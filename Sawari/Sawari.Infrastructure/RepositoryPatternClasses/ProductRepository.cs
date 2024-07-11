using Sawari.Infrastructure.RepositoryPatternClasses;
using Sawari.Domain.Entities;
using Sawari.Domain.UnitOfWorkInterfaces;
using Sawari.Domain.RepositoryPatternInterfaces;
using Sawari.Infrastructure.ProductDB;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sawari.Infrastructure.RepositoryPatternClasses
{
    public class ProductRepository : Repository<Product,Guid>, IProduct
    {
        public ProductRepository(ProductDbContext context) : base(context)
        {

        }
    }
}