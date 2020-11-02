using System;
using System.Collections.Generic;
using System.Text;

namespace VejledningBooking.Domain.Model
{
    public class Timeslot
    {

        /// <summary>
        ///     Used only by Entity framework
        /// </summary>
        /// 
        public Guid Id { get; }

        public List<Booking> bookings { get; }


        public DateTime SlotStartDateTime { get; }
        public DateTime SlotEndDateTime { get; }

        Timeslot(Guid id)
        {
            Id = id;
        }
    }
}
