using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PetDiary.Web.Controllers
{
    [ApiController]
    [Route("api/diary"), Authorize]
    public class DiaryController : ControllerBase
    {
        public DiaryController() 
        {
        }



    }
}
