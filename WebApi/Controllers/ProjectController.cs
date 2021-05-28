using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Data.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Services.Abstract;
using Domain;

namespace WebApi.Controllers
{
    
    public class ProjectController : Controller
    {
        private readonly IProjectService _projectService;

        public ProjectController(IProjectService projServ)
        {
            _projectService = projServ;
        }

        public IActionResult Index()
        {
            var model = _projectService.GetProjects();
            if (model == null)
                return View("Hello");
            return View(model);
        }

        public IActionResult ProjectEdit(int id)
        {
            Project model = _projectService.GetProjectById(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult ProjectEdit(Project project)
        {
            _projectService.UpdateProject(project);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult ProjectDelete(int id)
        {
            _projectService.DeleteProjectById(id);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult ProjectAdd(Project model)
        {
            _projectService.AddProject(model);
            return View();
        }        
    }
}
