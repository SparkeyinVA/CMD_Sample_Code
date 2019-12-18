<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CommunicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.USBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RS485ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TerminalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DigitalIOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ResetCommButton = New System.Windows.Forms.ToolStripButton()
        Me.IDLabel = New System.Windows.Forms.ToolStripLabel()
        Me.DeviceListCombo = New System.Windows.Forms.ToolStripComboBox()
        Me.COMPortLabel = New System.Windows.Forms.ToolStripLabel()
        Me.COMListCombo = New System.Windows.Forms.ToolStripComboBox()
        Me.BaudLabel = New System.Windows.Forms.ToolStripLabel()
        Me.BaudRateCombo = New System.Windows.Forms.ToolStripComboBox()
        Me.SerialIDLabel = New System.Windows.Forms.ToolStripLabel()
        Me.SerialIDCombo = New System.Windows.Forms.ToolStripComboBox()
        Me.ConnectButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripCommand = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripReply = New System.Windows.Forms.ToolStripTextBox()
        Me.SettingsSaveDialog = New System.Windows.Forms.SaveFileDialog()
        Me.SettingsOpenDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.CommTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Build = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.EmergencyStop = New System.Windows.Forms.Panel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.ExternalStart = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ClearOutY = New System.Windows.Forms.Panel()
        Me.ClearOutX = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.InPositionY = New System.Windows.Forms.Panel()
        Me.InPositionX = New System.Windows.Forms.Panel()
        Me.btnClearY = New System.Windows.Forms.Button()
        Me.btnClearX = New System.Windows.Forms.Button()
        Me.ClearY = New System.Windows.Forms.Button()
        Me.ClearX = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DecelY = New System.Windows.Forms.Panel()
        Me.DecelX = New System.Windows.Forms.Panel()
        Me.AlarmY = New System.Windows.Forms.Panel()
        Me.NLimitY = New System.Windows.Forms.Panel()
        Me.HomeY = New System.Windows.Forms.Panel()
        Me.PLimitY = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.AlarmX = New System.Windows.Forms.Panel()
        Me.NLimitX = New System.Windows.Forms.Panel()
        Me.HomeX = New System.Windows.Forms.Panel()
        Me.PLimitX = New System.Windows.Forms.Panel()
        Me.PY = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PX = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.EY = New System.Windows.Forms.TextBox()
        Me.EX = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.MSTX = New System.Windows.Forms.TextBox()
        Me.txtMSTX = New System.Windows.Forms.TextBox()
        Me.txtMSTY = New System.Windows.Forms.TextBox()
        Me.MSTY = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.AutoSetSSPDM = New System.Windows.Forms.CheckBox()
        Me.DECrate = New System.Windows.Forms.Label()
        Me.ACCrate = New System.Windows.Forms.Label()
        Me.TargetMove = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SCVy = New System.Windows.Forms.Panel()
        Me.SCVx = New System.Windows.Forms.Panel()
        Me.btnJogPlus = New System.Windows.Forms.Button()
        Me.btnJogMinus = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.rbINC = New System.Windows.Forms.RadioButton()
        Me.rbABS = New System.Windows.Forms.RadioButton()
        Me.StopEmgButton = New System.Windows.Forms.Button()
        Me.StopImmedButton = New System.Windows.Forms.Button()
        Me.StopDecelButton = New System.Windows.Forms.Button()
        Me.TargetZeroMove = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.EO2 = New System.Windows.Forms.Panel()
        Me.EO1 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.YTarget = New System.Windows.Forms.TextBox()
        Me.XTarget = New System.Windows.Forms.TextBox()
        Me.YCheckBox = New System.Windows.Forms.CheckBox()
        Me.XCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.DecelText = New System.Windows.Forms.TextBox()
        Me.AccelText = New System.Windows.Forms.TextBox()
        Me.LowSpeedText = New System.Windows.Forms.TextBox()
        Me.HighSpeedText = New System.Windows.Forms.TextBox()
        Me.AccelCombo = New System.Windows.Forms.ComboBox()
        Me.DecelCombo = New System.Windows.Forms.ComboBox()
        Me.LowSpeedCombo = New System.Windows.Forms.ComboBox()
        Me.HighSpeedCombo = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CommunicationToolStripMenuItem, Me.TerminalToolStripMenuItem, Me.DigitalIOToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(821, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CommunicationToolStripMenuItem
        '
        Me.CommunicationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.USBToolStripMenuItem, Me.RS485ToolStripMenuItem})
        Me.CommunicationToolStripMenuItem.Name = "CommunicationToolStripMenuItem"
        Me.CommunicationToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.CommunicationToolStripMenuItem.Text = "Communication"
        '
        'USBToolStripMenuItem
        '
        Me.USBToolStripMenuItem.Name = "USBToolStripMenuItem"
        Me.USBToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.USBToolStripMenuItem.Text = "USB"
        '
        'RS485ToolStripMenuItem
        '
        Me.RS485ToolStripMenuItem.Name = "RS485ToolStripMenuItem"
        Me.RS485ToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.RS485ToolStripMenuItem.Text = "RS-485"
        '
        'TerminalToolStripMenuItem
        '
        Me.TerminalToolStripMenuItem.Name = "TerminalToolStripMenuItem"
        Me.TerminalToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.TerminalToolStripMenuItem.Text = "Terminal"
        '
        'DigitalIOToolStripMenuItem
        '
        Me.DigitalIOToolStripMenuItem.Name = "DigitalIOToolStripMenuItem"
        Me.DigitalIOToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.DigitalIOToolStripMenuItem.Text = "Input/Output"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetCommButton, Me.IDLabel, Me.DeviceListCombo, Me.COMPortLabel, Me.COMListCombo, Me.BaudLabel, Me.BaudRateCombo, Me.SerialIDLabel, Me.SerialIDCombo, Me.ConnectButton, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.ToolStripCommand, Me.ToolStripLabel2, Me.ToolStripReply})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(821, 27)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ResetCommButton
        '
        Me.ResetCommButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ResetCommButton.Image = CType(resources.GetObject("ResetCommButton.Image"), System.Drawing.Image)
        Me.ResetCommButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ResetCommButton.Name = "ResetCommButton"
        Me.ResetCommButton.Size = New System.Drawing.Size(24, 24)
        Me.ResetCommButton.Text = "ResetCommButton"
        '
        'IDLabel
        '
        Me.IDLabel.Name = "IDLabel"
        Me.IDLabel.Size = New System.Drawing.Size(18, 24)
        Me.IDLabel.Text = "ID"
        '
        'DeviceListCombo
        '
        Me.DeviceListCombo.BackColor = System.Drawing.SystemColors.Menu
        Me.DeviceListCombo.DropDownWidth = 150
        Me.DeviceListCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeviceListCombo.Name = "DeviceListCombo"
        Me.DeviceListCombo.Size = New System.Drawing.Size(120, 27)
        '
        'COMPortLabel
        '
        Me.COMPortLabel.Name = "COMPortLabel"
        Me.COMPortLabel.Size = New System.Drawing.Size(34, 24)
        Me.COMPortLabel.Text = "Ports"
        '
        'COMListCombo
        '
        Me.COMListCombo.AutoSize = False
        Me.COMListCombo.BackColor = System.Drawing.SystemColors.Menu
        Me.COMListCombo.Name = "COMListCombo"
        Me.COMListCombo.Size = New System.Drawing.Size(60, 23)
        '
        'BaudLabel
        '
        Me.BaudLabel.Name = "BaudLabel"
        Me.BaudLabel.Size = New System.Drawing.Size(34, 24)
        Me.BaudLabel.Text = "Baud"
        '
        'BaudRateCombo
        '
        Me.BaudRateCombo.BackColor = System.Drawing.SystemColors.Menu
        Me.BaudRateCombo.Name = "BaudRateCombo"
        Me.BaudRateCombo.Size = New System.Drawing.Size(75, 27)
        '
        'SerialIDLabel
        '
        Me.SerialIDLabel.Name = "SerialIDLabel"
        Me.SerialIDLabel.Size = New System.Drawing.Size(18, 24)
        Me.SerialIDLabel.Text = "ID"
        '
        'SerialIDCombo
        '
        Me.SerialIDCombo.AutoSize = False
        Me.SerialIDCombo.BackColor = System.Drawing.SystemColors.Menu
        Me.SerialIDCombo.Name = "SerialIDCombo"
        Me.SerialIDCombo.Size = New System.Drawing.Size(40, 23)
        '
        'ConnectButton
        '
        Me.ConnectButton.BackColor = System.Drawing.Color.LightGray
        Me.ConnectButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ConnectButton.Image = CType(resources.GetObject("ConnectButton.Image"), System.Drawing.Image)
        Me.ConnectButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ConnectButton.Name = "ConnectButton"
        Me.ConnectButton.Size = New System.Drawing.Size(56, 24)
        Me.ConnectButton.Text = "Connect"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(64, 24)
        Me.ToolStripLabel1.Text = "Command"
        '
        'ToolStripCommand
        '
        Me.ToolStripCommand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToolStripCommand.Name = "ToolStripCommand"
        Me.ToolStripCommand.Size = New System.Drawing.Size(100, 27)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(36, 24)
        Me.ToolStripLabel2.Text = "Reply"
        '
        'ToolStripReply
        '
        Me.ToolStripReply.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToolStripReply.Name = "ToolStripReply"
        Me.ToolStripReply.Size = New System.Drawing.Size(100, 27)
        '
        'SettingsOpenDialog
        '
        Me.SettingsOpenDialog.FileName = "OpenFileDialog1"
        '
        'CommTimer
        '
        '
        'Build
        '
        Me.Build.AutoSize = True
        Me.Build.BackColor = System.Drawing.Color.Transparent
        Me.Build.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Build.Location = New System.Drawing.Point(12, 62)
        Me.Build.Name = "Build"
        Me.Build.Size = New System.Drawing.Size(80, 12)
        Me.Build.TabIndex = 6
        Me.Build.Text = "Software Version:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(317, 140)
        Me.Label31.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(35, 13)
        Me.Label31.TabIndex = 291
        Me.Label31.Text = "Count"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(291, 140)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(29, 13)
        Me.Label24.TabIndex = 290
        Me.Label24.Text = "Error"
        '
        'EmergencyStop
        '
        Me.EmergencyStop.BackColor = System.Drawing.Color.White
        Me.EmergencyStop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmergencyStop.Location = New System.Drawing.Point(247, 207)
        Me.EmergencyStop.Margin = New System.Windows.Forms.Padding(2)
        Me.EmergencyStop.Name = "EmergencyStop"
        Me.EmergencyStop.Size = New System.Drawing.Size(19, 18)
        Me.EmergencyStop.TabIndex = 289
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(157, 210)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(85, 13)
        Me.Label22.TabIndex = 288
        Me.Label22.Text = "Emergency Stop"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(30, 210)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(70, 13)
        Me.Label21.TabIndex = 217
        Me.Label21.Text = "External Start"
        '
        'ExternalStart
        '
        Me.ExternalStart.BackColor = System.Drawing.Color.White
        Me.ExternalStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ExternalStart.Location = New System.Drawing.Point(111, 207)
        Me.ExternalStart.Margin = New System.Windows.Forms.Padding(2)
        Me.ExternalStart.Name = "ExternalStart"
        Me.ExternalStart.Size = New System.Drawing.Size(19, 18)
        Me.ExternalStart.TabIndex = 287
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(487, 144)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(29, 13)
        Me.Label18.TabIndex = 286
        Me.Label18.Text = "ERC"
        '
        'ClearOutY
        '
        Me.ClearOutY.BackColor = System.Drawing.Color.White
        Me.ClearOutY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ClearOutY.Location = New System.Drawing.Point(490, 185)
        Me.ClearOutY.Margin = New System.Windows.Forms.Padding(2)
        Me.ClearOutY.Name = "ClearOutY"
        Me.ClearOutY.Size = New System.Drawing.Size(19, 18)
        Me.ClearOutY.TabIndex = 283
        '
        'ClearOutX
        '
        Me.ClearOutX.BackColor = System.Drawing.Color.White
        Me.ClearOutX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ClearOutX.Location = New System.Drawing.Point(490, 160)
        Me.ClearOutX.Margin = New System.Windows.Forms.Padding(2)
        Me.ClearOutX.Name = "ClearOutX"
        Me.ClearOutX.Size = New System.Drawing.Size(19, 18)
        Me.ClearOutX.TabIndex = 282
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(464, 144)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(25, 13)
        Me.Label17.TabIndex = 281
        Me.Label17.Text = "INP"
        '
        'InPositionY
        '
        Me.InPositionY.BackColor = System.Drawing.Color.White
        Me.InPositionY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InPositionY.Location = New System.Drawing.Point(467, 185)
        Me.InPositionY.Margin = New System.Windows.Forms.Padding(2)
        Me.InPositionY.Name = "InPositionY"
        Me.InPositionY.Size = New System.Drawing.Size(19, 18)
        Me.InPositionY.TabIndex = 278
        '
        'InPositionX
        '
        Me.InPositionX.BackColor = System.Drawing.Color.White
        Me.InPositionX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InPositionX.Location = New System.Drawing.Point(467, 160)
        Me.InPositionX.Margin = New System.Windows.Forms.Padding(2)
        Me.InPositionX.Name = "InPositionX"
        Me.InPositionX.Size = New System.Drawing.Size(19, 18)
        Me.InPositionX.TabIndex = 277
        '
        'btnClearY
        '
        Me.btnClearY.BackColor = System.Drawing.Color.LightGray
        Me.btnClearY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearY.Location = New System.Drawing.Point(321, 181)
        Me.btnClearY.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClearY.Name = "btnClearY"
        Me.btnClearY.Size = New System.Drawing.Size(20, 22)
        Me.btnClearY.TabIndex = 274
        Me.btnClearY.Text = "R"
        Me.btnClearY.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClearY.UseVisualStyleBackColor = False
        '
        'btnClearX
        '
        Me.btnClearX.BackColor = System.Drawing.Color.LightGray
        Me.btnClearX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearX.Location = New System.Drawing.Point(321, 155)
        Me.btnClearX.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClearX.Name = "btnClearX"
        Me.btnClearX.Size = New System.Drawing.Size(20, 22)
        Me.btnClearX.TabIndex = 273
        Me.btnClearX.Text = "R"
        Me.btnClearX.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClearX.UseVisualStyleBackColor = False
        '
        'ClearY
        '
        Me.ClearY.BackColor = System.Drawing.Color.LightGray
        Me.ClearY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearY.Location = New System.Drawing.Point(297, 180)
        Me.ClearY.Margin = New System.Windows.Forms.Padding(2)
        Me.ClearY.Name = "ClearY"
        Me.ClearY.Size = New System.Drawing.Size(20, 22)
        Me.ClearY.TabIndex = 270
        Me.ClearY.Text = "C"
        Me.ClearY.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ClearY.UseVisualStyleBackColor = False
        '
        'ClearX
        '
        Me.ClearX.BackColor = System.Drawing.Color.LightGray
        Me.ClearX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearX.Location = New System.Drawing.Point(297, 155)
        Me.ClearX.Margin = New System.Windows.Forms.Padding(2)
        Me.ClearX.Name = "ClearX"
        Me.ClearX.Size = New System.Drawing.Size(20, 22)
        Me.ClearX.TabIndex = 269
        Me.ClearX.Text = "C"
        Me.ClearX.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ClearX.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(443, 144)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(22, 13)
        Me.Label12.TabIndex = 266
        Me.Label12.Text = "SD"
        '
        'DecelY
        '
        Me.DecelY.BackColor = System.Drawing.Color.White
        Me.DecelY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DecelY.Location = New System.Drawing.Point(444, 185)
        Me.DecelY.Margin = New System.Windows.Forms.Padding(2)
        Me.DecelY.Name = "DecelY"
        Me.DecelY.Size = New System.Drawing.Size(19, 18)
        Me.DecelY.TabIndex = 260
        '
        'DecelX
        '
        Me.DecelX.BackColor = System.Drawing.Color.White
        Me.DecelX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DecelX.Location = New System.Drawing.Point(444, 160)
        Me.DecelX.Margin = New System.Windows.Forms.Padding(2)
        Me.DecelX.Name = "DecelX"
        Me.DecelX.Size = New System.Drawing.Size(19, 18)
        Me.DecelX.TabIndex = 257
        '
        'AlarmY
        '
        Me.AlarmY.BackColor = System.Drawing.Color.White
        Me.AlarmY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AlarmY.Location = New System.Drawing.Point(421, 185)
        Me.AlarmY.Margin = New System.Windows.Forms.Padding(2)
        Me.AlarmY.Name = "AlarmY"
        Me.AlarmY.Size = New System.Drawing.Size(19, 18)
        Me.AlarmY.TabIndex = 248
        '
        'NLimitY
        '
        Me.NLimitY.BackColor = System.Drawing.Color.White
        Me.NLimitY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NLimitY.Location = New System.Drawing.Point(398, 185)
        Me.NLimitY.Margin = New System.Windows.Forms.Padding(2)
        Me.NLimitY.Name = "NLimitY"
        Me.NLimitY.Size = New System.Drawing.Size(19, 18)
        Me.NLimitY.TabIndex = 247
        '
        'HomeY
        '
        Me.HomeY.BackColor = System.Drawing.Color.White
        Me.HomeY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HomeY.Location = New System.Drawing.Point(375, 185)
        Me.HomeY.Margin = New System.Windows.Forms.Padding(2)
        Me.HomeY.Name = "HomeY"
        Me.HomeY.Size = New System.Drawing.Size(19, 18)
        Me.HomeY.TabIndex = 246
        '
        'PLimitY
        '
        Me.PLimitY.BackColor = System.Drawing.Color.White
        Me.PLimitY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PLimitY.Location = New System.Drawing.Point(352, 185)
        Me.PLimitY.Margin = New System.Windows.Forms.Padding(2)
        Me.PLimitY.Name = "PLimitY"
        Me.PLimitY.Size = New System.Drawing.Size(19, 18)
        Me.PLimitY.TabIndex = 245
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(412, 144)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 13)
        Me.Label11.TabIndex = 244
        Me.Label11.Text = "Alarm"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(397, 144)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 13)
        Me.Label10.TabIndex = 243
        Me.Label10.Text = "-L"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(377, 144)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 13)
        Me.Label9.TabIndex = 242
        Me.Label9.Text = "H"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(351, 144)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 13)
        Me.Label8.TabIndex = 241
        Me.Label8.Text = "+L"
        '
        'AlarmX
        '
        Me.AlarmX.BackColor = System.Drawing.Color.White
        Me.AlarmX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AlarmX.Location = New System.Drawing.Point(421, 160)
        Me.AlarmX.Margin = New System.Windows.Forms.Padding(2)
        Me.AlarmX.Name = "AlarmX"
        Me.AlarmX.Size = New System.Drawing.Size(19, 18)
        Me.AlarmX.TabIndex = 240
        '
        'NLimitX
        '
        Me.NLimitX.BackColor = System.Drawing.Color.White
        Me.NLimitX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NLimitX.Location = New System.Drawing.Point(398, 160)
        Me.NLimitX.Margin = New System.Windows.Forms.Padding(2)
        Me.NLimitX.Name = "NLimitX"
        Me.NLimitX.Size = New System.Drawing.Size(19, 18)
        Me.NLimitX.TabIndex = 239
        '
        'HomeX
        '
        Me.HomeX.BackColor = System.Drawing.Color.White
        Me.HomeX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HomeX.Location = New System.Drawing.Point(375, 160)
        Me.HomeX.Margin = New System.Windows.Forms.Padding(2)
        Me.HomeX.Name = "HomeX"
        Me.HomeX.Size = New System.Drawing.Size(19, 18)
        Me.HomeX.TabIndex = 238
        '
        'PLimitX
        '
        Me.PLimitX.BackColor = System.Drawing.Color.White
        Me.PLimitX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PLimitX.Location = New System.Drawing.Point(352, 160)
        Me.PLimitX.Margin = New System.Windows.Forms.Padding(2)
        Me.PLimitX.Name = "PLimitX"
        Me.PLimitX.Size = New System.Drawing.Size(19, 18)
        Me.PLimitX.TabIndex = 237
        '
        'PY
        '
        Me.PY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PY.Location = New System.Drawing.Point(30, 183)
        Me.PY.Margin = New System.Windows.Forms.Padding(2)
        Me.PY.Name = "PY"
        Me.PY.Size = New System.Drawing.Size(62, 20)
        Me.PY.TabIndex = 224
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 185)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 13)
        Me.Label1.TabIndex = 221
        Me.Label1.Text = "Y"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(26, 142)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 220
        Me.Label6.Text = "Step Position"
        '
        'PX
        '
        Me.PX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PX.Location = New System.Drawing.Point(30, 158)
        Me.PX.Margin = New System.Windows.Forms.Padding(2)
        Me.PX.Name = "PX"
        Me.PX.Size = New System.Drawing.Size(62, 20)
        Me.PX.TabIndex = 219
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 160)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 13)
        Me.Label5.TabIndex = 218
        Me.Label5.Text = "X"
        '
        'EY
        '
        Me.EY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EY.Location = New System.Drawing.Point(96, 183)
        Me.EY.Margin = New System.Windows.Forms.Padding(2)
        Me.EY.Name = "EY"
        Me.EY.Size = New System.Drawing.Size(80, 20)
        Me.EY.TabIndex = 303
        '
        'EX
        '
        Me.EX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EX.Location = New System.Drawing.Point(96, 158)
        Me.EX.Margin = New System.Windows.Forms.Padding(2)
        Me.EX.Name = "EX"
        Me.EX.Size = New System.Drawing.Size(80, 20)
        Me.EX.TabIndex = 302
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(93, 142)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(87, 13)
        Me.Label20.TabIndex = 301
        Me.Label20.Text = "Encoder Position"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(194, 143)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 228
        Me.Label4.Text = "Status"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(254, 143)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(30, 13)
        Me.Label23.TabIndex = 227
        Me.Label23.Text = "MST"
        '
        'MSTX
        '
        Me.MSTX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MSTX.Location = New System.Drawing.Point(180, 158)
        Me.MSTX.Margin = New System.Windows.Forms.Padding(2)
        Me.MSTX.Name = "MSTX"
        Me.MSTX.Size = New System.Drawing.Size(62, 20)
        Me.MSTX.TabIndex = 233
        '
        'txtMSTX
        '
        Me.txtMSTX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMSTX.Location = New System.Drawing.Point(246, 157)
        Me.txtMSTX.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMSTX.Name = "txtMSTX"
        Me.txtMSTX.Size = New System.Drawing.Size(47, 20)
        Me.txtMSTX.TabIndex = 229
        Me.txtMSTX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMSTY
        '
        Me.txtMSTY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMSTY.Location = New System.Drawing.Point(246, 182)
        Me.txtMSTY.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMSTY.Name = "txtMSTY"
        Me.txtMSTY.Size = New System.Drawing.Size(47, 20)
        Me.txtMSTY.TabIndex = 230
        Me.txtMSTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MSTY
        '
        Me.MSTY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MSTY.Location = New System.Drawing.Point(180, 182)
        Me.MSTY.Margin = New System.Windows.Forms.Padding(2)
        Me.MSTY.Name = "MSTY"
        Me.MSTY.Size = New System.Drawing.Size(62, 20)
        Me.MSTY.TabIndex = 234
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(621, 176)
        Me.Label33.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(49, 13)
        Me.Label33.TabIndex = 352
        Me.Label33.Text = "ACC rate"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(621, 215)
        Me.Label32.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(50, 13)
        Me.Label32.TabIndex = 351
        Me.Label32.Text = "DEC rate"
        '
        'AutoSetSSPDM
        '
        Me.AutoSetSSPDM.AutoSize = True
        Me.AutoSetSSPDM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AutoSetSSPDM.Location = New System.Drawing.Point(611, 108)
        Me.AutoSetSSPDM.Margin = New System.Windows.Forms.Padding(2)
        Me.AutoSetSSPDM.Name = "AutoSetSSPDM"
        Me.AutoSetSSPDM.Size = New System.Drawing.Size(145, 17)
        Me.AutoSetSSPDM.TabIndex = 350
        Me.AutoSetSSPDM.Text = "Automatically Set SSPDM"
        Me.AutoSetSSPDM.UseVisualStyleBackColor = True
        '
        'DECrate
        '
        Me.DECrate.AutoSize = True
        Me.DECrate.Location = New System.Drawing.Point(680, 215)
        Me.DECrate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DECrate.Name = "DECrate"
        Me.DECrate.Size = New System.Drawing.Size(29, 13)
        Me.DECrate.TabIndex = 349
        Me.DECrate.Text = "DEC"
        '
        'ACCrate
        '
        Me.ACCrate.AutoSize = True
        Me.ACCrate.Location = New System.Drawing.Point(680, 176)
        Me.ACCrate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ACCrate.Name = "ACCrate"
        Me.ACCrate.Size = New System.Drawing.Size(28, 13)
        Me.ACCrate.TabIndex = 348
        Me.ACCrate.Text = "ACC"
        '
        'TargetMove
        '
        Me.TargetMove.BackColor = System.Drawing.Color.LightGray
        Me.TargetMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TargetMove.Location = New System.Drawing.Point(380, 246)
        Me.TargetMove.Margin = New System.Windows.Forms.Padding(2)
        Me.TargetMove.Name = "TargetMove"
        Me.TargetMove.Size = New System.Drawing.Size(172, 55)
        Me.TargetMove.TabIndex = 347
        Me.TargetMove.Text = "TargetMove"
        Me.TargetMove.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(215, 77)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 346
        Me.Label7.Text = "S-curve"
        '
        'SCVy
        '
        Me.SCVy.BackColor = System.Drawing.Color.White
        Me.SCVy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SCVy.Location = New System.Drawing.Point(227, 121)
        Me.SCVy.Margin = New System.Windows.Forms.Padding(2)
        Me.SCVy.Name = "SCVy"
        Me.SCVy.Size = New System.Drawing.Size(17, 17)
        Me.SCVy.TabIndex = 343
        '
        'SCVx
        '
        Me.SCVx.BackColor = System.Drawing.Color.White
        Me.SCVx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SCVx.Location = New System.Drawing.Point(227, 97)
        Me.SCVx.Margin = New System.Windows.Forms.Padding(2)
        Me.SCVx.Name = "SCVx"
        Me.SCVx.Size = New System.Drawing.Size(17, 17)
        Me.SCVx.TabIndex = 342
        '
        'btnJogPlus
        '
        Me.btnJogPlus.BackColor = System.Drawing.Color.LightGray
        Me.btnJogPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJogPlus.Location = New System.Drawing.Point(287, 246)
        Me.btnJogPlus.Margin = New System.Windows.Forms.Padding(2)
        Me.btnJogPlus.Name = "btnJogPlus"
        Me.btnJogPlus.Size = New System.Drawing.Size(82, 55)
        Me.btnJogPlus.TabIndex = 341
        Me.btnJogPlus.Text = "+ JOG Until Stop"
        Me.btnJogPlus.UseVisualStyleBackColor = False
        '
        'btnJogMinus
        '
        Me.btnJogMinus.BackColor = System.Drawing.Color.LightGray
        Me.btnJogMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJogMinus.Location = New System.Drawing.Point(197, 246)
        Me.btnJogMinus.Margin = New System.Windows.Forms.Padding(2)
        Me.btnJogMinus.Name = "btnJogMinus"
        Me.btnJogMinus.Size = New System.Drawing.Size(82, 55)
        Me.btnJogMinus.TabIndex = 340
        Me.btnJogMinus.Text = "- JOG Until Stop"
        Me.btnJogMinus.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(277, 96)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 13)
        Me.Label13.TabIndex = 339
        Me.Label13.Text = "Move Mode"
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.rbINC)
        Me.Panel11.Controls.Add(Me.rbABS)
        Me.Panel11.Location = New System.Drawing.Point(343, 90)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(124, 23)
        Me.Panel11.TabIndex = 337
        '
        'rbINC
        '
        Me.rbINC.AutoSize = True
        Me.rbINC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbINC.Location = New System.Drawing.Point(59, 3)
        Me.rbINC.Name = "rbINC"
        Me.rbINC.Size = New System.Drawing.Size(42, 17)
        Me.rbINC.TabIndex = 0
        Me.rbINC.Text = "INC"
        Me.rbINC.UseVisualStyleBackColor = True
        '
        'rbABS
        '
        Me.rbABS.AutoSize = True
        Me.rbABS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbABS.Location = New System.Drawing.Point(3, 3)
        Me.rbABS.Name = "rbABS"
        Me.rbABS.Size = New System.Drawing.Size(45, 17)
        Me.rbABS.TabIndex = 0
        Me.rbABS.Text = "ABS"
        Me.rbABS.UseVisualStyleBackColor = True
        '
        'StopEmgButton
        '
        Me.StopEmgButton.BackColor = System.Drawing.Color.Red
        Me.StopEmgButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.StopEmgButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopEmgButton.Location = New System.Drawing.Point(380, 314)
        Me.StopEmgButton.Margin = New System.Windows.Forms.Padding(2)
        Me.StopEmgButton.Name = "StopEmgButton"
        Me.StopEmgButton.Size = New System.Drawing.Size(172, 55)
        Me.StopEmgButton.TabIndex = 338
        Me.StopEmgButton.Text = "Emergency Stop"
        Me.StopEmgButton.UseVisualStyleBackColor = False
        '
        'StopImmedButton
        '
        Me.StopImmedButton.BackColor = System.Drawing.Color.LightGray
        Me.StopImmedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StopImmedButton.Location = New System.Drawing.Point(197, 314)
        Me.StopImmedButton.Margin = New System.Windows.Forms.Padding(2)
        Me.StopImmedButton.Name = "StopImmedButton"
        Me.StopImmedButton.Size = New System.Drawing.Size(172, 55)
        Me.StopImmedButton.TabIndex = 336
        Me.StopImmedButton.Text = "Abort"
        Me.StopImmedButton.UseVisualStyleBackColor = False
        '
        'StopDecelButton
        '
        Me.StopDecelButton.BackColor = System.Drawing.Color.LightGray
        Me.StopDecelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StopDecelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopDecelButton.Location = New System.Drawing.Point(8, 314)
        Me.StopDecelButton.Margin = New System.Windows.Forms.Padding(2)
        Me.StopDecelButton.Name = "StopDecelButton"
        Me.StopDecelButton.Size = New System.Drawing.Size(172, 55)
        Me.StopDecelButton.TabIndex = 335
        Me.StopDecelButton.Text = "Ramp Stop"
        Me.StopDecelButton.UseVisualStyleBackColor = False
        '
        'TargetZeroMove
        '
        Me.TargetZeroMove.BackColor = System.Drawing.Color.LightGray
        Me.TargetZeroMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TargetZeroMove.Location = New System.Drawing.Point(10, 246)
        Me.TargetZeroMove.Margin = New System.Windows.Forms.Padding(2)
        Me.TargetZeroMove.Name = "TargetZeroMove"
        Me.TargetZeroMove.Size = New System.Drawing.Size(172, 55)
        Me.TargetZeroMove.TabIndex = 332
        Me.TargetZeroMove.Text = "Return to Zero"
        Me.TargetZeroMove.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(176, 76)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 13)
        Me.Label14.TabIndex = 329
        Me.Label14.Text = "Enable"
        '
        'EO2
        '
        Me.EO2.BackColor = System.Drawing.Color.White
        Me.EO2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EO2.Location = New System.Drawing.Point(188, 120)
        Me.EO2.Margin = New System.Windows.Forms.Padding(2)
        Me.EO2.Name = "EO2"
        Me.EO2.Size = New System.Drawing.Size(17, 17)
        Me.EO2.TabIndex = 326
        '
        'EO1
        '
        Me.EO1.BackColor = System.Drawing.Color.White
        Me.EO1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EO1.Location = New System.Drawing.Point(188, 96)
        Me.EO1.Margin = New System.Windows.Forms.Padding(2)
        Me.EO1.Name = "EO1"
        Me.EO1.Size = New System.Drawing.Size(17, 17)
        Me.EO1.TabIndex = 325
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(82, 76)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(78, 13)
        Me.Label15.TabIndex = 324
        Me.Label15.Text = "Target Position"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(12, 76)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(67, 13)
        Me.Label16.TabIndex = 323
        Me.Label16.Text = "Move Select"
        '
        'YTarget
        '
        Me.YTarget.BackColor = System.Drawing.Color.White
        Me.YTarget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.YTarget.Location = New System.Drawing.Point(79, 120)
        Me.YTarget.Margin = New System.Windows.Forms.Padding(2)
        Me.YTarget.Name = "YTarget"
        Me.YTarget.Size = New System.Drawing.Size(88, 20)
        Me.YTarget.TabIndex = 320
        '
        'XTarget
        '
        Me.XTarget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.XTarget.Location = New System.Drawing.Point(79, 96)
        Me.XTarget.Margin = New System.Windows.Forms.Padding(2)
        Me.XTarget.Name = "XTarget"
        Me.XTarget.Size = New System.Drawing.Size(88, 20)
        Me.XTarget.TabIndex = 319
        '
        'YCheckBox
        '
        Me.YCheckBox.AutoSize = True
        Me.YCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.YCheckBox.Location = New System.Drawing.Point(21, 122)
        Me.YCheckBox.Margin = New System.Windows.Forms.Padding(2)
        Me.YCheckBox.Name = "YCheckBox"
        Me.YCheckBox.Size = New System.Drawing.Size(52, 17)
        Me.YCheckBox.TabIndex = 316
        Me.YCheckBox.Text = "Y Axis"
        Me.YCheckBox.UseVisualStyleBackColor = True
        '
        'XCheckBox
        '
        Me.XCheckBox.AutoSize = True
        Me.XCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.XCheckBox.Location = New System.Drawing.Point(21, 97)
        Me.XCheckBox.Margin = New System.Windows.Forms.Padding(2)
        Me.XCheckBox.Name = "XCheckBox"
        Me.XCheckBox.Size = New System.Drawing.Size(52, 17)
        Me.XCheckBox.TabIndex = 315
        Me.XCheckBox.Text = "X Axis"
        Me.XCheckBox.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(608, 67)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(79, 13)
        Me.Label19.TabIndex = 314
        Me.Label19.Text = "Speed Settings"
        '
        'DecelText
        '
        Me.DecelText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DecelText.Location = New System.Drawing.Point(677, 193)
        Me.DecelText.Margin = New System.Windows.Forms.Padding(2)
        Me.DecelText.Name = "DecelText"
        Me.DecelText.Size = New System.Drawing.Size(76, 20)
        Me.DecelText.TabIndex = 313
        '
        'AccelText
        '
        Me.AccelText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AccelText.Location = New System.Drawing.Point(677, 154)
        Me.AccelText.Margin = New System.Windows.Forms.Padding(2)
        Me.AccelText.Name = "AccelText"
        Me.AccelText.Size = New System.Drawing.Size(76, 20)
        Me.AccelText.TabIndex = 312
        '
        'LowSpeedText
        '
        Me.LowSpeedText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LowSpeedText.Location = New System.Drawing.Point(677, 128)
        Me.LowSpeedText.Margin = New System.Windows.Forms.Padding(2)
        Me.LowSpeedText.Name = "LowSpeedText"
        Me.LowSpeedText.Size = New System.Drawing.Size(76, 20)
        Me.LowSpeedText.TabIndex = 311
        '
        'HighSpeedText
        '
        Me.HighSpeedText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HighSpeedText.Location = New System.Drawing.Point(677, 87)
        Me.HighSpeedText.Margin = New System.Windows.Forms.Padding(2)
        Me.HighSpeedText.Name = "HighSpeedText"
        Me.HighSpeedText.Size = New System.Drawing.Size(76, 20)
        Me.HighSpeedText.TabIndex = 310
        '
        'AccelCombo
        '
        Me.AccelCombo.BackColor = System.Drawing.SystemColors.Menu
        Me.AccelCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AccelCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccelCombo.FormattingEnabled = True
        Me.AccelCombo.Location = New System.Drawing.Point(544, 152)
        Me.AccelCombo.Margin = New System.Windows.Forms.Padding(2)
        Me.AccelCombo.Name = "AccelCombo"
        Me.AccelCombo.Size = New System.Drawing.Size(128, 21)
        Me.AccelCombo.TabIndex = 309
        '
        'DecelCombo
        '
        Me.DecelCombo.BackColor = System.Drawing.SystemColors.Menu
        Me.DecelCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DecelCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecelCombo.FormattingEnabled = True
        Me.DecelCombo.Location = New System.Drawing.Point(544, 191)
        Me.DecelCombo.Margin = New System.Windows.Forms.Padding(2)
        Me.DecelCombo.Name = "DecelCombo"
        Me.DecelCombo.Size = New System.Drawing.Size(128, 21)
        Me.DecelCombo.TabIndex = 308
        '
        'LowSpeedCombo
        '
        Me.LowSpeedCombo.BackColor = System.Drawing.SystemColors.Menu
        Me.LowSpeedCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LowSpeedCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LowSpeedCombo.FormattingEnabled = True
        Me.LowSpeedCombo.Location = New System.Drawing.Point(544, 128)
        Me.LowSpeedCombo.Margin = New System.Windows.Forms.Padding(2)
        Me.LowSpeedCombo.Name = "LowSpeedCombo"
        Me.LowSpeedCombo.Size = New System.Drawing.Size(128, 21)
        Me.LowSpeedCombo.TabIndex = 307
        '
        'HighSpeedCombo
        '
        Me.HighSpeedCombo.BackColor = System.Drawing.SystemColors.Menu
        Me.HighSpeedCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HighSpeedCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HighSpeedCombo.FormattingEnabled = True
        Me.HighSpeedCombo.Location = New System.Drawing.Point(544, 87)
        Me.HighSpeedCombo.Margin = New System.Windows.Forms.Padding(2)
        Me.HighSpeedCombo.Name = "HighSpeedCombo"
        Me.HighSpeedCombo.Size = New System.Drawing.Size(128, 21)
        Me.HighSpeedCombo.TabIndex = 306
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Commander_Terminal_VB_NET.My.Resources.Resources.CMD_4CR_standalone_faded1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(821, 400)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.AutoSetSSPDM)
        Me.Controls.Add(Me.DECrate)
        Me.Controls.Add(Me.ACCrate)
        Me.Controls.Add(Me.TargetMove)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.SCVy)
        Me.Controls.Add(Me.SCVx)
        Me.Controls.Add(Me.btnJogPlus)
        Me.Controls.Add(Me.btnJogMinus)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.StopEmgButton)
        Me.Controls.Add(Me.StopImmedButton)
        Me.Controls.Add(Me.StopDecelButton)
        Me.Controls.Add(Me.TargetZeroMove)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.EO2)
        Me.Controls.Add(Me.EO1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.YTarget)
        Me.Controls.Add(Me.XTarget)
        Me.Controls.Add(Me.YCheckBox)
        Me.Controls.Add(Me.XCheckBox)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.DecelText)
        Me.Controls.Add(Me.AccelText)
        Me.Controls.Add(Me.LowSpeedText)
        Me.Controls.Add(Me.HighSpeedText)
        Me.Controls.Add(Me.AccelCombo)
        Me.Controls.Add(Me.DecelCombo)
        Me.Controls.Add(Me.LowSpeedCombo)
        Me.Controls.Add(Me.HighSpeedCombo)
        Me.Controls.Add(Me.EY)
        Me.Controls.Add(Me.EX)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.EmergencyStop)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.ExternalStart)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.ClearOutY)
        Me.Controls.Add(Me.ClearOutX)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.InPositionY)
        Me.Controls.Add(Me.InPositionX)
        Me.Controls.Add(Me.btnClearY)
        Me.Controls.Add(Me.btnClearX)
        Me.Controls.Add(Me.ClearY)
        Me.Controls.Add(Me.ClearX)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.DecelY)
        Me.Controls.Add(Me.DecelX)
        Me.Controls.Add(Me.AlarmY)
        Me.Controls.Add(Me.NLimitY)
        Me.Controls.Add(Me.HomeY)
        Me.Controls.Add(Me.PLimitY)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.AlarmX)
        Me.Controls.Add(Me.NLimitX)
        Me.Controls.Add(Me.HomeX)
        Me.Controls.Add(Me.PLimitX)
        Me.Controls.Add(Me.MSTY)
        Me.Controls.Add(Me.txtMSTY)
        Me.Controls.Add(Me.txtMSTX)
        Me.Controls.Add(Me.MSTX)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PY)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PX)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Build)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Commander core Sample Sorce Code"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents IDLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents DeviceListCombo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ConnectButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripCommand As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripReply As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents SettingsSaveDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents SettingsOpenDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents COMListCombo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents BaudLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BaudRateCombo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ResetCommButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents COMPortLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents SerialIDCombo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents SerialIDLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CommTimer As System.Windows.Forms.Timer
    Friend WithEvents Build As Label
    Friend WithEvents TerminalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label31 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents EmergencyStop As Panel
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents ExternalStart As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents ClearOutY As Panel
    Friend WithEvents ClearOutX As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents InPositionY As Panel
    Friend WithEvents InPositionX As Panel
    Friend WithEvents btnClearY As Button
    Friend WithEvents btnClearX As Button
    Friend WithEvents ClearY As Button
    Friend WithEvents ClearX As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents DecelY As Panel
    Friend WithEvents DecelX As Panel
    Friend WithEvents AlarmY As Panel
    Friend WithEvents NLimitY As Panel
    Friend WithEvents HomeY As Panel
    Friend WithEvents PLimitY As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents AlarmX As Panel
    Friend WithEvents NLimitX As Panel
    Friend WithEvents HomeX As Panel
    Friend WithEvents PLimitX As Panel
    Friend WithEvents PY As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PX As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents EY As TextBox
    Friend WithEvents EX As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents MSTX As TextBox
    Friend WithEvents txtMSTX As TextBox
    Friend WithEvents txtMSTY As TextBox
    Friend WithEvents MSTY As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents AutoSetSSPDM As CheckBox
    Friend WithEvents DECrate As Label
    Friend WithEvents ACCrate As Label
    Friend WithEvents TargetMove As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents SCVy As Panel
    Friend WithEvents SCVx As Panel
    Friend WithEvents btnJogPlus As Button
    Friend WithEvents btnJogMinus As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents rbINC As RadioButton
    Friend WithEvents rbABS As RadioButton
    Friend WithEvents StopEmgButton As Button
    Friend WithEvents StopImmedButton As Button
    Friend WithEvents StopDecelButton As Button
    Friend WithEvents TargetZeroMove As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents EO2 As Panel
    Friend WithEvents EO1 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents YTarget As TextBox
    Friend WithEvents XTarget As TextBox
    Friend WithEvents YCheckBox As CheckBox
    Friend WithEvents XCheckBox As CheckBox
    Friend WithEvents Label19 As Label
    Friend WithEvents DecelText As TextBox
    Friend WithEvents AccelText As TextBox
    Friend WithEvents LowSpeedText As TextBox
    Friend WithEvents HighSpeedText As TextBox
    Friend WithEvents AccelCombo As ComboBox
    Friend WithEvents DecelCombo As ComboBox
    Friend WithEvents LowSpeedCombo As ComboBox
    Friend WithEvents HighSpeedCombo As ComboBox
    Friend WithEvents DigitalIOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CommunicationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents USBToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RS485ToolStripMenuItem As ToolStripMenuItem
End Class
