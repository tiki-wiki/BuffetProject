using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BuffetAssistant.MessageBoxes
{
    public class CostumMessageBox
    {
        private static Window1 messageBoxWindow;
        public enum MessageButtons
        {
            YesNoCancel,
            OK
        }
        public enum MessageResult
        {
            Yes,
            No,
            Cancel,
            OK
        }
        public enum MessageIcons
        {
            Error,
            Exclamation,
            Information,
            Question,
            Warning,
            OK
        }
        public static int Show(string text)
        {
            messageBoxWindow = new Window1(text);
            messageBoxWindow.ShowDialog();
            return 1;
        }

        public static void Show(string text, string caption, MessageIcons messageIcon, MessageButtons messageButtons)
        {
            messageBoxWindow = new Window1(text, caption, messageIcon, messageButtons);
            messageBoxWindow.ShowDialog();
        }
    }
}
