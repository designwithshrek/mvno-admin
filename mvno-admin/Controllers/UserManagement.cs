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
    public class UserManagementController : Controller
    {
        public ActionResult UsersList()
        {
            ViewBag.Message = "Launched Subscribers Page";
            return View("~/Views/App/User Management/Index.cshtml");

        }


        public ActionResult GetUsersList([DataSourceRequest] DataSourceRequest request)
        {
            try
            {
                List<Users> _user = new List<Users>();
                _user.Add(new Users(1, "Admin", "John", "Clavin", "Lorem Ipsum Dolor", "jc@unavo.com", "Agent"));
                _user.Add(new Users(2, "Admin", "John", "Clavin", "Lorem Ipsum Dolor", "jc@unavo.com", "Agent"));
                _user.Add(new Users(3, "Admin", "John", "Clavin", "Lorem Ipsum Dolor", "jc@unavo.com", "Agent"));
                _user.Add(new Users(4, "Admin", "John", "Clavin", "Lorem Ipsum Dolor", "jc@unavo.com", "Agent"));
                _user.Add(new Users(5, "Admin", "John", "Clavin", "Lorem Ipsum Dolor", "jc@unavo.com", "Agent"));
                _user.Add(new Users(6, "Admin", "John", "Clavin", "Lorem Ipsum Dolor", "jc@unavo.com", "Agent"));
                _user.Add(new Users(7, "Admin", "John", "Clavin", "Lorem Ipsum Dolor", "jc@unavo.com", "Agent"));
                _user.Add(new Users(8, "Admin", "John", "Clavin", "Lorem Ipsum Dolor", "jc@unavo.com", "Agent"));
                _user.Add(new Users(9, "Admin", "John", "Clavin", "Lorem Ipsum Dolor", "jc@unavo.com", "Agent"));
                _user.Add(new Users(10, "Admin", "John", "Clavin", "Lorem Ipsum Dolor", "jc@unavo.com", "Agent"));

                DataSourceResult result = _user.ToDataSourceResult(request);
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(ex.Message, JsonRequestBehavior.AllowGet);

            }
        }
    }
}