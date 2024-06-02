using ET.Services;
using ET.Web.Models;
using ET.Web.Models.Mappers;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ET.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRssFeedService _rssFeedService;

        public HomeController(ILogger<HomeController> logger, IRssFeedService rssFeedService)
        {
            _logger = logger;
            _rssFeedService = rssFeedService;
        }

        public async Task<IActionResult> Index()
        {
            string rssUrl = "https://rss.nytimes.com/services/xml/rss/nyt/HomePage.xml"; // Example RSS feed
            var items = await _rssFeedService.GetRssFeedAsync(rssUrl);

            var itemsVM = items.Select(x => x.ToViewModel());

            return View(itemsVM);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}