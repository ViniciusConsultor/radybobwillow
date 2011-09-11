using System;
using System.Collections.Generic;
using System.Reflection;

namespace Com.GainWinSoft.Common
{
    public partial class PropertiesCopier
    {
        public static void CheckRecursiveDifferentTypes(object wasSource, object wasDestination)
        {
            var count = 1;

            CheckRecursiveDifferentTypes(wasDestination, wasSource, null, ref count);

            Console.WriteLine();
            Console.WriteLine("Counted: " + (count - 1));
            Console.WriteLine();
        }

        private static string LastPart(Type t)
        {
            var split = t.ToString().Split(new[] { "." }, StringSplitOptions.RemoveEmptyEntries);
            var name = split[split.Length - 1];

            //hack this code is here just because we prefixed our classes w/ 'V1' and 'V2'
            //in case of a web service, only the namespace is changed
            return name.Replace("V1", "").Replace("V2", "");
        }

        private static void CheckRecursiveDifferentTypes(object wasDestination, object wasSource, IList<String> propertiesToOmmit, ref int count)
        {
            var wasDestinationType = wasDestination.GetType();
            var wasDestinationTypeName = wasDestinationType.Name;

            //if (wasSource != null)
            //    Assert.AreEqual(LastPart(wasDestinationType), LastPart(wasSource.GetType()));

            var properties = wasDestinationType.GetProperties();

            //for a type coming from a serialized web service type
            if (propertiesToOmmit == null)
                propertiesToOmmit = new List<string> { "ExtensionData" };

            foreach (var propertInfo in properties)
            {
                var property = propertInfo;

                if (propertiesToOmmit.Contains(property.Name))
                    continue;

                var wasDestinationValue = property.GetValue(wasDestination, null);

                var wasSourceValue = property.PropertyType.IsValueType ? Activator.CreateInstance(property.PropertyType) : null;

                PropertyInfo propertyInSource;

                //source is null
                if (wasSource != null)
                {
                    propertyInSource = wasSource.GetType().GetProperty(property.Name);

                    //wasSource has the property
                    if (propertyInSource != null)
                        wasSourceValue = propertyInSource.GetValue(wasSource, null);
                    else 
                        Console.WriteLine("\tsource does not contain property " + wasDestinationTypeName + " -> " + property.Name);
                }
                //else
                //  Console.WriteLine("\tsource was null for " + wasDestinationTypeName + " -> " + property.Name);


                //it's a complex/container type?
                var isComplex = !property.PropertyType.ToString().StartsWith("System");

                if (isComplex & !property.PropertyType.IsArray)
                {
                    Console.WriteLine("\tRecursion on: " + property.Name);

                    CheckRecursiveDifferentTypes(wasDestinationValue, wasSourceValue, propertiesToOmmit, ref count);
                    continue;
                }


                var s = string.Format(count + ". {0,-30} = {1}", wasDestinationTypeName + "." + property.Name, wasSourceValue);
                Console.WriteLine(s);

                count++;

                ////todo deep assert for arrays
                //if (!property.PropertyType.IsArray)
                //    Assert.AreEqual(wasDestinationValue, wasSourceValue, "Assert failed for property: " + wasDestinationTypeName + "." + property.Name);
            }
        }
    }
}
