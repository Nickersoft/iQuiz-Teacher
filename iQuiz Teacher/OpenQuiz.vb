Public Class OpenQuiz
    Public file As String

    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel1.Click
        Me.Close()
    End Sub

    Private Sub OpenQuiz_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ComboBox1.SelectedIndex = 0
    End Sub

End Class