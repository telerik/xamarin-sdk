using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portable
{
    public class ChartViewModel : ViewModel
    {
        public ChartViewModel()
        {
            this.BinariesList = this.GetChartBinariesList();
        }

        private List<DataObject> GetChartBinariesList()
        {
            var result = new List<DataObject>();
            result.Add(new DataObject("Portable", "Telerik.XamarinForms.Chart"));
            result.Add(new DataObject("Portable", "Telerik.XamarinForms.Common"));

            result.Add(new DataObject("Android", "Telerik.Xamarin.Android.Common"));
            result.Add(new DataObject("Android", "Telerik.Xamarin.Android.Chart"));
            result.Add(new DataObject("Android", "Telerik.Xamarin.Android.Primitives"));
            result.Add(new DataObject("Android", "Telerik.XamarinForms.Common"));
            result.Add(new DataObject("Android", "Telerik.XamarinForms.Chart"));
            result.Add(new DataObject("Android", "Telerik.XamarinForms.ChartRenderer.Android"));
            result.Add(new DataObject("Android", "Telerik.XamarinForms.Common.Android"));

            result.Add(new DataObject("iOS", "Telerik.Xamarin.iOS"));
            result.Add(new DataObject("iOS", "Telerik.XamarinForms.Chart"));
            result.Add(new DataObject("iOS", "Telerik.XamarinForms.Common"));
            result.Add(new DataObject("iOS", "Telerik.XamarinForms.ChartRenderer.iOS"));
            result.Add(new DataObject("iOS", "Telerik.XamarinForms.Common.iOS"));

            result.Add(new DataObject("UWP", "Telerik.Core"));
            result.Add(new DataObject("UWP", "Telerik.UI.Xaml.Chart.UWP"));
            result.Add(new DataObject("UWP", "Telerik.UI.Xaml.Primitives.UWP"));
            result.Add(new DataObject("UWP", "Telerik.XamarinForms.Common"));
            result.Add(new DataObject("UWP", "Telerik.XamarinForms.Chart"));
            result.Add(new DataObject("UWP", "Telerik.XamarinForms.Common.UWP"));
            result.Add(new DataObject("UWP", "Telerik.XamarinForms.ChartRenderer.UWP"));


            result.Add(new DataObject("Windows 8.1", "Telerik.Core"));
            result.Add(new DataObject("Windows 8.1", "Telerik.UI.Xaml.Chart"));
            result.Add(new DataObject("Windows 8.1", "Telerik.UI.Xaml.Primitives"));
            result.Add(new DataObject("Windows 8.1", "Telerik.XamarinForms.Common"));
            result.Add(new DataObject("Windows 8.1", "Telerik.XamarinForms.Chart"));
            result.Add(new DataObject("Windows 8.1", "Telerik.XamarinForms.Common.WinRT.Windows"));
            result.Add(new DataObject("Windows 8.1", "Telerik.XamarinForms.ChartRenderer.WinRT.Windows"));

            result.Add(new DataObject("Windows Phone 8.1", "Telerik.Core"));
            result.Add(new DataObject("Windows Phone 8.1", "Telerik.UI.Xaml.Chart"));
            result.Add(new DataObject("Windows Phone 8.1", "Telerik.UI.Xaml.Primitives"));
            result.Add(new DataObject("Windows Phone 8.1", "Telerik.XamarinForms.Common"));
            result.Add(new DataObject("Windows Phone 8.1", "Telerik.XamarinForms.Chart"));
            result.Add(new DataObject("Windows Phone 8.1", "Telerik.XamarinForms.Common.WinRT.WindowsPhone"));
            result.Add(new DataObject("Windows Phone 8.1", "Telerik.XamarinForms.ChartRenderer.WinRT.WindowsPhone"));

            result.Add(new DataObject("Windows Phone 8.0", "Telerik.Windows.Controls.Chart"));
            result.Add(new DataObject("Windows Phone 8.0", "Telerik.Windows.Controls.Primitives"));
            result.Add(new DataObject("Windows Phone 8.0", "Telerik.Windows.Core"));
            result.Add(new DataObject("Windows Phone 8.0", "Telerik.XamarinForms.Common"));
            result.Add(new DataObject("Windows Phone 8.0", "Telerik.XamarinForms.Chart"));
            result.Add(new DataObject("Windows Phone 8.0", "Telerik.XamarinForms.Common.WinPhone"));
            result.Add(new DataObject("Windows Phone 8.0", "Telerik.XamarinForms.ChartRenderer.WinPhone"));
            return result;
        }
    }
}
