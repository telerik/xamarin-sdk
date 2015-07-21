using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace X_Calendar
{
    public partial class DeleteAppointmentPage : ContentPage
    {
        public DeleteAppointmentPage()
        {
            InitializeComponent();

            this.list.ItemsSource = MyStaticFields.Appointments;
        }

        void DeleteButtonClicked(object sender, EventArgs e)
        {
            MyStaticFields.Appointments.Remove((Appointment)this.list.SelectedItem);
            Navigation.PopAsync();
        }
    }
}