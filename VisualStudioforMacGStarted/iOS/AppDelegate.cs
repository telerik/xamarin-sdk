using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using Telerik.XamarinForms.Common.iOS;
using UIKit;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(Telerik.XamarinForms.Input.RadCalendar), typeof(Telerik.XamarinForms.InputRenderer.iOS.CalendarRenderer))]

namespace Test.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			new Telerik.XamarinForms.InputRenderer.iOS.CalendarRenderer();

			global::Xamarin.Forms.Forms.Init();
			TelerikForms.Init();

			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}
}
