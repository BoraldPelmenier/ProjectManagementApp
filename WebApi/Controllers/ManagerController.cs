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
            //var projects = _projectService.GetProjects();
            var infoViewModel = new InfoViewModel() { ProjectModel = infoModel, Users = _userService.GetUsers() };           
            return View(infoViewModel);
            //return View(new InfoViewModel { ProjectModel = _projectService.GetProjects().Single(p => p.Id == model.Id), Users = _userService.GetUsers() });            
        }

        
        public IActionResult AddUserInProject(int projectId, int userId)
        {
            Project project = _projectService.GetProjectById(projectId);
            User user = _userService.GetUserById(userId);
            user.ProjectId = project.Id;
            _userService.UpdateUser(user);
            return RedirectToAction("ProjectInfo", project);
            //infoViewModel.ProjectModel.Users.Append(_userService.GetUserById(userId));
            //_projectService.UpdateProject(projectModel);
            //var _projectModel = _projectService.GetProjectById(projectModel.Id);
            //_projectModel.Users.Append(_userService.GetUserById(user.Id));
            //_projectService.UpdateProject(_projectModel);
            // return View("ProjectInfo");
        }
    }
}
