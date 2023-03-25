﻿using Mevzuat6n._3Service.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Mevzuat6n.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly IArticleService articleService;

        public HomeController(IArticleService articleService)
        {
            this.articleService = articleService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}