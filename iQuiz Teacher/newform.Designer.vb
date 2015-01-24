<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewForm))
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.newtext = New System.Windows.Forms.TextBox
        Me.Quiz = New System.Windows.Forms.FlowLayoutPanel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.MCChoices = New System.Windows.Forms.TextBox
        Me.MultiChoiceQuestion = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.TxtField = New System.Windows.Forms.RichTextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.SAtxt = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.SAans = New System.Windows.Forms.TextBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.EssayQuest = New System.Windows.Forms.TextBox
        Me.EssayAnswer = New System.Windows.Forms.TextBox
        Me.Button7 = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.Button14 = New System.Windows.Forms.Button
        Me.Button13 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.OpenPic = New System.Windows.Forms.OpenFileDialog
        Me.Label3 = New System.Windows.Forms.Label
        Me.quizname = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Button11 = New System.Windows.Forms.Button
        Me.MatchBox = New System.Windows.Forms.ListView
        Me.Statement = New System.Windows.Forms.ColumnHeader
        Me.Answer = New System.Windows.Forms.ColumnHeader
        Me.Button10 = New System.Windows.Forms.Button
        Me.MatchAnswer = New System.Windows.Forms.TextBox
        Me.MatchStatement = New System.Windows.Forms.TextBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button12 = New System.Windows.Forms.Button
        Me.FBStatement = New System.Windows.Forms.TextBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.FalseRadio = New System.Windows.Forms.RadioButton
        Me.TrueRadio = New System.Windows.Forms.RadioButton
        Me.TFQuestBox = New System.Windows.Forms.TextBox
        Me.Button9 = New System.Windows.Forms.Button
        Me.OpenVid = New System.Windows.Forms.OpenFileDialog
        Me.OpenAud = New System.Windows.Forms.OpenFileDialog
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "*.quest"
        Me.SaveFileDialog1.Filter = "iQuiz Files|*.quest"
        Me.SaveFileDialog1.FilterIndex = 0
        '
        'newtext
        '
        Me.newtext.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newtext.Location = New System.Drawing.Point(86, 20)
        Me.newtext.MaxLength = 200
        Me.newtext.Name = "newtext"
        Me.newtext.Size = New System.Drawing.Size(138, 20)
        Me.newtext.TabIndex = 0
        Me.newtext.Tag = "Type your title here"
        Me.newtext.Text = "Type your title here"
        '
        'Quiz
        '
        Me.Quiz.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Quiz.AutoScroll = True
        Me.Quiz.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Quiz.BackColor = System.Drawing.Color.White
        Me.Quiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Quiz.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Quiz.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.Quiz.Location = New System.Drawing.Point(249, 69)
        Me.Quiz.Name = "Quiz"
        Me.Quiz.Size = New System.Drawing.Size(651, 737)
        Me.Quiz.TabIndex = 0
        Me.Quiz.WrapContents = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.MCChoices)
        Me.GroupBox1.Controls.Add(Me.MultiChoiceQuestion)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 283)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(224, 118)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Multiple Choice"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Gainsboro
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(86, 83)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(122, 23)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Insert Multiple Choice"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 30)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "*Seperate with commas. Put an asterisk(*) after the correct answer"
        '
        'MCChoices
        '
        Me.MCChoices.Location = New System.Drawing.Point(7, 45)
        Me.MCChoices.Name = "MCChoices"
        Me.MCChoices.Size = New System.Drawing.Size(209, 20)
        Me.MCChoices.TabIndex = 8
        Me.MCChoices.Tag = "Type your choices here*"
        Me.MCChoices.Text = "Type your choices here*"
        '
        'MultiChoiceQuestion
        '
        Me.MultiChoiceQuestion.Location = New System.Drawing.Point(7, 19)
        Me.MultiChoiceQuestion.Name = "MultiChoiceQuestion"
        Me.MultiChoiceQuestion.Size = New System.Drawing.Size(208, 20)
        Me.MultiChoiceQuestion.TabIndex = 7
        Me.MultiChoiceQuestion.Tag = "Enter a question here"
        Me.MultiChoiceQuestion.Text = "Enter a question here"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.TxtField)
        Me.GroupBox2.Controls.Add(Me.newtext)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(230, 154)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Titles and Text Fields"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gainsboro
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(6, 125)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(218, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Insert Text Field"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TxtField
        '
        Me.TxtField.Location = New System.Drawing.Point(6, 45)
        Me.TxtField.Name = "TxtField"
        Me.TxtField.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal
        Me.TxtField.Size = New System.Drawing.Size(216, 74)
        Me.TxtField.TabIndex = 2
        Me.TxtField.Tag = "Type your text here"
        Me.TxtField.Text = "Type your text here"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Gainsboro
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(6, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(74, 23)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Insert Title"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.SAtxt)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.SAans)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Location = New System.Drawing.Point(10, 167)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(224, 110)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Short Answer"
        '
        'SAtxt
        '
        Me.SAtxt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SAtxt.Location = New System.Drawing.Point(7, 19)
        Me.SAtxt.Name = "SAtxt"
        Me.SAtxt.Size = New System.Drawing.Size(209, 20)
        Me.SAtxt.TabIndex = 4
        Me.SAtxt.Tag = "Type your question here"
        Me.SAtxt.Text = "Type your question here"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 12)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "*Answer will not be shown to students"
        '
        'SAans
        '
        Me.SAans.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SAans.Location = New System.Drawing.Point(7, 45)
        Me.SAans.Name = "SAans"
        Me.SAans.Size = New System.Drawing.Size(209, 20)
        Me.SAans.TabIndex = 5
        Me.SAans.Tag = "Type your answer here*"
        Me.SAans.Text = "Type your answer here*"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Gainsboro
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(105, 82)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(111, 21)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Insert Short Answer"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Button7)
        Me.GroupBox4.Controls.Add(Me.EssayQuest)
        Me.GroupBox4.Controls.Add(Me.EssayAnswer)
        Me.GroupBox4.Location = New System.Drawing.Point(10, 404)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(224, 290)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Essay"
        '
        'EssayQuest
        '
        Me.EssayQuest.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EssayQuest.Location = New System.Drawing.Point(7, 19)
        Me.EssayQuest.Multiline = True
        Me.EssayQuest.Name = "EssayQuest"
        Me.EssayQuest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.EssayQuest.Size = New System.Drawing.Size(209, 108)
        Me.EssayQuest.TabIndex = 10
        Me.EssayQuest.Tag = "Type your essay question here"
        Me.EssayQuest.Text = "Type your essay question here"
        '
        'EssayAnswer
        '
        Me.EssayAnswer.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EssayAnswer.Location = New System.Drawing.Point(6, 133)
        Me.EssayAnswer.Multiline = True
        Me.EssayAnswer.Name = "EssayAnswer"
        Me.EssayAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.EssayAnswer.Size = New System.Drawing.Size(209, 121)
        Me.EssayAnswer.TabIndex = 11
        Me.EssayAnswer.Tag = "Type an example answer here (will not be shown to students)"
        Me.EssayAnswer.Text = "Type an example answer here (will not be shown to students)"
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Gainsboro
        Me.Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), System.Drawing.Image)
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Location = New System.Drawing.Point(85, 260)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(130, 24)
        Me.Button7.TabIndex = 12
        Me.Button7.Text = "Insert Essay Question"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.GroupBox9)
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(240, 845)
        Me.Panel1.TabIndex = 13
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Button14)
        Me.GroupBox9.Controls.Add(Me.Button13)
        Me.GroupBox9.Controls.Add(Me.Button6)
        Me.GroupBox9.Location = New System.Drawing.Point(10, 702)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(224, 130)
        Me.GroupBox9.TabIndex = 10
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Media"
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.Gainsboro
        Me.Button14.BackgroundImage = CType(resources.GetObject("Button14.BackgroundImage"), System.Drawing.Image)
        Me.Button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button14.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.Button14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.Location = New System.Drawing.Point(6, 91)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(209, 28)
        Me.Button14.TabIndex = 15
        Me.Button14.Text = "Insert Audio"
        Me.Button14.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.Gainsboro
        Me.Button13.BackgroundImage = CType(resources.GetObject("Button13.BackgroundImage"), System.Drawing.Image)
        Me.Button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button13.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.Button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Location = New System.Drawing.Point(6, 57)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(209, 28)
        Me.Button13.TabIndex = 14
        Me.Button13.Text = "Insert Video"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Gainsboro
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(6, 23)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(210, 28)
        Me.Button6.TabIndex = 13
        Me.Button6.Text = "Insert Image"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(246, 812)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button8)
        Me.SplitContainer1.Size = New System.Drawing.Size(651, 32)
        Me.SplitContainer1.SplitterDistance = 328
        Me.SplitContainer1.TabIndex = 15
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Gainsboro
        Me.Button2.BackgroundImage = Global.iQuiz.My.Resources.Resources.glassstrip
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(0, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(328, 32)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Gainsboro
        Me.Button8.BackgroundImage = Global.iQuiz.My.Resources.Resources.glassstrip
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Location = New System.Drawing.Point(0, 0)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(319, 32)
        Me.Button8.TabIndex = 29
        Me.Button8.Text = "Close"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'OpenPic
        '
        Me.OpenPic.Filter = "All Files|*.*|JPEG (.jpg, .jpeg)|*.jpg; *.jpeg|Bitmap (.bmp)|*.bmp|PNG (.png)|*.p" & _
            "ng|GIF (.gif)|*.gif"
        Me.OpenPic.FilterIndex = 0
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Location = New System.Drawing.Point(246, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(651, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "You are now editing"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'quizname
        '
        Me.quizname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.quizname.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quizname.Location = New System.Drawing.Point(246, 9)
        Me.quizname.Name = "quizname"
        Me.quizname.Size = New System.Drawing.Size(651, 57)
        Me.quizname.TabIndex = 16
        Me.quizname.Text = "An Untitled Quiz"
        Me.quizname.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Timer1
        '
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.GroupBox6)
        Me.Panel2.Controls.Add(Me.GroupBox7)
        Me.Panel2.Controls.Add(Me.GroupBox5)
        Me.Panel2.Location = New System.Drawing.Point(907, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(257, 845)
        Me.Panel2.TabIndex = 17
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Button11)
        Me.GroupBox6.Controls.Add(Me.MatchBox)
        Me.GroupBox6.Controls.Add(Me.Button10)
        Me.GroupBox6.Controls.Add(Me.MatchAnswer)
        Me.GroupBox6.Controls.Add(Me.MatchStatement)
        Me.GroupBox6.Location = New System.Drawing.Point(3, 337)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(230, 335)
        Me.GroupBox6.TabIndex = 12
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Matching"
        Me.GroupBox6.Visible = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.Gainsboro
        Me.Button11.BackgroundImage = CType(resources.GetObject("Button11.BackgroundImage"), System.Drawing.Image)
        Me.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button11.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.Button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Location = New System.Drawing.Point(6, 303)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(218, 23)
        Me.Button11.TabIndex = 27
        Me.Button11.Text = "Insert Matching"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'MatchBox
        '
        Me.MatchBox.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Statement, Me.Answer})
        Me.MatchBox.Location = New System.Drawing.Point(6, 97)
        Me.MatchBox.Name = "MatchBox"
        Me.MatchBox.Size = New System.Drawing.Size(218, 200)
        Me.MatchBox.TabIndex = 26
        Me.MatchBox.UseCompatibleStateImageBehavior = False
        Me.MatchBox.View = System.Windows.Forms.View.Details
        '
        'Statement
        '
        Me.Statement.Text = "Statement"
        Me.Statement.Width = 96
        '
        'Answer
        '
        Me.Answer.Text = "Answer"
        Me.Answer.Width = 101
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.Gainsboro
        Me.Button10.BackgroundImage = CType(resources.GetObject("Button10.BackgroundImage"), System.Drawing.Image)
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button10.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.Button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Location = New System.Drawing.Point(6, 68)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(218, 23)
        Me.Button10.TabIndex = 25
        Me.Button10.Text = "Add to List"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'MatchAnswer
        '
        Me.MatchAnswer.Location = New System.Drawing.Point(6, 42)
        Me.MatchAnswer.Name = "MatchAnswer"
        Me.MatchAnswer.Size = New System.Drawing.Size(218, 20)
        Me.MatchAnswer.TabIndex = 24
        Me.MatchAnswer.Tag = "Type your answer here"
        Me.MatchAnswer.Text = "Type your answer here"
        '
        'MatchStatement
        '
        Me.MatchStatement.Location = New System.Drawing.Point(6, 19)
        Me.MatchStatement.Name = "MatchStatement"
        Me.MatchStatement.Size = New System.Drawing.Size(218, 20)
        Me.MatchStatement.TabIndex = 23
        Me.MatchStatement.Tag = "Type your statement here"
        Me.MatchStatement.Text = "Type your statement here"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.ListView1)
        Me.GroupBox7.Controls.Add(Me.Label2)
        Me.GroupBox7.Controls.Add(Me.Button12)
        Me.GroupBox7.Controls.Add(Me.FBStatement)
        Me.GroupBox7.Location = New System.Drawing.Point(3, 94)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(230, 237)
        Me.GroupBox7.TabIndex = 12
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Fill in the Blanks"
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(6, 63)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(217, 136)
        Me.ListView1.TabIndex = 21
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.List
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 10)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Select the word(s) you wish to remove:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.Gainsboro
        Me.Button12.BackgroundImage = CType(resources.GetObject("Button12.BackgroundImage"), System.Drawing.Image)
        Me.Button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button12.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.Button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Location = New System.Drawing.Point(6, 205)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(217, 23)
        Me.Button12.TabIndex = 22
        Me.Button12.Text = "Insert FitB"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'FBStatement
        '
        Me.FBStatement.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FBStatement.Location = New System.Drawing.Point(6, 19)
        Me.FBStatement.MaxLength = 200
        Me.FBStatement.Name = "FBStatement"
        Me.FBStatement.Size = New System.Drawing.Size(218, 20)
        Me.FBStatement.TabIndex = 20
        Me.FBStatement.Tag = "Type a sentence here"
        Me.FBStatement.Text = "Type a sentence here"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.FalseRadio)
        Me.GroupBox5.Controls.Add(Me.TrueRadio)
        Me.GroupBox5.Controls.Add(Me.TFQuestBox)
        Me.GroupBox5.Controls.Add(Me.Button9)
        Me.GroupBox5.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(230, 80)
        Me.GroupBox5.TabIndex = 11
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "True or False"
        '
        'FalseRadio
        '
        Me.FalseRadio.AutoSize = True
        Me.FalseRadio.Location = New System.Drawing.Point(59, 47)
        Me.FalseRadio.Name = "FalseRadio"
        Me.FalseRadio.Size = New System.Drawing.Size(50, 17)
        Me.FalseRadio.TabIndex = 18
        Me.FalseRadio.TabStop = True
        Me.FalseRadio.Text = "False"
        Me.FalseRadio.UseVisualStyleBackColor = True
        '
        'TrueRadio
        '
        Me.TrueRadio.AutoSize = True
        Me.TrueRadio.Location = New System.Drawing.Point(6, 47)
        Me.TrueRadio.Name = "TrueRadio"
        Me.TrueRadio.Size = New System.Drawing.Size(47, 17)
        Me.TrueRadio.TabIndex = 17
        Me.TrueRadio.TabStop = True
        Me.TrueRadio.Text = "True"
        Me.TrueRadio.UseVisualStyleBackColor = True
        '
        'TFQuestBox
        '
        Me.TFQuestBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TFQuestBox.Location = New System.Drawing.Point(6, 19)
        Me.TFQuestBox.MaxLength = 200
        Me.TFQuestBox.Name = "TFQuestBox"
        Me.TFQuestBox.Size = New System.Drawing.Size(218, 20)
        Me.TFQuestBox.TabIndex = 16
        Me.TFQuestBox.Tag = "Type your question here"
        Me.TFQuestBox.Text = "Type your question here"
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Gainsboro
        Me.Button9.BackgroundImage = CType(resources.GetObject("Button9.BackgroundImage"), System.Drawing.Image)
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button9.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Location = New System.Drawing.Point(115, 47)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(109, 23)
        Me.Button9.TabIndex = 19
        Me.Button9.Text = "Insert True or False"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'OpenVid
        '
        Me.OpenVid.Filter = "All Files|*.*|MPEG Files|*.mpg|WMV Files|*.wmv|AVI Files|*.avi"
        Me.OpenVid.FilterIndex = 0
        '
        'OpenAud
        '
        Me.OpenAud.Filter = "All Files|*.*|MP3 Files|*.mp3|WAV Files|*.wav"
        Me.OpenAud.FilterIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.iQuiz.My.Resources.Resources.generator
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1159, 874)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Transparent
        Me.StatusStrip1.BackgroundImage = Global.iQuiz.My.Resources.Resources.glassstrip
        Me.StatusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 852)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1159, 22)
        Me.StatusStrip1.TabIndex = 14
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(57, 17)
        Me.ToolStripStatusLabel1.Tag = "Not Saved"
        Me.ToolStripStatusLabel1.Text = "Not Saved"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        Me.ToolStripProgressBar1.Visible = False
        '
        'NewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1159, 874)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Quiz)
        Me.Controls.Add(Me.quizname)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "NewForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Quiz As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents newtext As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MultiChoiceQuestion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MCChoices As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents SAans As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SAtxt As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents EssayAnswer As System.Windows.Forms.TextBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents TxtField As System.Windows.Forms.RichTextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents OpenPic As System.Windows.Forms.OpenFileDialog
    Private WithEvents EssayQuest As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents quizname As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents OpenVid As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpenAud As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents TFQuestBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents MatchBox As System.Windows.Forms.ListView
    Friend WithEvents Statement As System.Windows.Forms.ColumnHeader
    Friend WithEvents Answer As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents MatchAnswer As System.Windows.Forms.TextBox
    Friend WithEvents MatchStatement As System.Windows.Forms.TextBox
    Friend WithEvents FalseRadio As System.Windows.Forms.RadioButton
    Friend WithEvents TrueRadio As System.Windows.Forms.RadioButton
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents FBStatement As System.Windows.Forms.TextBox
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
End Class
