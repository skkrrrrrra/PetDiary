using PetDiary.Application.Services.Interfaces;
using PetDiary.Persistence;

namespace PetDiary.Application.Services
{
    public class DiariesService : IDiariesService
    {
        private readonly PostgreDbContext _dbContext;

        public DiariesService(PostgreDbContext dbContext) 
        {
            _dbContext = dbContext;
        }
    }
}
