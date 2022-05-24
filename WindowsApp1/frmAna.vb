Imports System.Data.SqlClient
Public Class frmAna
    Dim c As New Crud
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        frmMüsteriListele.ShowDialog()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        frmÜrünEkle.ShowDialog()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        frmÜrünListele.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmSatiss.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmKategori.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        frmMarka.ShowDialog()
    End Sub


End Class
