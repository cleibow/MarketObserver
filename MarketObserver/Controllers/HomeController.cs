using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MarketObserver.Models;
using MarketObserver.Business.HttpClients;
using MarketObserver.Business;
using MarketObserver.Business.Services;
using MarketObserver.Business.BusinessLogic;

namespace MarketObserver.Controllers
{
    public class HomeController : Controller
    {
        public IStockBusinessLogic _stockBusinessLogic { get; set; }

        public HomeController (IStockBusinessLogic stockBusinessLogic)
        {
            this._stockBusinessLogic = stockBusinessLogic;
        }

        public IActionResult Index()
        {
            var result = this._stockBusinessLogic.CheckStockChanges();
            //var response = this._marketStackHttpClient.GetIntradayStocks();
            //var result = this._stockSeedDataService.GetStockSymbols();
            //var test = result.First();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
