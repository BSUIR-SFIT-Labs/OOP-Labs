using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Plugin
{
    public static class PluginLoader
    {
        public static IEnumerable<IPlugin> LoadPlugins(string directory)
        {
            string[] pluginFiles = Directory.GetFiles(directory, "*.dll");

            var plugins = new List<IPlugin>();

            foreach (string pluginPath in pluginFiles)
            {
                Type[] types = null;

                var assembly = Assembly.LoadFrom(pluginPath);
                if (assembly != null)
                {
                    types = assembly.GetTypes()?.Where(type => type.GetInterface(typeof(IPlugin).Name) != null).ToArray();
                }

                if (types != null)
                {
                    foreach (var type in types)
                    {
                        plugins.Add((IPlugin)Activator.CreateInstance(type));
                    }
                }
            }

            return plugins;
        }
    }
}
