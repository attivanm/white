using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Utils
{
    public static class InfoManager
    {
        public static string DeptoName => "Depto" + TestCaseSufixValue();

        private static string TestCaseSufixValue()
        {
            return Environment.GetEnvironmentVariable("NorthwindSufixValue");
        }
    }
}
