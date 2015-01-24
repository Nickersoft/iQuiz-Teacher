Public Class Question
    Public showMenu As Boolean = True
    Public typeOfQuestion As String = ""

#Region "ToolStrip Menu Items"

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If showMenu = False Then
            e.Cancel = True
        End If
        Dim curpos As Integer = Me.Parent.Controls.GetChildIndex(Me)
        If curpos = Me.Parent.Controls.Count Then
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
    Private Sub DeleteQuestionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteQuestionToolStripMenuItem.Click
        Me.Parent.Controls.Remove(Me)
        NewForm.refreshnums(NewForm.Quiz)
    End Sub

#End Region

End Class
