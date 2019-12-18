Imports System.IO
Imports System.IO.Ports



Public Class frmMain
    Dim timerStep As Integer = 0
    Dim MSTtimerStep As Integer = 0
    Dim HSPDSel As Boolean
    Dim LSPDSel As Boolean
    Dim ACCSel As Boolean
    Dim DECSel As Boolean

    'Load
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim availablePorts As String() = SerialPort.GetPortNames()
        Dim IDString As String
        Dim numberHIDs As Integer
        Dim retVal As Integer
        Dim i As Integer
        Build.Text = "Build: " + GlobalBuildVersion
        ' Get the number of connected Commander-HIDs
        numberHIDs = GetCommanderHIDnumber()

        If numberHIDs > 0 Then
            For i = 0 To numberHIDs - 1
                retVal = GetCommanderHIDName(i, HidName)
                DeviceListCombo.Items.Add(HidName)
            Next i
            DeviceListCombo.Sorted = True
            DeviceListCombo.SelectedIndex = 0
        End If

        Console.WriteLine("The following serial ports were found")
        Dim port As String
        For Each port In availablePorts
            COMListCombo.Items.Add(port)
        Next

        If (COMListCombo.Items.Count > 0) Then
            COMListCombo.SelectedIndex = 0
        End If

        BaudRateCombo.Items.Add("9600")
        BaudRateCombo.Items.Add("19200")
        BaudRateCombo.Items.Add("38400")
        BaudRateCombo.Items.Add("57600")
        BaudRateCombo.Items.Add("115200")
        BaudRateCombo.SelectedIndex = 0

        For i = 1 To 99
            If i < 10 Then
                IDString = "0" & i
            Else
                IDString = "" & i
            End If
            SerialIDCombo.Items.Add(IDString)
        Next i
        SerialIDCombo.SelectedIndex = 0
        USBToolStripMenuItem.PerformClick()

        viewDigitalIO = False
        CommTimer.Enabled = True
        viewTerminal = False
        'SearchRS485ToolStripMenuItem.Visible = False
        'SelectedPortToolStripMenuItem.Visible = False
        'AllPortsToolStripMenuItem.Visible = False

        'Speed section setup
        HighSpeedCombo.Items.Add("Global High Speed")
        HighSpeedCombo.Items.Add("X High Speed")
        HighSpeedCombo.Items.Add("Y High Speed")
        HighSpeedCombo.DropDownStyle = ComboBoxStyle.DropDownList

        LowSpeedCombo.Items.Add("Global Low Speed")
        LowSpeedCombo.Items.Add("X Low Speed")
        LowSpeedCombo.Items.Add("Y Low Speed")
        LowSpeedCombo.DropDownStyle = ComboBoxStyle.DropDownList

        AccelCombo.Items.Add("Global Acceleration")
        AccelCombo.Items.Add("X Acceleration")
        AccelCombo.Items.Add("Y Acceleration")
        AccelCombo.DropDownStyle = ComboBoxStyle.DropDownList

        DecelCombo.Items.Add("Global Deceleration")
        DecelCombo.Items.Add("X Deceleration")
        DecelCombo.Items.Add("Y Deceleration")
        DecelCombo.DropDownStyle = ComboBoxStyle.DropDownList

        HighSpeedCombo.SelectedIndex = 0
        LowSpeedCombo.SelectedIndex = 0
        AccelCombo.SelectedIndex = 0
        DecelCombo.SelectedIndex = 0

        HSPDSel = False
        LSPDSel = False
        ACCSel = False
        DECSel = False

        XTarget.Text = "1000"
        YTarget.Text = "1000"

        'SSPD Section setup
        AutoSetSSPDM.Checked = True

        'When a text box is selected, have the cursor start at the end of text
        'This initialization can be removed if the cursor initializes at the beginning of text
        HighSpeedText.SelectionStart = HighSpeedText.TextLength
        LowSpeedText.SelectionStart = LowSpeedText.TextLength
        AccelText.SelectionStart = AccelText.TextLength
        DecelText.SelectionStart = DecelText.TextLength
        XTarget.SelectionStart = XTarget.TextLength
        YTarget.SelectionStart = YTarget.TextLength

        CommTimer.Enabled = True
    End Sub

    ' Tick
    Private Sub CommTimer_Tick(sender As Object, e As EventArgs) Handles CommTimer.Tick
        If ComStatus = False Then
            DigitalIOToolStripMenuItem.Enabled = False
        Else
            DigitalIOToolStripMenuItem.Enabled = True
        End If

        TimerMST_Tick()

        UpdateControlStatusLogic()


    End Sub


    'Communation
    Private Sub ConnectButton_Click(sender As Object, e As EventArgs) Handles ConnectButton.Click
        Dim selectedStr As String
        Dim commandStr As New String("", 63)
        Dim replyStr As String
        Dim retVal As Integer

        If (ConnectButton.Text = "Connect") Then
            If (communicationType = 1 And DeviceListCombo.Items.Count > 0) Then
                selectedStr = DeviceListCombo.SelectedItem.ToString
                HidName = selectedStr

                If (InStr(HidName, "CMD-4CR") = 0) Then
                    MsgBox("No Commander core available to open")
                    handleOpened = False
                    ComStatus = False
                Else
                    retVal = OpenCommanderHID(HidHandle, HidName)
                    If (retVal = 0) Then
                        MsgBox("Error opening device: " + HidName)
                        retVal = CloseCommanderHID(HidHandle)
                        handleOpened = False
                    Else
                        handleOpened = True
                        ComStatus = True
                        '109 - save the device ID to global string
                        deviceID = Mid(HidName, 9, 2) 'JC was 12
                        StartAllTimers() 'start timers if there are already some forms open
                        ConnectButton.Text = "Disconnect"
                    End If
                End If
            ElseIf (communicationType = 2) Then
                selectedStr = BaudRateCombo.Text
                baud = selectedStr
                selectedStr = COMListCombo.Text

                globalSerialPort.PortName = selectedStr
                globalSerialPort.BaudRate = baud
                globalSerialPort.DataBits = 8
                globalSerialPort.Parity = Ports.Parity.None
                globalSerialPort.StopBits = Ports.StopBits.One
                globalSerialPort.Handshake = Ports.Handshake.None
                globalSerialPort.ReadTimeout = 100

                Try
                    globalSerialPort.Open()
                    ConnectButton.Text = "Disconnect"
                    ComStatus = True
                    Sleep(100)
                    commandStr = "VER"
                    replyStr = SendReceiveCommander(commandStr)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    globalSerialPort.Close()
                    ComStatus = False
                    ConnectButton.Text = "Connect"
                End Try
            End If

        ElseIf (ConnectButton.Text = "Disconnect") Then
            StopAllTimers() 'stop all timers before disconnecting. allows for more seemless disconnect.
            If (communicationType = 1) Then
                retVal = CloseCommanderHID(HidHandle)
                handleOpened = False
                ComStatus = False
                ConnectButton.Text = "Connect"
            ElseIf (communicationType = 2) Then
                globalSerialPort.Close()
                ComStatus = False
                ConnectButton.Text = "Connect"
            End If
        End If
    End Sub

    Private Sub USBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles USBToolStripMenuItem.Click
        communicationType = 1
        USBToolStripMenuItem.Checked = True
        RS485ToolStripMenuItem.Checked = False

        'Enable USB fields
        IDLabel.Visible = True
        DeviceListCombo.Visible = True

        'Disable RS485 fields
        COMListCombo.Visible = False
        COMPortLabel.Visible = False
        BaudLabel.Visible = False
        BaudRateCombo.Visible = False
        SerialIDLabel.Visible = False
        SerialIDCombo.Visible = False

        ResetCommButton.PerformClick()
    End Sub

    Private Sub RS485ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RS485ToolStripMenuItem.Click
        communicationType = 2
        RS485ToolStripMenuItem.Checked = True
        USBToolStripMenuItem.Checked = False

        'Disable USB fields
        IDLabel.Visible = False
        DeviceListCombo.Visible = False

        'Enable RS485 fields
        COMListCombo.Visible = True
        COMPortLabel.Visible = True
        BaudLabel.Visible = True
        BaudRateCombo.Visible = True
        SerialIDLabel.Visible = True
        SerialIDCombo.Visible = True

        ResetCommButton.PerformClick()
    End Sub

    Private Sub ResetCommButton_Click(sender As Object, e As EventArgs) Handles ResetCommButton.Click
        Dim availablePorts As String() = SerialPort.GetPortNames()
        Dim numberHIDs As Integer
        Dim retVal As Integer
        Dim i As Short

        If (communicationType = 1) Then
            If (ComStatus = False) Then
                DeviceListCombo.Items.Clear()
                DeviceListCombo.Text = ""

                ' Get the number of connected Commander-HIDs
                numberHIDs = GetCommanderHIDnumber()

                If numberHIDs > 0 Then
                    For i = 0 To numberHIDs - 1
                        retVal = GetCommanderHIDName(i, HidName)
                        DeviceListCombo.Items.Add(HidName)
                    Next i
                    DeviceListCombo.Sorted = True
                    DeviceListCombo.SelectedIndex = 0
                End If
            Else
                MsgBox("Must disconnect first")
            End If

        ElseIf (communicationType = 2) Then
            COMListCombo.Items.Clear()
            COMListCombo.Text = ""

            Dim port As String
            For Each port In availablePorts
                COMListCombo.Items.Add(port)
            Next

            If (COMListCombo.Items.Count > 0) Then
                COMListCombo.SelectedIndex = 0
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CloseCommanderHID(HidHandle)
        End
    End Sub




    'ToolStrip Commands

    Private Sub ToolStripCommand_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripCommand.KeyDown
        Dim commandStr As New String("", 63)
        Dim replyStr As String

        If (e.KeyCode = 13) Then 'keycode 13 = carriage return
            commandStr = ToolStripCommand.Text
            replyStr = SendReceiveCommander(commandStr)

            If replyStr.Length > 0 Then
                ToolStripReply.Text = replyStr
                ToolStripCommand.Text = ""
            Else
                ToolStripCommand.Text = ""
            End If
        End If
    End Sub

    Private Sub DigitalIOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DigitalIOToolStripMenuItem.Click
        If (viewDigitalIO = False) Then
            viewDigitalIO = True
            digitalIOForm.TopLevel = False
            Me.Controls.Add(digitalIOForm)
            digitalIOForm.Show()
            digitalIOForm.Top = 67
            digitalIOForm.BringToFront()
            DigitalIOToolStripMenuItem.Checked = True
            If (ComStatus = True) Then
                digitalIOForm.TimerIO.Enabled = True
            End If
        Else
            viewDigitalIO = False
            digitalIOForm.TimerIO.Enabled = False
            Me.Controls.Remove(digitalIOForm)
            DigitalIOToolStripMenuItem.Checked = False
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim retVal As Integer

        StopAllTimers() 'stop all timers before disconnecting. allows for more seemless disconnect.
        If (communicationType = 1 And ComStatus = True) Then
            retVal = CloseCommanderHID(HidHandle)
            handleOpened = False
            ComStatus = False
        ElseIf (communicationType = 2 And ComStatus = True) Then
            globalSerialPort.Close()
            ComStatus = False
        End If

        Me.Close()
    End Sub


    Private Sub TerminalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TerminalToolStripMenuItem.Click
        If (viewTerminal = False) Then
            viewTerminal = True
            TerminalForm.TopLevel = False
            Me.Controls.Add(TerminalForm)
            TerminalForm.Show()
            TerminalForm.Top = 67
            TerminalForm.BringToFront()
            TerminalToolStripMenuItem.Checked = True
        Else
            viewTerminal = False
            Me.Controls.Remove(TerminalForm)
            TerminalToolStripMenuItem.Checked = False
        End If
    End Sub

    'Motor/Encoder Status
    Private Sub TimerMST_Tick()
        Dim retVal As Short
        Dim commandStr As New String("", 63)
        Dim replyStr As New String("", 63)
        Dim value As Integer


        On Error GoTo SKIP

        If (MSTtimerStep = 0) Then
            commandStr = "MSTX"
            replyStr = SendReceiveCommander(commandStr)
            value = replyStr
            txtMSTX.Text = "0x" & CStr(Hex(value))

            If (BitAND(value, 1) = 1) Then
                MSTX.Text = "Accelerating"                  'Bit0 Acceleration
            ElseIf (BitAND(value, 2) = 2) Then
                MSTX.Text = "Decelerating"                  'Bit1 Deceleration
            ElseIf (BitAND(value, 4) = 4) Then
                MSTX.Text = "Constant"                      'Bit2 Constant
            ElseIf (BitAND(value, 256) = 256) Then
                MSTX.Text = "+LIM ERR"                      'Bit8 +LIM ERR
            ElseIf (BitAND(value, 512) = 512) Then
                MSTX.Text = "-LIM ERR"                      'Bit9 -LIM ERR
            ElseIf (BitAND(value, 1024) = 1024) Then
                MSTX.Text = "ALARM ERR"                     'Bit10 ALARM ERR
            ElseIf (BitAND(value, 65536) = 65536) Then
                MSTX.Text = "EMG ERR"                       'Bit16 EMG ERR
            ElseIf (BitAND(value, 131072) = 131072) Then
                MSTX.Text = "SD STOP"                       'Bit17 SD Stop
            ElseIf (BitAND(value, 262144) = 262144) Then
                MSTX.Text = "Wait INP"                      'Bit18 Wait INP
            ElseIf (BitAND(value, 524288) = 524288) Then
                MSTX.Text = "Wait Ext Start"                'Bit19 Wait Ext Start
            Else
                MSTX.Text = "Idle"
            End If
            If (BitAND(value, 8) = 8) Then                  'Bit3 Alarm
                AlarmX.BackColor = Color.Red
            Else
                AlarmX.BackColor = Color.White
            End If
            If (BitAND(value, 16) = 16) Then                'Bit4 +Limit
                PLimitX.BackColor = Color.Red
            Else
                PLimitX.BackColor = Color.White
            End If
            If (BitAND(value, 32) = 32) Then                'Bit5 -Limit
                NLimitX.BackColor = Color.Red
            Else
                NLimitX.BackColor = Color.White
            End If
            If (BitAND(value, 64) = 64) Then                'Bit6 Home
                HomeX.BackColor = Color.Green
            Else
                HomeX.BackColor = Color.White
            End If
            If (BitAND(value, 128) = 128) Then              'Bit7 Slow Down
                DecelX.BackColor = Color.Blue
            Else
                DecelX.BackColor = Color.White
            End If
            If (BitAND(value, 2048) = 2048) Then            'Bit11 Inposition
                InPositionX.BackColor = Color.Green
            Else
                InPositionX.BackColor = Color.White
            End If
            If (BitAND(value, 4096) = 4096) Then            'Bit12 ERC
                ClearOutX.BackColor = Color.Blue
            Else
                ClearOutX.BackColor = Color.White
            End If
            If (BitAND(value, 16384) = 16384) Then            'Bit14 CSTA
                ExternalStart.BackColor = Color.Green
            Else
                ExternalStart.BackColor = Color.White
            End If
            If (BitAND(value, 32768) = 32768) Then          'Bit15 CEMG
                EmergencyStop.BackColor = Color.Red
            Else
                EmergencyStop.BackColor = Color.White
            End If
            MSTtimerStep = MSTtimerStep + 1
        ElseIf (MSTtimerStep = 1) Then
            commandStr = "MSTY"
            replyStr = SendReceiveCommander(commandStr)
            value = replyStr
            txtMSTY.Text = "0x" & CStr(Hex(value))

            If (BitAND(value, 1) = 1) Then
                MSTY.Text = "Accelerating"
            ElseIf (BitAND(value, 2) = 2) Then
                MSTY.Text = "Decelerating"
            ElseIf (BitAND(value, 4) = 4) Then
                MSTY.Text = "Constant"
            ElseIf (BitAND(value, 256) = 256) Then
                MSTY.Text = "+LIM ERR"
            ElseIf (BitAND(value, 512) = 512) Then
                MSTY.Text = "-LIM ERR"
            ElseIf (BitAND(value, 1024) = 1024) Then
                MSTY.Text = "ALARM ERR"
            ElseIf (BitAND(value, 65536) = 65536) Then
                MSTY.Text = "EMG ERR"                       'Bit16 EMG ERR
            ElseIf (BitAND(value, 131072) = 131072) Then
                MSTY.Text = "SD STOP"                       'Bit17 SD Stop
            ElseIf (BitAND(value, 262144) = 262144) Then
                MSTY.Text = "Wait INP"
            ElseIf (BitAND(value, 262144) = 262144) Then
                MSTY.Text = "Wait Ext Start"
            Else
                MSTY.Text = "Idle"
            End If
            If (BitAND(value, 8) = 8) Then
                AlarmY.BackColor = Color.Red
            Else
                AlarmY.BackColor = Color.White
            End If
            If (BitAND(value, 16) = 16) Then
                PLimitY.BackColor = Color.Red
            Else
                PLimitY.BackColor = Color.White
            End If
            If (BitAND(value, 32) = 32) Then
                NLimitY.BackColor = Color.Red
            Else
                NLimitY.BackColor = Color.White
            End If
            If (BitAND(value, 64) = 64) Then
                HomeY.BackColor = Color.Green
            Else
                HomeY.BackColor = Color.White
            End If
            If (BitAND(value, 128) = 128) Then
                DecelY.BackColor = Color.Blue
            Else
                DecelY.BackColor = Color.White
            End If
            If (BitAND(value, 2048) = 2048) Then
                InPositionY.BackColor = Color.Green
            Else
                InPositionY.BackColor = Color.White
            End If
            If (BitAND(value, 4096) = 4096) Then
                ClearOutY.BackColor = Color.Blue
            Else
                ClearOutY.BackColor = Color.White
            End If
            MSTtimerStep = MSTtimerStep + 1
        ElseIf (MSTtimerStep = 2) Then
            commandStr = "PX"
            replyStr = SendReceiveCommander(commandStr)
            PX.Text = replyStr

            commandStr = "PY"
            replyStr = SendReceiveCommander(commandStr)
            PY.Text = replyStr

            commandStr = "EX"
            replyStr = SendReceiveCommander(commandStr)
            EX.Text = replyStr

            commandStr = "EY"
            replyStr = SendReceiveCommander(commandStr)
            EY.Text = replyStr

            MSTtimerStep = MSTtimerStep + 1
        End If

        If (MSTtimerStep > 2) Then
            MSTtimerStep = 0
        End If

