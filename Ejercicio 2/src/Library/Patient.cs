using System;
using System.Text;

namespace Library
{
    public class Patient
    {
        public string name { get; set;}
        public string id { get; set;}
        public string phoneNumber { get; set;}
        public Patient(string name, string id, string phoneNumber)
        {
            this.name = name;
            this.id = id;
            this.phoneNumber = phoneNumber;
        }
    }
}