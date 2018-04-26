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
    public class ProjectWindow : WindowObjects
    {
        #region Controls
        private TextBox Name => TextBox(0);
        private TextBox Price => TextBox(1);
        private Button Ok => Button("OK");
        #endregion

        public ProjectWindow(Window window)
            : base(window)
        {

        }
        
        public ProjectWindow SetName(string name)
        {
            Name.Text = name;
            return this;
        }

        public ProjectWindow SetPrice(int price)
        {
            Price.Text = price.ToString();
            return this;
        }

        public void Save()
        {
            Ok.Click();
        }
    }
}
