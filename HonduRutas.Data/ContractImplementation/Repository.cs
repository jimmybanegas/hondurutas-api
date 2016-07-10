using HonduRutas.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Data.Entity;
using HonduRutas.Domain;

namespace HonduRutas.Data.ContractImplementation
{
    /// <summary>
    /// Implements IRepository for Entity Framework.
    /// </summary>
    public class Repository<TEntity> : DisposableBase, IRepository<TEntity>
        where TEntity : class, IEntity
    {
        public IUnitOfWork UnitOfWork { get; set; }

        /// <summary>
        /// Gets EF DbContext object.
        /// </summary>
        private readonly DbContext _context;

        /// <summary>
        /// Gets DbSet for given entity.
        /// </summary>
        protected virtual IDbSet<TEntity> EntitySet { get { return _context.Set<TEntity>(); } }

        public Repository(IUnitOfWork unitOfWork, DbContext dbContext)
        {
            UnitOfWork = unitOfWork;
            _context = dbContext;
        }

        /// <inheritdoc/>
        public IQueryable<TEntity> GetAll()
        {
            return EntitySet;
        }

        /// <inheritdoc/>
        public IEnumerable<TEntity> GetAllList()
        {
            return EntitySet.ToList();
        }

        /// <inheritdoc/>
        public IEnumerable<TEntity> GetAllList(Expression<Func<TEntity, bool>> predicate)
        {
            return GetAll().Where(predicate).ToList();
        }
        
        /// <inheritdoc/>
        public IEnumerable<TEntity> GetAllPaged(int pageSize, int pageIndex)
        {
            if (pageSize < 1 || pageIndex < 0)
            {
                return new List<TEntity>();
            }

            return EntitySet.Skip(pageSize * pageIndex).Take(pageSize).AsEnumerable();
        }
        
        /// <inheritdoc/>
        public IEnumerable<TEntity> GetPaged(int pageSize, int pageIndex, Expression<Func<TEntity, bool>> predicate)
        {
            if (pageSize < 1 || pageIndex < 0)
            {
                return new List<TEntity>();
            }

            return EntitySet.Where(predicate).Skip(pageSize * pageIndex).Take(pageSize).AsEnumerable();
        }

        /// <inheritdoc/>
        public T Query<T>(Func<IQueryable<TEntity>, T> queryMethod)
        {
            return queryMethod(GetAll());
        }

        /// <inheritdoc/>
        public TEntity Single(Expression<Func<TEntity, bool>> predicate)
        {
            return GetAll().FirstOrDefault(predicate);
        }

        /// <inheritdoc/>
        public TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return GetAll().FirstOrDefault(predicate);
        }

        /// <inheritdoc/>
        public TEntity Insert(TEntity entity)
        {
            return EntitySet.Add(entity);
        }

        /// <inheritdoc/>
        public TEntity Update(TEntity entity)
        {
            AttachIfNotAttached(entity);
            _context.Entry(entity).State = EntityState.Modified;
            return entity;
        }

        /// <inheritdoc/>
        public void Delete(TEntity entity)
        {
            AttachIfNotAttached(entity);
            EntitySet.Remove(entity);            
        }

        /// <inheritdoc/>
        public void Delete(Expression<Func<TEntity, bool>> predicate)
        {
            foreach (var entity in GetAll().Where(predicate).ToList())
            {
                Delete(entity);
            }
        }

        /// <inheritdoc/>
        public int Count()
        {
            return GetAll().Count();
        }

        /// <inheritdoc/>
        public int Count(Expression<Func<TEntity, bool>> predicate)
        {
            return GetAll().Where(predicate).Count();
        }
        
        /// <inheritdoc/>
        protected virtual void AttachIfNotAttached(TEntity entity)
        {
            if (!EntitySet.Local.Contains(entity))
            {
                EntitySet.Attach(entity);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Release managed resources.
                if (UnitOfWork != null) UnitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }
    }}
