using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace VejledningBooking.Domain.Model
{
    public class Calender
    {

        public Guid Id { get; }

        public List<Timeslot> Timeslots { get; set; }

        Calender(Guid id)
        {
            Id = id;
        }

    }
}
