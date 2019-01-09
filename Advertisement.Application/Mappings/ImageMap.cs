using System.Data;
using Advertisement.Application.Entities;
using Advertisement.Application.Infrastructure;

namespace Advertisement.Application.Mappings
{
    internal class ImageMap : BaseEntityMap<Image>
    {
        public ImageMap()
        {
            ToTable("Image", "Adv");
            Property(c => c.Name).HasColumnType(SqlDbType.NVarChar.ToString()).IsRequired();
            Property(c => c.Address).HasColumnType(SqlDbType.NVarChar.ToString()).IsRequired();
        }
    }
}
