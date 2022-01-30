
using BusinessLayer.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore5._0_TravelWebSite.Controllers
{
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;
        //private readonly ICategoryService _categoryService;

        public AboutController(IAboutService aboutService/*, ICategoryService categoryService*/)
        {
            _aboutService = aboutService;
            //_categoryService = categoryService;
        }

        public IActionResult Index()
        {
            _aboutService.GetList();   
            return View();
        }
    }
}
