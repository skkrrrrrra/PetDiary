using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PetDiary.Application.Models.DiaryModels;
using PetDiary.Application.Models.NoteModels;
using PetDiary.Application.Requests.Diary;
using PetDiary.Application.Requests.Note;
using PetDiary.Application.Responses.Results;
using PetDiary.Application.Services.Interfaces;
using PetDiary.Domain.Enums;
using PetDiary.Persistence.Common;

namespace PetDiary.Web.Controllers
{
    [ApiController]
    [Route("api/diary"), Authorize]
    public class DiaryController : ControllerBase
    {
        private readonly IAuditUserProvider _auditUserProvider;
        private readonly IDiariesService _diariesService;

        public DiaryController(IAuditUserProvider auditUserProvider,
            IDiariesService diariesService) 
        {
            _auditUserProvider = auditUserProvider;
            _diariesService = diariesService;
        }

        [HttpPost]
        [Route("create")]
        public async Task<Result<DiaryModel>> CreateDiary(DiaryCreateRequest request)
        {
            var result = await _diariesService.CreateDiary(request);
            return result;
        }

        [HttpGet]
        [Route("list")]
        public async Task<Result<List<DiaryModel>>> GetDiariesByType(DiaryType diaryType)
        {
            var userId = _auditUserProvider.GetUserId();
            return await _diariesService.GetDiariesByType(userId.Value, diaryType);
        }

        [HttpGet]
        [Route("{diaryId}")]
        public async Task<Result<DiaryModel>> GetDiaryById(long diaryId)
        {
            var userId = _auditUserProvider.GetUserId();
            return await _diariesService.GetDiaryById(userId.Value, diaryId);
        }

        [HttpPost]
        [Route("note/create")]
        public async Task<Result<NoteModel>> CreateNote(NoteCreateRequest request)
        {
            return await _diariesService.CreateNote(request);
        }

        [HttpGet]
        [Route("note/list")]
        public async Task<Result<List<NoteModel>>> GetNotes(long diaryId)
        {
            var userId = _auditUserProvider.GetUserId();
            return await _diariesService.GetDiaryNotes(userId.Value, diaryId);
        }

        [HttpGet]
        [Route("note/{noteId}")]
        public async Task<Result<NoteModel>> GetNoteById(long noteId)
        {
            return await _diariesService.GetNoteById(noteId);
        }
    }
}
