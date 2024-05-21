using Microsoft.EntityFrameworkCore;
using PetDiary.Application.Models.DiaryModels;
using PetDiary.Application.Models.NoteModels;
using PetDiary.Application.Requests.Diary;
using PetDiary.Application.Requests.Note;
using PetDiary.Application.Responses.Results;
using PetDiary.Application.Services.Interfaces;
using PetDiary.Domain.Entities;
using PetDiary.Domain.Enums;
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

        public async Task<Result<DiaryModel>> CreateDiary(DiaryCreateRequest request)
        {
            var diary = Map<Diary>(request);
            var user = await _dbContext.Diaries
                .AddAsync(diary);
            await _dbContext.SaveChangesAsync();

            var result = new DiaryModel().ConvertFromEntity(diary);
            return new SuccessResult<DiaryModel>(result);
        }

        public async Task<Result<List<DiaryModel>>> GetDiariesByType(long userId, DiaryType diaryType)
        {
            var diaries = await _dbContext.Diaries
                .Include(item => item.Notes)
                .AsNoTracking()
                .Where(item =>
                    item.DiaryType == diaryType
                    && item.UserId == userId)
                .ToListAsync();

            var result = diaries.Select(item => new DiaryModel().ConvertFromEntity(item)).ToList();
            return new SuccessResult<List<DiaryModel>>(result);
        }

        public async Task<Result<NoteModel>> CreateNote(NoteCreateRequest request)
        {
            var note = Map<Note>(request);
            note.Diary = await _dbContext.Diaries.FirstOrDefaultAsync(item => item.Id == note.DiaryId);
            await _dbContext.Notes.AddAsync(note);
            await _dbContext.SaveChangesAsync();
            var result = new NoteModel().ConvertFromEntity(note);

            return new SuccessResult<NoteModel>(result);
        }

        public async Task<Result<List<NoteModel>>> GetDiaryNotes(long userId, long diaryId)
        {
            var diaryNotes = (await _dbContext.Diaries
                .AsNoTracking()
                .Include(item => item.Notes)
                .FirstOrDefaultAsync(item =>
                    item.Id == diaryId
                    && item.UserId == userId)
                )?.Notes.ToList();

            var result = diaryNotes?.Select(item => new NoteModel().ConvertFromEntity(item))?.ToList();
            return new SuccessResult<List<NoteModel>>(result);
        }

        public async Task<Result<DiaryModel>> GetDiaryById(long userId, long diaryId)
        {
            var diary = await _dbContext.Diaries
                .Include(item => item.Notes)
                .AsNoTracking()
                .FirstOrDefaultAsync(item =>
                    item.Id == diaryId
                    && item.UserId == userId);

            var result = new DiaryModel().ConvertFromEntity(diary);
            return new SuccessResult<DiaryModel>(result);
        }

        public async Task<Result<NoteModel>> GetNoteById(long noteId)
        {
            var note = await _dbContext.Notes
                .FirstOrDefaultAsync(item => item.Id == noteId);

            var result = new NoteModel().ConvertFromEntity(note);
            return new SuccessResult<NoteModel>(result);
        }
    }
}
