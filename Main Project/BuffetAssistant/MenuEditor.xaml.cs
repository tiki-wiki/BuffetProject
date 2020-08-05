using System;
using System.Collections.Generic;
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
using BuffetAssistant.Classes;
using Microsoft.Win32;
namespace BuffetAssistant
{
    /// <summary>
    /// Interaction logic for MenuEditor.xaml
    /// </summary>
    public partial class MenuEditor : Window
    {
        public MenuEditor()
        {
            InitializeComponent();
        }
        public static ImageSource GetImageSource(string path)
        {
            BitmapImage iconSource = new BitmapImage();
            iconSource.BeginInit();
            iconSource.UriSource = new Uri(path);
            iconSource.EndInit();
            return iconSource;
        }
        private void imageBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog imageFile = new OpenFileDialog();
            imageFile.Filter = "Image Files (*.jpg)|*.jpg|(*.png)|*.png|(*.ico)|*.ico";
            if (imageFile.ShowDialog() == true)
                foodImage.Source = GetImageSource(imageFile.FileName);
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox infoTextBox = sender as TextBox;
            infoTextBox.Text = string.Empty;
        }

        private void clearBtn_Click(object sender, RoutedEventArgs e)
        {
            nameBox.Clear();
            numberBox.Clear();
            IngrediantBox.Clear();
            nameBox.Text = "نام دسته";
            numberBox.Text = "شماره";
            IngrediantBox.Text = "مواد تشکیل دهنده";
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            ((OrderWindow)Application.Current.Windows[0]).categoryName = nameBox.Text;
            ((OrderWindow)Application.Current.Windows[0]).id = numberBox.Text;
            ((OrderWindow)Application.Current.Windows[0]).image = foodImage.Source;
            ((OrderWindow)Application.Current.Windows[0]).ingredients = IngrediantBox.Text;
            this.Close();
        }
    }
}
