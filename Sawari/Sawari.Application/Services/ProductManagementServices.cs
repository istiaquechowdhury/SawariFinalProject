using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Sawari.Application.Services;
using Sawari.Domain.Entities;
using Sawari.Domain.UnitOfWorkInterfaces;

namespace Sawari.Application.Services
{
    public class ProductManagementServices : IProductManagementServices
    {
        private readonly IProductUnitOfWork _ProductUnitOfWork;

        public ProductManagementServices(IProductUnitOfWork productUnitOfWork)
        {
            _ProductUnitOfWork = productUnitOfWork;
        }
        public void CreateProduct(Product Products)
        {
            _ProductUnitOfWork.Product.Add(Products);
            _ProductUnitOfWork.Save();
        }
    }
}
