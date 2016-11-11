using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace BasisMap.DBContext
{
    public static class ServiceProviderConfig
    {
        //const string imgUrl = "~/Images/placeholder.png";
        //const string defaultAdminUserName = "DefaultAdminUserName";
        //const string defaultAdminPassword = "DefaultAdminPassword";

        public static async Task InitializeMusicStoreDatabaseAsync(IServiceProvider serviceProvider)
        {
            using (var serviceScope = serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var db = serviceScope.ServiceProvider.GetService<ltgwarehouseContext>();

                if (await db.Database.EnsureCreatedAsync())
                {
                    //await InsertTestData(serviceProvider);
                    //if (createUsers)
                    //{
                    //    await CreateAdminUser(serviceProvider);
                    //}
                }
            }
        }

        //private static async Task InsertTestData(IServiceProvider serviceProvider)
        //{
        //    var albums = GetAlbums(imgUrl, Genres, Artists);

        //    await AddOrUpdateAsync(serviceProvider, g => g.GenreId, Genres.Select(genre => genre.Value));
        //    await AddOrUpdateAsync(serviceProvider, a => a.ArtistId, Artists.Select(artist => artist.Value));
        //    await AddOrUpdateAsync(serviceProvider, a => a.AlbumId, albums);
        //}

        // TODO [EF] This may be replaced by a first class mechanism in EF
        private static async Task AddOrUpdateAsync<TEntity>(
            IServiceProvider serviceProvider,
            Func<TEntity, object> propertyToMatch, IEnumerable<TEntity> entities)
            where TEntity : class
        {
            // Query in a separate context so that we can attach existing entities as modified
            List<TEntity> existingData;
            using (var serviceScope = serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var db = serviceScope.ServiceProvider.GetService<ltgwarehouseContext>();
                existingData = db.Set<TEntity>().ToList();
            }

            using (var serviceScope = serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var db = serviceScope.ServiceProvider.GetService<ltgwarehouseContext>();
                foreach (var item in entities)
                {
                    db.Entry(item).State = existingData.Any(g => propertyToMatch(g).Equals(propertyToMatch(item)))
                        ? EntityState.Modified
                        : EntityState.Added;
                }

                await db.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Creates a store manager user who can manage the inventory.
        /// </summary>
        /// <param name="serviceProvider"></param>
        /// <returns></returns>
        //private static async Task CreateAdminUser(IServiceProvider serviceProvider)
        //{
        //    var env = serviceProvider.GetService<IHostingEnvironment>();

        //    var builder = new ConfigurationBuilder()
        //        .SetBasePath(env.ContentRootPath)
        //        .AddJsonFile("config.json")
        //        .AddEnvironmentVariables();
        //    var configuration = builder.Build();

        //    //const string adminRole = "Administrator";

        //    var userManager = serviceProvider.GetService<UserManager<ApplicationUser>>();
        //    // TODO: Identity SQL does not support roles yet
        //    //var roleManager = serviceProvider.GetService<ApplicationRoleManager>();
        //    //if (!await roleManager.RoleExistsAsync(adminRole))
        //    //{
        //    //    await roleManager.CreateAsync(new IdentityRole(adminRole));
        //    //}

        //    var user = await userManager.FindByNameAsync(configuration[defaultAdminUserName]);
        //    if (user == null)
        //    {
        //        user = new ApplicationUser { UserName = configuration[defaultAdminUserName] };
        //        await userManager.CreateAsync(user, configuration[defaultAdminPassword]);
        //        //await userManager.AddToRoleAsync(user, adminRole);
        //        await userManager.AddClaimAsync(user, new Claim("ManageStore", "Allowed"));
        //    }

        //    // NOTE: For end to end testing only
        //    var envPerfLab = configuration["PERF_LAB"];
        //    if (envPerfLab == "true")
        //    {
        //        for (int i = 0; i < 100; ++i)
        //        {
        //            var email = string.Format("User{0:D3}@example.com", i);
        //            var normalUser = await userManager.FindByEmailAsync(email);
        //            if (normalUser == null)
        //            {
        //                await userManager.CreateAsync(new ApplicationUser { UserName = email, Email = email }, "Password~!1");
        //            }
        //        }
        //    }
        //}
    }
}
