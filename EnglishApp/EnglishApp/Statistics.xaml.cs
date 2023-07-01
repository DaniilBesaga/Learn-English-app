using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Security.Policy;
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
    /// Логика взаимодействия для Statistics.xaml
    /// </summary>
    public partial class Statistics : Page
    {
        Languages LThis;
        public static Statistics S;
        public ObservableCollection<GridTable> Titles { get; set; }
        public Statistics()
        {
            InitializeComponent();
            this.DataContext = this;
            this.Titles = new ObservableCollection<GridTable>();
            this.Titles.Add(new GridTable() { GridCount = 60, GridTitle = "Total Words: " });
            this.Titles.Add(new GridTable() { GridCount = Settings1.Default.LearnedWords, GridTitle = "You lerned: " });
            this.Titles.Add(new GridTable() { GridCount = Settings1.Default.LeftWords, GridTitle = "Words left: " });
            this.Titles.Add(new GridTable() { GridCount = Settings1.Default.ErrorWords, GridTitle = "Errors: " });
            
        }
        public Statistics(Languages L):this()
        {
            LThis = L;
            S = this;
        }
        private void Ch_L_B_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ChooseLang());
            
        }

        private void LearnE_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Categories(LThis));
        }

        private void DisAds_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("С Вас шавуха!!!");
        }

        private void ResetAll_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult res = MessageBox.Show("Are you sure to reset all stats?", "Warning",
                MessageBoxButton.OKCancel);
            if (res == MessageBoxResult.OK)
            {
                Settings1.Default.AnimalsValue = 0;
                Settings1.Default.MusicValue = 0;
                Settings1.Default.VerbsValue = 0;
                Settings1.Default.PHVerbsValue = 0;
                Settings1.Default.LearnedWords = 0;
                Settings1.Default.ErrorWords = 0;
                Settings1.Default.LeftWords = 60;
                Settings1.Default.ListOfIds = null;
                Settings1.Default.Save();
                NavigationService.Navigate(new ChooseLang());
            }
            else
                return;
        }

        private void ListView_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            ListView listView = sender as ListView;
            GridView gView = listView.View as GridView;

            var workingWidth = listView.ActualWidth - SystemParameters.VerticalScrollBarWidth; // take into account vertical scrollbar
            var col1 = 0.15;
            var col2 = 0.85;
            gView.Columns[0].Width = workingWidth * col1;
            gView.Columns[1].Width = workingWidth * col2;
            
        }
    }
    public class GridTable: INotifyPropertyChanged
    {
        public string? GridTitle { get; set; }
        public int GridCount { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public int Gridcount
        {
            get { return GridCount; }
            set
            {
                GridCount = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(GridCount)));
            }
        }
    }
    
}
