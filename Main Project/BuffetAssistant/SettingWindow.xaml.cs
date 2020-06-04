using BuffetAssistant.Pages;
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
using System.Windows.Navigation;
namespace BuffetAssistant
{
    /// <summary>
    /// Interaction logic for SettingWindow.xaml
    /// </summary>
    public partial class SettingWindow : Window
    {
        public SettingWindow()
        {
            InitializeComponent();
        }

        private void settingListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GeneralSettingsPage generalPage = new GeneralSettingsPage();
            settingFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            if (settingListView.SelectedIndex == 0)
            {
                settingFrame.Navigate(generalPage);
            }
        }
    }
}
