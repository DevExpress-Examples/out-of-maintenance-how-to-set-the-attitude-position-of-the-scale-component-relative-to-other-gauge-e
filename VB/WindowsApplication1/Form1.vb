Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraGauges.Core.Base

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Private defaultX, defaultY As Decimal
		Public Sub New()
			InitializeComponent()
			defaultX = Convert.ToDecimal(arcScaleComponent1.Center.X)
			defaultY = Convert.ToDecimal(arcScaleComponent1.Center.Y)
			ResetPosition()
		End Sub
		Private Sub ResetPosition()
			spinEditX.Value = defaultX
			spinEditY.Value = defaultY
		End Sub
		Private Sub spinEditX_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinEditX.EditValueChanged
			arcScaleComponent1.Center = New PointF2D(Convert.ToSingle(spinEditX.Value), arcScaleComponent1.Center.Y)
		End Sub
		Private Sub spinEditY_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinEditY.EditValueChanged
			arcScaleComponent1.Center = New PointF2D(arcScaleComponent1.Center.X, Convert.ToSingle(spinEditY.Value))
		End Sub
		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			ResetPosition()
		End Sub
	End Class
End Namespace