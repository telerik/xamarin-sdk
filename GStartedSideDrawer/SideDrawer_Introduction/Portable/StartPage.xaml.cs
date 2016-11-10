using System;
using Xamarin.Forms;
namespace Portable
{
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();

            var tap = new TapGestureRecognizer();
            tap.Tapped += HamburgetBtnPressed;
            this.ImageHolder.GestureRecognizers.Add(tap);

            this.AssemblyNameHolder.Text = "Home";
        }

        private void Calendar_Clicked(object sender, EventArgs e)
        {
            this.Drawer.IsOpen = false;
            var calendarPage = new SecondPage(new CalendarViewModel(), "Calendar");
            NavigationPage.SetHasNavigationBar(calendarPage, false);
            Navigation.PushAsync(calendarPage);
        }
        private void Chart_Clicked(object sender, EventArgs e)
        {
            this.Drawer.IsOpen = false;
            var chartPage = new SecondPage(new ChartViewModel(), "Chart");
            NavigationPage.SetHasNavigationBar(chartPage, false);
            Navigation.PushAsync(chartPage);
        }
        private void DataForm_Clicked(object sender, EventArgs e)
        {
            this.Drawer.IsOpen = false;
            var dataFormPage = new SecondPage(new DataFormViewModel(), "DataForm");
            NavigationPage.SetHasNavigationBar(dataFormPage, false);
            Navigation.PushAsync(dataFormPage);
        }
        private void ListView_Clicked(object sender, EventArgs e)
        {
            this.Drawer.IsOpen = false;
            var listViewPage = new SecondPage(new ListViewViewModel(), "ListView");
            NavigationPage.SetHasNavigationBar(listViewPage, false);
            Navigation.PushAsync(listViewPage);
        }
        private void SideDrawer_Clicked(object sender, EventArgs e)
        {
            this.Drawer.IsOpen = false;
            var sideDrawerPage = new SecondPage(new SideDrawerViewModel(), "SideDrawer");
            NavigationPage.SetHasNavigationBar(sideDrawerPage, false);
            Navigation.PushAsync(sideDrawerPage);
        }
        private void HamburgetBtnPressed(object sender, EventArgs e)
        {
            this.Drawer.IsOpen = true;
        }
    }
}