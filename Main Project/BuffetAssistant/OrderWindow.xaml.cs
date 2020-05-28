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

namespace BuffetAssistant
{
    /// <summary>
    /// Interaction logic for OrderWindow.xaml
    /// </summary>
    public partial class OrderWindow : Window
    {
        public OrderWindow()
        {
            InitializeComponent();
        }

        private void specialOrderBTN_MouseEnter(object sender, MouseEventArgs e)
        {
        }

        private void normalOrderBTN_MouseEnter(object sender, MouseEventArgs e)
        {
            imgNormalgray.Opacity = 0;
        }

        private void normalOrderBTN_MouseLeave(object sender, MouseEventArgs e)
        {
            imgNormalgray.Opacity = 1;

        }
    }
}
