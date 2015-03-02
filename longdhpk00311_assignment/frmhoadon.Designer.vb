<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmhoadon
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
        Me.lbl_tenhd = New System.Windows.Forms.Label()
        Me.lbl_ngayxuat = New System.Windows.Forms.Label()
        Me.lbl_makh = New System.Windows.Forms.Label()
        Me.lbl_nvxuathd = New System.Windows.Forms.Label()
        Me.lbl_mahd = New System.Windows.Forms.Label()
        Me.bntxoa = New System.Windows.Forms.Button()
        Me.bntsua = New System.Windows.Forms.Button()
        Me.bntthem = New System.Windows.Forms.Button()
        Me.txt_Tenhd = New System.Windows.Forms.TextBox()
        Me.txt_ngayxuat = New System.Windows.Forms.TextBox()
        Me.txt_idkh = New System.Windows.Forms.TextBox()
        Me.txt_nvXUATHD = New System.Windows.Forms.TextBox()
        Me.txt_idhd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblkhmakh = New System.Windows.Forms.Label()
        Me.txt_khmakh = New System.Windows.Forms.TextBox()
        Me.lsthd = New System.Windows.Forms.ListView()
        Me.Mahd = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.khmakh = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.makh = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nvxhd = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tenhd = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ngayxuat = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'lbl_tenhd
        '
        Me.lbl_tenhd.AutoSize = True
        Me.lbl_tenhd.Location = New System.Drawing.Point(223, 142)
        Me.lbl_tenhd.Name = "lbl_tenhd"
        Me.lbl_tenhd.Size = New System.Drawing.Size(72, 13)
        Me.lbl_tenhd.TabIndex = 50
        Me.lbl_tenhd.Text = "Tên Hóa Đơn"
        '
        'lbl_ngayxuat
        '
        Me.lbl_ngayxuat.AutoSize = True
        Me.lbl_ngayxuat.Location = New System.Drawing.Point(223, 184)
        Me.lbl_ngayxuat.Name = "lbl_ngayxuat"
        Me.lbl_ngayxuat.Size = New System.Drawing.Size(57, 13)
        Me.lbl_ngayxuat.TabIndex = 49
        Me.lbl_ngayxuat.Text = "Ngày Xuất"
        '
        'lbl_makh
        '
        Me.lbl_makh.AutoSize = True
        Me.lbl_makh.Location = New System.Drawing.Point(17, 183)
        Me.lbl_makh.Name = "lbl_makh"
        Me.lbl_makh.Size = New System.Drawing.Size(85, 13)
        Me.lbl_makh.TabIndex = 48
        Me.lbl_makh.Text = "Mã Khách Hàng"
        '
        'lbl_nvxuathd
        '
        Me.lbl_nvxuathd.AutoSize = True
        Me.lbl_nvxuathd.Location = New System.Drawing.Point(223, 85)
        Me.lbl_nvxuathd.Name = "lbl_nvxuathd"
        Me.lbl_nvxuathd.Size = New System.Drawing.Size(101, 13)
        Me.lbl_nvxuathd.TabIndex = 47
        Me.lbl_nvxuathd.Text = "Nhân Viên Xuất HD"
        '
        'lbl_mahd
        '
        Me.lbl_mahd.AutoSize = True
        Me.lbl_mahd.Location = New System.Drawing.Point(17, 88)
        Me.lbl_mahd.Name = "lbl_mahd"
        Me.lbl_mahd.Size = New System.Drawing.Size(68, 13)
        Me.lbl_mahd.TabIndex = 46
        Me.lbl_mahd.Text = "Mã Hóa Đơn"
        '
        'bntxoa
        '
        Me.bntxoa.Location = New System.Drawing.Point(286, 236)
        Me.bntxoa.Name = "bntxoa"
        Me.bntxoa.Size = New System.Drawing.Size(75, 39)
        Me.bntxoa.TabIndex = 45
        Me.bntxoa.Text = "Xóa"
        Me.bntxoa.UseVisualStyleBackColor = True
        '
        'bntsua
        '
        Me.bntsua.Location = New System.Drawing.Point(175, 236)
        Me.bntsua.Name = "bntsua"
        Me.bntsua.Size = New System.Drawing.Size(75, 39)
        Me.bntsua.TabIndex = 44
        Me.bntsua.Text = "Sửa"
        Me.bntsua.UseVisualStyleBackColor = True
        '
        'bntthem
        '
        Me.bntthem.Location = New System.Drawing.Point(69, 236)
        Me.bntthem.Name = "bntthem"
        Me.bntthem.Size = New System.Drawing.Size(75, 39)
        Me.bntthem.TabIndex = 43
        Me.bntthem.Text = "Thêm"
        Me.bntthem.UseVisualStyleBackColor = True
        '
        'txt_Tenhd
        '
        Me.txt_Tenhd.Location = New System.Drawing.Point(327, 135)
        Me.txt_Tenhd.Name = "txt_Tenhd"
        Me.txt_Tenhd.Size = New System.Drawing.Size(100, 20)
        Me.txt_Tenhd.TabIndex = 41
        '
        'txt_ngayxuat
        '
        Me.txt_ngayxuat.Location = New System.Drawing.Point(327, 183)
        Me.txt_ngayxuat.Name = "txt_ngayxuat"
        Me.txt_ngayxuat.Size = New System.Drawing.Size(100, 20)
        Me.txt_ngayxuat.TabIndex = 40
        '
        'txt_idkh
        '
        Me.txt_idkh.Location = New System.Drawing.Point(108, 180)
        Me.txt_idkh.Name = "txt_idkh"
        Me.txt_idkh.Size = New System.Drawing.Size(100, 20)
        Me.txt_idkh.TabIndex = 39
        '
        'txt_nvXUATHD
        '
        Me.txt_nvXUATHD.Location = New System.Drawing.Point(327, 82)
        Me.txt_nvXUATHD.Name = "txt_nvXUATHD"
        Me.txt_nvXUATHD.Size = New System.Drawing.Size(100, 20)
        Me.txt_nvXUATHD.TabIndex = 38
        '
        'txt_idhd
        '
        Me.txt_idhd.Location = New System.Drawing.Point(108, 85)
        Me.txt_idhd.Name = "txt_idhd"
        Me.txt_idhd.Size = New System.Drawing.Size(100, 20)
        Me.txt_idhd.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(414, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "HÓA ĐƠN"
        '
        'lblkhmakh
        '
        Me.lblkhmakh.AutoSize = True
        Me.lblkhmakh.Location = New System.Drawing.Point(17, 135)
        Me.lblkhmakh.Name = "lblkhmakh"
        Me.lblkhmakh.Size = New System.Drawing.Size(59, 13)
        Me.lblkhmakh.TabIndex = 52
        Me.lblkhmakh.Text = "KH_MAKH"
        '
        'txt_khmakh
        '
        Me.txt_khmakh.Location = New System.Drawing.Point(108, 132)
        Me.txt_khmakh.Name = "txt_khmakh"
        Me.txt_khmakh.Size = New System.Drawing.Size(100, 20)
        Me.txt_khmakh.TabIndex = 53
        '
        'lsthd
        '
        Me.lsthd.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Mahd, Me.khmakh, Me.makh, Me.nvxhd, Me.tenhd, Me.ngayxuat})
        Me.lsthd.FullRowSelect = True
        Me.lsthd.GridLines = True
        Me.lsthd.Location = New System.Drawing.Point(485, 82)
        Me.lsthd.Name = "lsthd"
        Me.lsthd.Size = New System.Drawing.Size(442, 193)
        Me.lsthd.TabIndex = 54
        Me.lsthd.UseCompatibleStateImageBehavior = False
        Me.lsthd.View = System.Windows.Forms.View.Details
        '
        'Mahd
        '
        Me.Mahd.Text = "Mã hd"
        '
        'khmakh
        '
        Me.khmakh.Text = "Mã KH"
        '
        'makh
        '
        Me.makh.Text = "Ma kh"
        '
        'nvxhd
        '
        Me.nvxhd.Text = "nhân viên xuât hd"
        '
        'tenhd
        '
        Me.tenhd.Text = "Tên hd"
        '
        'ngayxuat
        '
        Me.ngayxuat.Text = "ngày xuất"
        '
        'frmhoadon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 343)
        Me.Controls.Add(Me.lsthd)
        Me.Controls.Add(Me.txt_khmakh)
        Me.Controls.Add(Me.lblkhmakh)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_tenhd)
        Me.Controls.Add(Me.lbl_ngayxuat)
        Me.Controls.Add(Me.lbl_makh)
        Me.Controls.Add(Me.lbl_nvxuathd)
        Me.Controls.Add(Me.lbl_mahd)
        Me.Controls.Add(Me.bntxoa)
        Me.Controls.Add(Me.bntsua)
        Me.Controls.Add(Me.bntthem)
        Me.Controls.Add(Me.txt_Tenhd)
        Me.Controls.Add(Me.txt_ngayxuat)
        Me.Controls.Add(Me.txt_idkh)
        Me.Controls.Add(Me.txt_nvXUATHD)
        Me.Controls.Add(Me.txt_idhd)
        Me.Name = "frmhoadon"
        Me.Text = "frmhoadon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_tenhd As System.Windows.Forms.Label
    Friend WithEvents lbl_ngayxuat As System.Windows.Forms.Label
    Friend WithEvents lbl_makh As System.Windows.Forms.Label
    Friend WithEvents lbl_nvxuathd As System.Windows.Forms.Label
    Friend WithEvents lbl_mahd As System.Windows.Forms.Label
    Friend WithEvents bntxoa As System.Windows.Forms.Button
    Friend WithEvents bntsua As System.Windows.Forms.Button
    Friend WithEvents bntthem As System.Windows.Forms.Button
    Friend WithEvents txt_Tenhd As System.Windows.Forms.TextBox
    Friend WithEvents txt_ngayxuat As System.Windows.Forms.TextBox
    Friend WithEvents txt_idkh As System.Windows.Forms.TextBox
    Friend WithEvents txt_nvXUATHD As System.Windows.Forms.TextBox
    Friend WithEvents txt_idhd As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblkhmakh As System.Windows.Forms.Label
    Friend WithEvents txt_khmakh As System.Windows.Forms.TextBox
    Friend WithEvents lsthd As System.Windows.Forms.ListView
    Friend WithEvents Mahd As System.Windows.Forms.ColumnHeader
    Friend WithEvents khmakh As System.Windows.Forms.ColumnHeader
    Friend WithEvents makh As System.Windows.Forms.ColumnHeader
    Friend WithEvents nvxhd As System.Windows.Forms.ColumnHeader
    Friend WithEvents tenhd As System.Windows.Forms.ColumnHeader
    Friend WithEvents ngayxuat As System.Windows.Forms.ColumnHeader
End Class
