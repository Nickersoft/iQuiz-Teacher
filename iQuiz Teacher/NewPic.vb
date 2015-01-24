Public Class NewPic
    Dim doresize As Boolean
    Dim currentx As Integer
    Dim currenty As Integer

    Public showMenu As Boolean = True

    Private Sub Panel1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseUp, Panel2.MouseUp
        doresize = False
        Me.Tag = Me.Tag.split(";")(0) & ";" & Me.Tag.split(";")(1) & ";" & Me.Width & ";" & Me.Height

    End Sub


    Private Sub Panel1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove, Panel2.MouseMove
        If doresize = True Then

            If e.X < currentx Then
                Me.Width = Me.Width - (currentx - e.X)

            End If

            If e.X > currentx Then
                Me.Width = Me.Width + (e.X - currentx)

            End If

            If e.Y < currenty Then
                Me.Height = Me.Height - (currenty - e.Y)


            End If

            If e.Y > currenty Then
                Me.Height = Me.Height + (e.Y - currenty)

            End If
        End If
    End Sub

    Private Sub Panel1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown, Panel2.MouseDown
        doresize = True
        currentx = e.X
        currenty = e.Y
    End Sub

    Private Sub DeleteImageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteImageToolStripMenuItem.Click
        Me.Parent.Controls.Remove(Me)
    End Sub

    Private Sub MoveUpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoveUpToolStripMenuItem.Click
        Dim curpos As Integer = Me.Parent.Controls.GetChildIndex(Me)
        Me.Parent.Controls.SetChildIndex(Me, curpos - 1)
        NewForm.refreshnums(Me.Parent)
    End Sub

    Private Sub MoveDownToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoveDownToolStripMenuItem.Click
        Dim curpos As Integer = Me.Parent.Controls.GetChildIndex(Me)
        Me.Parent.Controls.SetChildIndex(Me, curpos + 1)
        NewForm.refreshnums(Me.Parent)
    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If showMenu = False Then
            e.Cancel = True
        End If
        Dim curpos As Integer = Me.Parent.Controls.GetChildIndex(Me)
        If curpos = NewForm.Quiz.Controls.Count Then
            MoveDownToolStripMenuItem.Visible = False
        Else
            MoveDownToolStripMenuItem.Visible = True
        End If
        If curpos = 0 Then
            MoveUpToolStripMenuItem.Visible = False
        Else
            MoveUpToolStripMenuItem.Visible = True
        End If
    End Sub


End Class
