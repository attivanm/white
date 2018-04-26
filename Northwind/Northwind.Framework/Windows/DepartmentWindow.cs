using Northwind.Framework.Engine;
using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;

namespace Northwind.Framework.Windows
{
    public class DepartmentWindow : WindowObjects
    {
        #region Controls
        private TextBox Name => TextBox();
        private Button Ok => Button("OK");
        #endregion

        internal DepartmentWindow(Window window)
            : base(window)
        {
        }

        public void CreateDepartment(string name)
        {
            //Set depto name
            Name.Text = name;

            //Save
            Ok.Click();
        }
    }
}
