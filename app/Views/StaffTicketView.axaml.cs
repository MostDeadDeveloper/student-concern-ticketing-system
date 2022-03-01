using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;

namespace app.Views
{
    public partial class StaffTicketView : UserControl
    {
        public StaffTicketView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void CreateTicket_Click(object sender, RoutedEventArgs e){
                Window CreateTicket = new CreateTicketView();
                CreateTicket.Show();
        }
    }
}