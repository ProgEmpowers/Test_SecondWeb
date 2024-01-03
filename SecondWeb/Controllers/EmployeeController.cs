using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SecondWeb.Models;
using System.Globalization;

namespace SecondWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        [Route("GetData")]
        public string GetData()
        {
            return "Authenticated wih JWT";
        }
        [HttpGet]
        [Route("Details")]
        public string Details()
        {
            return "Authenticated wih JWT";
        }
        [Authorize]
        [HttpPost]

        public string AddUser(Users user)
        {
            return "User added with username " + user.Username;
        }
    }
}
