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
    public class UserRegisterController : ControllerBase
    {   [HttpPost]
        public UserRegistrationReply registerUser([FromBody] User userRegd)
        {
            Console.WriteLine("User Registration in process...");
            UserRegistrationReply userReply = new UserRegistrationReply();
            UserRegistration.getInstance().Add(userRegd);
            userReply.Name = userRegd.Name;
            userReply.AccNo = userRegd.AccNo;
            userReply.Bal = userRegd.Bal;
            userReply.RegistrationStatus = "Successful";

            return userReply;
        }
    }
}