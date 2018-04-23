Imports Microsoft.VisualBasic
Imports System.Web.Mvc

Namespace DXTREMEMVC.Controllers
	Public Class HomeController
		Inherits Controller
		Public Function Index() As ActionResult
			Return View()
		End Function
	End Class
End Namespace
