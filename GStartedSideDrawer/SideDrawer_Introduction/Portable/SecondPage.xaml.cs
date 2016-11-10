using System;
using Xamarin.Forms;

namespace Portable
{
    public partial class SecondPage : ContentPage
    {
        public SecondPage(ViewModel viewModel, string header)
        {
            InitializeComponent();
            this.BindingContext = viewModel;
            this.Header.Text = header;

            var tap = new TapGestureRecognizer();
            tap.Tapped += BackBtnPressed;
            this.BackBtnHolder.GestureRecognizers.Add(tap);
        }

        private void BackBtnPressed(object sender, EventArgs e)
        {
            Navigation.PopAsync();
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
    }
}