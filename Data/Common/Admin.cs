using Data.Framework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Common
{
    public abstract class Admin<T> where T : class
    {

        private DBContext db = new DBContext();

        private IDbSet<T> dbSet;

        protected Admin()
        {
            dbSet = db.Set<T>();
        }

        //public virtual T Add(T entity)
        //{
        //    return dbSet.Add(entity);
        //}

        public virtual void Update(T entity)
        {
            dbSet.Attach(entity);
            db.Entry(entity).State = EntityState.Modified;
        }

        public virtual T Delete(T entity)
        {
            return dbSet.Remove(entity);
        }

        public virtual T Delete(int ID)
        {
            var entity = dbSet.Find(ID);
            return dbSet.Remove(entity);
        }

        public virtual bool Insert(T entity)
        {
            try
            {
                dbSet.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public virtual bool Update2(T entity)
        {
            try
            {
                dbSet.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public virtual bool Delete2(T entity)
        {
            try
            {
                dbSet.Remove(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public virtual List<T> List()
        {
            return dbSet.ToList();
        }

        public virtual T ViewDetails(int ID)
        {
            return dbSet.Find(ID);
        }

    }
}
