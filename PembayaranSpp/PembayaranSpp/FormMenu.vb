Public Class FormMenu
    'Coding untuk memanggil childform atau menu di panel
    Private currentform As Form = Nothing
    Private Sub openchildform(ByVal childfrom As Form)
        If currentform IsNot Nothing Then currentform.Close()
        currentform = childfrom
        childfrom.TopLevel = False
        childfrom.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        childfrom.Dock = DockStyle.Fill
        PanelData.Controls.Add(childfrom)
        PanelData.Tag = childfrom
        childfrom.BringToFront()
        childfrom.Show()
    End Sub

    Private Sub openchildform2(ByVal childfrom As Form)
        If currentform IsNot Nothing Then currentform.Close()
        currentform = childfrom
        childfrom.TopLevel = False
        childfrom.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        childfrom.Dock = DockStyle.Fill
        PanelTransaksi.Controls.Add(childfrom)
        PanelTransaksi.Tag = childfrom
        childfrom.BringToFront()
        childfrom.Show()
    End Sub

    Private Sub btnData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnData.Click
        lblSelect1.Visible = True
        lblSelect2.Visible = False
        lblSelect3.Visible = False
        lblSelect4.Visible = False
        'tampilkan form
        PanelData.Visible = True
        PanelTransaksi.Visible = False
        PanelLaporan.Visible = False
    End Sub

    Private Sub btnTransaksi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransaksi.Click
        lblSelect1.Visible = False
        lblSelect2.Visible = True
        lblSelect3.Visible = False
        lblSelect4.Visible = False
        'tampilkan form
        PanelData.Visible = False
        PanelTransaksi.Visible = True
        PanelLaporan.Visible = False

    End Sub

    Private Sub btnLaporan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLaporan.Click
        lblSelect1.Visible = False
        lblSelect2.Visible = False
        lblSelect3.Visible = True
        lblSelect4.Visible = False
        'tampilkan form
        PanelData.Visible = False
        PanelTransaksi.Visible = False
        PanelLaporan.Visible = True
    End Sub

    Private Sub btnLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogOut.Click
        lblSelect1.Visible = False
        lblSelect2.Visible = False
        lblSelect3.Visible = False
        lblSelect4.Visible = True
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnSiswa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiswa.Click
        'Dan ini pemanggilanya
        openchildform(FormSiswa)
    End Sub

    Private Sub btnEditSiswa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditSiswa.Click
        openchildform(FormEditSiswa)
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMaximize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMaximize.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnBayar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBayar.Click
        openchildform2(FormSpp)
    End Sub
End Class