using Domain.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Domain.Serializer
{
    public class CustomSerializer : ISerializer
    {
        public void Serialize<T>(Stream stream, T obj) where T : class
        {
            using (var streamWriter = new StreamWriter(stream))
            {
                foreach (var drink in (IEnumerable)obj)
                {
                    var drinkType = drink.GetType();
                    var properties = drinkType.GetProperties();

                    streamWriter.WriteLine(drinkType.FullName);

                    foreach (var property in properties)
                    {
                        WriteProperty(property, drink, streamWriter);
                    }
                }
            }
        }

        public T Deserialize<T>(Stream stream) where T : class
        {
            var drinks = new List<Drink>();

            int drinkCounter = -1;

            using (var streamReader = new StreamReader(stream))
            {
                string typeName;
                string propertyKey;
                string propertyValue;

                bool isBottle = false;

                string readedData;

                while (true)
                {
                    readedData = streamReader.ReadLine();

                    if (readedData == null)
                    {
                        break;
                    }

                    var dataArray = readedData.Split('|');

                    if (dataArray.Length < 2)
                    {
                        typeName = readedData;
                        drinks.Add((Drink)Activator.CreateInstance(Type.GetType(typeName)));
                        drinkCounter++;
                        isBottle = false;
                    }
                    else
                    {
                        propertyKey = dataArray[0];
                        propertyValue = dataArray[1];

                        PropertyInfo propertyInfo;

                        propertyInfo = isBottle ? drinks[drinkCounter].Bottle.GetType().GetProperty(propertyKey)
                            : drinks[drinkCounter].GetType().GetProperty(propertyKey);

                        if (propertyInfo != null)
                        {
                            SetPropertyValue(propertyInfo, drinks[drinkCounter],
                                ref isBottle, propertyValue);
                        }
                    }
                }
            }

            return drinks as T;
        }

        private void WriteProperty(PropertyInfo property, object obj, StreamWriter streamWriter)
        {
            if (property.PropertyType == typeof(string)
                || property.PropertyType == typeof(int)
                || property.PropertyType == typeof(float)
                || property.PropertyType == typeof(decimal)
                || property.PropertyType == typeof(DateTime))
            {
                streamWriter.WriteLine($"{property.Name}|{property.GetValue(obj)}");

                return;
            }

            if (property.PropertyType.IsClass)
            {
                streamWriter.WriteLine($"{property.Name}|");
                var properties = property.PropertyType.GetProperties();
                foreach (var _property in properties)
                {
                    WriteProperty(_property, property.GetValue(obj), streamWriter);
                }

                return;
            }
        }

        private void SetPropertyValue(PropertyInfo propertyInfo, Drink drink,
            ref bool isBottle, string value)
        {
            var propertyType = propertyInfo.PropertyType;

            if (propertyType == typeof(string) && !isBottle)
            {
                propertyInfo.SetValue(drink, value);
            }
            else if (propertyType == typeof(decimal) && !isBottle)
            {
                propertyInfo.SetValue(drink, decimal.Parse(value));
            }
            else if (propertyType == typeof(float) && !isBottle)
            {
                propertyInfo.SetValue(drink, float.Parse(value));
            }
            else if (propertyType == typeof(int) && !isBottle)
            {
                propertyInfo.SetValue(drink, int.Parse(value));
            }
            else if (propertyType == typeof(DateTime) && !isBottle)
            {
                propertyInfo.SetValue(drink, DateTime.Parse(value));
            }
            else if (propertyType == typeof(Bottle) && !isBottle)
            {
                propertyInfo.SetValue(drink, new Bottle());
                isBottle = true;
            }
            else if (propertyType == typeof(int) && isBottle)
            {
                propertyInfo.SetValue(drink.Bottle, int.Parse(value));
            }
            else if (propertyType == typeof(string) && isBottle)
            {
                propertyInfo.SetValue(drink.Bottle, value);
            }
            else
            {
                throw new ArgumentException("This type was not found!");
            }
        }
    }
}
