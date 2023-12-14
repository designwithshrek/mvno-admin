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
    public class SubscribersController : Controller
    {
        public ActionResult SubscribersList()
        {
            ViewBag.Message = "Launched Subscribers Page";
            return View("~/Views/App/Subscribers/Index.cshtml");

        }

        public ActionResult CreateNewSubscriber()
        {
            ViewBag.Message = "Launched Create Subscriber Page";
            return View("~/Views/App/Subscribers/Add/Index.cshtml");

        }

        public ActionResult GetSubscribersList([DataSourceRequest] DataSourceRequest request)
        {
            try
            {
                List<Subscribers> _subscriber = new List<Subscribers>();
                _subscriber.Add(new Subscribers(35684836, "Active", "Demo", "unavosupport", 9203052333, "John", "Clavin", "3,000 Data Only Pan", 123456, "ACP", false, false));
                _subscriber.Add(new Subscribers(35684836, "Active", "Demo", "unavosupport", 9203052333, "John", "Clavin", "3,000 Data Only Pan", 123456, "ACP", false, false));
                _subscriber.Add(new Subscribers(35684836, "Active", "Demo", "unavosupport", 9203052333, "John", "Clavin", "3,000 Data Only Pan", 123456, "ACP", false, false));
                _subscriber.Add(new Subscribers(35684836, "Active", "Demo", "unavosupport", 9203052333, "John", "Clavin", "3,000 Data Only Pan", 123456, "ACP", false, false));
                _subscriber.Add(new Subscribers(35684836, "Active", "Demo", "unavosupport", 9203052333, "John", "Clavin", "3,000 Data Only Pan", 123456, "ACP", false, false));
                _subscriber.Add(new Subscribers(35684836, "Active", "Demo", "unavosupport", 9203052333, "John", "Clavin", "3,000 Data Only Pan", 123456, "ACP", false, false));
                _subscriber.Add(new Subscribers(35684836, "Active", "Demo", "unavosupport", 9203052333, "John", "Clavin", "3,000 Data Only Pan", 123456, "ACP", false, false));
                _subscriber.Add(new Subscribers(35684836, "Active", "Demo", "unavosupport", 9203052333, "John", "Clavin", "3,000 Data Only Pan", 123456, "ACP", false, false));
                _subscriber.Add(new Subscribers(35684836, "Active", "Demo", "unavosupport", 9203052333, "John", "Clavin", "3,000 Data Only Pan", 123456, "ACP", false, false));
                _subscriber.Add(new Subscribers(35684836, "Active", "Demo", "unavosupport", 9203052333, "John", "Clavin", "3,000 Data Only Pan", 123456, "ACP", false, false));
                _subscriber.Add(new Subscribers(35684836, "Active", "Demo", "unavosupport", 9203052333, "John", "Clavin", "3,000 Data Only Pan", 123456, "ACP", false, false));
                _subscriber.Add(new Subscribers(35684836, "Active", "Demo", "unavosupport", 9203052333, "John", "Clavin", "3,000 Data Only Pan", 123456, "ACP", false, false));
                _subscriber.Add(new Subscribers(35684836, "Active", "Demo", "unavosupport", 9203052333, "John", "Clavin", "3,000 Data Only Pan", 123456, "ACP", false, false));
                _subscriber.Add(new Subscribers(35684836, "Active", "Demo", "unavosupport", 9203052333, "John", "Clavin", "3,000 Data Only Pan", 123456, "ACP", false, false));
                _subscriber.Add(new Subscribers(35684836, "Active", "Demo", "unavosupport", 9203052333, "John", "Clavin", "3,000 Data Only Pan", 123456, "ACP", false, false));
                _subscriber.Add(new Subscribers(35684836, "Active", "Demo", "unavosupport", 9203052333, "John", "Clavin", "3,000 Data Only Pan", 123456, "ACP", false, false));
                _subscriber.Add(new Subscribers(35684836, "Active", "Demo", "unavosupport", 9203052333, "John", "Clavin", "3,000 Data Only Pan", 123456, "ACP", false, false));
                _subscriber.Add(new Subscribers(35684836, "Active", "Demo", "unavosupport", 9203052333, "John", "Clavin", "3,000 Data Only Pan", 123456, "ACP", false, false));
                _subscriber.Add(new Subscribers(35684836, "Active", "Demo", "unavosupport", 9203052333, "John", "Clavin", "3,000 Data Only Pan", 123456, "ACP", false, false));
                _subscriber.Add(new Subscribers(35684836, "Active", "Demo", "unavosupport", 9203052333, "John", "Clavin", "3,000 Data Only Pan", 123456, "ACP", false, false));
                _subscriber.Add(new Subscribers(35684836, "Active", "Demo", "unavosupport", 9203052333, "John", "Clavin", "3,000 Data Only Pan", 123456, "ACP", false, false));
                _subscriber.Add(new Subscribers(35684836, "Active", "Demo", "unavosupport", 9203052333, "John", "Clavin", "3,000 Data Only Pan", 123456, "ACP", false, false));
                _subscriber.Add(new Subscribers(35684836, "Active", "Demo", "unavosupport", 9203052333, "John", "Clavin", "3,000 Data Only Pan", 123456, "ACP", false, false));
                _subscriber.Add(new Subscribers(35684836, "Active", "Demo", "unavosupport", 9203052333, "John", "Clavin", "3,000 Data Only Pan", 123456, "ACP", false, false));
                _subscriber.Add(new Subscribers(35684836, "Active", "Demo", "unavosupport", 9203052333, "John", "Clavin", "3,000 Data Only Pan", 123456, "ACP", false, false));
                _subscriber.Add(new Subscribers(35684836, "Active", "Demo", "unavosupport", 9203052333, "John", "Clavin", "3,000 Data Only Pan", 123456, "ACP", false, false));
                _subscriber.Add(new Subscribers(35684836, "Active", "Demo", "unavosupport", 9203052333, "John", "Clavin", "3,000 Data Only Pan", 123456, "ACP", false, false));
                _subscriber.Add(new Subscribers(35684836, "Active", "Demo", "unavosupport", 9203052333, "John", "Clavin", "3,000 Data Only Pan", 123456, "ACP", false, false));
                _subscriber.Add(new Subscribers(35684836, "Active", "Demo", "unavosupport", 9203052333, "John", "Clavin", "3,000 Data Only Pan", 123456, "ACP", false, false));
                _subscriber.Add(new Subscribers(35684836, "Active", "Demo", "unavosupport", 9203052333, "John", "Clavin", "3,000 Data Only Pan", 123456, "ACP", false, false));
                _subscriber.Add(new Subscribers(35684836, "Active", "Demo", "unavosupport", 9203052333, "John", "Clavin", "3,000 Data Only Pan", 123456, "ACP", false, false));
                _subscriber.Add(new Subscribers(35684836, "Active", "Demo", "unavosupport", 9203052333, "John", "Clavin", "3,000 Data Only Pan", 123456, "ACP", false, false));

                DataSourceResult result = _subscriber.ToDataSourceResult(request);
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(ex.Message, JsonRequestBehavior.AllowGet);

            }
        }
    }
}