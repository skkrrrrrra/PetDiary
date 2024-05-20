namespace Diary.Persistence.Common
{

    public interface IAuditUserProvider
    {
        long? GetUserId();
        string GetUserRole();
    }
}