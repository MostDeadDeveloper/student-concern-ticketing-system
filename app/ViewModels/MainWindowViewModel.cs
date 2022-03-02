using System;
using System.Collections.Generic;
using System.Text;
using ReactiveUI;
using app.Services;

namespace app.ViewModels
{
    class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel(Database db)
        {
            List = new TicketListViewModel(db.GetItems());
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
            Content = new StaffTicketViewModel();
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

        public void AdminAddUserView()
        {
            Content = new AdminAddUserViewModel();
        }

        public void AdminEditUserView()
        {
            Content = new AdminEditUserViewModel();
        }

        public void AdminAddSLAView()
        {
            Content = new AdminAddSLAViewModel();
        }

        public void AdminEditSLAView()
        {
            Content = new AdminEditSLAViewModel();
        }

        public void OnClickDDMenu()
        {
            Content = new TopMenubarViewModel();
        }
    }
}
