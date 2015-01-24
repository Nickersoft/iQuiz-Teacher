Public Class Register
    Dim inputKey As String = ""
    Dim keyList As New List(Of String)
    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        TextBox2.Text = TextBox2.Text.ToUpper
        TextBox2.SelectionStart = TextBox2.Text.Length
        If TextBox2.Text.Length = TextBox2.MaxLength Then
            Me.SelectNextControl(TextBox2, True, True, True, False)
            CheckKeys()
        End If
    End Sub

    Private Sub TextBox3_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.Enter
        TextBox3.Clear()
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        TextBox3.Text = TextBox3.Text.ToUpper
        TextBox3.SelectionStart = TextBox3.Text.Length
        If TextBox3.Text.Length = TextBox4.MaxLength Then
            Me.SelectNextControl(TextBox3, True, True, True, False)
            CheckKeys()
        End If

    End Sub

    Private Sub TextBox4_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox4.Enter
        TextBox4.Clear()
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        TextBox4.Text = TextBox4.Text.ToUpper
        TextBox4.SelectionStart = TextBox4.Text.Length
        If TextBox4.Text.Length = TextBox4.MaxLength Then
            Me.SelectNextControl(TextBox4, True, True, True, False)
            CheckKeys()
        End If

    End Sub
    Public Sub CheckKeys()
        Button5.Enabled = False
        PictureBox1.Visible = False
        If TextBox2.Text.Trim <> "" AndAlso TextBox3.Text.Trim <> "" AndAlso TextBox4.Text.Trim <> "" AndAlso TextBox5.Text.Trim <> "" Then
            For i As Integer = 0 To keyList.Count - 1
                If keyList(i).Trim = Label5.Text & TextBox2.Text.Trim & "-" & TextBox3.Text.Trim & "-" & TextBox4.Text.Trim & "-" & TextBox5.Text.Trim Then
                    PictureBox1.Visible = True
                    Button5.Enabled = True
                    inputKey = Label5.Text & TextBox2.Text.Trim & "-" & TextBox3.Text.Trim & "-" & TextBox4.Text.Trim & "-" & TextBox5.Text.Trim
                    Exit Sub
                End If
            Next

        End If
    End Sub

    Private Sub TextBox5_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox5.Enter
        TextBox5.Clear()
    End Sub
    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        TextBox5.Text = TextBox5.Text.ToUpper
        TextBox5.SelectionStart = TextBox5.Text.Length
        If TextBox5.Text.Length = TextBox5.MaxLength Then
            Me.SelectNextControl(TextBox5, True, True, True, False)
            CheckKeys()
        End If

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            If TextBox1.Text.Trim = "" Then
                MsgBox("Please enter your full name.")
                Exit Sub
            End If
            My.Settings.isRegistered = True
            My.Settings.RegisteredName = TextBox1.Text.Trim
            My.Settings.Save()
            Application.DoEvents()

            Dim newKeyList As String = ""
            For Each key As String In keyList
                If key <> inputKey Then
                    newKeyList &= key & Environment.NewLine
                End If
            Next
            Dim wc As New Net.WebClient
            wc.Credentials = New Net.NetworkCredential("username", "password")
            wc.UploadString("ftp://ftp.cwahi.net/iQuiz%20Pro/keys.txt", newKeyList)
            Application.DoEvents()

            MsgBox("Thank you for registering iQuiz!")
            iQuizTeacher.RegisterToolStripMenuItem.Enabled = False
            Me.Close()
        Catch
            MsgBox("Could not register at this time. Please try again later.")
            Me.Close()
        End Try
    End Sub

    Private Sub Register_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Dim picBox As New PictureBox
        picBox.Image = My.Resources.generator
        picBox.SizeMode = PictureBoxSizeMode.CenterImage
        picBox.Dock = DockStyle.Fill
        picBox.WaitOnLoad = True
        Me.Controls.Add(picBox)
        picBox.BringToFront()
        Application.DoEvents()

        TrialLabel.Text = String.Format("You have {0} days left to your free trial.", My.Settings.DaysLeft)
        BackgroundWorker1.RunWorkerAsync()
        Application.DoEvents()

        Me.Controls.Remove(picBox)
        Application.DoEvents()
    End Sub

    Private Sub TextBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.Enter
        TextBox2.Clear()
    End Sub

    Private Sub Register_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If My.Settings.DaysLeft = 0 Then
            Application.Exit()
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim wc As New Net.WebClient
        wc.Credentials = New Net.NetworkCredential("username", "password")
        Dim keysList As String = wc.DownloadString("ftp://ftp.cwahi.net/iQuiz%20Pro/keys.txt")
        For Each key As String In keysList.Split(Environment.NewLine)
            keyList.Add(key)
        Next
        Application.DoEvents()

    End Sub
End Class
