Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace LegendTitleSample
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
'            #Region "#LegendTitleOptions"
            ' Specify legend title's text.
            chart.Legend.Title.Text = "Area of countries"
            ' Show legend title.
            chart.Legend.Title.Visible = True
            ' Configure legend title appearance.
            chart.Legend.Title.Alignment = StringAlignment.Near
            chart.Legend.Title.MaxLineCount = 3
            chart.Legend.Title.WordWrap = True
'            #End Region ' #LegendTitleOptions
        End Sub
    End Class
End Namespace
