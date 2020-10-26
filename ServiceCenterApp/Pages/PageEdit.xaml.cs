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
    /// Interaction logic for PageEdit.xaml
    /// </summary>
    public partial class PageEdit : Page
    {
        private string _photoPath;
        public PageEdit()
        {
            InitializeComponent();

            TxtName.Text = PermanentData.Service.Title;
            TxtCost.Text = PermanentData.Service.Cost.ToString();
            TxtDuration.Text = PermanentData.Service.DurationInSeconds.ToString();
            if (PermanentData.Service.Description == null)
            {
                TxtDescription.Text = string.Empty;
            }
            else
            {
                TxtDescription.Text = PermanentData.Service.Description.ToString();
            }
            
            if (PermanentData.Service.Discount == null)
            {
                TxtSale.Text = string.Empty;
            }
            else
            {
                TxtSale.Text = PermanentData.Service.Discount.ToString();
            }
            
            if (PermanentData.Service.MainImagePath == null)
            {
                ServicePhoto.Source = new BitmapImage(new Uri("/Resources/service_logo.png", UriKind.Relative));
            }
            else
            {
                ServicePhoto.Source = new BitmapImage(new Uri(PermanentData.Service.MainImagePath, UriKind.Relative));
            }
        }
        /// <summary>
        /// Обновление данных в БД после их изменения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                IEnumerable<Service> service = PermanentData.Ent.Services.Where(x => x.ID == PermanentData.Service.ID).AsEnumerable().Select(x =>
                {
                    x.Title = TxtName.Text;
                    x.Cost = Convert.ToDecimal(TxtCost.Text);
                    x.DurationInSeconds = Convert.ToInt32(TxtDuration.Text) * 60;
                    x.Description = TxtDescription.Text;
                    x.Discount = Convert.ToDouble(TxtSale.Text);
                    x.MainImagePath = _photoPath;
                    return x;
                });

                foreach (Service serv in service)
                {
                    PermanentData.Ent.Entry(serv).State = System.Data.Entity.EntityState.Modified;
                    MessageBox.Show("Все данные успешно изменены!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            

        }
        /// <summary>
        /// Размещение картинки на странице и сохранение в строку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StackPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.Filter = "Images .*JPG, .*PNG | *.jpg; *.jpeg; *.png";

            if (dialog.ShowDialog() == true)
            {
                ServicePhoto.Source = new BitmapImage(new Uri(dialog.FileName, UriKind.Relative));
                _photoPath = dialog.FileName;
            }
        }
    }
}
