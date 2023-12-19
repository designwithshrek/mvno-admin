using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using mvno_admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvno_admin.Controllers
{
    public class PackagesController : Controller
    {
        public ActionResult PackagesList()
        {
            ViewBag.Message = "Launched Packages Page";
            return View("~/Views/App/Packages/Index.cshtml");

        }

        public ActionResult CreateNewPackage()
        {
            ViewBag.Message = "Launched Create New Package Page";
            return View("~/Views/App/Packages/Add/Index.cshtml");

        }


        public ActionResult GetPackagesList([DataSourceRequest] DataSourceRequest request)
        {
            try
            {
                List<Packages> _package = new List<Packages>();
                _package.Add(new Packages(001, "Lorem ipsum dolor si", "Active", 0, "T-Mobile", "Quetzal", "06/21/2023 13:00:31", "-"));
                _package.Add(new Packages(002, "Lorem ipsum dolor si", "Active", 0, "T-Mobile", "Quetzal", "06/21/2023 13:00:31", "-"));
                _package.Add(new Packages(003, "Lorem ipsum dolor si", "Active", 0, "T-Mobile", "Quetzal", "06/21/2023 13:00:31", "-"));
                _package.Add(new Packages(004, "Lorem ipsum dolor si", "Active", 0, "T-Mobile", "Quetzal", "06/21/2023 13:00:31", "-"));
                _package.Add(new Packages(005, "Lorem ipsum dolor si", "Active", 0, "T-Mobile", "Quetzal", "06/21/2023 13:00:31", "-"));
                _package.Add(new Packages(006, "Lorem ipsum dolor si", "Active", 0, "T-Mobile", "Quetzal", "06/21/2023 13:00:31", "-"));
                _package.Add(new Packages(007, "Lorem ipsum dolor si", "Active", 0, "T-Mobile", "Quetzal", "06/21/2023 13:00:31", "-"));
                _package.Add(new Packages(008, "Lorem ipsum dolor si", "Active", 0, "T-Mobile", "Quetzal", "06/21/2023 13:00:31", "-"));
                _package.Add(new Packages(009, "Lorem ipsum dolor si", "Active", 0, "T-Mobile", "Quetzal", "06/21/2023 13:00:31", "-"));
                _package.Add(new Packages(010, "Lorem ipsum dolor si", "Active", 0, "T-Mobile", "Quetzal", "06/21/2023 13:00:31", "-"));
                _package.Add(new Packages(011, "Lorem ipsum dolor si", "Active", 0, "T-Mobile", "Quetzal", "06/21/2023 13:00:31", "-"));
                _package.Add(new Packages(012, "Lorem ipsum dolor si", "Active", 0, "T-Mobile", "Quetzal", "06/21/2023 13:00:31", "-"));
                _package.Add(new Packages(013, "Lorem ipsum dolor si", "Active", 0, "T-Mobile", "Quetzal", "06/21/2023 13:00:31", "-"));
                _package.Add(new Packages(014, "Lorem ipsum dolor si", "Active", 0, "T-Mobile", "Quetzal", "06/21/2023 13:00:31", "-"));
                _package.Add(new Packages(015, "Lorem ipsum dolor si", "Active", 0, "T-Mobile", "Quetzal", "06/21/2023 13:00:31", "-"));
                _package.Add(new Packages(016, "Lorem ipsum dolor si", "Active", 0, "T-Mobile", "Quetzal", "06/21/2023 13:00:31", "-"));
                _package.Add(new Packages(017, "Lorem ipsum dolor si", "Active", 0, "T-Mobile", "Quetzal", "06/21/2023 13:00:31", "-"));
                _package.Add(new Packages(018, "Lorem ipsum dolor si", "Active", 0, "T-Mobile", "Quetzal", "06/21/2023 13:00:31", "-"));
                _package.Add(new Packages(019, "Lorem ipsum dolor si", "Active", 0, "T-Mobile", "Quetzal", "06/21/2023 13:00:31", "-"));
                _package.Add(new Packages(020, "Lorem ipsum dolor si", "Active", 0, "T-Mobile", "Quetzal", "06/21/2023 13:00:31", "-"));


                DataSourceResult result = _package.ToDataSourceResult(request);
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(ex.Message, JsonRequestBehavior.AllowGet);

            }
        }
    }
}