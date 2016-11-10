using System.Collections.Generic;

namespace Portable
{
    public class DataFormViewModel : ViewModel
    {
        public DataFormViewModel()
        {
            this.BinariesList = this.GetDataFormtBinariesList();
        }

        private List<DataObject> GetDataFormtBinariesList()
        {
            var result = new List<DataObject>();
            result.Add(new DataObject("Portable", "Telerik.XamarinForms.Input"));
            result.Add(new DataObject("Portable", "Telerik.XamarinForms.Common"));

            result.Add(new DataObject("Android", "Telerik.Xamarin.Android.Common"));
            result.Add(new DataObject("Android", "Telerik.Xamarin.Android.Input"));
            result.Add(new DataObject("Android", "Telerik.Xamarin.Android.Primitives"));
            result.Add(new DataObject("Android", "Telerik.XamarinForms.Common"));
            result.Add(new DataObject("Android", "Telerik.XamarinForms.Input"));
            result.Add(new DataObject("Android", "Telerik.XamarinForms.InputRenderer.Android"));
            result.Add(new DataObject("Android", "Telerik.XamarinForms.Common.Android"));

            result.Add(new DataObject("iOS", "Telerik.Xamarin.iOS"));
            result.Add(new DataObject("iOS", "Telerik.XamarinForms.Input"));
            result.Add(new DataObject("iOS", "Telerik.XamarinForms.Common"));
            result.Add(new DataObject("iOS", "Telerik.XamarinForms.InputRenderer.iOS"));
            result.Add(new DataObject("iOS", "Telerik.XamarinForms.Common.iOS"));

            result.Add(new DataObject("UWP", "Telerik.Core"));
            result.Add(new DataObject("UWP", "Telerik.Data"));
            result.Add(new DataObject("UWP", "Telerik.UI.Xaml.Input.UWP"));
            result.Add(new DataObject("UWP", "Telerik.UI.Xaml.Primitives.UWP"));
            result.Add(new DataObject("UWP", "Telerik.XamarinForms.Common"));
            result.Add(new DataObject("UWP", "Telerik.XamarinForms.Input"));
            result.Add(new DataObject("UWP", "Telerik.XamarinForms.Common.UWP"));
            result.Add(new DataObject("UWP", "Telerik.XamarinForms.InputRenderer.UWP"));

            result.Add(new DataObject("Windows 8.1", "Telerik.Core"));
            result.Add(new DataObject("Windows 8.1", "Telerik.Data"));
            result.Add(new DataObject("Windows 8.1", "Telerik.UI.Xaml.Input"));
            result.Add(new DataObject("Windows 8.1", "Telerik.UI.Xaml.Primitives"));
            result.Add(new DataObject("Windows 8.1", "Telerik.UI.Xaml.Controls.Data"));
            result.Add(new DataObject("Windows 8.1", "Telerik.XamarinForms.Common"));
            result.Add(new DataObject("Windows 8.1", "Telerik.XamarinForms.Input"));
            result.Add(new DataObject("Windows 8.1", "Telerik.XamarinForms.Common.WinRT.Windows"));
            result.Add(new DataObject("Windows 8.1", "Telerik.XamarinForms.InputRenderer.WinRT.Windows"));


            result.Add(new DataObject("Windows Phone 8.1", "Telerik.Core"));
            result.Add(new DataObject("Windows Phone 8.1", "Telerik.Data"));
            result.Add(new DataObject("Windows Phone 8.1", "Telerik.UI.Xaml.Input"));
            result.Add(new DataObject("Windows Phone 8.1", "Telerik.UI.Xaml.Primitives"));
            result.Add(new DataObject("Windows Phone 8.1", "Telerik.UI.Xaml.Controls.Data"));
            result.Add(new DataObject("Windows Phone 8.1", "Telerik.XamarinForms.Common"));
            result.Add(new DataObject("Windows Phone 8.1", "Telerik.XamarinForms.Input"));
            result.Add(new DataObject("Windows Phone 8.1", "Telerik.XamarinForms.Common.WinRT.WindowsPhone"));
            result.Add(new DataObject("Windows Phone 8.1", "Telerik.XamarinForms.InputRenderer.WinRT.WindowsPhone"));

            return result;
        }
    }
}