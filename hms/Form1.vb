Public Class Form1
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim user As String = "admin"
        Dim pass As String = "admin"
        If (txtUsername.Text = "admin" And txtPass.Text = "admin") Then
            Form2.Show()
            Me.Hide()
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is TextBox Then
                    ctrl.Text = ""
                ElseIf TypeOf ctrl Is ComboBox Then
                    ctrl.Text = ""
                End If
            Next
        Else
            MsgBox("Invalid Username and Password")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Focus()
    End Sub
End Class
