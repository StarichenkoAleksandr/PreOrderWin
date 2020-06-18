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
using System.Collections.ObjectModel;

namespace PreOrderWin
{

    public class GrupTov
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImagePath { get; set; } // путь к изображению

    }


    public class Bludo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImagePath { get; set; } // путь к изображению
        public string Inform { get; set; }
        public string Price { get; set; }
    }

    /// <summary>
    /// Логика взаимодействия для ListPriceWin.xaml
    /// </summary>
    public partial class ListPriceWin : Window
    {

        public static string NameTovPrice = "";
        public ListPriceWin()
        {
            InitializeComponent();

            //if (MainWindow.OnOffInvalid == 0) this.StackGrid.Height = MainWindow.ScreenHeight - MainWindow.SetHeigtCurent;
            //else this.StackGrid.Height = System.Windows.SystemParameters.PrimaryScreenHeight - MainWindow.SetHeigtCurent - MainWindow.InitLoadedHeigt;

            this.RowPayment.Height = new GridLength(2, GridUnitType.Pixel);
            if (MainWindow.OnOffInvalid == 0)
            {
                ButtonBack.Visibility = Visibility.Hidden;
                Button5.Visibility = Visibility.Visible;
            }
            else
            {
                ButtonBack.Visibility = Visibility.Visible;
                Button5.Visibility = Visibility.Hidden;
            }
            //if (MainWindow.OnOffInvalid == 0) this.StackGrid.Height = MainWindow.ScreenHeight - MainWindow.SetHeigtCurent;
            //else this.StackGrid.Height = System.Windows.SystemParameters.PrimaryScreenHeight - MainWindow.SetHeigtCurent - MainWindow.InitLoadedHeigt;

            if (MainWindow.OnOffInvalid == 1) this.StackTake.VerticalAlignment = VerticalAlignment.Bottom;
            else this.StackTake.VerticalAlignment = VerticalAlignment.Center;

    

            if (MainWindow.language_Key == 1)
            {
                this.Button5.Content = "Back";
                this.Zakaz.Content = MainWindow.RestHier == 0 ? "My order is in a restaurant" : "My order is with me";
                this.Itog.Content = "Total";
                this.Masege.Content = "You have nothing ordered";
                this.Button4.Content = "CANCEL " + Environment.NewLine + " ORDERS ";
                this.Button3.Content = "FINISH";
            }
            else
            {
                this.Button5.Content = "Назад";
                this.Zakaz.Content = MainWindow.RestHier == 1 ? "Моє замовлення -з собою" : "Моє замовлення -у ресторані "; ;
                this.Itog.Content = " Разом : ";
                this.Masege.Content = "Ви ще нічого не замовили";
                this.Button4.Content = "   СКАСУВАТИ " + Environment.NewLine + " ЗАМОВЛЕННЯ";
                this.Button3.Content = "ГОТОВО";
            }


            ObservableCollection<GrupTov> GrupTovs = new ObservableCollection<GrupTov>
            {
            new GrupTov {Id=1, ImagePath="pack://application:,,,/PreOrderWin;component/Images/9.jpg" ,Title="Гарніри"},
            new GrupTov {Id=2, ImagePath="pack://application:,,,/PreOrderWin;component/Images/2.jpg" ,Title="Ковбаса-гриль"},
            new GrupTov {Id=3, ImagePath="pack://application:,,,/PreOrderWin;component/Images/3.jpg" ,Title="Комбо набори"},
            new GrupTov {Id=4, ImagePath="pack://application:,,,/PreOrderWin;component/Images/9.jpg" ,Title="Хот-дог"},
            new GrupTov {Id=5, ImagePath="pack://application:,,,/PreOrderWin;component/Images/5.jpg" ,Title="Соуси"},
            new GrupTov {Id=6, ImagePath="pack://application:,,,/PreOrderWin;component/Images/6.jpg" ,Title="Гарніри"},
            new GrupTov {Id=7, ImagePath="pack://application:,,,/PreOrderWin;component/Images/7.jpg" ,Title="Ковбаса-гриль"},
            new GrupTov {Id=8, ImagePath="pack://application:,,,/PreOrderWin;component/Images/8.jpg" ,Title="Хот-дог"}
            };
            ListGrupTovs.ItemsSource = GrupTovs;
        }

        private void GrupTovList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GrupTov();
        }

        public void GrupTov()
        {
            GrupTov p = (GrupTov)ListGrupTovs.SelectedItem;
            //MessageBox.Show(p.ImagePath);
            TitleGrup.Content = p.Title;
            if (p.Id == 1)
            {
                ObservableCollection<Bludo> ListBludo = new ObservableCollection<Bludo>
                {
                new Bludo {Id=1, Inform="pack://application:,,,/PreOrderWin;component/Images/iteminfo.png", Price="58,00", ImagePath="pack://application:,,,/PreOrderWin;component/Images/1.jpg" ,Title="Салат-мікс овочевий  "},
                new Bludo {Id=2, Inform="pack://application:,,,/PreOrderWin;component/Images/iteminfo.png", Price="58,00",ImagePath="pack://application:,,,/PreOrderWin;component/Images/2.jpg" ,Title="Мікс овочевий на пару "},
                new Bludo {Id=3, Inform="pack://application:,,,/PreOrderWin;component/Images/iteminfo.png", Price="58,00",ImagePath="pack://application:,,,/PreOrderWin;component/Images/3.jpg" ,Title="Комбо набори"},

                };
                BludoList.ItemsSource = ListBludo;

            }
            if (p.Id == 2)
            {
                ObservableCollection<Bludo> ListBludo = new ObservableCollection<Bludo>
                {

                new Bludo {Id=3, Inform="pack://application:,,,/PreOrderWin;component/Images/iteminfo.png", Price="58,00",ImagePath="pack://application:,,,/PreOrderWin;component/Images/3.jpg" ,Title="Комбо набори"},
                new Bludo {Id=4, Inform="pack://application:,,,/PreOrderWin;component/Images/iteminfo.png", Price="58,00",ImagePath="pack://application:,,,/PreOrderWin;component/Images/9.jpg" ,Title="Хот-дог"},
                new Bludo {Id=5, Inform="pack://application:,,,/PreOrderWin;component/Images/iteminfo.png", Price="58,00",ImagePath="pack://application:,,,/PreOrderWin;component/Images/5.jpg" ,Title="Соуси"},
                new Bludo {Id=6, Inform="pack://application:,,,/PreOrderWin;component/Images/iteminfo.png", Price="58,00",ImagePath="pack://application:,,,/PreOrderWin;component/Images/6.jpg" ,Title="Гарніри"},
                new Bludo {Id=7, Inform="pack://application:,,,/PreOrderWin;component/Images/iteminfo.png", Price="58,00",ImagePath="pack://application:,,,/PreOrderWin;component/Images/7.jpg" ,Title="Ковбаса-гриль"},
                new Bludo {Id=8, Inform="pack://application:,,,/PreOrderWin;component/Images/iteminfo.png", Price="58,00",ImagePath="pack://application:,,,/PreOrderWin;component/Images/8.jpg" ,Title="Хот-дог"}
                };
                BludoList.ItemsSource = ListBludo;
            }
            if (p.Id == 3)
            {
                ObservableCollection<Bludo> ListBludo = new ObservableCollection<Bludo>
                {

                new Bludo {Id=6, Inform="pack://application:,,,/PreOrderWin;component/Images/iteminfo.png", Price="58,00",ImagePath="pack://application:,,,/PreOrderWin;component/Images/6.jpg" ,Title="Гарніри"},
                new Bludo {Id=7, Inform="pack://application:,,,/PreOrderWin;component/Images/iteminfo.png", Price="58,00",ImagePath="pack://application:,,,/PreOrderWin;component/Images/7.jpg" ,Title="Ковбаса-гриль"},
                new Bludo {Id=8, Inform="pack://application:,,,/PreOrderWin;component/Images/iteminfo.png", Price="58,00",ImagePath="pack://application:,,,/PreOrderWin;component/Images/8.jpg" ,Title="Хот-дог"}
                };
                BludoList.ItemsSource = ListBludo;
            }
            if (p.Id == 4)
            {
                ObservableCollection<Bludo> ListBludo = new ObservableCollection<Bludo>
                {

                new Bludo {Id=2, Inform="pack://application:,,,/PreOrderWin;component/Images/iteminfo.png", Price="58,00",ImagePath="pack://application:,,,/PreOrderWin;component/Images/2.jpg" ,Title="Мікс овочевий на пару "},
                new Bludo {Id=3, Inform="pack://application:,,,/PreOrderWin;component/Images/iteminfo.png", Price="58,00",ImagePath="pack://application:,,,/PreOrderWin;component/Images/3.jpg" ,Title="Комбо набори"},
                new Bludo {Id=4, Inform="pack://application:,,,/PreOrderWin;component/Images/iteminfo.png", Price="58,00",ImagePath="pack://application:,,,/PreOrderWin;component/Images/9.jpg" ,Title="Хот-дог"},
                new Bludo {Id=5, Inform="pack://application:,,,/PreOrderWin;component/Images/iteminfo.png", Price="58,00",ImagePath="pack://application:,,,/PreOrderWin;component/Images/5.jpg" ,Title="Соуси"},

                };
                BludoList.ItemsSource = ListBludo;
            }
        }

        private void BludoList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Bludo CartTov = (Bludo)BludoList.SelectedItem;
            int IdCArtov = 1;//  CartTov.Id;
            //NameTovPrice = CartTov.Title;
            SelectCartTov(IdCArtov);
            //MessageBox.Show(p.ImagePath);
        }


        private void Back_Click(object sender, RoutedEventArgs e)
        {
            PaymentWin WinTake = new PaymentWin();
            WinTake.Owner = this;
            WinTake.Show();
         
        }

        private void Back_One_Click(object sender, RoutedEventArgs e)
        {
            //if (MainWindow.OnOffInvalid == 0) this.StackGrid.Height = System.Windows.SystemParameters.PrimaryScreenHeight - MainWindow.SetHeigtCurent - MainWindow.InitLoadedHeigt;
            //else this.StackGrid.Height = MainWindow.ScreenHeight - MainWindow.SetHeigtCurent;
            //if (MainWindow.OnOffInvalid == 0) this.StackTake.VerticalAlignment = VerticalAlignment.Bottom;
            //else this.StackTake.VerticalAlignment = VerticalAlignment.Center;
            //MainWindow.OnOffInvalid = MainWindow.OnOffInvalid == 0 ? 1 : 0;

        }

        private void Add_Check1(object sender, MouseButtonEventArgs e)
        {
            MainWindow.TextContent = MainWindow.TextContent + "Рис з овочами    58,00" + Environment.NewLine;
            //Check.Content = MainWindow.TextContent;
            MainWindow.Kol++;
            Itog.Content = " Разом :     " + Convert.ToString(MainWindow.Kol * 58);
        }

        private void Add_Check2(object sender, MouseButtonEventArgs e)
        {
            MainWindow.TextContent = MainWindow.TextContent + "Картопля фрі " + Environment.NewLine + "з беконом  58,00" + Environment.NewLine;
            //Check.Content = MainWindow.TextContent;
            MainWindow.Kol++;
            Itog.Content = " Разом :     " + Convert.ToString(MainWindow.Kol * 58);
        }
        private void Add_Check3(object sender, MouseButtonEventArgs e)
        {
            MainWindow.TextContent = MainWindow.TextContent + "Картопля " + Environment.NewLine + "по селянськи  58,00" + Environment.NewLine;
            //Check.Content = MainWindow.TextContent;
            MainWindow.Kol++;
            Itog.Content = " Разом :     " + Convert.ToString(MainWindow.Kol * 58);
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.TextContent = "";
            //Check.Content = MainWindow.TextContent;
            Itog.Content = "";
            MainWindow.Kol = 0;
            Masege.Content = "Ви ще нічого не замовили";
            MainWindow WinTake = new MainWindow();
            WinTake.Owner = this;
            WinTake.Show();
        }

        private void Finish_Click(object sender, RoutedEventArgs e)
        {

            ListZakazWin WinTake = new ListZakazWin();
            WinTake.Owner = this;
            WinTake.Show();
 
        }

        private void GrupTovList_SelectionChanged(object sender, MouseButtonEventArgs e)
        {
            GrupTov();
        }

        public void SelectCartTov(int IdCartTov)
        {



            System.Windows.Application.Current.Dispatcher.Invoke(new Action(delegate ()
            {
               
            
                ListPriceWin MapTov_Top = ControlWin.LinkMainWindow("ListPriceWin");
                Window WinOblako = new MapTov();
                if (MainWindow.OnOffInvalid == 1)
                {
                    MapTov_Top.RowPayment.Height = new GridLength(500, GridUnitType.Pixel);
                    MapTov_Top.StackTake.VerticalAlignment = VerticalAlignment.Bottom;

                }
                else
                {
                    MapTov_Top.RowPayment.Height = new GridLength(2, GridUnitType.Pixel);
                    MapTov_Top.StackTake.VerticalAlignment = VerticalAlignment.Center;
                }

                WinOblako.Owner = MapTov_Top;
                int TopScreen = (Convert.ToUInt16(MainWindow.ScreenHeight) > 1700 && MainWindow.OnOffInvalid == 1) ? Convert.ToUInt16(MainWindow.ScreenHeight) - Convert.ToUInt16(WinOblako.Height) : (Convert.ToUInt16(MainWindow.ScreenHeight) >= 1000) ? 200 : 0; // Convert.ToUInt16(MainWindow.ScreenHeight) - Convert.ToUInt16(WinOblako.Height) 
                WinOblako.Top = MapTov_Top.Top + TopScreen;
                //WinOblako.Left = ConectoWorkSpace_InW.ScrollViewerd.Width - (WinOblakoVerh_Info.Width * 2);  //ConectoWorkSpace_InW.Left + MessageLeft;
                WinOblako.ShowActivated = false;
                WinOblako.Show();

            }));

            //MapTov WinTake = new MapTov();
            //WinTake.Owner = this;
            //WinTake.Show();



        }

        private void Back_Invalid_Click(object sender, RoutedEventArgs e)
        {
            if (MainWindow.OnOffInvalid == 0) this.RowPayment.Height = new GridLength(500, GridUnitType.Pixel);
            else this.RowPayment.Height = new GridLength(2, GridUnitType.Pixel);
            if (MainWindow.OnOffInvalid == 0) this.StackTake.VerticalAlignment = VerticalAlignment.Bottom;
            else this.StackTake.VerticalAlignment = VerticalAlignment.Center;
            MainWindow.OnOffInvalid = MainWindow.OnOffInvalid == 0 ? 1 : 0;

            if (MainWindow.OnOffInvalid == 0)
            {
                ButtonBack.Visibility = Visibility.Hidden;
                Button5.Visibility = Visibility.Visible;
            }
            else
            {
                ButtonBack.Visibility = Visibility.Visible;
                Button5.Visibility = Visibility.Hidden;
            }
        }
    }
}
