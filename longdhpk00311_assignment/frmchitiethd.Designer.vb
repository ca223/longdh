<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmchitiethd
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
        Me.lstcthd = New System.Windows.Forms.ListView()
        Me.maCTHD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mahd = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.soluong = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ngayxuat = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mota = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lbl_mota = New System.Windows.Forms.Label()
        Me.lbl_ngayxuat = New System.Windows.Forms.Label()
        Me.lbl_soluong = New System.Windows.Forms.Label()
        Me.lbl_tensp = New System.Windows.Forms.Label()
        Me.lbl_hd = New System.Windows.Forms.Label()
        Me.lbl_machitiethd = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.tensp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstcthd
        '
        Me.lstcthd.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.maCTHD, Me.mahd, Me.tensp, Me.soluong, Me.ngayxuat, Me.mota})
        Me.lstcthd.FullRowSelect = True
        Me.lstcthd.GridLines = True
        Me.lstcthd.Location = New System.Drawing.Point(355, 92)
        Me.lstcthd.Name = "lstcthd"
        Me.lstcthd.Size = New System.Drawing.Size(517, 182)
        Me.lstcthd.TabIndex = 36
        Me.lstcthd.UseCompatibleStateImageBehavior = False
        Me.lstcthd.View = System.Windows.Forms.View.Details
        '
        'maCTHD
        '
        Me.maCTHD.Text = "Mã Chi Tiết HD"
        Me.maCTHD.Width = 91
        '
        'mahd
        '
        Me.mahd.Text = "Mã Hóa Đơn"
        Me.mahd.Width = 111
        '
        'soluong
        '
        Me.soluong.DisplayIndex = 2
        Me.soluong.Text = "Số Lượng"
        '
        'ngayxuat
        '
        Me.ngayxuat.DisplayIndex = 3
        Me.ngayxuat.Text = "Ngày Xuất"
        Me.ngayxuat.Width = 75
        '
        'mota
        '
        Me.mota.DisplayIndex = 4
        Me.mota.Text = "Mô Tả"
        '
        'lbl_mota
        '
        Me.lbl_mota.AutoSize = True
        Me.lbl_mota.Location = New System.Drawing.Point(190, 179)
        Me.lbl_mota.Name = "lbl_mota"
        Me.lbl_mota.Size = New System.Drawing.Size(38, 13)
        Me.lbl_mota.TabIndex = 35
        Me.lbl_mota.Text = "Mô Tả"
        '
        'lbl_ngayxuat
        '
        Me.lbl_ngayxuat.AutoSize = True
        Me.lbl_ngayxuat.Location = New System.Drawing.Point(190, 136)
        Me.lbl_ngayxuat.Name = "lbl_ngayxuat"
        Me.lbl_ngayxuat.Size = New System.Drawing.Size(57, 13)
        Me.lbl_ngayxuat.TabIndex = 34
        Me.lbl_ngayxuat.Text = "Ngày Xuất"
        '
        'lbl_soluong
        '
        Me.lbl_soluong.AutoSize = True
        Me.lbl_soluong.Location = New System.Drawing.Point(190, 99)
        Me.lbl_soluong.Name = "lbl_soluong"
        Me.lbl_soluong.Size = New System.Drawing.Size(53, 13)
        Me.lbl_soluong.TabIndex = 33
        Me.lbl_soluong.Text = "Số Lượng"
        '
        'lbl_tensp
        '
        Me.lbl_tensp.AutoSize = True
        Me.lbl_tensp.Location = New System.Drawing.Point(14, 179)
        Me.lbl_tensp.Name = "lbl_tensp"
        Me.lbl_tensp.Size = New System.Drawing.Size(78, 13)
        Me.lbl_tensp.TabIndex = 32
        Me.lbl_tensp.Text = "Tên Sản Phẩm"
        '
        'lbl_hd
        '
        Me.lbl_hd.AutoSize = True
        Me.lbl_hd.Location = New System.Drawing.Point(14, 136)
        Me.lbl_hd.Name = "lbl_hd"
        Me.lbl_hd.Size = New System.Drawing.Size(41, 13)
        Me.lbl_hd.TabIndex = 31
        Me.lbl_hd.Text = "Mã HD"
        '
        'lbl_machitiethd
        '
        Me.lbl_machitiethd.AutoSize = True
        Me.lbl_machitiethd.Location = New System.Drawing.Point(14, 99)
        Me.lbl_machitiethd.Name = "lbl_machitiethd"
        Me.lbl_machitiethd.Size = New System.Drawing.Size(55, 13)
        Me.lbl_machitiethd.TabIndex = 30
        Me.lbl_machitiethd.Text = "Mã CTHD"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(238, 226)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "Sửa"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(121, 226)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "Xóa"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(20, 226)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Thêm"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(249, 176)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 26
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(249, 133)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 25
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(249, 92)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 24
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(84, 176)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 23
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(84, 133)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 22
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(84, 92)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 21
        '
        'tensp
        '
        Me.tensp.DisplayIndex = 5
        Me.tensp.Text = "Tên Sản Phẩm"
        Me.tensp.Width = 83
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(361, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "CHI TIẾT HÓA ĐƠN"
        '
        'frmchitiethd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 335)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstcthd)
        Me.Controls.Add(Me.lbl_mota)
        Me.Controls.Add(Me.lbl_ngayxuat)
        Me.Controls.Add(Me.lbl_soluong)
        Me.Controls.Add(Me.lbl_tensp)
        Me.Controls.Add(Me.lbl_hd)
        Me.Controls.Add(Me.lbl_machitiethd)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "frmchitiethd"
        Me.Text = "frmchitiethd"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstcthd As System.Windows.Forms.ListView
    Friend WithEvents maCTHD As System.Windows.Forms.ColumnHeader
    Friend WithEvents mahd As System.Windows.Forms.ColumnHeader
    Friend WithEvents tensp As System.Windows.Forms.ColumnHeader
    Friend WithEvents soluong As System.Windows.Forms.ColumnHeader
    Friend WithEvents ngayxuat As System.Windows.Forms.ColumnHeader
    Friend WithEvents mota As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbl_mota As System.Windows.Forms.Label
    Friend WithEvents lbl_ngayxuat As System.Windows.Forms.Label
    Friend WithEvents lbl_soluong As System.Windows.Forms.Label
    Friend WithEvents lbl_tensp As System.Windows.Forms.Label
    Friend WithEvents lbl_hd As System.Windows.Forms.Label
    Friend WithEvents lbl_machitiethd As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
