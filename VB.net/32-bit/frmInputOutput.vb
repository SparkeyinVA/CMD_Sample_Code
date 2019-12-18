Imports Commander_Terminal_VB_NET

Public Class frmInputOutput
    Dim timerStep As Integer
    Dim digitalIOExpand As Boolean
    Public widthDIO = 50
    Public widthExpandDIO = 850
    Public heightDIO = 50
    Public heightExpandDIO = 400
    Public PWM1Used As Boolean
    Public PWM2Used As Boolean
    Public SYncWindMinMAxFocus As Boolean
    Public SyncPositionHasFocus As Boolean
    Public OKreply As New String("", 63)

    ' Tick
    Private Sub TimerIO_Tick(sender As Object, e As EventArgs) Handles TimerIO.Tick
        Dim retVal As Short
        Dim commandStr As New String("", 63)
        Dim replyStr As New String("", 63)
        Dim value As Integer
        Dim lvalue As Long
        Dim lvalue1 As Long

        If (ComStatus = True) Then
            TimerIO.Enabled = False

            On Error GoTo SKIP

            commandStr = "DI"
            replyStr = SendReceiveCommander(commandStr)
            value = replyStr
            '' Digital Input 1
            If (BitAND(value, 1) = 1) Then
                DI1.BackColor = Color.Green
            Else
                DI1.BackColor = Color.White
            End If

            '' Digital Input 2
            If (BitAND(value, 2) = 2) Then
                DI2.BackColor = Color.Green
            Else
                DI2.BackColor = Color.White
            End If

            '' Digital Input 3
            If (BitAND(value, 4) = 4) Then
                DI3.BackColor = Color.Green
            Else
                DI3.BackColor = Color.White
            End If

            '' Digital Input 4
            If (BitAND(value, 8) = 8) Then
                DI4.BackColor = Color.Green
            Else
                DI4.BackColor = Color.White
            End If

            commandStr = "DO"
            replyStr = SendReceiveCommander(commandStr)
            value = replyStr
            '' Digital Output 1
            If (BitAND(value, 1) = 1) Then
                DO1.BackColor = Color.Blue
            Else
                DO1.BackColor = Color.White
            End If

            '' Digital Output 2
            If (BitAND(value, 2) = 2) Then
                DO2.BackColor = Color.Blue
            Else
                DO2.BackColor = Color.White
            End If

            '' Digital Output 3
            If (BitAND(value, 4) = 4) Then
                DO3.BackColor = Color.Blue
            Else
                DO3.BackColor = Color.White
            End If

            '' Digital Output 4
            If (BitAND(value, 8) = 8) Then
                DO4.BackColor = Color.Blue
            Else
                DO4.BackColor = Color.White
            End If

            If (digitalIOExpand = True) Then
                UpdateIOLogic()
            End If


            commandStr = "AI1"
            replyStr = SendReceiveCommander(commandStr)
            AIN1Text.Text = replyStr
            globalCounter = globalCounter + 1

            commandStr = "AI2"
            replyStr = SendReceiveCommander(commandStr)
            AIN2Text.Text = replyStr

            commandStr = "IO"
            replyStr = SendReceiveCommander(commandStr)
            lvalue = replyStr

            commandStr = "IOCFG"
            replyStr = SendReceiveCommander(commandStr)
            lvalue1 = replyStr

            If (BitAND(lvalue, &H1) = &H1) Then
                If (BitAND(lvalue1, &H1) = &H1) Then
                    IO1.BackColor = Color.Blue
                Else
                    IO1.BackColor = Color.Green
                End If
            Else
                IO1.BackColor = Color.White
            End If
            If (BitAND(lvalue, &H2) = &H2) Then
                If (BitAND(lvalue1, &H2) = &H2) Then
                    IO2.BackColor = Color.Blue
                Else
                    IO2.BackColor = Color.Green
                End If
            Else
                IO2.BackColor = Color.White
            End If
            If (BitAND(lvalue, &H4) = &H4) Then
                If (BitAND(lvalue1, &H4) = &H4) Then
                    IO3.BackColor = Color.Blue
                Else
                    IO3.BackColor = Color.Green
                End If
            Else
                IO3.BackColor = Color.White
            End If
            If (BitAND(lvalue, &H8) = &H8) Then
                If (BitAND(lvalue1, &H8) = &H8) Then
                    IO4.BackColor = Color.Blue
                Else
                    IO4.BackColor = Color.Green
                End If
            Else
                IO4.BackColor = Color.White
            End If

