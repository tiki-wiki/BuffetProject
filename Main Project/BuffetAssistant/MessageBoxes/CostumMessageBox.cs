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
        public enum MessageButtons
        {
            Yes,
            No,
            Cancel,
            Retry,
            OK
        }
        public enum MessageIcons
        {

        }
        public static string Show(string text)
        {
            return Show(text);
        }
        public static string Show(string text, string caption)
        {
            return Show(text, caption);
        }
        public static string Show(string text, string caption, MessageButtons messageButtons)
        {
            return Show(text, caption,messageButtons);
        }
    }
}
