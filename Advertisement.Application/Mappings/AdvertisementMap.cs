using System.Data;
using Advertisement.Application.Infrastructure;
using Advertisement.Application.Entities;

namespace Advertisement.Application.Mappings
{
    internal class AdvertisementMap : BaseEntityMap<Entities.Advertisement>
    {
        public AdvertisementMap()
        {
            ToTable("Advertisement", "Adv");
            Property(c => c.Title).HasColumnType(SqlDbType.NVarChar.ToString()).HasMaxLength(150).IsRequired();
            Property(c => c.Name).HasColumnType(SqlDbType.NVarChar.ToString()).HasMaxLength(100).IsRequired();
            Property(c => c.Description).HasColumnType(SqlDbType.NVarChar.ToString()).IsMaxLength().IsRequired();
            Property(c => c.IsActive).HasColumnType(SqlDbType.Bit.ToString()).IsRequired();
            Property(c => c.Latitude).HasColumnType(SqlDbType.Decimal.ToString()).IsRequired();
            Property(c => c.Longitude).HasColumnType(SqlDbType.Decimal.ToString()).IsRequired();

            HasMany(c => c.Images).WithMany(d => d.Advertisements).Map(m =>
            {
                m.MapLeftKey("AdvertisementId");
                m.MapRightKey("ImageId");
                m.ToTable("Advertisement_Image");
            });
        }
    }
}
