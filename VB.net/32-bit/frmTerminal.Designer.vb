<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTerminal
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
        Me.components = New System.ComponentModel.Container()
        Me.SendText = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ClrTermWin = New System.Windows.Forms.Button()
        Me.TimerRVT = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.F6Command = New System.Windows.Forms.Label()
        Me.F5Command = New System.Windows.Forms.Label()
        Me.F4Command = New System.Windows.Forms.Label()
        Me.F3Command = New System.Windows.Forms.Label()
        Me.F2Command = New System.Windows.Forms.Label()
        Me.F1Command = New System.Windows.Forms.Label()
        Me.TerminalPad = New System.Windows.Forms.RichTextBox()
        Me.AdvancedControl = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SendText
        '
        Me.SendText.Location = New System.Drawing.Point(93, 520)
        Me.SendText.Name = "SendText"
        Me.SendText.Size = New System.Drawing.Size(304, 26)
        Me.SendText.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 523)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Command:"
        '
        'ClrTermWin
        '
        Me.ClrTermWin.Location = New System.Drawing.Point(403, 514)
        Me.ClrTermWin.Name = "ClrTermWin"
        Me.ClrTermWin.Size = New System.Drawing.Size(131, 54)
        Me.ClrTermWin.TabIndex = 4
        Me.ClrTermWin.Text = "Clear Window"
        Me.ClrTermWin.UseVisualStyleBackColor = True
        '
        'TimerRVT
        '
        Me.TimerRVT.Interval = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(133, 549)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(223, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Press Enter to send command"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 578)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Command History:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 608)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "F1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 641)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "F2"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 674)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "F3"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 707)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 20)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "F4"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 740)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 20)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "F5"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 773)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 20)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "F6"
        '
        'F6Command
        '
        Me.F6Command.AutoSize = True
        Me.F6Command.Location = New System.Drawing.Point(49, 773)
        Me.F6Command.Name = "F6Command"
        Me.F6Command.Size = New System.Drawing.Size(28, 20)
        Me.F6Command.TabIndex = 19
        Me.F6Command.Text = "F6"
        '
        'F5Command
        '
        Me.F5Command.AutoSize = True
        Me.F5Command.Location = New System.Drawing.Point(49, 740)
        Me.F5Command.Name = "F5Command"
        Me.F5Command.Size = New System.Drawing.Size(28, 20)
        Me.F5Command.TabIndex = 18
        Me.F5Command.Text = "F5"
        '
        'F4Command
        '
        Me.F4Command.AutoSize = True
        Me.F4Command.Location = New System.Drawing.Point(49, 707)
        Me.F4Command.Name = "F4Command"
        Me.F4Command.Size = New System.Drawing.Size(28, 20)
        Me.F4Command.TabIndex = 17
        Me.F4Command.Text = "F4"
        '
        'F3Command
        '
        Me.F3Command.AutoSize = True
        Me.F3Command.Location = New System.Drawing.Point(49, 674)
        Me.F3Command.Name = "F3Command"
        Me.F3Command.Size = New System.Drawing.Size(28, 20)
        Me.F3Command.TabIndex = 16
        Me.F3Command.Text = "F3"
        '
        'F2Command
        '
        Me.F2Command.AutoSize = True
        Me.F2Command.Location = New System.Drawing.Point(49, 641)
        Me.F2Command.Name = "F2Command"
        Me.F2Command.Size = New System.Drawing.Size(28, 20)
        Me.F2Command.TabIndex = 15
        Me.F2Command.Text = "F2"
        '
        'F1Command
        '
        Me.F1Command.AutoSize = True
        Me.F1Command.Location = New System.Drawing.Point(49, 608)
        Me.F1Command.Name = "F1Command"
        Me.F1Command.Size = New System.Drawing.Size(28, 20)
        Me.F1Command.TabIndex = 14
        Me.F1Command.Text = "F1"
        '
        'TerminalPad
        '
        Me.TerminalPad.Location = New System.Drawing.Point(16, 9)
        Me.TerminalPad.Name = "TerminalPad"
        Me.TerminalPad.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.TerminalPad.Size = New System.Drawing.Size(552, 497)
        Me.TerminalPad.TabIndex = 22
        Me.TerminalPad.Text = ""
        '
        'AdvancedControl
        '
        Me.AdvancedControl.BackgroundImage = Global.Commander_Terminal_VB_NET.My.Resources.Resources.Settings
        Me.AdvancedControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AdvancedControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AdvancedControl.Location = New System.Drawing.Point(540, 537)
        Me.AdvancedControl.Name = "AdvancedControl"
        Me.AdvancedControl.Size = New System.Drawing.Size(28, 31)
        Me.AdvancedControl.TabIndex = 129
        Me.AdvancedControl.UseVisualStyleBackColor = True
        '
        'frmTerminal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 580)
        Me.ControlBox = False
        Me.Controls.Add(Me.AdvancedControl)
        Me.Controls.Add(Me.TerminalPad)
        Me.Controls.Add(Me.F6Command)
        Me.Controls.Add(Me.F5Command)
        Me.Controls.Add(Me.F4Command)
        Me.Controls.Add(Me.F3Command)
        Me.Controls.Add(Me.F2Command)
        Me.Controls.Add(Me.F1Command)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ClrTermWin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SendText)
        Me.MaximumSize = New System.Drawing.Size(600, 845)
        Me.MinimumSize = New System.Drawing.Size(600, 615)
        Me.Name = "frmTerminal"
        Me.Text = "Terminal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SendText As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ClrTermWin As Button
    Friend WithEvents TimerRVT As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents F6Command As Label
    Friend WithEvents F5Command As Label
    Friend WithEvents F4Command As Label
    Friend WithEvents F3Command As Label
    Friend WithEvents F2Command As Label
    Friend WithEvents F1Command As Label
    Friend WithEvents TerminalPad As RichTextBox
    Friend WithEvents AdvancedControl As Button
End Class
