using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessClinic.Controllers
{
    public class FitnessClinicController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
