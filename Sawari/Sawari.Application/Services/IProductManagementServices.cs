using Sawari.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sawari.Application.Services
{
    public interface IProductManagementServices
    {
        void CreateProduct(Product Products);
    }
}
