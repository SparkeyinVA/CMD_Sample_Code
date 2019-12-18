Option Explicit On
Imports System.IO.Ports

Module CommanderModule
    Public Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Integer)

    Public Declare Function GetCommanderHIDnumber Lib "CMDHidApi" () As Integer
    Public Declare Function GetCommanderHIDName Lib "CMDHidApi" (ByVal HidIndex As Integer, ByVal HidName As String) As Integer
    Public Declare Function OpenCommanderHID Lib "CMDHidApi" (ByRef HidHandle As Integer, ByVal HidName As String) As Integer
    Public Declare Function CloseCommanderHID Lib "CMDHidApi" (ByVal HidHandle As Integer) As Integer
    Public Declare Function SendReceiveCommanderHID Lib "CMDHidApi" (ByVal HidHandle As Integer, ByVal command_Renamed As String, ByVal reply As String) As Integer

    Public GlobalModel As String = "CMD-4CR"
    Public Version As Version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version
    Public VersionMajor As Integer = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Major
    Public VersionMinor As Integer = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Minor
    Public DateTime As DateTime = New DateTime(2000, 1, 1).AddDays(Version.Build).AddSeconds(Version.Revision * 2)
    Public GlobalBuildVersion As String = $"{Version} ({DateTime})"
    Public GlobalSoftwareVersion As String = Str((VersionMajor * 100) + VersionMinor)
    Public maxLines As Integer
    Public globalCounter As Long = 0
    Public HidHandle As Integer
    Public handleOpened As Boolean
    Public ComStatus As Boolean
    Public pausePolling As Boolean
    Public HidName As New String("", 15)
    Public deviceID As String
    Public communicationType As Integer
    Public globalSerialPort As New SerialPort
    Public baud As Integer

    Public digitalIOForm As New frmInputOutput
    Public viewDigitalIO As Boolean

    Public TerminalForm As New frmTerminal
    Public viewTerminal As Boolean

    Public Function SendReceiveCommander(ByVal cmdstr As String) As String
        Dim commandStr As New String("", 63)
        Dim replyStr As New String("", 63)
        Dim tempstr As String
        Dim ret As Integer
        Dim lvalue As Long
        Dim retryCount As Integer
        Dim retryReciveCount As Integer

        retryCount = 0
        retryReciveCount = 0
        ret = 0
        commandStr = cmdstr
Retry_Send:
        If (ComStatus = True) Then
            If (communicationType = 1) Then
                ret = SendReceiveCommanderHID(HidHandle, commandStr, replyStr)
            ElseIf (communicationType = 2) Then
                tempstr = ""
                commandStr = "@" & frmMain.SerialIDCombo.Text & cmdstr & Chr(13)
                lvalue = commandStr.Length
RETRY_RECEIVE:
                globalSerialPort.Write(commandStr, 0, lvalue)

                Sleep(50)

                Try
                    tempstr = Chr(globalSerialPort.ReadByte)
                Catch ex As Exception
                    If retryReciveCount < 5 Then
                        retryReciveCount = retryReciveCount + 1
                        GoTo RETRY_RECEIVE
                    End If
                End Try

                replyStr = tempstr
                Do While (tempstr <> Chr(13))
                    tempstr = Chr(globalSerialPort.ReadByte)
                    If (tempstr <> Chr(13)) Then
                        replyStr = replyStr & tempstr
                    End If
                Loop
            End If

            SendReceiveCommander = replyStr
        Else
            SendReceiveCommander = "0"
        End If

        If (ret < 0) And (retryCount < 5) Then
            retryCount = retryCount + 1
            GoTo Retry_Send
        End If

        If (ret < 0) Then
            SendReceiveCommander = "0"
            ComStatus = False
            MsgBox("Target power OFF")
            Call frmMain.ConnectButton.PerformClick()
            Call frmMain.ResetCommButton.PerformClick()
        End If
        Return SendReceiveCommander
    End Function
    Public Sub MemSet(ByVal Buffer() As Byte, ByVal Value As Byte, ByVal Amount As Long)
        'this function sets all elements of on array to 0
        Dim i

        For i = 0 To (Amount - 1)
            Buffer(i) = Value
        Next
    End Sub

    Public Function BitAND(ByVal tv1 As Long, ByVal tv2 As Long) As Long
        Dim result, temp1, temp2, v1, v2 As Long
        Dim i As Integer

        result = 0
        v1 = tv1
        v2 = tv2
        For i = 31 To 0 Step -1 '*** 32 bit numbers
            temp1 = v1 \ (2 ^ i) 'gets the bit of text1.text
            v1 = v1 - temp1 * (2 ^ i) 'subtracts it from the number
            temp2 = v2 \ (2 ^ i) 'gets the bit of text2.text
            v2 = v2 - temp2 * (2 ^ i) 'subtracts it from the number
            If temp1 = 1 And temp2 = 1 Then 'If both are equal to 1 then return a 1
                result = result + (2 ^ i) 'This returns a decimal number
            End If
        Next i
        BitAND = result
    End Function

    Public Function BitOR(ByVal tv1 As ULong, ByVal tv2 As ULong) As Long
        Dim result, temp1, temp2, v1, v2 As ULong
        Dim i As Integer

        result = 0
        v1 = tv1
        v2 = tv2
        For i = 31 To 0 Step -1 '32 bit numbers accepted
            temp1 = v1 \ (2 ^ i) 'gets the bit of text1.text
            v1 = v1 - temp1 * (2 ^ i) 'subtracts it from the number
            temp2 = v2 \ (2 ^ i) 'gets the bit of text2.text
            v2 = v2 - temp2 * (2 ^ i) 'subtracts it from the number
            If temp1 = 1 Or temp2 = 1 Then ' If one or the other or both=1 then return a 1
                result = result + (2 ^ i) 'This returns a decimal number
            End If
        Next i
        BitOR = result
    End Function

    Public Function BitShiftLeft(ByVal v1 As Long, ByVal v2 As Long) As Long
        Dim result As Long

        result = v1 * 2 ^ v2 ' This shifts the bits
        BitShiftLeft = result
    End Function

    Public Function BitShiftRight(ByVal v1 As Long, ByVal v2 As Long) As Long
        Dim result As Long

        result = v1 \ 2 ^ v2 ' This shifts the bits
        BitShiftRight = result
    End Function

    Public Sub StopAllTimers()
        If (viewDigitalIO = True) Then
            digitalIOForm.TimerIO.Enabled = False
        End If
    End Sub

    Public Sub StartAllTimers()
        If (viewDigitalIO = True) Then
            digitalIOForm.TimerIO.Enabled = True
        End If
    End Sub
End Module
