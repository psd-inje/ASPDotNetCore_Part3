using DotNetNote.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore.Controllers
{
    public class BuyerTestController : Controller
    {
        private readonly IBuyerRepository buyerRepository;

        public BuyerTestController(IBuyerRepository buyerRepository)
        {
            this.buyerRepository = buyerRepository;
        }

        public IActionResult Index()
        {
            var buyers = buyerRepository.GetBuyers();
            return View(buyers);
        }

        public IActionResult Details(string buyerId)
        {
            var buyer = buyerRepository.GetBuyer(buyerId);
            return View(buyer);
        }
    }


}
