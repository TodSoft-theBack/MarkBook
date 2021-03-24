using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services.DAO
{
    public partial class AdminDAO
    {
        public int AddAdmin(string firstName, string lastName, int userId)
        {
            if (firstName == null)
            {
                throw new ArgumentException("Invalid first name");
            }
            if (lastName == null)
            {
                throw new ArgumentException("Invalid last name");
            }
            if (userId == 0)
            {
                throw new ArgumentException("Invalid user id");
            }

            Admins Admin = new Admins();
            Admin.FirstName = firstName;
            Admin.LastName = lastName;
            Admin.UserId = userId;

            this.context.Admins.Add(Admin);
            return this.context.SaveChanges();
        }
        public int RemoveAdmin(int adminId)
        {
            if (adminId == 0)
            {
                throw new Exception("Invalid admin id");
            }

            var admin = this.context.Admins.Where(a => a.AdminId == adminId).FirstOrDefault();
            if (admin == null)
            {
                throw new ArgumentException("This admin does not exist");
            }

            int userNum = context.Admins.Where(a => a.AdminId == adminId).FirstOrDefault().UserId;
            context.Remove(context.Admins.Where(t => t.AdminId == adminId).FirstOrDefault());
            context.Remove(context.Users.Where(u => u.UserId == userNum).FirstOrDefault());

            return this.context.SaveChanges();
        }

        public Admins GetAdminByID(int adminId)
        {
            if (adminId == 0)
            {
                throw new Exception("Invalid admin id");
            }

            var admin = this.context.Admins.Where(a => a.AdminId == adminId).FirstOrDefault();
            if (admin == null)
            {
                throw new ArgumentException("This admin does not exist");
            }

            return this.context.Admins.FirstOrDefault(t => t.AdminId.Equals(adminId));
        }
        public Admins GetAdminByUserID(int userId)
        {
            if (userId == 0)
            {
                throw new ArgumentException("Invalid user id");
            }

            var admin = this.context.Admins.Where(a => a.UserId == userId).FirstOrDefault();
            if (admin == null)
            {
                throw new ArgumentException("This admin does not exist");
            }

            return this.context.Admins.FirstOrDefault(t => t.UserId == userId);
        }
        private MarkBookDBContext context;

        public AdminDAO(MarkBookDBContext context)
        {
            if (context == null) throw new ArgumentNullException("context");

            this.context = context;
        }
    }
}
