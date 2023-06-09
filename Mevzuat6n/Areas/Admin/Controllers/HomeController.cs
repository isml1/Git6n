﻿using Mevzuat6n._1Entities.Entities;
using Mevzuat6n._2Data.UnitOfWorks;
using Mevzuat6n._3Service.Services.Abstractions;
using Mevzuat6n.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace Mevzuat6n.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IArticleService articleService;
        private readonly IDashbordService dashbordService;

        public HomeController(IArticleService articleService, IDashbordService dashbordService)
        {
            this.articleService = articleService;
            this.dashbordService = dashbordService;
        }
        public async Task<IActionResult> Index()
        {
            var articles = await articleService.GetAllArticlesWithCategoryNonDeletedAsync();

            return View(articles);
        }
        [HttpGet]
        public async Task<IActionResult> YearlyArticleCounts()
        {
            var count = await dashbordService.GetYearlyArticleCounts();
            return Json(JsonConvert.SerializeObject(count));
        }
        [HttpGet]
        public async Task<IActionResult> TotalArticleCount()
        {
            var count = await dashbordService.GetTotalArticleCount();
            return Json(count);
        }
        [HttpGet]
        public async Task<IActionResult> TotalCategoryCount()
        {
            var count = await dashbordService.GetTotalCategoryCount();
            return Json(count);
        }
    }
}

