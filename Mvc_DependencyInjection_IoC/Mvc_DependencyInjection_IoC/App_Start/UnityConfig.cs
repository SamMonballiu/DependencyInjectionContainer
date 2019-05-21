using Mvc_DependencyInjection_IoC.Data.Models.Interfaces;
using Mvc_DependencyInjection_IoC.Data.Models.Repositories;
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

            container.RegisterType<IProductRepository, ProductRepository>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}