using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Vesper_HomeWork.DAL;
using Vesper_HomeWork.Models;
using Vesper_HomeWork.ViewModels;

namespace Vesper_HomeWork.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContextVesper _context;
        public HomeController(DataContextVesper context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            HomeViewmodels homeVm = new HomeViewmodels
            {
                TeamMembers = _context.TeamMembers.Include(x=>x.SocialMedias).ToList(),
                SocialMedias= _context.SocialMedias.ToList(),
                Services= _context.Services.ToList()

            };
           return View(homeVm);
        }
    }
}
