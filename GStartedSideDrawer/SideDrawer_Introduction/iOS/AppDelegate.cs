using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using UIKit;

[assembly: Xamarin.Forms.ExportRenderer(typeof(Telerik.XamarinForms.Chart.RadCartesianChart), typeof(Telerik.XamarinForms.ChartRenderer.iOS.CartesianChartRenderer))]
[assembly: Xamarin.Forms.ExportRenderer(typeof(Telerik.XamarinForms.Chart.RadPieChart), typeof(Telerik.XamarinForms.ChartRenderer.iOS.PieChartRenderer))]
[assembly: Xamarin.Forms.ExportRenderer(typeof(Telerik.XamarinForms.Input.RadCalendar), typeof(Telerik.XamarinForms.InputRenderer.iOS.CalendarRenderer))]
[assembly: Xamarin.Forms.ExportRenderer(typeof(Telerik.XamarinForms.DataControls.RadListView), typeof(Telerik.XamarinForms.DataControlsRenderer.iOS.ListViewRenderer))]
[assembly: Xamarin.Forms.ExportRenderer(typeof(Telerik.XamarinForms.Primitives.RadSideDrawer), typeof(Telerik.XamarinForms.PrimitivesRenderer.iOS.SideDrawerRenderer))]
[assembly: Xamarin.Forms.ExportRenderer(typeof(Telerik.XamarinForms.Input.RadDataForm), typeof(Telerik.XamarinForms.InputRenderer.iOS.DataFormRenderer))]

namespace SideDrawer_Introduction.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            new Telerik.XamarinForms.DataControlsRenderer.iOS.ListViewRenderer();
            new Telerik.XamarinForms.ChartRenderer.iOS.PieChartRenderer();
            new Telerik.XamarinForms.ChartRenderer.iOS.CartesianChartRenderer();
            new Telerik.XamarinForms.InputRenderer.iOS.CalendarRenderer();
            new Telerik.XamarinForms.PrimitivesRenderer.iOS.SideDrawerRenderer();

            global::Xamarin.Forms.Forms.Init();
            Telerik.XamarinForms.Common.iOS.TelerikForms.Init();
            LoadApplication(new Portable.App());

            return base.FinishedLaunching(app, options);
        }
    }
}
