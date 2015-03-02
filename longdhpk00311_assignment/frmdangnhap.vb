Public Class frmdangnhap

    Private Sub btnDN_Click(sender As Object, e As EventArgs) Handles btnDN.Click
        If txtMK.Text = "123456" And txtTDN.Text = "admin" Then
            frmhethong.Show()
            MessageBox.Show("Đăng nhập thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Me.Hide()
        Else
            MessageBox.Show("Nhập sai tên đăng nhập hoặc mật khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        End If
    End Sub

End Class
