Imports Microsoft.VisualBasic
Imports System.Collections
Imports System.Web.Mvc
Imports System.Web.Script.Serialization

Namespace DXTREMEMVC.Controllers
	Public Class StartUpController
		Inherits Controller
		Public Function StartUpIndex() As ActionResult
			Dim model As Object = CreateScriptObjectFromDataObject(GetDataObject())
			Return View(model)
		End Function

		Private Function GetDataObject() As IEnumerable
			Return New DXTREMEMVC.Models.DataHelper().GetItems()
		End Function

		Private Function CreateScriptObjectFromDataObject(ByVal dataObject As IEnumerable) As String
			Dim serializer As New JavaScriptSerializer()
			Return serializer.Serialize(dataObject)
		End Function
	End Class
End Namespace
