using RealEstateDemo.MVVM;
using RealEstateDemo.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace RealEstateDemo.VM
{
    public class MainVM : BaseViewModel
    {
        //класс MainWindow.xaml
        public Page CurrentPage { get; set; }


        // команды
        public CustomCommand GoToClient { get; set; }
        public CustomCommand GoToAgent { get; set; }
        public CustomCommand GoToObjects { get; set; }
        

        public MainVM()
        {
            //реализация команд
            GoToObjects = new CustomCommand(() =>
            {
                CurrentPage = new RealEstateObjects(); SignalChanged("CurrentPage");
            });

            GoToClient = new CustomCommand(() =>
            {
                CurrentPage = new ClientPage(); SignalChanged("CurrentPage");
            });

            GoToAgent = new CustomCommand(() =>
            {
                CurrentPage = new AgentPage(); SignalChanged("CurrentPage");
            });
        }
    }
}
