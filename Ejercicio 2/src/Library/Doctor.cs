using System;
using System.Text;

namespace Library
{
    public class Doctor
    {
        public string doctorName { get; set;}
        public string specialization { get; set;}
        public Doctor(string doctorName, string specialization)
        {
            this.doctorName = doctorName;
            this.specialization = specialization;
        }
    }

}