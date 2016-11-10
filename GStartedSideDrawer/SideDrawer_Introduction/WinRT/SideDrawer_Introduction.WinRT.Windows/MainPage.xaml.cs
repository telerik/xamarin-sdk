using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

[assembly: Xamarin.Forms.Platform.WinRT.ExportRenderer(typeof(Telerik.XamarinForms.Chart.RadCartesianChart), typeof(Telerik.XamarinForms.ChartRenderer.WinRT.CartesianChartRenderer))]
[assembly: Xamarin.Forms.Platform.WinRT.ExportRenderer(typeof(Telerik.XamarinForms.Chart.RadPieChart), typeof(Telerik.XamarinForms.ChartRenderer.WinRT.PieChartRenderer))]
[assembly: Xamarin.Forms.Platform.WinRT.ExportRenderer(typeof(Telerik.XamarinForms.Input.RadCalendar), typeof(Telerik.XamarinForms.InputRenderer.WinRT.CalendarRenderer))]
[assembly: Xamarin.Forms.Platform.WinRT.ExportRenderer(typeof(Telerik.XamarinForms.Primitives.RadSideDrawer), typeof(Telerik.XamarinForms.PrimitivesRenderer.WinRT.SideDrawerRenderer))]
[assembly: Xamarin.Forms.Platform.WinRT.ExportRenderer(typeof(Telerik.XamarinForms.DataControls.RadListView), typeof(Telerik.XamarinForms.DataControlsRenderer.WinRT.ListViewRenderer))]

namespace SideDrawer_Introduction.WinRT
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
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
