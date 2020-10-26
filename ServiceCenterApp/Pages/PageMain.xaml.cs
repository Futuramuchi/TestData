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
    /// Interaction logic for PageMain.xaml
    /// </summary>
    public partial class PageMain : Page
    {
        public PageMain()
        {
            InitializeComponent();
        }

        private void BtnService_Click(object sender, RoutedEventArgs e)
        {
            PermanentData.Frame.Navigate(new PageServiceList());
        }

        private void BtnClientServiceAdd_Click(object sender, RoutedEventArgs e)
        {
            PermanentData.Frame.Navigate(new PageAddClientService());
        }

        private void BtnAddService_Click(object sender, RoutedEventArgs e)
        {
            PermanentData.Frame.Navigate(new PageAddService());
        }

        private void BtnServiceList_Click(object sender, RoutedEventArgs e)
        {
            PermanentData.Frame.Navigate(new PageEditServiceClient());
        }
    }
}
