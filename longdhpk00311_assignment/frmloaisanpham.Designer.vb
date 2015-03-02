<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmloaisanpham
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
        Me.lstloaisp = New System.Windows.Forms.ListView()
        Me.maloai = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tenloai = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lbl_tenloai = New System.Windows.Forms.Label()
        Me.lbl_maloai = New System.Windows.Forms.Label()
        Me.bntxoa = New System.Windows.Forms.Button()
        Me.bntthem = New System.Windows.Forms.Button()
        Me.txt_tenloaisp = New System.Windows.Forms.TextBox()
        Me.txt_idloaisp = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstloaisp
        '
        Me.lstloaisp.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.maloai, Me.tenloai})
        Me.lstloaisp.FullRowSelect = True
        Me.lstloaisp.GridLines = True
        Me.lstloaisp.Location = New System.Drawing.Point(372, 53)
        Me.lstloaisp.Name = "lstloaisp"
        Me.lstloaisp.Size = New System.Drawing.Size(255, 138)
        Me.lstloaisp.TabIndex = 45
        Me.lstloaisp.UseCompatibleStateImageBehavior = False
        Me.lstloaisp.View = System.Windows.Forms.View.Details
        '
        'maloai
        '
        Me.maloai.Text = "Mã Loại "
        Me.maloai.Width = 119
        '
        'tenloai
        '
        Me.tenloai.Text = "Tên Loại SP"
        Me.tenloai.Width = 131
        '
        'lbl_tenloai
        '
        Me.lbl_tenloai.AutoSize = True
        Me.lbl_tenloai.Location = New System.Drawing.Point(81, 110)
        Me.lbl_tenloai.Name = "lbl_tenloai"
        Me.lbl_tenloai.Size = New System.Drawing.Size(66, 13)
        Me.lbl_tenloai.TabIndex = 43
        Me.lbl_tenloai.Text = "Tên Loai SP"
        '
        'lbl_maloai
        '
        Me.lbl_maloai.AutoSize = True
        Me.lbl_maloai.Location = New System.Drawing.Point(82, 56)
        Me.lbl_maloai.Name = "lbl_maloai"
        Me.lbl_maloai.Size = New System.Drawing.Size(45, 13)
        Me.lbl_maloai.TabIndex = 44
        Me.lbl_maloai.Text = "Mã Loại"
        '
        'bntxoa
        '
        Me.bntxoa.Location = New System.Drawing.Point(270, 152)
        Me.bntxoa.Name = "bntxoa"
        Me.bntxoa.Size = New System.Drawing.Size(75, 39)
        Me.bntxoa.TabIndex = 39
        Me.bntxoa.Text = "Xóa"
        Me.bntxoa.UseVisualStyleBackColor = True
        '
        'bntthem
        '
        Me.bntthem.Location = New System.Drawing.Point(72, 152)
        Me.bntthem.Name = "bntthem"
        Me.bntthem.Size = New System.Drawing.Size(75, 39)
        Me.bntthem.TabIndex = 41
        Me.bntthem.Text = "Thêm"
        Me.bntthem.UseVisualStyleBackColor = True
        '
        'txt_tenloaisp
        '
        Me.txt_tenloaisp.Location = New System.Drawing.Point(183, 107)
        Me.txt_tenloaisp.Name = "txt_tenloaisp"
        Me.txt_tenloaisp.Size = New System.Drawing.Size(100, 20)
        Me.txt_tenloaisp.TabIndex = 37
        '
        'txt_idloaisp
        '
        Me.txt_idloaisp.Location = New System.Drawing.Point(183, 53)
        Me.txt_idloaisp.Name = "txt_idloaisp"
        Me.txt_idloaisp.Size = New System.Drawing.Size(100, 20)
        Me.txt_idloaisp.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(289, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "LOẠI SẢN PHẨM"
        '
        'frmloaisanpham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 254)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstloaisp)
        Me.Controls.Add(Me.lbl_tenloai)
        Me.Controls.Add(Me.lbl_maloai)
        Me.Controls.Add(Me.bntxoa)
        Me.Controls.Add(Me.bntthem)
        Me.Controls.Add(Me.txt_tenloaisp)
        Me.Controls.Add(Me.txt_idloaisp)
        Me.Name = "frmloaisanpham"
        Me.Text = "frmloaisanpham"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstloaisp As System.Windows.Forms.ListView
    Friend WithEvents maloai As System.Windows.Forms.ColumnHeader
    Friend WithEvents tenloai As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbl_tenloai As System.Windows.Forms.Label
    Friend WithEvents lbl_maloai As System.Windows.Forms.Label
    Friend WithEvents bntxoa As System.Windows.Forms.Button
    Friend WithEvents bntthem As System.Windows.Forms.Button
    Friend WithEvents txt_tenloaisp As System.Windows.Forms.TextBox
    Friend WithEvents txt_idloaisp As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
