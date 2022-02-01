using BusinessLayer.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore5._0_TravelWebSite.Controllers
{
    public class ContactController : Controller
    {
        //private readonly IContactService _contactService;
        

        //public ContactController(IContactService contactService)
        //{
        //    _contactService = contactService;
  
        //}

        public IActionResult Index()
        {
            //_contactService.GetList();
            return View();
        }
    }
}
