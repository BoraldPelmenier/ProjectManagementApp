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
        [HttpGet]
        public IActionResult ProjectInfo(Project model)
        {
            var infoModel = _projectService.GetProjectById(model.Id);           
            var infoViewModel = new InfoViewModel() { ProjectModel = infoModel, Users = _userService.GetUsers() };           
            return View(infoViewModel);                        
        }

        
        public IActionResult AddUserInProject(int projectId, int userId)
        {
            Project projectModel = _projectService.GetProjectById(projectId);
            User userModel = _userService.GetUserById(userId);
            userModel.ProjectId = projectModel.Id;
            _userService.UpdateUser(userModel);
            return RedirectToAction("ProjectInfo", projectModel);            
        }

        public IActionResult DeleteUserFromProject(int userId)
        {
            User userModel = _userService.GetUserById(userId);
            Project projectModel = _projectService.GetProjectById(userModel.ProjectId);
            userModel.ProjectId = 0;
            _userService.UpdateUser(userModel);
            return RedirectToAction("ProjectInfo", projectModel);
        }
    }
}
