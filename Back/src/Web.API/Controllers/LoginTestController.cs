using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Web.API.Data;
using Web.API.Models;

namespace Web.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginTestController : ControllerBase
    {
        private readonly DataContext context;

        public LoginTestController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet("{login} {password}")]
        public Login GetById(string login, string password)
        {
            return context.Logins.FirstOrDefault(x => x.UserLogin == login && x.UserPassword == password);
        }
    }
}
