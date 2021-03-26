using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.DAO
{
    public class LogInDAO
    {
        public Users LogIn(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || username.Contains(" "))
            {
                throw new ArgumentException("Invalid username");
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("Invalid password");
            }
            var user = this.context.Users
                .Where(u => u.Username == username && u.Password == password)
                .FirstOrDefault();

            if (user == null)
            {
                throw new ArgumentException("This user does not exist or you have entered a wrong password");
            }
            return user;
        }
        public void RegisterUser(Users userInfo)
        {
            if (userInfo == null)
            {
                throw new ArgumentException("Invalid user info");
            }

            this.context.Users.Add(userInfo);
            this.context.SaveChanges();
        }
        public void RegisterTeacher(Teachers teacher, Users teacherInfo)
        {
            if (teacher == null)
            {
                throw new ArgumentException("Invalid teacher");
            }

            if (teacherInfo == null)
            {
                throw new ArgumentException("Invalid teacher info");
            }

            this.context.Teachers.Add(teacher);
            this.context.Users.Add(teacherInfo);
            this.context.SaveChanges();
        }
        public void RegisterAdmin(Admins admin, Users userInfo)
        {
            if (admin == null)
            {
                throw new ArgumentException("Invalid admin");
            }

            if (userInfo == null)
            {
                throw new ArgumentException("Invalid admin info");
            }

            this.context.Users.Add(userInfo);
            this.context.Admins.Add(admin);
            this.context.SaveChanges();
        }
        private MarkBookDBContext context;
        public LogInDAO(MarkBookDBContext context)
        {
            if (context == null) throw new ArgumentNullException("context");
            this.context = context;
        }
    }
}
