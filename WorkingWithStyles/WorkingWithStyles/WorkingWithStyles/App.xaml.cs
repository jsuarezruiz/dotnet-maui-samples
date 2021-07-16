using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using Application = Microsoft.Maui.Controls.Application;

namespace WorkingWithStyles
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            if (Current.Resources == null)
            {
                Current.Resources = new ResourceDictionary();
            }

            var appStyle = new Style(typeof(Label))
            {
                BaseResourceKey = Device.Styles.SubtitleStyleKey,
                Setters = {
                    new Setter { Property = Label.TextColorProperty, Value = Colors.Green }
                }
            };
            Current.Resources.Add("AppStyle", appStyle);

            var boxStyle = new Style(typeof(BoxView))
            {
                Setters = {
                    new Setter { Property = BoxView.ColorProperty, Value = Colors.Aqua }
                }
            };
            Current.Resources.Add(boxStyle); // implicit style for ALL boxviews

            var tabs = new TabbedPage();
            tabs.Children.Add(new StylePage { Title = "C#", IconImageSource = "csharp.png" });
            tabs.Children.Add(new StyleXaml { Title = "Xaml", IconImageSource = "xaml.png" });
            tabs.Children.Add(new DynamicResourceXaml { Title = "Dynamic", IconImageSource = "xaml.png" });

            //tabs.Children.Add (new OldResourceDictionary {Title = "Old", IconImageSource = "xaml.png"});

            MainPage = tabs;
        }
    }
}
