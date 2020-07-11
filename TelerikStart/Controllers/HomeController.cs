using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TelerikStart.Models;

namespace TelerikStart.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Grid()
        {
            return View();
        }


        public ActionResult GetCompanyRepresentatives([DataSourceRequest]DataSourceRequest request)
        {
            var c = new Company();

            var rep = c.CompanyRepresentativesList(); // Company.CompanyRepresentativesList();

            return Json(rep.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }

      
        public ActionResult Splitter1()
        {
            return View();
        }

        public ActionResult Splitter2()
        {
            return View();
        }

        public ActionResult GridTabstrip()
        {
            return View();
        }
    }
}