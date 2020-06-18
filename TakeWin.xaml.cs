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
using System.Threading;
using System.Diagnostics;



namespace PreOrderWin
{
    /// <summary>
    /// Логика взаимодействия для TakeWin.xaml
    /// </summary>
    public partial class TakeWin : Window
    {
        public TakeWin()
        {
            InitializeComponent();
            this.RowTake.Height = new GridLength(2, GridUnitType.Pixel);
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
            if (MainWindow.OnOffInvalid == 1) this.StackTake.VerticalAlignment = VerticalAlignment.Bottom;
            else this.StackTake.VerticalAlignment = VerticalAlignment.Center;


            //TakeWin ScreenTake = new TakeWin();
            //ScreenTake.Height = System.Windows.SystemParameters.PrimaryScreenHeight;
            //ScreenTake.Width = System.Windows.SystemParameters.PrimaryScreenWidth;
            ;
            //if (MainWindow.OnOffInvalid == 0) this.StackGrid.Height = MainWindow.ScreenHeight - MainWindow.SetHeigtCurent;
            //else this.StackGrid.Height = System.Windows.SystemParameters.PrimaryScreenHeight - MainWindow.SetHeigtCurent - MainWindow.InitLoadedHeigt;

            if (MainWindow.language_Key == 0)
            {
                this.Button5.Content = "Назад";
                Vibor.Content = "Будь ласка оберіть";
                language.Content = "Оберіть мову";
                Label.Content = "Замовлення в закладі";
                Label2.Content = "Замовлення з собою";
            }
            else
            {
                this.Button5.Content = "Back";
                Vibor.Content = "ORDER HERE";
                language.Content = "Choose a language";
                Label.Content = "TAKE IN";
                Label2.Content = "TAKE OUT";
            }

        }
        private void Back_One_Click(object sender, RoutedEventArgs e)
        {
            // смещение высоты панели для инвалидов

            //if (MainWindow.OnOffInvalid == 0) this.StackGrid.Height = System.Windows.SystemParameters.PrimaryScreenHeight - MainWindow.SetHeigtCurent - MainWindow.InitLoadedHeigt;
            //else this.StackGrid.Height = MainWindow.ScreenHeight - MainWindow.SetHeigtCurent;
            if (MainWindow.OnOffInvalid == 0) this.RowTake.Height = new GridLength(500, GridUnitType.Pixel);
            else this.RowTake.Height = new GridLength(2, GridUnitType.Pixel);
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

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow WinTake = new MainWindow();
            WinTake.Owner = this;
            WinTake.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.RestHier = 0; // заказ здесь
            PaymentWin WinPayment = new PaymentWin();
            WinPayment.Owner = this;
            WinPayment.Show();
        }



        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            MainWindow.RestHier = 1; // заказ на вынос
            PaymentWin WinPayment = new PaymentWin();
            WinPayment.Owner = this;
            WinPayment.Show();
        }

        private void Button_away_Click(object sender, MouseButtonEventArgs e)
        {
            MainWindow.RestHier = 1;
            PaymentWin WinPayment = new PaymentWin();
            WinPayment.Owner = this;
            WinPayment.Show();
        }

        private void Button_Here_Click(object sender, MouseButtonEventArgs e)
        {
            MainWindow.RestHier = 0;
            PaymentWin WinPayment = new PaymentWin();
            WinPayment.Owner = this;
            WinPayment.Show();
        }

        private void Ukraine_Click(object sender, RoutedEventArgs e)
        {

            this.Button5.Content = "Назад";
            Vibor.Content = "Будь ласка оберіть";
            language.Content = "Оберіть мову";
            Label.Content = "Замовлення в закладі";
            Label2.Content = "Замовлення з собою";
            MainWindow.language_Key = 0;
        }

        private void English_Click(object sender, RoutedEventArgs e)
        {
            this.Button5.Content = "Back";
            Vibor.Content = "ORDER HERE";
            language.Content = "Choose a language";
            Label.Content = "TAKE IN";
            Label2.Content = "TAKE OUT";
            MainWindow.language_Key = 1;
        }

        private void Button_Here_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.RestHier = 0;
            PaymentWin WinPayment = new PaymentWin();
            WinPayment.Owner = this;
            WinPayment.Show();
        }

    }
}


