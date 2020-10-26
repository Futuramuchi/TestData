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
    /// Interaction logic for PageEditing.xaml
    /// </summary>
    public partial class PageEditing : Page
    {
        public PageEditing(ClientService clientService)
        {
            InitializeComponent();
            TxtClient.Text = clientService.Client.LastName;
            TxtTime.Text = clientService.StartTime.ToString();
            TxtComment.Text = clientService.Comment;

            CmbxService.SelectedValuePath = "ID";
            CmbxService.DisplayMemberPath = "Title";
            CmbxService.ItemsSource = PermanentData.Ent.Services.ToList();
            CmbxService.SelectedIndex = clientService.ServiceID - 1;

            PermanentData.ClientService = clientService;
        }
        /// <summary>
        /// Изменение существующих данных в БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                IEnumerable<ClientService> clService = PermanentData.Ent.ClientServices.Where(x => x.ID == PermanentData.ClientService.ID).AsEnumerable().Select(x =>
                {
                    x.ClientID = PermanentData.ClientService.ClientID;
                    x.ServiceID = (int)CmbxService.SelectedValue;
                    x.StartTime = Convert.ToDateTime(TxtTime.Text);
                    x.Comment = TxtComment.Text;
                    return x;
                });

                foreach (ClientService clServ in clService)
                {
                    PermanentData.Ent.Entry(clServ).State = System.Data.Entity.EntityState.Modified;
                    MessageBox.Show("Все данные успешно изменены!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
           
        
    }
}
