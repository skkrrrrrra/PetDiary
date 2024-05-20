using PetDiary.Domain.Abstractions;
using PetDiary.Domain.Constants;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetDiary.Domain.Entities
{
    public class PastedSticker : BaseEntity
    {
        [Column(Columns.StickerId)]
        public int StickerId { get; set; }


        [Column(Columns.NoteId)]
        public int NoteId { get; set; }


        [Column(Columns.XAxisIndentation)]
        public double XAxisIndentation { get; set; }


        [Column(Columns.YAxisIndentation)]
        public double YAxisIndentation { get; set; }


        [Column(Columns.RotateCorner)]
        public double RotateCorner { get; set; }

        public virtual Sticker Sticker { get; set; }
    }
}
