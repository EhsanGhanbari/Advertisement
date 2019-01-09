using System;
using System.Collections.Generic;
using System.Linq;
namespace Advertisement.Application.Infrastructure
{
    public class BaseViewModel
    {
        public Guid Id { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime UpdateDate { get; set; }
    }
}
