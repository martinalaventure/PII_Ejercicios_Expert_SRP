using System;
using System.Text;

namespace Library
{
    public class AppointmentScheduler
    {
        public string ScheduleAppointment(Appointment appointment)
        {
            if (appointment.isValid())
            {  
                return "Appointment scheduled";;
            }  
            else
            {
                return "Unable to schedule appointment, some fields are missing";
            }

        }
    }
}