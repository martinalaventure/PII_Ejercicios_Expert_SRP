using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main()
        {
            Appointment appointment = new Appointment
            {
                name = "Martina Laventure",
                id = "5571876-9",
                phoneNumber = "098994321",
                date= DateTime.Now,
                appointmentPlace = "Clinic A",
                doctorName = "Jorge Ruiz"
            };
            AppointmentScheduler scheduler = new AppointmentScheduler();
            string result = scheduler.ScheduleAppointment(appointment);

            Console.WriteLine(result);
        }
    }
}
