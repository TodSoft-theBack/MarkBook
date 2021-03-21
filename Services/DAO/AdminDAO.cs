using System;
using System.Collections.Generic;
using System.Text;
using Services.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Services;

namespace Services.DAO
{
    public class AdminDAO
    {
        public int AddAdmin(string firstName, string lastName, int userId)
        {
            Admins Admin = new Admins();
            Admin.FirstName = firstName;
            Admin.LastName = lastName;
            Admin.UserID = userId;

            this.context.Admins.Add(Admin);
            return this.context.SaveChanges();
        }

        public int RemoveAdmin(int adminId)
        {
            int userNum = context.Admins.Where(a => a.AdminID == adminId).FirstOrDefault().UserID;
            context.Remove(context.Admins.Where(t => t.AdminID == adminId).FirstOrDefault());
            context.Remove(context.Users.Where(u => u.UserID == userNum).FirstOrDefault());

            return this.context.SaveChanges();
        }

        public Admins GetAdminById(int AdminId)
        {
            return this.context.Admins.FirstOrDefault(t => t.AdminID.Equals(AdminId));
        }
        public Admins GetUserById(int userID)
        {
            return this.context.Admins.FirstOrDefault(t => t.UserID == userID);
        }
        private MarkBookDBContext context;

        public AdminDAO(MarkBookDBContext context)
        {
            if (context == null) throw new ArgumentNullException("context");

            this.context = context;
        }
    }
}
