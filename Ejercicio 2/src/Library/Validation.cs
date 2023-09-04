using System;
using System.Text;

namespace Library
{
    public class Validation
    {
    public bool IsValid(Patient patient, Appointment appointment, Doctor doctor)
        {
            return !string.IsNullOrEmpty(patient.name) &&
                   !string.IsNullOrEmpty(patient.id) &&
                   !string.IsNullOrEmpty(patient.phoneNumber) &&
                   !string.IsNullOrEmpty(appointment.appointmentPlace) &&
                   !string.IsNullOrEmpty(doctor.doctorName);
        }
    }
}