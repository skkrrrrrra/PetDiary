using PetDiary.Persistence.Common;
using Microsoft.Extensions.DependencyInjection;

namespace PetDiary.Application
{
    public static class ApplicationConfiguration
    {
        //DI
        public static void AddServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IAuditUserProvider, AuditUserProvider>();
        }
    }
}
