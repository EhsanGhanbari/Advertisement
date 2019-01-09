using System.Collections.Generic;
using Advertisement.Application.Infrastructure;

namespace Advertisement.Application.Entities
{
    public class Advertisement : BaseEntity
    {
        public string Name { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public decimal Longitude { get; set; }

        public decimal Latitude { get; set; }

        public bool IsActive { get; set; }

        public ICollection<Image> Images { get; set; }
    }
}
