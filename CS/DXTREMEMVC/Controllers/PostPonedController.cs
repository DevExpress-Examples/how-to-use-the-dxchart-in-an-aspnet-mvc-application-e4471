using System.Collections;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace DXTREMEMVC.Controllers {
    public class PostPonedController : Controller {
        public ActionResult PostPonedIndex() {
            return View();
        }

        public JsonResult GetScriptDataObject() {
            object model = GetDataObject();
            return Json(model, JsonRequestBehavior.AllowGet);
        }

        private IEnumerable GetDataObject() {
            return new DXTREMEMVC.Models.DataHelper().GetItems();
        }
    }
}