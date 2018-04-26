using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Acceptance.Dtos
{
    public class EmployeeDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmployeeType { get; set; }
        public string About { get; set; }
        public string DepartamentName
        {
            get { return _departmentName; } 
            set {
                //_departmentName; 
            }
        }

        public string _departmentName;
        
    }
}
