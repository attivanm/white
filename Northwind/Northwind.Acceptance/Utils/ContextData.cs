using Northwind.Acceptance.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Acceptance.Utils
{
    public class ContextData
    {
        public DepartmentDto DepartmentDto { get; set; }
        public IEnumerable<DepartmentDto> DepartmentDtos { get; set; }


    }
}
