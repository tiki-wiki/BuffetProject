using BuffetAssistant.Classes;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
namespace BuffetAssistant
{
    /// <summary>
    /// Interaction logic for OrderWindow.xaml
    /// </summary>
    public partial class OrderWindow : Window
    {

        //transfering variables Definition
        public string categoryName;
        public string id;
        public ImageSource image;
        public string ingredients;

        public OrderWindow()
        {
            InitializeComponent();
            myBox.Text = ingredients;
        }

        private void minimizeBTN_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void maximizeBTN_Click(object sender, RoutedEventArgs e)
        {
            //maximize window
            if (this.WindowState == WindowState.Normal)
                this.WindowState = WindowState.Maximized;

            //minimiz window
            else if (this.WindowState == WindowState.Maximized)
                this.WindowState = WindowState.Normal;
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void closeBTN_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            new MainWindow().ShowDialog();
            this.Close();
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            searchBox.Text = string.Empty;
        }

        private void searchBox_LostFocus(object sender, RoutedEventArgs e)
        {
            searchBox.Text = "... جست و جو";
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuEditor editor = new MenuEditor();
            editor.ShowDialog();
        }

        private void removeBTN_Click(object sender, RoutedEventArgs e)
        {
            menuBox.Items.Remove(menuBox.SelectedItem);
        }
    }
}
