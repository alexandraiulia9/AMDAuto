using AMDAuto.DataAccess.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace AMDAuto.Services.Base
{
    public class BaseService : IDisposable
    {
        protected readonly AMDAutoUnitOfWork UnitOfWork;

        public BaseService(AMDAutoUnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork;
        }

        public void Dispose()
        {
            UnitOfWork.Dispose();
        }
    }
}
