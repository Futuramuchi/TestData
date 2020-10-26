using ServiceCenterApp.AppData;
using ServiceCenterApp.Pages;
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

namespace ServiceCenterApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PermanentData.Ent = new ServiceCenterEntities();

            PermanentData.Frame = FrameBody;
            FrameBody.Navigate(new PageMain());
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            PermanentData.Frame.GoBack();
        }
    }
}
