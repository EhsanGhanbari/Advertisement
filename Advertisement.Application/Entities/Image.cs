using System.Collections.Generic;
using Advertisement.Application.Infrastructure;

namespace Advertisement.Application.Entities
{
    public class Image : BaseEntity
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public ICollection<Advertisement> Advertisements { get; set; } 
    }
}
