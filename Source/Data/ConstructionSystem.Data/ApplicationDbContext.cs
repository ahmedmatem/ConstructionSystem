namespace ConstructionSystem.Data
{
    using ConstructionSystem.Data.Migrations;
    using ConstructionSystem.Data.Models;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Data.Entity;

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
        }

        //public IDbSet<Post> Posts { get; set; }
    }
}
