using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Documents;
using EksamensProject.Classes;

namespace EksamensProject.Classes
{
    public static class DatasetToList
    {
        //IList represents a non-generic collection of objects that can be individually accessed by index.
        //PropertyInfo discovers the attributes of a property and provides access to property metadata.
        //Typeof represents type declarations: class types, interface types, array types, value types, enumeration types, type parameters, generic type definitions, and open or closed constructed generic types.
        public static List<T> ToList<T>(this DataTable table) where T : new()
        {
            IList<PropertyInfo> properties = typeof(T).GetProperties().ToList();
            List<T> result = new List<T>();

            foreach (var row in table.Rows)
            {
                var item = CreateItemFromRow<T>((DataRow)row, properties);
                result.Add(item);
            }

            return result;
        }

        //enum provides the base class for enumerations.
        //enumeration: the action of mentioning a number of things one by one.
        //DBNull represents a nonexistent value. This class cannot be inherited.
        public static T CreateItemFromRow<T>(DataRow row, IList<PropertyInfo> properties) where T : new()
        {
            T item = new T();

            foreach (var property in properties)
            {
                if (property.PropertyType == typeof(System.DayOfWeek))
                {
                    DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), row[property.Name].ToString());
                    property.SetValue(item, day, null);
                }
                else
                {
                    if (row[property.Name] == DBNull.Value)
                        property.SetValue(item, null, null);
                    else
                        property.SetValue(item, row[property.Name], null);
                }
            }

            return item;
        }
    }
}
