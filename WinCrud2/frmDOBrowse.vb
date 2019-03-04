Imports WinCrud2.Test.Data
Imports MySql.Data.MySqlClient
Public Class frmDOBrowse
    Private _DBConnection As New DBConnection
    Dim _RowIDH As String = ""
    Dim _RowIDDet As String = ""
    Dim _Selected As String = ""
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs)

    End Sub

    'Select Case e.KeyCode
    '        Case Keys.Enter
    'Dim LookupCust As New FrmLookupCust(txtSearch.Text)
    'Dim Dr As DialogResult = LookupCust.ShowDialog()

    '            If Dr = Windows.Forms.DialogResult.OK Then
    '                txtSearch.Text = LookupCust.NamaCust
    '                lblKode.Text = LookupCust.IDCust
    '            End If
    '    End Select

    Private Sub CmdSearch_Click(sender As Object, e As EventArgs) Handles CmdSearch.Click
        Dim Sql As String
        Try
            Sql = "Select a.rowid as RowIDH," +
            "a.NoSO as NoSO," +
            "a.TglSO as TglSO," +
            "tc.NamaCustomer as NamaCustomer," +
            "tc.Alamat01 as Alamat01," +
            "s.KodeSales,s.NamaSales,a.nPrint" +
            " from SalesOrder a" +
            " Inner Join tsales s on a.SalesID = s.KodeSales" +
            " inner join tcustomer tc on tc.KodeCustomer = a.KodeCust" +
            " Where a.TglSO between '" + DateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "' and '" + DateTimePicker2.Value.Date.ToString("yyyy-MM-dd") + "'"

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(Sql, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim ds As New DataSet
                Dim BS As New BindingSource

                DA.SelectCommand = CMD
                DA.Fill(ds, "View")

                BS.DataSource = ds
                BS.DataMember = "View"
                ViewH.DataSource = BS

                If ds.Tables(0).Rows.Count > 0 Then
                    LoadHeader(_RowIDH)
                End If

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CmdAdd_Click(sender As Object, e As EventArgs) Handles CmdAdd.Click
        'Dim LookupCust As New FrmLookupSales("")
        'Dim Dr As DialogResult = LookupCust.ShowDialog()
        If _Selected = "Header" Then
            'call header form
            Dim Header As New FrmSOHeaderUpdate
            Dim Dr As DialogResult = Header.ShowDialog()
            If Dr = Windows.Forms.DialogResult.OK Then
                CmdSearch.PerformClick()
            End If

        Else
            'call detail form
            Dim Detail As New FrmSODetailUpdate(_RowIDH)
            Dim Dr As DialogResult = Detail.ShowDialog()
            If Dr = Windows.Forms.DialogResult.OK Then
                CmdSearch.PerformClick()
            End If
        End If
    End Sub

    Private Sub ViewH_SelectionChanged(sender As Object, e As EventArgs) Handles ViewH.SelectionChanged
        _RowIDH = ViewH.Rows(ViewH.CurrentRow.Index).Cells("RowID").Value.ToString()
        LoadHeader(_RowIDH)
    End Sub

    Private Sub LoadHeader(Optional ByVal Headerid As String = "")
        Dim Sql As String
        Sql = "select sod.RowID as RowIDD,i.NamaItem,sod.QtyOrder,sod.QtyDO,sod.HrgSatuan,sod.KodeBarang " +
            " From salesorderdetail sod" +
            " inner join titem i on i.KodeItem = sod.KodeBarang " +
            " where sod.HeaderID = '" + Headerid + "'"
        Using DBX As IDbConnection = _DBConnection.Connection
            Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(Sql, DBX)
            Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
            Dim ds As New DataSet
            Dim BS As New BindingSource

            DA.SelectCommand = CMD
            DA.Fill(ds, "View")

            BS.DataSource = ds
            BS.DataMember = "View"
            ViewD.DataSource = BS
        End Using
    End Sub

    Private Sub ViewH_Click(sender As Object, e As EventArgs) Handles ViewH.Click
        _Selected = "Header"
    End Sub

    Private Sub ViewD_Click(sender As Object, e As EventArgs) Handles ViewD.Click
        _Selected = "Detail"
    End Sub

    Private Sub frmDOBrowse_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        CmdSearch.PerformClick()
    End Sub

    Public Sub FindHeader()

    End Sub

    Private Sub CmdEdit_Click(sender As Object, e As EventArgs) Handles CmdEdit.Click
        If _Selected = "Header" Then
            'call header form
            Dim Header As New FrmSOHeaderUpdate(_RowIDH)
            Dim Dr As DialogResult = Header.ShowDialog()
            If Dr = Windows.Forms.DialogResult.OK Then
                CmdSearch.PerformClick()
            End If

        Else
            'call detail form
            Dim Detail As New FrmSODetailUpdate(_RowIDH, _RowIDDet)
            Dim Dr As DialogResult = Detail.ShowDialog()
            If Dr = Windows.Forms.DialogResult.OK Then
                CmdSearch.PerformClick()
            End If
        End If
    End Sub

    Private Sub ViewD_SelectionChanged(sender As Object, e As EventArgs) Handles ViewD.SelectionChanged
        _RowIDDet = ViewD.Rows(ViewD.CurrentRow.Index).Cells("RowIDD").Value.ToString()
    End Sub

    Private Sub CmdDel_Click(sender As Object, e As EventArgs) Handles CmdDel.Click
        If MessageBox.Show("Hapus Data Baris ini ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes And _Selected <> "Header" Then
            Dim SQL As String
            Try
                SQL = "Delete from salesorderdetail where rowid = '" + _RowIDDet + "'"
                Using DBX As IDbConnection = _DBConnection.Connection
                    Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                    CMD.ExecuteNonQuery()
                    MessageBox.Show("Data grid 2 Berhasil di Hapus")
                    CmdSearch.PerformClick()
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            If ViewD.Rows.Count = 0 Then
                Dim SQL As String
                Try
                    SQL = "Delete from salesorder where rowid = '" + _RowIDH + "'"
                    Using DBX As IDbConnection = _DBConnection.Connection
                        Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                        CMD.ExecuteNonQuery()
                        MessageBox.Show("Data grid 1 Berhasil di Hapus")
                        CmdSearch.PerformClick()
                    End Using
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Else
                MessageBox.Show("Masih ada data di grid 2.")
                Return
            End If
        End If
    End Sub

    Private Sub CmdPrint_Click(sender As Object, e As EventArgs) Handles CmdPrint.Click
        Dim ds As New System.Data.DataTable

        Dim NoDO As String = ViewH.Rows(ViewH.CurrentRow.Index).Cells("NoSO").Value.ToString()
        Dim TglSO As String = ViewH.Rows(ViewH.CurrentRow.Index).Cells("TglSO").Value.ToString()
        Dim NamaSales As String = ViewH.Rows(ViewH.CurrentRow.Index).Cells("NamaSales").Value.ToString()
        Dim KodeSales As String = ViewH.Rows(ViewH.CurrentRow.Index).Cells("KodeSales").Value.ToString()
        Dim NamaCustomer As String = ViewH.Rows(ViewH.CurrentRow.Index).Cells("NamaCust").Value.ToString()
        Dim Alamat As String = ViewH.Rows(ViewH.CurrentRow.Index).Cells("AlamatKirim").Value.ToString()

        Dim Sql As String
        Sql = "select sod.KodeBarang as KodeItem,i.NamaItem,sod.QtyOrder As Qty,sod.HrgSatuan As Hrg " +
            " From salesorderdetail sod" +
            " inner join titem i on i.KodeItem = sod.KodeBarang " +
            " where sod.HeaderID = '" + _RowIDH + "'"
        Using DBX As IDbConnection = _DBConnection.Connection
            Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(Sql, DBX)
            Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
            Dim BS As New BindingSource

            DA.SelectCommand = CMD
            DA.Fill(ds)

            Dim PrvCetak As New FrmReportViewer(_RowIDH, NoDO, TglSO, NamaSales, KodeSales, NamaCustomer, Alamat)
            'IsMdiContainer = True
            PrvCetak.MdiParent = frmMain
            'Dim PrvCetak As FrmReportViewer(ds)
            PrvCetak.Show()

        End Using
    End Sub
End Class