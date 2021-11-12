using ETicket.Data;
using ETicket.Data.ViewModels;
using ETicket.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicket.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly AppDbContext context;

        public AccountController(
            UserManager<ApplicationUser> userManager, 
            SignInManager<ApplicationUser> signInManager, 
            AppDbContext context)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.context = context;
        }

        public IActionResult Login()
        {
            return View(new LoginVM());
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (!ModelState.IsValid)
            {
                return View(loginVM);
            }
            var user = await userManager.FindByEmailAsync(loginVM.EmailAddress);
            if (user != null)
            {
                var passwordCheck = await userManager
                    .CheckPasswordAsync(user, loginVM.Password);
                if (passwordCheck)
                {
                    var result = await signInManager
                        .PasswordSignInAsync(user, loginVM.Password, false, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Movies");
                    }
                }

                TempData["Error"] = "Wrong credentials, please try again";
                return View(loginVM);
            }

            TempData["Error"] = "Wrong credentials, please try again";
            return View(loginVM);
        }

        public IActionResult Register()
        {
            return View(new RegisterVM());
        }
    }
}
