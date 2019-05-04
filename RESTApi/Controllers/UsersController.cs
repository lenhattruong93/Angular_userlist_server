using RESTApi.Entity;
using RESTApi.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace RESTApi.Controllers
{
    [RoutePrefix("api/users")]
    public class UsersController : ApiController
    {
        [HttpGet()]
        [Route("")]
        public IList<User> GetUser()
        {
            //kHAI BAO BIEN
            UserService userservice = new UserService();
            var users = userservice.GetUser();
            return users;
        }
    }
}