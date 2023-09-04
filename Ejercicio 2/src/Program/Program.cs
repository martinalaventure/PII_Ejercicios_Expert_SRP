using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main()
        {
            Appointment appointment = new Appointment(DateTime.Now, "Clinic A");
            Patient patient = new Patient("Martina Laventure","5571876-9","098994321");
            Doctor doctor= new Doctor("Fernando Ruiz","Dermatologist");
            Validation validation = new Validation();

            AppointmentScheduler scheduler = new AppointmentScheduler();
            string result = scheduler.ScheduleAppointment(patient, doctor, appointment, validation);

            Console.WriteLine(result);
        }
    }
}
