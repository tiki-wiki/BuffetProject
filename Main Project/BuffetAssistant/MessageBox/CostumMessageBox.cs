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
        private static Window1 window1;
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
            Warning
        }
        public static int Show(string text)
        {
            window1 = new Window1(text);
            window1.Show();
            return -1;
        }
        public static void Show(string text, string caption, MessageIcons messageIcon, MessageButtons messageButtons)
        {
            window1 = new Window1(text, caption, messageIcon, messageButtons);
            window1.Show();
        }
    }
}
