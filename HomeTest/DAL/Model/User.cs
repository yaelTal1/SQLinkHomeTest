using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class User
    {
        public string name { get; set; }
        public string team { get; set; }
        public DateTime joinedAt { get; set; }
        public string avatar { get; set; }

    }

    public class UserDetails : User
    {
        public string password { get; set; }
        public string email { get; set; }
    }


    public class LoginParam
    {
        public string password { get; set; }
        public string email { get; set; }
    }


    public class LoginResponse
    {
        public string token { get; set; }
        public User personalDetails { get; set; }
    }

}
