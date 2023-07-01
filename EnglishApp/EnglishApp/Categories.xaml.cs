using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace EnglishApp
{
    
    /// <summary>
    /// Логика взаимодействия для Categories.xaml
    /// </summary>
    public partial class Categories : Page
    {
        //private string TotalW1;
        //private string TotalW2;
        //private string TotalW3;
        //private string TotalW4;
        public static Categories C;
        //public string TotalWords_Animals { get => "\\" + TotalW1; set => TotalW1 = value; }
        //public string WordsLeft_Animals { get; set; }

        //public string TotalWords_Music { get => "\\" + TotalW2; set => TotalW2 = value; }
        //public int WordsLeft_Music { get; set; }

        //public string TotalWords_Verbs { get => "\\" + TotalW3; set => TotalW3 = value; }
        //public int WordsLeft_Verbs { get; set; }


        //public string TotalWords_PHVerbs { get => "\\" + TotalW4; set => TotalW4 = value; }
        //public int WordsLeft_PHVerbs { get; set; }

        public int CorrectWords_Animals { get; set; }
        public int CorrectWords_Music { get; set; }
        public int CorrectWords_Verbs { get; set; }
        public int CorrectWords_PHVerbs { get; set; }

        Languages LTHis;

        public Categories()
        {
            InitializeComponent();
            C = this;
            Animals_PB.Value = Settings1.Default.AnimalsValue;
            Music_PB.Value = Settings1.Default.MusicValue;
            Verbs_PB.Value = Settings1.Default.VerbsValue;
            PhVerbs_PB.Value = Settings1.Default.PHVerbsValue;
            TB_Animals_1.Text = (Settings1.Default.AnimalsValue /2 ).ToString();
            TB_Music_1.Text = (Settings1.Default.MusicValue / 2).ToString();
            TB_Verbs_1.Text = (Settings1.Default.VerbsValue / 2).ToString();
            TB_PHVerbs_1.Text = (Settings1.Default.PHVerbsValue / 2).ToString();
        }
        public Categories(Languages L):this()
        {
            LTHis = L;
        }

        private void AnimalsC_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Learning(CategoriesEnum.AnimalsE, LTHis));
        }

        private void Verbs_C_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Learning(CategoriesEnum.VerbsE, LTHis));
        }

        private void PHVerbs_C_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Learning(CategoriesEnum.PHVerbsE, LTHis));
        }
        private void Music_C_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Learning(CategoriesEnum.MusicE, LTHis));
        }

        private void Animals_PB_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            CheckForEnable(ref Animals_PB, "animals");
        }

        private void Music_PB_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            CheckForEnable(ref Music_PB, "music");
        }

        private void Verbs_PB_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            CheckForEnable(ref Verbs_PB, "verbs");
        }

        private void PhVerbs_PB_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            CheckForEnable(ref PhVerbs_PB, "phverbs");
        }
        private void CheckForEnable(ref ProgressBar P, string s)
        {
            if(P.Value==30)
            {
                switch(s)
                {
                    case "animals":
                        {
                            AnimalsC.IsEnabled = false;
                            break;
                        }
                    case "music":
                        {
                            Music_C.IsEnabled = false;
                            break;
                        }
                    case "verbs":
                        {
                            Verbs_C.IsEnabled = false;
                            break;
                        }
                    case "phverbs":
                        {
                            PHVerbs_C.IsEnabled = false;
                            break;
                        }
                }
            }
        }
        //public void PB_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        //{
        //    Animals_PB.Foreground = new SolidColorBrush(Colors.Green);
        //    for (int i = 0; i < 50; i++)
        //    {
        //        Animals_PB.Dispatcher.Invoke(
        //            new Action(() => Animals_PB.Value += 2), DispatcherPriority.Background);
        //        Thread.Sleep(1000);
        //        TB_Animals_1.Text = $"{i+2}";

        //    }
        //}

    }
    
}
