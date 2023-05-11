Imports System.Data.SqlClient

Public Class BOOK
    Dim con As SqlConnection
    Dim query As SqlCommand
    Dim adp As New SqlDataAdapter
    Dim a As New DataSet

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PATIENT.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DOCTOR.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("YOU ARE NOW ON APPOINTMENT BOOKING MODULE!!")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox5.TextLength < 10 Then
            MsgBox("Enter Correct Phone Number")
        ElseIf TextBox1.Text = "" Or TextBox4.Text = "" Or TextBox5.text = "" Then
            MsgBox("Enter Value in TextBox")
        Else
            con = New SqlConnection("Data Source=DESKTOP-04T76LJ;Initial Catalog=msdb;Integrated Security=True")
            con.Open()
            query = New SqlCommand("insert into Book values('" & TextBox1.Text & "', '" & ComboBox1.SelectedItem.ToString & "',  '" & ComboBox2.SelectedItem.ToString & "', '" & DateTimePicker1.Text & "', '" & TextBox4.Text & "',  '" & TextBox5.Text & "')", con)
            query.ExecuteNonQuery()
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is TextBox Then
                    ctrl.Text = ""
                ElseIf TypeOf ctrl Is ComboBox Then
                    ctrl.Text = ""
                End If
            Next
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Book_View.Show()
        Me.Hide()
    End Sub

    Private Sub BOOK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            ElseIf TypeOf ctrl Is ComboBox Then
                ctrl.Text = ""
            End If
        Next
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("Enter letters only")
        End If
    End Sub
    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("Enter letters only")
        End If
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("Enter numbers only")
        End If
    End Sub

End Class