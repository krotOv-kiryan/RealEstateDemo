using RealEstateDemo.db;
using RealEstateDemo.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RealEstateDemo.VM
{
    public class ClientPageVM : BaseViewModel
    {
        static RealEstateDemoContext db;
        // класс ClientPage.xaml

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
            
        public List<Client> Clients { get; set; }

        public CustomCommand CreateClient { get; set; }
        public CustomCommand SaveClient { get; set; }
        public CustomCommand DeleteClient { get; set; }

        public ClientPageVM()
        {
            LoadClients();
            CreateClient = new CustomCommand(() =>
            {
                var client = new Client { FirstName = "FirstName", MiddleName = "MiddleName" };
                db.Clients.Add(client);
                selectedClient = client;
                LoadClients();
            });

            DeleteClient = new CustomCommand(() =>
            {
                if (SelectedClient == null)
                {
                    MessageBox.Show("Для удаления клиента нужно его выбрать в списке");
                    return;
                }
                /*
                if (SelectedClient.Id > 0)
                {
                  MessageBox.Show("Невозможно удалить клиента со связями");
                    return;
                }
                */  
                //Client.Remove(SelectedClient);
                db.SaveChanges();
            })
            {

            };
            SaveClient = new CustomCommand(() =>
            {
                 if (SelectedClient == null)
                    return;
                try
                {
                   
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                };
                db.SaveChanges();
            });

        }

        private void LoadClients()
        {
            Clients = new List<Client>();
            SignalChanged("Clients");
        }

    }
}

