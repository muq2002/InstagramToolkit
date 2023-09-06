Imports System.IO
Public Class Main


    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Width = 514
        Me.Height = 450

        ' Rest Some Values
        SignInBTN.Enabled = False
        SignOutBTN.Enabled = False
    End Sub

    'code
    ' Follow
    Private Sub FollowBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FollowBTN.Click
        Dim DisplayMSM As Boolean
        DisplayMSM = True
        ListConsole.Items.Clear()
        If listwork.Items.Count <> 0 Then
            Dim UserView As String
            For l = 0 To (ListWork.Items.Count) - 1
                If CheckOffline() <> True Then
                    ListWork.SetSelected(l, True)
                    UserView = ListWork.SelectedItem()
                    ig.Navigate("https://www.ig.com/" & Trim(UserView) & "/")
                    Do While ig.ReadyState <> WebBrowserReadyState.Complete Or ig.IsBusy : Application.DoEvents() : Loop

                    ' Now Start to follow
                    Threading.Thread.Sleep(1000)
                    'deley(10 ^ Val(Time.Text))
                    If DisplayMSM = True Then
                        If (ListConsole.Items.Count) - 1 >= 40 Then
                            If MsgBox("You Arrive to mix( " & l & " ) you can follow (above 40 users). do you want to stop ?", vbInformation + vbYesNo, "Follow Method") = vbYes Then
                                Exit Sub
                            Else
                                DisplayMSM = False
                            End If
                        End If
                    End If
                    For Follow = 0 To (ig.Document.GetElementsByTagName("button").Count) - 1
                        If ig.Document.GetElementsByTagName("button")(Follow).InnerText = "Follow" Then
                            ig.Document.GetElementsByTagName("button")(Follow).InvokeMember("click")
                            'deley(10 ^ Val(Time.Text))
                            'Write on Console
                            ListConsole.Items.Add("Follow( " & l & " )-> " & UserView)
                            Threading.Thread.Sleep(100)
                            'GoodLb.Text = "Good Rq. : " & ListConsole.Items.Count
                            Exit For
                        End If
                    Next Follow
                Else
                    MsgBox("Your Driver is Offline, We arrive to : " & l, vbInformation, "Internet Method")
                    End
                End If
            Next l
        Else
            MsgBox("Your Must Loading Users List", vbInformation, "List User Method")
            Exit Sub
        End If
    End Sub
    'Unfollow
    Private Sub UnfollowBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnfollowBNT.Click
        Dim NumUnfollow As String
        Dim DisplayMSM As Boolean
        DisplayMSM = True
        ListConsole.Items.Clear()
        If listwork.Items.Count <> 0 Then
            NumUnfollow = 0
            NumUnfollow = InputBox("Select Number UnFollow Account To View :", "Select Number Start", "0")
            Dim UserView As String
            For l = Val(NumUnfollow) To (listwork.Items.Count) - 1
                    If CheckOffline() <> True Then
                        listwork.SetSelected(l, True)
                        UserView = listwork.SelectedItem()
                        ig.Navigate("https://www.ig.com/" & Trim(UserView) & "/")
                        Do While ig.ReadyState <> WebBrowserReadyState.Complete Or ig.IsBusy : Application.DoEvents() : Loop

                        ' Now Start to follow
                        Threading.Thread.Sleep(1000)
                    'deley(10 ^ Val(Time.Text))
                        If DisplayMSM = True Then
                            If ListConsole.Items.Count >= 15 Then
                                If MsgBox("You Arrive to mix( " & l & " ) you can unfollow (15 users). do you want to stop ?", vbInformation + vbYesNo, "Unfollow Method") = vbYes Then
                                    Exit Sub
                                Else
                                    DisplayMSM = False
                                End If
                            End If
                        End If
                        For unFollow = 0 To (ig.Document.GetElementsByTagName("button").Count) - 1
                            If ig.Document.GetElementsByTagName("button")(unFollow).InnerText = "Following" Then
                                ig.Document.GetElementsByTagName("button")(unFollow).InvokeMember("click")
                                Exit For
                            End If
                        Next unFollow

                        ' Confire Unfollow
                    'deley(10 ^ Val(Time.Text))
                        For CunFollow = 0 To (ig.Document.GetElementsByTagName("button").Count) - 1
                            If ig.Document.GetElementsByTagName("button")(CunFollow).InnerText = "Unfollow" Then
                                ig.Document.GetElementsByTagName("button")(CunFollow).InvokeMember("click")
                                'Write on Console
                                ListConsole.Items.Add("Unfollow( " & l & " )-> " & UserView)
                                Threading.Thread.Sleep(100)
                            'GoodLb.Text = "Good Rq. : " & ListConsole.Items.Count
                                Exit For
                            End If
                        Next CunFollow
                    Else
                        MsgBox("Your Driver is Offline, We arrive to : " & l, vbInformation, "Internet Method")
                        End
                    End If
            Next l

        Else
            MsgBox("Your Must Loading Users List", vbInformation, "List User Method")
            Exit Sub
        End If
    End Sub
    ' Block
    Private Sub BlockBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BlockBTN.Click
        Dim NumBlock As String
        Dim DisplayMSM As Boolean
        DisplayMSM = True
        ListConsole.Items.Clear()
        If listwork.Items.Count <> 0 Then
            NumBlock = 0
            NumBlock = InputBox("Select Number Block Account To View :", "Select Number Start", "0")
            Dim UserView As String
            For l = Val(NumBlock) To (listwork.Items.Count) - 1
                    If CheckOffline() <> True Then
                        listwork.SetSelected(l, True)
                        UserView = listwork.SelectedItem()
                        ig.Navigate("https://www.ig.com/" & Trim(UserView) & "/")
                        Do While ig.ReadyState <> WebBrowserReadyState.Complete Or ig.IsBusy : Application.DoEvents() : Loop

                        ' Now Start to follow
                        Threading.Thread.Sleep(1000)
                    ' deley(10 ^ Val(Time.Text))
                        If DisplayMSM = True Then
                            If ListConsole.Items.Count >= 15 Then
                                If MsgBox("You Arrive to mix( " & l & " ) you can block (above 15 users). do you want to stop ?", vbInformation + vbYesNo, "Block Method") = vbYes Then
                                    Exit Sub
                                Else
                                    DisplayMSM = False
                                End If
                            End If
                        End If
                        ' Access List Have Block Accounts
                        ig.Document.GetElementsByTagName("button")(2).InvokeMember("click")
                        ' Click Block Button
                        For Block = 0 To (ig.Document.GetElementsByTagName("button").Count) - 1
                            If ig.Document.GetElementsByTagName("button")(Block).InnerText = "Block this user" Then
                                ig.Document.GetElementsByTagName("button")(Block).InvokeMember("click")
                                Exit For
                            End If
                        Next Block
                        ' deley(10 ^ Val(Time.Text))
                        ' Confirm block
                        For CBlock = 0 To (ig.Document.GetElementsByTagName("button").Count) - 1
                            If ig.Document.GetElementsByTagName("button")(CBlock).InnerText = "Block" Then
                                ig.Document.GetElementsByTagName("button")(CBlock).InvokeMember("click")
                                'Write on Console
                                ListConsole.Items.Add("Block( " & l & " )-> " & UserView)
                                Threading.Thread.Sleep(100)
                            'GoodLb.Text = "Good Rq. : " & ListConsole.Items.Count
                                Exit For
                            End If
                        Next CBlock


                    Else
                        MsgBox("Your Driver is Offline, We arrive to : " & l, vbInformation, "Internet Method")
                        End
                    End If
            Next l

        Else
            MsgBox("Your Must Loading Users List", vbInformation, "List User Method")
            Exit Sub
        End If
    End Sub
    ' Unblock
    Private Sub UnblockBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnblockBTN.Click
        Dim NumUnBlock As String
        Dim DisplayMSM As Boolean
        DisplayMSM = True
        ListConsole.Items.Clear()
        If listwork.Items.Count <> 0 Then
            NumUnBlock = 0
            NumUnBlock = InputBox("Select Number Unblock Account To View :", "Select Number Start", "0")
            Dim UserView As String
            For l = Val(NumUnBlock) To (listwork.Items.Count) - 1
                If CheckOffline() <> True Then
                    ListWork.SetSelected(l, True)
                    UserView = ListWork.SelectedItem()
                    ig.Navigate("https://www.ig.com/" & Trim(UserView) & "/")
                    Do While ig.ReadyState <> WebBrowserReadyState.Complete Or ig.IsBusy : Application.DoEvents() : Loop

                    ' Now Start to follow
                    Threading.Thread.Sleep(1000)
                    ' deley(10 ^ Val(Time.Text))
                    If DisplayMSM = True Then
                        If ListConsole.Items.Count >= 15 Then
                            If MsgBox("You Arrive to mix( " & l & " ) you can unBlock (above 15 users). do you want to stop ?", vbInformation + vbYesNo, "Unblock Method") = vbYes Then
                                Exit Sub
                            Else
                                DisplayMSM = False
                            End If
                        End If
                    End If

                    ' Click Unblock Button
                    For J = 0 To 2
                        For Block = 0 To (ig.Document.GetElementsByTagName("button").Count) - 1
                            If ig.Document.GetElementsByTagName("button")(Block).InnerText = "Unblock" Then
                                ig.Document.GetElementsByTagName("button")(Block).InvokeMember("click")

                                'Write on Console
                                ListConsole.Items.Add("Unblock( " & l & " )-> " & UserView)
                                Threading.Thread.Sleep(100)
                                'GoodLb.Text = "Good Rq. : " & ListConsole.Items.Count
                            End If
                        Next Block
                    Next J
                Else
                    MsgBox("Your Driver is Offline, We arrive to : " & l, vbInformation, "Internet Method")
                    End
                End If
            Next l

        Else
            MsgBox("Your Must Loading Users List", vbInformation, "List User Method")
            Exit Sub
        End If
    End Sub


    ' Desgin
    Private Sub CloseBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBTN.Click
        End
    End Sub
    Private Sub PassView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PassView.Click
        If Password.PasswordChar <> "*" Then
            Password.PasswordChar = "*"
        Else
            Password.PasswordChar = ""
        End If
    End Sub
    Private Sub Username_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Username.TextChanged
        If Username.Text <> "" And Password.Text <> "" Then
            SignInBTN.Enabled = True
            SignOutBTN.Enabled = True
        Else
            SignInBTN.Enabled = False
            SignOutBTN.Enabled = False
        End If
    End Sub
    Private Sub Password_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Password.TextChanged
        If Username.Text <> "" And Password.Text <> "" Then
            SignInBTN.Enabled = True
            SignOutBTN.Enabled = True
        Else
            SignInBTN.Enabled = False
            SignOutBTN.Enabled = False
        End If
    End Sub
    Private Sub LoadBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadBTN.Click
        Dim StringReader, Path As String
        If ListWork.Items.Count > 0 Then
            If MsgBox("You have " & ListWork.Items.Count & " user(s) Do you want delete this ?", vbInformation + vbYesNo) = vbYes Then
                ListWork.Items.Clear()
            End If
        End If
        Path = FilesDialog()
        If My.Computer.FileSystem.FileExists(Path) Then
            Dim FileReader As System.IO.StreamReader
            FileReader = My.Computer.FileSystem.OpenTextFileReader(Path)
            For L = 0 To File.ReadAllLines(Path).Length
                Using sr As New System.IO.StreamReader(Path)
                    StringReader = FileReader.ReadLine()
                    If StringReader <> "" Then
                        ListWork.Items.Add(StringReader)
                        If L = (File.ReadAllLines(Path).Length) - 1 Then
                            FileReader.Close()
                            Exit For
                        End If
                    End If
                End Using
            Next
        End If
        If ListWork.Items.Count > 0 Then
            MsgBox("Loaded List users", vbInformation, "Loaded Method")
            SelectionLab.Text = "Selected: " & ListWork.SelectedIndex + 1 & " From: " & ListWork.Items.Count
        End If
    End Sub
    Private Sub AddBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBTN.Click
        Dim Data As String
        Data = InputBox("Write Username here ! ", "username")
        For L = 0 To (ListWork.Items.Count) - 1
            ListWork.SetSelected(L, True)
            If Data = ListWork.SelectedItem Then
                MsgBox("This is found on this list")
                Exit Sub
            End If
        Next L
        ListWork.Items.Add(Data)
    End Sub

    'Functions
    Public Function FilesDialog() As String
        Dim fd As OpenFileDialog = New OpenFileDialog()

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = Application.StartupPath & "\data\"
        fd.Filter = "All files (*.txt)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            FilesDialog = fd.FileName
        End If
    End Function
    Public Function Login(ByVal User As String, ByVal Pass As String)
        Dim Test
        If CheckOffline() <> True Then
            ig.Navigate("https://www.ig.com/accounts/login/?source=auth_switcher")
            Do While ig.ReadyState <> WebBrowserReadyState.Complete Or ig.IsBusy : Application.DoEvents() : Loop
            Do Until (ig.Document.GetElementById("react-root").OuterHtml).IndexOf("http://www.w3.org/2000/svg") > 34 : Application.DoEvents() : Loop
            ' i loop login becuseig does work  if not loop
            For Test = 0 To 2
                For UserSet = 0 To (ig.Document.GetElementsByTagName("input").Count) - 1
                    If ig.Document.GetElementsByTagName("input")(UserSet).GetAttribute("className") = "_2hvTZ pexuQ zyHYP" Then
                        ig.Document.GetElementsByTagName("input")(UserSet).InnerText = User
                        Exit For
                    End If
                Next UserSet
                'Set Password 
                ig.Document.GetElementsByTagName("input")(1).InnerText = Pass
            Next Test
            For Login = 0 To (ig.Document.GetElementsByTagName("button").Count) - 1
                If ig.Document.GetElementsByTagName("button")(Login).InnerText = "Log In" Then
                    ig.Document.GetElementsByTagName("button")(Login).InvokeMember("click")
                    Exit For
                End If
            Next Login
            Do While ig.ReadyState <> WebBrowserReadyState.Complete Or ig.IsBusy : Application.DoEvents() : Loop
            Do Until (ig.Document.GetElementById("react-root").OuterHtml).IndexOf("http://www.w3.org/2000/svg") > 34 : Application.DoEvents() : Loop
            ' Login Checker
            If ig.Url.AbsoluteUri.ToString.IndexOf("challenge") > 0 Then
                MsgBox("there are challenge on ig account ! " + vbNewLine + "So, You Should fix that .", vbExclamation + vbOK)
                For Q = 0 To (ig.Document.GetElementsByTagName("div").Count) - 1
                    If ig.Document.GetElementsByTagName("div")(Q).GetAttribute("className").ToString.IndexOf("vqibd  wNNoj") > 0 Then
                        MsgBox("there are challenge on ig account ! " + vbNewLine + "So, You Should fix that ." + vbNewLine + ig.Document.GetElementsByTagName("div")(Q).InnerText, vbExclamation + vbOK)
                    End If
                Next Q
            End If
            For N = 0 To (ig.Document.GetElementsByTagName("span").Count) - 1
                If ig.Document.GetElementsByTagName("span")(N).GetAttribute("className").ToString = "glyphsSpriteUser__outline__24__grey_9 u-__7" Then
                    ListConsole.Items.Add("Log In as " & ig.Document.GetElementsByTagName("span")(N).Parent.GetAttribute("href").ToString().Replace("/", ""))
                End If
            Next N
        Else
            MsgBox("Your Driver is Offline", vbInformation, "Internet Method")
            Exit Function
        End If
    End Function
    Public Function Logout()
        Dim User As String
        If CheckOffline() <> True Then
            ig.Navigate("https://www.ig.com/")
            Do While ig.ReadyState <> WebBrowserReadyState.Complete Or ig.IsBusy : Application.DoEvents() : Loop
            Do Until (ig.Document.GetElementById("react-root").OuterHtml).IndexOf("http://www.w3.org/2000/svg") > 34 : Application.DoEvents() : Loop
            For N = 0 To (ig.Document.GetElementsByTagName("span").Count) - 1
                If ig.Document.GetElementsByTagName("span")(N).GetAttribute("className").ToString = "glyphsSpriteUser__outline__24__grey_9 u-__7" Then
                    ListConsole.Items.Add("Log In as " & ig.Document.GetElementsByTagName("span")(N).Parent.GetAttribute("href").ToString().Replace("/", ""))
                    User = ig.Document.GetElementsByTagName("span")(N).Parent.GetAttribute("href").ToString().Replace("/", "")
                End If
            Next N
            ig.Navigate("https://www.ig.com/" & User & "/")
            Do While ig.ReadyState <> WebBrowserReadyState.Complete Or ig.IsBusy : Application.DoEvents() : Loop
            Do Until (ig.Document.GetElementById("react-root").OuterHtml).IndexOf("http://www.w3.org/2000/svg") > 34 : Application.DoEvents() : Loop
            ' Setting Button Click
            'glyphsSpriteSettings__outline__24__grey_9 u-__7
            For SettingA = 0 To (ig.Document.GetElementsByTagName("span").Count) - 1
                If ig.Document.GetElementsByTagName("span")(SettingA).GetAttribute("className") = "glyphsSpriteSettings__outline__24__grey_9 u-__7" Then
                    ig.Document.GetElementsByTagName("span")(SettingA).Parent().InvokeMember("click")
                    Exit For
                End If
            Next SettingA
            ' Logout  Button Click
            For Logout = 0 To (ig.Document.GetElementsByTagName("button").Count) - 1
                If ig.Document.GetElementsByTagName("button")(Logout).InnerText = "Log Out" Then
                    ig.Document.GetElementsByTagName("button")(Logout).InvokeMember("click")
                    Exit For
                End If
            Next Logout
            Threading.Thread.Sleep(3000)
            Do While ig.ReadyState <> WebBrowserReadyState.Complete Or ig.IsBusy : Application.DoEvents() : Loop
            ListConsole.Items.Add("Log Out From ")
        Else
            MsgBox("Your Driver is Offline", vbInformation, "Internet Method")
            Exit Function
        End If
    End Function
    Public Function CheckOffline() As Boolean
        On Error GoTo Line1
        My.Computer.Network.Ping("www.ig.com")
        CheckOffline = False
        Exit Function
Line1:
        CheckOffline = True
    End Function

    Private Sub SignInBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SignInBTN.Click
        Login(Username.Text, Password.Text)
    End Sub

    Private Sub SignOutBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SignOutBTN.Click
        Logout()
    End Sub

    Private Sub ReportBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportBTN.Click
        Report.Show()
    End Sub
End Class
