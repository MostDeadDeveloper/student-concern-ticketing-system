using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using student_concern_ticketing_system.frontend.ViewModels;
using student_concern_ticketing_system.frontend.Views;
using student_concern_ticketing_system.frontend.Services;

namespace student_concern_ticketing_system
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                var db  = new Database();

                desktop.MainWindow = new MainWindow
                {
                    DataContext = new MainWindowViewModel(db),
                };
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}
