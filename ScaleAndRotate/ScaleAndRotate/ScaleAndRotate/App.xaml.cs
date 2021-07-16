using Microsoft.Maui.Controls;
using Application = Microsoft.Maui.Controls.Application;

namespace ScaleAndRotate
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new HomePage());
        }
    }
}
