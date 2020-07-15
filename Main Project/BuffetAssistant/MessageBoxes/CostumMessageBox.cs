using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BuffetAssistant.MessageBoxes
{
    class CostumMessageBox
    {
        public enum Buttons
        {
            Yes,
            No,
            Cancel,
            Retry,
            OK
        }
        public static string Show(string text,string Caption)
        {
            return Show(text, Buttons.OK);
        }
    }
}
