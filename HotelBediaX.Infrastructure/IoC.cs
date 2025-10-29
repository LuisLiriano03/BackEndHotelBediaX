using HotelBediaX.Domain.Interfaces;
using HotelBediaX.Infrastructure.Repositorys;
using Microsoft.Extensions.DependencyInjection;
namespace HotelBediaX.Infrastructure
{
    public static class IoC
    {
        public static IServiceCollection AddRepositories(this IServiceCollection service)
        {
            return service
                .AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));

        }

    }

}
