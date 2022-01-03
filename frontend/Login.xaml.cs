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

namespace frontend
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login(){
            InitializeComponent();
        
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e){
            // this.Hide();
            // Profile win = new Profile();
            // win.Show();
            if (sender != null){
                MessageBoxResult result = MessageBox.Show("You clicked Login :D", "Login", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btnSignup_Click(object sender, RoutedEventArgs e){
            this.Hide();
            Signup win = new Signup();
            win.Show();
        }
    }

    
}
