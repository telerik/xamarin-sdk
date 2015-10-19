using System;
using System.Linq;
using CustomizableListView;
using CustomizableListView.iOS;
using Foundation;
using Telerik.XamarinForms.Common.iOS;
using Telerik.XamarinForms.DataControlsRenderer.iOS;
using UIKit;

[assembly:ExportTypeConverter(typeof(Song), typeof(SongNS))]
[assembly: Xamarin.Forms.ExportRenderer(typeof(Telerik.XamarinForms.DataControls.RadListView), typeof(Telerik.XamarinForms.DataControlsRenderer.iOS.ListViewRenderer))]
namespace CustomizableListView.iOS
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
            new ListViewRenderer();
            global::Xamarin.Forms.Forms.Init();
            TelerikForms.Init();
            this.LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }

    public class SongNS : ConvertibleObject<Song>
    {
        public SongNS(Song song) : base(song)
        {
        }

        [Export("Title")]
        public string Title
        {
            get
            {
                return this.Instance.Title;
            }
            set
            {
                this.Instance.Title = value;
            }
        }

        [Export("Author")]
        public string Author
        {
            get
            {
                return this.Instance.Author;
            }
            set
            {
                this.Instance.Author = value;
            }
        }

        [Export("Album")]
        public string Album
        {
            get
            {
                return this.Instance.Album;
            }
            set
            {
                this.Instance.Album = value;
            }
        }

        [Export("AlbumArt")]
        public string AlbumArt
        {
            get
            {
                return this.Instance.AlbumArt;
            }
            set
            {
                this.Instance.AlbumArt = value;
            }
        }

        [Export("IsFavourite")]
        public bool IsFavourite
        {
            get
            {
                return this.Instance.IsFavourite;
            }
            set
            {
                this.Instance.IsFavourite = value;
            }
        }
    }
}