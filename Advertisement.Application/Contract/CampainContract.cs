using System.Collections.Generic;
using System.Linq;
using Advertisement.Application.Entities;
using Advertisement.Application.Infrastructure;

namespace Advertisement.Application.Contract
{
    public interface ICampainContract : IBaseContract<Campain>
    {
        IList<Campain> GetAllCampains();
    }

    internal class CampainContract : BaseContract<Campain>, ICampainContract
    {

        public CampainContract(AdvDbDbContext advDbDbContext) : base(advDbDbContext)
        {           
        }


        public IList<Campain> GetAllCampains()
        {
            return Entities.ToList();
        }
    }
}
