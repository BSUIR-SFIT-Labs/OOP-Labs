using Domain.Helpers;
using Domain.Model;
using Domain.Serializer;
using Plugin;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Domain.Services
{
    [Serializable]
    public class ModelService
    {
        public List<Drink> Drinks { get; private set; }

        public List<SerializerHelper> Serializers { get; set; }

        public ISerializer LastSerializer { get; set; }

        public string LastFile { get; set; }

        public ModelService()
        {
            Drinks = new List<Drink>();

            Serializers = new List<SerializerHelper>()
            {
                new SerializerHelper("Binary file (*.bin)|*.bin", new BinarySerializer()),
                new SerializerHelper("JSON file (*.json)|*.json", new JsonSerializer()),
                new SerializerHelper("CSER file (*.cser)|*.cser", new CustomSerializer())
            };

            var serializersWithPlugins = LoadSerializerWithPlugins(Serializers.Select(f => f.Serializator));

            Serializers.Add(new SerializerHelper("File processed by the plugin (*.fpbp)|*.fpbp",
                serializersWithPlugins));
        }

        public void AddDrink(Drink drink)
        {
            Drinks.Add(drink);
        }

        public void AddDrinks(List<Drink> drinks)
        {
            Drinks.Clear();

            foreach (var drink in drinks)
            {
                Drinks.Add(drink);
            }
        }

        private SerializerWithPlugins LoadSerializerWithPlugins(IEnumerable<ISerializer> serializers)
        {
            const string DirectoryWithPlugins = "Plugins";

            var pathToPlugins = Path.Combine(Environment.CurrentDirectory, DirectoryWithPlugins);

            var plugins = new List<IPlugin>(PluginLoader.LoadPlugins(pathToPlugins))
            {
                new EmptyPlugin()
            };

            return new SerializerWithPlugins(serializers, plugins);
        }
    }
}
