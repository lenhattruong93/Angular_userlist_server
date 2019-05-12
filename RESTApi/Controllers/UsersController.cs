using RESTApi.DTOs;
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
            return userservice.GetUser();
           
        }
        [HttpPost()]
        [Route("")]
        public void AddNewUser(AddNewUserRequest request)
        {
            UserService userservice = new UserService();
            userservice.AddUser(request);

        }
    }
}