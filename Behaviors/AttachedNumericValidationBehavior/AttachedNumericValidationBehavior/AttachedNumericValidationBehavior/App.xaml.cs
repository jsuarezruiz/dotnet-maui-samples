using Application = Microsoft.Maui.Controls.Application;

namespace AttachedNumericValidationBehavior
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new HomePage();
        }
    }
}
