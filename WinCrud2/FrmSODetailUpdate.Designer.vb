<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSODetailUpdate
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnamaitem = New System.Windows.Forms.TextBox()
        Me.lblkodeitem = New System.Windows.Forms.Label()
        Me.txtQtyOrder = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHrgSat = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Item"
        '
        'txtnamaitem
        '
        Me.txtnamaitem.Location = New System.Drawing.Point(91, 6)
        Me.txtnamaitem.Name = "txtnamaitem"
        Me.txtnamaitem.Size = New System.Drawing.Size(239, 20)
        Me.txtnamaitem.TabIndex = 1
        '
        'lblkodeitem
        '
        Me.lblkodeitem.AutoSize = True
        Me.lblkodeitem.Location = New System.Drawing.Point(88, 29)
        Me.lblkodeitem.Name = "lblkodeitem"
        Me.lblkodeitem.Size = New System.Drawing.Size(43, 13)
        Me.lblkodeitem.TabIndex = 2
        Me.lblkodeitem.Text = "[CODE]"
        '
        'txtQtyOrder
        '
        Me.txtQtyOrder.Location = New System.Drawing.Point(91, 45)
        Me.txtQtyOrder.Name = "txtQtyOrder"
        Me.txtQtyOrder.Size = New System.Drawing.Size(40, 20)
        Me.txtQtyOrder.TabIndex = 3
        Me.txtQtyOrder.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Qty Order"
        '
        'txtHrgSat
        '
        Me.txtHrgSat.Location = New System.Drawing.Point(91, 71)
        Me.txtHrgSat.Name = "txtHrgSat"
        Me.txtHrgSat.Size = New System.Drawing.Size(100, 20)
        Me.txtHrgSat.TabIndex = 5
        Me.txtHrgSat.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Harga Satuan"
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(15, 97)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 7
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(264, 97)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 8
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'FrmSODetailUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 131)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtHrgSat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtQtyOrder)
        Me.Controls.Add(Me.lblkodeitem)
        Me.Controls.Add(Me.txtnamaitem)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmSODetailUpdate"
        Me.Text = "FrmSODetailUpdate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnamaitem As System.Windows.Forms.TextBox
    Friend WithEvents lblkodeitem As System.Windows.Forms.Label
    Friend WithEvents txtQtyOrder As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtHrgSat As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
End Class
