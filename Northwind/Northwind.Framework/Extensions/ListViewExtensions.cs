using System.Collections.Generic;
using System.Linq;
using TestStack.White.UIItems;

namespace Northwind.Framework.Extensions
{
    public static class ListViewExtensions
    {
        public static bool Contains(this ListView listView,
            ObjectInGrid objectInGrid)
        {
            foreach (var row in listView.Rows)
            {
                if (DataMatch(row, objectInGrid))
                {
                    return true;
                }
            }

            return false;
        }

        private static bool DataMatch(ListViewRow row,
            ObjectInGrid objectInGrid)
        {
            foreach (KeyValuePair<string, string> values
                in objectInGrid.Values)
            {
                if (row.Cells[values.Key].Text != values.Value)
                {
                    return false;
                }
            }

            return true;
        }
    }

    public class DepartmentInGrid : ObjectInGrid
    {
        public DepartmentInGrid(string name) : base(name)
        {
            
        }
    }
    
    public class ProjectInGrid : ObjectInGrid
    {
        public ProjectInGrid(string project, int price) :
            base(project)
        {
            _values["Price"] = price.ToString("C0");
        }
    }

    public class EmployeeInGrid : ObjectInGrid
    {
        public EmployeeInGrid(string firstName, string lastName, string depto) :
            base(null)
        {
            _values["First Name"] = firstName;
            _values["Last Name"] = lastName;
            _values["Department"] = depto;
        }
    }

    public class ObjectInGrid
    {
        protected Dictionary<string, string> _values =
            new Dictionary<string, string>();
        public Dictionary<string, string> Values
        {
            get { return 
                  _values.Where(x => x.Value != null)
                  .ToDictionary(x => x.Key, x => x.Value);
                }
        }

        public ObjectInGrid(string name)
        {
            _values["Name"] = name;
        }
    }
}
