using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using DAL;
using DAL.DtoClasses;
using DAL.DtoFunctions;
using DAL.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HomeTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InfoController : ControllerBase
    {
        //[Route("/info")]
        [HttpGet]
        public ActionResult<IEnumerable<Project>> Info()

        {
            try
            {
                IInfo Iinfo = new ProjectsService();
                return Ok(Iinfo.GetAllProjects());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "לא קיימים פרויקטים");
            }
        }

        [HttpPost]
        public async Task<ActionResult<LoginResponse>> Authenticate([FromBody]LoginParam param)
        {
            try
            {
                if (param == null)
                    return BadRequest();
                UserService userService = new UserService();
                var userDetails = userService.Login(param.password, param.email);
                if (userDetails == null)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError,
                    "משתמש לא קיים במערכת");
                }
                return CreatedAtAction(null, null, userDetails);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "לא ניתן להתחבר");
            }
        }

    }
}
