Public Class NewForm
    Dim activebox As Label
    Dim powerctrl As Control
    Dim addmore As New LinkLabel
    Public issaved As Boolean = True
#Region "Public Functions"

    Public Sub AddNames()
        Dim newname As New Names
        newname.BorderStyle = BorderStyle.None
        newname.Visible = True
        newname.Dock = DockStyle.Top
        newname.Width = Quiz.Width - (newname.Width / 2)
        Quiz.Controls.Add(newname)
    End Sub
    Public Sub AddTitle(ByVal Parent As FlowLayoutPanel, ByVal TitleText As String, ByVal AllowRightClick As Boolean)

        Dim title As New TitleorText
        title.BorderStyle = BorderStyle.None
        title.AutoSize = True
        title.ContextMenuStrip1.Items(2).Text = "Delete Title"
        title.Tag = "title"
        If AllowRightClick = False Then
            title.ContextMenu = Nothing
        End If
        If AllowRightClick = False Then
            title.showMenu = False
        End If
        Dim newlabel As New Label
        newlabel.AutoSize = False
        newlabel.Width = Parent.Width - (newlabel.Width / 2)
        newlabel.TextAlign = ContentAlignment.MiddleCenter
        newlabel.BackColor = Color.Transparent
        newlabel.Font = New Font(newtext.Font.Name, 14, FontStyle.Bold)
        newlabel.Text = TitleText
        newlabel.Tag = "title;" & TitleText
        title.FlowLayoutPanel1.Controls.Add(newlabel)
        title.Padding = New Padding(3, 3, 3, 3)
        Parent.Controls.Add(title)
        refreshnums(Quiz)
    End Sub
    Public Sub AddText(ByVal Parent As FlowLayoutPanel, ByVal TextString As String, ByVal AllowRightClick As Boolean)

        Dim text As New TitleorText
        text.BorderStyle = BorderStyle.None
        text.AutoSize = True

        If AllowRightClick = False Then
            text.ContextMenu = Nothing
        End If
        text.ContextMenuStrip1.Items(2).Text = "Delete Text"
        Dim newlabel As New Label
        If AllowRightClick = False Then
            text.showMenu = False
        End If
        newlabel.BackColor = Color.Transparent
        newlabel.Font = New Font(TxtField.Font.Name, 8, FontStyle.Regular)
        newlabel.Text = TextString
        text.Tag = "text;" & TextString.Replace(Chr(10), "<br>")
        newlabel.Width = Parent.Width - (newlabel.Width / 2)
        Dim szf As SizeF = newlabel.CreateGraphics.MeasureString(newlabel.Text, newlabel.Font, newlabel.Width)
        newlabel.Height = szf.Height + 5
        text.FlowLayoutPanel1.Controls.Add(newlabel)
        Parent.Controls.Add(text)
        refreshnums(Quiz)
    End Sub
    Public Sub AddMC(ByVal Parent As FlowLayoutPanel, ByVal MCQuestion As String, ByVal MCAnswers As String, ByVal AllowRightClick As Boolean)
        Dim i As Integer = 0
        If AllowRightClick = True Then
            For Each item As String In MCAnswers.Split(",")
                If InStr(item.Trim, "*") Then
                    i += 1
                End If
            Next
            If i = 0 Then
                MsgBox("Please place an asterisk(*) after the correct answer.")
                MCChoices.Focus()
                Exit Sub
            End If
            If i > 1 Then
                MsgBox("You can only select one right answer!")
                MCChoices.Focus()
                Exit Sub
            End If
        End If

        Dim MultiChoice As New Question
        MultiChoice.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        MultiChoice.BorderStyle = BorderStyle.None
        MultiChoice.typeOfQuestion = "mc"
        Dim lbl As New Label
        lbl.Font = New Font(newtext.Font, FontStyle.Bold)
        lbl.Text = MCQuestion
        lbl.Tag = MCQuestion
        lbl.AutoSize = True
        lbl.Margin = New Padding(3, 3, 3, 3)
        MultiChoice.FlowLayoutPanel1.Controls.Add(lbl)
        If AllowRightClick = False Then
            MultiChoice.showMenu = False
        End If
        Dim Choices() As String = MCAnswers.Split(",")
        For Each choice As String In Choices
            Dim newchoice As New RadioButton
            newchoice.Margin = New Padding(3, 0, 3, 0)
            newchoice.BackColor = Color.Transparent
            newchoice.Text = choice

            If InStr(newchoice.Text, "*") AndAlso (AllowRightClick = True) Then
                newchoice.Checked = True
            End If

            newchoice.Text = choice.Replace("*", "")
            If AllowRightClick = True Then
                newchoice.Enabled = False
            End If
            newchoice.AutoSize = True
            MultiChoice.FlowLayoutPanel1.SetFlowBreak(newchoice, True)
            MultiChoice.FlowLayoutPanel1.Controls.Add(newchoice)
        Next
        Dim str As String = ""
        For Each choice As String In Choices
            If InStr(choice, "*") Then
                str = choice
            End If
        Next
        MultiChoice.Tag = "MC;" & MCQuestion.Replace("*", "") & ";" & MCAnswers & ";" & str

        Parent.Controls.Add(MultiChoice)
        refreshnums(Quiz)

    End Sub
    Public Sub AddSA(ByVal Parent As FlowLayoutPanel, ByVal SAQuestion As String, ByVal SAAnswer As String, ByVal ShowAnswer As Boolean, ByVal AllowRightClick As Boolean)

        Dim ShortAnswer As New Question
        ShortAnswer.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        ShortAnswer.BorderStyle = BorderStyle.None
        Dim lbl As New Label
        lbl.Font = New Font(newtext.Font, FontStyle.Bold)
        lbl.Text = SAQuestion
        lbl.Tag = SAQuestion
        lbl.AutoSize = True
        lbl.Margin = New Padding(3, 3, 3, 3)
        ShortAnswer.FlowLayoutPanel1.Controls.Add(lbl)
        If AllowRightClick = False Then
            ShortAnswer.showMenu = False
        End If
        Dim ntxt As New TextBox
        If ShowAnswer = True Then
            ntxt.Text = SAAnswer
            ntxt.Enabled = False
        Else
            ntxt.Text = ""
            ntxt.Enabled = True
        End If

        ntxt.Font = SAans.Font

        ntxt.BackColor = Color.White
        ntxt.Width = SAAnswer.Length * 10
        ntxt.Margin = New Padding(15, 3, 3, 3)

        ShortAnswer.FlowLayoutPanel1.Controls.Add(ntxt)
        ShortAnswer.Tag = "SA;" & SAQuestion & ";" & SAAnswer
        Parent.Controls.Add(ShortAnswer)
        refreshnums(Quiz)
    End Sub
    Public Sub AddESS(ByVal Parent As FlowLayoutPanel, ByVal ESSQuestion As String, ByVal ESSAnswer As String, ByVal ShowAnswer As Boolean, ByVal AllowRightClick As Boolean)

        Dim essayq As New Question
        Dim lbl As New Label
        lbl.Font = New Font(newtext.Font, FontStyle.Bold)
        lbl.Text = ESSQuestion
        lbl.Tag = ESSQuestion
        lbl.AutoSize = True
        lbl.Margin = New Padding(3, 3, 3, 3)
        essayq.FlowLayoutPanel1.Controls.Add(lbl)
        If AllowRightClick = False Then
            essayq.showMenu = False
        End If
        Dim ntxt As New TextBox
        If ShowAnswer = True Then
            ntxt.Text = ESSAnswer
            ntxt.Size = TxtField.Size
            ntxt.Enabled = False
        Else
            ntxt.Text = ""
            ntxt.Size = New Size(TxtField.Width * 2, TxtField.Height * 2)
            ntxt.Enabled = True
        End If

        ntxt.Font = EssayAnswer.Font
        ntxt.Multiline = True
        ntxt.ScrollBars = ScrollBars.Vertical
        ntxt.BackColor = Color.White

        ntxt.Margin = New Padding(15, 3, 3, 3)
        essayq.FlowLayoutPanel1.Controls.Add(ntxt)

        essayq.BorderStyle = BorderStyle.None
        essayq.Tag = "ESS;" & ESSQuestion.Replace(vbCrLf, "<br>") & ";" & ESSAnswer.Replace(vbCrLf, "<br>")
        Parent.Controls.Add(essayq)

        refreshnums(Parent)
    End Sub
    Public Sub AddPic(ByVal Parent As FlowLayoutPanel, ByVal ImgPath As String, ByVal DoAutosize As Boolean, ByVal AllowRightClick As Boolean, Optional ByVal Width As Integer = 0, Optional ByVal Height As Integer = 0)
        Try
            Dim np As New NewPic
            Dim img As Image = Image.FromFile(ImgPath)
            np.BackgroundImageLayout = ImageLayout.Stretch
            np.BackgroundImage = img
            np.Tag = "PIC;" & ImgPath
            If AllowRightClick = False Then
                np.showMenu = False
                np.BorderStyle = BorderStyle.None
            End If
            If DoAutosize = False Then
                np.Width = Width
                np.Height = Height
            End If

            Parent.Controls.Add(np)
            RefreshNums(Quiz)
        Catch
            MsgBox("The inserted image's file type is not one that iQuiz understands.")
        End Try
    End Sub
    Public Sub AddMatching(ByVal Parent As FlowLayoutPanel, ByVal mquestions As String, ByVal mchoices As String, ByVal AllowRightClick As Boolean, ByVal isFirstTime As Boolean)

        Dim MatchingQ As New Question
        MatchingQ.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        MatchingQ.BorderStyle = BorderStyle.None
        MatchingQ.FlowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight
        MatchingQ.FlowLayoutPanel1.WrapContents = True
        If AllowRightClick = False Then
            MatchingQ.showMenu = False
        End If

        Dim qArray As New List(Of String)
        Dim aArray As New List(Of String)

        For Each item As String In mquestions.Split(",")
            qArray.Add(item)

        Next

        For Each item As String In mchoices.Split(",")
            aArray.Add(item)

        Next

        For i As Integer = 0 To qArray.Count - 1
            Try
                If qArray(i).Trim <> "" AndAlso aArray(i).Trim <> "" Then
                    Dim lbl As New Label
                    lbl.AutoSize = True
                    lbl.Text = qArray(i)
                    Dim combo As New ComboBox
                    MatchingQ.FlowLayoutPanel1.Controls.Add(lbl)

                    Dim pastStr As String = ""
                    Dim randArray As New List(Of String)
                    Dim rand As New Random
                    Do Until randArray.Count = aArray.Count

                        Dim randInt As Integer = rand.Next(0, aArray.Count - 1)
                        If aArray(randInt) <> pastStr Then
                            randArray.Add(aArray(randInt))
                            pastStr = aArray(randInt)
                        End If
                    Loop

                    For Each item As String In randArray
                        combo.Items.Add(item)
                    Next
                    MatchingQ.FlowLayoutPanel1.SetFlowBreak(combo, True)
                    MatchingQ.FlowLayoutPanel1.Controls.Add(combo)
                End If

            Catch ex As Exception

            End Try

        Next


        MatchingQ.Tag = "MCH;" & mquestions & ";" & mchoices
        Parent.Controls.Add(MatchingQ)
    End Sub
    Public Sub AddMedia(ByVal Parent As FlowLayoutPanel, ByVal MPath As String, ByVal AudOrVid As String, ByVal AllowRightClick As Boolean)
        Try
            Dim mediaPlayer As New NewVidAud

            Select Case AudOrVid
                Case "aud"
                    mediaPlayer.Size = New Size(460, 45)
                Case "vid"
                    mediaPlayer.Size = New Size(460, 340)
            End Select

            mediaPlayer.AxWindowsMediaPlayer1.URL = MPath
            mediaPlayer.Tag = "MED*" & MPath & "*" & AudOrVid
            Parent.Controls.Add(mediaPlayer)
            mediaPlayer.AxWindowsMediaPlayer1.Ctlcontrols.stop()
        Catch ex As Exception
            MsgBox("The inserted media's file type is not one that iQuiz understands.")
        End Try

    End Sub
    Public Sub AddTF(ByVal Parent As FlowLayoutPanel, ByVal TFQuestion As String, ByVal isTrue As Boolean, ByVal AllowRightClick As Boolean, ByVal isOpened As Boolean)
        Dim i As Integer = 0
        If isOpened = False Then
            If TFQuestBox.Text = TFQuestBox.Tag Then
                MsgBox("Please enter a true or false statement.")
                Exit Sub
            End If

            If TrueRadio.Checked = False AndAlso FalseRadio.Checked = False Then
                MsgBox("Please mark the statement as either being true or false.")
                Exit Sub
            End If
        End If

        Dim TrueFalse As New Question
        TrueFalse.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        TrueFalse.BorderStyle = BorderStyle.None
        TrueFalse.typeOfQuestion = "tf"
        Dim lbl As New Label
        lbl.Font = New Font(newtext.Font, FontStyle.Bold)
        lbl.Text = TFQuestion
        lbl.Tag = TFQuestion
        lbl.AutoSize = True
        lbl.Margin = New Padding(3, 3, 3, 3)
        TrueFalse.FlowLayoutPanel1.Controls.Add(lbl)

        If AllowRightClick = False Then
            TrueFalse.showMenu = False
        End If

        'Add True Radio Button
        Dim truechoice As New RadioButton
        truechoice.Margin = New Padding(3, 0, 3, 0)
        truechoice.BackColor = Color.Transparent
        truechoice.Text = "True"

        If isTrue = True AndAlso (AllowRightClick = True) Then
            truechoice.Checked = True
        End If

        If AllowRightClick = True Then
            truechoice.Enabled = False
        End If
        truechoice.AutoSize = True
        TrueFalse.FlowLayoutPanel1.SetFlowBreak(truechoice, True)
        TrueFalse.FlowLayoutPanel1.Controls.Add(truechoice)

        'Add False Radio Button
        Dim falsechoice As New RadioButton
        falsechoice.Margin = New Padding(3, 0, 3, 0)
        falsechoice.BackColor = Color.Transparent
        falsechoice.Text = "False"

        If isTrue = False AndAlso (AllowRightClick = True) Then
            falsechoice.Checked = True
        End If

        If AllowRightClick = True Then
            falsechoice.Enabled = False
        End If
        falsechoice.AutoSize = True
        TrueFalse.FlowLayoutPanel1.SetFlowBreak(falsechoice, True)
        TrueFalse.FlowLayoutPanel1.Controls.Add(falsechoice)

        TrueFalse.Tag = "TF;" & TFQuestion & ";" & isTrue

        Parent.Controls.Add(TrueFalse)
        RefreshNums(Quiz)

    End Sub
    Public Sub AddFitB(ByVal Parent As FlowLayoutPanel, ByVal Statement As String, ByVal Words2Replace As String, ByVal AllowRightClick As Boolean)
        Dim FitB As New Question
        FitB.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        FitB.BorderStyle = BorderStyle.None
        Dim lbl As New Label
        lbl.Font = New Font(newtext.Font, FontStyle.Bold)
        For Each word As String In Words2Replace.Split(",")
            If word.Trim <> "" Then
                Dim fillStr As String = ""
                For i As Integer = 0 To word.Length - 1
                    fillStr &= "_"
                Next
                Statement = System.Text.RegularExpressions.Regex.Replace(Statement, "\b" & word & "\b", fillStr)
            End If
        Next
        lbl.Text = Statement
        lbl.Tag = Statement
        lbl.AutoSize = True
        lbl.Margin = New Padding(3, 3, 3, 3)
        FitB.FlowLayoutPanel1.Controls.Add(lbl)
        If AllowRightClick = False Then
            FitB.showMenu = False
        End If
        Dim ntxt As New TextBox
        If AllowRightClick = True Then
            ntxt.Text = Words2Replace.Replace(",", ", ")
            ntxt.Enabled = False
        Else
            ntxt.Text = ""
            ntxt.Enabled = True
        End If

        ntxt.Font = SAans.Font

        ntxt.BackColor = Color.White
        ntxt.Width = ntxt.CreateGraphics().MeasureString(Words2Replace, ntxt.Font).Width
        ntxt.Margin = New Padding(15, 3, 3, 3)

        FitB.FlowLayoutPanel1.Controls.Add(ntxt)
        FitB.Tag = "FB;" & Statement & ";" & Words2Replace
        Parent.Controls.Add(FitB)
        RefreshNums(Quiz)
    End Sub
    Public Function GetTagContents(ByVal Source As String, ByVal startTag As String, ByVal endTag As String) As List(Of String)
        Dim StringsFound As New List(Of String)
        Dim Index As Integer = Source.IndexOf(startTag) + startTag.Length
        While Index <> startTag.Length - 1
            StringsFound.Add(Source.Substring(Index, Source.IndexOf(endTag, Index) - Index))
            Index = Source.IndexOf(startTag, Index) + startTag.Length
        End While

        Return StringsFound

    End Function
    Public Sub RefreshNums(ByVal parent As FlowLayoutPanel)
        Dim i As Integer = 1
        For Each ctrl As Control In parent.Controls
            If TypeOf ctrl Is Question Then
                For Each flow As Control In ctrl.Controls
                    If TypeOf flow Is FlowLayoutPanel Then
                        For Each lbl As Control In flow.Controls
                            If TypeOf lbl Is Label Then
                                lbl.Text = i & ". " & lbl.Tag
                                i += 1
                            End If
                        Next
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub SaveDemMos(ByVal filePath As String)

        If IO.File.Exists(filePath) Then
            IO.File.Delete(filePath)
        End If

        Dim streamwrite As New IO.StreamWriter(filePath, False)
        Dim masterfile As String = ""
        ToolStripStatusLabel1.Text = "Saving..."
        ToolStripProgressBar1.Visible = True
        Application.DoEvents()

        For Each ctrl As Control In Quiz.Controls
            If TypeOf ctrl Is Names Then
                masterfile = masterfile & "[name]" & vbCrLf
            End If
            If TypeOf ctrl Is TitleorText Then
                For Each flow As Control In ctrl.Controls
                    If TypeOf flow Is FlowLayoutPanel Then
                        For Each tot As Control In flow.Controls
                            If TypeOf tot Is Label Then
                                If tot.Font.Style = FontStyle.Bold Then
                                    masterfile = masterfile & "[TIT;" & tot.Text & " /TIT]" & vbCrLf
                                Else
                                    Dim modified As String = tot.Text.Replace(Chr(10), "<br>")
                                    masterfile = masterfile & "[TXT;" & modified & " /TXT]" & vbCrLf
                                End If
                            End If
                        Next
                    End If
                Next

            End If

            If TypeOf ctrl Is Question Then
                Dim disect() As String = ctrl.Tag.ToString.Split(";")
                If disect(0) = "SA" Then
                    masterfile = masterfile & "[SA;" & disect(1) & ";" & disect(2) & " /SA]" & vbCrLf
                End If
                If disect(0) = "MC" Then
                    masterfile = masterfile & "[MC;" & disect(1) & ";" & disect(2) & ";" & disect(3) & " /MC]" & vbCrLf
                End If
                If disect(0) = "ESS" Then
                    masterfile = masterfile & "[ESS;" & disect(1) & ";" & disect(2) & " /ESS]" & vbCrLf
                End If
                If disect(0) = "TF" Then
                    masterfile = masterfile & "[TF;" & disect(1) & ";" & disect(2) & " /TF]" & vbCrLf
                End If
                If disect(0) = "FB" Then
                    masterfile = masterfile & "[FB;" & disect(1) & ";" & disect(2) & " /FB]" & vbCrLf
                End If
            End If

            If TypeOf ctrl Is NewPic Then
                Dim disect() As String = ctrl.Tag.ToString.Split(";")
                masterfile = masterfile & "[PIC;" & disect(1) & ";" & ctrl.Width & ";" & ctrl.Height & " /PIC]" & vbCrLf
            End If

            If TypeOf ctrl Is NewVidAud Then
                Dim disect() As String = ctrl.Tag.ToString.Split("*")
                masterfile = masterfile & "[MED*" & disect(1) & "*" & disect(2) & "/MED]" & vbCrLf
            End If

        Next
        streamwrite.Write(masterfile)
        streamwrite.Close()
        Timer1.Stop()
        ToolStripProgressBar1.Value = 100
        Application.DoEvents()
        ToolStripProgressBar1.Visible = False
        ToolStripStatusLabel1.Text = "Last saved: " & My.Computer.Clock.LocalTime.Date.ToShortDateString & " at " & My.Computer.Clock.LocalTime.ToShortTimeString
        issaved = True
        Application.DoEvents()
    End Sub
