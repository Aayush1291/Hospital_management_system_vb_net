Imports System.Data.SqlClient

Public Class DOCTOR
    Dim con As SqlConnection
    Dim query As SqlCommand
    Dim adp As New SqlDataAdapter
    Dim a As New DataSet
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PATIENT.Show()
        Me.Hide()
    End Sub

    Private Sub DOCTOR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PATIENT.Hide()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("YOU ARE NOW IN DOCTOR'S MODULE!!")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        BOOK.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox3.TextLength < 10 Then
            MsgBox("Enter Correct Phone Number")
        ElseIf TextBox1.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox6.text = "" Then
            MsgBox("Enter Value in TextBox")
        Else
            con = New SqlConnection("Data Source=DESKTOP-04T76LJ;Initial Catalog=msdb;Integrated Security=True")
            con.Open()
            query = New SqlCommand("insert into Doctor values('" & TextBox1.Text & "','" & DateTimePicker1.Text & "', '" & ComboBox1.SelectedItem.ToString & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "', '" & ComboBox2.SelectedItem.ToString & "', '" & TextBox6.Text & "',  '" & DateTimePicker2.Text & "')", con)
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

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("Enter letters only")
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("Enter Numbers only")
        End If
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("Enter Numbers only")
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Doctor_View.Show()
        Me.Hide()
    End Sub
End Class