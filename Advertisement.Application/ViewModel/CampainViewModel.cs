using System;
using Advertisement.Application.Infrastructure;

namespace Advertisement.Application.ViewModel
{
    public class CampainViewModel : BaseViewModel
    {
        public string AdvId { get; set; }

        public string CampId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool IsActive { get; set; }

        public bool IsFinished { get; set; }
    }
}
