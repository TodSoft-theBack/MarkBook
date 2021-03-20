using Services.Models;
using System;
using System.Linq;

namespace Services.DAO
{
    public class UserDAO
    {
        public int AddUser(string username, string password)
        {
            Users userToAdd = new Users();
            userToAdd.Username = username;
            userToAdd.Password = password;

            this.context.Users.Add(userToAdd);
            return this.context.SaveChanges();
        }

        public Users GetUser(string username)
        {
            return this.context.Users.FirstOrDefault(x => x.Username == username);
        }

        public int RemoveUserById(int id)
        {
            context.Remove(context.Users.Where(u => u.UserID == id).FirstOrDefault());
            return this.context.SaveChanges();
        }

        private MarkBookDBContext context;

        public UserDAO(MarkBookDBContext context)
        {
            if (context == null) throw new ArgumentNullException("context");

            this.context = context;
        }
    }
}