SKIP:
            TimerIO.Enabled = True
        End If

    End Sub

    ' Loader
    Private Sub frmDigitalIO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim commandStr As New String("", 63)
        Dim replyStr As New String("", 63)
        Dim value As Integer
        Me.Height = heightDIO
        Me.Width = widthDIO

        PWM2Used = False
        PWM1Used = False
        OKreply = "OK"

        commandStr = "PWM1"
        replyStr = SendReceiveCommander(commandStr)
        value = replyStr
        If value = 0 Then
            commandStr = "PWM1=1"
            replyStr = SendReceiveCommander(commandStr)
            commandStr = "PWM1"
            replyStr = SendReceiveCommander(commandStr)
            value = replyStr
        ElseIf value = 100 Then
            commandStr = "PWM1=99"
            replyStr = SendReceiveCommander(commandStr)
            commandStr = "PWM1"
            replyStr = SendReceiveCommander(commandStr)
            value = replyStr
        End If
        PWM1TrackBar.Value = value

        commandStr = "PWM2"
        replyStr = SendReceiveCommander(commandStr)
        value = replyStr
        If value = 0 Then
            commandStr = "PWM2=1"
            replyStr = SendReceiveCommander(commandStr)
            commandStr = "PWM2"
            replyStr = SendReceiveCommander(commandStr)
            value = replyStr
        ElseIf value = 100 Then
            commandStr = "PWM2=99"
            replyStr = SendReceiveCommander(commandStr)
            commandStr = "PWM2"
            replyStr = SendReceiveCommander(commandStr)
            value = replyStr
        End If
        PWM2TrackBar.Value = value


        UpdateIOLogic()
        TimerIO.Enabled = True

    End Sub

    ' D OUT
    Private Sub DO1_Click(sender As Object, e As System.EventArgs) Handles DO1.Click
        Dim commandStr As New String("", 63)
        Dim replyStr As New String("", 63)
        Dim value As Integer

        commandStr = "DO1"
        replyStr = SendReceiveCommander(commandStr)
        value = replyStr
        '' Toggle DO1 depending on current value
        If (value = 1) Then
            commandStr = "DO1=0"
        Else
            commandStr = "DO1=1"
        End If

        replyStr = SendReceiveCommander(commandStr)
    End Sub

    Private Sub DO2_Click(sender As Object, e As System.EventArgs) Handles DO2.Click
        Dim commandStr As New String("", 63)
        Dim replyStr As New String("", 63)
        Dim value As Integer

        commandStr = "DO2"
        replyStr = SendReceiveCommander(commandStr)
        value = replyStr
        '' Toggle DO2 depending on current value
        If (value = 1) Then
            commandStr = "DO2=0"
        Else
            commandStr = "DO2=1"
        End If

        replyStr = SendReceiveCommander(commandStr)
    End Sub

    Private Sub DO3_Click(sender As Object, e As System.EventArgs) Handles DO3.Click
        Dim commandStr As New String("", 63)
        Dim replyStr As New String("", 63)
        Dim value As Integer

        commandStr = "DO3"
        replyStr = SendReceiveCommander(commandStr)
        value = replyStr
        '' Toggle DO3 depending on current value
        If (value = 1) Then
            commandStr = "DO3=0"
        Else
            commandStr = "DO3=1"
        End If

        replyStr = SendReceiveCommander(commandStr)
    End Sub

    Private Sub DO4_Click(sender As Object, e As System.EventArgs) Handles DO4.Click
        Dim commandStr As New String("", 63)
        Dim replyStr As New String("", 63)
        Dim value As Integer

        commandStr = "DO4"
        replyStr = SendReceiveCommander(commandStr)
        value = replyStr
        '' Toggle DO1 depending on current value
        If (value = 1) Then
            commandStr = "DO4=0"
        Else
            commandStr = "DO4=1"
        End If

        replyStr = SendReceiveCommander(commandStr)
    End Sub


    ' PWM
    Private Sub PWM1TrackBar_Scroll(sender As Object, e As EventArgs) Handles PWM1TrackBar.Scroll
        Dim commandStr As New String("", 63)
        Dim replyStr As New String("", 63)
        Dim lvalue As Long

        ToolTip1.SetToolTip(PWM1TrackBar, PWM1TrackBar.Value.ToString)

        lvalue = PWM1TrackBar.Value
        commandStr = "PWM1=" & lvalue
        replyStr = SendReceiveCommander(commandStr)
    End Sub

    Private Sub PWM1TrackBar_GotFocus(sender As Object, e As EventArgs) Handles PWM1TrackBar.GotFocus
        PWM1Used = True
    End Sub

    Private Sub PWM1TrackBar_LostFocus(sender As Object, e As EventArgs) Handles PWM1TrackBar.LostFocus
        PWM1Used = False
    End Sub

    Private Sub PWM2TrackBar_Scroll(sender As Object, e As EventArgs) Handles PWM2TrackBar.Scroll
        Dim commandStr As New String("", 63)
        Dim replyStr As New String("", 63)
        Dim lvalue As Long

        ToolTip1.SetToolTip(PWM2TrackBar, PWM2TrackBar.Value.ToString)

        lvalue = PWM2TrackBar.Value
        commandStr = "PWM2=" & lvalue
        replyStr = SendReceiveCommander(commandStr)
    End Sub

    Private Sub PWM2TrackBar_GotFocus(sender As Object, e As EventArgs) Handles PWM2TrackBar.GotFocus
        PWM2Used = True
    End Sub

    Private Sub PWM2TrackBar_LostFocus(sender As Object, e As EventArgs) Handles PWM2TrackBar.LostFocus
        PWM2Used = False
    End Sub

    ' Subs
    Public Overrides Function Equals(obj As Object) As Boolean
        Dim iO = TryCast(obj, frmInputOutput)
        Return iO IsNot Nothing AndAlso
               EqualityComparer(Of Object).Default.Equals(heightDIO, iO.heightDIO)
    End Function

    Private Sub UpdateIOLogic()
        Dim retVal As Short
        Dim commandStr As New String("", 63)
        Dim replyStr As New String("", 63)
        Dim value As Integer
        Dim bitvalue As Integer
        Dim lvalue As Long
        Dim SuggSSPDMmode As Integer
        Dim SyncOn As Boolean

        SyncOn = False

        On Error GoTo SKIP

        If (ComStatus = True) Then

            ' PWM Slider
            If PWM1Used = False Then
                commandStr = "PWM1"
                replyStr = SendReceiveCommander(commandStr)
                value = replyStr
                PWM1TrackBar.Value = value
            End If

            If PWM2Used = False Then
                commandStr = "PWM2"
                replyStr = SendReceiveCommander(commandStr)
                value = replyStr
                PWM2TrackBar.Value = value
            End If

        End If

