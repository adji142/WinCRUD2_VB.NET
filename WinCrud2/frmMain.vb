Public Class frmMain

    Private Sub OrderPenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrderPenjualanToolStripMenuItem.Click
        Dim ifrmformDO As New frmDOBrowse
        IsMdiContainer = True
        ifrmformDO.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmformDO.Show()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
