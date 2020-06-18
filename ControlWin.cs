using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreOrderWin
{
    public partial class ControlWin
    {

        #region Вернуть ссылку на главное окно по запросу WPF C# {LinkMainWindow}
        /// <summary>
        /// Вернуть ссылку на окно по запросу WPF C# {ListWindowMain}MainWindow
        /// </summary>
        /// <param name="NameWindow"> Имя главного окна Рабочий стол или Панель</param>
        /// <returns></returns>
        public static dynamic LinkMainWindow(string NameWindow = "MainWindow")
        {

            foreach (System.Windows.Window openWindow in System.Windows.Application.Current.Windows)
            {

                //System.Windows.MessageBox.Show(openWindow.Name.ToString(), "«Open Windows»");
                if (openWindow.Title == NameWindow)
                {
                    // Пример ссылки на объект

                    // Пример кода
                    // ownedWindow.Close();MainWindow
                    return (dynamic)openWindow;
                }

            }
            return null;

        }
        #endregion

    }
}
