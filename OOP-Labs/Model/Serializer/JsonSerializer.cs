using Newtonsoft.Json;
using System.IO;

namespace Domain.Serializer
{
    public class JsonSerializer : ISerializer
    {
        public void Serialize<T>(Stream stream, T obj) where T : class
        {
            using (var streamWriter = new StreamWriter(stream))
            using (var jsonTextWriter = new JsonTextWriter(streamWriter))
            {
                var serializer = new Newtonsoft.Json.JsonSerializer
                {
                    TypeNameHandling = TypeNameHandling.All
                };

                serializer.Serialize(jsonTextWriter, obj, typeof(T));
            }
        }

        public T Deserialize<T>(Stream stream) where T : class
        {
            T deserializationResult;

            using (var streamReader = new StreamReader(stream))
            using (var jsonTextReader = new JsonTextReader(streamReader))
            {
                var serializer = new Newtonsoft.Json.JsonSerializer
                {
                    TypeNameHandling = TypeNameHandling.All
                };

                deserializationResult = serializer.Deserialize<T>(jsonTextReader);
            }

            return deserializationResult;
        }
    }
}
