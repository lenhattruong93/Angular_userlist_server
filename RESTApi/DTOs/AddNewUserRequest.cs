using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RESTApi.DTOs
{
    public class AddNewUserRequest
    {
        public int Id { get; set; }
        public string FistName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
    }
}