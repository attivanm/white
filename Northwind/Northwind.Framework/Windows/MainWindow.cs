using Northwind.Framework.Engine;
using Northwind.Framework.Extensions;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.WindowItems;

namespace Northwind.Framework.Windows
{
    public class MainWindow : WindowObjects
    {
        private Window _window;

        #region Controls
        private ListBox LeftMenu 
            => ListBox();
        private ListItem DepartmentTab 
            => LeftMenu.Item("Departments");
        private ListItem ProjectTab
           => LeftMenu.Item("Projects");
        private ListItem EmployeeTab
           => LeftMenu.Item("Employees");
        private Button Add =>
            Button("Add");
        private ListView Grid =>
            ListView();
        #endregion

        internal MainWindow(Window window) 
            : base(window)
        {
            _window = window;
        }

        public void AddDepartment()
        {
            //LeftMenu
            DepartmentTab.Select();

            //Add button
            Add.Click();
        }

        public void AddProject()
        {
            //LeftMenu
            ProjectTab.Select();

            //Add button
            Add.Click();
        }

        public void AddEmployee()
        {
            EmployeeTab.Select();
            Add.Click();
        }

        public bool IsDepartmentInGrid(string depto)
        {
            //LeftMenu
            DepartmentTab.Select();

            return Grid.Contains(new DepartmentInGrid(depto));
        }

        public bool IsProjectInGrid(string project, int price)
        {
            //LeftMenu
            ProjectTab.Select();

            return Grid.Contains(new ProjectInGrid(project, price));
            
        }

        public bool IsEmployeeInGrid(string firstName, string lastName, string depto)
        {
            EmployeeTab.Select();
            return Grid.Contains(new EmployeeInGrid(firstName, lastName, depto));
        }
    }
}
