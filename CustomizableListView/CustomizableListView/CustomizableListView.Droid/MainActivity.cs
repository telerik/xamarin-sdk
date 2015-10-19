using System;
using Android.App;
using Android.Content.PM;
using Android.OS;
using Telerik.XamarinForms.Common.Android;

[assembly: Xamarin.Forms.ExportRenderer(typeof(Telerik.XamarinForms.DataControls.RadListView), typeof(CustomizableListView.Droid.CustomListViewRenderer))]
namespace CustomizableListView.Droid
{
    [Activity(Label = "CustomizableListView", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            TelerikForms.Init();
            this.LoadApplication(new App());
        }
    }
}