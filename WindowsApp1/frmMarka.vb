Imports System.Data.SqlClient
Public Class frmMarka
    Dim c As New Crud
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String = "insert into markabilgileri(kategori,marka) values('" & ComboBox1.Text & "','" & TextBox1.Text & "')"
        Dim command As New SqlCommand()
        c.CUD(command, sql)
        TextBox1.Text = ""
        ComboBox1.Text = ""
        MessageBox.Show("Marka Eklendi", "Marka Ekleme İşlemi")
    End Sub

    Private Sub frmMarka_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sConnection As String = "Data Source=.\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True"
        Using Con As New SqlConnection(sConnection)
            Con.Open()
            Using com As New SqlCommand("select * from kategoribilgileri", Con)
                Using rdr = com.ExecuteReader()
                    If rdr.HasRows Then
                        Do While rdr.Read
                            ComboBox1.Items.Add(rdr.Item("kategori").ToString())
                        Loop
                    End If
                End Using
            End Using
            Con.Close()
        End Using
    End Sub
End Class