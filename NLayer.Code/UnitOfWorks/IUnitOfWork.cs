using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Code.UnitOfWorks
{
    internal interface IUnitOfWork
    {
        Task CommitAsync();
        void Commit();
    }
}
