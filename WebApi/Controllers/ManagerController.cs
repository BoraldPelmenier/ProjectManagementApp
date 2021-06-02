using Microsoft.AspNetCore.Mvc;
using Services.Abstract;
using WebApi.ViewModels;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    public class ManagerController : Controller
    {
        private readonly IProjectService _projectService;
        private readonly IUserService _userService;
        public ManagerController (IProjectService projectService, IUserService userService)
        {
            _projectService = projectService;
            _userService = userService;
        }

        public IActionResult ProjectInfo(int? id)
        {
            return View(new InfoViewModel { ProjectModel = _projectService.GetProjectById(id), Users = _userService.GetUsers() });            
        }

        public void AddUserInProject(this Project projectModel, User userModel)
        {
            projectModel.Users.Append(userModel);
           // return View("ProjectInfo");
        }
    }
}
