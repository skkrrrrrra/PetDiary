using PetDiary.Application.Models.DiaryModels;
using PetDiary.Application.Models.NoteModels;
using PetDiary.Application.Requests.Diary;
using PetDiary.Application.Requests.Note;
using PetDiary.Application.Responses.Results;
using PetDiary.Domain.Enums;

namespace PetDiary.Application.Services.Interfaces
{
    public interface IDiariesService
    {
        Task<Result<DiaryModel>> CreateDiary(DiaryCreateRequest request);
        Task<Result<List<DiaryModel>>> GetDiariesByType(long userId, DiaryType diaryType);
        Task<Result<NoteModel>> CreateNote(NoteCreateRequest request);
        Task<Result<List<NoteModel>>> GetDiaryNotes(long userId, long diaryId);
        Task<Result<DiaryModel>> GetDiaryById(long userId, long diaryId);
        Task<Result<NoteModel>> GetNoteById(long noteId);
    }
}
