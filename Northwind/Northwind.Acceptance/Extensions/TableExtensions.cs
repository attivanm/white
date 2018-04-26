using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Northwind.Acceptance.Extensions
{
    public static class TableExtensions
    {
        public static IEnumerable<T> Build<T>(this Table table)
        {
            return table.CreateSet<T>();
        }

        public static T BuildInstance<T>(this Table table)
        {
            return table.CreateInstance<T>();
        }

        public static TableTemplate BuildTemplate(this Table table)
        {
            return table.CreateInstance<TableTemplate>();
        }

        public static List<string> BuildList(this Table table)
        {
            var final = new List<string>();
            foreach (var row in table.Rows)
            {
                final.AddRange(row.Values);
            }
            return final;
        }

        public class TableTemplate
        {
            public string Field { get; set; }
            public string Value { get; set; }

        }


    }
}
