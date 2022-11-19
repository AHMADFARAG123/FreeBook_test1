using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBook_test1.Areas.Admin.Controllers
{
    public class AcountsController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
