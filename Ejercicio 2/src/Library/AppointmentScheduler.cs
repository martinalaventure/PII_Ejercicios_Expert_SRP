using System;
using System.Text;

namespace Library
{
    public class AppointmentScheduler
    {
        public string ScheduleAppointment(Patient patient, Doctor doctor, Appointment appointment, Validation validation)
        {
            if (validation.IsValid(patient,appointment,doctor))
            {  
                return "Appointment scheduled";
            }  
            else
            {
                return "Unable to schedule appointment, some fields are missing";
            }

        }
    }
}