using FluentMigrator;
using PetDiary.Persistence.Common;

namespace PetDiary.Persistence.Migrations
{
    [Migration(200, "alter columns table table")]
    public class AlterColumnsTable : SqlMigration
    {
        protected override string GetUpSql(IServiceProvider services) => $@"

ALTER SEQUENCE stickerpacks_id_seq RESTART WITH 4;
ALTER SEQUENCE stickers_id_seq RESTART WITH 10;
ALTER SEQUENCE identity_users_id_seq RESTART WITH 2;
ALTER SEQUENCE user_profiles_id_seq RESTART WITH 2;
ALTER SEQUENCE diaries_id_seq RESTART WITH 5;
ALTER SEQUENCE notes_id_seq RESTART WITH 9;

";

        protected override string GetDownSql(IServiceProvider services) => $@"
";
    }
}
