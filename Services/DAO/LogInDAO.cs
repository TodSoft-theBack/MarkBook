﻿using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.DAO
{
    class LogInDAO
    {
        public Users LogIn(string username, string password)
        {
            var user = this.context.Users
                .Where(u => u.Username.Equals(username) && u.Password.Equals(password))
                .FirstOrDefault();

            return user;
        }
        public void RegisterUser(Users userInfo)
        {
            this.context.Users.Add(userInfo);
            this.context.SaveChanges();
        }
        public void RegisterTeacher(Teachers teacher, Users teacherInfo)
        {
            this.context.Teachers.Add(teacher);
            this.context.Users.Add(teacherInfo);
            this.context.SaveChanges();
        }
        public void RegisterAdmin(Admins admin, Users userInfo)
        {
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
