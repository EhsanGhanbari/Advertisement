using System.Collections.Generic;
using System.Text.RegularExpressions;
using Advertisement.Application.Infrastructure;

namespace Advertisement.Application.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }

        public string Family { get; set; }

        public string Email { get; set; }

        public string EmailValidationCode { get; set; }

        public bool HasEmailActicationCode { get; set; }

        public string Phone { get; set; }

        public string MobileValidationCode { get; set; }

        public bool HasMobileValidationCode { get; set; }

        public string Password { get; set; }

        public bool IsActive { get; set; }

        public ICollection<Charge> Charges { get; set; }

        public ICollection<Campain> Campains { get; set; }
    }
}
