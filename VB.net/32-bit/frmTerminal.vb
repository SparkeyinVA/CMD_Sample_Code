Public Class frmTerminal
    Dim controlExpand As Boolean
    Public widthControl = 600
    Public heightControl = 400
    Public heightExpandControl = 600

    Public sF1Command As String
    Public sF2Command As String
    Public sF3Command As String
    Public sF4Command As String
    Public sF5Command As String
    Public sF6Command As String
    Public PreviousCommand As String


    Private Sub TerminalForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        controlExpand = False
        Me.Height = heightControl
        Me.Width = widthControl

        TerminalPad.SelectionColor = Color.Black
        TerminalPad.AppendText("> ")
        sF1Command = ""
        sF2Command = ""
        sF3Command = ""
        sF4Command = ""
        sF5Command = ""
        sF6Command = ""
        TimerRVT.Enabled = True
    End Sub

    Private Sub TimerRVT_Tick(sender As Object, e As EventArgs) Handles TimerRVT.Tick

        F1Command.Text = sF1Command
        F2Command.Text = sF2Command
        F3Command.Text = sF3Command
        F4Command.Text = sF4Command
        F5Command.Text = sF5Command
        F6Command.Text = sF6Command

        If sF1Command = PreviousCommand OrElse sF2Command = PreviousCommand OrElse
            sF3Command = PreviousCommand OrElse sF4Command = PreviousCommand OrElse
            sF5Command = PreviousCommand OrElse sF6Command = PreviousCommand OrElse
            PreviousCommand = "" Then
            PreviousCommand = ""
        ElseIf sF1Command = "" Then
            sF1Command = PreviousCommand
        ElseIf sF2Command = "" Then
            sF2Command = PreviousCommand
        ElseIf sF3Command = "" Then
            sF3Command = PreviousCommand
        ElseIf sF4Command = "" Then
            sF4Command = PreviousCommand
        ElseIf sF5Command = "" Then
            sF5Command = PreviousCommand
        ElseIf sF6Command = "" Then
            sF6Command = PreviousCommand
        Else
            sF1Command = sF2Command
            sF2Command = sF3Command
            sF3Command = sF4Command
            sF4Command = sF5Command
            sF5Command = sF6Command
            sF6Command = PreviousCommand
        End If

    End Sub

    Private Sub SendTest_KeyDown(sender As Object, e As KeyEventArgs) Handles SendText.KeyDown
        Dim commandStr As New String("", 63)
        Dim replyStr As String
        Dim value As Integer

        If e.KeyCode = Keys.F1 Then
            SendText.Text = sF1Command
        End If
        If e.KeyCode = Keys.F2 Then
            SendText.Text = sF2Command
        End If
        If e.KeyCode = Keys.F3 Then
            SendText.Text = sF3Command
        End If
        If e.KeyCode = Keys.F4 Then
            SendText.Text = sF4Command
        End If
        If e.KeyCode = Keys.F5 Then
            SendText.Text = sF5Command
        End If
        If e.KeyCode = Keys.F6 Then
            SendText.Text = sF6Command
        End If

        If e.KeyCode = Keys.Enter Then
            On Error GoTo CheckConn

            PreviousCommand = SendText.Text
            PreviousCommand = PreviousCommand.ToUpper()
            SendText.Text = ""

            commandStr = PreviousCommand
            TerminalPad.SelectionColor = Color.Blue
            TerminalPad.AppendText(commandStr)

            replyStr = SendReceiveCommander(commandStr)

            If replyStr.Length > 0 Then
                TerminalPad.SelectionColor = Color.Black
                TerminalPad.AppendText(" < ")
                'TerminalPad.Text = TerminalPad.Text + "< " + replyStr
                TerminalPad.SelectionColor = Color.Green
                TerminalPad.AppendText(replyStr)

            Else
                TerminalPad.Text = TerminalPad.Text + " < NO REPLY!"
            End If
            TerminalPad.SelectionColor = Color.Black
            TerminalPad.AppendText(Environment.NewLine + "> ")
            TerminalPad.ScrollToCaret()
        End If

CheckConn:

    End Sub

    Private Sub ClrTermWin_Click(sender As Object, e As EventArgs) Handles ClrTermWin.Click
        TerminalPad.Text = "> "
    End Sub

    Private Sub AdvancedControl_Click(sender As Object, e As EventArgs) Handles AdvancedControl.Click
        If (controlExpand = False) Then
            Me.Height = heightExpandControl
            controlExpand = True
        Else
            Me.Height = heightControl
            controlExpand = False
        End If
    End Sub
End Class