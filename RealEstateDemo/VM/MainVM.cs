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
        public Page CurrentPage { get; set; }

        public CustomCommand GoToClient { get; set; }
        public CustomCommand GoToAgent { get; set; }

        public MainVM()
        {

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
