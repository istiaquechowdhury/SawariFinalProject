using Autofac;
using Sawari.Web.Data;
using Sawari.Application.Services;
using Sawari.Domain.RepositoryPatternInterfaces;
using Sawari.Domain.UnitOfWorkInterfaces;
using Sawari.Infrastructure.ProductDB;
using Sawari.Infrastructure.RepositoryPatternClasses;
using Sawari.Infrastructure.UnitOfWorkClasses;


namespace Sawari.Web
{
    public class WebModule(string connectionString, string migrationAssembly) : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductDbContext>().AsSelf()
                .WithParameter("connectionString", connectionString)
                .WithParameter("migrationAssembly", migrationAssembly)
                .InstancePerLifetimeScope();

            builder.RegisterType<ApplicationDbContext>().AsSelf()
                .WithParameter("connectionString", connectionString)
                .WithParameter("migrationAssembly", migrationAssembly)
                .InstancePerLifetimeScope();

            builder.RegisterType<ProductRepository>()
                .As<IProduct>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ProductUnitOfWork>()
                .As<IProductUnitOfWork>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ProductManagementServices>()
                .As<IProductManagementServices>()
                .InstancePerLifetimeScope();
        }
    }

}
