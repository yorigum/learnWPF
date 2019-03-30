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
using System.Windows.Shapes;
using System.Configuration;
namespace BengkelAtmaAuto.Main
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public Dashboard()
        {
            InitializeComponent();
        }


        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Apakah Anda ingin Log Out dari sistem?", "Perhatian!", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
            {

            }
            else
            {
                Exception ex = new Exception();
                MessageBox.Show("Anda berhasil melakukan Logout", "Perhatian!", MessageBoxButton.OK, MessageBoxImage.Warning);
                Default menu = new Default();  //code buat pindah menu.,
                menu.Show();
                this.Close();
            }
        }
    }
}
