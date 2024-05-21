using FluentMigrator;
using PetDiary.Persistence.Common;

namespace PetDiary.Persistence.Migrations
{
    [Migration(100, "fill stickers table")]
    public class FillStickerPacksTable : SqlMigration
    {
        protected override string GetUpSql(IServiceProvider services) => $@"

insert into stickerpacks(id, title)
    values (1, 'cats');
insert into stickerpacks(id, title)
    values (2, 'dogs');
insert into stickerpacks(id, title)
    values (3, 'cars');

";

        protected override string GetDownSql(IServiceProvider services) => $@"";
    }
}
