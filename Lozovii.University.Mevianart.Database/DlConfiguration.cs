using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Lozovii.University.Mevianart.Database.Interfaces;
using Lozovii.University.Mevianart.Database.Services;
using Lozovii.University.Mevianart.Models;

namespace Lozovii.University.Mevianart.Database
{
    public static class DIConfiguration
    {
        public static void RegisterDatabaseDependencies(this IServiceCollection services, IConfigurationRoot configuration)
        {
            services.AddDbContext<MevianartDbContext>((x) => x.UseSqlServer(configuration.GetConnectionString("PhoneDatabase")));

            services.AddScoped(typeof(IDbEntityService<>), typeof(DbEntityService<>));
            services.AddScoped<IDbEntityService<Phone>, PhoneDBService>();
        }
    }
}