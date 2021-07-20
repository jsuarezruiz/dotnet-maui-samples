using System.Diagnostics;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace WorkingWithListview
{
    /// <summary>
    /// Use ContextActions 
    /// </summary>
    public class ContextActionsCell : ViewCell
    {
        public ContextActionsCell()
        {
            var label1 = new Label { Text = "Label 1", TextColor = Colors.Black, FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)), FontAttributes = FontAttributes.Bold };
            label1.SetBinding(Label.TextProperty, new Binding("."));
            var hint = Device.RuntimePlatform == Device.iOS ? "Tip: swipe left for context action" : "Tip: long press for context action";
            var label2 = new Label { Text = hint, TextColor = Colors.Black, FontSize = Device.GetNamedSize(NamedSize.Micro, typeof(Label)) };

            //
            // define context actions
            //
            var moreAction = new MenuItem { Text = "More" };
            moreAction.SetBinding(MenuItem.CommandParameterProperty, new Binding("."));
            moreAction.Clicked += (sender, e) =>
            {
                var mi = ((MenuItem)sender);
                Debug.WriteLine("More Context Action clicked: " + mi.CommandParameter);
            };

            var deleteAction = new MenuItem { Text = "Delete", IsDestructive = true }; // red background
            deleteAction.SetBinding(MenuItem.CommandParameterProperty, new Binding("."));
            deleteAction.Clicked += (sender, e) =>
            {
                var mi = ((MenuItem)sender);
                Debug.WriteLine("Delete Context Action clicked: " + mi.CommandParameter);
            };

            //
            // add context actions to the cell
            //
            ContextActions.Add(moreAction);
            ContextActions.Add(deleteAction);



            View = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                Padding = new Thickness(15, 5, 5, 15),
                Children = {
                    new StackLayout {
                        Orientation = StackOrientation.Vertical,
                        Children = { label1, label2 }
                    }
                }
            };
        }
    }
}