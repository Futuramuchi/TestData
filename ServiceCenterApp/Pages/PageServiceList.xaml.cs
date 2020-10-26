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
using System.Windows.Threading;

namespace ServiceCenterApp.Pages
{
    /// <summary>
    /// Interaction logic for PageServiceList.xaml
    /// </summary>
    public partial class PageServiceList : Page
    {
        public PageServiceList()
        {
            InitializeComponent();

            //DispatcherTimer timer = new DispatcherTimer();
            //timer.Interval = TimeSpan.FromSeconds(10);
            //timer.Tick += UpdateData;
            //timer.Start();

            ListService.ItemsSource = PermanentData.Ent.Services.ToList();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            var res = (sender as Button).DataContext as Service;
            PermanentData.Service = res;
            PermanentData.Frame.Navigate(new PageEdit());

        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var del = (sender as Button).DataContext as Service;
            PermanentData.Ent.Services.Remove(del);
            PermanentData.Ent.SaveChanges();
            MessageBox.Show("Данные успешно удалены!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        //private void UpdateData(object e, object sender)
        //{
            
        //}
    }
}
