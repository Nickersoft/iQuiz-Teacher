﻿Public Class TitleorText
    Public showMenu As Boolean = True
    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
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
        MoveDownToolStripMenuItem.Visible = True
        MoveUpToolStripMenuItem.Visible = True
        If curpos = Me.Parent.Controls.Count Then
            MoveDownToolStripMenuItem.Visible = False
        End If
        If curpos = 0 Then
            MoveUpToolStripMenuItem.Visible = False
        End If
    End Sub

    Private Sub FlowLayoutPanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub
End Class
