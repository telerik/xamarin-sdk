using Xamarin.Forms;

namespace Portable
{
    public class App : Application
    {
        public App()
        {
            var start = new StartPage();
            NavigationPage.SetHasNavigationBar(start, false);
            MainPage = new NavigationPage(start);
            //MainPage = new MasterDetailPage() { }
        }
    }
}