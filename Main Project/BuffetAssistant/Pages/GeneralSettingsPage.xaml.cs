//using System;
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
using System.Drawing.Text;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;
using BuffetAssistant.Properties;
using BuffetAssistant.Classes;

namespace BuffetAssistant.Pages
{
    /// <summary>
    /// Interaction logic for GeneralSettingsPage.xaml
    /// </summary>
    public partial class GeneralSettingsPage : Page
    {
        public GeneralSettingsPage()
        {
            InitializeComponent();

            //when this page open
            fontComboBox.SelectedIndex = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Peek_Theme(object sender, MouseButtonEventArgs e)
        {
            Label label = sender as Label;
            AppSetting.config.Theme = label.Background;
            AppSetting.SaveSetting();
        }
    }
}