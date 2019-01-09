using System;
using System.Data.Entity;
using Advertisement.Application.Helpers;

namespace Advertisement.Application.Infrastructure
{
    internal class AdvDbDbContext : DbContext
    {
        public AdvDbDbContext() : base("AdvConnection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Adv");

            var typesToRegister = TypeFinder.GetAllGenericTypesOf(typeof(BaseEntityMap<>));

            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(configurationInstance);
                base.OnModelCreating(modelBuilder);
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}

