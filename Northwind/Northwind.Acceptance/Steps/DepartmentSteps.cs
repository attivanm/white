using Northwind.Acceptance.Dtos;
using Northwind.Acceptance.Extensions;
using Northwind.Acceptance.Utils;
using Northwind.Framework.Engine;
using Northwind.Utils;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Northwind.Acceptance.Steps
{
    [Binding]
    public sealed class DepartmentSteps
    {
        private string _departmentName;
        private ContextData _contextData;

        public DepartmentSteps(ContextData contextData)
        {
            _contextData = contextData;
        }

        [When(@"I create a department")]
        public void WhenICreateADepartment()
        {
            _departmentName = DataGenerator.Name;

            //Test Steps
            WindowRepository.Main.AddDepartment();
            WindowRepository.Department.CreateDepartment(_departmentName);
        }

        [Then(@"it should appear in the department grid")]
        public void ThenItShouldAppearInTheDepartmentGrid()
        {
            //Validation
            Assert.IsTrue(
                WindowRepository.Main.IsDepartmentInGrid(_departmentName));
        }

        [Given(@"I have a department using the following values:")]
        public void GivenIHaveADepartmentUsingTheFollowingValues(Table table)
        {
            
            var department = table.BuildInstance<DepartmentDto>();
            _contextData.DepartmentDto = department;
        }

        [Given(@"I have the following Department created:")]
        public void GivenIHaveTheFollowingDepartmentCreated(Table table)
        {
            var departments = table.CreateSet<DepartmentDto>();
            _contextData.DepartmentDtos = departments;
        }


    }
}
