using System.Data;
using Advertisement.Application.Entities;
using Advertisement.Application.Infrastructure;

namespace Advertisement.Application.Mappings
{
   internal class UserMap : BaseEntityMap<User>
    {
        public UserMap()
        {
            ToTable("User", "Adv");
            Property(c => c.Email).HasColumnType(SqlDbType.NVarChar.ToString()).HasMaxLength(100).IsRequired();
            Property(c => c.Password).HasColumnType(SqlDbType.NVarChar.ToString()).HasMaxLength(200).IsRequired();
            Property(c => c.EmailValidationCode).HasColumnType(SqlDbType.NVarChar.ToString()).HasMaxLength(20).IsOptional();
            Property(c => c.Family).HasColumnType(SqlDbType.NVarChar.ToString()).HasMaxLength(100).IsRequired();
            Property(c => c.HasEmailActicationCode).HasColumnType(SqlDbType.Bit.ToString()).IsOptional();
            Property(c => c.HasMobileValidationCode).HasColumnType(SqlDbType.Bit.ToString()).IsOptional();
            Property(c => c.IsActive).HasColumnType(SqlDbType.Bit.ToString()).IsOptional();
            Property(c => c.MobileValidationCode).HasColumnType(SqlDbType.NVarChar.ToString()).HasMaxLength(20).IsOptional();
            Property(c => c.Name).HasColumnType(SqlDbType.NVarChar.ToString()).HasMaxLength(100).IsRequired();
            Property(c => c.Phone).HasColumnType(SqlDbType.NVarChar.ToString()).HasMaxLength(20).IsOptional();

            HasMany(c => c.Charges).WithMany(d => d.Users).Map(m =>
            {
                m.MapLeftKey("UserId");
                m.MapRightKey("ChargeId");
                m.ToTable("User_Charge");
            });

            HasMany(c => c.Campains).WithMany(d => d.Users).Map(m =>
            {
                m.MapLeftKey("UserId");
                m.MapRightKey("CampainId");
                m.ToTable("User_Campain");
            });
        }
    }
}

