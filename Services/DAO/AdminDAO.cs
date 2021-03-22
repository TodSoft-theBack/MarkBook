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
            Admins Admin = new Admins();
            Admin.FirstName = firstName;
            Admin.LastName = lastName;
            Admin.UserId = userId;

            this.context.Admins.Add(Admin);
            return this.context.SaveChanges();
        }
        public int RemoveAdmin(int adminId)
        {
            int userNum = context.Admins.Where(a => a.AdminId == adminId).FirstOrDefault().UserId;
            context.Remove(context.Admins.Where(t => t.AdminId == adminId).FirstOrDefault());
            context.Remove(context.Users.Where(u => u.UserId == userNum).FirstOrDefault());

            return this.context.SaveChanges();
        }

        public Admins GetAdminByID(int AdminId)
        {
            return this.context.Admins.FirstOrDefault(t => t.AdminId.Equals(AdminId));
        }
        public Admins GetAdminByUserID(int userId)
        {
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
