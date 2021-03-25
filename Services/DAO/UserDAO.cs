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
            if (string.IsNullOrWhiteSpace(username) || username.Contains(" "))
            {
                throw new ArgumentException("A username cannot contain empty spaces");
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("A password is required");
            }

            if (this.context.Users.Contains(this.context.Users.Where(u => u.Username == username).FirstOrDefault()))
            {
                throw new ArgumentException("This user already exists");
            }

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
            if (string.IsNullOrWhiteSpace(username))
            {
                throw new ArgumentException("This user does not exist");
            }

            var user = this.context.Users.FirstOrDefault(x => x.Username == username);
            if (user == null)
            {
                throw new ArgumentException("This user does not exist");
            }

            return this.context.Users.FirstOrDefault(x => x.Username == username);
        }

        public int RemoveUserById(int id)
        {
            if (id == 0)
            {
                throw new ArgumentException("This user does not exist");
            }

            var user = this.context.Users.FirstOrDefault(x => x.UserId == id);
            if (user == null)
            {
                throw new ArgumentException("This user does not exist");
            }

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
