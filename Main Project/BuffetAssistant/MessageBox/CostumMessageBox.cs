using MaterialDesignThemes.Wpf;
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
            YesNo,
            OKCancel,
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

        public static CostumMessageBox.MessageResult Show(string text, string caption, MessageIcons messageIcon, MessageButtons messageButtons)
        {
            messageBoxWindow = new Window1(text, caption, messageIcon, messageButtons);
            messageBoxWindow.ShowDialog();

            //cheking idalog result

            if (messageButtons == MessageButtons.YesNo)
            {

                if (messageBoxWindow.dialogCode == "Yes")
                    return MessageResult.Yes;
                else
                    return MessageResult.No;
            }

            else if (messageButtons == MessageButtons.OKCancel)
            {

                if (messageBoxWindow.dialogCode == "Ok")
                    return MessageResult.OK;
                else
                    return MessageResult.Cancel;
            }

            else
                return 0;
        }
    }
}
