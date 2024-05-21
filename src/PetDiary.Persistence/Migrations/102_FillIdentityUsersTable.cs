using FluentMigrator;
using PetDiary.Persistence.Common;

namespace PetDiary.Persistence.Migrations
{
    [Migration(102, "fill identity users table")]
    public class FillIdentityUsersTable : SqlMigration
    {
        protected override string GetUpSql(IServiceProvider services) => $@"

insert into identity_users(id, user_name, normalized_user_name, email, normalized_email, email_confirmed, password_hash, security_stamp, concurrency_stamp, phone_number, phone_number_confirmed, two_factor_enabled, lockout_end, lockout_enabled, access_failed_count)
    values(1, 'chernyshevilyatest', 'CHERNYSHEVILYATEST', 'flsab45@gmail.com', 'FLSAB45@gmail.com', false, 'AQAAAAIAAYagAAAAEFm0o6bb0NM5af2Ih0M9swbZ1bIncEK0a1XTEYFVNiOcLWQ1PFvGSJlvQqFyhuWmdw==', 'EI2WWWWM3MKF5ECBEBYLSTMA7SMZSUBL', '8048e19b-1ca4-4218-878e-63e55f75e53b', '+79873852817', false, false, null, true, 0);
";

        protected override string GetDownSql(IServiceProvider services) => $@"";
    }
}
