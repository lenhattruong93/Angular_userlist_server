using RESTApi.Context;
using RESTApi.DTOs;
using RESTApi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RESTApi.Service
{
    public class UserService
    {
        internal IList<User> GetUser()
        {
            RESTDbContext context = new RESTDbContext();
            return context.User.ToList();
        }
        internal void AddUser(AddNewUserRequest request)
        {
            User user = new User();
            user.FistName = request.FistName;
            user.LastName = request.LastName;
            user.UserName = request.UserName;
            RESTDbContext context = new RESTDbContext();
            context.User.Add(user);
            context.SaveChanges();


        }
    }
}