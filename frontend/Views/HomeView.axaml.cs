using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace student_concern_ticketing_system.frontend.Views
{
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
} 
