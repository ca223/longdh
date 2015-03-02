<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmkhachhang
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
        Me.txt_ngaysinh = New System.Windows.Forms.TextBox()
        Me.lbl_sdt = New System.Windows.Forms.Label()
        Me.lbl_ngaysinh = New System.Windows.Forms.Label()
        Me.lbl_gioitinh = New System.Windows.Forms.Label()
        Me.lbl_tenkh = New System.Windows.Forms.Label()
        Me.lbl_diachi = New System.Windows.Forms.Label()
        Me.lbl_makh = New System.Windows.Forms.Label()
        Me.bntxoa = New System.Windows.Forms.Button()
        Me.bntsua = New System.Windows.Forms.Button()
        Me.bntthem = New System.Windows.Forms.Button()
        Me.txt_sdt = New System.Windows.Forms.TextBox()
        Me.txt_gioitinh = New System.Windows.Forms.TextBox()
        Me.txt_tenkh = New System.Windows.Forms.TextBox()
        Me.txt_diachi = New System.Windows.Forms.TextBox()
        Me.txt_idkh = New System.Windows.Forms.TextBox()
        Me.lstkh = New System.Windows.Forms.ListView()
        Me.makh = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tenkh = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gioitinh = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ngaysinh = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.diachi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.sdt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_ngaysinh
        '
        Me.txt_ngaysinh.Location = New System.Drawing.Point(105, 211)
        Me.txt_ngaysinh.Name = "txt_ngaysinh"
        Me.txt_ngaysinh.Size = New System.Drawing.Size(100, 20)
        Me.txt_ngaysinh.TabIndex = 38
        '
        'lbl_sdt
        '
        Me.lbl_sdt.AutoSize = True
        Me.lbl_sdt.Location = New System.Drawing.Point(237, 105)
        Me.lbl_sdt.Name = "lbl_sdt"
        Me.lbl_sdt.Size = New System.Drawing.Size(29, 13)
        Me.lbl_sdt.TabIndex = 36
        Me.lbl_sdt.Text = "SDT"
        '
        'lbl_ngaysinh
        '
        Me.lbl_ngaysinh.AutoSize = True
        Me.lbl_ngaysinh.Location = New System.Drawing.Point(18, 214)
        Me.lbl_ngaysinh.Name = "lbl_ngaysinh"
        Me.lbl_ngaysinh.Size = New System.Drawing.Size(56, 13)
        Me.lbl_ngaysinh.TabIndex = 35
        Me.lbl_ngaysinh.Text = "Ngày Sinh"
        '
        'lbl_gioitinh
        '
        Me.lbl_gioitinh.AutoSize = True
        Me.lbl_gioitinh.Location = New System.Drawing.Point(18, 162)
        Me.lbl_gioitinh.Name = "lbl_gioitinh"
        Me.lbl_gioitinh.Size = New System.Drawing.Size(51, 13)
        Me.lbl_gioitinh.TabIndex = 34
        Me.lbl_gioitinh.Text = "Giới Tính"
        '
        'lbl_tenkh
        '
        Me.lbl_tenkh.AutoSize = True
        Me.lbl_tenkh.Location = New System.Drawing.Point(16, 105)
        Me.lbl_tenkh.Name = "lbl_tenkh"
        Me.lbl_tenkh.Size = New System.Drawing.Size(83, 13)
        Me.lbl_tenkh.TabIndex = 33
        Me.lbl_tenkh.Text = "Tên Kách Hàng"
        '
        'lbl_diachi
        '
        Me.lbl_diachi.AutoSize = True
        Me.lbl_diachi.Location = New System.Drawing.Point(237, 48)
        Me.lbl_diachi.Name = "lbl_diachi"
        Me.lbl_diachi.Size = New System.Drawing.Size(41, 13)
        Me.lbl_diachi.TabIndex = 32
        Me.lbl_diachi.Text = "Địa Chỉ"
        '
        'lbl_makh
        '
        Me.lbl_makh.AutoSize = True
        Me.lbl_makh.Location = New System.Drawing.Point(18, 51)
        Me.lbl_makh.Name = "lbl_makh"
        Me.lbl_makh.Size = New System.Drawing.Size(85, 13)
        Me.lbl_makh.TabIndex = 37
        Me.lbl_makh.Text = "Mã Khách Hàng"
        '
        'bntxoa
        '
        Me.bntxoa.Location = New System.Drawing.Point(300, 273)
        Me.bntxoa.Name = "bntxoa"
        Me.bntxoa.Size = New System.Drawing.Size(75, 39)
        Me.bntxoa.TabIndex = 31
        Me.bntxoa.Text = "Xóa"
        Me.bntxoa.UseVisualStyleBackColor = True
        '
        'bntsua
        '
        Me.bntsua.Location = New System.Drawing.Point(191, 273)
        Me.bntsua.Name = "bntsua"
        Me.bntsua.Size = New System.Drawing.Size(75, 39)
        Me.bntsua.TabIndex = 30
        Me.bntsua.Text = "Sửa"
        Me.bntsua.UseVisualStyleBackColor = True
        '
        'bntthem
        '
        Me.bntthem.Location = New System.Drawing.Point(80, 273)
        Me.bntthem.Name = "bntthem"
        Me.bntthem.Size = New System.Drawing.Size(75, 39)
        Me.bntthem.TabIndex = 29
        Me.bntthem.Text = "Thêm"
        Me.bntthem.UseVisualStyleBackColor = True
        '
        'txt_sdt
        '
        Me.txt_sdt.Location = New System.Drawing.Point(300, 102)
        Me.txt_sdt.Name = "txt_sdt"
        Me.txt_sdt.Size = New System.Drawing.Size(100, 20)
        Me.txt_sdt.TabIndex = 27
        '
        'txt_gioitinh
        '
        Me.txt_gioitinh.Location = New System.Drawing.Point(105, 159)
        Me.txt_gioitinh.Name = "txt_gioitinh"
        Me.txt_gioitinh.Size = New System.Drawing.Size(100, 20)
        Me.txt_gioitinh.TabIndex = 26
        '
        'txt_tenkh
        '
        Me.txt_tenkh.Location = New System.Drawing.Point(105, 102)
        Me.txt_tenkh.Name = "txt_tenkh"
        Me.txt_tenkh.Size = New System.Drawing.Size(100, 20)
        Me.txt_tenkh.TabIndex = 25
        '
        'txt_diachi
        '
        Me.txt_diachi.Location = New System.Drawing.Point(300, 48)
        Me.txt_diachi.Name = "txt_diachi"
        Me.txt_diachi.Size = New System.Drawing.Size(100, 20)
        Me.txt_diachi.TabIndex = 24
        '
        'txt_idkh
        '
        Me.txt_idkh.Location = New System.Drawing.Point(105, 48)
        Me.txt_idkh.Name = "txt_idkh"
        Me.txt_idkh.Size = New System.Drawing.Size(100, 20)
        Me.txt_idkh.TabIndex = 28
        '
        'lstkh
        '
        Me.lstkh.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.makh, Me.tenkh, Me.gioitinh, Me.ngaysinh, Me.diachi, Me.sdt})
        Me.lstkh.FullRowSelect = True
        Me.lstkh.GridLines = True
        Me.lstkh.Location = New System.Drawing.Point(420, 48)
        Me.lstkh.Name = "lstkh"
        Me.lstkh.Size = New System.Drawing.Size(429, 253)
        Me.lstkh.TabIndex = 23
        Me.lstkh.UseCompatibleStateImageBehavior = False
        Me.lstkh.View = System.Windows.Forms.View.Details
        '
        'makh
        '
        Me.makh.Text = "Mã Khách Hàng"
        Me.makh.Width = 100
        '
        'tenkh
        '
        Me.tenkh.Text = "Tên KH"
        '
        'gioitinh
        '
        Me.gioitinh.Text = "Giới Tinh"
        '
        'ngaysinh
        '
        Me.ngaysinh.Text = "Ngay Sinh"
        Me.ngaysinh.Width = 82
        '
        'diachi
        '
        Me.diachi.Text = "Dia Chi"
        '
        'sdt
        '
        Me.sdt.Text = "SDT"
        Me.sdt.Width = 62
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(405, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "KHÁCH HÀNG"
        '
        'frmkhachhang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 356)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_ngaysinh)
        Me.Controls.Add(Me.lbl_sdt)
        Me.Controls.Add(Me.lbl_ngaysinh)
        Me.Controls.Add(Me.lbl_gioitinh)
        Me.Controls.Add(Me.lbl_tenkh)
        Me.Controls.Add(Me.lbl_diachi)
        Me.Controls.Add(Me.lbl_makh)
        Me.Controls.Add(Me.bntxoa)
        Me.Controls.Add(Me.bntsua)
        Me.Controls.Add(Me.bntthem)
        Me.Controls.Add(Me.txt_sdt)
        Me.Controls.Add(Me.txt_gioitinh)
        Me.Controls.Add(Me.txt_tenkh)
        Me.Controls.Add(Me.txt_diachi)
        Me.Controls.Add(Me.txt_idkh)
        Me.Controls.Add(Me.lstkh)
        Me.Name = "frmkhachhang"
        Me.Text = "frmkhachhang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_ngaysinh As System.Windows.Forms.TextBox
    Friend WithEvents lbl_sdt As System.Windows.Forms.Label
    Friend WithEvents lbl_ngaysinh As System.Windows.Forms.Label
    Friend WithEvents lbl_gioitinh As System.Windows.Forms.Label
    Friend WithEvents lbl_tenkh As System.Windows.Forms.Label
    Friend WithEvents lbl_diachi As System.Windows.Forms.Label
    Friend WithEvents lbl_makh As System.Windows.Forms.Label
    Friend WithEvents bntxoa As System.Windows.Forms.Button
    Friend WithEvents bntsua As System.Windows.Forms.Button
    Friend WithEvents bntthem As System.Windows.Forms.Button
    Friend WithEvents txt_sdt As System.Windows.Forms.TextBox
    Friend WithEvents txt_gioitinh As System.Windows.Forms.TextBox
    Friend WithEvents txt_tenkh As System.Windows.Forms.TextBox
    Friend WithEvents txt_diachi As System.Windows.Forms.TextBox
    Friend WithEvents txt_idkh As System.Windows.Forms.TextBox
    Friend WithEvents lstkh As System.Windows.Forms.ListView
    Friend WithEvents makh As System.Windows.Forms.ColumnHeader
    Friend WithEvents tenkh As System.Windows.Forms.ColumnHeader
    Friend WithEvents gioitinh As System.Windows.Forms.ColumnHeader
    Friend WithEvents ngaysinh As System.Windows.Forms.ColumnHeader
    Friend WithEvents diachi As System.Windows.Forms.ColumnHeader
    Friend WithEvents sdt As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
