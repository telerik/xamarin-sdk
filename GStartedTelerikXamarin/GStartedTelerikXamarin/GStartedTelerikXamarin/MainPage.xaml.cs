using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace GStartedTelerikXamarin
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();

            BackgroundColor = Xamarin.Forms.Device.OnPlatform(Xamarin.Forms.Color.White, Xamarin.Forms.Color.White, Xamarin.Forms.Color.Transparent);

            var chart = new RadCartesianChart
            {
                HorizontalAxis = new Telerik.XamarinForms.Chart.CategoricalAxis()
                {
                    LabelFitMode = AxisLabelFitMode.MultiLine,
                },
                VerticalAxis = new Telerik.XamarinForms.Chart.NumericalAxis()
                {
                    LabelFitMode = AxisLabelFitMode.MultiLine,
                    RangeExtendDirection = NumericalAxisRangeExtendDirection.Both,
                    MajorStep = 30,
                },
            };

            var series = new BarSeries();
            chart.Series.Add(series);

            this.Content = chart;

            series.ValueBinding = new Telerik.XamarinForms.Chart.PropertyNameDataPointBinding
            {
                PropertyName = "Value"
            };

            series.CategoryBinding = new Telerik.XamarinForms.Chart.PropertyNameDataPointBinding
            {
                PropertyName = "Category"
            };

            series.ItemsSource = MainViewModel.GetCategoricalData();

            var grid = new CartesianChartGrid();

            grid.MajorLinesVisibility = GridLineVisibility.Y;
            grid.MajorYLineDashArray = Device.OnPlatform(null, new double[] { 4, 2 }, new double[] { 4, 2 });
            grid.StripLinesVisibility = GridLineVisibility.Y;

            grid.YStripeColor = Color.FromRgb(99, 99, 99);

            grid.YStripeAlternativeColor = Color.FromHex("1FA9A9A9");
            grid.MajorLineColor = Color.FromHex("D3D3D3");
            grid.MajorLineThickness = Device.OnPlatform(0.5, 2, 2);

            chart.Grid = grid;

            var treshold = MainViewModel.GetCategoricalData().Average(c => c.Value);
            var startTreshold = treshold * 0.95;
            var endTreshold = treshold * 1.05;

            var lineAnnotation = new CartesianGridLineAnnotation()
            {
                Axis = chart.VerticalAxis,
                Value = treshold,
                Stroke = Color.FromRgb(255, 0,0),
                StrokeThickness = Device.OnPlatform(0.5, 2, 2),
                DashArray = Device.OnPlatform(new double[] { 4, 2 }, new double[] { 4, 2 }, new double[] { 4, 2 })

            };

            var bandAnnotation = new CartesianPlotBandAnnotation()
            {
                Axis = chart.VerticalAxis,
                From = startTreshold,
                To = endTreshold,
                Fill = Color.FromRgba(0, 125, 0, 255),
                StrokeThickness = 2,
                Stroke = Color.Transparent,
            };

            chart.Annotations.Add(bandAnnotation);
            chart.Annotations.Add(lineAnnotation);
        }
    }
}
