using Northwind.Acceptance.Dtos;
using Northwind.Acceptance.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Northwind.Acceptance.Steps
{
    [Binding]
    public sealed class EmployeeSteps
    {
        private ContextData _contextData;

        public EmployeeSteps(ContextData contextData)
        {
            _contextData = contextData;
        }

        [Given(@"I have a department")]
        public void GivenIHaveADepartment()
        {
            //create Department
        }

        [When(@"I create an employee using the following values:")]
        public void WhenICreateAnEmployeeUsingTheFollowingValues(Table table)
        {
            var department = _contextData.DepartmentDto;
            var employee = table.CreateInstance<EmployeeDto>();
        }

        [Then(@"it should appear in the employee grid")]
        public void ThenItShouldAppearInTheEmployeeGrid()
        {

        }

        [When(@"I create several employees using the following values:")]
        public void WhenICreateSeveralEmployeesUsingTheFollowingValues(Table table)
        {
           var employees = table.CreateSet<EmployeeDto>();
        }


    }
}
