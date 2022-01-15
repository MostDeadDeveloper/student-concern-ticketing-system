using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media.Imaging;

namespace student_concern_ticketing_system.frontend.Views
{
    public partial class NavigationSidebar : UserControl
    {
        public NavigationSidebar()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}