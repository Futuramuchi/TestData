using ServiceCenterApp.AppData;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for PageAddService.xaml
    /// </summary>
    public partial class PageAddService : Page
    {
        private string _photoPath;


        public PageAddService()
        {
            InitializeComponent();
        }

        private void StackPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.Filter = "Images *.jpg,*.jpeg, *.png | *.jpg; *.jpeg; *.png;";
            
            if (dialog.ShowDialog() == true)
            {
                ServicePhoto.Source = new BitmapImage(new Uri(dialog.FileName, UriKind.Relative));
                _photoPath = dialog.FileName;

                //JpegBitmapEncoder jpegBitmapEncoder = new JpegBitmapEncoder();
                //jpegBitmapEncoder.Frames.Add(BitmapFrame.Create(ServicePhoto.Source as BitmapSource));
                //using (FileStream fileStream = new FileStream(_photoPath, FileMode.Create))
                //    jpegBitmapEncoder.Save(fileStream);

                //System.Environment.CurrentDirectory = @"";
            }

        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtCost.Text) || string.IsNullOrEmpty(TxtName.Text) || string.IsNullOrEmpty(TxtDuration.Text))
            {
                MessageBox.Show("Поля названия, цены и продолжительности должны быть заполнены!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Exclamation);

            }
            else
            {
                Service serv = new Service()
                {
                    Title = TxtName.Text,
                    Cost = Convert.ToDecimal(TxtCost.Text),
                    DurationInSeconds = Convert.ToInt32(TxtDuration.Text),
                    Description = TxtDescription.Text,
                    Discount = Convert.ToDouble(TxtSale.Text),
                    MainImagePath = _photoPath
                };

                PermanentData.Ent.Services.Add(serv);
                PermanentData.Ent.SaveChanges();
                MessageBox.Show("Все данные успешно сохранены!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);

            }
        }
    }
}
