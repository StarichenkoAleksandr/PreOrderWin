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
using Microsoft.EntityFrameworkCore;

namespace PreOrderWin
{
      public class ElementInterfeysWindows
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Puth { get; set; }
        }

        public class ApplicationContext : DbContext
        {
            public DbSet<ElementInterfeysWindows> Admin { get; set; }

            public ApplicationContext()
            {
                Database.EnsureCreated();
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseNpgsql(@"Host=localhost;Port=5432;Database=D:\WindowNext\WindowNext\AdminBd;Username=postgres;Password=Admin");
            }
        } 
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static double ScreenHeight = 0, SetHeigtCurent = 0;
        public static double ScreenWidth = 0;
        public static int RestHier = 0, CashBank = 0, Card_Loyal = 0;
        public static int language_Key = 0;
        public static string TextContent = "";
        public static int Kol = 0;
        public static int HeightWin = 100;
        public static string FonBord = ""; // @"d:\WindowNext\WindowNext\start1.jpg";
        public static string TMBord = ""; //  @"d:\WindowNext\WindowNext\logo.png";

   

        public static int OnOffInvalid = 0, InitLoadedHeigt = 0; // переключатель сворачивания экрана для инвалида
        public MainWindow()
        {
            InitializeComponent();
            // 1920х1080
            ScreenHeight = System.Windows.SystemParameters.PrimaryScreenHeight;
            ScreenWidth = System.Windows.SystemParameters.PrimaryScreenWidth;
            //InitLoadedHeigt = 400;
            //if (ScreenWidth > 1700)
            //{
            //    //ScreenHeight = ScreenWidth;
            //    //InitLoadedHeigt = 1000;
            //    SetHeigtCurent = ScreenHeight - Convert.ToDouble(200);
            //}

        }

        private void Button_Click(object sender, MouseButtonEventArgs e)
        {
            //MessageBox.Show("ScreenHeight =" + ScreenHeight.ToString()+ "  ScreenWidth=" + ScreenWidth.ToString());
            TakeWin WinTake = new TakeWin();
            WinTake.Owner = this;
            WinTake.Show();
        }

        private void ExitPreOrder(object sender, MouseButtonEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
