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
using System.Windows.Media.Effects;


namespace PreOrderWin
{
    /// <summary>
    /// Логика взаимодействия для MapTov.xaml
    /// </summary>
    public partial class MapTov : Window
    {
        public MapTov()
        {
            InitializeComponent();


  
        }

        private void CloseMapTov_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            Kolvo.Content = Convert.ToInt16(Kolvo.Content) + 1 >= 99 ? "99" : (Convert.ToInt16(Kolvo.Content) + 1).ToString();
            Vartist.Content = Convert.ToInt16(Kolvo.Content)*58.00;
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            Kolvo.Content = Convert.ToInt16(Kolvo.Content) - 1 > 0 ? (Convert.ToInt16(Kolvo.Content) - 1).ToString() : "0";
            Vartist.Content = Convert.ToInt16(Kolvo.Content) * 58.00;
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Okey_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Kol = Convert.ToInt16(Kolvo.Content);
            this.Close();
        }

        private void Col_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
