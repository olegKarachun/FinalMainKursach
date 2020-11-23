using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Controllers;
using Microsoft.AspNetCore.Identity;
using WebApplication1.Classes;
using WebApplication1.Classes.AdminActions;

namespace WebApplication1.Controllers
{    
    [Authorize(Roles ="Admin")]
    [Authorize(Roles = "Active")]
    public class AccountController : Controller
    {        
        private readonly ApplicationDbContext db;        
        private readonly UserManager<User> userManager;
        private SignInManager<User> signInManager;

        public AccountController(UserManager<User> userManager, ApplicationDbContext context, SignInManager<User> signInManager)
        {            
            this.userManager = userManager;
            this.signInManager = signInManager;
            db = context;
        }        

        public async Task<IActionResult> MakeAdmin(Dictionary<string, bool> check)
        {               
            Admin admin = new Admin(db, check, new AddAdmin(userManager, signInManager));            
            await admin.Action();                                  
            return RedirectToAction("AdminPage", "Home");
        }        

        public async Task<IActionResult> RemoveAdmin(Dictionary<string, bool> check)
        {
            Admin admin = new Admin(db, check, new RemoveAdmin(userManager, signInManager));
            await admin.Action();
            return RedirectToAction("AdminPage", "Home");
        }
        
        public async Task<IActionResult> Block(Dictionary<string, bool> check)
        {            
            Admin admin = new Admin(db, check, new BlockUser(userManager, signInManager));
            await admin.Action();
            return RedirectToAction("AdminPage", "Home");
        }
        
        public async Task<IActionResult> Unblock(Dictionary<string, bool> check)
        {
            Admin admin = new Admin(db, check, new UnblockUser(userManager, signInManager));
            await admin.Action();
            return RedirectToAction("AdminPage", "Home");
        }

        public async Task<IActionResult> Delete(Dictionary<string, bool> check)
        {
            Admin admin = new Admin(db, check, new DeleteUser(userManager, signInManager));
            await admin.Action();
            return RedirectToAction("AdminPage", "Home");
        }       
    }
}
