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
            UserService userservice = new UserService();
            return userservice.GetUsers();       
        }
        [HttpGet()]
        [Route("{userId}")]
        public User GetUser(int userId)
        {
            UserService userservice = new UserService();
            return userservice.GetUser(userId);
        }
        [HttpPost()]
        [Route("")]
        public void AddNewUser(AddNewUserRequest request)
        {
            UserService userservice = new UserService();
            userservice.AddUser(request);
        }
        [HttpPut()]
        [Route("userId")]
        public void UpdateUser(int userId, UpdateUserRequest request)
        {
            UserService userservice = new UserService();
            userservice.UpdateUser(request);

        }
    }
}