Imports WinCrud2.Test.Data
Imports MySql.Data.MySqlClient
Public Class FrmLookupStock
    Public IDStock As String = ""
    Public NamaStock As String = ""

    Private _Key As String = ""
    Private _DBConnection As New DBConnection
    Public Sub New(Optional ByVal Key As String = "")

        ' This call is required by the designer.
        InitializeComponent()
        _Key = Key
        txtKey.Text = Key
        ShowData(Key)
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub FrmLookupCust_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowData(txtKey.Text)
    End Sub
    Private Sub ShowData(Optional ByVal Key As String = "")
        Dim Sql As String
        Sql = "Select KodeItem,NamaItem from titem where NamaItem like '%" & Key & "%'"

        Using DBX As IDbConnection = _DBConnection.Connection
            Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(Sql, DBX)
            Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
            Dim Ds As New DataSet
            Dim BS As New BindingSource

            'CMD.Parameters.AddWithValue("@Kriteria", txtKey.Text)
            DA.SelectCommand = CMD
            DA.Fill(Ds, "View")

            BS.DataSource = Ds
            BS.DataMember = "View"

            View.RowTemplate.Height = 16
            View.DataSource = BS
        End Using
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ShowData(txtKey.Text)
    End Sub

    Private Sub txtKey_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKey.KeyPress
        ShowData(txtKey.Text)
    End Sub

    Private Sub View_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles View.CellContentDoubleClick
        IDStock = View(0, View.CurrentCell.RowIndex).Value
        NamaStock = View(1, View.CurrentCell.RowIndex).Value

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Dispose()
    End Sub

    Private Sub cmdpilih_Click(sender As Object, e As EventArgs) Handles cmdpilih.Click
        IDStock = View(0, View.CurrentCell.RowIndex).Value
        NamaStock = View(1, View.CurrentCell.RowIndex).Value

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Dispose()
    End Sub
End Class