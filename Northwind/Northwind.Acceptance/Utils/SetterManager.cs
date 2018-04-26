using Northwind.Utils;
using System;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Northwind.Acceptance.Utils
{
    public static class SetterManager
    {
        public static string Set(string value)
        {
            if (value.StartsWith("DataGenerator"))
            {
                var res = Convert.ToString(GetPropertyValue(value));
                return res;
            }
            if (value.StartsWith("InfoManager"))
            {
                var res = Convert.ToString(GetPropertyValue(value));
                return res;
            }

            if (value.Equals("TODAY"))
            {
                return DateTime.Now.ToString();
            }

            if (value.Equals("TOMORROW"))
            {
                return DateTime.Now.AddDays(+1).ToString();
            }

            if (value.Equals("YESTERDAY"))
            {
                return DateTime.Now.AddDays(-1).ToString();
            }

            return value;
        }

        private static object GetPropertyValue(string value)
        {
            Type type = null;
            string propertyName = value;
            string sufix = string.Empty;
            // case& 
            if (Regex.IsMatch(value, "&"))
            {
                propertyName = value.Split('&')[0];
                sufix = value.Split('&')[1];
            }else
            {
                propertyName = value;
            }
            //Get class and property name
            string className = propertyName.Split('.')[0];
            propertyName = propertyName.Split('.')[1];

            switch (className)
            {
                case "DataGenerator":
                    type = typeof(DataGenerator);
                    break;
                case "InfoManager":
                    type = typeof(InfoManager);
                    break;
            }
            var propInfo = type?.GetProperty(propertyName, BindingFlags.Public | BindingFlags.Static);
            if (string.IsNullOrEmpty(sufix))
            {
                return propInfo?.GetValue(null) + sufix;
            }

            return propInfo?.GetValue(null);
        }
    }
}
