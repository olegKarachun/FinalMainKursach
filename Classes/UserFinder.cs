using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Classes
{
    public class UserFinder
    {
        public static User GetByEmail(ApplicationDbContext db, string Email)
        {
            return db.Users.FirstOrDefault(user => user.Email == Email);
        }

        public static User GetById(ApplicationDbContext db, string Id)
        {
            return db.Users.FirstOrDefault(user => user.Id == Id);
        }
    }
}
