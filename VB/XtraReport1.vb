Imports System
' ...

Namespace PageWidth
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub xrLabel1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrLabel1.BeforePrint
			xrLabel1.Width = Convert.ToInt32(PrintingSystem.PageSettings.UsablePageSize.Width) - 1
		End Sub

	End Class
End Namespace
