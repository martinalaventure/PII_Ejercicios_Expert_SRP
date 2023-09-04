using System;
using System.Text;

namespace Library
{
    public class Appointment
    {
        public DateTime date { get; set;}
        public string appointmentPlace { get; set;}
        public Appointment(DateTime date, string appointmentPlace)
        {
            this.date = date;
            this.appointmentPlace = appointmentPlace;  
        }
    }
}