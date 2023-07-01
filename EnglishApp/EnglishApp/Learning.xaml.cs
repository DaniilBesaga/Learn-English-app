using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EnglishApp
{
    /// <summary>
    /// Логика взаимодействия для Learning.xaml
    /// </summary>
    public partial class Learning : Page
    {
        private int rightanswers = 0;
        public Color BackA {get;set;}
        public string? AWord { get; set; }
        static CategoriesEnum CThis;
        static Languages LThis;
        static List<List<long>> getted_id = new List<List<long>>();
        static List<int> randwords = new List<int>();
        int[] numbers;
        int new_id;
        Random rnd = new Random();
        string s = "";
        long chosenid = 0;
        static int waschosen = 15;
        public Learning()
        {
            InitializeComponent();
            if (Settings1.Default.AnimalsValue == 0 && Settings1.Default.MusicValue == 0 &&
                Settings1.Default.VerbsValue == 0 && Settings1.Default.PHVerbsValue == 0)
                Settings1.Default.ListOfIds = new List<List<long>>();
            DataContext = this;
        }

        public Learning(CategoriesEnum C, Languages L):this()
        {
            switch (C) {
                case CategoriesEnum.AnimalsE:
                    CThis = CategoriesEnum.AnimalsE; break;
                case CategoriesEnum.MusicE:
                    CThis = CategoriesEnum.MusicE; break;
                case CategoriesEnum.VerbsE:
                    CThis = CategoriesEnum.VerbsE; break;
                case CategoriesEnum.PHVerbsE:
                    CThis = CategoriesEnum.PHVerbsE; break;
            }
            switch (L)
            {
                case Languages.Russian:
                    LThis = Languages.Russian; break;
                case Languages.Ukrainian:
                    LThis = Languages.Ukrainian; break;  
            }
            if (Settings1.Default.AnimalsValue == 0 && Settings1.Default.MusicValue == 0 &&
                Settings1.Default.VerbsValue == 0 && Settings1.Default.PHVerbsValue == 0)
            {
                string appFolder = Directory.GetCurrentDirectory();
                string dbFilePath = System.IO.Path.Combine(appFolder, "DBEnglish.db");
                SqliteConnection english_word_conn = new SqliteConnection
                    ($"Data Source = {dbFilePath}");
                english_word_conn.Open();
                SqliteCommand sqlcom_english = english_word_conn.CreateCommand();
                string[] words = new string[] { "Animals" , "Music Instruments",
                "Verbs", "Phrasal Verbs" };
                getted_id.Add(new List<long>());
                getted_id.Add(new List<long>());
                getted_id.Add(new List<long>());
                getted_id.Add(new List<long>());
                for (int i = 0; i < 4; i++)
                {
                    sqlcom_english.CommandText = $"SELECT * FROM Words Where Category = '{words[i]}'";
                    SqliteDataReader sqlrd_cat = sqlcom_english.ExecuteReader();
                    while (sqlrd_cat.Read())
                    {
                        getted_id[i].Add(Convert.ToInt64(sqlrd_cat["Id"]));
                    }
                    sqlrd_cat.Close();
                }
                english_word_conn.Close();
            }
            Filling_From_DB();
        }

        
        private void FirstWordButton_Click(object sender, RoutedEventArgs e)
        {
            
            
        }

        private void SecondWordButton_Click(object sender, RoutedEventArgs e)
        {
            
            
        }

        private void ThirdWordButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void FourthWordButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void WasIncorrect(object sender, RoutedEventArgs e)
        {
            if (sender is Button B)
            {
                B.Background = new SolidColorBrush(Colors.Red);
                myMethod(B);
                EnglishApp.Statistics.S.Titles.ElementAt(3).Gridcount = Settings1.Default.ErrorWords++;
                Settings1.Default.Save();
            }
        }

        private void WasCorrect(object sender, RoutedEventArgs e)
        {
            rightanswers++;
            if (sender is Button B)
            {
                B.Background = new SolidColorBrush(Colors.Green);
                myMethod(B);
            }
            
            
            this.Dispatcher.Invoke(DispatcherPriority.Background, delegate ()
            {
                Thread.Sleep(1000);
                FirstWordButton.Opacity = 0;
                SecondWordButton.Opacity = 0;
                ThirdWordButton.Opacity = 0;
                FourthWordButton.Opacity = 0;
                FirstWordButton.ClearValue(BackgroundProperty);
                SecondWordButton.ClearValue(BackgroundProperty);
                ThirdWordButton.ClearValue(BackgroundProperty);
                FourthWordButton.ClearValue(BackgroundProperty);
            });
            ChangeData();
            switch (CThis)
            {
                case CategoriesEnum.AnimalsE:
                    if (Settings1.Default.AnimalsValue == 30)
                    {
                        NavigationService.GoBack();
                        return;
                    }
                    break;
                case CategoriesEnum.MusicE:
                    if (Settings1.Default.MusicValue == 30)
                    {
                        NavigationService.GoBack();
                        return;
                    }
                    break;
                case CategoriesEnum.VerbsE:
                    if (Settings1.Default.VerbsValue == 30)
                    {
                        NavigationService.GoBack();
                        return;
                    }
                    break;
                case CategoriesEnum.PHVerbsE:
                    if (Settings1.Default.PHVerbsValue == 30)
                    {
                        NavigationService.GoBack();
                        return;
                    }
                    break; 


            }
            Filling_From_DB(); 
            ReturnOpacity(FirstWordButton);
            ReturnOpacity(SecondWordButton);
            ReturnOpacity(ThirdWordButton);
            ReturnOpacity(FourthWordButton);
            
            
        }
        
        private void ChangeData()
        {
            switch (CThis)
            {
                case CategoriesEnum.AnimalsE:
                    Settings1.Default.AnimalsValue += 2;
                    EnglishApp.Categories.C.Animals_PB.Value = Settings1.Default.AnimalsValue;
                    EnglishApp.Categories.C.TB_Animals_1.Text =
                        (EnglishApp.Categories.C.Animals_PB.Value / 2).ToString();
                    break;
                case CategoriesEnum.MusicE:
                    Settings1.Default.MusicValue += 2;
                    EnglishApp.Categories.C.Music_PB.Value = Settings1.Default.MusicValue;
                    EnglishApp.Categories.C.TB_Music_1.Text =
                        (EnglishApp.Categories.C.Music_PB.Value / 2).ToString();
                    break;
                case CategoriesEnum.VerbsE:
                    Settings1.Default.VerbsValue += 2;
                    EnglishApp.Categories.C.Verbs_PB.Value = Settings1.Default.VerbsValue;
                    EnglishApp.Categories.C.TB_Verbs_1.Text =
                        (EnglishApp.Categories.C.Verbs_PB.Value / 2).ToString();
                    break;
                case CategoriesEnum.PHVerbsE:
                    Settings1.Default.PHVerbsValue += 2;
                    EnglishApp.Categories.C.PhVerbs_PB.Value = Settings1.Default.PHVerbsValue;
                    EnglishApp.Categories.C.TB_PHVerbs_1.Text =
                        (EnglishApp.Categories.C.PhVerbs_PB.Value / 2).ToString();
                    break;
            }
            EnglishApp.Statistics.S.Titles.ElementAt(1).Gridcount = Settings1.Default.LearnedWords++;
            EnglishApp.Statistics.S.Titles.ElementAt(2).Gridcount = Settings1.Default.LeftWords--;
            Settings1.Default.Save();

            
        }

        public void myMethod(object? sender)
        {
            this.Dispatcher.Invoke(DispatcherPriority.Normal,delegate ()
            {
                if(sender is Button ctrl)
                {
                    DoubleAnimation DA = new DoubleAnimation();
                    DA.From = ctrl.Opacity;
                    DA.To = 0;
                    DA.Duration = TimeSpan.FromSeconds(1);
                    ctrl.IsEnabled = false;
                    ctrl.BeginAnimation(Button.OpacityProperty, DA);
                    
                }
            });
        }
        private void Filling_From_DB()
        {
            int num = 15;
            if(Settings1.Default.ListOfIds.Count!=0)
            {
                if (15 - Settings1.Default.AnimalsValue/2 != Settings1.Default.ListOfIds[0].Count)
                {
                    Settings1.Default.ListOfIds[0].Add(Settings1.Default.WasRemembered);
                    num++;
                }
                if (15 - Settings1.Default.MusicValue / 2 != Settings1.Default.ListOfIds[1].Count)
                {
                    Settings1.Default.ListOfIds[1].Add(Settings1.Default.WasRemembered);
                    num++;
                }
                if (15 - Settings1.Default.VerbsValue / 2 != Settings1.Default.ListOfIds[2].Count)
                {
                    Settings1.Default.ListOfIds[2].Add(Settings1.Default.WasRemembered);
                    num++;
                }
                if (15 - Settings1.Default.PHVerbsValue / 2 != Settings1.Default.ListOfIds[3].Count)
                {
                    Settings1.Default.ListOfIds[3].Add(Settings1.Default.WasRemembered);
                    num++;
                }
                Settings1.Default.Save();
            }
            switch (CThis)
            {
                case CategoriesEnum.AnimalsE:
                    waschosen = num - Settings1.Default.AnimalsValue/2;
                    
                    break;
                case CategoriesEnum.MusicE:
                    waschosen = num - Settings1.Default.MusicValue / 2;
                    
                    break;
                case CategoriesEnum.VerbsE:
                    waschosen = num - Settings1.Default.VerbsValue / 2;
                    
                    break;
                case CategoriesEnum.PHVerbsE:
                    waschosen = num - Settings1.Default.PHVerbsValue / 2;
                    
                    break;
            }

            if (Settings1.Default.ListOfIds.Count!=0)
                getted_id = Settings1.Default.ListOfIds;
            string appFolder = Directory.GetCurrentDirectory();
            string dbFilePath = System.IO.Path.Combine(appFolder, "DBEnglish.db");
            SqliteConnection english_word_conn = new SqliteConnection
                ($"Data Source = {dbFilePath}");
            english_word_conn.Open();
            SqliteCommand sqlcom_english = english_word_conn.CreateCommand();
            SqliteCommand sqlcom_rand_words = english_word_conn.CreateCommand();
  
            if (numbers!=null)
            {
                SP_Words.Children.OfType<Button>().ElementAt(new_id).Click -= WasCorrect;
                SP_Words.Children.OfType<Button>().ElementAt(numbers[0]).Click -= WasIncorrect;
                SP_Words.Children.OfType<Button>().ElementAt(numbers[1]).Click -= WasIncorrect;
                SP_Words.Children.OfType<Button>().ElementAt(numbers[2]).Click -= WasIncorrect;
            }
            numbers = new int[] { 0, 1, 2, 3 };
            
            switch (CThis)
            {
                case CategoriesEnum.AnimalsE:
                    {
                        while (true)
                        {
                            new_id = rnd.Next(0, waschosen-1);
                            if(getted_id[0].ElementAtOrDefault(new_id)!=null)
                            {
                                chosenid = getted_id[0][new_id];
                                getted_id[0].RemoveAt(new_id);
                                break;
                            }                          
                        }
                        break;
                    }

                case CategoriesEnum.MusicE:
                    {
                        while (true)
                        {
                            new_id = rnd.Next(0, waschosen - 1);
                            if (getted_id[1].ElementAtOrDefault(new_id) != null)
                            {
                                chosenid = getted_id[1][new_id];
                                getted_id[1].RemoveAt(new_id);
                                break;
                            }
                        }
                        break;
                    }

                case CategoriesEnum.VerbsE:
                    {
                        while (true)
                        {
                            new_id = rnd.Next(0, waschosen - 1);
                            if (getted_id[2].ElementAtOrDefault(new_id) != null)
                            {
                                chosenid = getted_id[2][new_id];
                                getted_id[2].RemoveAt(new_id);
                                break;
                            }
                        }
                        break;
                    }

                case CategoriesEnum.PHVerbsE:
                    {
                        while (true)
                        {
                            new_id = rnd.Next(0, waschosen - 1);
                            if (getted_id[3].ElementAtOrDefault(new_id) != null)
                            {
                                chosenid = getted_id[3][new_id];
                                getted_id[3].RemoveAt(new_id);
                                break;
                            }
                        }
                        break;
                    }
            }
            waschosen--;
            int new_id_rand = 0;
            for (int i = 0; i < 3; i++)
            {
                while (true)
                {
                    new_id_rand = rnd.Next(1, 25);
                    if (!randwords.Contains(new_id_rand))
                    {
                        randwords.Add(new_id_rand);
                        break;
                    }
                }
            }
            

            sqlcom_rand_words.CommandText = $"SELECT * FROM RandomWords Where Id in" +
                $"({randwords[0]}, {randwords[1]}, {randwords[2]})";
            sqlcom_english.CommandText = $"SELECT * FROM Words Where Id={chosenid}";
            //Settings1.Default.ListOfIds.Add(Convert.ToString(getted_id.Last()));
            
            Settings1.Default.WasRemembered = new_id;
            Settings1.Default.ListOfIds = getted_id;
            Settings1.Default.Save();
            SqliteDataReader sqlrd_eng = sqlcom_english.ExecuteReader();
            string temp = "";
            
            new_id = rnd.Next(0, 4);
            while (sqlrd_eng.Read())
            {
                
                temp = (LThis.Equals(Languages.Russian)) ? "Russian" : "Ukrainian";
                SP_Words.Children.OfType<Button>().ElementAt(new_id).Content = sqlrd_eng[temp].ToString();
                SP_Words.Children.OfType<Button>().ElementAt(new_id).Click += WasCorrect;
                TB_Engw.Text = sqlrd_eng["EnglishTranslate"].ToString();
            }
            sqlrd_eng.Close();
            numbers = Array.FindAll(numbers, delegate (int n) { return n != new_id; }
            ) ;
            SqliteDataReader sqlrd_rand_words = sqlcom_rand_words.ExecuteReader();
            int count = 0;
            while (sqlrd_rand_words.Read())
            {
                SP_Words.Children.OfType<Button>().ElementAt(numbers[count]).Content = sqlrd_rand_words[temp].ToString();
                SP_Words.Children.OfType<Button>().ElementAt(numbers[count]).Click += WasIncorrect;
                count++;
            }
            randwords.Clear();
            
        }

        private void ReturnOpacity(object? sender)
        {
            this.Dispatcher.Invoke(DispatcherPriority.ApplicationIdle,delegate ()
            {
                if (sender is Button ctrl)
                {
                    DoubleAnimation DA = new DoubleAnimation();
                    DA.From = ctrl.Opacity;
                    DA.To = 1;
                    DA.Duration = TimeSpan.FromSeconds(0.1);
                    ctrl.IsEnabled = true;
                    ctrl.BeginAnimation(Button.OpacityProperty, DA);
                    
                }
            });
        }

        private void Page_Unloaded(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("All money was spent on development");
        }
    }
    
}
