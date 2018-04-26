using Northwind.Framework.Engine;
using Northwind.Tests.Base;
using Northwind.Utils;
using NUnit.Framework;

namespace Northwind.Tests.Departments
{
    [TestFixture]
    public class DepartmentTests : BaseTest
    {
        [Category("Department")]
        [Category("High")]
        [Category("Level2")]
        [Test]
        public void Can_Create_a_Department()
        {
            //Variables
            var depto = DataGenerator.Name;

            //Test Steps
            WindowRepository.Main.AddDepartment();
            WindowRepository.Department.CreateDepartment(depto);

            //Validation
            Assert.IsTrue(
                WindowRepository.Main.IsDepartmentInGrid(depto));
        }
    }
}
