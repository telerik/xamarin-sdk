using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace ChartAnimations
{
	public partial class Page1 : ContentPage
	{
		public Page1()
		{
			this.Appearing += Page1_Appearing;

			InitializeComponent();
		}

		async void Page1_Appearing(object sender, EventArgs e)
		{
			await Task.Delay(30);

            LineSeries ser = new LineSeries();
            ser.ValueBinding = new PropertyNameDataPointBinding("Value");
            ser.CategoryBinding = new PropertyNameDataPointBinding("Name");
            this.chart.Series.Add(ser);
            ser.ItemsSource = new List<DataItem>{
				new DataItem() {Name = "Avocado", Value = 5},
				new DataItem() {Name = "Plum", Value = 6},
				new DataItem() {Name = "Orange", Value = 4},
				new DataItem() {Name = "Kiwi", Value = 5},
				new DataItem() {Name = "Nuts", Value = 10},
				new DataItem() {Name = "Lemon", Value = 6},
				new DataItem() {Name = "Banana", Value = 7},
			};
		}
	}
}
