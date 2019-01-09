using System.Data;
using Advertisement.Application.Entities;
using Advertisement.Application.Infrastructure;

namespace Advertisement.Application.Mappings
{
    internal class CampainMap : BaseEntityMap<Campain>
    {
        public CampainMap()
        {
            ToTable("Campain", "Adv");

            Property(c => c.Name).HasColumnType(SqlDbType.NVarChar.ToString()).HasMaxLength(100).IsRequired();
            Property(c => c.EndDate).HasColumnType(SqlDbType.DateTime.ToString()).IsRequired();
            Property(c => c.StartDate).HasColumnType(SqlDbType.DateTime.ToString()).IsRequired();
            Property(c => c.IsActive).HasColumnType(SqlDbType.Bit.ToString()).IsRequired();
            Property(c => c.IsFinished).HasColumnType(SqlDbType.Bit.ToString()).IsRequired();
        }
    }
}
