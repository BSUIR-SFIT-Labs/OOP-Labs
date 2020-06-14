using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Domain.Serializer
{
    class BinarySerializer : ISerializer
    {
        public void Serialize<T>(Stream stream, T obj) where T : class
        {
            var serializer = new BinaryFormatter();
            serializer.Serialize(stream, obj);
        }

        public T Deserialize<T>(Stream stream) where T : class
        {
            var serializer = new BinaryFormatter();
            return serializer.Deserialize(stream) as T;
        }
    }
}
