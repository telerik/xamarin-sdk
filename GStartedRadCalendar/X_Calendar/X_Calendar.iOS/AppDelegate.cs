using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

[assembly: Xamarin.Forms.ExportRenderer(typeof(Telerik.XamarinForms.Input.RadCalendar), typeof(Telerik.XamarinForms.InputRenderer.iOS.CalendarRenderer))]

namespace X_Calendar.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            new Telerik.XamarinForms.InputRenderer.iOS.CalendarRenderer();
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new X_Calendar.App());

            return base.FinishedLaunching(app, options);
        }
    }
}