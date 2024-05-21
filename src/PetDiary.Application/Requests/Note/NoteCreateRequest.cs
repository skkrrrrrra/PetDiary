namespace PetDiary.Application.Requests.Note
{
    public class NoteCreateRequest
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public long DiaryId { get; set; }
    }
}
