using Northwind.Framework.Engine;
using Northwind.Framework.Windows;
using Northwind.Tests.Base;
using Northwind.Utils;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Tests.Employees
{
    [TestFixture]
    public class EmployeeTests : BaseTest
    {
        [Test]
        public void Can_Create_Employee()
        {
            //Variables
            var departmentName = DataGenerator.Name;

            //Preconditions
            var depto = DataGenerator.Name;

            //Test Steps
            WindowRepository.Main.AddDepartment();
            WindowRepository.Department.CreateDepartment(depto);
            //DB - YES using EF (Entity Framework)
            //Rest - No tiene
            //Test Steps
            WindowRepository.Main.AddEmployee();
            WindowRepository.NewEmployee
                .SetFirstName("Gonzalo")
                .setLastName("Alba")
                .SetEmploymentType(EmploymentType.FullTime)
                .SetAbout("About me ...")
                .SetDepartment(depto)
                .Save();

            WindowRepository.Employee.Cancel();

            Assert.IsTrue(WindowRepository.Main.IsEmployeeInGrid("Gonzalo","Alba", depto), "Created Employee is not in the grid.");

        }
    }
}
