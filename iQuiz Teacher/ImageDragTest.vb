Imports System.Threading
Imports System.Text.RegularExpressions
Public Class ImageDragTest

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            PictureBox1.Tag = OpenFileDialog1.FileName
        End If
    End Sub
    Dim x As Integer
    Dim y As Integer
    Dim isdraggin As Boolean
    Dim currentx, currenty As Integer

    Private Sub PictureBox1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        isdraggin = True
        currentx = e.X
        currenty = e.Y
    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        If (isdraggin = True) Then
            PictureBox1.Top = PictureBox1.Top + (e.Y - currenty)
            PictureBox1.Left = PictureBox1.Left + (e.X - currentx)
        End If
    End Sub

    Private Sub PictureBox1_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
        isdraggin = False
    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        PictureBox1.Image = Nothing
        PictureBox1.Size = New Size(240, 215)
        PictureBox1.Location = New Point(12, 69)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        PictureBox1.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox2.Text = "[img= " & PictureBox1.Tag & "," & PictureBox1.Height & "," & PictureBox1.Width & "," & PictureBox1.Location.X & "," & PictureBox1.Location.Y & " /img]"
    End Sub
    Private Function GetTagContents(ByVal Source As String, ByVal startTag As String, ByVal endTag As String) As List(Of String)
        Dim StringsFound As New List(Of String)
        Dim Index As Integer = Source.IndexOf(startTag) + startTag.Length

        While Index <> startTag.Length - 1
            StringsFound.Add(Source.Substring(Index, Source.IndexOf(endTag, Index) - Index))
            Index = Source.IndexOf(startTag, Index) + startTag.Length
        End While

        Return StringsFound
    End Function

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        PictureBox1.Hide()

        For Each msg As String In GetTagContents(TextBox2.Text, "[img=", "/img]")
            Dim arr() As String = msg.Split(",")
            Dim pic As New PictureBox
            pic.Image = Image.FromFile(arr(0))
            pic.Size = New Size(arr(2), arr(1))
            pic.Location = New Point(arr(3), (arr(4)))
            pic.SizeMode = PictureBoxSizeMode.StretchImage
            Me.Controls.Add(pic)
        Next

    End Sub

    Dim doresize As Boolean
    Dim currentx2 As Integer
    Dim currenty2 As Integer
    Private Sub PictureBox2_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseDown
        doresize = True
        currentx2 = e.X
        currenty2 = e.Y
    End Sub

    Private Sub PictureBox2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseMove
        If doresize = True Then
            If e.X < currentx Then
                PictureBox1.Width = PictureBox1.Width - (currentx - e.X)
                currentx = e.X
            End If

            If e.X > currentx Then
                PictureBox1.Width = PictureBox1.Width + (e.X - currentx)
                currentx = e.X
            End If

            If e.Y < currenty Then
                PictureBox1.Height = PictureBox1.Height - (currenty - e.Y)
                currenty = e.Y

            End If

            If e.Y > currenty Then
                PictureBox1.Height = PictureBox1.Height + (e.Y - currenty)
                currenty = e.Y
            End If
        End If
    End Sub

    Private Sub PictureBox2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseUp
        doresize = False
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub ImageDragTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class