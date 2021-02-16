using Asynchronous.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Asynchronous.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        //public IActionResult Index()
        //{
        //    return View();
        //}

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}

        //public async Task<ViewResult> Index()
        //{
        //    //long? length = await AsyncMethods.GetPageLength();
        //    //return View(new string[] { $"Length: {length}"
        //    //});
        //    //List<string> output = new List<string>();
        //    //await foreach (long? len in AsyncMethods.GetPageLengths(output,"google.com", "microsoft.com","amazon.com"))
        //    //{
        //    //    output.Add($"Page length: { len}");
        //    //}
        //    //return View(output);
           
        //}
        public ViewResult Index()
        {
            var products = new[] {new { Name = "Kayak", Price = 275M },new { Name = "Lifejacket", Price = 48.95M },new { Name = "Soccer ball", Price = 19.50M },new { Name = "Corner flag", Price = 34.95M }};
            //return View(products.Select(p => $"Name{ p.Price} "));
            return View(products.Select(p => $"{nameof(p.Name)}: {p.Name},{ nameof(p.Price)}: { p.Price}"));
        }
    }
}
