using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace UsingMessagingCenter
{
    public class MainPageViewModel
    {
        public ObservableCollection<string> Greetings { get; set; }

        public MainPageViewModel()
        {
            Greetings = new ObservableCollection<string>();

            MessagingCenter.Subscribe<MainPage>(this, "Hi", (sender) =>
            {
                Greetings.Add("Hi");
            });

            MessagingCenter.Subscribe<MainPage, string>(this, "Hi", (sender, arg) =>
            {
                Greetings.Add("Hi " + arg);
            });
        }
    }
}

