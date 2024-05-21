using PetDiary.Application.Models.Base;
using PetDiary.Application.Models.NoteModels;
using PetDiary.Domain.Entities;
using PetDiary.Domain.Enums;

namespace PetDiary.Application.Models.DiaryModels
{
    public class DiaryModel : BaseModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DiaryType DiaryType { get; set; }

        public List<NoteModel> Notes { get; set; }

        public DiaryModel ConvertFromEntity(Diary entity)
        {
            return new DiaryModel
            {
                Id = entity.Id,
                Title = entity.Title,
                Description = entity.Description,
                DiaryType = entity.DiaryType,
                Notes = entity.Notes?.Select(item => new NoteModel().ConvertFromEntity(item)).ToList() ?? null,
            };
        }

        public Note ConvertToEntity(NoteModel model)
        {
            return new Note();
        }
    }
}
