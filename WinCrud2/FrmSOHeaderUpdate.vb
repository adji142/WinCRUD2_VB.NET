Imports WinCrud2.Test.Data
Imports MySql.Data.MySqlClient
Public Class FrmSOHeaderUpdate
    Private _DBConnection As New DBConnection
    Private Enum enumSaveMode
        AddMode = 1
        EditMode = 2
    End Enum
    Private _SaveMode As enumSaveMode
    Private _RowId As String
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        _SaveMode = enumSaveMode.AddMode
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(Optional ByVal RowID As String = "")

        ' This call is required by the designer.
        InitializeComponent()
        _RowId = RowID
        _SaveMode = enumSaveMode.EditMode
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsales.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Dim LookupSale As New FrmLookupSale(txtsales.Text)
                Dim Dr As DialogResult = LookupSale.ShowDialog()

                If Dr = Windows.Forms.DialogResult.OK Then
                    txtsales.Text = LookupSale.NamaSales
                    lblkodesales.Text = LookupSale.IDSales
                End If
        End Select
    End Sub

    Private Sub txtcust_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcust.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Dim LookupCust As New FrmLookupCust(txtcust.Text)
                Dim Dr As DialogResult = LookupCust.ShowDialog()

                If Dr = Windows.Forms.DialogResult.OK Then
                    txtcust.Text = LookupCust.NamaCust
                    lblkodecust.Text = LookupCust.IDCust
                End If
        End Select
    End Sub

    Private Sub CmdSave_Click(sender As Object, e As EventArgs) Handles CmdSave.Click
        If _SaveMode = enumSaveMode.EditMode Then
            Dim SQL As String
            Try
                SQL = "Update salesorder set KodeCust = '" + lblkodecust.Text + "', SalesID = '" + lblkodesales.Text + "' where RowID = '" + _RowId + "'"

                Using DBX As IDbConnection = _DBConnection.Connection
                    Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                    CMD.ExecuteNonQuery()
                End Using
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                Me.Dispose()
            End Try
        Else
            Dim SQL As String
            Try
                SQL = "insert into salesorder values " +
                "('" + Guid.NewGuid.ToString() + "','" + txtnoso.Text + "'," +
                "'" + DateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "','" + lblkodecust.Text + "'," +
                "'" + lblkodesales.Text + "','',now(),0)"

                Using DBX As IDbConnection = _DBConnection.Connection
                    Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                    CMD.ExecuteNonQuery()
                End Using
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                Me.Dispose()
            End Try
        End If

    End Sub

    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles CmdClose.Click
        Me.Dispose()
    End Sub

    Private Sub FrmSOHeaderUpdate_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If _SaveMode = enumSaveMode.EditMode Then
            Dim Sql As String
            Try
                Sql = "Select a.rowid as RowIDH," +
                "a.NoSO as NoSO," +
                "a.TglSO as TglSO," +
                "tc.NamaCustomer as NamaCustomer," +
                "tc.Alamat01 as Alamat01," +
                "s.KodeSales,s.NamaSales,a.nPrint,a.KodeCust" +
                " from SalesOrder a" +
                " Inner Join tsales s on a.SalesID = s.KodeSales" +
                " inner join tcustomer tc on tc.KodeCustomer = a.KodeCust" +
                " Where a.rowid = '" + _RowId + "'"

                Using DBX As IDbConnection = _DBConnection.Connection
                    Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(Sql, DBX)
                    Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                    Dim ds As New DataSet
                    Dim BS As New BindingSource

                    DA.SelectCommand = CMD
                    DA.Fill(ds, "View")

                    Dim Noso As String = ds.Tables(0).Rows(0)("NoSO").ToString()
                    Dim tglSO As DateTime = DateTime.ParseExact(ds.Tables(0).Rows(0)("TglSO"), "dd/MM/yyyy", Nothing)
                    Dim NamaSales As String = ds.Tables(0).Rows(0)("NamaSales").ToString()
                    Dim KodeSales As String = ds.Tables(0).Rows(0)("KodeSales").ToString()

                    Dim NamaCust As String = ds.Tables(0).Rows(0)("NamaCustomer").ToString()
                    Dim KodeCust As String = ds.Tables(0).Rows(0)("KodeCust").ToString()

                    txtnoso.Enabled = False
                    DateTimePicker1.Enabled = False

                    txtnoso.Text = Noso
                    DateTimePicker1.Value = tglSO 'New Date(tglSO.ToString("dd/MM/yyyy"))
                    txtsales.Text = NamaSales
                    lblkodesales.Text = KodeSales
                    txtcust.Text = NamaCust
                    lblkodecust.Text = KodeCust

                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
End Class