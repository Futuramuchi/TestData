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
    /// Interaction logic for PageEditServiceClient.xaml
    /// </summary>
    public partial class PageEditServiceClient : Page
    {
        public PageEditServiceClient()
        {
            InitializeComponent();

            GridClientService.ItemsSource = PermanentData.Ent.ClientServices.ToList();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            PermanentData.Frame.Navigate(new PageEditing((sender as Button).DataContext as ClientService));

        }
    }
}
