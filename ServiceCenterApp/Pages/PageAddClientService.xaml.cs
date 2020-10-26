using ServiceCenterApp.AppData;
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

namespace ServiceCenterApp.Pages
{
    /// <summary>
    /// Interaction logic for PageAddClientService.xaml
    /// </summary>
    public partial class PageAddClientService : Page
    {
        public PageAddClientService()
        {
            InitializeComponent();

            CmbxService.SelectedValuePath = "ID";
            CmbxService.DisplayMemberPath = "Title";
            CmbxService.ItemsSource = PermanentData.Ent.Services.ToList();
            CmbxService.SelectedIndex = 0;

            GridClient.ItemsSource = PermanentData.Ent.Clients.ToList();
        }

        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtDate.Text) || string.IsNullOrEmpty(TxtCLient.Text))
            {
                MessageBox.Show("Поля клиента, даты и услуги должны быть заполнены!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                ClientService clServ = new ClientService()
                {
                    ClientID = PermanentData.Client.ID,
                    ServiceID = (int)CmbxService.SelectedValue,
                    StartTime = Convert.ToDateTime(TxtDate.Text),
                    Comment = TxtComment.Text
                };

                PermanentData.Ent.ClientServices.Add(clServ);
                PermanentData.Ent.SaveChanges();
                MessageBox.Show("Данные успешно сохранены!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);


            }
        }

        private void TxtSearch_SelectionChanged(object sender, RoutedEventArgs e)
        {
            GridClient.ItemsSource = PermanentData.Ent.Clients.Where(x => x.FirstName.Contains(TxtSearch.Text) || x.LastName.Contains(TxtSearch.Text)
            || x.Patronymic.Contains(TxtSearch.Text)).ToList();
        }

        private void GridClient_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for (int i = 0; i < GridClient.SelectedItems.Count; i++)
            {
                Client cl = GridClient.SelectedItems[i] as Client;
                PermanentData.Client = cl;
                TxtCLient.Text = cl.LastName;
            }
        }
    }
}
