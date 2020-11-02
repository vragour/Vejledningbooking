using System;
using System.Collections.Generic;
using System.Text;
using VejledningBooking.Domain.Model;

namespace VejledningBooking.Domain.Model
{
    public class Teacher
    {

        public Guid Id { get; }
        public List<Calender> calendars { get; }

        
        Teacher(Guid id)
        {
            Id = id;
        }
        

    }
}
