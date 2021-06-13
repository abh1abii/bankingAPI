using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using BankWebApp.Models;

namespace BankWebApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserUpdateController : ControllerBase
    {   [HttpPut]
        public int PutUserRecord(User user)
        {
            
            Console.WriteLine("Update User Record in Process..");
            return UserRegistration.getInstance().UpdateUser(user);
        }
    }
}