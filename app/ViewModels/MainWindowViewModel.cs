using System;
using System.Collections.Generic;
using System.Text;
using ReactiveUI;
using app.Services;

namespace app.ViewModels
{
    class MainWindowViewModel : ViewModelBase
    {
        public Database connection; 

        public MainWindowViewModel(Database db)
        {
            List = new TicketListViewModel(db.GetItems());

            // provide a database connection to everyone, a very safety hazard pero hey
            // nobody cares.
            connection = db;

            StartView();
        }

        public TicketListViewModel List { get; }

        public void OnClickCommand()
        {
            // do something
        }

        ViewModelBase content;
        
        public ViewModelBase Content
        {
            get => content;
            private set => this.RaiseAndSetIfChanged(ref content, value);
        }

        public void StartView()
        {
            Content = new StartViewModel();
        }
        public void HomeView()
        {
            Content = new HomeViewModel();
        }

        public void StaffTicketView()
        {
            Content = new StaffTicketViewModel(connection.GetItems());
        }

        public void ReportView()
        {
            Content = new ReportViewModel();
        }

        public void LoginView()
        {
            Content = new LoginViewModel();
        }

        public void SignupView()
        {
            Content = new SignupViewModel();
        }

        public void AdminSettingView()
        {
            Content = new AdminSettingViewModel();
        }

        public void ProfileView()
        {
            Content = new ProfileViewModel();
        }

        public void AdminSLAManageView()
        {
            Content = new AdminSLAManageViewModel();
        }

        public void AdminUserManageView()
        {
            Content = new AdminUserManageViewModel();
        }

        public void OnClickDDMenu()
        {
            Content = new TopMenubarViewModel();
        }
    }
}
