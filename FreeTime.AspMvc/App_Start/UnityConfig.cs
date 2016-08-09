using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using FreeTime.Common.Repositories;
using FreeTime.Common.Models;
using FreeTime.Common.Services;
using FreeTime.WebApp.Controllers;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;


namespace FreeTime.WebApp
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            UnityContainer container = new UnityContainer();

            container.RegisterType<DbContext, ApplicationDbContext>(new HierarchicalLifetimeManager());
            container.RegisterType<UserManager<ApplicationUser>>(new HierarchicalLifetimeManager());
            container.RegisterType<IUserStore<ApplicationUser>, UserStore<ApplicationUser>>(new HierarchicalLifetimeManager());
            container.RegisterType<AccountController>(new InjectionConstructor());
            
            container.RegisterType<IGenericRepo<Blog>, GenericRepo<Blog>>();
            container.RegisterType<IGenericRepo<Category>, GenericRepo<Category>>();
            container.RegisterType<ICategoryService, CategoryService>();
            container.RegisterType<IBlogService, BlogService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}