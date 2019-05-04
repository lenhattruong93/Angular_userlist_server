using RESTApi.Context;
using RESTApi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RESTApi.Service
{
    public class UserService
    {
        public IList<User> GetUser()
        {
            RESTDbContext context = new RESTDbContext();
            return context.User.ToList();
        }
    }
}