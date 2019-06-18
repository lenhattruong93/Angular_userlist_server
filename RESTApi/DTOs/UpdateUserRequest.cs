using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RESTApi.DTOs
{
    public class UpdateUserRequest
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
    }
}