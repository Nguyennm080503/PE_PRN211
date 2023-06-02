using Microsoft.EntityFrameworkCore;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Services
{
    public class ContextBase<T> where T : class
    {
        BankAccountTypeContext bankAccountTypeContext;
        DbSet<T> dbSet;
        public ContextBase()
        {
            bankAccountTypeContext = new BankAccountTypeContext();
            dbSet = bankAccountTypeContext.Set<T>();
        }

        public List<T> GetAll()
        {
            return dbSet.ToList();
        }

        public void Create(T entity)
        {
            dbSet.Add(entity);
            bankAccountTypeContext.SaveChanges();
        }
        public void Update(T entity)
        {
            var tracker = bankAccountTypeContext.Attach(entity);
            tracker.State = EntityState.Modified;
            bankAccountTypeContext.SaveChanges();
        }
        public Boolean Delete(T entity)
        {
            try
            {
                dbSet.Remove(entity);
                bankAccountTypeContext.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
