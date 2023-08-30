using System;
using System.Collections.Generic;

namespace SRP
{
    public class Sector
    {
        public string Sectorid { get; set; }
        public List<Shelve> listshelve { get; set; }
        public Sector(string sector)
        {
            Sectorid=sector;
            listshelve=new List<Shelve>();
        }
        public void AddShelve(Shelve shelve)
        {
            listshelve.Add(shelve);
        }
    }
}