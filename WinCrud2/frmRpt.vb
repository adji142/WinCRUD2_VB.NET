Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Imports WinCrud2.Test.Data
Public Class frmRpt
    Dim ds As DataSet
    Private Sub frmRpt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Server As New ConnectionInfo
        Dim DataTable As Table



        Me.Cursor = Cursors.WaitCursor

        Dim DBX As Object = New DBConnection().ConnectionSetting()
        With Server
            .ServerName = "Localhost"
            .DatabaseName = "PP"
            .UserID = "Root"
            .Password = "lagis3nt0s4"
        End With

        Dim ReportObject As New ReportDocument

        ReportObject.Load("RptDoPrint.rpt")



    End Sub
End Class