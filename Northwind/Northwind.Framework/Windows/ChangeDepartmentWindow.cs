using Northwind.Framework.Engine;
using TestStack.White.UIItems;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.WindowItems;

namespace Northwind.Framework.Windows
{
    public class ChangeDepartmentWindow : WindowObjects
    {
        #region controls
        private ListBox DepartmentList => ListBox();
        private Button Ok => Button("OK");
        #endregion
        internal ChangeDepartmentWindow(Window window)
            : base(window)
        {

        }

        public void SelectDepartment(string depto)
        {
            DepartmentList.Items.Select(depto);
            Ok.Click();
        }
    }
}
