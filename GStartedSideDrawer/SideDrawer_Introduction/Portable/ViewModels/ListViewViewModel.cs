using System.Collections.Generic;

namespace Portable
{
    public class ListViewViewModel : ViewModel
    {
        public ListViewViewModel()
        {
            this.BinariesList = this.GetListViewBinariesList();
        }

        private List<DataObject> GetListViewBinariesList()
        {
            var result = new List<DataObject>();
            result.Add(new DataObject("Portable", "Telerik.XamarinForms.DataControls"));
            result.Add(new DataObject("Portable", "Telerik.XamarinForms.Common"));

            result.Add(new DataObject("Android", "Telerik.Xamarin.Android.Common"));
            result.Add(new DataObject("Android", "Telerik.Xamarin.Android.Input"));
            result.Add(new DataObject("Android", "Telerik.Xamarin.Android.Data"));
            result.Add(new DataObject("Android", "Telerik.Xamarin.Android.List"));
            result.Add(new DataObject("Android", "Telerik.XamarinForms.Common"));
            result.Add(new DataObject("Android", "Telerik.XamarinForms.DataControls"));
            result.Add(new DataObject("Android", "Telerik.XamarinForms.DataControlsRenderer.Android"));
            result.Add(new DataObject("Android", "Telerik.XamarinForms.Common.Android"));

            result.Add(new DataObject("iOS", "Telerik.Xamarin.iOS"));
            result.Add(new DataObject("iOS",  "Telerik.XamarinForms.DataControls"));
            result.Add(new DataObject("iOS",  "Telerik.XamarinForms.Common"));
            result.Add(new DataObject("iOS",  "Telerik.XamarinForms.DataControlsRenderer.iOS"));
            result.Add(new DataObject("iOS", "Telerik.XamarinForms.Common.iOS"));

            result.Add(new DataObject("UWP", "Telerik.Core"));
            result.Add(new DataObject("UWP", "Telerik.Data"));
            result.Add(new DataObject("UWP", "Telerik.UI.Xaml.Input.UWP"));
            result.Add(new DataObject("UWP", "Telerik.UI.Xaml.Primitives.UWP"));
            result.Add(new DataObject("UWP", "Telerik.UI.Xaml.Controls.Data.UWP"));
            result.Add(new DataObject("UWP", "Telerik.XamarinForms.Common"));
            result.Add(new DataObject("UWP", "Telerik.XamarinForms.DataControls"));
            result.Add(new DataObject("UWP", "Telerik.XamarinForms.Common.UWP"));
            result.Add(new DataObject("UWP", "Telerik.XamarinForms.DataControlsRenderer.UWP"));

            result.Add(new DataObject("Windows 8.1", "Telerik.Core"));
            result.Add(new DataObject("Windows 8.1", "Telerik.Data"));
            result.Add(new DataObject("Windows 8.1", "Telerik.UI.Xaml.Input"));
            result.Add(new DataObject("Windows 8.1", "Telerik.UI.Xaml.Primitives"));
            result.Add(new DataObject("Windows 8.1", "Telerik.UI.Xaml.Controls.Data"));
            result.Add(new DataObject("Windows 8.1", "Telerik.XamarinForms.Common"));
            result.Add(new DataObject("Windows 8.1", "Telerik.XamarinForms.DataControls"));
            result.Add(new DataObject("Windows 8.1", "Telerik.XamarinForms.Common.WinRT.Windows"));
            result.Add(new DataObject("Windows 8.1", "Telerik.XamarinForms.DataControlsRenderer.WinRT.Windows"));

            result.Add(new DataObject("Windows Phone 8.1", "Telerik.Core"));
            result.Add(new DataObject("Windows Phone 8.1", "Telerik.Data"));
            result.Add(new DataObject("Windows Phone 8.1", "Telerik.UI.Xaml.Input"));
            result.Add(new DataObject("Windows Phone 8.1", "Telerik.UI.Xaml.Primitives"));
            result.Add(new DataObject("Windows Phone 8.1", "Telerik.UI.Xaml.Controls.Data"));
            result.Add(new DataObject("Windows Phone 8.1", "Telerik.XamarinForms.Common"));
            result.Add(new DataObject("Windows Phone 8.1", "Telerik.XamarinForms.DataControls"));
            result.Add(new DataObject("Windows Phone 8.1", "Telerik.XamarinForms.Common.WinRT.WindowsPhone"));
            result.Add(new DataObject("Windows Phone 8.1", "Telerik.XamarinForms.DataControlsRenderer.WinRT.WindowsPhone"));

            return result;
        }
    }
}