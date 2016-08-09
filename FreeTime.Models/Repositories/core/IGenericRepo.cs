using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FreeTime.Common.Repositories
{
    public interface IGenericRepo<TEntity>
      where TEntity : class
    {
        IEnumerable<TEntity> All();
        void Delete(object id);
        void Delete(TEntity entityToDelete);
        TEntity GetByID(object id);
        TEntity Insert(TEntity entity);
        void Update(TEntity entityToUpdate);
        void SaveChanges();
    }
}