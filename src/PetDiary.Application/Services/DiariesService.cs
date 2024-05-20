using Diary.Persistence;
using PetDiary.Application.Services.Interfaces;

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
