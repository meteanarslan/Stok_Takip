Imports System.Data.SqlClient

Public Class frmMüsteriListele
    Dim c As New Crud
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sql As String = "insert into müsteri(tc,adsoyad,telefon,adres,email) values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "')"
        Dim command As New SqlCommand()
        c.CUD(command, sql)
        listele()
        temizle()
        MessageBox.Show("Kayıt Eklendi", "Kayıt İşlemi")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String = "update müsteri set adsoyad='" & TextBox2.Text & "',telefon='" & TextBox3.Text & "',adres='" & TextBox4.Text & "',email='" & TextBox5.Text & "'where tc='" & TextBox1.Text & "'"
        Dim command As New SqlCommand()
        c.CUD(command, sql)
        listele()
        temizle()
        MessageBox.Show("Güncelleme Yapıldı", "Güncelleme İşlemi")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sql As String = "delete from müsteri where tc='" & DataGridView1.CurrentRow.Cells(0).Value & "' "
        Dim command As New SqlCommand()
        c.CUD(command, sql)
        listele()
        temizle()
    End Sub
    Sub listele()
        DataGridView1.DataSource = c.list("select * from müsteri")
    End Sub
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value
        TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value
        TextBox3.Text = DataGridView1.CurrentRow.Cells(2).Value
        TextBox4.Text = DataGridView1.CurrentRow.Cells(3).Value
        TextBox5.Text = DataGridView1.CurrentRow.Cells(4).Value
    End Sub
    Private Sub frmMüsteriListele_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listele()
    End Sub
    Sub temizle()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        DataGridView1.DataSource = c.list("select * from müsteri where tc like'" & TextBox6.Text & "%'")
    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    '    Dim baglanti As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True")
    '    baglanti.Open()
    '    Dim komut As New SqlCommand("update müsteri set adsoyad'" + TextBox2.Text + "',telefon'" + TextBox3.Text + "',adres'" + TextBox4.Text + "',email'" + TextBox5.Text + "',where tc='" + TextBox1.Text + "'", baglanti)
    '    komut.ExecuteNonQueryAsync()
    '    baglanti.Close()
    '    MessageBox.Show("Kayıt Eklendi", "Kayıt İşlemi")
    '    temizle()
    '    tablo.Clear()
    '    listele()
    'End Sub
    'Private Sub listele()

    '    Dim baglanti As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True")
    '    baglanti.Open()
    '    Dim adtr As New SqlDataAdapter("select * from müsteri", baglanti)
    '    adtr.Fill(tablo)
    '    DataGridView1.DataSource = tablo
    '    baglanti.Close()
    'End Sub
    'Private Sub frmMüsteriListele_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Dim baglanti As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True")
    '    baglanti.Open()
    '    listele()
    'End Sub


    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    '    Dim baglanti As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True")
    '    baglanti.Open()
    '    Dim komut As New SqlCommand("delete * from müsteri where tc='" + DataGridView1.CurrentRow.Cells("tc").Value.ToString() + "'", baglanti)
    '    komut.ExecuteNonQueryAsync()
    '    baglanti.Close()
    '    tablo.Clear()
    '    listele()
    'End Sub 

End Class