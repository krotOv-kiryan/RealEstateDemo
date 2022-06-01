using RealEstateDemo.VM;
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

namespace RealEstateDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainVM();
        }

        private void Button_BD(object sender, RoutedEventArgs e)
        {


            // часть кода для импорта
            /*
            var connection = DBInstance.Get();
            connection.SaveChanges();

            string path = @"C:\Users\user\Desktop\ДЭ\Сессия 1\clientservice_a_impor1.csv";
            var rows = File.ReadAllLines(path);
            var clients = connection.Client.ToList();
            var services = connection.Service.ToList();
            for (int i = 1; i < rows.Length; i++)
            {
            var cols = rows[i].Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            var client = clients.First(s => s.LastName == cols[0]);
            var service = services.First(s => s.Title == cols[2]);
            connection.ClientService.Add(new ClientService {
            Client = client,
            Service = service,
            StartTime = DateTime.Parse(cols[1])
            });
            }
            connection.SaveChanges();

            */
        }
    }
}
