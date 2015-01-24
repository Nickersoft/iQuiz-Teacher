Public Class AboutMe

  
    Private Sub AboutMe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = Label1.Text.Insert(Label1.Text.Split(Chr(10))(0).Length + 1, "Version " & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & " (Build " & My.Application.Info.Version.Build & ")" & vbCrLf & vbCrLf)
    End Sub
End Class