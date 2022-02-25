using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using Avalonia.Controls.ApplicationLifetimes;
using System;

namespace app.Views
{
    public partial class TopMenubar : UserControl
    {
        private Button _ProfileBtn;
        public TopMenubar()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
            var _ProfileDDMenu = this.Find<ComboBox>("ProfileDDMenu");
            _ProfileBtn = this.Find<Button>("ProfileBtn");
            if(_ProfileDDMenu.SelectedIndex == 2){
                //DataContext = new LoginView();
            }
        }
    }
}
