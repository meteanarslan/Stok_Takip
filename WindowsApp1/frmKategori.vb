Imports System.Data.SqlClient
Public Class frmKategori
    Dim c As New Crud
    Dim durum As New Boolean
    Private Sub kategoriengelle()
        durum = True
        Dim sConnection As String = "Data Source=.\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True"
        Using Con As New SqlConnection(sConnection)
            Con.Open()
            Using com As New SqlCommand("select * from kategoribilgileri", Con)
                Using rdr = com.ExecuteReader()
                    If rdr.HasRows Then
                        Do While rdr.Read
                            If TextBox1.Text = rdr("kategori").ToString() Or TextBox1.Text = "" Then
                                durum = False
                            End If
                        Loop
                    End If
                End Using
            End Using
            Con.Close()
        End Using
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        kategoriengelle()
        If durum = True Then
            Dim sql As String = "insert into kategoribilgileri(kategori) values('" & TextBox1.Text & "')"
            Dim command As New SqlCommand()
            c.CUD(command, sql)
            TextBox1.Text = ""
            MessageBox.Show("Kategori Eklendi", "Kategori Ekleme İşlemi")
        Else
            MessageBox.Show("Böyle bir kategori var")
        End If

    End Sub


End Class