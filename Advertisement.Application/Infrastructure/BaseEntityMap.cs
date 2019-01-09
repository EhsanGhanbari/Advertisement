
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Entity.ModelConfiguration;

namespace Advertisement.Application.Infrastructure
{
    internal abstract class BaseEntityMap<TEntity> : EntityTypeConfiguration<TEntity> where TEntity : BaseEntity
    {
        protected BaseEntityMap()
        {
            HasKey(e => e.Id).Property(e => e.Id).HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();
            Property(c => c.CreateDate).HasColumnType(SqlDbType.DateTime.ToString()).IsRequired();
            Property(c => c.UpdateDate).HasColumnType(SqlDbType.DateTime.ToString()).IsRequired();
        }
    }
}
