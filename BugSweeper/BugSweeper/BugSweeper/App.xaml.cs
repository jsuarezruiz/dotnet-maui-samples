using Application = Microsoft.Maui.Controls.Application;

namespace BugSweeper
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new BugSweeperPage();
        }
    }
}
