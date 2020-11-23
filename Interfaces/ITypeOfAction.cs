using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Interfaces
{
    public interface ITypeOfAction 
    {        
        Task Action(ApplicationDbContext db, User user);
    }

    enum Role
    {
        Admin,
        Active,
        Blocked,
    }    
}
