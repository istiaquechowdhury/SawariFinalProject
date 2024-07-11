using Sawari.Domain.UnitOfWorkInterfaces;
using Sawari.Domain.RepositoryPatternInterfaces;
using Sawari.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sawari.Domain.RepositoryPatternInterfaces
{
    public interface IProduct : IRepositoryBase<Product,Guid>
    {

    }
}
