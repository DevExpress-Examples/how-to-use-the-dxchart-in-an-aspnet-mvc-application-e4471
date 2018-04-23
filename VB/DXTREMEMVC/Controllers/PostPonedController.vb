Imports Microsoft.VisualBasic
Imports System.Collections
Imports System.Web.Helpers
Imports System.Web.Mvc
Imports System.Web.Script.Serialization

Namespace DXTREMEMVC.Controllers
	Public Class PostPonedController
		Inherits Controller
		Public Function PostPonedIndex() As ActionResult
			Return View()
		End Function

		Public Function GetScriptDataObject() As JsonResult
			Dim model As Object = GetDataObject()
			Return Json(model, JsonRequestBehavior.AllowGet)
		End Function

		Private Function GetDataObject() As IEnumerable
			Return New DXTREMEMVC.Models.DataHelper().GetItems()
		End Function
	End Class
End Namespace