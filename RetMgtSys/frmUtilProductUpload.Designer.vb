<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtilProductUpload
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cmdButton08 = New System.Windows.Forms.Button()
        Me.cmdButton02 = New System.Windows.Forms.Button()
        Me.cmdButton01 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtField02 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtField00 = New System.Windows.Forms.TextBox()
        Me.txtField01 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.cmdButton08)
        Me.Panel3.Controls.Add(Me.cmdButton02)
        Me.Panel3.Controls.Add(Me.cmdButton01)
        Me.Panel3.Location = New System.Drawing.Point(5, 115)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(445, 62)
        Me.Panel3.TabIndex = 9
        '
        'cmdButton08
        '
        Me.cmdButton08.Image = Global.RetailManagementSystem.My.Resources.Resources._exit
        Me.cmdButton08.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdButton08.Location = New System.Drawing.Point(385, 3)
        Me.cmdButton08.Name = "cmdButton08"
        Me.cmdButton08.Size = New System.Drawing.Size(53, 53)
        Me.cmdButton08.TabIndex = 7
        Me.cmdButton08.Text = "Close"
        Me.cmdButton08.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdButton08.UseVisualStyleBackColor = True
        '
        'cmdButton02
        '
        Me.cmdButton02.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdButton02.Image = Global.RetailManagementSystem.My.Resources.Resources.update
        Me.cmdButton02.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdButton02.Location = New System.Drawing.Point(333, 3)
        Me.cmdButton02.Name = "cmdButton02"
        Me.cmdButton02.Size = New System.Drawing.Size(53, 53)
        Me.cmdButton02.TabIndex = 1
        Me.cmdButton02.Text = "Upload"
        Me.cmdButton02.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdButton02.UseVisualStyleBackColor = True
        '
        'cmdButton01
        '
        Me.cmdButton01.Image = Global.RetailManagementSystem.My.Resources.Resources.browse
        Me.cmdButton01.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdButton01.Location = New System.Drawing.Point(280, 4)
        Me.cmdButton01.Name = "cmdButton01"
        Me.cmdButton01.Size = New System.Drawing.Size(53, 53)
        Me.cmdButton01.TabIndex = 3
        Me.cmdButton01.Text = "Browse"
        Me.cmdButton01.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdButton01.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtField02)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtField00)
        Me.Panel2.Controls.Add(Me.txtField01)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Location = New System.Drawing.Point(5, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(445, 105)
        Me.Panel2.TabIndex = 10
        '
        'txtField02
        '
        Me.txtField02.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtField02.Location = New System.Drawing.Point(333, 40)
        Me.txtField02.Name = "txtField02"
        Me.txtField02.Size = New System.Drawing.Size(92, 22)
        Me.txtField02.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(251, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Column No,"
        '
        'txtField00
        '
        Me.txtField00.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtField00.Location = New System.Drawing.Point(95, 9)
        Me.txtField00.Name = "txtField00"
        Me.txtField00.ReadOnly = True
        Me.txtField00.Size = New System.Drawing.Size(330, 22)
        Me.txtField00.TabIndex = 1
        Me.txtField00.TabStop = False
        '
        'txtField01
        '
        Me.txtField01.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtField01.Location = New System.Drawing.Point(95, 43)
        Me.txtField01.Name = "txtField01"
        Me.txtField01.Size = New System.Drawing.Size(92, 22)
        Me.txtField01.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(3, 12)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(29, 16)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "File"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(3, 43)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 16)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Row No,"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GrayText
        Me.Panel1.Location = New System.Drawing.Point(100, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(330, 22)
        Me.Panel1.TabIndex = 2
        '
        'frmUtilProductUpload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 183)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmUtilProductUpload"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Upload Inventory Maintenance"
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cmdButton08 As Button
    Friend WithEvents cmdButton01 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtField00 As TextBox
    Friend WithEvents txtField01 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmdButton02 As Button
    Friend WithEvents txtField02 As TextBox
    Friend WithEvents Label1 As Label
End Class
