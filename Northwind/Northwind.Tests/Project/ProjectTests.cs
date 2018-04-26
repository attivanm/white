using Northwind.Framework.Windows;
using Northwind.Tests.Base;
using Northwind.Utils;
using NUnit.Framework;

namespace Northwind.Tests.Project
{
    [TestFixture]
    public class ProjectTests : BaseTest
    {
        [Test]
        public void Can_Create_a_Project()
        {
            //variables
            var projectName = DataGenerator.Name;
            var price = DataGenerator.Number;
            //test steps
            WindowRepository.Main.AddProject();
            WindowRepository.Project
                .SetName(projectName)
                .SetPrice(price)
                .Save();

            //validation
            Assert.IsTrue(WindowRepository.Main.IsProjectInGrid(projectName, price));
        }
    }
}
