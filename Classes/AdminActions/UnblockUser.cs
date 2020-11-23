using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Classes.AdminActions
{
    public class UnblockUser : ITypeOfAction
    {
        private UserManager<User> userManager;
        private SignInManager<User> signInManager;

        public UnblockUser(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public async Task Action(ApplicationDbContext db, User user)
        {
            user.IsBlocked = false;
            await userManager.AddToRoleAsync(user, Role.Active.ToString());
            await userManager.UpdateSecurityStampAsync(user);
            await db.SaveChangesAsync();
        }
    }
}
