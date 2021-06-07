using Microsoft.AspNetCore.Mvc;
using PartyMVCLib.Interfaces;
using PartyMVCLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyMVCUI.Controllers
{
    public class VisitorsController : Controller
    {
        private readonly IVisitorRepository _repo;
        public VisitorsController(IVisitorRepository repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Visitor visitor)
        {
            try
            {
                _repo.AddVisitor(visitor);
                ModelState.Clear();
                return View();
            }
            catch
            {
                return View();
            }
        }
        [HttpGet]
        public IActionResult Summary()
        {
            ViewBag.TotalGuests = _repo.TotalMembers();
            ViewBag.TotalFamilyGuests = _repo.TotalFamilyMembers();
            ViewBag.YoungestAge = _repo.YoungestMember();
            ViewBag.OldestAge = _repo.OldestMember();
            return View();
        }
    }
}
