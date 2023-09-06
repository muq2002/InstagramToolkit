<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
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
        Me.ListUsers = New System.Windows.Forms.ListBox()
        Me.ListPasswords = New System.Windows.Forms.ListBox()
        Me.ListVictim = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CloseBTN = New System.Windows.Forms.Button()
        Me.AddBTN = New System.Windows.Forms.Button()
        Me.RemoveBTN = New System.Windows.Forms.Button()
        Me.StartBTN = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Username = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ListUsers
        '
        Me.ListUsers.FormattingEnabled = True
        Me.ListUsers.Location = New System.Drawing.Point(12, 35)
        Me.ListUsers.Name = "ListUsers"
        Me.ListUsers.Size = New System.Drawing.Size(137, 225)
        Me.ListUsers.TabIndex = 0
        '
        'ListPasswords
        '
        Me.ListPasswords.FormattingEnabled = True
        Me.ListPasswords.Location = New System.Drawing.Point(155, 35)
        Me.ListPasswords.Name = "ListPasswords"
        Me.ListPasswords.Size = New System.Drawing.Size(145, 225)
        Me.ListPasswords.TabIndex = 1
        '
        'ListVictim
        '
        Me.ListVictim.FormattingEnabled = True
        Me.ListVictim.Location = New System.Drawing.Point(306, 35)
        Me.ListVictim.Name = "ListVictim"
        Me.ListVictim.Size = New System.Drawing.Size(145, 225)
        Me.ListVictim.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(351, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "List Of Victim"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(180, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "List Of Passwords"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "List Of Users"
        '
        'CloseBTN
        '
        Me.CloseBTN.Location = New System.Drawing.Point(576, 272)
        Me.CloseBTN.Name = "CloseBTN"
        Me.CloseBTN.Size = New System.Drawing.Size(56, 23)
        Me.CloseBTN.TabIndex = 6
        Me.CloseBTN.Text = "Close"
        Me.CloseBTN.UseVisualStyleBackColor = True
        '
        'AddBTN
        '
        Me.AddBTN.Location = New System.Drawing.Point(590, 152)
        Me.AddBTN.Name = "AddBTN"
        Me.AddBTN.Size = New System.Drawing.Size(42, 23)
        Me.AddBTN.TabIndex = 7
        Me.AddBTN.Text = "Add"
        Me.AddBTN.UseVisualStyleBackColor = True
        '
        'RemoveBTN
        '
        Me.RemoveBTN.Location = New System.Drawing.Point(528, 152)
        Me.RemoveBTN.Name = "RemoveBTN"
        Me.RemoveBTN.Size = New System.Drawing.Size(56, 23)
        Me.RemoveBTN.TabIndex = 8
        Me.RemoveBTN.Text = "Rrmove"
        Me.RemoveBTN.UseVisualStyleBackColor = True
        '
        'StartBTN
        '
        Me.StartBTN.Location = New System.Drawing.Point(519, 272)
        Me.StartBTN.Name = "StartBTN"
        Me.StartBTN.Size = New System.Drawing.Size(51, 23)
        Me.StartBTN.TabIndex = 9
        Me.StartBTN.Text = "Start"
        Me.StartBTN.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(457, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Username:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(459, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Password:"
        '
        'Username
        '
        Me.Username.Location = New System.Drawing.Point(460, 79)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(172, 20)
        Me.Username.TabIndex = 12
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(460, 126)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(172, 20)
        Me.Password.TabIndex = 13
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 298)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.StartBTN)
        Me.Controls.Add(Me.RemoveBTN)
        Me.Controls.Add(Me.AddBTN)
        Me.Controls.Add(Me.CloseBTN)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListVictim)
        Me.Controls.Add(Me.ListPasswords)
        Me.Controls.Add(Me.ListUsers)
        Me.Name = "Report"
        Me.Text = "Report"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListUsers As System.Windows.Forms.ListBox
    Friend WithEvents ListPasswords As System.Windows.Forms.ListBox
    Friend WithEvents ListVictim As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CloseBTN As System.Windows.Forms.Button
    Friend WithEvents AddBTN As System.Windows.Forms.Button
    Friend WithEvents RemoveBTN As System.Windows.Forms.Button
    Friend WithEvents StartBTN As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Username As System.Windows.Forms.TextBox
    Friend WithEvents Password As System.Windows.Forms.TextBox
End Class