SKIP:

    End Sub

    'Conf I/O
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim commandStr As New String("", 63)
        Dim replyStr As String
        Dim lvalue As Long

        commandStr = "IOCFG"
        replyStr = SendReceiveCommander(commandStr)
        lvalue = replyStr

        If Button1.Text = "I" Then
            lvalue = BitOR(lvalue, &H1)
            Button1.Text = "O"
            ToolTip1.SetToolTip(Me.Button1, "IO1 is Output")
        Else
            lvalue = BitAND(lvalue, &HFFFFFFFEUL)
            Button1.Text = "I"
            ToolTip1.SetToolTip(Me.Button1, "IO1 is Input")
        End If

        commandStr = "IOCFG=" + Str(lvalue)
        replyStr = SendReceiveCommander(commandStr)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim commandStr As New String("", 63)
        Dim replyStr As New String("", 63)
        Dim lvalue As Long

        commandStr = "IOCFG"
        replyStr = SendReceiveCommander(commandStr)
        lvalue = replyStr

        If Button2.Text = "I" Then
            lvalue = BitOR(lvalue, &H2)
            Button2.Text = "O"
            ToolTip1.SetToolTip(Me.Button2, "IO2 is Output")
        Else
            lvalue = BitAND(lvalue, &HFFFFFFFDUL)
            Button2.Text = "I"
            ToolTip1.SetToolTip(Me.Button2, "IO2 is Input")
        End If

        commandStr = "IOCFG=" + Str(lvalue)
        replyStr = SendReceiveCommander(commandStr)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim commandStr As New String("", 63)
        Dim replyStr As New String("", 63)
        Dim lvalue As Long

        commandStr = "IOCFG"
        replyStr = SendReceiveCommander(commandStr)
        lvalue = replyStr

        If Button3.Text = "I" Then
            lvalue = BitOR(lvalue, &H4)
            Button3.Text = "O"
            ToolTip1.SetToolTip(Me.Button3, "IO3 is Output")
        Else
            lvalue = BitAND(lvalue, &HFFFFFFFBUL)
            Button3.Text = "I"
            ToolTip1.SetToolTip(Me.Button3, "IO3 is Input")
        End If

        commandStr = "IOCFG=" + Str(lvalue)
        replyStr = SendReceiveCommander(commandStr)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim commandStr As New String("", 63)
        Dim replyStr As New String("", 63)
        Dim lvalue As Long

        commandStr = "IOCFG"
        replyStr = SendReceiveCommander(commandStr)
        lvalue = replyStr

        If Button4.Text = "I" Then
            lvalue = BitOR(lvalue, &H8)
            Button4.Text = "O"
            ToolTip1.SetToolTip(Me.Button4, "IO4 is Output")
        Else
            lvalue = BitAND(lvalue, &HFFFFFFF7UL)
            Button4.Text = "I"
            ToolTip1.SetToolTip(Me.Button4, "IO4 is Input")
        End If

        commandStr = "IOCFG=" + Str(lvalue)
        replyStr = SendReceiveCommander(commandStr)
    End Sub

    Private Sub IO1_Click(sender As Object, e As System.EventArgs) Handles IO1.Click
        Dim commandStr As New String("", 63)
        Dim replyStr As New String("", 63)
        Dim value As Integer

        If (Button1.Text = "O") Then
            commandStr = "IO1"
            replyStr = SendReceiveCommander(commandStr)
            value = replyStr

            If (value = 1) Then
                commandStr = "IO1=0"
            Else
                commandStr = "IO1=1"
            End If

            replyStr = SendReceiveCommander(commandStr)
        End If
    End Sub

    Private Sub IO2_Click(sender As Object, e As System.EventArgs) Handles IO2.Click
        Dim commandStr As New String("", 63)
        Dim replyStr As New String("", 63)
        Dim value As Integer

        If (Button2.Text = "O") Then
            commandStr = "IO2"
            replyStr = SendReceiveCommander(commandStr)
            value = replyStr

            If (value = 1) Then
                commandStr = "IO2=0"
            Else
                commandStr = "IO2=1"
            End If

            replyStr = SendReceiveCommander(commandStr)
        End If
    End Sub

    Private Sub IO3_Click(sender As Object, e As System.EventArgs) Handles IO3.Click
        Dim commandStr As New String("", 63)
        Dim replyStr As New String("", 63)
        Dim value As Integer

        If (Button3.Text = "O") Then
            commandStr = "IO3"
            replyStr = SendReceiveCommander(commandStr)
            value = replyStr

            If (value = 1) Then
                commandStr = "IO3=0"
            Else
                commandStr = "IO3=1"
            End If

            replyStr = SendReceiveCommander(commandStr)
        End If
    End Sub

    Private Sub IO4_Click(sender As Object, e As System.EventArgs) Handles IO4.Click
        Dim commandStr As New String("", 63)
        Dim replyStr As New String("", 63)
        Dim value As Integer

        If (Button4.Text = "O") Then
            commandStr = "IO4"
            replyStr = SendReceiveCommander(commandStr)
            value = replyStr

            If (value = 1) Then
                commandStr = "IO4=0"
            Else
                commandStr = "IO4=1"
            End If

            replyStr = SendReceiveCommander(commandStr)
        End If
    End Sub

End Class