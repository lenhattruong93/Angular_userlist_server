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
        internal IList<User> GetUsers()
        {
            RESTDbContext context = new RESTDbContext();
            return context.User.ToList();
        }
        internal void AddUser(AddNewUserRequest request)
        {
            User user = new User();
            user.FirstName = request.FirstName;
            user.LastName = request.LastName;
            user.UserName = request.UserName;
            RESTDbContext context = new RESTDbContext();
            context.User.Add(user);
            context.SaveChanges();
        }

        internal User GetUser(int userId)
        {
            RESTDbContext context = new RESTDbContext();
            return context.User.FirstOrDefault(user => user.Id == userId);
        }
        internal void UpdateUser(UpdateUserRequest request)
        {
            RESTDbContext context = new RESTDbContext();
            User user = context.User.FirstOrDefault(item => item.Id == request.Id);
            user.FirstName = request.FirstName;
            user.LastName = request.LastName;
            user.UserName = request.UserName;
            context.SaveChanges();
        }
    }
}