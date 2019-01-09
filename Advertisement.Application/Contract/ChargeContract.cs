using Advertisement.Application.Entities;
using Advertisement.Application.Infrastructure;

namespace Advertisement.Application.Contract
{
    public interface IChargeContract : IBaseContract<Charge>
    {

    }

    internal class ChargeContract : BaseContract<Charge>, IChargeContract
    {
        public ChargeContract(AdvDbDbContext advDbDbContext) : base(advDbDbContext)
        {
        }
    }
}
