using System;
using Telerik.XamarinForms.Common;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GridLikeListView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GridFilteringControl : ContentView
    {
        private readonly SortOrder?[] sortOrders = { null, SortOrder.Ascending, SortOrder.Descending };
        private int currentSortOrder;

        public GridFilteringControl()
        {
            this.InitializeComponent();

            TapGestureRecognizer headerTapRecognizer = new TapGestureRecognizer();
            headerTapRecognizer.Tapped += this.HeaderTapRecognizer_Tapped;
            this.headerContainer.GestureRecognizers.Add(headerTapRecognizer);

            this.picker.ItemsSource = Enum.GetValues(typeof(FilterMode));
            this.picker.SelectedIndexChanged += this.Picker_SelectedIndexChanged;
            this.picker.SelectedIndex = 0;
        }

        public event EventHandler OnSortOrderChanged;
        public event EventHandler OnFilterChanged;

        public SortOrder? SelectedSortOrder
        {
            get
            {
                return this.sortOrders[this.currentSortOrder];
            }
        }

        public FilterMode SelectedFilterMode { get; private set; }

        public string ColumnName { get; set; }

        public string HeaderText
        {
            get
            {
                return this.header.Text;
            }
            set
            {
                this.header.Text = value;
            }
        }

        public string FilterValue
        {
            get
            {
                return this.inputEntry.Text;
            }
        }

        private void OnClearFilterClicked(object sender, EventArgs e)
        {
            this.inputEntry.Text = string.Empty;

            this.OnFilterChanged?.Invoke(this, EventArgs.Empty);
        }

        private void OnApplyFilterClicked(object sender, EventArgs e)
        {
            this.OnFilterChanged?.Invoke(this, EventArgs.Empty);
        }

        private void HeaderTapRecognizer_Tapped(object sender, EventArgs e)
        {
            StackLayout stackLayout = (StackLayout)sender;

            Image icon = (Image)stackLayout.Children[1];

            this.currentSortOrder++;
            this.currentSortOrder %= 3;

            switch (this.SelectedSortOrder)
            {
                case null:
                    icon.Source = null;
                    break;
                case SortOrder.Ascending:
                    icon.Source = (FileImageSource)ImageSource.FromFile(this.ConvertIconPath("sortascending.png"));
                    break;
                case SortOrder.Descending:
                    icon.Source = (FileImageSource)ImageSource.FromFile(this.ConvertIconPath("sortdescending.png"));
                    break;
            }

            this.OnSortOrderChanged?.Invoke(this, EventArgs.Empty);
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedFilterMode = (FilterMode)this.picker.SelectedItem;
        }

        private string ConvertIconPath(string path)
        {
            if (Device.RuntimePlatform == Device.Windows)
            {
                return "Assets/" + path;
            }

            return path;
        }
    }
}