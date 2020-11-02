using System;
using System.Collections.Generic;
using System.Text;

namespace VejledningBooking.Domain.Model
{
    public class BookingType
    {
        public Guid Id { get; }


        //duration in minutes
        public int Duration { get; }

        BookingType(Guid id, int duration)
        {
            Id = id;
            Duration = duration;
        }


    }
}
