using PetDiary.Persistence.Common;
using Microsoft.Extensions.DependencyInjection;
using PetDiary.Application.Services.Interfaces;
using PetDiary.Application.Services;

namespace PetDiary.Application
{
    public static class ApplicationConfiguration
    {
        //DI
        public static void AddServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IAuditUserProvider, AuditUserProvider>();
            serviceCollection.AddScoped<IDiariesService, DiariesService>();
        }
    }
}
