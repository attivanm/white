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

namespace Northwind.Tests.Projects
{
    [TestFixture]
    public class ProjectTests : BaseTest
    {
        [Test]
        public void Can_create_a_project()
        {
            //Variables
            var projectName = DataGenerator.Name;
            var price = DataGenerator.Number;

            //Test Steps
            WindowRepository.Main.AddProject();
            WindowRepository.Project
                .SetName(projectName)
                .SetPrice(price)
                .Save();

            //Validation
            Assert.IsTrue(
                WindowRepository.Main.IsProjectInGrid(projectName,
                                                      price));
        }
    }
}
