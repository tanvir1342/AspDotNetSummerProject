using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using AspDotNetSummerProject.Models;
using Newtonsoft.Json;

namespace AspDotNetSummerProject.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult create()
        {
            return View();
        }
        public ActionResult CustomerHome()
        {
            ViewBag.userId = Session["logged_user"];
            return View();
        }
        public ActionResult info()
        {
            return View();
        }
        public async Task<ActionResult> test()
        {
            getLocationJSN model = new getLocationJSN();
            GeoHelper geoHelper = new GeoHelper();
            var result = await geoHelper.GetGeoInfo();
            model = JsonConvert.DeserializeObject<getLocationJSN>(result);

            return View(model);

        }
        public ActionResult search()
        {
            return View();
        }
        public ActionResult Logout()
        {
            Session.Remove("logged_user");
            return RedirectToAction("Login","Home");
        }
    }
}