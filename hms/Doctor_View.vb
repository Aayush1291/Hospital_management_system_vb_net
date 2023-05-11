Imports System.Data.SqlClient
Public Class Doctor_View
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DOCTOR.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connection As SqlConnection = New SqlConnection("Data Source=DESKTOP-04T76LJ;Initial Catalog=msdb;Integrated Security=True")
        connection.Open()
        Dim adp As SqlDataAdapter = New SqlDataAdapter("select * from Doctor", connection)
        Dim ds As DataSet = New DataSet()
        adp.Fill(ds, " Doctor")
        DataGridView1.DataSource = ds.Tables(0)
    End Sub
End Class