using FreeTime.Common.Models;
using FreeTime.Common.Repositories;
using FreeTime.Common.Services;
using FreeTime.WebApi.Controllers;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Practices.Unity;
using System.Data.Entity;
using System.Web.Http;
using Unity.WebApi;

namespace FreeTime.WebApi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            container.RegisterType<DbContext, ApplicationDbContext>(new HierarchicalLifetimeManager());
            container.RegisterType<UserManager<ApplicationUser>>(new HierarchicalLifetimeManager());
            container.RegisterType<IUserStore<ApplicationUser>, UserStore<ApplicationUser>>(new HierarchicalLifetimeManager());
            container.RegisterType<AccountController>(new InjectionConstructor());

            container.RegisterType<IGenericRepo<Blog>, GenericRepo<Blog>>();
            container.RegisterType<IGenericRepo<Category>, GenericRepo<Category>>();
            container.RegisterType<ICategoryService, CategoryService>();
            container.RegisterType<IBlogService, BlogService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}