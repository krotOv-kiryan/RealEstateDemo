using RealEstateDemo.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateDemo.VM
{
    public class ClientPageVM : BaseViewModel
    {
        /*
        private Client selectedClient;
        public Client SelectedClient
        {
            get => selectedClient;
            set
            {
            selectedClient = value;
            SignalChanged();
            }
        }
            */

        // public List<Client> Clients { get; set; }

        public CustomCommand CreateClient { get; set; }
        public CustomCommand SaveClient { get; set; }
        public CustomCommand DeleteClient { get; set; }

        public ClientPageVM()
        {
            CreateClient = new CustomCommand(() =>
            {
                // var client = new Client { FirstName = "FirstName" };
                //selectedClient = client;

                LoadClients();
            });

            DeleteClient = new CustomCommand(() =>
            {
                // Db.Courses.Remove(selectedCourse);
                // Db.SaveChanges();
                LoadClients();
            });

            SaveClient = new CustomCommand(() =>
            {
                try
                {
                    // Db.SaveChanges();
                    LoadClients();
                }
                catch (Exception ex)
                {
                    System.Windows.MessageBox.Show(ex.Message);
                }

            });

        }

        private void LoadClients()
        {
            // Clients = new List<Client>();
            SignalChanged("Clients");
        }

    }
}

