using Telerik.XamarinForms.Input;
using Xamarin.Forms;

namespace Test
{
	public partial class TestPage : ContentPage
	{
		public TestPage()
		{
			InitializeComponent();
			this.Content = new RadCalendar();
		}
	}
}
