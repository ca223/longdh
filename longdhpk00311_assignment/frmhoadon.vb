Imports System.Data
Imports System.Data.SqlClient
Public Class frmhoadon
    Private ketnoi As DataBaseAccess
    Private kn = "Data Source=.;Initial Catalog=Assignment;Integrated Security=True"
    Private Sub aa()
        ketnoi = New DataBaseAccess(kn)
        Dim a As DataTable
        a = ketnoi.GetDataTable("select * from HoaDon")
        lsthd.Items.Clear()
        Dim b As Integer
        For Each hang As DataRow In a.Rows
            lsthd.Items.Add(hang("MaHD").ToString())
            lsthd.Items(b).SubItems.Add(hang("KH_MaKH").ToString())
            lsthd.Items(b).SubItems.Add(hang("MaKH").ToString())
            lsthd.Items(b).SubItems.Add(hang("NhanVienXuatHD").ToString())
            lsthd.Items(b).SubItems.Add(hang("TenHD").ToString())
            lsthd.Items(b).SubItems.Add(hang("NgayXuat").ToString())
            b += 1
        Next
        txt_idhd.Text = ""
        txt_khmakh.Text = ""
        txt_idkh.Text = ""
        txt_nvXUATHD.Text = ""
        txt_Tenhd.Text = ""
        txt_ngayxuat.Text = ""
    End Sub

    Private Sub frmhoadon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        aa()
    End Sub

    Private Sub bntthem_Click(sender As Object, e As EventArgs) Handles bntthem.Click
        Dim lenh As String
        lenh = "insert HoaDon values ('" + txt_idhd.Text + "','" + txt_khmakh.Text + "','" + txt_idkh.Text + "','" + txt_nvXUATHD.Text + "','" + txt_Tenhd.Text + "','" + txt_ngayxuat.Text + "')"
        If (ketnoi.ExecuteNoneQuery(lenh, True) = True) Then
            aa()
        End If
    End Sub

    Private Sub bntsua_Click(sender As Object, e As EventArgs) Handles bntsua.Click
        Dim lenh As String
        lenh = "update HoaDon set MaHD='" + txt_idhd.Text + "',KH_MaKH='" + txt_khmakh.Text + "',MaKH='" + txt_idkh.Text + "',NhanVienXuatHD='" + txt_nvXUATHD.Text + "',TenHD='" + txt_Tenhd.Text + "',NgayXuat='" + txt_ngayxuat.Text + "' where MaHD='" + txt_idhd.Text + "'"
        If (ketnoi.ExecuteNoneQuery(lenh, True) = True) Then
            aa()
        End If
    End Sub

    Private Sub bntxoa_Click(sender As Object, e As EventArgs) Handles bntxoa.Click
        Dim lenh As String
        lenh = "delete HoaDon where MaHD='" + txt_idhd.Text + "'"
        If (ketnoi.ExecuteNoneQuery(lenh, True) = True) Then
            aa()
        End If
    End Sub

    Private Sub lsthd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsthd.SelectedIndexChanged
        If lsthd.SelectedItems.Count = 1 Then
            For Each lis As ListViewItem In lsthd.SelectedItems
                txt_idhd.Text = lis.SubItems(0).Text
                txt_khmakh.Text = lis.SubItems(1).Text
                txt_idkh.Text = lis.SubItems(2).Text
                txt_nvXUATHD.Text = lis.SubItems(3).Text
                txt_Tenhd.Text = lis.SubItems(4).Text
                txt_ngayxuat.Text = lis.SubItems(5).Text

                bntxoa.Enabled = True
                bntsua.Enabled = True
            Next
        End If
    End Sub
End Class