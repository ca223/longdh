Imports System.Data
Imports System.Data.SqlClient
Public Class frmkhachhang
    Private ketnoi As DataBaseAccess
    Private kn = "Data Source=.;Initial Catalog=Assignment;Integrated Security=True"
    Private Sub aa()
        ketnoi = New DataBaseAccess(kn)
        Dim a As DataTable
        a = ketnoi.GetDataTable("select * from KhachHang")
        lstkh.Items.Clear()
        Dim b As Integer
        For Each hang As DataRow In a.Rows
            lstkh.Items.Add(hang("MaKH").ToString())
            lstkh.Items(b).SubItems.Add(hang("TenKH").ToString())
            lstkh.Items(b).SubItems.Add(hang("GioiTinh").ToString())
            lstkh.Items(b).SubItems.Add(hang("NamSinh").ToString())
            lstkh.Items(b).SubItems.Add(hang("DiaChi").ToString())
            lstkh.Items(b).SubItems.Add(hang("SDT").ToString())
            b += 1
        Next
        txt_idkh.Text = ""
        txt_tenkh.Text = ""
        txt_gioitinh.Text = ""
        txt_ngaysinh.Text = ""
        txt_diachi.Text = ""
        txt_sdt.Text = ""
    End Sub
    Private Sub frmkhachhang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        aa()
    End Sub

    Private Sub bntxoa_Click(sender As Object, e As EventArgs) Handles bntxoa.Click
        Dim lenh As String
        lenh = "delete KhachHang where MaKH='" + txt_idkh.Text + "'"
        If (ketnoi.ExecuteNoneQuery(lenh, True) = True) Then
            aa()
        End If
    End Sub

    Private Sub lstkh_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstkh.SelectedIndexChanged
        If lstkh.SelectedItems.Count = 1 Then
            For Each lis As ListViewItem In lstkh.SelectedItems
                txt_idkh.Text = lis.SubItems(0).Text
                txt_tenkh.Text = lis.SubItems(1).Text
                txt_gioitinh.Text = lis.SubItems(2).Text
                txt_ngaysinh.Text = lis.SubItems(3).Text
                txt_diachi.Text = lis.SubItems(4).Text
                txt_sdt.Text = lis.SubItems(5).Text

                bntxoa.Enabled = True
                bntsua.Enabled = True
            Next
        End If
    End Sub

    Private Sub bntsua_Click(sender As Object, e As EventArgs) Handles bntsua.Click
        Dim lenh As String
        lenh = "update KhachHang set MaKH='" + txt_idkh.Text + "',TenKH='" + txt_tenkh.Text + "',GioiTinh='" + txt_gioitinh.Text + "',NamSinh='" + txt_ngaysinh.Text + "',DiaChi='" + txt_diachi.Text + "',SDT='" + txt_sdt.Text + "' where MaKH='" + txt_idkh.Text + "'"
        If (ketnoi.ExecuteNoneQuery(lenh, True) = True) Then
            aa()
        End If
    End Sub

    Private Sub bntthem_Click(sender As Object, e As EventArgs) Handles bntthem.Click
        Dim lenh As String
        lenh = "insert KhachHang values ('" + txt_idkh.Text + "',N'" + txt_tenkh.Text + "','" + txt_gioitinh.Text + "','" + txt_ngaysinh.Text + "',N'" + txt_diachi.Text + "','" + txt_sdt.Text + "')"
        If (ketnoi.ExecuteNoneQuery(lenh, True) = True) Then
            aa()
        End If
    End Sub
End Class