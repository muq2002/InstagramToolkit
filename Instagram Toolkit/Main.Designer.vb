<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.Info = New System.Windows.Forms.GroupBox()
        Me.AddBTN = New System.Windows.Forms.Button()
        Me.LoadBTN = New System.Windows.Forms.Button()
        Me.SelectionLab = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListWork = New System.Windows.Forms.ListBox()
        Me.CloseBTN = New System.Windows.Forms.Button()
        Me.PassView = New System.Windows.Forms.Button()
        Me.SignInBTN = New System.Windows.Forms.Button()
        Me.SignOutBTN = New System.Windows.Forms.Button()
        Me.AboutBTN = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Username = New System.Windows.Forms.TextBox()
        Me.Tools = New System.Windows.Forms.GroupBox()
        Me.UnReportBTN = New System.Windows.Forms.Button()
        Me.CommentsBTN = New System.Windows.Forms.Button()
        Me.LikeBTN = New System.Windows.Forms.Button()
        Me.ReportBTN = New System.Windows.Forms.Button()
        Me.UnblockBTN = New System.Windows.Forms.Button()
        Me.BlockBTN = New System.Windows.Forms.Button()
        Me.FollowBTN = New System.Windows.Forms.Button()
        Me.UnfollowBNT = New System.Windows.Forms.Button()
        Me.ListConsole = New System.Windows.Forms.ListBox()
        Me.ig = New System.Windows.Forms.WebBrowser()
        Me.Setting = New System.Windows.Forms.Button()
        Me.Info.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Tools.SuspendLayout()
        Me.SuspendLayout()
        '
        'Info
        '
        Me.Info.Controls.Add(Me.AddBTN)
        Me.Info.Controls.Add(Me.LoadBTN)
        Me.Info.Controls.Add(Me.SelectionLab)
        Me.Info.Controls.Add(Me.Label1)
        Me.Info.Controls.Add(Me.ListWork)
        Me.Info.Location = New System.Drawing.Point(1, 2)
        Me.Info.Name = "Info"
        Me.Info.Size = New System.Drawing.Size(233, 407)
        Me.Info.TabIndex = 0
        Me.Info.TabStop = False
        Me.Info.Text = "Info: Account"
        '
        'AddBTN
        '
        Me.AddBTN.Location = New System.Drawing.Point(118, 379)
        Me.AddBTN.Name = "AddBTN"
        Me.AddBTN.Size = New System.Drawing.Size(51, 23)
        Me.AddBTN.TabIndex = 18
        Me.AddBTN.Text = "Add"
        Me.AddBTN.UseVisualStyleBackColor = True
        '
        'LoadBTN
        '
        Me.LoadBTN.Location = New System.Drawing.Point(175, 378)
        Me.LoadBTN.Name = "LoadBTN"
        Me.LoadBTN.Size = New System.Drawing.Size(51, 23)
        Me.LoadBTN.TabIndex = 17
        Me.LoadBTN.Text = "Load"
        Me.LoadBTN.UseVisualStyleBackColor = True
        '
        'SelectionLab
        '
        Me.SelectionLab.AutoSize = True
        Me.SelectionLab.Location = New System.Drawing.Point(6, 389)
        Me.SelectionLab.Name = "SelectionLab"
        Me.SelectionLab.Size = New System.Drawing.Size(99, 13)
        Me.SelectionLab.TabIndex = 2
        Me.SelectionLab.Text = "Selected: 0 From: 0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "List Work"
        '
        'ListWork
        '
        Me.ListWork.FormattingEnabled = True
        Me.ListWork.Location = New System.Drawing.Point(6, 34)
        Me.ListWork.Name = "ListWork"
        Me.ListWork.Size = New System.Drawing.Size(220, 342)
        Me.ListWork.TabIndex = 0
        '
        'CloseBTN
        '
        Me.CloseBTN.Location = New System.Drawing.Point(418, 381)
        Me.CloseBTN.Name = "CloseBTN"
        Me.CloseBTN.Size = New System.Drawing.Size(75, 23)
        Me.CloseBTN.TabIndex = 1
        Me.CloseBTN.Text = "Close"
        Me.CloseBTN.UseVisualStyleBackColor = True
        '
        'PassView
        '
        Me.PassView.Location = New System.Drawing.Point(216, 48)
        Me.PassView.Name = "PassView"
        Me.PassView.Size = New System.Drawing.Size(27, 20)
        Me.PassView.TabIndex = 3
        Me.PassView.Text = "<>"
        Me.PassView.UseVisualStyleBackColor = True
        '
        'SignInBTN
        '
        Me.SignInBTN.Location = New System.Drawing.Point(140, 78)
        Me.SignInBTN.Name = "SignInBTN"
        Me.SignInBTN.Size = New System.Drawing.Size(47, 23)
        Me.SignInBTN.TabIndex = 4
        Me.SignInBTN.Text = "SignIn"
        Me.SignInBTN.UseVisualStyleBackColor = True
        '
        'SignOutBTN
        '
        Me.SignOutBTN.Location = New System.Drawing.Point(193, 78)
        Me.SignOutBTN.Name = "SignOutBTN"
        Me.SignOutBTN.Size = New System.Drawing.Size(53, 23)
        Me.SignOutBTN.TabIndex = 5
        Me.SignOutBTN.Text = "SignOut"
        Me.SignOutBTN.UseVisualStyleBackColor = True
        '
        'AboutBTN
        '
        Me.AboutBTN.Location = New System.Drawing.Point(337, 381)
        Me.AboutBTN.Name = "AboutBTN"
        Me.AboutBTN.Size = New System.Drawing.Size(75, 23)
        Me.AboutBTN.TabIndex = 6
        Me.AboutBTN.Text = "About"
        Me.AboutBTN.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Password)
        Me.GroupBox1.Controls.Add(Me.Username)
        Me.GroupBox1.Controls.Add(Me.SignOutBTN)
        Me.GroupBox1.Controls.Add(Me.PassView)
        Me.GroupBox1.Controls.Add(Me.SignInBTN)
        Me.GroupBox1.Location = New System.Drawing.Point(241, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(252, 107)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Login And Logout"
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(6, 48)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.Size = New System.Drawing.Size(207, 20)
        Me.Password.TabIndex = 8
        '
        'Username
        '
        Me.Username.Location = New System.Drawing.Point(6, 22)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(240, 20)
        Me.Username.TabIndex = 9
        '
        'Tools
        '
        Me.Tools.Controls.Add(Me.UnReportBTN)
        Me.Tools.Controls.Add(Me.CommentsBTN)
        Me.Tools.Controls.Add(Me.LikeBTN)
        Me.Tools.Controls.Add(Me.ReportBTN)
        Me.Tools.Controls.Add(Me.UnblockBTN)
        Me.Tools.Controls.Add(Me.BlockBTN)
        Me.Tools.Controls.Add(Me.FollowBTN)
        Me.Tools.Controls.Add(Me.UnfollowBNT)
        Me.Tools.Location = New System.Drawing.Point(241, 109)
        Me.Tools.Name = "Tools"
        Me.Tools.Size = New System.Drawing.Size(252, 115)
        Me.Tools.TabIndex = 8
        Me.Tools.TabStop = False
        Me.Tools.Text = "Tools"
        '
        'UnReportBTN
        '
        Me.UnReportBTN.Location = New System.Drawing.Point(162, 48)
        Me.UnReportBTN.Name = "UnReportBTN"
        Me.UnReportBTN.Size = New System.Drawing.Size(75, 23)
        Me.UnReportBTN.TabIndex = 16
        Me.UnReportBTN.Text = "UnReport"
        Me.UnReportBTN.UseVisualStyleBackColor = True
        '
        'CommentsBTN
        '
        Me.CommentsBTN.Location = New System.Drawing.Point(0, 77)
        Me.CommentsBTN.Name = "CommentsBTN"
        Me.CommentsBTN.Size = New System.Drawing.Size(75, 23)
        Me.CommentsBTN.TabIndex = 15
        Me.CommentsBTN.Text = "Comments"
        Me.CommentsBTN.UseVisualStyleBackColor = True
        '
        'LikeBTN
        '
        Me.LikeBTN.Location = New System.Drawing.Point(81, 77)
        Me.LikeBTN.Name = "LikeBTN"
        Me.LikeBTN.Size = New System.Drawing.Size(75, 23)
        Me.LikeBTN.TabIndex = 13
        Me.LikeBTN.Text = "Likes"
        Me.LikeBTN.UseVisualStyleBackColor = True
        '
        'ReportBTN
        '
        Me.ReportBTN.Location = New System.Drawing.Point(162, 19)
        Me.ReportBTN.Name = "ReportBTN"
        Me.ReportBTN.Size = New System.Drawing.Size(75, 23)
        Me.ReportBTN.TabIndex = 14
        Me.ReportBTN.Text = "Report"
        Me.ReportBTN.UseVisualStyleBackColor = True
        '
        'UnblockBTN
        '
        Me.UnblockBTN.Location = New System.Drawing.Point(81, 48)
        Me.UnblockBTN.Name = "UnblockBTN"
        Me.UnblockBTN.Size = New System.Drawing.Size(75, 23)
        Me.UnblockBTN.TabIndex = 9
        Me.UnblockBTN.Text = "UnBlock"
        Me.UnblockBTN.UseVisualStyleBackColor = True
        '
        'BlockBTN
        '
        Me.BlockBTN.Location = New System.Drawing.Point(81, 19)
        Me.BlockBTN.Name = "BlockBTN"
        Me.BlockBTN.Size = New System.Drawing.Size(75, 23)
        Me.BlockBTN.TabIndex = 12
        Me.BlockBTN.Text = "Block"
        Me.BlockBTN.UseVisualStyleBackColor = True
        '
        'FollowBTN
        '
        Me.FollowBTN.Location = New System.Drawing.Point(0, 19)
        Me.FollowBTN.Name = "FollowBTN"
        Me.FollowBTN.Size = New System.Drawing.Size(75, 23)
        Me.FollowBTN.TabIndex = 10
        Me.FollowBTN.Text = "Follow"
        Me.FollowBTN.UseVisualStyleBackColor = True
        '
        'UnfollowBNT
        '
        Me.UnfollowBNT.Location = New System.Drawing.Point(-1, 48)
        Me.UnfollowBNT.Name = "UnfollowBNT"
        Me.UnfollowBNT.Size = New System.Drawing.Size(75, 23)
        Me.UnfollowBNT.TabIndex = 11
        Me.UnfollowBNT.Text = "UnFollow"
        Me.UnfollowBNT.UseVisualStyleBackColor = True
        '
        'ListConsole
        '
        Me.ListConsole.FormattingEnabled = True
        Me.ListConsole.Location = New System.Drawing.Point(243, 230)
        Me.ListConsole.Name = "ListConsole"
        Me.ListConsole.Size = New System.Drawing.Size(250, 134)
        Me.ListConsole.TabIndex = 3
        '
        'ig
        '
        Me.ig.Location = New System.Drawing.Point(500, 2)
        Me.ig.MinimumSize = New System.Drawing.Size(20, 20)
        Me.ig.Name = "ig"
        Me.ig.Size = New System.Drawing.Size(510, 407)
        Me.ig.TabIndex = 9
        '
        'Setting
        '
        Me.Setting.Location = New System.Drawing.Point(256, 380)
        Me.Setting.Name = "Setting"
        Me.Setting.Size = New System.Drawing.Size(75, 23)
        Me.Setting.TabIndex = 10
        Me.Setting.Text = "View Setting"
        Me.Setting.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 410)
        Me.Controls.Add(Me.Setting)
        Me.Controls.Add(Me.ig)
        Me.Controls.Add(Me.ListConsole)
        Me.Controls.Add(Me.Tools)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.AboutBTN)
        Me.Controls.Add(Me.CloseBTN)
        Me.Controls.Add(Me.Info)
        Me.Name = "Main"
        Me.Text = "Instagram Tootkit"
        Me.Info.ResumeLayout(False)
        Me.Info.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Tools.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Info As System.Windows.Forms.GroupBox
    Friend WithEvents SelectionLab As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListWork As System.Windows.Forms.ListBox
    Friend WithEvents CloseBTN As System.Windows.Forms.Button
    Friend WithEvents PassView As System.Windows.Forms.Button
    Friend WithEvents SignInBTN As System.Windows.Forms.Button
    Friend WithEvents SignOutBTN As System.Windows.Forms.Button
    Friend WithEvents AboutBTN As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Password As System.Windows.Forms.TextBox
    Friend WithEvents Username As System.Windows.Forms.TextBox
    Friend WithEvents Tools As System.Windows.Forms.GroupBox
    Friend WithEvents UnReportBTN As System.Windows.Forms.Button
    Friend WithEvents CommentsBTN As System.Windows.Forms.Button
    Friend WithEvents LikeBTN As System.Windows.Forms.Button
    Friend WithEvents ReportBTN As System.Windows.Forms.Button
    Friend WithEvents UnblockBTN As System.Windows.Forms.Button
    Friend WithEvents BlockBTN As System.Windows.Forms.Button
    Friend WithEvents FollowBTN As System.Windows.Forms.Button
    Friend WithEvents UnfollowBNT As System.Windows.Forms.Button
    Friend WithEvents ListConsole As System.Windows.Forms.ListBox
    Friend WithEvents LoadBTN As System.Windows.Forms.Button
    Friend WithEvents ig As System.Windows.Forms.WebBrowser
    Friend WithEvents AddBTN As System.Windows.Forms.Button
    Friend WithEvents Setting As System.Windows.Forms.Button

End Class