#End Region

#Region "Button Events"

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AddText(Quiz, TxtField.Text, True)
        TxtField.Clear()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If quizname.Tag = "" Then
            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                SaveDemMos(SaveFileDialog1.FileName)
                Dim newquizitem As New ListViewItem(IO.Path.GetFileNameWithoutExtension(SaveFileDialog1.FileName))
                newquizitem.SubItems.Add(IO.Path.GetDirectoryName(SaveFileDialog1.FileName))
                newquizitem.SubItems.Add("No")
                iQuizTeacher.ListView1.Items.Add(newquizitem)
                quizname.Text = IO.Path.GetFileNameWithoutExtension(SaveFileDialog1.FileName)
                quizname.Tag = SaveFileDialog1.FileName
            End If
        Else
            Try
                SaveDemMos(quizname.Tag)
            Catch ex As Exception
                MsgBox("There was an error saving your quiz. Please save it as a new file.")
                If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                    SaveDemMos(SaveFileDialog1.FileName)
                    Dim newquizitem As New ListViewItem(IO.Path.GetFileNameWithoutExtension(SaveFileDialog1.FileName))
                    newquizitem.SubItems.Add(IO.Path.GetDirectoryName(SaveFileDialog1.FileName))
                    newquizitem.SubItems.Add("No")
                    iQuizTeacher.ListView1.Items.Add(newquizitem)
                    quizname.Text = IO.Path.GetFileNameWithoutExtension(SaveFileDialog1.FileName)
                    quizname.Tag = SaveFileDialog1.FileName
                End If
            End Try
        End If

    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        AddTitle(Quiz, newtext.Text, True)
        newtext.Clear()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        AddMC(Quiz, MultiChoiceQuestion.Text, MCChoices.Text, True)
        MultiChoiceQuestion.Clear()
        MCChoices.Clear()
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        AddSA(Quiz, SAtxt.Text, SAans.Text, True, True)
        SAtxt.Clear()
        SAans.Clear()
    End Sub
    Private Sub Button6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button6.Click
        If OpenPic.ShowDialog = Windows.Forms.DialogResult.OK Then
            AddPic(Quiz, OpenPic.FileName, True, True)
        End If
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        AddESS(Quiz, EssayQuest.Text, EssayAnswer.Text, True, True)
        EssayQuest.Clear()
        EssayAnswer.Clear()
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim theQuizName As String = quizname.Text
        If quizname.Tag Is Nothing Then
            theQuizName = "Untitled"
        End If
        If issaved = False Then
            If MessageBox.Show("""" & theQuizName & """ is not saved. Are you sure you want to close?", "Close Quiz?", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Me.Close()
            Else
                Exit Sub
            End If
        Else
            Me.Close()
        End If
    End Sub
    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        If OpenVid.ShowDialog = Windows.Forms.DialogResult.OK Then
            AddMedia(Quiz, OpenVid.FileName, "vid", True)
        End If
    End Sub
    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        If OpenAud.ShowDialog = Windows.Forms.DialogResult.OK Then
            AddMedia(Quiz, OpenAud.FileName, "aud", True)
        End If
    End Sub

#End Region

#Region "TextBox Events"

    Private Sub TextBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MultiChoiceQuestion.Click
        If MultiChoiceQuestion.Text = "Enter a question here" Then
            MultiChoiceQuestion.Clear()
        End If
    End Sub
    Private Sub MCChoices_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MCChoices.Click
        If MCChoices.Text = "Type your choices here*" Then
            MCChoices.Clear()
        End If
    End Sub
    Private Sub newtext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newtext.Click
        If newtext.Text = "Type your title here" Then
            newtext.Clear()
        End If

    End Sub
    Private Sub TxtField_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtField.Click
        If TxtField.Text = "Type your text here" Then
            TxtField.Clear()
        End If
    End Sub
    Private Sub SAtxt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SAtxt.Click
        If SAtxt.Text = "Type your question here" Then
            SAtxt.Clear()
        End If
    End Sub
    Private Sub SAans_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SAans.Click
        If SAans.Text = "Type your answer here*" Then
            SAans.Clear()
        End If
    End Sub
    Private Sub EssayQuest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EssayQuest.Click
        If EssayQuest.Text = "Type your essay question here" Then
            EssayQuest.Clear()
        End If
    End Sub
    Private Sub EssayAnswer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EssayAnswer.Click
        If EssayAnswer.Text = "Type an example answer here (will not be shown to students)" Then
            EssayAnswer.Clear()
        End If
    End Sub

#End Region

    Private Sub StatusStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ToolStripProgressBar1.Visible = True
        Do Until ToolStripProgressBar1.Value = 100
            ToolStripProgressBar1.Increment(1)
        Loop
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim isTrue As Boolean = False
        If TrueRadio.Checked = True Then
            isTrue = True
        End If
        AddTF(Quiz, TFQuestBox.Text, isTrue, True, False)
        TFQuestBox.Clear()
        TrueRadio.Checked = False
        FalseRadio.Checked = False
    End Sub

    Private Sub Quiz_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Quiz.Paint
        issaved = False
    End Sub

    Private Sub TFQuestBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TFQuestBox.Click
        If TFQuestBox.Text.Trim = TFQuestBox.Tag.ToString.Trim Then
            TFQuestBox.Clear()
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim newMatch As New ListViewItem
        newMatch.Text = MatchStatement.Text
        newMatch.SubItems.Add(MatchAnswer.Text)
        MatchBox.Items.Add(newMatch)
        MatchStatement.Clear()
        MatchAnswer.Clear()
        Application.DoEvents()
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FBStatement.TextChanged
        If FBStatement.Text = FBStatement.Tag OrElse FBStatement.Text.Trim = "" Then
            Exit Sub
        End If
        ListView1.Items.Clear()
        For Each word As String In FBStatement.Text.Split(" ")
            ListView1.Items.Add(word)
        Next
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Try
            Dim words2replace As String = ""
            For i As Integer = 0 To ListView1.SelectedItems.Count - 1
                words2replace &= ListView1.SelectedItems(i).Text & ","
            Next
            words2replace.Remove(words2replace.Length - 1, 1)
            AddFitB(Quiz, FBStatement.Text, words2replace, True)
        Catch
            MsgBox("Please select some words to remove")
        End Try
    End Sub

    Private Sub FBStatement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FBStatement.Click
        If FBStatement.Text.Trim = FBStatement.Tag.ToString.Trim Then
            FBStatement.Clear()
        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        If MatchBox.Items.Count = 0 Then
            MsgBox("Please enter at least one statement and answer.")
            Exit Sub
        End If
        Dim stateList As String = ""
        Dim choiceList As String = ""
        For Each item As ListViewItem In MatchBox.Items
            stateList &= item.Text & ","
            choiceList &= item.SubItems(1).Text & ","
        Next
        choiceList.Remove(choiceList.Length - 1, 1)
        stateList.Remove(stateList.Length - 1, 1)
        AddMatching(Quiz, stateList, choiceList, True, True)
    End Sub
End Class