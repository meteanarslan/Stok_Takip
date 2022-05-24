Imports System.Data.SqlClient

Public Class frmÜrünEkle
    Dim c As New Crud


    Sub temizlegb1()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
    End Sub
    Sub temizle()
        'TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
    End Sub
    Sub temizle2()
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
    End Sub

    Private Sub frmÜrünEkle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sConnection As String = "Data Source=.\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True"
        Using Cons As New SqlConnection(sConnection)
            Cons.Open()
            Using com As New SqlCommand("select * from kategoribilgileri", Cons)
                Using rdr = com.ExecuteReader()
                    If rdr.HasRows Then
                        Do While rdr.Read
                            ComboBox1.Items.Add(rdr.Item("kategori").ToString())
                        Loop
                    End If
                End Using
            End Using
            Cons.Close()
        End Using
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox2.Items.Clear()
        ComboBox2.Text = ""
        Dim sConnection As String = "Data Source=.\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True"
        Using Con As New SqlConnection(sConnection)
            Con.Open()
            Using com As New SqlCommand("select * from markabilgileri where kategori ='" & ComboBox1.SelectedItem & "'", Con)
                Using rdr = com.ExecuteReader()
                    If rdr.HasRows Then
                        Do While rdr.Read
                            ComboBox2.Items.Add(rdr.Item("marka").ToString())
                        Loop
                    End If
                End Using
            End Using
            Con.Close()
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String = "insert into urun(barkodno,kategori,marka,urunadi,miktari,alisfiyati,satisfiyati,tarih) values('" & TextBox1.Text & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & TextBox2.Text & "',@miktari,@alisfiyati,@satisfiyati,@tarih)"
        Dim command As New SqlCommand()
        command.Parameters.Add("@miktari", SqlDbType.Int).Value = Integer.Parse(TextBox3.Text)
        command.Parameters.Add("@alisfiyati", SqlDbType.Decimal).Value = Decimal.Parse(TextBox4.Text)
        command.Parameters.Add("@satisfiyati", SqlDbType.Decimal).Value = Decimal.Parse(TextBox5.Text)
        command.Parameters.Add("@tarih", SqlDbType.NVarChar).Value = DateTime.Now.ToString()
        c.CUD(command, sql)
        MessageBox.Show("Ürün Başarıyla Eklendi", "Ürün Ekleme İşlemi")
        ComboBox2.Items.Clear()
        temizlegb1()
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        temizle()
        Label15.Text = ""
        Dim sConnection As String = "Data Source=.\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True"
        Using Con As New SqlConnection(sConnection)
            Con.Open()
            Using com As New SqlCommand("select * from urun where barkodno like '" & TextBox6.Text & "'", Con)
                Using rdr = com.ExecuteReader()
                    If rdr.HasRows Then
                        Do While rdr.Read
                            TextBox7.Text = (rdr("kategori").ToString())
                            TextBox8.Text = (rdr("marka").ToString())
                            TextBox9.Text = (rdr("urunadi").ToString())
                            Label15.Text = (rdr("miktari").ToString())
                            TextBox11.Text = (rdr("alisfiyati").ToString())
                            TextBox12.Text = (rdr("satisfiyati").ToString())
                        Loop
                    End If
                End Using
            End Using
            Con.Close()
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sql As String = "update urun set miktari=miktari+'" & Integer.Parse(TextBox10.Text) & "'where barkodno='" & TextBox6.Text & "'"
        Dim command As New SqlCommand()
        c.CUD(command, sql)
        MessageBox.Show("Var Olan Ürüne Başarıyla Ekleme Yapıldı", "Var Olan Ürüne Ekleme İşlemi")
        temizle2()
    End Sub
End Class