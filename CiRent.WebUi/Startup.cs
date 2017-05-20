using CiRent.DAL.Concrete.EF;
using CiRent.IDEntity;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

[assembly: OwinStartup(typeof(CiRent.WebUi.Startup))]
namespace CiRent.WebUi
{
    public partial class Startup
    {
        private WebClient _dummy;

        public void Configuration(IAppBuilder app)
        {
            app.CreatePerOwinContext<CiRentContext>(CiRentContext.Create);
            app.CreatePerOwinContext<ApplicationRoleManager>(ApplicationRoleManager.Create);
            app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);
            app.UseCookieAuthentication(new CookieAuthenticationOptions()
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login"),
            });

            //var resolver = IocMannager.GetServiceContainer<WindsorSignalRDependencyResolver>();
            //var windsorSignalDependencyResolver = resolver.Service;


            //GlobalHost.Configuration.LongPollDelay = TimeSpan.FromSeconds(6);
            //(GlobalHost.DependencyResolver.Resolve<ITransportManager>() as TransportManager).Remove("webSockets");
            ////(GlobalHost.DependencyResolver.Resolve<ITransportManager>() as TransportManager).Remove("serverSentEvents");
            ////(GlobalHost.DependencyResolver.Resolve<ITransportManager>() as TransportManager).Remove("foreverFrame");

            //app.MapSignalR(new HubConfiguration
            //{
            //    EnableDetailedErrors = true,
            //    //   Resolver = windsorSignalDependencyResolver,

            //});
            

        }
    }

    //public class FilteredCamelCasePropertyNamesContractResolver : DefaultContractResolver
    //{
    //    public FilteredCamelCasePropertyNamesContractResolver()
    //    {
    //        AssembliesToInclude = new HashSet<Assembly>(AppDomain.CurrentDomain.GetAssemblies().Where(a => a.FullName.StartsWith("Svetophor")));
    //        TypesToInclude = new HashSet<Type>();
    //        ;
    //    }
    //    // Identifies assemblies to include in camel-casing
    //    public HashSet<Assembly> AssembliesToInclude { get; set; }
    //    // Identifies types to include in camel-casing
    //    public HashSet<Type> TypesToInclude { get; set; }
    //    protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
    //    {
    //        //AssembliesToInclude = new HashSet<Assembly>(AppDomain.CurrentDomain.GetAssemblies().Where(a => a.FullName.StartsWith("Svetophor")));

    //        var jsonProperty = base.CreateProperty(member, memberSerialization);
    //        Type declaringType = member.DeclaringType;
    //        if (
    //            TypesToInclude.Contains(declaringType)
    //            || AssembliesToInclude.Contains(declaringType.Assembly))
    //        {
    //            jsonProperty.PropertyName = jsonProperty.PropertyName.ToCamelCase();
    //        }
    //        return jsonProperty;
    //    }
    //}
}