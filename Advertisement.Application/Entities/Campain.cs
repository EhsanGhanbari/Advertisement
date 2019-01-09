using System;
using System.Collections.Generic;
using Advertisement.Application.Infrastructure;

namespace Advertisement.Application.Entities
{
    public class Campain : BaseEntity
    {
        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool IsActive { get; set; }

        public bool IsFinished { get; set; }

        public ICollection<User> Users { get; set; } 
    }
}