SKIP:


    End Sub

    Private Sub ClearX_Click(sender As Object, e As EventArgs) Handles ClearX.Click
        Dim commandStr As New String("", 63)
        Dim replyStr As New String("", 63)

        commandStr = "CLRX"
        replyStr = SendReceiveCommander(commandStr)
    End Sub

    Private Sub ClearY_Click(sender As Object, e As EventArgs) Handles ClearY.Click
        Dim commandStr As New String("", 63)
        Dim replyStr As New String("", 63)

        commandStr = "CLRY"
        replyStr = SendReceiveCommander(commandStr)
    End Sub

    Private Sub btnClearX_Click(sender As Object, e As EventArgs) Handles btnClearX.Click
        Dim commandStr As New String("", 63)
        Dim replyStr As New String("", 63)

        'Motor postion counter = 0
        commandStr = "PX=0"
        replyStr = SendReceiveCommander(commandStr)

        'Encoder postion counter = 0
        commandStr = "EX=0"
        replyStr = SendReceiveCommander(commandStr)

    End Sub

    Private Sub btnClearY_Click(sender As Object, e As EventArgs) Handles btnClearY.Click
        Dim commandStr As New String("", 63)
        Dim replyStr As New String("", 63)

        'Motor postion counter = 0
        commandStr = "PY=0"
        replyStr = SendReceiveCommander(commandStr)

        'Encoder postion counter = 0
        commandStr = "EY=0"
        replyStr = SendReceiveCommander(commandStr)

    End Sub

    'Motor Control
    'Enable
    Private Sub EO1_Click(sender As Object, e As System.EventArgs) Handles EO1.Click
        Dim commandStr As New String("", 63)
        Dim replyStr As New String("", 63)
        Dim value As Integer

        commandStr = "EO1"
        replyStr = SendReceiveCommander(commandStr)
        value = replyStr

        If (value = 1) Then
            commandStr = "EO1=0"
        Else
            commandStr = "EO1=1"
        End If

        replyStr = SendReceiveCommander(commandStr)
    End Sub

    Private Sub EO2_Click(sender As Object, e As System.EventArgs) Handles EO2.Click
        Dim commandStr As New String("", 63)
        Dim replyStr As New String("", 63)
        Dim value As Integer

        commandStr = "EO2"
        replyStr = SendReceiveCommander(commandStr)
        value = replyStr

        If (value = 1) Then
            commandStr = "EO2=0"
        Else
            commandStr = "EO2=1"
        End If

        replyStr = SendReceiveCommander(commandStr)
    End Sub

    'Move
    Private Sub TargetMove_Click(sender As Object, e As EventArgs) Handles TargetMove.Click
        Dim ret As Integer
        Dim commandStr As New String("", 63)
        Dim replyStr As New String("", 63)
        Dim tempStr As New String("", 63)

        'Set the selected speeds before issuing the move
        Call SetSpeed()

        ret = 0
        If (XCheckBox.Checked = True) Then
            ret = 1
            SetSSPDM("X")
            commandStr = "X" + XTarget.Text
        End If
        If (YCheckBox.Checked = True) Then
            SetSSPDM("Y")
            If (ret = 1) Then
                commandStr = commandStr + "Y" + YTarget.Text
            Else
                ret = 1
                commandStr = "Y" + YTarget.Text
            End If
        End If

        replyStr = SendReceiveCommander(commandStr)
    End Sub

    Private Sub TargetZeroMove_Click(sender As Object, e As EventArgs) Handles TargetZeroMove.Click
        Dim ret As Integer
        Dim commandStr As New String("", 63)
        Dim replyStr As New String("", 63)

        'Set the selected speeds before issuing the move
        Call SetSpeed()

        ret = 0
        If (XCheckBox.Checked = True) Then
            ret = 1
            SetSSPDM("X")
            commandStr = "X0"
        End If
        If (YCheckBox.Checked = True) Then
            SetSSPDM("Y")
            If (ret = 1) Then
                commandStr = commandStr + "Y0"
            Else
                ret = 1
                commandStr = "Y0"
            End If
        End If

        If (ret = 1) Then
            replyStr = SendReceiveCommander(commandStr)
        End If
    End Sub

    Private Sub btnJogMinus_Click(sender As Object, e As EventArgs) Handles btnJogMinus.Click
        Dim commandStr As New String("", 63)
        Dim replyStr As New String("", 63)
        Dim tempStr As String

        'Set the selected speeds before issuing the move
        Call SetSpeed()

        If (XCheckBox.Checked = True) Then
            SetSSPDM("X")
            commandStr = "MSTX"
            replyStr = SendReceiveCommander(commandStr)
            tempStr = BitAND(replyStr, 7)
            If tempStr = 0 Then
                commandStr = "JX-"
                replyStr = SendReceiveCommander(commandStr)
                tempStr = Mid(replyStr, 1, 2)
                If (tempStr <> "OK") Then
                    MsgBox("X Axis Error: " + replyStr)
                End If
            Else
                commandStr = "STOPX"
                replyStr = SendReceiveCommander(commandStr)
            End If
        End If

        If (YCheckBox.Checked = True) Then
            SetSSPDM("Y")
            commandStr = "MSTY"
            replyStr = SendReceiveCommander(commandStr)
            tempStr = BitAND(replyStr, 7)
            If tempStr = 0 Then
                commandStr = "JY-"
                replyStr = SendReceiveCommander(commandStr)
                tempStr = Mid(replyStr, 1, 2)
                If (tempStr <> "OK") Then
                    MsgBox("Y Axis Error: " + replyStr)
                End If
            Else
                commandStr = "STOPY"
                replyStr = SendReceiveCommander(commandStr)
            End If
        End If
    End Sub

    Private Sub btnJogPlus_Click(sender As Object, e As EventArgs) Handles btnJogPlus.Click
        Dim commandStr As New String("", 63)
        Dim replyStr As New String("", 63)
        Dim tempStr As String

        'Set the selected speeds before issuing the move
        Call SetSpeed()

        If (XCheckBox.Checked = True) Then
            SetSSPDM("X")
            commandStr = "MSTX"
            replyStr = SendReceiveCommander(commandStr)
            tempStr = BitAND(replyStr, 7)

            If tempStr = 0 Then
                commandStr = "JX+"
                replyStr = SendReceiveCommander(commandStr)
                tempStr = Mid(replyStr, 1, 2)
                If (tempStr <> "OK") Then
                    MsgBox("X Axis Error: " + replyStr)
                End If
            Else
                commandStr = "STOPX"
                replyStr = SendReceiveCommander(commandStr)
            End If

        End If

        If (YCheckBox.Checked = True) Then
            SetSSPDM("Y")
            commandStr = "MSTY"
            replyStr = SendReceiveCommander(commandStr)
            tempStr = BitAND(replyStr, 7)

            If tempStr = 0 Then
                commandStr = "JY+"
                replyStr = SendReceiveCommander(commandStr)
                tempStr = Mid(replyStr, 1, 2)
                If (tempStr <> "OK") Then
                    MsgBox("Y Axis Error: " + replyStr)
                End If
            Else
                commandStr = "STOPY"
                replyStr = SendReceiveCommander(commandStr)
            End If

        End If
    End Sub





    'Stop
    Private Sub StopDecelButton_Click(sender As Object, e As EventArgs) Handles StopDecelButton.Click
        Dim commandStr As New String("", 63)
        Dim replyStr As New String("", 63)

        If ((XCheckBox.Checked = True) And (YCheckBox.Checked = True)) Then
            commandStr = "STOP"
            replyStr = SendReceiveCommander(commandStr)
            Exit Sub
        End If

        If (XCheckBox.Checked = True) Then
            commandStr = "STOPX"
            replyStr = SendReceiveCommander(commandStr)
        End If
        If (YCheckBox.Checked = True) Then
            commandStr = "STOPY"
            replyStr = SendReceiveCommander(commandStr)
        End If

    End Sub

    Private Sub StopImmedButton_Click(sender As Object, e As EventArgs) Handles StopImmedButton.Click
        Dim commandStr As New String("", 63)
        Dim replyStr As New String("", 63)

        If ((XCheckBox.Checked = True) And (YCheckBox.Checked = True)) Then
            commandStr = "ABORT"
            replyStr = SendReceiveCommander(commandStr)
            Exit Sub
        End If

        If (XCheckBox.Checked = True) Then
            commandStr = "ABORTX"
            replyStr = SendReceiveCommander(commandStr)
        End If
        If (YCheckBox.Checked = True) Then
            commandStr = "ABORTY"
            replyStr = SendReceiveCommander(commandStr)
        End If
    End Sub

    Private Sub StopEmgButton_Click(sender As Object, e As EventArgs) Handles StopEmgButton.Click
        Dim commandStr As New String("", 63)
        Dim replyStr As New String("", 63)

        commandStr = "ESTOP"
        replyStr = SendReceiveCommander(commandStr)

    End Sub

    'Move Type
    Private Sub rbABS_Click(sender As Object, e As EventArgs) Handles rbABS.Click
        Dim commandStr As New String("", 63)
        Dim replyStr As New String("", 63)

        commandStr = "ABS"
        replyStr = SendReceiveCommander(commandStr)

    End Sub

    Private Sub rbINC_Click(sender As Object, e As EventArgs) Handles rbINC.Click
        Dim commandStr As New String("", 63)
        Dim replyStr As New String("", 63)

        commandStr = "INC"
        replyStr = SendReceiveCommander(commandStr)

    End Sub

    Private Sub SCVx_Click(sender As Object, e As EventArgs) Handles SCVx.Click
        Dim commandStr As New String("", 63)
        Dim replyStr As New String("", 63)
        Dim value As Integer

        commandStr = "SCVX"
        replyStr = SendReceiveCommander(commandStr)
        value = replyStr

        If (value = 1) Then
            commandStr = "SCVX=0"
        Else
            commandStr = "SCVX=1"
        End If

        replyStr = SendReceiveCommander(commandStr)
    End Sub

    Private Sub SCVy_Click(sender As Object, e As EventArgs) Handles SCVy.Click
        Dim commandStr As New String("", 63)
        Dim replyStr As New String("", 63)
        Dim value As Integer

        commandStr = "SCVY"
        replyStr = SendReceiveCommander(commandStr)
        value = replyStr

        If (value = 1) Then
            commandStr = "SCVY=0"
        Else
            commandStr = "SCVY=1"
        End If

        replyStr = SendReceiveCommander(commandStr)
    End Sub




    Private Sub UpdateControlStatusLogic()
        Dim retVal As Short
        Dim commandStr As New String("", 63)
        Dim replyStr As New String("", 63)
        Dim value As Integer
        Dim bitvalue As Integer
        Dim lvalue As Long
        Dim SuggSSPDMmode As Integer
        Dim HighSpeed As Integer
        Dim LowSpeed As Integer
        Dim AccelTime As Single
        Dim AccelRate As Integer
        Dim DecelTime As Single
        Dim DecelRate As Integer
        Dim ACCelAxis As Integer
        Dim DecelAxis As Integer
        Dim HighSpeedLow As Integer
        Dim LowSpeedLow As Integer
        Dim UpdateRate As Boolean = True

        On Error GoTo SKIP

        If (ComStatus = True) Then

            If timerStep = 1 Then
                commandStr = "EO"
                replyStr = SendReceiveCommander(commandStr)
                lvalue = replyStr

                If (BitAND(lvalue, 1) = 1) Then
                    EO1.BackColor = Color.Red
                Else
                    EO1.BackColor = Color.White
                End If
                If (BitAND(lvalue, 2) = 2) Then
                    EO2.BackColor = Color.Red
                Else
                    EO2.BackColor = Color.White
                End If
            ElseIf (timerStep = 2) Then
                commandStr = "SCVX"
                replyStr = SendReceiveCommander(commandStr)
                lvalue = replyStr

                If (lvalue = 1) Then
                    SCVx.BackColor = Color.Green
                Else
                    SCVx.BackColor = Color.White
                End If

                commandStr = "SCVY"
                replyStr = SendReceiveCommander(commandStr)
                lvalue = replyStr

                If (lvalue = 1) Then
                    SCVy.BackColor = Color.Green
                Else
                    SCVy.BackColor = Color.White
                End If
            ElseIf (timerStep = 3) Then

                If ACCSel = False AndAlso AccelCombo.DroppedDown = False Then
                    If (AccelCombo.SelectedIndex = 0) Then
                        commandStr = "ACC"
                    ElseIf (AccelCombo.SelectedIndex = 1) Then
                        commandStr = "ACCX"
                    Else
                        commandStr = "ACCY"
                    End If
                    replyStr = SendReceiveCommander(commandStr)
                    AccelText.Text = replyStr
                    ACCelAxis = AccelCombo.SelectedIndex
                    AccelTime = AccelText.Text / 1000 ' Time in Sec
                Else
                    UpdateRate = False
                End If


                If DECSel = False AndAlso DecelCombo.DroppedDown = False Then
                    If (DecelCombo.SelectedIndex = 0) Then
                        commandStr = "DEC"
                    ElseIf (DecelCombo.SelectedIndex = 1) Then
                        commandStr = "DECX"
                    Else
                        commandStr = "DECY"
                    End If
                    replyStr = SendReceiveCommander(commandStr)
                    DecelText.Text = replyStr
                    DecelAxis = DecelCombo.SelectedIndex
                    DecelTime = DecelText.Text / 1000  ' Time in Sec
                Else
                    UpdateRate = False
                End If

                If HSPDSel = False AndAlso HighSpeedCombo.DroppedDown = False Then
                    If (HighSpeedCombo.SelectedIndex = 0) Then
                        commandStr = "HSPD"
                    ElseIf (HighSpeedCombo.SelectedIndex = 1) Then
                        commandStr = "HSPDX"
                    Else
                        commandStr = "HSPDY"
                    End If
                    replyStr = SendReceiveCommander(commandStr)
                    HighSpeedText.Text = replyStr

                    If HighSpeedCombo.SelectedIndex = ACCelAxis Then
                        HighSpeed = HighSpeedText.Text
                    Else
                        If (ACCelAxis = 0) Then
                            commandStr = "HSPD"
                        ElseIf (ACCelAxis = 1) Then
                            commandStr = "HSPDX"
                        Else
                            commandStr = "HSPDY"
                        End If
                        replyStr = SendReceiveCommander(commandStr)
                        HighSpeed = replyStr
                        If HighSpeed = 0 Then
                            commandStr = "HSPD"
                            replyStr = SendReceiveCommander(commandStr)
                            HighSpeed = replyStr
                        End If
                    End If

                    If HighSpeedCombo.SelectedIndex = DecelAxis Then
                        HighSpeedLow = HighSpeedText.Text
                    Else
                        If (DecelAxis = 0) Then
                            commandStr = "HSPD"
                        ElseIf (DecelAxis = 1) Then
                            commandStr = "HSPDX"
                        Else
                            commandStr = "HSPDY"
                        End If
                        replyStr = SendReceiveCommander(commandStr)
                        HighSpeedLow = replyStr
                        If HighSpeedLow = 0 Then
                            commandStr = "HSPD"
                            replyStr = SendReceiveCommander(commandStr)
                            HighSpeedLow = replyStr
                        End If
                    End If
                Else
                    UpdateRate = False
                End If

                If LSPDSel = False AndAlso LowSpeedCombo.DroppedDown = False Then
                    If (LowSpeedCombo.SelectedIndex = 0) Then
                        commandStr = "LSPD"
                    ElseIf (LowSpeedCombo.SelectedIndex = 1) Then
                        commandStr = "LSPDX"
                    Else
                        commandStr = "LSPDY"
                    End If
                    replyStr = SendReceiveCommander(commandStr)
                    LowSpeedText.Text = replyStr

                    If LowSpeedCombo.SelectedIndex = DecelAxis Then
                        LowSpeedLow = LowSpeedText.Text
                    Else
                        If (DecelAxis = 0) Then
                            commandStr = "LSPD"
                        ElseIf (DecelAxis = 1) Then
                            commandStr = "LSPDX"
                        Else
                            commandStr = "LSPDY"
                        End If
                        replyStr = SendReceiveCommander(commandStr)
                        LowSpeedLow = replyStr
                        If LowSpeedLow = 0 Then
                            commandStr = "LSPD"
                            replyStr = SendReceiveCommander(commandStr)
                            LowSpeedLow = replyStr
                        End If
                    End If

                    If LowSpeedCombo.SelectedIndex = ACCelAxis Then
                        LowSpeed = LowSpeedText.Text
                    Else
                        If (ACCelAxis = 0) Then
                            commandStr = "LSPD"
                        ElseIf (ACCelAxis = 1) Then
                            commandStr = "LSPDX"
                        Else
                            commandStr = "LSPDY"

                        End If
                        replyStr = SendReceiveCommander(commandStr)
                        LowSpeed = replyStr
                        If LowSpeed = 0 Then
                            commandStr = "LSPD"
                            replyStr = SendReceiveCommander(commandStr)
                            LowSpeed = replyStr
                        End If
                    End If
                Else
                    UpdateRate = False
                End If

                If UpdateRate = True Then
                    AccelRate = (HighSpeed - LowSpeed) / AccelTime
                    DecelRate = (HighSpeedLow - LowSpeedLow) / DecelTime

                    ACCrate.Text = AccelRate.ToString + " P/S/S"
                    DECrate.Text = DecelRate.ToString + " P/S/S"
                End If

                commandStr = "MM"
                replyStr = SendReceiveCommander(commandStr)
                If (Mid(replyStr, 1, 1) = "0") Then
                    rbABS.Checked = True
                Else
                    rbINC.Checked = True
                End If


            ElseIf (timerStep = 4) Then

                ' Color of box based on operation
                If (communicationType = 1) Then
                    commandStr = "MSTX"
                    replyStr = SendReceiveCommander(commandStr)
                    value = replyStr
                    If (BitAND(value, 1) = 1) Then
                        XTarget.BackColor = Color.Khaki         'Bit0 Acceleration
                    ElseIf (BitAND(value, 2) = 2) Then
                        XTarget.BackColor = Color.Salmon         'Bit1 Deceleration
                    ElseIf (BitAND(value, 4) = 4) Then
                        XTarget.BackColor = Color.PaleGreen  'Bit2 Constant
                    ElseIf (BitAND(value, 256) = 256) Then
                        XTarget.BackColor = Color.Red
                    ElseIf (BitAND(value, 512) = 512) Then
                        XTarget.BackColor = Color.Red
                    ElseIf (BitAND(value, 1024) = 1024) Then
                        XTarget.BackColor = Color.Red
                    ElseIf (BitAND(value, 65536) = 65536) Then
                        XTarget.BackColor = Color.Red
                    Else
                        XTarget.BackColor = Color.White
                    End If

                    commandStr = "MSTY"
                    replyStr = SendReceiveCommander(commandStr)
                    value = replyStr
                    If (BitAND(value, 1) = 1) Then
                        YTarget.BackColor = Color.Khaki         'Bit0 Acceleration
                    ElseIf (BitAND(value, 2) = 2) Then
                        YTarget.BackColor = Color.Salmon         'Bit1 Deceleration
                    ElseIf (BitAND(value, 4) = 4) Then
                        YTarget.BackColor = Color.PaleGreen  'Bit2 Constant
                    ElseIf (BitAND(value, 256) = 256) Then
                        YTarget.BackColor = Color.Red
                    ElseIf (BitAND(value, 512) = 512) Then
                        YTarget.BackColor = Color.Red
                    ElseIf (BitAND(value, 1024) = 1024) Then
                        YTarget.BackColor = Color.Red
                    ElseIf (BitAND(value, 65536) = 65536) Then
                        YTarget.BackColor = Color.Red
                    Else
                        YTarget.BackColor = Color.White
                    End If

                End If
            End If
        End If

