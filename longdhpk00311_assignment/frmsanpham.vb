Imports System.Data
Imports System.Data.SqlClient
Public Class frmsanpham
    Private ketnoi As DataBaseAccess
    Private kn = "Data Source=.;Initial Catalog=Assignment;Integrated Security=True"
    Private Sub aa()
        ketnoi = New DataBaseAccess(kn)
        Dim a As DataTable
        a = ketnoi.GetDataTable("select * from SanPham")
        lstsp.Items.Clear()
        Dim b As Integer
        For Each hang As DataRow In a.Rows
            lstsp.Items.Add(hang("MaSP").ToString())
            lstsp.Items(b).SubItems.Add(hang("LSP_MaLoai").ToString())
            lstsp.Items(b).SubItems.Add(hang("MaLoai").ToString())
            lstsp.Items(b).SubItems.Add(hang("TenSP").ToString())
            lstsp.Items(b).SubItems.Add(hang("Gia").ToString())
            lstsp.Items(b).SubItems.Add(hang("MoTa").ToString())
            lstsp.Items(b).SubItems.Add(hang("NhaSanXuat").ToString())
            b += 1
        Next
        txtmasp.Text = ""
        txtLSPMALOAI.Text = ""
        txtmaloai.Text = ""
        txttensp.Text = ""
        txtgia.Text = ""
        txtmota.Text = ""
        txtnhasx.Text = ""
    End Sub
    Private Sub frmsanpham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        aa()
    End Sub
    Private Sub lstsp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstsp.SelectedIndexChanged
        If lstsp.SelectedItems.Count = 1 Then
            For Each lis As ListViewItem In lstsp.SelectedItems
                txtmasp.Text = lis.SubItems(0).Text
                txtLSPMALOAI.Text = lis.SubItems(1).Text
                txtmaloai.Text = lis.SubItems(2).Text
                txttensp.Text = lis.SubItems(3).Text
                txtgia.Text = lis.SubItems(4).Text
                txtmota.Text = lis.SubItems(5).Text
                txtnhasx.Text = lis.SubItems(6).Text

                bntxoa.Enabled = True
                bntsua.Enabled = True
            Next
        End If
    End Sub
    Private Sub bntsua_Click(sender As Object, e As EventArgs) Handles bntsua.Click
        Dim lenh As String
        lenh = "update SanPham set MaSP='" + txtmasp.Text + "',LSP_MaLoai='" + txtLSPMALOAI.Text + "',MaLoai='" + txtmaloai.Text + "',TenSP=N'" + txttensp.Text + "',Gia=" + txtgia.Text + ",MoTa=N'" + txtmota.Text + "' where MaSP='" + txtmasp.Text + "'"
        If (ketnoi.ExecuteNoneQuery(lenh, True) = True) Then
            aa()
        End If
    End Sub
    Private Sub bntthem_Click(sender As Object, e As EventArgs) Handles bntthem.Click
        Dim lenh As String
        lenh = "insert SanPham values ('" + txtmasp.Text + "','" + txtLSPMALOAI.Text + "','" + txtmaloai.Text + "',N'" + txttensp.Text + "'," + txtgia.Text + ",N'" + txtmota.Text + "','" + txtnhasx.Text + "')"
        If (ketnoi.ExecuteNoneQuery(lenh, True) = True) Then
            aa()
        End If
    End Sub

    Private Sub bntxoa_Click(sender As Object, e As EventArgs) Handles bntxoa.Click
        Dim lenh As String
        lenh = "delete SanPham where MaSP='" + txtmasp.Text + "'"
        If (ketnoi.ExecuteNoneQuery(lenh, True) = True) Then
            aa()
        End If
    End Sub
End Class