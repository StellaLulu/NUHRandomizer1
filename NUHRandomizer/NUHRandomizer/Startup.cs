using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using NUHRandomizer.Models;
using Owin;

[assembly: OwinStartupAttribute(typeof(NUHRandomizer.Startup))]
namespace NUHRandomizer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            createRolesandUsers();
        }
        private void createRolesandUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));


            // Creating Admin role   
            if (!roleManager.RoleExists("Administrator"))
            {
                var role = new IdentityRole();
                role.Name = "Administrator";
                roleManager.Create(role);
            }

            // Creating super user role
            if (!roleManager.RoleExists("Coordinator"))
            {
                var role = new IdentityRole();
                role.Name = "Coordinator";
                roleManager.Create(role);
            }

            // Creating user role    
            if (!roleManager.RoleExists("User"))
            {
                var role = new IdentityRole();
                role.Name = "User";
                roleManager.Create(role);
            }      
        }
    }
}
