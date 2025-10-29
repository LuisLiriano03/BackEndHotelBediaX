using HotelBediaX.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace HotelBediaX.API.Config
{
    public static class DbConfig
    {
        public static IServiceCollection ConfigDbConnection(this IServiceCollection service, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("myConnection")!;
            service.AddDbContext<DbhotelBediaXContext>(options => options.UseSqlServer(connectionString));

            return service;
        }

    }

}
