using System.Data;
using Advertisement.Application.Entities;
using Advertisement.Application.Infrastructure;

namespace Advertisement.Application.Mappings
{
    internal class ChargeMap : BaseEntityMap<Charge>
    {
        public ChargeMap()
        {
            ToTable("Charge", "Adv");
            Property(c => c.PaymentType).HasColumnType(SqlDbType.TinyInt.ToString()).IsRequired();
            Property(c => c.Amount).HasColumnType(SqlDbType.Decimal.ToString()).HasPrecision(18, 2).IsRequired();
            Property(c => c.PaymentDateTime).HasColumnType(SqlDbType.DateTime.ToString()).IsRequired();
        }
    }
}
