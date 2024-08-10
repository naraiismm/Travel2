using Core.DataAccess.Abstract;
using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace Core.DataAccess.Concrete
{
    public class BaseRepository<TEntity, TContext> (TContext context): IBaseRepository<TEntity>
    
        where TEntity :class,IEntity,new ()
        where TContext : DbContext,new ()
        {
        private readonly TContext _context = context;
        public void Add(TEntity entity)
        {
             var addedEntity=_context.Entry(entity);
            addedEntity.State = EntityState.Added;
                
                context.SaveChanges();

            

        }

        public void Delete(TEntity entity)
        {
           using(TContext context = new TContext())
            {
                var deleteEntity=context.Entry(entity);
                deleteEntity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using TContext context = new TContext();
                return context.Set<TEntity>().SingleOrDefault(filter);
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using TContext context = new TContext();
                return context.Set<TEntity>().Where(filter).ToList();
        }

        public void Update(TEntity entity)
        {
            using(TContext context=new TContext())
            {
                var updateEntity = context.Entry(entity);
                updateEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
            
        }
    }
}
