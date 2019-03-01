<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSOHeaderUpdate
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
        Me.txtnoso = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtsales = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblkodesales = New System.Windows.Forms.Label()
        Me.txtcust = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblkodecust = New System.Windows.Forms.Label()
        Me.CmdSave = New System.Windows.Forms.Button()
        Me.CmdClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No SO"
        '
        'txtnoso
        '
        Me.txtnoso.Location = New System.Drawing.Point(82, 6)
        Me.txtnoso.Name = "txtnoso"
        Me.txtnoso.Size = New System.Drawing.Size(100, 20)
        Me.txtnoso.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(82, 32)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tanggal SO"
        '
        'txtsales
        '
        Me.txtsales.Location = New System.Drawing.Point(82, 58)
        Me.txtsales.Name = "txtsales"
        Me.txtsales.Size = New System.Drawing.Size(177, 20)
        Me.txtsales.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Sales"
        '
        'lblkodesales
        '
        Me.lblkodesales.AutoSize = True
        Me.lblkodesales.Location = New System.Drawing.Point(79, 81)
        Me.lblkodesales.Name = "lblkodesales"
        Me.lblkodesales.Size = New System.Drawing.Size(43, 13)
        Me.lblkodesales.TabIndex = 6
        Me.lblkodesales.Text = "[CODE]"
        '
        'txtcust
        '
        Me.txtcust.Location = New System.Drawing.Point(82, 97)
        Me.txtcust.Name = "txtcust"
        Me.txtcust.Size = New System.Drawing.Size(177, 20)
        Me.txtcust.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Customer"
        '
        'lblkodecust
        '
        Me.lblkodecust.AutoSize = True
        Me.lblkodecust.Location = New System.Drawing.Point(79, 120)
        Me.lblkodecust.Name = "lblkodecust"
        Me.lblkodecust.Size = New System.Drawing.Size(43, 13)
        Me.lblkodecust.TabIndex = 9
        Me.lblkodecust.Text = "[CODE]"
        '
        'CmdSave
        '
        Me.CmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdSave.Location = New System.Drawing.Point(15, 140)
        Me.CmdSave.Name = "CmdSave"
        Me.CmdSave.Size = New System.Drawing.Size(75, 23)
        Me.CmdSave.TabIndex = 10
        Me.CmdSave.Text = "Save"
        Me.CmdSave.UseVisualStyleBackColor = True
        '
        'CmdClose
        '
        Me.CmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdClose.Location = New System.Drawing.Point(223, 140)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Size = New System.Drawing.Size(75, 23)
        Me.CmdClose.TabIndex = 11
        Me.CmdClose.Text = "Close"
        Me.CmdClose.UseVisualStyleBackColor = True
        '
        'FrmSOHeaderUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 175)
        Me.Controls.Add(Me.CmdClose)
        Me.Controls.Add(Me.CmdSave)
        Me.Controls.Add(Me.lblkodecust)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtcust)
        Me.Controls.Add(Me.lblkodesales)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtsales)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtnoso)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmSOHeaderUpdate"
        Me.Text = "FrmSOHeaderUpdate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnoso As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtsales As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblkodesales As System.Windows.Forms.Label
    Friend WithEvents txtcust As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblkodecust As System.Windows.Forms.Label
    Friend WithEvents CmdSave As System.Windows.Forms.Button
    Friend WithEvents CmdClose As System.Windows.Forms.Button
End Class
