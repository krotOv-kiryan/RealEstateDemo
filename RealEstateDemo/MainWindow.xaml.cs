using RealEstateDemo.VM;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace RealEstateDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      // static MainWindow window;
        public MainWindow()
        {
           // window = this;
            InitializeComponent();
            DataContext = new MainVM();
        }

        private void Button_BD(object sender, RoutedEventArgs e)
        {
            // часть кода для импорта
            /*
            var connection = DBInstance.Get();
            string path = @"C:\Users\Кирилл\Desktop\Дэмо экзамены\ФНЧ 2018 Недвижимость\Resources\Session 1\clients.csv";
            var rows = File.ReadAllLines(path);
            var clients = connection.Clients.ToList();
            var services = connection.Clients.ToList();
            for (int i = 1; i < rows.Length; i++)
            {
                var cols = rows[i].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                connection.Clients.Add(new Client
                {
                    id = i,
                     = int.Parse(cols[0]),
                    servicename = cols[1],
                    price = double.Parse(cols[2].Replace('.', ',')),
                });
            }
            */
        }


        /*
        public static void Navigate(Page page)
        {
            window.mainFrame.Navigate(page);
        }

        private void BackPage(object sender, RoutedEventArgs e)
        {
            if (mainFrame.CanGoBack)
                mainFrame.GoBack();
        }

        private void ForwardPage(object sender, RoutedEventArgs e)
        {
            if (mainFrame.CanGoForward)
                mainFrame.GoForward();
        }
        */
    }
}
