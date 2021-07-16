using Application = Microsoft.Maui.Controls.Application;

namespace TipCalc
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TipCalcPage();
        }
    }
}
