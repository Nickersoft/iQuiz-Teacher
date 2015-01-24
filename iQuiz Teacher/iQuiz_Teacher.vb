Imports System.Net
Imports System.IO
Public Class iQuizTeacher

    Dim list As New List(Of String)
    Dim newquiz As New OpenQuiz 'Declares newquiz as a new 'opened' quiz

#Region "Public Functions"

    Public Sub ViewQuiz(ByVal FilePath As String)

        newquiz.Show()
        Application.DoEvents()


        Dim FileContents As String = IO.File.ReadAllText(FilePath) 'Declares FileContents as the contents of the *.quest file
        newquiz.ToolStrip1.Tag = FilePath 'Hides the FilePath string in the toolstrip at the bottom of the screen

        For Each line As String In FileContents.Split(Chr(10)) 'Splits the lines of the quiz's contents into a string array
            Dim type() As String = line.Split(";") 'Splits the line into fields using the ';' divider

            'If line contains an essay...
            If type(0) = "[ESS" Then
                Dim inner As List(Of String) = NewForm.GetTagContents(line, "[ESS", "/ESS]")
                Dim disect() As String = inner(0).Split(";")
                NewForm.AddESS(newquiz.OpenedQuiz, disect(1).Replace("<br>", Chr(10)), disect(2).Replace("<br>", Chr(10)), False, False)
            End If

            'If line contains a short answer...
            If type(0) = "[SA" Then
                Dim inner As List(Of String) = NewForm.GetTagContents(line, "[SA", "/SA]")
                Dim disect() As String = inner(0).Split(";")
                NewForm.AddSA(newquiz.OpenedQuiz, disect(1), disect(2), False, False)
            End If

            'If line contains a multiple choice...
            If type(0) = "[MC" Then
                Dim inner As List(Of String) = NewForm.GetTagContents(line, "[MC", "/MC]")
                Dim disect() As String = inner(0).Split(";")
                NewForm.AddMC(newquiz.OpenedQuiz, disect(1), disect(2), False)
            End If

            'If line contains a text field...
            If type(0) = "[TXT" Then
                Dim inner As List(Of String) = NewForm.GetTagContents(line, "[TXT", "/TXT]")
                Dim disect() As String = inner(0).Split(";")
                NewForm.AddText(newquiz.OpenedQuiz, disect(1).Replace("<br>", Chr(10)), False)
            End If

            'If line contains a title...
            If type(0) = "[TIT" Then
                Dim inner As List(Of String) = NewForm.GetTagContents(line, "[TIT", "/TIT]")
                Dim disect() As String = inner(0).Split(";")
                NewForm.AddTitle(newquiz.OpenedQuiz, disect(1), False)
            End If

            'If line contains a picture...
            If type(0) = "[PIC" Then
                Dim inner As List(Of String) = NewForm.GetTagContents(line, "[PIC", "/PIC]")
                Dim disect() As String = inner(0).Split(";")
                NewForm.AddPic(newquiz.OpenedQuiz, disect(1), False, False, disect(2), disect(3))
            End If

            'If line contains a media file
            If line.Split("*")(0) = "[MED" Then
                Dim inner As List(Of String) = NewForm.GetTagContents(line, "[MED", "/MED]")
                Dim disect() As String = inner(0).Split("*")
                NewForm.AddMedia(newquiz.OpenedQuiz, disect(1), disect(2), True)
            End If

            'If line contains a true or false question
            If type(0) = "[TF" Then
                Dim inner As List(Of String) = NewForm.GetTagContents(line, "[TF", "/TF]")
                Dim disect() As String = inner(0).Split(";")
                If disect(2).Trim = "True" Then
                    NewForm.AddTF(newquiz.OpenedQuiz, disect(1), True, False, True)
                Else
                    NewForm.AddTF(newquiz.OpenedQuiz, disect(1), False, False, True)
                End If

            End If

            'If line contains a fill-in-the-blanks question...
            If type(0) = "[FB" Then
                Dim inner As List(Of String) = NewForm.GetTagContents(line, "[FB", "/FB]")
                Dim disect() As String = inner(0).Split(";")
                NewForm.AddFitB(newquiz.OpenedQuiz, disect(1), disect(2), False)
            End If
        Next

        NewForm.RefreshNums(newquiz.OpenedQuiz)
        Application.DoEvents()

        newquiz.OpenedQuiz.Visible = True

    End Sub
    Public Sub EditQuiz(ByVal QuizPath As String)
        Dim newquiz As New NewForm
        Dim pic As New PictureBox
        pic.BackColor = NewForm.BackColor
        pic.Dock = DockStyle.Fill
        pic.Image = My.Resources.generator
        pic.SizeMode = PictureBoxSizeMode.CenterImage
        newquiz.Controls.Add(pic)
        pic.BringToFront()
        Application.DoEvents()

        Dim QuizContents As String = IO.File.ReadAllText(QuizPath)
        newquiz.Show()
        Application.DoEvents()

        Dim path As String = ListView1.SelectedItems(0).SubItems(1).Text & "\" & ListView1.SelectedItems(0).Text & ".quest"
        newquiz.quizname.Tag = path
        newquiz.quizname.Text = IO.Path.GetFileNameWithoutExtension(path)
        For Each line As String In QuizContents.Split(Chr(10))
            Dim type() As String = line.Split(";")

            'If line contains an essay
            If type(0) = "[ESS" Then
                Dim inner As List(Of String) = NewForm.GetTagContents(line, "[ESS", "/ESS]")
                Dim disect() As String = inner(0).Split(";")

                NewForm.AddESS(newquiz.Quiz, disect(1).Replace("<br>", Chr(10)), disect(2).Replace("<br>", Chr(10)), True, True)
            End If

            'If line contains a short answer
            If type(0) = "[SA" Then
                Dim inner As List(Of String) = NewForm.GetTagContents(line, "[SA", "/SA]")
                Dim disect() As String = inner(0).Split(";")
                NewForm.AddSA(newquiz.Quiz, disect(1), disect(2), True, True)
            End If

            'If line contains a multiple choice
            If type(0) = "[MC" Then
                Dim inner As List(Of String) = NewForm.GetTagContents(line, "[MC", "/MC]")
                Dim disect() As String = inner(0).Split(";")
                NewForm.AddMC(newquiz.Quiz, disect(1), disect(2), True)
            End If

            'If line contains a text field
            If type(0) = "[TXT" Then
                Dim inner As List(Of String) = NewForm.GetTagContents(line, "[TXT", "/TXT]")
                Dim disect() As String = inner(0).Split(";")
                NewForm.AddText(newquiz.Quiz, disect(1).Replace("<br>", Chr(10)), True)
            End If

            'If line contains a title
            If type(0) = "[TIT" Then
                Dim inner As List(Of String) = NewForm.GetTagContents(line, "[TIT", "/TIT]")
                Dim disect() As String = inner(0).Split(";")
                NewForm.AddTitle(newquiz.Quiz, disect(1), True)
            End If

            'If line contains a picture
            If type(0) = "[PIC" Then
                Dim inner As List(Of String) = NewForm.GetTagContents(line, "[PIC", "/PIC]")
                Dim disect() As String = inner(0).Split(";")
                NewForm.AddPic(newquiz.Quiz, disect(1), False, True, disect(2), disect(3))
            End If

            'If line contains a media file
            If line.Split("*")(0) = "[MED" Then
                Dim inner As List(Of String) = NewForm.GetTagContents(line, "[MED", "/MED]")
                Dim disect() As String = inner(0).Split("*")
                NewForm.AddMedia(newquiz.Quiz, disect(1), disect(2), True)
            End If

            'If line contains a true or false question
            If type(0) = "[TF" Then
                Dim inner As List(Of String) = NewForm.GetTagContents(line, "[TF", "/TF]")
                Dim disect() As String = inner(0).Split(";")
                If disect(2).Trim = "True" Then
                    NewForm.AddTF(newquiz.Quiz, disect(1), True, True, True)
                Else
                    NewForm.AddTF(newquiz.Quiz, disect(1), False, True, True)
                End If

            End If

            'If line contains a fill-in-the-blanks question
            If type(0) = "[FB" Then
                Dim inner As List(Of String) = NewForm.GetTagContents(line, "[FB", "/FB]")
                Dim disect() As String = inner(0).Split(";")
                NewForm.AddFitB(newquiz.Quiz, disect(1), disect(2), True)
            End If
        Next

        newquiz.RefreshNums(newquiz.Quiz)
        Dim modDate As Date = IO.File.GetLastWriteTime(QuizPath)
        newquiz.ToolStripStatusLabel1.Text = "Last saved: " & modDate.ToShortDateString & " at " & modDate.ToShortTimeString
        Application.DoEvents()
        newquiz.issaved = True
        newquiz.Controls.Remove(pic)
        Application.DoEvents()
    End Sub
    Public Sub UploadFTPFile(ByVal FileLocation As String, ByVal DestNoRoot As String)
        Dim request As System.Net.FtpWebRequest = DirectCast(System.Net.WebRequest.Create(My.Settings.CurrentServer & "/iQuiz Pro/" & DestNoRoot), System.Net.FtpWebRequest)
        request.Credentials = New Net.NetworkCredential(My.Settings.username, My.Settings.password)
        request.Method = System.Net.WebRequestMethods.Ftp.UploadFile

        Dim file() As Byte = System.IO.File.ReadAllBytes(FileLocation)
        Dim strz As System.IO.Stream = request.GetRequestStream()
        strz.Write(file, 0, file.Length)
        strz.Close()
        strz.Dispose()
    End Sub
    Public Function DWNLDFTPInfo(ByVal LocationNoRoot As String) As String

        Dim client As New WebClient
        client.Credentials = New NetworkCredential(My.Settings.username, My.Settings.password)
        Return client.DownloadString(My.Settings.CurrentServer & "/iQuiz Pro/" & LocationNoRoot)

    End Function
    Public Function DeleteFTPFile(ByVal LocationNoRoot As String) As Boolean
        Try
            Dim request As System.Net.FtpWebRequest = DirectCast(System.Net.WebRequest.Create(My.Settings.CurrentServer & "/iQuiz Pro/" & LocationNoRoot), System.Net.FtpWebRequest)
            request.Credentials = New System.Net.NetworkCredential(My.Settings.username, My.Settings.password)
            request.Method = System.Net.WebRequestMethods.Ftp.DeleteFile

            request.GetResponse()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function CreateFTPDirectory(ByVal LocationNoRoot As String) As Boolean
        Try
            Dim request As System.Net.FtpWebRequest = DirectCast(System.Net.WebRequest.Create(My.Settings.CurrentServer & "/iQuiz Pro/" & LocationNoRoot), System.Net.FtpWebRequest)
            request.Credentials = New System.Net.NetworkCredential(My.Settings.username, My.Settings.password)
            request.Method = System.Net.WebRequestMethods.Ftp.MakeDirectory

            request.GetResponse()
            Return True
        Catch
            Return False
        End Try
    End Function
    Public Function DeleteFTPDirectory(ByVal LocationNoRoot As String) As Boolean
        Try
            Dim request As System.Net.FtpWebRequest = DirectCast(System.Net.WebRequest.Create(My.Settings.CurrentServer & "/iQuiz Pro/" & LocationNoRoot), System.Net.FtpWebRequest)
            request.Credentials = New System.Net.NetworkCredential(My.Settings.username, My.Settings.password)
            request.Method = System.Net.WebRequestMethods.Ftp.RemoveDirectory

            request.GetResponse()
            Return True
        Catch
            Return False
        End Try
    End Function
    Public Function ListFTPDirectories(ByVal LocationNoRoot As String) As String
        Dim request As System.Net.FtpWebRequest = DirectCast(System.Net.WebRequest.Create(My.Settings.CurrentServer & "/iQuiz Pro/" & LocationNoRoot), System.Net.FtpWebRequest)
        request.Credentials = New Net.NetworkCredential(My.Settings.username, My.Settings.password)
        request.Method = System.Net.WebRequestMethods.Ftp.ListDirectory

        Dim strz As System.IO.Stream = request.GetRequestStream()
        Dim strRead As New StreamReader(strz)
        Return strRead.ReadToEnd()
        strz.Close()
        strz.Dispose()
    End Function
    Public Sub RefreshQuizzes()

        If My.Settings.StoredQuizzes.Trim = "" Then
        Else
            ListView1.Items.Clear()
            For Each quiz As String In My.Settings.StoredQuizzes.Split("|")
                Dim quizz() As String = quiz.Split(";")
                If quizz(0).Trim = "" Then
                Else

                    If IO.File.Exists(quizz(1) & "\" & quizz(0) & ".quest") Then
                        Dim newitem As New ListViewItem
                        newitem.Text = quizz(0)
                        newitem.SubItems.Add(quizz(1))
                        newitem.SubItems.Add("No")
                        ListView1.Items.Add(newitem)
                    End If

                End If

            Next
        End If

    End Sub

#End Region

#Region "All Button Events"
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        Try
            Dim path As String = ListView1.SelectedItems(0).SubItems(1).Text & "\" & ListView1.SelectedItems(0).Text & ".quest"
            EditQuiz(path)
        Catch ex As IO.FileNotFoundException
            MsgBox("It appears that this file has been changed, moved, or no longer exists. Click ""Add Quiz"" or ""Refresh"" to reimport this quiz or remove it from the list")
        Catch ex As ArgumentException
            MsgBox("Please select or double-click a quiz to view it")
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message & ". Please contact Nickersoft at nickersoft@gmail.com.")
        End Try
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HostSelectedToolStripMenuItem.Click
        Try
            Dim testLine As String = ListView1.SelectedItems(0).Text
            HostQuiz()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Please select a quiz to host it.", MsgBoxStyle.OkOnly)
        End Try

    End Sub
    Public Sub HostQuiz()
        Dim username As String = My.User.Name.Split("\")(My.User.Name.Split("\").Length - 1)
        Try
            DWNLDFTPInfo(username & "/" & ListView1.SelectedItems(0).Text & ".quest")
            If MessageBox.Show("You are already hosting a quiz with the same name. Would you like to stop hosting that quiz and replace it with this one?", "Quiz Already Hosting", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                DeleteFTPFile(username & "/" & ListView1.SelectedItems(0).Text & ".quest")
            Else
                Exit Sub
            End If
        Catch ex As Exception

        End Try

        Dim path As String = ListView1.SelectedItems(0).SubItems(1).Text & "\" & ListView1.SelectedItems(0).Text & ".quest"
        Dim str As String = IO.File.ReadAllText(path)
        str = str.Insert(0, TextBox1.Text & vbCrLf)
        Application.DoEvents()

        CreateFTPDirectory(username)
        CreateFTPDirectory(username & "/" & ListView1.SelectedItems(0).Text)
        CreateFTPDirectory(username & "/" & ListView1.SelectedItems(0).Text & "/Completed")

        UploadFTPFile(path, username & "/" & ListView1.SelectedItems(0).Text & "/" & ListView1.SelectedItems(0).Text & ".quest")
        ListView1.SelectedItems(0).SubItems(2).Text = "Yes"
        Application.DoEvents()
        MsgBox("Congradulations! You're quiz is now hosting and ready for students to take!", MsgBoxStyle.Information, "Your Quiz is Now Hosting!")
        ComboBox1.Items.Add(ListView1.SelectedItems(0).Text)
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshQuizzesToolStripMenuItem.Click
        For Each item As ListViewItem In ListView1.Items
            If IO.File.Exists(item.SubItems(1).Text & "\" & item.SubItems(0).Text) = False Then
                ListView1.Items.Remove(item)
            End If
        Next
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteSelectedToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to delete this quiz from your hard drive?", "Are You Sure You Want to Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Try
                IO.File.Delete(ListView1.SelectedItems(0).SubItems(1).Text & "\" & ListView1.SelectedItems(0).Text & ".quest")
                Application.DoEvents()
                RefreshQuizzes()
            Catch ex As ArgumentException
                MsgBox("Please select a quiz to delete.")
            Catch ex As IO.FileNotFoundException
                If MessageBox.Show("It appears that this file no longer exists. Would you like to remove this file from the list?") = Windows.Forms.DialogResult.Yes Then
                    ListView1.Items.Remove(ListView1.SelectedItems(0))
                End If
            Catch ex As Exception
                MsgBox("An error occurred: " & ex.Message & ". Please contact Nickersoft at nickersoft@gmail.com.")
            End Try
        End If
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewQuizToolStripMenuItem.Click
        NewForm.Show()
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewSelectedToolStripMenuItem.Click
        Try
            Dim path As String = ListView1.SelectedItems(0).SubItems(1).Text & "\" & ListView1.SelectedItems(0).Text & ".quest"
            ViewQuiz(path)
        Catch ex As FileNotFoundException
            MsgBox("It appears that this file has been changed, moved, or no longer exists. Click ""Add Quiz"" or ""Refresh"" to reimport this quiz or remove it from the list")
        Catch ex As ArgumentException
            MsgBox("Please select or double-click a quiz to view it")
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message & ". Please contact Nickersoft at nickersoft@gmail.com.")
        End Try
    End Sub
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportQuizToolStripMenuItem.Click
        If OpenFileDialog3.ShowDialog = Windows.Forms.DialogResult.OK Then
            For Each fil As String In OpenFileDialog3.FileNames
                Dim nitem As New ListViewItem
                nitem.Text = IO.Path.GetFileNameWithoutExtension(fil)
                nitem.SubItems.Add(IO.Path.GetDirectoryName(fil))
                nitem.SubItems.Add("No")
                ListView1.Items.Add(nitem)
            Next

        End If
    End Sub
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutIQuizToolStripMenuItem.Click
        AboutMe.Show()
    End Sub
#End Region

#Region "iQuiz Form Events"

    Private Sub iQuizTeacher_InputLanguageChanging(ByVal sender As Object, ByVal e As System.Windows.Forms.InputLanguageChangingEventArgs) Handles Me.InputLanguageChanging

    End Sub

    Private Sub iQuizTeacher_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        ToolStrip1.Renderer = New ToolStripRender

        If TypeOf ToolStrip1.Renderer Is ToolStripProfessionalRenderer Then
            CType(ToolStrip1.Renderer, ToolStripProfessionalRenderer).RoundedEdges = False
        End If
        Application.DoEvents()

        If My.Settings.isRegistered = True Then
            RegisterToolStripMenuItem.Enabled = False
        End If
        Try
            My.Computer.Registry.ClassesRoot.CreateSubKey(".quest").SetValue("", "iQuiz", Microsoft.Win32.RegistryValueKind.String)
            My.Computer.Registry.ClassesRoot.CreateSubKey("iQuiz\shell\open\command").SetValue("", Application.ExecutablePath & _
     " ""%l"" ", Microsoft.Win32.RegistryValueKind.String)
        Catch
            MsgBox("Due to restrictions on the host computer, iQuiz could not write to the registry. Therefore, all *.quest will NOT be automatically associated to iQuiz.", MsgBoxStyle.Exclamation, "Could Not Write to Registry")
        End Try
        RefreshQuizzes()

    End Sub

    Private Sub iQuizTeacher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        With My.Settings
            If .PastDay.ToShortDateString <> My.Computer.Clock.LocalTime.ToShortDateString Then
                .PastDay = My.Computer.Clock.LocalTime
                .DaysLeft -= 1
                My.Settings.Save()
                If .DaysLeft = 0 Then
                    Register.ShowDialog()
                End If
            End If
        End With
        If My.Settings.isRegistered = True Then
            Me.Text = "iQuiz Professional- Teacher's Edition"
        End If
    End Sub

    Private Sub iQuizTeacher_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        For Each item As ListViewItem In ListView1.Items
            If item.SubItems(2).Text = "Yes" Then
                If MessageBox.Show("It appears that some of your quizzes are being hosted at the moment. By quitting iQuiz, you are stopping all of the quizzes being hosted. This may disrupt any student currently taking the quiz. Do you wish to continue?", "Hmmm...", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                    Try
                        Dim username As String = My.User.Name.Split("\")(My.User.Name.Split("\").Length - 1)
                        DeleteFTPFile(username & "/" & item.Text & "/" & item.Text & ".quest")
                        For Each Filestr As String In ListFTPDirectories(username & "/Completed").Split(Chr(10))
                            DeleteFTPFile(username & "/" & Filestr.Replace(vbCr, ""))
                        Next
                        DeleteFTPDirectory(username & "/" & item.Text & "/Completed")
                        DeleteFTPDirectory(username & "/" & item.Text)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                Else
                    e.Cancel = True
                End If
            End If
        Next
    End Sub
    Private Sub iQuiz_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        RefreshQuizzes()
        My.Settings.StoredQuizzes = Nothing
        For Each item As ListViewItem In ListView1.Items
            My.Settings.StoredQuizzes &= item.Text & ";" & item.SubItems(1).Text & ";" & item.SubItems(2).Text & "|"
        Next
        Application.DoEvents()
        My.Settings.Save()
    End Sub

#End Region

#Region "TextBox Events"
    Private Sub TextBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.Enter
        Try
            If TextBox1.Text.Trim = TextBox1.Tag.ToString.Trim Then
                TextBox1.Clear()
                TextBox1.ForeColor = Color.Black
            End If

            For Each fi As String In My.Settings.StoredQuizzes.Split("|")
                list.Add(fi.Split(";")(0))
            Next
        Catch ex As Exception

        End Try

    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            If TextBox1.Text = TextBox1.Tag OrElse TextBox1.Text.Trim = "" Then
                RefreshQuizzes()
                Exit Sub
            End If
            ListView1.Items.Clear()
            For i As Integer = 0 To list.Count - 1
                If list(i).Contains(TextBox1.Text) Then

                    Dim path As String = My.Settings.StoredQuizzes.Split("|")(i).Split(";")(1)
                    Dim isHosting As String = My.Settings.StoredQuizzes.Split("|")(i).Split(";")(2)
                    Dim nList As New ListViewItem
                    nList.Text = list(i)
                    nList.SubItems.Add(path)
                    nList.SubItems.Add(isHosting)
                    ListView1.Items.Add(nList)

                End If
            Next
        Catch
        End Try
    End Sub
    Private Sub TextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Leave
        If TextBox1.Text.Trim = "" Then
            TextBox1.Text = TextBox1.Tag
            TextBox1.ForeColor = Color.DimGray
        End If
    End Sub
#End Region

#Region "ListView Events"

    Private Sub ListView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        Try
            Dim path As String = ListView1.SelectedItems(0).SubItems(1).Text & "\" & ListView1.SelectedItems(0).Text & ".quest"
            EditQuiz(path)
        Catch ex As IO.FileNotFoundException
            MsgBox("It appears that this file has been changed, moved, or no longer exists. Click ""Add Quiz"" or ""Refresh"" to reimport this quiz or remove it from the list")
        Catch ex As ArgumentException
            MsgBox("Please select or double-click a quiz to view it")
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message & ". Please contact Nickersoft at nickersoft@gmail.com.")
        End Try
    End Sub
#End Region

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ComboBox1.Enabled = False
        If ComboBox1.Text.Trim = "" Then
            MsgBox("Please select a quiz to grade.")
            ComboBox1.Enabled = True
            Exit Sub
        End If
        Try
            Dim username As String = My.User.Name.Split("\")(My.User.Name.Split("\").Length - 1)
            For Each quiz As String In ListFTPDirectories(username & "/" & ComboBox1.Text & "/Completed").Split(Chr(10))
                Dim studentName As String = quiz.Replace(vbCr, "").Split("/")(quiz.Split("/").Length - 1).Split(".")(0)
                Dim newItem As New ListViewItem
                newItem.Text = studentName
                newItem.Tag = quiz.Replace(vbCr, "")
            Next
        Catch ex As Exception
            MsgBox("Bummer! It looks like none of your students have finished the quiz yet! Better wait.", MsgBoxStyle.OkOnly, "No One Is Done Yet!")
        End Try
    End Sub

    Private Sub RegisterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterToolStripMenuItem.Click
        Register.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Settings.Reset()
    End Sub

    Private Sub ExitIQuizToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitIQuizToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ComboBox1.Enabled = False
        For i As Integer = 0 To ListView2.Items.Count - 1
            ListView2.Items(i).Selected = True

            Dim username As String = My.User.Name.Split("\")(My.User.Name.Split("\").Length - 1)
            Dim FileContents As String = DWNLDFTPInfo(username & "/" & ComboBox1.Text & "/Completed/" & ListView2.Items(i).Text & ".quest")
            Dim numOfProblems As Integer = FileContents.Split(Chr(10)).Length


            Dim answerArray As New List(Of String)
            For Each aLine As String In DWNLDFTPInfo(username & ComboBox1.Text & "/Completed/" & ListView2.Items(i).Text & ".quest").Split(Chr(10))

            Next
            For Each line As String In FileContents.Split(Chr(10)) 'Splits the lines of the quiz's contents into a string array
                Dim type() As String = line.Split(";") 'Splits the line into fields using the ';' divider

                'If line contains an essay...
                If type(0) = "[ESS" Then
                    Dim inner As List(Of String) = NewForm.GetTagContents(line, "[ESS", "/ESS]")
                    Dim disect() As String = inner(0).Split(";")

                    NewForm.AddESS(newquiz.OpenedQuiz, disect(1).Replace("<br>", Chr(10)), disect(2).Replace("<br>", Chr(10)), False, False)
                End If

                'If line contains a short answer...
                If type(0) = "[SA" Then
                    Dim inner As List(Of String) = NewForm.GetTagContents(line, "[SA", "/SA]")
                    Dim disect() As String = inner(0).Split(";")
                    NewForm.AddSA(newquiz.OpenedQuiz, disect(1), disect(2), False, False)
                End If

                'If line contains a multiple choice...
                If type(0) = "[MC" Then
                    Dim inner As List(Of String) = NewForm.GetTagContents(line, "[MC", "/MC]")
                    Dim disect() As String = inner(0).Split(";")
                    NewForm.AddMC(newquiz.OpenedQuiz, disect(1), disect(2), False)
                End If

                'If line contains a text field...
                If type(0) = "[TXT" Then
                    Dim inner As List(Of String) = NewForm.GetTagContents(line, "[TXT", "/TXT]")
                    Dim disect() As String = inner(0).Split(";")
                    NewForm.AddText(newquiz.OpenedQuiz, disect(1).Replace("<br>", Chr(10)), False)
                End If

                'If line contains a title...
                If type(0) = "[TIT" Then
                    Dim inner As List(Of String) = NewForm.GetTagContents(line, "[TIT", "/TIT]")
                    Dim disect() As String = inner(0).Split(";")
                    NewForm.AddTitle(newquiz.OpenedQuiz, disect(1), False)
                End If

                'If line contains a picture...
                If type(0) = "[PIC" Then
                    Dim inner As List(Of String) = NewForm.GetTagContents(line, "[PIC", "/PIC]")
                    Dim disect() As String = inner(0).Split(";")
                    NewForm.AddPic(newquiz.OpenedQuiz, disect(1), False, False, disect(2), disect(3))
                End If

                'If line contains a media file
                If line.Split("*")(0) = "[MED" Then
                    Dim inner As List(Of String) = NewForm.GetTagContents(line, "[MED", "/MED]")
                    Dim disect() As String = inner(0).Split("*")
                    NewForm.AddMedia(newquiz.OpenedQuiz, disect(1), disect(2), True)
                End If

                'If line contains a true or false question
                If type(0) = "[TF" Then
                    Dim inner As List(Of String) = NewForm.GetTagContents(line, "[TF", "/TF]")
                    Dim disect() As String = inner(0).Split(";")
                    If disect(2).Trim = "True" Then
                        NewForm.AddTF(newquiz.OpenedQuiz, disect(1), True, False, True)
                    Else
                        NewForm.AddTF(newquiz.OpenedQuiz, disect(1), False, False, True)
                    End If

                End If

                'If line contains a fill-in-the-blanks question...
                If type(0) = "[FB" Then
                    Dim inner As List(Of String) = NewForm.GetTagContents(line, "[FB", "/FB]")
                    Dim disect() As String = inner(0).Split(";")
                    NewForm.AddFitB(newquiz.OpenedQuiz, disect(1), disect(2), False)
                End If
            Next

            NewForm.RefreshNums(newquiz.OpenedQuiz)
            Application.DoEvents()

            newquiz.OpenedQuiz.Visible = True
        Next
    End Sub


End Class
Public Class ToolStripRender
    Inherits ToolStripProfessionalRenderer
    Public Sub New()
    End Sub
    Protected Overrides Sub OnRenderToolStripBorder(ByVal e As System.Windows.Forms.ToolStripRenderEventArgs)
    End Sub
    Protected Overrides Sub Initialize(ByVal toolStrip As System.Windows.Forms.ToolStrip)
        toolStrip.Renderer = New ToolStripProfessionalRenderer(New ToolStripColors)
        MyBase.Initialize(toolStrip)
    End Sub
End Class
Public Class ToolStripColors
    Inherits ProfessionalColorTable
    Public Sub New()
    End Sub
    Public Overrides ReadOnly Property ToolStripDropDownBackground() As System.Drawing.Color
        Get
            Return Color.Silver
        End Get
    End Property
    Public Overrides ReadOnly Property SeparatorDark() As System.Drawing.Color
        Get
            Return Color.DimGray
        End Get
    End Property
    Public Overrides ReadOnly Property SeparatorLight() As System.Drawing.Color
        Get
            Return Color.Gainsboro
        End Get
    End Property
    Public Overrides ReadOnly Property ImageMarginGradientBegin() As System.Drawing.Color
        Get
            Return Color.Transparent
        End Get
    End Property
    Public Overrides ReadOnly Property ImageMarginGradientEnd() As System.Drawing.Color
        Get
            Return Color.Transparent
        End Get
    End Property
    Public Overrides ReadOnly Property ImageMarginGradientMiddle() As System.Drawing.Color
        Get
            Return Color.Transparent
        End Get
    End Property
    Public Overrides ReadOnly Property ToolStripBorder() As System.Drawing.Color
        Get
            Return Color.Transparent
        End Get
    End Property
    Public Overrides ReadOnly Property ButtonSelectedBorder() As System.Drawing.Color
        Get
            Return Color.DimGray
        End Get
    End Property
    Public Overrides ReadOnly Property MenuItemBorder() As System.Drawing.Color
        Get
            Return Color.DimGray
        End Get
    End Property
    Public Overrides ReadOnly Property MenuItemSelected() As System.Drawing.Color
        Get
            Return Color.Gainsboro
        End Get
    End Property
    Public Overrides ReadOnly Property ButtonSelectedGradientBegin() As System.Drawing.Color
        Get
            Return Color.White
        End Get
    End Property
    Public Overrides ReadOnly Property ButtonSelectedGradientEnd() As System.Drawing.Color
        Get
            Return Color.Silver
        End Get
    End Property
    Public Overrides ReadOnly Property ButtonPressedBorder() As System.Drawing.Color
        Get
            Return Color.DimGray
        End Get
    End Property
    Public Overrides ReadOnly Property ButtonPressedGradientBegin() As System.Drawing.Color
        Get
            Return Color.White
        End Get
    End Property
    Public Overrides ReadOnly Property ButtonPressedGradientEnd() As System.Drawing.Color
        Get
            Return Color.SkyBlue
        End Get
    End Property
End Class