﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ims.Controllers
{
    [Authorize(Roles = Pages.MainMenu.Branch.RoleName)]
    public class BranchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}