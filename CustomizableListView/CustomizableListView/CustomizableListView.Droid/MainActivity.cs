using Android.App;
using Android.Content.PM;
using Android.OS;

[assembly: Xamarin.Forms.ExportRenderer(typeof(Telerik.XamarinForms.DataControls.RadListView), typeof(CustomizableListView.Droid.CustomListViewRenderer))]

namespace CustomizableListView.Droid
{
    [Activity(Label = "CustomizableListView.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            Telerik.XamarinForms.Common.Android.TelerikForms.Init();
            this.LoadApplication(new CustomizableListView.App());
        }
    }
}

