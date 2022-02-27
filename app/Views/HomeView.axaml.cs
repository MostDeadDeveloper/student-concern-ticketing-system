using Avalonia;
using System;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;

namespace app.Views
{
    public partial class HomeView : UserControl
    {
        private Carousel _carousel;
        private Button _left;
        private Button _right;


        public HomeView()
        {
            InitializeComponent();
            _left.Click += (s, e) => _carousel.Previous();
            _right.Click += (s, e) => _carousel.Next();

        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
            _carousel = this.FindControl<Carousel>("carousel");
            _left = this.FindControl<Button>("left");
            _right = this.FindControl<Button>("right");

        }
         private void CreateTicket_Click(object sender, RoutedEventArgs e){
                Window CreateTicket = new CreateTicketView();
                CreateTicket.Show();
        }
    }

}