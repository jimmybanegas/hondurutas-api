using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HonduRutas.Domain.Contracts
{
    /// <summary>
    /// This interface is implemented by all repositories to ensure implementation of fixed methods.
    /// </summary>
    public interface IRepository<TEntity> : IDisposable where TEntity : class, IEntity
    {
        /// <summary>
        /// Used to get or set the UnitOfWork for this repository
        /// </summary>
        IUnitOfWork UnitOfWork { get; set; }

        #region Select/Get/Query

        /// <summary>
        /// Used to get a IQueryable that is used to retrieve entities from entire table.
        /// </summary>
        IQueryable<TEntity> GetAll();

        /// <summary>
        /// Used to get all entities.
        /// </summary>
        IEnumerable<TEntity> GetAllList();
        
        /// <summary>
        /// Used to get all entities based on given <paramref name="predicate"/>.
        /// </summary>
        IEnumerable<TEntity> GetAllList(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// Used to get a paged list of all entities.
        /// </summary>
        IEnumerable<TEntity> GetAllPaged(int pageSize, int pageIndex);

        /// <summary>
        /// Used to get a paged list of all entities based on given <paramref name="predicate"/>.
        /// </summary>
        IEnumerable<TEntity> GetPaged(int pageSize, int pageIndex, Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// Used to run a query over entire entities.
        /// if <paramref name="queryMethod"/> finishes IQueryable with ToList, FirstOrDefault etc..
        /// </summary>
        T Query<T>(Func<IQueryable<TEntity>, T> queryMethod);

        /// <summary>
        /// Gets exactly one entity with given predicate.
        /// Throws exception if no entity or more than one entity.
        /// </summary>
        TEntity Single(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// Gets an entity with given given predicate or null if not found.
        /// </summary>
        TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate);
        #endregion

        #region Insert
        /// <summary>
        /// Inserts a new entity.
        /// </summary>
        TEntity Insert(TEntity entity);
        #endregion

        #region Update
        /// <summary>
        /// Updates an existing entity.
        /// </summary>
        TEntity Update(TEntity entity);
        #endregion

        #region Delete
        /// <summary>
        /// Deletes an entity.
        /// </summary>
        void Delete(TEntity entity);

        /// <summary>
        /// Deletes many entities by function.
        /// Notice that: All entities fits to given predicate are retrieved and deleted.
        /// This may cause major performance problems if there are too many entities with
        /// given predicate.
        /// </summary>
        void Delete(Expression<Func<TEntity, bool>> predicate);
        #endregion

        #region Aggregates
        /// <summary>
        /// Gets count of all entities in this repository.
        /// </summary>
        int Count();

        /// <summary>
        /// Gets count of all entities in this repository based on given <paramref name="predicate"/>.
        /// </summary>
        int Count(Expression<Func<TEntity, bool>> predicate);
        #endregion
    }
}