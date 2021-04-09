Public Class FormSpp

    Sub matikan()
        txtNisn.Enabled = False
        txtNama.Enabled = False
        txtTanggal.Enabled = False
        txtTunggakan.Enabled = False
        txtNominal.Enabled = False
    End Sub

    Sub hidupkan()
        txtNisn.Enabled = True
        txtNama.Enabled = True
        txtTanggal.Enabled = True
        txtTunggakan.Enabled = True
        txtNominal.Enabled = True
    End Sub

    Sub kosongkan()
        txtNisn.Text = ""
        txtNama.Text = ""
        txtTanggal.Text = ""
        txtTunggakan.Text = ""
        txtNominal.Text = ""
    End Sub

    Sub dataspp()
        Call koneksiDB()
        da = New OleDb.OleDbDataAdapter("select * from spp", conn)
        ds = New DataSet
        da.Fill(ds)
        dgvSpp.DataSource = ds.Tables(0)
        dgvSpp.ReadOnly = True
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub FormSpp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Call koneksiDB()
        Call dataspp()
        Call matikan()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        txtTanggal.Text = Format(Now, "dd/MM/yyyy")
    End Sub
End Class