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
    public partial class AppointmentsPage : ContentPage
    {
        static AppointmentsPage()
        {
            MyStaticFields.Appointments = new ObservableCollection<Appointment>() { new Appointment() { StartDate = DateTime.Now.AddDays(-1), EndDate = DateTime.Now.AddDays(-1).AddMinutes(1), Title = "Call Steve" } };
            MyStaticFields.Appointments.Add( new Appointment() { StartDate = DateTime.Now, EndDate = DateTime.Now.AddMinutes(1), Title = "Tickets" } );
            MyStaticFields.Appointments.Add(new Appointment() { StartDate = DateTime.Now.AddDays(3), EndDate = DateTime.Now.AddDays(3).AddMinutes(1), Title = "Travel" });
        }

        public AppointmentsPage()
        {
            InitializeComponent();

            this.calendar.AppointmentsSource = MyStaticFields.Appointments;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        void AddButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddAppointmentPage(), true);
        }

        void DeleteButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DeleteAppointmentPage(), true);
        }
    }
}