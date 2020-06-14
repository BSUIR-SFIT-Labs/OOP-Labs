using System.IO;

namespace Domain.Serializer
{
    public interface ISerializer
    {
        void Serialize<T>(Stream stream, T obj) where T : class;

        T Deserialize<T>(Stream stream) where T : class;
    }
}
