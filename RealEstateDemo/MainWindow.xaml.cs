
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
            RealEstateDemoContext con = new RealEstateDemoContext();
           
            string pathAgent = @"C:\Users\kirya\OneDrive\Рабочий стол\Дэмо экзамены\ФНЧ 2018 Недвижимость\Resources\Session 1\agents.csv";
            string pathClient = @"C:\Users\kirya\OneDrive\Рабочий стол\Дэмо экзамены\ФНЧ 2018 Недвижимость\Resources\Session 1\clients.csv";
           
            var rows = File.ReadAllLines(path);
            for (int i = 0; i < rows.Length; i++)
            {
                var cols = rows[i].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                con.Add(new Agent
                {
                    Id = int.Parse(cols[0]),
                    FirstName = cols[1],
                    MiddleName = cols[2],
                    LastName = cols[3],
                    ShareOfCommission = int.Parse(cols[4])
                });
            }
            con.SaveChanges();
        
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
