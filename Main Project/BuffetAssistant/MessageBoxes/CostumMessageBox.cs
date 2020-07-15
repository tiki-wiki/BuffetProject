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
            Error,
            Exclamation,
            Information,
            Question,
            Warning
        }
        public static int ShowDialog()
        {
            return -1;
        }
        public static int Show(string text)
        {
            return -1;
        }
        public static string Show(string text, string caption)
        {
            return Show(text,caption);
        }
        public static string Show(string text, string caption, MessageButtons messageButtons)
        {
            return Show(text, caption,messageButtons);
        }
        public static string Show(string text, string caption, MessageButtons messageButtons,MessageIcons messageIcon)
        {
            return Show(text, caption, messageButtons,messageIcon);
        }
    }
}
