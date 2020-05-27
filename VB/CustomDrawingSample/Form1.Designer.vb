﻿Namespace CustomDrawingSample
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
			Me.components = New System.ComponentModel.Container()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' chart
			' 
			Me.chart.CrosshairOptions.CrosshairLabelMode = DevExpress.XtraCharts.CrosshairLabelMode.ShowForNearestSeries
			Me.chart.CrosshairOptions.HighlightPoints = False
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Legend.TextVisible = False
			Me.chart.Location = New System.Drawing.Point(0, 0)
			Me.chart.Margin = New System.Windows.Forms.Padding(4)
			Me.chart.Name = "chart"
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series(){}
			Me.chart.Size = New System.Drawing.Size(911, 445)
			Me.chart.TabIndex = 1
			chartTitle1.Text = "Sales Volume by Year"
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1})
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(7F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(911, 445)
			Me.Controls.Add(Me.chart)
			Me.Margin = New System.Windows.Forms.Padding(4)
			Me.Name = "Form1"
			Me.Text = "Form1"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Load += new System.EventHandler(this.Form1_Load);
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private chart As DevExpress.XtraCharts.ChartControl
		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
	End Class
End Namespace

