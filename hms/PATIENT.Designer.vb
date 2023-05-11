<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PATIENT
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Label9 = New Label()
        Label8 = New Label()
        Panel2 = New Panel()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox4 = New TextBox()
        TextBox6 = New TextBox()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        Button5 = New Button()
        Button6 = New Button()
        DateTimePicker1 = New DateTimePicker()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label8)
        Panel1.Location = New Point(-1, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(802, 75)
        Panel1.TabIndex = 0
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.ForeColor = Color.White
        Label9.Location = New Point(171, 9)
        Label9.Name = "Label9"
        Label9.Size = New Size(323, 50)
        Label9.TabIndex = 9
        Label9.Text = "PATIENT MODULE"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(0, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(41, 15)
        Label8.TabIndex = 0
        Label8.Text = "Label8"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Panel2.Controls.Add(Button4)
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button1)
        Panel2.Location = New Point(-1, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(165, 456)
        Panel2.TabIndex = 1
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Button4.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.Location = New Point(23, 329)
        Button4.Name = "Button4"
        Button4.Size = New Size(119, 61)
        Button4.TabIndex = 4
        Button4.Text = "LOGOUT"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Button3.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(23, 247)
        Button3.Name = "Button3"
        Button3.Size = New Size(119, 54)
        Button3.TabIndex = 3
        Button3.Text = "BOOK APPOINTMENT"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Button2.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(23, 165)
        Button2.Name = "Button2"
        Button2.Size = New Size(119, 54)
        Button2.TabIndex = 2
        Button2.Text = "DOCTOR"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DodgerBlue
        Button1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(23, 92)
        Button1.Name = "Button1"
        Button1.Size = New Size(119, 54)
        Button1.TabIndex = 1
        Button1.Text = "PATIENT"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(237, 109)
        Label1.Name = "Label1"
        Label1.Size = New Size(24, 20)
        Label1.TabIndex = 2
        Label1.Text = "ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(237, 142)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 20)
        Label2.TabIndex = 3
        Label2.Text = "NAME"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(237, 176)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 20)
        Label3.TabIndex = 4
        Label3.Text = "GENDER"
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(237, 209)
        Label4.Name = "Label4"
        Label4.Size = New Size(40, 20)
        Label4.TabIndex = 5
        Label4.Text = "DOB"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(237, 242)
        Label5.Name = "Label5"
        Label5.Size = New Size(125, 20)
        Label5.TabIndex = 6
        Label5.Text = "MOBILE NUMBER"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(237, 276)
        Label6.Name = "Label6"
        Label6.Size = New Size(109, 20)
        Label6.TabIndex = 7
        Label6.Text = "BLOOD GROUP"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(237, 309)
        Label7.Name = "Label7"
        Label7.Size = New Size(101, 20)
        Label7.TabIndex = 8
        Label7.Text = "BED NUMBER"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(393, 102)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(177, 27)
        TextBox1.TabIndex = 9
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.Location = New Point(393, 135)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(177, 27)
        TextBox2.TabIndex = 10
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox4.Location = New Point(393, 235)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(177, 27)
        TextBox4.TabIndex = 12
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox6.Location = New Point(393, 302)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(177, 27)
        TextBox6.TabIndex = 14
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"MALE", "FEMALE"})
        ComboBox1.Location = New Point(393, 168)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(177, 28)
        ComboBox1.TabIndex = 15
        ' 
        ' ComboBox2
        ' 
        ComboBox2.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-"})
        ComboBox2.Location = New Point(393, 268)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(177, 28)
        ComboBox2.TabIndex = 16
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button5.Location = New Point(237, 365)
        Button5.Name = "Button5"
        Button5.Size = New Size(100, 27)
        Button5.TabIndex = 17
        Button5.Text = "Save"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button6.Location = New Point(393, 365)
        Button6.Name = "Button6"
        Button6.Size = New Size(100, 27)
        Button6.TabIndex = 18
        Button6.Text = "View"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CustomFormat = "yyyy/MM/dd"
        DateTimePicker1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.Location = New Point(393, 202)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(177, 27)
        DateTimePicker1.TabIndex = 19
        ' 
        ' PATIENT
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DateTimePicker1)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox6)
        Controls.Add(TextBox4)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "PATIENT"
        Text = "PATIENT"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
