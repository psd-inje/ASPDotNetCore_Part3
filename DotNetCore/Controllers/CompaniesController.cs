using DotNetNote.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore.Controllers
{

    public class CompaniesController : Controller
    {
        //private readonly IConfiguration _configuration;
        private readonly ICompanyRepository _repository;

        //public CompaniesController(IConfiguration configuration, ICompanyRepository repository)
        public CompaniesController(ICompanyRepository repository)
        {
            //this._configuration = configuration;
            this._repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string name)
        {
            ViewBag.Message = $"{name}을 입력했습니다.";

            return View();
        }

        [HttpGet]
        public IActionResult Manage()
        {
            var companies = _repository.Read();
            //return View();
            return View(companies);
        }

        [HttpPost]
        public IActionResult Manage(string name)
        {
            _repository.Add(new CompanyModel() { Name = name });
            //return View();
            return RedirectToAction(nameof(Manage));
        }


    }
}
