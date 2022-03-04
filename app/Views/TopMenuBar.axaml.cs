using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using System;
using app.ViewModels;
using app.Services;

namespace app.Views
{
    public partial class TopMenubar : UserControl
    {
        private ComboBox _ProfileDDMenu;
        private Label _lbltracker;
        private Button _ProfileBtn;

        public TopMenubar()
        {
            InitializeComponent();
            _ProfileDDMenu.SelectionChanged += cmbItemChanged;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
            _ProfileDDMenu = this.Find<ComboBox>("ProfileDDMenu");
            _lbltracker = this.Find<Label>("lbltracker");
            _ProfileBtn = this.Find<Button>("ProfileBtn");

        }

        private void cmbItemChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (_ProfileDDMenu.SelectedIndex)
            {
                case 0:
                    _lbltracker.Content = "Inbox";
                    break;
                case 1:
                    _lbltracker.Content = "Account Profile";
                    break;
                case 2:
                    // Content = new LoginViewModel();
                    
                    _lbltracker.Content = "Sign Out";
                    // _ProfileBtn.Command = "{Binding $parent[Window].DataContext.LoginView}");
                    break;
            }
        }
    }
}
 