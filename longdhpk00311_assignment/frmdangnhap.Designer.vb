<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdangnhap
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
        Me.txtMK = New System.Windows.Forms.TextBox()
        Me.txtTDN = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnT = New System.Windows.Forms.Button()
        Me.btnDN = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtMK
        '
        Me.txtMK.Location = New System.Drawing.Point(183, 113)
        Me.txtMK.Name = "txtMK"
        Me.txtMK.Size = New System.Drawing.Size(201, 20)
        Me.txtMK.TabIndex = 19
        '
        'txtTDN
        '
        Me.txtTDN.Location = New System.Drawing.Point(183, 82)
        Me.txtTDN.Name = "txtTDN"
        Me.txtTDN.Size = New System.Drawing.Size(201, 20)
        Me.txtTDN.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(90, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Mật Khẩu"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(90, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Tên Đăng Nhập"
        '
        'btnT
        '
        Me.btnT.Location = New System.Drawing.Point(216, 158)
        Me.btnT.Name = "btnT"
        Me.btnT.Size = New System.Drawing.Size(90, 31)
        Me.btnT.TabIndex = 15
        Me.btnT.Text = "Thoát"
        Me.btnT.UseVisualStyleBackColor = True
        '
        'btnDN
        '
        Me.btnDN.Location = New System.Drawing.Point(93, 158)
        Me.btnDN.Name = "btnDN"
        Me.btnDN.Size = New System.Drawing.Size(89, 31)
        Me.btnDN.TabIndex = 14
        Me.btnDN.Text = "Đăng nhập"
        Me.btnDN.UseVisualStyleBackColor = True
        '
        'frmdangnhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.longdhpk00311_assignment.My.Resources.Resources.Abstracte_patroon_achtergronden_patroon_wallpapers_afbeeldingen_10
        Me.ClientSize = New System.Drawing.Size(458, 274)
        Me.Controls.Add(Me.txtMK)
        Me.Controls.Add(Me.txtTDN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnT)
        Me.Controls.Add(Me.btnDN)
        Me.Name = "frmdangnhap"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMK As System.Windows.Forms.TextBox
    Friend WithEvents txtTDN As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnT As System.Windows.Forms.Button
    Friend WithEvents btnDN As System.Windows.Forms.Button

End Class
