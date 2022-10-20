using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;
using SpaDay.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            AddUserViewModel addUserViewModel = new AddUserViewModel();
            return View(addUserViewModel);
        }

        [HttpPost]
        [Route("/user")]
        public IActionResult SubmitAddUserForm(AddUserViewModel addUserViewModel)
        {
            if (ModelState.IsValid)
            {
                User user = new User(addUserViewModel.UserName, addUserViewModel.EmailAddress, addUserViewModel.Password);
                if (addUserViewModel.Password == addUserViewModel.VerifyPassword)
                {

                    return View("Index", user);
                }
                else
                {
                    ViewBag.error = "Passwords do not match! Try again!";
                    return View("Add", user);
                }
            }
            ViewBag.error = "One or more inputs are not valid";
            return View("Add");
        }

    }

}
