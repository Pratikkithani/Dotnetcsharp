using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Vehicle_Rental_System.Constants;
using Vehicle_Rental_System.Models;
using Vehicle_Rental_System.ViewModels;

namespace Vehicle_Rental_System.Controllers
{
    public class AccountController : Controller
    {
        readonly UserManager<User> _userManager;
        readonly SignInManager<User> _signInManger;
        public AccountController(UserManager<User> userManager, SignInManager<User> signInManger)
        {
            _userManager = userManager;
            _signInManger = signInManger;

        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel user)
        {
            if (ModelState.IsValid)
            {
                var createdUser = new User { Email = user.Email,UserName=user.UserName};
                var result = await _userManager.CreateAsync(createdUser, user.Password);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(createdUser, Role.User);
                    return RedirectToAction("Login");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return View(user);
        }


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginModel)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(loginModel.Email); 

                if (user == null)
                {
                    ModelState.AddModelError("", "Invalid login attempt. User not found.");
                    return View(loginModel);
                }
                var result = await _signInManger.PasswordSignInAsync(user.UserName, loginModel.Password, loginModel.RememberMe, false);
                if (result.Succeeded)
                {
                    var roles = await _userManager.GetRolesAsync(user);
                    if (roles.Contains(Role.Administrator))
                    {
                        return RedirectToAction("GetAllVehicles", "Vehicle");
                    }
                    else if (roles.Contains(Role.User))
                    {
                        return RedirectToAction("Index", "Home");
                    }

                }
                ModelState.AddModelError("", "LoginFailed");
            }
            return View(loginModel);
        }
        public async Task<IActionResult> LogOut()
        {
            await _signInManger.SignOutAsync();
            return RedirectToAction("Login");
        }


        public IActionResult RegisterAdmin()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> RegisterAdmin(RegisterViewModel admin)
        {
            if (ModelState.IsValid)
            {
                var createdUser = new User { UserName = admin.UserName, Email = admin.Email };
                var result = await _userManager.CreateAsync(createdUser, admin.Password);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(createdUser, Role.Administrator);
                    return RedirectToAction("Login");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return View(admin);
        }

    }
}
