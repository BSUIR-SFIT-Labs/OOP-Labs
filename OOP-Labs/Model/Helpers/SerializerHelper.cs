using Domain.Serializer;

namespace Domain.Helpers
{
    public class SerializerHelper
    {
        public string Filter { get; }
        public ISerializer Serializator { get; }

        public SerializerHelper(string filter, ISerializer serializator)
        {
            Filter = filter;
            Serializator = serializator;
        }
    }
}
