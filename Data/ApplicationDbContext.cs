using WebApplication5.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace WebApplication5.Data
{

    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }


        //private readonly IOptions<OperationalStoreOptions> _operationalStoreOptions;



        //public DbSet<PersistedGrant> PersistedGrants { get; set; }

        //public DbSet<DeviceFlowCodes> DeviceFlowCodes { get; set; }

        //Task<int> IPersistedGrantDbContext.SaveChangesAsync() => base.SaveChangesAsync();

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);
        //    builder.ConfigurePersistedGrantContext(_operationalStoreOptions.Value);
        //}
    }





    //public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    //{
    //    public ApplicationDbContext(
    //        DbContextOptions options,
    //        IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
    //    {
    //    }
    //}
}
