using System;
using System.Collections.Generic;
using System.Text;

namespace VejledningBooking.Domain.Model
{
    public class Team
    {
        public Guid Id { get; }
        public Team(Guid id)
        {
            Id = id;
        }


        public List<Student> students { get; }
        public List<Teacher> teachers { get;  }

    }
}
