using Northwind.Acceptance.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Acceptance.Dtos
{
    public class DepartmentDto
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = SetterManager.Set(value); }
        }

    }
}
