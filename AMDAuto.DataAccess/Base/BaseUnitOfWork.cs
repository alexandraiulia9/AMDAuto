using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AMDAuto.DataAccess.Base
{
    public class BaseUnitOfWork : IUnitOfWork, IDisposable
    {
        protected readonly AmdautoContext DbContext;

        public BaseUnitOfWork(AmdautoContext context)
        {
            this.DbContext = context;
        }

        public bool SaveChanges()
        {
            try
            {
                DbContext.SaveChanges();

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public void Dispose()
        {
            DbContext.Dispose();
        }
    }
}
