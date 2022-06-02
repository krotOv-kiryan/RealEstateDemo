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

        // класс ClientPage.xaml
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
                /*/
                if (SelectedClient == null)
                {
                    System.Windows.MessageBox.Show("Для удаления клиента нужно его выбрать в списке");
                    return;
                }
                if (SelectedClient.CountVisit > 0)
                {
                    System.Windows.MessageBox.Show("Невозможно удалить клиента со связями");
                    return;
                }
                DBInstance.Get().Client.Remove(SelectedClient);
                DBInstance.Get().SaveChanges();
                */
            });

            SaveClient = new CustomCommand(() =>
            {
                // if (SelectedClient == null)
                //    return;
                /*
                try
                {
                    EditClient.Tag = SelectedTags;
                    if (EditClient.ID == 0)
                        DBInstance.Get().Client.Add(EditClient);
                    else
                        DBInstance.Get().Entry(client).CurrentValues.SetValues(EditClient);
                    DBInstance.Get().SaveChanges();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                };
                */
            });

        }

        private void LoadClients()
        {
            // Clients = new List<Client>();
            SignalChanged("Clients");
        }

    }
}

