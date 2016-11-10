using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portable
{
    public class SideDrawerViewModel : ViewModel
    {
        public SideDrawerViewModel()
        {
            this.BinariesList = this.GetSideDrawerBinariesList();
        }

        private List<DataObject> GetSideDrawerBinariesList()
        {
            var result = new List<DataObject>();
            result.Add(new DataObject("Portable", "Telerik.XamarinForms.Primitives"));
            result.Add(new DataObject("Portable", "Telerik.XamarinForms.Common"));

            result.Add(new DataObject("Android", "Telerik.Xamarin.Android.Common"));
            result.Add(new DataObject("Android", "Telerik.Xamarin.Android.Primitives"));
            result.Add(new DataObject("Android", "Telerik.XamarinForms.Common"));
            result.Add(new DataObject("Android", "Telerik.XamarinForms.Primitives"));
            result.Add(new DataObject("Android", "Telerik.XamarinForms.PrimitivesRenderer.Android"));
            result.Add(new DataObject("Android", "Telerik.XamarinForms.Common.Android"));

            result.Add(new DataObject("iOS", "Telerik.Xamarin.iOS"));
            result.Add(new DataObject("iOS", "Telerik.XamarinForms.Primitives"));
            result.Add(new DataObject("iOS", "Telerik.XamarinForms.Common"));
            result.Add(new DataObject("iOS", "Telerik.XamarinForms.PrimitivesRenderer.iOS"));
            result.Add(new DataObject("iOS", "Telerik.XamarinForms.Common.iOS"));

            result.Add(new DataObject("UWP", "Telerik.Core"));
            result.Add(new DataObject("UWP", "Telerik.UI.Xaml.Primitives.UWP"));
            result.Add(new DataObject("UWP", "Telerik.XamarinForms.Common"));
            result.Add(new DataObject("UWP", "Telerik.XamarinForms.Primitives"));
            result.Add(new DataObject("UWP", "Telerik.XamarinForms.Common.UWP"));
            result.Add(new DataObject("UWP", "Telerik.XamarinForms.PrimitivesRenderer.UWP"));

            result.Add(new DataObject("Windows 8.1",  "Telerik.Core"));
            result.Add(new DataObject("Windows 8.1",  "Telerik.UI.Xaml.Primitives"));
            result.Add(new DataObject("Windows 8.1",  "Telerik.XamarinForms.Common"));
            result.Add(new DataObject("Windows 8.1",  "Telerik.XamarinForms.Primitives"));
            result.Add(new DataObject("Windows 8.1",  "Telerik.XamarinForms.Common.WinRT.Windows"));
            result.Add(new DataObject("Windows 8.1", "Telerik.XamarinForms.PrimitivesRenderer.WinRT.Windows"));

            result.Add(new DataObject("Windows Phone 8.1", "Telerik.Core"));
            result.Add(new DataObject("Windows Phone 8.1", "Telerik.UI.Xaml.Primitives"));
            result.Add(new DataObject("Windows Phone 8.1", "Telerik.XamarinForms.Common"));
            result.Add(new DataObject("Windows Phone 8.1", "Telerik.XamarinForms.Primitives"));
            result.Add(new DataObject("Windows Phone 8.1", "Telerik.XamarinForms.Common.WinRT.WindowsPhone"));
            result.Add(new DataObject("Windows Phone 8.1", "Telerik.XamarinForms.PrimitivesRenderer.WinRT.WindowsPhone"));

            return result;
        }
    }
}
