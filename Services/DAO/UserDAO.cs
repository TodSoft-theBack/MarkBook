using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.DAO
{
    public class UserDAO
    {
        public int AddUser(string username, string password)
        {
            Users userToAdd = new Users
            {
                Username = username,
                Password = password
            };

            this.context.Users.Add(userToAdd);
            return this.context.SaveChanges();
        }

        public Users GetUser(string username)
        {
            return this.context.Users.FirstOrDefault(x => x.Username == username);
        }

        public int RemoveUserById(int id)
        {
            context.Remove(context.Users.Where(u => u.UserId == id).FirstOrDefault());
            return this.context.SaveChanges();
        }

        private readonly MarkBookDBContext context;

        public UserDAO(MarkBookDBContext context)
        {
            if (context == null) throw new ArgumentNullException("context");

            this.context = context;
        }
    }
}
