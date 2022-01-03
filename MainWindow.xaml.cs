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

namespace student_concern_ticketing_system
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // InitializeComponent();
            
        }

        private void btnHome_Click(object sender, RoutedEventArgs e){
            SetActiveControl(home);
        }
        public void SetActiveControl(UserControl control){
            //collapsed all user control
            home.Visibility = Visibility.Collapsed;
            profile.Visibility = Visibility.Collapsed;
            message.Visibility = Visibility.Collapsed;
            tickets.Visibility = Visibility.Collapsed;
            reports.Visibility = Visibility.Collapsed;

            //show the current user control
            control.Visibility = Visibility.Visible;
        }
        private void btnProfile_Click(object sender, RoutedEventArgs e){
            SetActiveControl(profile);
        }
        private void btnMessage_Click(object sender, RoutedEventArgs e){
            SetActiveControl(message);
        }
        private void btnTicket_Click(object sender, RoutedEventArgs e){
            SetActiveControl(tickets);
        }
        private void btnReport_Click(object sender, RoutedEventArgs e){
            SetActiveControl(reports);
        }
    }
}