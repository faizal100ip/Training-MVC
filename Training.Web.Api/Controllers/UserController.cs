using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Training.Web.Api.Controllers
{
    [RoutePrefix("api/User")]
    public class UserController : ApiController
    {
        public UserController()
        {

        }

        [Route("GetUserFirstName")]
        [HttpGet]
        public string GetUserFirstName()
        {
            var firstName = "Mohammad Faizal";
            return firstName;
        }

        [Route("GetUserFullName")]
        [HttpGet]
        public string GetUserFullName(string firstName, string lastName)
        {
            var fullName = String.Format("{0} {1}",firstName,lastName);
            return fullName;
        }
    }
}
