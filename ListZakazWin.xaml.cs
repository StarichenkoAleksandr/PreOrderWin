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
    /// Логика взаимодействия для ListZakazWin.xaml
    /// </summary>
    public partial class ListZakazWin : Window
    {
        public ListZakazWin()
        {
            InitializeComponent();

            this.RowPayment.Height = new GridLength(2, GridUnitType.Pixel);
            if (MainWindow.OnOffInvalid == 1) this.StackTake.VerticalAlignment = VerticalAlignment.Bottom;
            else this.StackTake.VerticalAlignment = VerticalAlignment.Center;

  

            if (MainWindow.RestHier == 1) this.OrderHereAway.Content = "Моє замовлення - з собою";
            else this.OrderHereAway.Content = "Моє замовлення - у ресторані";
            if (MainWindow.CashBank == 1) this.Oplata.Content = "Оплата через банківський темінал ";
            else this.Oplata.Content = "Оплата через касу готівкою або карткою.";

  

            if (MainWindow.language_Key == 1)
            {
                this.OrderList.Content = "Contents of the order";
                this.Summa.Content = "Total: number of units-Sum - ";
                this.OrderHereAway.Content = MainWindow.RestHier == 0 ? "My order is in a restaurant" : "My order is with me";
                this.Oplata.Content = MainWindow.CashBank == 0 ? "Payment: through the box office in cash or by card" : "Payment through a bank terminal";
                this.OrderDelete.Content = "Cancel";
                this.OpderEdit.Content = "Edit";
                this.Confirm.Content = "Confirm";
            }
            else
            {

                this.OrderList.Content = "Зміст замовлення";
                this.Summa.Content = "Разом: кількість одиниць-Сума - ";
                this.OrderHereAway.Content = MainWindow.RestHier == 1 ? "Моє замовлення - з собою" : "Моє замовлення -у ресторані ";
                this.Oplata.Content = MainWindow.CashBank == 1 ? "Оплата через банківський темінал " : "Оплата: готівкою через касу";
                this.OrderDelete.Content = "Скасувати";
                this.OpderEdit.Content = "Редагувати";
                this.Confirm.Content = "Підтвердити";
            }


        }

        private void StrokaOrder_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

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

        private void Select_Order_Click(object sender, RoutedEventArgs e)
        {
            PaymentOrderWin WinTake = new PaymentOrderWin();
            WinTake.Owner = this;
            WinTake.Show();
           
        }
    }
}
