using Domain.Serializer;
using Plugin;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Services
{
    public class PluginService
    {
        public Dictionary<string, ISerializer> Serializers { get; set; }

        public Dictionary<string, IPlugin> Plugins { get; set; }

        public ISerializer SelectedSerializer { get; set; }

        public IPlugin SelectedPlugin { get; set; }

        public PluginService(Dictionary<string, ISerializer> serializers,
            Dictionary<string, IPlugin> plugins)
        {
            serializers = serializers.Where(s => !(s.Value is SerializerWithPlugins)).ToDictionary(s => s.Key, s => s.Value);

            Serializers = serializers;
            Plugins = plugins;

            SelectedSerializer = Serializers.ElementAtOrDefault(0).Value;
            SelectedPlugin = Plugins.ElementAtOrDefault(0).Value;
        }
    }
}
