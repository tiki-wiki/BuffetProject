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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog imageFile = new OpenFileDialog();
            imageFile.Filter = "Image Files (*.jpg)|*.jpg|(*.png)|*.png|(*.ico)|*.ico";
            if (imageFile.ShowDialog() == true)
                foodImage.Source = GetImageSource(imageFile.FileName);
        }
    }
}
