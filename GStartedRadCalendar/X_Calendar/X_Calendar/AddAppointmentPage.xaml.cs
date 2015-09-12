using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;

namespace X_Calendar
{
    public partial class AddAppointmentPage : ContentPage
    {
        public AddAppointmentPage()
        {
            InitializeComponent();
        }

        void DoneButtonClicked(object sender, EventArgs e)
        {
            MyStaticFields.Appointments.Add(new Appointment()
            {
                StartDate = startDatePicker.Date,
                EndDate = endDatePicker.Date.AddSeconds(1),
                Title = title.Text == null ? "(No Title)" : title.Text
            });

            Navigation.PopAsync(true);
        }
    }
}