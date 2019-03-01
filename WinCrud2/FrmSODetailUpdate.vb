Imports WinCrud2.Test.Data
Imports MySql.Data.MySqlClient
Public Class FrmSODetailUpdate
    Private _DBConnection As New DBConnection
    Dim _Headerid As String = ""
    Dim _RowIDDet As String = ""
    Private Enum enumSaveMode
        AddMode = 1
        EditMode = 2
    End Enum
    Private _SaveMode As enumSaveMode
    Public Sub New(Optional ByVal HeaderID As String = "")

        ' This call is required by the designer.
        InitializeComponent()
        _Headerid = HeaderID
        _SaveMode = enumSaveMode.AddMode
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(Optional ByVal HeaderID As String = "", Optional ByVal RowIDD As String = "")

        ' This call is required by the designer.
        InitializeComponent()
        _Headerid = HeaderID
        _RowIDDet = RowIDD
        _SaveMode = enumSaveMode.EditMode
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub txtnamaitem_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnamaitem.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Dim LookupStock As New FrmLookupStock(txtnamaitem.Text)
                Dim Dr As DialogResult = LookupStock.ShowDialog()

                If Dr = Windows.Forms.DialogResult.OK Then
                    txtnamaitem.Text = LookupStock.NamaStock
                    lblkodeitem.Text = LookupStock.IDStock
                End If
        End Select
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If _SaveMode = enumSaveMode.EditMode Then
            Dim SQL As String
            Try
                SQL = "Update salesorderdetail set KodeBarang = '" + lblkodeitem.Text + "', " +
                    "QtyOrder = " + txtQtyOrder.Text + ", QtyDO = " + txtQtyOrder.Text +
                    ", HrgSatuan = " + txtHrgSat.Text + " where RowID = '" + _RowIDDet + "'"
                Console.WriteLine(SQL)
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
                SQL = "insert into salesorderDetail values " +
                "('" + Guid.NewGuid.ToString() + "','" + _Headerid + "'," +
                "'" + lblkodeitem.Text + "'," + txtQtyOrder.Text + "," +
                "" + txtQtyOrder.Text + "," + txtHrgSat.Text + ",'',now())"
                'Console.WriteLine(SQL)
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

    Private Sub FrmSODetailUpdate_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If _SaveMode = enumSaveMode.EditMode Then
            Dim Sql As String
            Sql = "select sod.RowID as RowIDD,i.NamaItem,sod.QtyOrder,sod.QtyDO,sod.HrgSatuan,sod.KodeBarang " +
                " From salesorderdetail sod" +
                " inner join titem i on i.KodeItem = sod.KodeBarang " +
                " where sod.RowID = '" + _RowIDDet + "'"
            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(Sql, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim ds As New DataSet
                Dim BS As New BindingSource

                DA.SelectCommand = CMD
                DA.Fill(ds, "View")

                Dim NamaItem As String = ds.Tables(0).Rows(0)("NamaItem").ToString()
                Dim KodeItem As String = ds.Tables(0).Rows(0)("KodeBarang").ToString()
                Dim Qty As String = ds.Tables(0).Rows(0)("QtyOrder").ToString()
                Dim Hrg As String = ds.Tables(0).Rows(0)("HrgSatuan").ToString()

                txtnamaitem.Text = NamaItem
                lblkodeitem.Text = KodeItem
                txtQtyOrder.Text = Qty
                txtHrgSat.Text = Microsoft.VisualBasic.Left(Hrg, Hrg.Length - 3)

            End Using
        End If
    End Sub
End Class