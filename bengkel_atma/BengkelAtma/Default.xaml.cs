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
using BengkelAtmaAuto.Main; // import folder lain untuk call 

namespace BengkelAtmaAuto
{
    /// <summary>
    /// Interaction logic for Default.xaml
    /// </summary>
    public partial class Default : Window
    {
        public Default()
        {
            InitializeComponent();
        }

        private void loginClick(object sender, RoutedEventArgs e)
        {
            if (tbUser.Text.Equals("panda") && pbPass.Password.Equals("panda123"))
            {
                Dashboard dashboard = new Dashboard();  //code buat pindah menu.,
                dashboard.Show();
                this.Hide();
            }
            else
            {
                Exception ex = new Exception();
                MessageBox.Show("User name atau Password tidak terdaftar! " , "Perhatian!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
