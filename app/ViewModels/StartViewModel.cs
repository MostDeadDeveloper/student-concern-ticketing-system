namespace app.ViewModels
{
    class StartViewModel : ViewModelBase
    {
        private string? Text; 
        public string? Start {
            set { Text="This is Start View";}
        }
    }
}