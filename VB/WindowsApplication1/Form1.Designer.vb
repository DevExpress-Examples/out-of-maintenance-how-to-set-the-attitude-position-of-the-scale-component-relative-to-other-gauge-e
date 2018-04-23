Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.gaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl()
			Me.circularGauge1 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
			Me.arcScaleBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
			Me.arcScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
			Me.arcScaleEffectLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent()
			Me.lblTest = New DevExpress.XtraGauges.Win.Base.LabelComponent()
			Me.arcScaleNeedleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
			Me.spinEditX = New DevExpress.XtraEditors.SpinEdit()
			Me.spinEditY = New DevExpress.XtraEditors.SpinEdit()
			Me.lblX = New DevExpress.XtraEditors.LabelControl()
			Me.lblY = New DevExpress.XtraEditors.LabelControl()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.circularGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleEffectLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lblTest, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinEditX.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinEditY.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gaugeControl1
			' 
			Me.gaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() { Me.circularGauge1})
			Me.gaugeControl1.Location = New System.Drawing.Point(12, 12)
			Me.gaugeControl1.Name = "gaugeControl1"
			Me.gaugeControl1.Size = New System.Drawing.Size(260, 260)
			Me.gaugeControl1.TabIndex = 0
			' 
			' circularGauge1
			' 
			Me.circularGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() { Me.arcScaleBackgroundLayerComponent1})
			Me.circularGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 248, 248)
			Me.circularGauge1.EffectLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent() { Me.arcScaleEffectLayerComponent1})
			Me.circularGauge1.Labels.AddRange(New DevExpress.XtraGauges.Win.Base.LabelComponent() { Me.lblTest})
			Me.circularGauge1.Name = "cGauge1"
			Me.circularGauge1.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() { Me.arcScaleNeedleComponent1})
			Me.circularGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() { Me.arcScaleComponent1})
			' 
			' arcScaleBackgroundLayerComponent1
			' 
			Me.arcScaleBackgroundLayerComponent1.ArcScale = Me.arcScaleComponent1
			Me.arcScaleBackgroundLayerComponent1.Name = "bg1"
			Me.arcScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style7
			Me.arcScaleBackgroundLayerComponent1.Size = New System.Drawing.SizeF(210F, 210F)
			Me.arcScaleBackgroundLayerComponent1.ZOrder = 1000
			' 
			' arcScaleComponent1
			' 
			Me.arcScaleComponent1.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 140F)
			Me.arcScaleComponent1.EndAngle = 60F
			Me.arcScaleComponent1.MajorTickmark.FormatString = "{0:F0}"
			Me.arcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style7_2
			Me.arcScaleComponent1.MajorTickmark.TextOffset = 22F
			Me.arcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
			Me.arcScaleComponent1.MaxValue = 100F
			Me.arcScaleComponent1.MinorTickCount = 4
			Me.arcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style7_1
			Me.arcScaleComponent1.Name = "scale1"
			Me.arcScaleComponent1.RadiusX = 70F
			Me.arcScaleComponent1.RadiusY = 70F
			Me.arcScaleComponent1.StartAngle = -240F
			' 
			' arcScaleEffectLayerComponent1
			' 
			Me.arcScaleEffectLayerComponent1.ArcScale = Me.arcScaleComponent1
			Me.arcScaleEffectLayerComponent1.Name = "effect1"
			Me.arcScaleEffectLayerComponent1.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 1.06F)
			Me.arcScaleEffectLayerComponent1.Shader = New DevExpress.XtraGauges.Core.Drawing.OpacityShader("Opacity[0.75]")
			Me.arcScaleEffectLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.CircularFull_Style7
			Me.arcScaleEffectLayerComponent1.Size = New System.Drawing.SizeF(210F, 100F)
			Me.arcScaleEffectLayerComponent1.ZOrder = -1000
			' 
			' lblTest
			' 
			Me.lblTest.AppearanceText.Font = New System.Drawing.Font("Tahoma", 12F, (CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle)))
			Me.lblTest.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Blue")
			Me.lblTest.Name = "circularGauge1_Label1"
			Me.lblTest.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 20F)
			Me.lblTest.Text = "The Label!!!"
			Me.lblTest.ZOrder = -1001
			' 
			' arcScaleNeedleComponent1
			' 
			Me.arcScaleNeedleComponent1.ArcScale = Me.arcScaleComponent1
			Me.arcScaleNeedleComponent1.EndOffset = -25F
			Me.arcScaleNeedleComponent1.Name = "needle1"
			Me.arcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style7
			Me.arcScaleNeedleComponent1.StartOffset = -21F
			Me.arcScaleNeedleComponent1.ZOrder = -50
			' 
			' spinEditX
			' 
			Me.spinEditX.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.spinEditX.Location = New System.Drawing.Point(35, 287)
			Me.spinEditX.Name = "spinEditX"
			Me.spinEditX.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinEditX.Size = New System.Drawing.Size(50, 20)
			Me.spinEditX.TabIndex = 2
'			Me.spinEditX.EditValueChanged += New System.EventHandler(Me.spinEditX_EditValueChanged);
			' 
			' spinEditY
			' 
			Me.spinEditY.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.spinEditY.Location = New System.Drawing.Point(210, 287)
			Me.spinEditY.Name = "spinEditY"
			Me.spinEditY.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinEditY.Size = New System.Drawing.Size(50, 20)
			Me.spinEditY.TabIndex = 3
'			Me.spinEditY.EditValueChanged += New System.EventHandler(Me.spinEditY_EditValueChanged);
			' 
			' lblX
			' 
			Me.lblX.Location = New System.Drawing.Point(23, 290)
			Me.lblX.Name = "lblX"
			Me.lblX.Size = New System.Drawing.Size(6, 13)
			Me.lblX.TabIndex = 4
			Me.lblX.Text = "X"
			' 
			' lblY
			' 
			Me.lblY.Location = New System.Drawing.Point(198, 290)
			Me.lblY.Name = "lblY"
			Me.lblY.Size = New System.Drawing.Size(6, 13)
			Me.lblY.TabIndex = 5
			Me.lblY.Text = "Y"
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(117, 287)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(50, 20)
			Me.simpleButton1.TabIndex = 6
			Me.simpleButton1.Text = "Reset"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(285, 320)
			Me.Controls.Add(Me.simpleButton1)
			Me.Controls.Add(Me.lblY)
			Me.Controls.Add(Me.lblX)
			Me.Controls.Add(Me.spinEditY)
			Me.Controls.Add(Me.spinEditX)
			Me.Controls.Add(Me.gaugeControl1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.circularGauge1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleEffectLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lblTest, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinEditX.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinEditY.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private gaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl
		Private circularGauge1 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
		Private arcScaleBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
		Private arcScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
		Private arcScaleEffectLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent
		Private arcScaleNeedleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
		Private lblTest As DevExpress.XtraGauges.Win.Base.LabelComponent
		Private WithEvents spinEditX As DevExpress.XtraEditors.SpinEdit
		Private WithEvents spinEditY As DevExpress.XtraEditors.SpinEdit
		Private lblX As DevExpress.XtraEditors.LabelControl
		Private lblY As DevExpress.XtraEditors.LabelControl
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
	End Class
End Namespace

