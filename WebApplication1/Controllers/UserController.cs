using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UserController: ApiController
    {
        public IEnumerable<User> Get() {
            return new User[] {
                new User{ Id=1,FirstName="Sangappa",LastName="Rodda" },
                new User{ Id=1,FirstName="Sidhharth",LastName="Rodda" }
            };
        }

       
    }
}