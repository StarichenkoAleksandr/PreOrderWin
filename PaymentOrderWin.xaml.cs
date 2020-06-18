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
    /// Логика взаимодействия для PaymentOrderWin.xaml
    /// </summary>
    public partial class PaymentOrderWin : Window
    {
        public PaymentOrderWin()
        {
            InitializeComponent();
            if (MainWindow.CashBank == 1)
            {
                this.Bank.Visibility = Visibility.Visible;
                this.Kasa.Visibility = Visibility.Hidden;

                this.BankTerminal.Visibility = Visibility.Visible;
                this.BankTerminal.VerticalAlignment = VerticalAlignment.Top;
                this.CashOrder.Visibility = Visibility.Hidden;
            }

            else
            {
                this.Bank.Visibility = Visibility.Hidden;
                this.Kasa.Visibility = Visibility.Visible;
                this.Kasa.VerticalAlignment = VerticalAlignment.Top;

                this.CashOrder.Visibility = Visibility.Visible;
                this.BankTerminal.Visibility = Visibility.Hidden;
            }

      
            this.RowPayment.Height = new GridLength(2, GridUnitType.Pixel);
            if (MainWindow.OnOffInvalid == 1) this.StackTake.VerticalAlignment = VerticalAlignment.Bottom;
            else this.StackTake.VerticalAlignment = VerticalAlignment.Center;

    
            if (MainWindow.language_Key == 1)
            {
                this.Bank.Content = "       Payment of the order" + Environment.NewLine + "through the bank terminal";
                this.Kasa.Content = "Payment of the order at the box office";
                this.CashOrder.Content = "Take a check for your order" + Environment.NewLine + "     and pay in cash or " + Environment.NewLine + " by card at the checkout.";
                this.BankTerminal.Content = "Please follow the instructions  " + Environment.NewLine + " provided in the bank terminal";
                this.OrderDelete.Content = "Cancel";
                this.OpderEdit.Content = "Edit";
                this.OrderPrint.Content = MainWindow.CashBank == 1 ? "To pay" : "Print " + Environment.NewLine + "a receipt";
            }
            else
            {
                this.Bank.Content = "       Оплата  замовлення " + Environment.NewLine + " через банківський термінал";
                this.Kasa.Content = "Оплата  замовлення на касі";
                this.CashOrder.Content = "Візьміть чек на Ваше замовлення " + Environment.NewLine + "           та сплатіть готівкою " + Environment.NewLine + "          або карткою  на касі.";
                this.BankTerminal.Content = "   Будь ласка слідуйте інструкціям " + Environment.NewLine + " вказаним у банківському терміналі";
                this.OrderDelete.Content = "Скасувати";
                this.OpderEdit.Content = "Редагувати";
                this.OrderPrint.Content = MainWindow.CashBank == 1 ? "Сплатити" :"Друкувати " + Environment.NewLine + " квітанцію";
            }

        }

        private void Delete_Oder_Click(object sender, RoutedEventArgs e)
        {
            MainWindow WinTake = new MainWindow();
            WinTake.Owner = this;
            WinTake.Show();
        }

        private void Ghage_Oder_Click(object sender, RoutedEventArgs e)
        {
            ListPriceWin WinTake = new ListPriceWin();
            WinTake.Owner = this;
            WinTake.Show();
        }

        private void Print_Order_Click(object sender, RoutedEventArgs e)
        {

            // вызов процедуры печати чека
            if (MainWindow.CashBank == 0)PrintOrder();
            else PaymentBank();

            MainWindow WinTake = new MainWindow();
            WinTake.Owner = this;
            WinTake.Show();
        }

        // печать квитанции по заказу.
        public void PrintOrder()
        { 
        
        }

        // вызов процедуры работы с банкоматом
        public void PaymentBank()
        { 
        }
    }
}