SKIP:
        timerStep = timerStep + 1
        If (timerStep > 4) Then
            timerStep = 0
        End If


    End Sub



    Private Sub HighSpeedText_LostFocus(sender As Object, e As EventArgs) Handles HighSpeedText.LostFocus
        SetHighSpeed()
        HSPDSel = False
    End Sub

    Private Sub LowSpeedText_LostFocus(sender As Object, e As EventArgs) Handles LowSpeedText.LostFocus
        SetLowSpeed()
        LSPDSel = False
    End Sub

    Private Sub AccelText_LostFocus(sender As Object, e As EventArgs) Handles AccelText.LostFocus
        SetAccel()
        ACCSel = False
    End Sub

    Private Sub DecelText_LostFocus(sender As Object, e As EventArgs) Handles DecelText.LostFocus
        SetDecel()
        DECSel = False
    End Sub

    Private Sub LowSpeedText_GotFocus(sender As Object, e As EventArgs) Handles LowSpeedText.GotFocus
        LSPDSel = True
    End Sub

    Private Sub HighSpeedText_GotFocus(sender As Object, e As EventArgs) Handles HighSpeedText.GotFocus
        HSPDSel = True
    End Sub

    Private Sub AccelText_GotFocus(sender As Object, e As EventArgs) Handles AccelText.GotFocus
        ACCSel = True
    End Sub

    Private Sub DecelText_GotFocus(sender As Object, e As EventArgs) Handles DecelText.GotFocus
        DECSel = True
    End Sub

    Private Sub HighSpeedText_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles HighSpeedText.KeyDown
        If (e.KeyCode = 13) Then 'keycode 13 = carriage return
            SetHighSpeed()
        End If
    End Sub

    Private Sub LowSpeedText_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LowSpeedText.KeyDown
        If (e.KeyCode = 13) Then 'keycode 13 = carriage return
            SetLowSpeed()
        End If
    End Sub

    Private Sub AccelText_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles AccelText.KeyDown
        If (e.KeyCode = 13) Then 'keycode 13 = carriage return
            SetAccel()
        End If
    End Sub

    Private Sub DecelText_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DecelText.KeyDown
        If (e.KeyCode = 13) Then 'keycode 13 = carriage return
            SetDecel()
        End If
    End Sub

    Private Sub SetSpeed()

        'Set the high speed
        SetHighSpeed()

        'Set the low speed
        SetLowSpeed()

        'Set the acceleration
        SetAccel()

        'Set the deceleration
        SetDecel()
    End Sub

    Private Sub SetHighSpeed()
        Dim commandStr As New String("", 63)
        Dim replyStr As New String("", 63)

        If (HighSpeedCombo.SelectedIndex = 0) Then
            commandStr = "HSPD=" + HighSpeedText.Text
        ElseIf (HighSpeedCombo.SelectedIndex = 1) Then
            commandStr = "HSPDX=" + HighSpeedText.Text
        Else
            commandStr = "HSPDY=" + HighSpeedText.Text
        End If
        replyStr = SendReceiveCommander(commandStr)
    End Sub

    Private Sub SetLowSpeed()
        Dim commandStr As New String("", 63)
        Dim replyStr As New String("", 63)

        If (LowSpeedCombo.SelectedIndex = 0) Then
            commandStr = "LSPD=" + LowSpeedText.Text
        ElseIf (LowSpeedCombo.SelectedIndex = 1) Then
            commandStr = "LSPDX=" + LowSpeedText.Text
        Else
            commandStr = "LSPDY=" + LowSpeedText.Text
        End If
        replyStr = SendReceiveCommander(commandStr)
    End Sub

    Private Sub SetAccel()
        Dim commandStr As New String("", 63)
        Dim replyStr As New String("", 63)

        If (AccelCombo.SelectedIndex = 0) Then
            commandStr = "ACC=" + AccelText.Text
        ElseIf (AccelCombo.SelectedIndex = 1) Then
            commandStr = "ACCX=" + AccelText.Text
        Else
            commandStr = "ACCY=" + AccelText.Text
        End If
        replyStr = SendReceiveCommander(commandStr)
    End Sub

    Private Sub SetDecel()
        Dim commandStr As New String("", 63)
        Dim replyStr As New String("", 63)

        If (DecelCombo.SelectedIndex = 0) Then
            commandStr = "DEC=" + DecelText.Text
        ElseIf (DecelCombo.SelectedIndex = 1) Then
            commandStr = "DECX=" + DecelText.Text
        Else
            commandStr = "DECY=" + DecelText.Text
        End If
        replyStr = SendReceiveCommander(commandStr)
    End Sub

    Private Sub SetSSPDM(Axis As String)
        Dim SSPDMmode As String
        Dim TargetSpeed As Integer
        Dim commandStr As New String("", 63)
        Dim replyStr As New String("", 63)
        Dim value As Integer

        If AutoSetSSPDM.Checked = True Then
            TargetSpeed = 0

            'What is the target Speed?

            commandStr = "HSPD" + Axis
            replyStr = SendReceiveCommander(commandStr)
            value = replyStr

            If value = 0 Then
                commandStr = "HSPD"
                replyStr = SendReceiveCommander(commandStr)
                value = replyStr
            End If

            TargetSpeed = value

            If TargetSpeed < 65000 Then
                SSPDMmode = "1"
            ElseIf TargetSpeed < 130000 Then
                SSPDMmode = "2"
            ElseIf TargetSpeed < 325000 Then
                SSPDMmode = "3"
            ElseIf TargetSpeed < 650000 Then
                SSPDMmode = "4"
            ElseIf TargetSpeed < 1300000 Then
                SSPDMmode = "5"
            ElseIf TargetSpeed < 3200000 Then
                SSPDMmode = "6"
            Else
                SSPDMmode = "7"
            End If

            commandStr = "SSPDM" + Axis + "=" + SSPDMmode
            replyStr = SendReceiveCommander(commandStr)
        End If

    End Sub

End Class
