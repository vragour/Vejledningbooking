using System;
using System.Collections.Generic;
using System.Text;

namespace VejledningBooking.Domain.Model
{
    public class Booking
    {
        public Guid Id { get; }

        public DateTime BookingStartDatetime { get; } 
        public DateTime BookingEndDateTime { get; }
        public BookingType BookingType { get; set; }
        Booking(Guid id)
        {
            Id = id;
        }


    }
}
