Imports System.Data
Imports System.Data.SqlClient
Public Class frmloaisanpham
    Private ketnoi As DataBaseAccess
    Private kn = "Data Source=.;Initial Catalog=Assignment;Integrated Security=True"
    Private Sub aa()
        ketnoi = New DataBaseAccess(kn)
        Dim a As DataTable
        a = ketnoi.GetDataTable("select * from LoaiSanPham")
        lstloaisp.Items.Clear()
        Dim b As Integer
        For Each hang As DataRow In a.Rows
            lstloaisp.Items.Add(hang("MaLoai").ToString())
            lstloaisp.Items(b).SubItems.Add(hang("TenLoai").ToString())

            b += 1
        Next
        txt_idloaisp.Text = ""
        txt_tenloaisp.Text = ""

    End Sub

    Private Sub frmloaisanpham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        aa()
    End Sub

    Private Sub bntthem_Click(sender As Object, e As EventArgs) Handles bntthem.Click
        Dim lenh As String
        lenh = "insert LoaiSanPham values ('" + txt_idloaisp.Text + "',N'" + txt_tenloaisp.Text + "')"
        If (ketnoi.ExecuteNoneQuery(lenh, True) = True) Then
            aa()
        End If
    End Sub

    Private Sub bntxoa_Click(sender As Object, e As EventArgs) Handles bntxoa.Click
        Dim lenh As String
        lenh = "delete LoaiSanPham where MaLoai='" + txt_idloaisp.Text + "'"
        If (ketnoi.ExecuteNoneQuery(lenh, True) = True) Then
            aa()
        End If
    End Sub

    Private Sub lstloaisp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstloaisp.SelectedIndexChanged
        If lstloaisp.SelectedItems.Count = 1 Then
            For Each lis As ListViewItem In lstloaisp.SelectedItems
                txt_idloaisp.Text = lis.SubItems(0).Text
                txt_tenloaisp.Text = lis.SubItems(1).Text

                bntxoa.Enabled = True
            Next
        End If
    End Sub
End Class
