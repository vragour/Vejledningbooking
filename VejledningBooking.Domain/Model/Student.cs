using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace VejledningBooking.Domain.Model
{
    public class Student
    {

        public Guid Id {get; }

        public string Name { get; set; }

        //public List<Team> Teams { get; }
        //public List<Booking> Bookings { get; }
        Student(Guid id, string name)
        {
            Id = id;
            Name = name;

        }



    }
}
