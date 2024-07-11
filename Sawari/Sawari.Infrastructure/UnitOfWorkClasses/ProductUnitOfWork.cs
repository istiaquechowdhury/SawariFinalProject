using Sawari.Application;
using Sawari.Domain.RepositoryPatternInterfaces;
using Sawari.Domain.UnitOfWorkInterfaces;
using Sawari.Infrastructure.ProductDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sawari.Infrastructure.UnitOfWorkClasses
{
    public class ProductUnitOfWork : UnitOfWork, IProductUnitOfWork
    {
        public IProduct Product { get; private set; }



        public ProductUnitOfWork(ProductDbContext dbContext,
            IProduct _Product) : base(dbContext)
        {
            Product = _Product;
        }
    }
}
