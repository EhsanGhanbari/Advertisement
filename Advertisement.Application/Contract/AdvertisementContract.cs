using Advertisement.Application.Infrastructure;

namespace Advertisement.Application.Contract
{
    public interface IAdvertisementContract : IBaseContract<Entities.Advertisement>
    {

    }

    internal class AdvertisementContract : BaseContract<Entities.Advertisement>, IAdvertisementContract
    {
        public AdvertisementContract(AdvDbDbContext advDbDbContext) : base(advDbDbContext)
        {
        }
    }
}
