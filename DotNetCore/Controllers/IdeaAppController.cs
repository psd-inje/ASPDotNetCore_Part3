using DotNetNote.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore.Controllers
{
    public class IdeaAppController : Controller
    {
        private readonly IIdeaRepository _repository;

        public IdeaAppController(IIdeaRepository repository)
        {
            this._repository = repository;
        }


        [HttpGet]
        public IActionResult Index()
        {
            var ideas = _repository.GetAll();

            return View(ideas);
        }

        [HttpPost]
        public IActionResult Index(Idea model)
        {
            if (ModelState.IsValid)
            {
                model = _repository.Add(model);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(model);
            }
        }

    }
}
