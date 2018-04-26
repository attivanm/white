using Northwind.Framework.Windows;
using System;
using System.Configuration;
using System.Linq;
using TestStack.White;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.Utility;

namespace Northwind.Framework.Engine
{
    public static class WindowRepository
    {
        private static Application _application;

        //Windows
        public static MainWindow Main
            => new MainWindow(GetWindow("Northwind"));

        public static DepartmentWindow Department
            => new DepartmentWindow(GetWindow("New department"));

        public static ProjectWindow Project
            => new ProjectWindow(GetWindow("New project"));

        private static Window GetWindow(string title)
        {
            return Retry.For(
               () => _application.GetWindows().First(
                   x => x.Title.Contains(title)),
                   TimeSpan.FromSeconds(5)
                );
        }

        //Title for this window: New Employee
        public static NewEmployeeWindow NewEmployee => new NewEmployeeWindow(GetWindow("New employee"));
        //Title for this window: Employee
        public static EmployeeWindow Employee => new EmployeeWindow(GetWindow("Employee:"));
        //Title for this window: Change Department
        public static ChangeDepartmentWindow ChangeDepartment => new ChangeDepartmentWindow(GetWindow("Change department"));
        public static void Init()
        {
            //Aplication initializer
            _application =
            Application
            .Launch(ConfigurationManager.AppSettings["NorthwindPath"]);
        }

        public static void Close()
        {
            _application.Kill();
        }
    }
}
