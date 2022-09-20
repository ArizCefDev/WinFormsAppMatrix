using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public User()
        {
        }

        public User(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        public User(int iD, string userName, string password)
        {
            ID = iD;
            UserName = userName;
            Password = password;
        }

        public static bool LogIn(string username, string password)
        {
            var result = Context.RunSelect($"SELECT*FROM Users WHERE UserName='{username}' AND UserPassword='{password}'");

            var userlist = result.Tables[0].AsEnumerable().Select(Row => new User
            {
                ID = Row.Field<int>("ID"),
                UserName = Row.Field<string>("UserName"),
                Password = Row.Field<string>("UserPassword")
            }).ToList();

            if (userlist.Count != 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
