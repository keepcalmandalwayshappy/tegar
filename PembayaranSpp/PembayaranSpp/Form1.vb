Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksiDB()
        da = New OleDb.OleDbDataAdapter("select*from Login", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Login")
        da.Dispose()
        ds.Dispose()
        conn.Close()
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Call koneksiDB()
        Dim dr As OleDb.OleDbDataReader
        Dim cmd As OleDb.OleDbCommand
        Dim sql As String

        cmd = New OleDb.OleDbCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn

        If txtUsername.Text = "" And txtPassword.Text = "" Then
            MsgBox("Username atau password tidak boleh salah!")
            txtUsername.Focus()
            Exit Sub

        Else
            sql = "select * from Login where username='" & txtUsername.Text & "'and password='" & txtPassword.Text & "'"
            cmd.CommandText = sql
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                MsgBox("Login Sukses")
                Me.Visible = False
                FormMenu.Show()
            Else
                MsgBox("Username atau password salah")
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtUsername_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsername.KeyPress
        If (e.KeyChar = Chr(13)) Then
            txtPassword.Focus()
        End If
    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If (e.KeyChar = Chr(13)) Then
            btnLogin.Focus()
        End If
    End Sub
End Class
