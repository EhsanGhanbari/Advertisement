using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Advertisement.Application.Infrastructure
{
    public interface IBaseContract<TEntity> where TEntity : BaseEntity
    {
        void Add(TEntity entity);

        void Remove(TEntity entity);

        void Update(TEntity entity);

        TEntity GetById(Guid id);

        IList<TEntity> GetAll();

        void Commit();
    }

    internal class BaseContract<TEntity> : IBaseContract<TEntity> where TEntity : BaseEntity
    {
        private readonly AdvDbDbContext _advDbDbContext;
        private IDbSet<TEntity> _entities;

        public BaseContract(AdvDbDbContext advDbDbContext)
        {
            _advDbDbContext = advDbDbContext;
        }

        protected virtual IDbSet<TEntity> Entities => _entities ?? (_entities = _advDbDbContext.Set<TEntity>());

        public void Add(TEntity entity)
        {
            AddBaseEntityStuff(entity);
            Entities.Add(entity);
        }

        public void Remove(TEntity entity)
        {
            Entities.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            UpdateBaseEntityStuff(entity);
            Entities.AddOrUpdate(entity);
        }

        public TEntity GetById(Guid id)
        {
            return Entities.Find(id);
        }

        public IList<TEntity> GetAll()
        {
            return Entities.ToList();
        }

        public void Commit()
        {
            _advDbDbContext.SaveChanges();
        }

        private void AddBaseEntityStuff(TEntity entity)
        {
            entity.CreateDate = DateTime.Now;
            entity.UpdateDate = DateTime.Now;
        }

        private void UpdateBaseEntityStuff(TEntity entity)
        {
            entity.UpdateDate = DateTime.Now;
        }
    }
}
