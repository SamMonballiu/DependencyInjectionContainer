using Mvc_DependencyInjection_IoC.Data.EF.Models.Repositories;
using Mvc_DependencyInjection_IoC.Data.Models.Repositories;
using Mvc_DependencyInjection_IoC.DataModels.Interfaces;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace Mvc_DependencyInjection_IoC
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // e.g. container.RegisterType<ITestService, TestService>();

            //container.RegisterType<IProductRepository, ProductRepositoryDb>();
            container.RegisterType<IProductRepository, ProductRepository>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}