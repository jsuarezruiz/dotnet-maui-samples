using Microsoft.Maui.Controls;
using System;
using System.Windows.Input;

namespace ScaleAndRotate
{
    public partial class HomePage : ContentPage
    {
        public ICommand NavigateCommand { get; private set; }

        public HomePage()
        {
            InitializeComponent();

            NavigateCommand = new Command<Type>(async (pageType) =>
            {
                Page page = (Page)Activator.CreateInstance(pageType);
                await this.Navigation.PushAsync(page);
            });
            BindingContext = this;
        }
    }
}
