using System;
using System.Collections.ObjectModel;
using Telerik.XamarinForms.DataControls.ListView;
using Xamarin.Forms;

namespace GridLikeListView
{
    public partial class MainPage : ContentPage
    {
        private const string FistNameColumn = "FirstName";
        private const string LastNameColumn = "LastName";
        private const string AgeColumn = "Age";
        private readonly string[] columnNames = { string.Empty, FistNameColumn, LastNameColumn, AgeColumn };

        public MainPage()
        {
            this.InitializeComponent();

            var data = new ObservableCollection<DataInfo>();

            Random r = new Random();
            for (int i = 0; i < 100; i++)
            {
                data.Add(new DataInfo()
                {
                    Id = (i + 1).ToString(),
                    FirstName = "First name " + i,
                    LastName = "Last name " + i,
                    Age = r.Next(21, 40),
                });
            }

            this.listView.ItemsSource = data;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            this.filteringGrid.IsVisible ^= true;
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            Picker picker = (Picker)sender;

            string propertyName = columnNames[picker.SelectedIndex];

            this.listView.GroupDescriptors.Clear();

            if (!string.IsNullOrEmpty(propertyName))
            {
                this.listView.GroupDescriptors.Add(new PropertyGroupDescriptor() { PropertyName = propertyName });
            }
        }

        private void OnSortOrderChanged(object sender, EventArgs e)
        {
            GridFilteringControl control = (GridFilteringControl)sender;

            this.listView.SortDescriptors.Clear();
            if (control.SelectedSortOrder.HasValue)
            {
                this.listView.SortDescriptors.Add(
                    new PropertySortDescriptor
                    {
                        PropertyName = control.ColumnName,
                        SortOrder = control.SelectedSortOrder.Value
                    });
            }
        }

        private void OnFilterChanged(object sender, EventArgs e)
        {
            GridFilteringControl control = (GridFilteringControl)sender;

            this.listView.FilterDescriptors.Clear();

            if (!string.IsNullOrEmpty(control.FilterValue))
            {
                this.listView.FilterDescriptors.Add(new DelegateFilterDescriptor
                {
                    Filter = (obj) =>
                    {
                        if (control.SelectedFilterMode == FilterMode.Contains)
                        {
                            return this.ContainsFilter(control.ColumnName, control.FilterValue, obj);
                        }

                        return this.IsEqualToFilter(control.ColumnName, control.FilterValue, obj);
                    }
                });
            }
        }

        private bool ContainsFilter(string propertyName, string value, object obj)
        {
            if (!string.IsNullOrEmpty(value))
            {
                DataInfo data = (DataInfo)obj;
                string propertyValue = this.GetPropertyValue(propertyName, data);

                return propertyValue.Contains(value);
            }

            return false;
        }

        private bool IsEqualToFilter(string propertyName, string value, object obj)
        {
            DataInfo data = (DataInfo)obj;
            string propertyValue = this.GetPropertyValue(propertyName, data);

            return propertyValue.Equals(value);
        }

        private string GetPropertyValue(string propertyName, DataInfo data)
        {
            switch (propertyName)
            {
                case FistNameColumn:
                    return data.FirstName;
                case LastNameColumn:
                    return data.LastName;
                case AgeColumn:
                    return data.Age.ToString();

                default:
                    throw new ArgumentException();
            }
        }
    }
}
