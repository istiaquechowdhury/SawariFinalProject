using Sawari.Domain.RepositoryPatternInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sawari.Domain.UnitOfWorkInterfaces
{
    public interface IProductUnitOfWork : IUnitOfWork   
    {
        public IProduct Product { get; }   
    }
}
