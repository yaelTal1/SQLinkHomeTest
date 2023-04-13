using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DtoFunctions
{
    public class UserService
    {
        List<UserDetails> users = new List<UserDetails>
        {
            new UserDetails{name="אבישי", team="מתכנתים", joinedAt=DateTime.Now, password="aaaa1111", email="aaa@aaaa" },
            new UserDetails{name="יונתן", team="תפעול", joinedAt=DateTime.Now.AddDays(-12), password="bbbb2222", email="bbb@bbbb" },
            new UserDetails{name="גד", team="אגברה", joinedAt=DateTime.Now.AddDays(-2), password="cccc3333", email="ccc@cccc" },
            new UserDetails{name="דניאל", team="אבטחת מידע", joinedAt=DateTime.Now.AddDays(-6), password="dddd4444", email="ddd@dddd" }
        };
        public LoginResponse Login(string email, string password)
        {
            LoginResponse userDetails = new LoginResponse();
            if (users.FindIndex(x => x.password == password && x.email == email) < 1)
            {
                return null;
            }
            userDetails.personalDetails = users.FirstOrDefault(x => x.password == password && x.email == email);
            userDetails.token = createRandomToken();
            return userDetails;
        }

        private string createRandomToken()
        {
            Random random = new Random();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, 16)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
