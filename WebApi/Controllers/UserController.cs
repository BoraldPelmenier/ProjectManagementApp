using Microsoft.AspNetCore.Mvc;
using Services.Abstract;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult AllUsers()
        {
            var model = _userService.GetUsers();
            return View(model);
        }

        public IActionResult UserEdit(User model)
        {
            //Project model = _projectService.GetProjectById(id);
            //return RedirectToAction("ProjectEdit", model);
            return View(model);
        }

        [HttpPost]
        public IActionResult UserEditPost(User model)
        {
            _userService.UpdateUser(model);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult UserDelete(int id)
        {
            _userService.DeleteUserById(id);
            return RedirectToAction("AllUsers");
        }
        [HttpPost]
        public IActionResult UserAdd(User model)
        {
            _userService.AddUser(model);
            return View();
        }

        public IActionResult UserAdd()
        {
            return View();
        }
    }
}
