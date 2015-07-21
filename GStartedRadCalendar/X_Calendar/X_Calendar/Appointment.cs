using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.XamarinForms.Input;

namespace X_Calendar
{
    public class Appointment : IAppointment
    {
        public DateTime EndDate
        {
            get;
            set;
        }

        public DateTime StartDate
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        }
    }
}