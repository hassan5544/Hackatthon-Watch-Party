using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchPartyPresentation.Controllers
{
    [Route("api/Users")]
    [ApiController]

    public class UsersController : ControllerBase
    {
        private readonly IServiceManager _service;
        public UsersController(IServiceManager service) => _service = service;

        [HttpGet]
        public IActionResult GetUsers()
        {
            try
            {
                var Users =
                _service.UserService.GetAllUsers(trackChanges: false);
                return Ok(Users);
            }
            catch
            {
                return StatusCode(500, "Internal server error");
            }
        }
        //[HttpPost]
        //public IActionResult AddUser()
        //{
        //    try
        //    {
        //        var User =
        //        _service.UserService.GetAllUsers(trackChanges: false);
        //        return Ok(Users);
        //    }
        //    catch
        //    {
        //        return StatusCode(500, "Internal server error");
        //    }
        //}

    }
}
