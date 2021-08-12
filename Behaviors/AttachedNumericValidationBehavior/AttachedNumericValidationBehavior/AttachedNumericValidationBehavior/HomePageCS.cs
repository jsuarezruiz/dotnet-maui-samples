using Microsoft.Maui.Controls;

namespace AttachedNumericValidationBehavior
{
    public class HomePageCS : TabbedPage
	{
		public HomePageCS ()
		{
			Children.Add (new NumericValidationPageCS ());
		}
	}
}
