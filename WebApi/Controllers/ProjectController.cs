﻿using Microsoft.AspNetCore.Http;
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

        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        public IActionResult Index()
        {
            var model = _projectService.GetProjects();           
            return View(model);
        }
        
        public IActionResult ProjectEdit(Project model)
        {
            //Project model = _projectService.GetProjectById(id);
            //return RedirectToAction("ProjectEdit", model);
            return View(model);
        }

        [HttpPost]
        public IActionResult ProjectEditPost(Project model)
        {
            _projectService.UpdateProject(model);
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
            model.CreatedDate = DateTime.Now;            
            _projectService.AddProject(model);
            return RedirectToAction("Index");
        } 
        
        public IActionResult ProjectAdd()
        {
            return View();
        }

        //public IActionResult ProjectInfo(int id)
        //{
        //    var model = _projectService.GetProjectById(id);
        //    return View(model);
        //}
    }
}
