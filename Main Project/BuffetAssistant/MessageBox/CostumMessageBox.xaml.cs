using BuffetAssistant.MessageBoxes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BuffetAssistant
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        //constructor 1
        public Window1(string text)
        {
            InitializeComponent();
            //initial MessageBox Text
            messageLabel.Text = text;
        }

        //constructor 2
        public Window1(string text, string caption, CostumMessageBox.MessageIcons icon,CostumMessageBox.MessageButtons buttons)
        {
            //initial MessageBox Text
            messageLabel.Text = text;

            //initial MessageBox Caption
            captionLabel.Text = caption;

            //Initial MessageBox Icon
            switch (icon)
            {
                case CostumMessageBox.MessageIcons.Error:
                    messageBoxIcon.Source = GetImageSource(@"D:\Temp\BuffetProject\Main Project\BuffetAssistant\Assets\Icons\MessageBoxIcons\Error.png");
                    break;
                case CostumMessageBox.MessageIcons.Exclamation:
                    messageBoxIcon.Source = GetImageSource(@"D:\Temp\BuffetProject\Main Project\BuffetAssistant\Assets\Icons\MessageBoxIcons\Exclamation.png");
                    break;
                case CostumMessageBox.MessageIcons.Information:
                    messageBoxIcon.Source = GetImageSource(@"D:\Temp\BuffetProject\Main Project\BuffetAssistant\Assets\Icons\MessageBoxIcons\Information.png");
                    break;
                case CostumMessageBox.MessageIcons.Question:
                    messageBoxIcon.Source = GetImageSource(@"D:\Temp\BuffetProject\Main Project\BuffetAssistant\Assets\Icons\MessageBoxIcons\Question.png");
                    break;
                case CostumMessageBox.MessageIcons.Warning:
                    messageBoxIcon.Source = GetImageSource(@"D:\Temp\BuffetProject\Main Project\BuffetAssistant\Assets\Icons\MessageBoxIcons\warning.png");
                    break;
            }

            //initial button
            switch (buttons)
            {
                case CostumMessageBox.MessageButtons.YesNoCancel:
                    yesBTN.Visibility = Visibility.Visible;
                    noBTN.Visibility = Visibility.Visible;
                    cancelBTN.Visibility = Visibility.Visible;

                    okBTN.Visibility = Visibility.Hidden;
                    break;
                case CostumMessageBox.MessageButtons.OK:
                    okBTN.Visibility = Visibility.Visible;

                    yesBTN.Visibility = Visibility.Hidden;
                    noBTN.Visibility = Visibility.Hidden;
                    cancelBTN.Visibility = Visibility.Hidden;
                    break;
            }
        }

        //imageSorce Converter
        public static ImageSource GetImageSource(string path)
        {
            BitmapImage iconSource = new BitmapImage();
            iconSource.BeginInit();
            iconSource.UriSource = new Uri(path);
            iconSource.EndInit();
            return iconSource;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void controlArea_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        DoubleAnimation animation;
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //fade closing
            Closing -= Window_Closing;
            e.Cancel = true;
            animation = new DoubleAnimation(0, (Duration)TimeSpan.FromMilliseconds(330));
            animation.Completed += Animation_Completed;
            this.BeginAnimation(UIElement.OpacityProperty, animation);
        }

        private void Animation_Completed(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
