Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data
Imports WinCrud2.Test.Data
Public Class FrmReportViewer
    Dim _ds As New dsRptData
    Dim _NoDO, _TglSO, _NamaSales, _KodeSales, _NamaCust, _alamat, _RowID As String
    Private _DBConnection As New DBConnection

    Public Sub New(ByVal ds As System.Data.DataSet)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(ByVal RowID As String, ByVal NoDo As String, ByVal TglSo As String, ByVal NamaSales As String, ByVal KodeSales As String, ByVal NamaCust As String, ByVal Alamat As String)

        ' This call is required by the designer.
        InitializeComponent()
        _NoDO = NoDo
        _TglSO = TglSo
        _NamaSales = NamaSales
        _KodeSales = KodeSales
        _NamaCust = NamaCust
        _alamat = Alamat
        _RowID = RowID
        ' Add any initialization after the InitializeComponent() call.
        '_ds.Tables.Add(dt)
        'Dim r As DataRow
        'Dim i As Integer = 0
        'Dim ii As Integer = dt.Rows.Count

        'For Each row As DataRow In dt.Rows
        '    r = _ds.Tables(0).NewRow
        '    r(0) = row(0)
        '    r(1) = row(1)
        '    r(2) = row(2)
        '    r(3) = row(3)
        '    _ds.Tables(0).Rows.Add(r)
        'Next row
    End Sub
    Private Sub FrmReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ReportObject As New ReportDocument()
        'Console.WriteLine(Application.StartupPath.Replace("bin\Debug", ""))
        ReportObject.Load(Application.StartupPath.Replace("bin\Debug", "") + "\RptDoPrint.rpt")

        'ReportObject.Database.Tables(0).SetDataSource(_ds)

        ' Param
        ReportObject.ParameterFields("NamaSales").CurrentValues.AddValue(_NamaSales)
        ReportObject.ParameterFields("KodeSales").CurrentValues.AddValue(_KodeSales)
        ReportObject.ParameterFields("NoSO").CurrentValues.AddValue(_NoDO)
        ReportObject.ParameterFields("TglSO").CurrentValues.AddValue(_TglSO)
        ReportObject.ParameterFields("NamaCustomer").CurrentValues.AddValue(_NamaCust)
        ReportObject.ParameterFields("Alamat").CurrentValues.AddValue(_alamat)
        ReportObject.ParameterFields("RowID").CurrentValues.AddValue(_RowID)


        CrystalReportViewer1.ReportSource = ReportObject
        CrystalReportViewer1.Refresh()

        Me.Cursor = Cursors.Default
        DoUpdate()
    End Sub
    Private Sub DoUpdate()
        Dim SQL As String
        Try
            SQL = "Update salesorder set nprint = nprint + 1 where RowID = '" + _RowID + "'"

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                CMD.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FrmReportViewer_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim FrmDO As New frmDOBrowse
        FrmDO.CmdSearch.PerformClick()
    End Sub
End Class