using BuffetAssistant.Classes;
using BuffetAssistant.MessageBoxes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BuffetAssistant
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void CloseCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Drag(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void minimizeBTN_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void orderBTN_Click(object sender, RoutedEventArgs e)
        {
            //chnage opacity
            OrderWindow orderWindow = new OrderWindow();
            mainGrid.Opacity = 0.4;
            this.Background.Opacity = 0.4;
            orderWindow.ShowDialog();

            if (orderWindow.WindowState == WindowState.Normal)
                mainGrid.Opacity = 1;
            this.Background.Opacity = 0.8;
        }

        private void settingBTN_Click(object sender, RoutedEventArgs e)
        {
            SettingWindow settingWindow = new SettingWindow();
            mainGrid.Opacity = 0.4;
            this.Background.Opacity = 0.4;
            settingWindow.ShowDialog();
            if (settingWindow.WindowState == WindowState.Normal)
                mainGrid.Opacity = 1;
            this.Background.Opacity = 0.8;
        }

        private void StoreBTN_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MaximizeBTN_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
                WindowState = WindowState.Normal;
            else if (WindowState == WindowState.Normal)
                WindowState = WindowState.Maximized;
        }


        //command for open setting
        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SettingWindow settingWindow = new SettingWindow();
            settingWindow.ShowDialog();
        }

        private void reportBTN_Click_1(object sender, RoutedEventArgs e)
        {
        }
    }
}
