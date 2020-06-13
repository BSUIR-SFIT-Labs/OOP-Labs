using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Domain.Helpers
{
    public static class ModelHelper
    {
        private const string DomainAssembly = "Domain.dll";
        private const string ModelNamespace = "Domain.Model";
        private const string BottleClass = "Bottle";

        public static List<Type> GetAllModelTypes()
        {
            var assembly = Assembly.LoadFrom(DomainAssembly);
            var modelTypes = assembly.GetTypes().Where(
                type => type.IsClass
                && !type.IsAbstract
                && type.FullName.Contains(ModelNamespace)
                && !type.FullName.Contains(BottleClass)).ToList();

            return modelTypes;
        }
    }
}
