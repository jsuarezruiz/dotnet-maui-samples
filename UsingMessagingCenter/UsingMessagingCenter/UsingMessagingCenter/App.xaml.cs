using Application = Microsoft.Maui.Controls.Application;

namespace UsingMessagingCenter
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }
    }
}
