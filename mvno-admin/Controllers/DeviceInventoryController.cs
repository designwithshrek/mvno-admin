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
    public class DeviceInventoryController : Controller
    {
        // GET: DeviceInventory
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetDeviceInventoryList([DataSourceRequest] DataSourceRequest request)
        {
            try
            {
                List<DeviceInventoryModel> _deviceInventory = new List<DeviceInventoryModel>();

                for (int i = 0; i < 20; i++)
                {
                    _deviceInventory.Add(new DeviceInventoryModel
                    (
                        DeviceId: i + 1,
                        Status: "Active",
                        CLEC: "Demo",
                        OrderId: 1000 + i,
                        ESN: $"ESN{i + 1}",
                        ILEC: $"ILEC{i + 1}",
                        UICC: $"UICC{i + 1}",
                        MSL: 123456 + i
                    ));
                }
                DataSourceResult result = _deviceInventory.ToDataSourceResult(request);
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(ex.Message, JsonRequestBehavior.AllowGet);

            }
        }
    }
}