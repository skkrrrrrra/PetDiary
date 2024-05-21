using FluentMigrator;
using PetDiary.Persistence.Common;

namespace PetDiary.Persistence.Migrations
{
    [Migration(104, "fill identity users table")]
    public class FillIdentityUserRoles : SqlMigration
    {
        protected override string GetUpSql(IServiceProvider services) => $@"

insert into identity_user_roles(user_id, role_id)
    values(1, 2);

";

        protected override string GetDownSql(IServiceProvider services) => $@"";
    }
}
