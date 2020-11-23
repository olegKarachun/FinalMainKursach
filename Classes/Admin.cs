using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Classes;
using WebApplication1.Data;
using WebApplication1.Interfaces;

namespace WebApplication1.Models
{
    public class Admin
    {        
        private Dictionary<string, bool> check;
        private ApplicationDbContext db;
        
        public ITypeOfAction AdminActionInt { private get; set; }

        public Admin(ApplicationDbContext db, Dictionary<string, bool> check, ITypeOfAction typeOfAction)
        {            
            this.check = check;
            this.db = db;
            AdminActionInt = typeOfAction;
        }     

        public async Task Action()
        {
            foreach(var item in check)
            {
                User user = UserFinder.GetByEmail(db, item.Key);
                Trace.WriteLine(user.Email);
                if(user != null) await AdminActionInt.Action(db, user);
            }            
        }
    }
}
