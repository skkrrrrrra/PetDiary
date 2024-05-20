using Microsoft.Extensions.DependencyInjection;
using Diary.Persistence.Common;

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
