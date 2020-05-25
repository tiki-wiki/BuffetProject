using BuffetAssistant.Classes;
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
            Order o1 = new Order();
            o1.ID = 4;
            o1.Name = "Hamburger";
            o1.Quantity = 50;
            o1.TotalPrice = 2500;
            hamInfo.Text = "Id:"+o1.ID.ToString() + "\n"+"Name:" + o1.Name + "\n"+"Quantity:" + 
                o1.Quantity.ToString() + "\n"+"TotalPrice: "+ o1.TotalPrice.ToString()+"$";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
