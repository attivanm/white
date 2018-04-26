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
    public class EmployeeWindow : WindowObjects
    {
        #region controls
        private Button CancelButton => Button("Cancel");
        #endregion
        internal EmployeeWindow(Window window)
            : base(window)
        {

        }

        public void Cancel()
        {
            CancelButton.Click();
        }




    }
}
