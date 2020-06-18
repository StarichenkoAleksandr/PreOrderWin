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

namespace PreOrderWin
{
    /// <summary>
    /// Логика взаимодействия для PaymentWin.xaml
    /// </summary>
    public partial class PaymentWin : Window
    {
        public PaymentWin()
        {
            InitializeComponent();

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

 

            LabelLoyal.Visibility = Visibility.Hidden;
            Button7.Visibility = Visibility.Hidden;
            Card.Visibility = Visibility.Hidden;
            Button9.Visibility = Visibility.Hidden;
            LabelNi.Visibility = Visibility.Hidden;
            LabelYes.Visibility = Visibility.Hidden;
            LabelNi.Visibility = Visibility.Hidden;

            if (MainWindow.language_Key == 0)
            {
                this.Button5.Content = "Назад";
                Oplata.Content = "ДЕ ВИ БАЖАЄТЕ ЗДІЙСНИТИ ОПЛАТУ ?";
                Label.Content = "     Оплатити на касі " + Environment.NewLine + "(Готівкою чи карткою)";
                Label2.Content = "   Оплатити тут " + Environment.NewLine + "(Тільки карткою) ";
                LabelLoyal.Content = "Ви бажаєта застосувати карту лояльності?";
                LabelYes.Content = "ТАК";
                LabelNi.Content = "НІ";
            }
            else
            {
                this.Button5.Content = "Back";
                Oplata.Content = "WHERE DO YOU WANT TO PAY?";
                Label.Content = "Pay at the box office " + Environment.NewLine + " (Cash or card)";
                Label2.Content = "Pay here (Card only)";
                LabelLoyal.Content = "You want to use a loyalty card?";
                LabelYes.Content = "Yes";
                LabelNi.Content = "No";
            }


        }

        private void Button_Nal_Click(object sender, RoutedEventArgs e)
        {
            CardVisible();
            MainWindow.CashBank = 0; // оплата через касу наличными или картой
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
 
            TakeWin WinTake = new TakeWin();
            WinTake.Owner = this;
            WinTake.Show();
        }

        private void Back_Invalid_Click(object sender, RoutedEventArgs e)
        {
            //if (MainWindow.OnOffInvalid == 0) this.StackGrid.Height = System.Windows.SystemParameters.PrimaryScreenHeight - MainWindow.SetHeigtCurent - MainWindow.InitLoadedHeigt;
            //else this.StackGrid.Height = MainWindow.ScreenHeight - MainWindow.SetHeigtCurent;
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

        private void Card_Loyal_Click(object sender, RoutedEventArgs e)
        {
            
            ListPriceWin WinPayment = new ListPriceWin();
            WinPayment.Owner = this;
            WinPayment.Show();

  
        }

        private void Button_Ni_Click(object sender, MouseButtonEventArgs e)
        {
            ListPriceWin WinPayment = new ListPriceWin();
            WinPayment.Owner = this;
            WinPayment.Show();
        }

        private void Button_Cart_Click(object sender, RoutedEventArgs e)
        {
            CardVisible();
            MainWindow.CashBank = 1; // оплата через через банковский терминал картой
        }

        private void Button_Cart_Click(object sender, MouseButtonEventArgs e)
        {
            CardVisible();
        }

        private void Button_Nal_Click(object sender, MouseButtonEventArgs e)
        {
            CardVisible();
        }

        public void CardVisible()
        {
            LabelLoyal.Visibility = Visibility.Visible;
            Button7.Visibility = Visibility.Visible;
            Card.Visibility = Visibility.Visible;
            Button9.Visibility = Visibility.Visible;
            LabelNi.Visibility = Visibility.Visible;
            LabelYes.Visibility = Visibility.Visible;
            LabelNi.Visibility = Visibility.Visible;
        }

        private void Card_Loyal_Click(object sender, MouseButtonEventArgs e)
        {
            MainWindow.Card_Loyal = 1;
            ListPriceWin WinPayment = new ListPriceWin();
            WinPayment.Owner = this;
            WinPayment.Show();
        }

        private void Card_NoLoyal_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Card_Loyal = 0;
            ListPriceWin WinPayment = new ListPriceWin();
            WinPayment.Owner = this;
            WinPayment.Show();
        }
    }
}
