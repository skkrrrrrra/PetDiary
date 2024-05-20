using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PetDiary.Domain.Entities;
using PetDiary.Domain.Enums;
using PetDiary.Persistence.Common;

namespace PetDiary.Web.Controllers
{
    [ApiController]
    [Route("api/diary"), Authorize]
    public class DiaryController : ControllerBase
    {
        private readonly IAuditUserProvider _auditUserProvider;

        public DiaryController(IAuditUserProvider auditUserProvider) 
        {
            _auditUserProvider = auditUserProvider;
        }
    }
}
