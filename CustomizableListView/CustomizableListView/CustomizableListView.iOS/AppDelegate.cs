using Foundation;
using UIKit;
 
[assembly: Xamarin.Forms.ExportRenderer(typeof(Telerik.XamarinForms.DataControls.RadListView), typeof(Telerik.XamarinForms.DataControlsRenderer.iOS.ListViewRenderer))] 

namespace CustomizableListView.iOS
{ 
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    { 
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            new Telerik.XamarinForms.DataControlsRenderer.iOS.ListViewRenderer(); 

            global::Xamarin.Forms.Forms.Init();
            Telerik.XamarinForms.Common.iOS.TelerikForms.Init();
            this.LoadApplication(new CustomizableListView.App());

            return base.FinishedLaunching(app, options);
        }
    }
}
