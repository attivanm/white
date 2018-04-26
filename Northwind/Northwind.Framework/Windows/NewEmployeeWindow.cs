using Northwind.Framework.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;

namespace Northwind.Framework.Windows
{
    public class NewEmployeeWindow : WindowObjects
    {
        #region controls
        private TextBox FirstName => TextBox();
        private TextBox LastName => TextBox(1);
        private RadioButton FullTime => RadioButton();
        private RadioButton PartTime => RadioButton(1);
        private TextBox About => TextBox(2);
        private Button ChangeDepartment => Button("Change");
        private Button Ok => Button("OK");
        #endregion
        internal NewEmployeeWindow(Window window)
            : base(window)
        {

        }

        public NewEmployeeWindow SetFirstName(String firstName)
        {
            FirstName.Text = firstName;
            return this;
        }

        public NewEmployeeWindow setLastName(String lastName)
        {
            LastName.Text = lastName;
            return this;
        }

        public NewEmployeeWindow SetEmploymentType(EmploymentType type)
        {
            switch (type) {
                case EmploymentType.FullTime:
                    FullTime.Select();
                    break;
                case EmploymentType.PartTime:
                    FullTime.Select();
                    break;
                default:
                    throw new ArgumentException("Error message ....");
            }       
            return this;
        }

        public NewEmployeeWindow SetAbout(string about)
        {
            About.Text = about;
            return this;
        }

        public NewEmployeeWindow SetDepartment(string depto)
        {
            ChangeDepartment.Click();
            WindowRepository.ChangeDepartment.SelectDepartment(depto);
            return this;
        }

        public void Save()
        {
            Ok.Click();
        }
    }

  
}
