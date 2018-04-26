using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.WindowItems;

namespace Northwind.Framework.Engine
{
    public abstract class WindowObjects
    {
        private Window _window;

        protected WindowObjects(Window window)
        {
            _window = window;
        }

        protected TextBox TextBox(int index = 0)
        {
            return _window.Get<TextBox>(SearchCriteria.Indexed(index));
        }

        protected Button Button(string text)
        {
            return 
                _window.Get<Button>(SearchCriteria.ByText(text));
        }

        protected ListBox ListBox()
        {
            return _window.Get<ListBox>();
        }

        protected ListView ListView()
        {
            return _window.Get<ListView>();
        }

        protected RadioButton RadioButton(int index = 0)
        {
            return _window.Get<RadioButton>(SearchCriteria.Indexed(index));
        }

        protected RadioButton RadioButton(string automationId)
        {
            return _window.Get<RadioButton>(SearchCriteria.ByAutomationId(automationId));
        }
    }
}
