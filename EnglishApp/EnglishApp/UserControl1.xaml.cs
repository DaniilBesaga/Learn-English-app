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
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            DataContext = this;
            
        }
        private string TotalW;

        public Color FirstOne { get; set; }
        public Color SecondOne { get; set; }

        public string FirstCategory { get; set; }
        public string SecondCategory { get; set; }
        public string ThirdCategory { get; set; }
        public string FourthCategory { get; set; }
        

        

        public string TotalWords { get => "\\"+TotalW; set => TotalW = value; }
        public int WordsLeft { get; set; }
        

        public ImageSource FirstImage
        {
            get => (ImageSource)GetValue(FirstImg);
            set => SetValue(FirstImg, value);
        }

        public static readonly DependencyProperty FirstImg = DependencyProperty.Register
            ("FirstImage", typeof(ImageSource), typeof(MyLabel));




        //private void PB_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        //{
        //    for (int i = 0; i < 50; i++)
        //    {
        //        PB.Dispatcher.Invoke(
        //            new Action(() => PB.Value += 2), DispatcherPriority.Background);
        //        Thread.Sleep(1000);

        //    }
        //}
    }

    public class MyLabel : Label
    {
        
        
    }
}

namespace MyImages
{
   
}

