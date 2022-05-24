Imports System.Data.SqlClient

Public Class Crud
    Dim v As New veritabanı
    Public Function CUD(command As SqlCommand, sql As String) As Boolean

        v.baglanti.Open()
        command.CommandText = sql
        command.Connection = v.baglanti
        command.ExecuteNonQuery()
        Try
            Return True

        Catch ex As Exception
            Return False
        Finally
            v.baglanti.Close()
        End Try

    End Function
    Public Function list(sql As String) As DataTable
        Dim tbl As New DataTable
        Dim adtr As New SqlDataAdapter(sql, v.baglanti)
        adtr.Fill(tbl)
        Return tbl
    End Function

End Class
