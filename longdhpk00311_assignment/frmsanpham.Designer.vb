<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsanpham
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
        Me.txt_masp = New System.Windows.Forms.Label()
        Me.txt_maloai = New System.Windows.Forms.Label()
        Me.txt_tensp = New System.Windows.Forms.Label()
        Me.txt_gia = New System.Windows.Forms.Label()
        Me.txt_nhasanxuat = New System.Windows.Forms.Label()
        Me.txt_mota = New System.Windows.Forms.Label()
        Me.txtmasp = New System.Windows.Forms.TextBox()
        Me.txtmaloai = New System.Windows.Forms.TextBox()
        Me.txttensp = New System.Windows.Forms.TextBox()
        Me.txtgia = New System.Windows.Forms.TextBox()
        Me.txtmota = New System.Windows.Forms.TextBox()
        Me.txtnhasx = New System.Windows.Forms.TextBox()
        Me.lstsp = New System.Windows.Forms.ListView()
        Me.masp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.maloai = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tensp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mota = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nhasx = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bntthem = New System.Windows.Forms.Button()
        Me.bntxoa = New System.Windows.Forms.Button()
        Me.bntsua = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLSPMALOAI = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txt_masp
        '
        Me.txt_masp.AutoSize = True
        Me.txt_masp.Location = New System.Drawing.Point(40, 46)
        Me.txt_masp.Name = "txt_masp"
        Me.txt_masp.Size = New System.Drawing.Size(74, 13)
        Me.txt_masp.TabIndex = 0
        Me.txt_masp.Text = "Mã Sản Phẩm"
        Me.txt_masp.UseWaitCursor = True
        '
        'txt_maloai
        '
        Me.txt_maloai.AutoSize = True
        Me.txt_maloai.Location = New System.Drawing.Point(40, 119)
        Me.txt_maloai.Name = "txt_maloai"
        Me.txt_maloai.Size = New System.Drawing.Size(45, 13)
        Me.txt_maloai.TabIndex = 1
        Me.txt_maloai.Text = "Mã Loại"
        '
        'txt_tensp
        '
        Me.txt_tensp.AutoSize = True
        Me.txt_tensp.Location = New System.Drawing.Point(40, 152)
        Me.txt_tensp.Name = "txt_tensp"
        Me.txt_tensp.Size = New System.Drawing.Size(78, 13)
        Me.txt_tensp.TabIndex = 2
        Me.txt_tensp.Text = "Tên Sản Phẩm"
        '
        'txt_gia
        '
        Me.txt_gia.AutoSize = True
        Me.txt_gia.Location = New System.Drawing.Point(40, 186)
        Me.txt_gia.Name = "txt_gia"
        Me.txt_gia.Size = New System.Drawing.Size(23, 13)
        Me.txt_gia.TabIndex = 3
        Me.txt_gia.Text = "Giá"
        '
        'txt_nhasanxuat
        '
        Me.txt_nhasanxuat.AutoSize = True
        Me.txt_nhasanxuat.Location = New System.Drawing.Point(40, 253)
        Me.txt_nhasanxuat.Name = "txt_nhasanxuat"
        Me.txt_nhasanxuat.Size = New System.Drawing.Size(74, 13)
        Me.txt_nhasanxuat.TabIndex = 4
        Me.txt_nhasanxuat.Text = "Nhà Sản Xuất"
        '
        'txt_mota
        '
        Me.txt_mota.AutoSize = True
        Me.txt_mota.Location = New System.Drawing.Point(40, 223)
        Me.txt_mota.Name = "txt_mota"
        Me.txt_mota.Size = New System.Drawing.Size(38, 13)
        Me.txt_mota.TabIndex = 5
        Me.txt_mota.Text = "Mô Tả"
        '
        'txtmasp
        '
        Me.txtmasp.Location = New System.Drawing.Point(136, 43)
        Me.txtmasp.Name = "txtmasp"
        Me.txtmasp.Size = New System.Drawing.Size(100, 20)
        Me.txtmasp.TabIndex = 6
        '
        'txtmaloai
        '
        Me.txtmaloai.Location = New System.Drawing.Point(136, 116)
        Me.txtmaloai.Name = "txtmaloai"
        Me.txtmaloai.Size = New System.Drawing.Size(100, 20)
        Me.txtmaloai.TabIndex = 7
        '
        'txttensp
        '
        Me.txttensp.Location = New System.Drawing.Point(136, 149)
        Me.txttensp.Name = "txttensp"
        Me.txttensp.Size = New System.Drawing.Size(100, 20)
        Me.txttensp.TabIndex = 8
        '
        'txtgia
        '
        Me.txtgia.Location = New System.Drawing.Point(136, 183)
        Me.txtgia.Name = "txtgia"
        Me.txtgia.Size = New System.Drawing.Size(100, 20)
        Me.txtgia.TabIndex = 9
        '
        'txtmota
        '
        Me.txtmota.Location = New System.Drawing.Point(136, 220)
        Me.txtmota.Name = "txtmota"
        Me.txtmota.Size = New System.Drawing.Size(100, 20)
        Me.txtmota.TabIndex = 10
        '
        'txtnhasx
        '
        Me.txtnhasx.Location = New System.Drawing.Point(136, 250)
        Me.txtnhasx.Name = "txtnhasx"
        Me.txtnhasx.Size = New System.Drawing.Size(100, 20)
        Me.txtnhasx.TabIndex = 11
        '
        'lstsp
        '
        Me.lstsp.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.masp, Me.maloai, Me.tensp, Me.gia, Me.mota, Me.nhasx})
        Me.lstsp.FullRowSelect = True
        Me.lstsp.GridLines = True
        Me.lstsp.Location = New System.Drawing.Point(270, 33)
        Me.lstsp.MultiSelect = False
        Me.lstsp.Name = "lstsp"
        Me.lstsp.Size = New System.Drawing.Size(429, 203)
        Me.lstsp.TabIndex = 12
        Me.lstsp.UseCompatibleStateImageBehavior = False
        Me.lstsp.View = System.Windows.Forms.View.Details
        '
        'masp
        '
        Me.masp.Text = "Mã Sản Phẩm"
        '
        'maloai
        '
        Me.maloai.Text = "Mã Loại"
        '
        'tensp
        '
        Me.tensp.Text = "Tên Sản Phẩm"
        '
        'gia
        '
        Me.gia.Text = "Giá"
        '
        'mota
        '
        Me.mota.Text = "Mô Tả"
        '
        'nhasx
        '
        Me.nhasx.Text = "Nhà Sản Xuất"
        Me.nhasx.Width = 121
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(316, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Sản Phẩm"
        Me.Label1.UseWaitCursor = True
        '
        'bntthem
        '
        Me.bntthem.Location = New System.Drawing.Point(43, 296)
        Me.bntthem.Name = "bntthem"
        Me.bntthem.Size = New System.Drawing.Size(75, 23)
        Me.bntthem.TabIndex = 14
        Me.bntthem.Text = "Thêm"
        Me.bntthem.UseVisualStyleBackColor = True
        '
        'bntxoa
        '
        Me.bntxoa.Location = New System.Drawing.Point(145, 296)
        Me.bntxoa.Name = "bntxoa"
        Me.bntxoa.Size = New System.Drawing.Size(75, 23)
        Me.bntxoa.TabIndex = 15
        Me.bntxoa.Text = "Xóa"
        Me.bntxoa.UseVisualStyleBackColor = True
        '
        'bntsua
        '
        Me.bntsua.Location = New System.Drawing.Point(252, 296)
        Me.bntsua.Name = "bntsua"
        Me.bntsua.Size = New System.Drawing.Size(75, 23)
        Me.bntsua.TabIndex = 16
        Me.bntsua.Text = "Sửa"
        Me.bntsua.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "LSP_MaLoai"
        '
        'txtLSPMALOAI
        '
        Me.txtLSPMALOAI.Location = New System.Drawing.Point(136, 80)
        Me.txtLSPMALOAI.Name = "txtLSPMALOAI"
        Me.txtLSPMALOAI.Size = New System.Drawing.Size(100, 20)
        Me.txtLSPMALOAI.TabIndex = 18
        '
        'frmsanpham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 331)
        Me.Controls.Add(Me.txtLSPMALOAI)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bntsua)
        Me.Controls.Add(Me.bntxoa)
        Me.Controls.Add(Me.bntthem)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstsp)
        Me.Controls.Add(Me.txtnhasx)
        Me.Controls.Add(Me.txtmota)
        Me.Controls.Add(Me.txtgia)
        Me.Controls.Add(Me.txttensp)
        Me.Controls.Add(Me.txtmaloai)
        Me.Controls.Add(Me.txtmasp)
        Me.Controls.Add(Me.txt_mota)
        Me.Controls.Add(Me.txt_nhasanxuat)
        Me.Controls.Add(Me.txt_gia)
        Me.Controls.Add(Me.txt_tensp)
        Me.Controls.Add(Me.txt_maloai)
        Me.Controls.Add(Me.txt_masp)
        Me.Name = "frmsanpham"
        Me.Text = "frmsanpham"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_masp As System.Windows.Forms.Label
    Friend WithEvents txt_maloai As System.Windows.Forms.Label
    Friend WithEvents txt_tensp As System.Windows.Forms.Label
    Friend WithEvents txt_gia As System.Windows.Forms.Label
    Friend WithEvents txt_nhasanxuat As System.Windows.Forms.Label
    Friend WithEvents txt_mota As System.Windows.Forms.Label
    Friend WithEvents txtmasp As System.Windows.Forms.TextBox
    Friend WithEvents txtmaloai As System.Windows.Forms.TextBox
    Friend WithEvents txttensp As System.Windows.Forms.TextBox
    Friend WithEvents txtgia As System.Windows.Forms.TextBox
    Friend WithEvents txtmota As System.Windows.Forms.TextBox
    Friend WithEvents txtnhasx As System.Windows.Forms.TextBox
    Friend WithEvents lstsp As System.Windows.Forms.ListView
    Friend WithEvents masp As System.Windows.Forms.ColumnHeader
    Friend WithEvents maloai As System.Windows.Forms.ColumnHeader
    Friend WithEvents tensp As System.Windows.Forms.ColumnHeader
    Friend WithEvents gia As System.Windows.Forms.ColumnHeader
    Friend WithEvents mota As System.Windows.Forms.ColumnHeader
    Friend WithEvents nhasx As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bntthem As System.Windows.Forms.Button
    Friend WithEvents bntxoa As System.Windows.Forms.Button
    Friend WithEvents bntsua As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLSPMALOAI As System.Windows.Forms.TextBox
End Class
