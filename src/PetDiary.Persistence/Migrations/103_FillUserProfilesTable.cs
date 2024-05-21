using FluentMigrator;
using PetDiary.Persistence.Common;

namespace PetDiary.Persistence.Migrations
{
    [Migration(103, "fill user profiles table")]
    public class FillUserProfilesTable : SqlMigration
    {
        protected override string GetUpSql(IServiceProvider services) => $@"

insert into user_profiles(id, first_name, last_name, status, username, base_64_image, quote)
    values(1, 'Ilya', 'Chernyshev', 0, 'chernyshevilyatest', null, null);

";

        protected override string GetDownSql(IServiceProvider services) => $@"";
    }
}
