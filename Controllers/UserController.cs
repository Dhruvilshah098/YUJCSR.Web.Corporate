﻿using Microsoft.AspNetCore.Mvc;
using YUJCSR.Web.Corporate.BusinessManager;
using YUJCSR.Web.Corporate.Models;

namespace YUJCSR.Web.Corporate.Controllers
{
    public class UserController : Controller
    {
        IConfiguration _config;
        public UserController(IConfiguration iConfig)
        {
            _config = iConfig;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            CSOManager manager = new CSOManager(_config);
            var status = manager.LoginCheck(model);
            if (status)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.message = "Invalid Credential";
            }
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(CSOProfileModel cso)
        {

            CSOManager manager = new CSOManager(_config);
            var status = manager.OnBoardCSO(cso);
            if (status)
            {
                ViewBag.message = "Success";
               
            }
            else
            {
                ViewBag.message = "Failure";
            }
            return View();
        }
        public IActionResult Onboarding()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }
    }
}
