using System;

[assembly: Xamarin.Forms.Platform.WinRT.ExportRenderer(typeof(Telerik.XamarinForms.Chart.RadCartesianChart), typeof(Telerik.XamarinForms.ChartRenderer.WinRT.CartesianChartRenderer))]
[assembly: Xamarin.Forms.Platform.WinRT.ExportRenderer(typeof(Telerik.XamarinForms.Chart.RadPieChart), typeof(Telerik.XamarinForms.ChartRenderer.WinRT.PieChartRenderer))]
[assembly: Xamarin.Forms.Platform.WinRT.ExportRenderer(typeof(Telerik.XamarinForms.Input.RadCalendar), typeof(Telerik.XamarinForms.InputRenderer.WinRT.CalendarRenderer))]
[assembly: Xamarin.Forms.Platform.WinRT.ExportRenderer(typeof(Telerik.XamarinForms.Primitives.RadSideDrawer), typeof(Telerik.XamarinForms.PrimitivesRenderer.WinRT.SideDrawerRenderer))]
[assembly: Xamarin.Forms.Platform.WinRT.ExportRenderer(typeof(Telerik.XamarinForms.DataControls.RadListView), typeof(Telerik.XamarinForms.DataControlsRenderer.WinRT.ListViewRenderer))]
namespace SideDrawer_Introduction.WinRT
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            Telerik.XamarinForms.Common.WinRT.TelerikForms.Init();
            this.InitializeComponent();

            LoadApplication(new Portable.App());
        }
    }
}