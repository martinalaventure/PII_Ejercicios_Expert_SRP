using System;
using System.Text;

namespace Library
{
    public class Appointment
    {
        public string name { get; set;}
        public string id { get; set;}
        public string phoneNumber { get; set;}
        public DateTime date { get; set;}
        public string appointmentPlace { get; set;}
        public string doctorName { get; set;}
        public bool isValid()
        {
            return !string.IsNullOrEmpty(name) &&
                   !string.IsNullOrEmpty(id) &&
                   !string.IsNullOrEmpty(phoneNumber) &&
                   !string.IsNullOrEmpty(appointmentPlace) &&
                   !string.IsNullOrEmpty(doctorName);
        }
    }
}