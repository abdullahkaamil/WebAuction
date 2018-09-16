using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAuction.Controllers
{
    public class AuctionsController : Controller
    {
        // GET: Auctions
        public ActionResult Index()
        {
            var auctions = new[]
                               {
                                   new Models.Auction()
                                       {
                                           Title = "example Auction #1",
                                           Description = "this is an Example auction",
                                           StartTime = DateTime.Now,
                                           EndTime = DateTime.Now.AddDays(7),
                                           StartPrice = 1.00m,
                                           CurrentPrice = null,
                                       },
                                   new Models.Auction()
                                       {
                                           Title = "example Auction #2",
                                           Description = "this is an Second auction",
                                           StartTime = DateTime.Now,
                                           EndTime = DateTime.Now.AddDays(7),
                                           StartPrice = 7.00m,
                                           CurrentPrice = 30m,
                                       },
                                   new Models.Auction()
                                       {
                                           Title = "example Auction #3",
                                           Description = "this is an third auction",
                                           StartTime = DateTime.Now,
                                           EndTime = DateTime.Now.AddDays(7),
                                           StartPrice = 10.00m,
                                           CurrentPrice = 24m,
                                       },
                               };

            return View(auctions);
          
        }

        public ActionResult TempDataDemo()
        {
            TempData["successmassage"] = "the action succecced!";


            return RedirectToAction("Index");


        }
        public ActionResult Auction()
        {
            var auction = new MvcAuction.Models.Auction()
                              {
                                  Title = "Example Auction",
                                  Description = "This is an example Auction",
                                  StartTime = DateTime.Now,
                                  EndTime = DateTime.Now.AddDays(7),
                                  StartPrice = 1.00m,
                                  CurrentPrice = null,
                              };
            //ViewData["Auction"] = auction;
            return View(auction);
        }

    }
}