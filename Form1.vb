Public Class Form1
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        txtNama.Text = Text()
        txtNPM.Text = Text()
        txtSemester.Text = Text()
        txtTugas.Text = Text()
        txtUTS.Text = Text()
        txtUAS.Text = Text()
        txtTotal.Text = Text()
        txtIPS.Text = Text()
        txtIPK.Text = Text()
    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click

        Dim Nama = txtNama.Text()
        Dim NPM = txtNPM.Text()
        Dim Semester = txtSemester.Text()
        Dim Tugas = txtTugas.Text()
        Dim UTS = txtUTS.Text()
        Dim UAS = txtUAS.Text()
        Dim IPS = txtIPS.Text()
        Dim IPK = txtIPK.Text()
        Dim Totalnilai = txtTotal.Text()
        txtTotal.Text = txtTugas.Text * 20 / 100 + txtUTS.Text * 30 / 100 + txtUAS.Text * 50 / 100
        txtIPS.Text = txtTotal.Text * 4 / 100
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class
