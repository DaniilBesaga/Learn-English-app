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

namespace EnglishApp
{
    /// <summary>
    /// Логика взаимодействия для ChooseLang.xaml
    /// </summary>
    public partial class ChooseLang : Page
    {
        public ChooseLang()
        {
            InitializeComponent();
            ShowsNavigationUI = false;
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Statistics(Languages.Russian));
        }

        private void MesB_ComingSoon()
        {
            MessageBox.Show("Coming soon...");
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MesB_ComingSoon();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MesB_ComingSoon();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
           MesB_ComingSoon();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Statistics(Languages.Ukrainian));
        }
    }
}
