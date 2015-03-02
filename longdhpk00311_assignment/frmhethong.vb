Public Class frmhethong

    Private Sub SanPhamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SanPhamToolStripMenuItem.Click
        frmsanpham.Show()
    End Sub

    Private Sub ThoatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoatToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub LoaiSanPhamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoaiSanPhamToolStripMenuItem.Click
        frmloaisanpham.Show()
    End Sub

    Private Sub KhachHangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KhachHangToolStripMenuItem.Click
        frmkhachhang.Show()
    End Sub

    Private Sub HoaDonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HoaDonToolStripMenuItem.Click
        frmhoadon.Show()
    End Sub

    Private Sub ChiTietHoaDonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChiTietHoaDonToolStripMenuItem.Click
        frmchitiethd.Show()
    End Sub
End Class