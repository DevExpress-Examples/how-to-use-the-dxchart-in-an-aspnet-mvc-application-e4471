using System.Collections;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace DXTREMEMVC.Controllers {
    public class StartUpController : Controller {
        public ActionResult StartUpIndex() {
            object model = CreateScriptObjectFromDataObject(GetDataObject());
            return View(model);
        }

        private IEnumerable GetDataObject() {
            return new DXTREMEMVC.Models.DataHelper().GetItems();
        }

        private string CreateScriptObjectFromDataObject(IEnumerable dataObject) {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            return serializer.Serialize(dataObject);
        }
    }
}
