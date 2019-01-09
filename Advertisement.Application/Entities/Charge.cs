using System;
using System.Collections.Generic;
using Advertisement.Application.Infrastructure;

namespace Advertisement.Application.Entities
{
    public class Charge : BaseEntity
    {
        public decimal Amount { get; set; }

        public PaymentType PaymentType { get; set; }

        public DateTime PaymentDateTime { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
