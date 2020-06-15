using Plugin;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Domain.Serializer
{
    public class SerializerWithPlugins : ISerializer
    {
        public IEnumerable<ISerializer> Serializers { get; set; }

        public IEnumerable<IPlugin> Plugins { get; set; }

        public ISerializer SelectedSerializer { get; set; }

        public IPlugin SelectedPlugin { get; set; }

        public SerializerWithPlugins(IEnumerable<ISerializer> serializers,
            IEnumerable<IPlugin> plugins)
        {
            Serializers = serializers;
            Plugins = plugins;
        }

        public void Serialize<T>(Stream stream, T obj) where T : class
        {
            if (SelectedSerializer == null || SelectedPlugin == null)
            {
                throw new NullReferenceException();
            }

            if (SelectedSerializer is SerializerWithPlugins)
            {
                throw new Exception(nameof(SerializerWithPlugins));
            }

            using (var memoryStream = new MemoryStream())
            {
                SelectedSerializer.Serialize<T>(memoryStream, obj);

                var buffer = memoryStream.GetBuffer();
                buffer = SelectedPlugin.Modify(buffer);

                var serializerName = SelectedSerializer.GetType().AssemblyQualifiedName;
                var pluginName = SelectedPlugin.GetType().AssemblyQualifiedName;
                var infoStr = $"<{serializerName}><{pluginName}>";
                var infoData = Encoding.ASCII.GetBytes(infoStr);

                stream.Write(infoData, 0, infoData.Length);
                stream.Write(buffer, 0, buffer.Length);
            }
        }

        public T Deserialize<T>(Stream stream) where T : class
        {
            using (var binaryReader = new BinaryReader(stream, Encoding.ASCII))
            {
                int counter = 0;
                var stringBuilder = new StringBuilder();

                do
                {
                    var readedCharacter = binaryReader.ReadChar();
                    stringBuilder.Append(readedCharacter);

                    if (readedCharacter == '>')
                    {
                        counter++;
                    }
                }
                while (counter < 2);

                var informationData = stringBuilder.ToString();
                var informationArray = informationData.Split(new char[] { '<', '>' }, StringSplitOptions.RemoveEmptyEntries);

                var serializerType = Type.GetType(informationArray[0]);
                var serializer = Serializers.FirstOrDefault(s => s.GetType().IsEquivalentTo(serializerType));

                var pluginType = informationArray[1];
                var plugin = Plugins.FirstOrDefault(p => p.GetType().AssemblyQualifiedName == pluginType);

                if (serializer == null || plugin == null)
                {
                    throw new ArgumentNullException("Plugin not found!");
                }

                byte[] buffer;

                Stream dataStream = binaryReader.BaseStream;
                using (var ms = new MemoryStream())
                {
                    dataStream.CopyTo(ms);
                    buffer = ms.ToArray();
                }


                buffer = plugin.Demodify(buffer);

                using (var MS = new MemoryStream(buffer))
                {
                    return serializer.Deserialize<T>(MS);
                }
            }
        }
    }
}
