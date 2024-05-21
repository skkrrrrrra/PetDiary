using FluentMigrator;
using PetDiary.Persistence.Common;

namespace PetDiary.Persistence.Migrations
{
    [Migration(105, "fill diaries table")]
    public class FillDiariesTable : SqlMigration
    {
        protected override string GetUpSql(IServiceProvider services) => $@"

insert into diaries(id, user_id, title, description, diary_type) 
    values (1, 1, 'My First Diary', 'this diary about me and  my family', 0);

insert into diaries(id, user_id, title, description, diary_type) 
    values (2, 1, 'Cooking notes', 'vlog', 1);

insert into diaries(id, user_id, title, description, diary_type) 
    values (3, 1, 'Adventure', 'vlog about my adventures', 1);

insert into diaries(id, user_id, title, description, diary_type) 
    values (4, 1, 'My Private Diary', 'this diary about me and  my family', 1);

";

        protected override string GetDownSql(IServiceProvider services) => $@"";
    }
}
