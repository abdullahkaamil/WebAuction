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
            return View();
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