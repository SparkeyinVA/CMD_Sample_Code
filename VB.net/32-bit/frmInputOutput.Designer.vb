<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInputOutput
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
        Me.DI4 = New System.Windows.Forms.Panel()
        Me.DI3 = New System.Windows.Forms.Panel()
        Me.DI2 = New System.Windows.Forms.Panel()
        Me.DI1 = New System.Windows.Forms.Panel()
        Me.DI_Latch = New System.Windows.Forms.Label()
        Me.DO4 = New System.Windows.Forms.Panel()
        Me.DO3 = New System.Windows.Forms.Panel()
        Me.DO2 = New System.Windows.Forms.Panel()
        Me.DO1 = New System.Windows.Forms.Panel()
        Me.DO_Sync = New System.Windows.Forms.Label()
        Me.TimerIO = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PWM2TrackBar = New System.Windows.Forms.TrackBar()
        Me.PWM1TrackBar = New System.Windows.Forms.TrackBar()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.IO4 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.IO3 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IO2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.IO1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.AIN2Text = New System.Windows.Forms.TextBox()
        Me.AIN1Text = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.PWM2TrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PWM1TrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DI4
        '
        Me.DI4.BackColor = System.Drawing.Color.White
        Me.DI4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DI4.Location = New System.Drawing.Point(189, 60)
        Me.DI4.Name = "DI4"
        Me.DI4.Size = New System.Drawing.Size(25, 25)
        Me.DI4.TabIndex = 19
        '
        'DI3
        '
        Me.DI3.BackColor = System.Drawing.Color.White
        Me.DI3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DI3.Location = New System.Drawing.Point(152, 60)
        Me.DI3.Name = "DI3"
        Me.DI3.Size = New System.Drawing.Size(25, 25)
        Me.DI3.TabIndex = 18
        '
        'DI2
        '
        Me.DI2.BackColor = System.Drawing.Color.White
        Me.DI2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DI2.Location = New System.Drawing.Point(116, 60)
        Me.DI2.Name = "DI2"
        Me.DI2.Size = New System.Drawing.Size(25, 25)
        Me.DI2.TabIndex = 17
        '
        'DI1
        '
        Me.DI1.BackColor = System.Drawing.Color.White
        Me.DI1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DI1.Location = New System.Drawing.Point(80, 60)
        Me.DI1.Name = "DI1"
        Me.DI1.Size = New System.Drawing.Size(25, 25)
        Me.DI1.TabIndex = 16
        '
        'DI_Latch
        '
        Me.DI_Latch.AutoSize = True
        Me.DI_Latch.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DI_Latch.Location = New System.Drawing.Point(15, 66)
        Me.DI_Latch.Name = "DI_Latch"
        Me.DI_Latch.Size = New System.Drawing.Size(48, 13)
        Me.DI_Latch.TabIndex = 15
        Me.DI_Latch.Text = "Digital In"
        '
        'DO4
        '
        Me.DO4.BackColor = System.Drawing.Color.White
        Me.DO4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DO4.Location = New System.Drawing.Point(189, 28)
        Me.DO4.Name = "DO4"
        Me.DO4.Size = New System.Drawing.Size(25, 25)
        Me.DO4.TabIndex = 14
        '
        'DO3
        '
        Me.DO3.BackColor = System.Drawing.Color.White
        Me.DO3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DO3.Location = New System.Drawing.Point(152, 28)
        Me.DO3.Name = "DO3"
        Me.DO3.Size = New System.Drawing.Size(25, 25)
        Me.DO3.TabIndex = 13
        '
        'DO2
        '
        Me.DO2.BackColor = System.Drawing.Color.White
        Me.DO2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DO2.Location = New System.Drawing.Point(116, 28)
        Me.DO2.Name = "DO2"
        Me.DO2.Size = New System.Drawing.Size(25, 25)
        Me.DO2.TabIndex = 12
        '
        'DO1
        '
        Me.DO1.BackColor = System.Drawing.Color.White
        Me.DO1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DO1.Location = New System.Drawing.Point(80, 28)
        Me.DO1.Name = "DO1"
        Me.DO1.Size = New System.Drawing.Size(25, 25)
        Me.DO1.TabIndex = 11
        '
        'DO_Sync
        '
        Me.DO_Sync.AutoSize = True
        Me.DO_Sync.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DO_Sync.Location = New System.Drawing.Point(15, 33)
        Me.DO_Sync.Name = "DO_Sync"
        Me.DO_Sync.Size = New System.Drawing.Size(56, 13)
        Me.DO_Sync.TabIndex = 10
        Me.DO_Sync.Text = "Digital Out"
        '
        'TimerIO
        '
        Me.TimerIO.Interval = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 359)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(371, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "---------------------------------------------------------------------------------" &
    "----------"
        '
        'PWM2TrackBar
        '
        Me.PWM2TrackBar.LargeChange = 1
        Me.PWM2TrackBar.Location = New System.Drawing.Point(69, 303)
        Me.PWM2TrackBar.Margin = New System.Windows.Forms.Padding(2)
        Me.PWM2TrackBar.Maximum = 99
        Me.PWM2TrackBar.Minimum = 1
        Me.PWM2TrackBar.Name = "PWM2TrackBar"
        Me.PWM2TrackBar.Size = New System.Drawing.Size(213, 45)
        Me.PWM2TrackBar.SmallChange = 10
        Me.PWM2TrackBar.TabIndex = 109
        Me.PWM2TrackBar.Value = 50
        '
        'PWM1TrackBar
        '
        Me.PWM1TrackBar.LargeChange = 1
        Me.PWM1TrackBar.Location = New System.Drawing.Point(69, 266)
        Me.PWM1TrackBar.Margin = New System.Windows.Forms.Padding(2)
        Me.PWM1TrackBar.Maximum = 99
        Me.PWM1TrackBar.Minimum = 1
        Me.PWM1TrackBar.Name = "PWM1TrackBar"
        Me.PWM1TrackBar.Size = New System.Drawing.Size(213, 45)
        Me.PWM1TrackBar.SmallChange = 10
        Me.PWM1TrackBar.TabIndex = 108
        Me.PWM1TrackBar.Value = 50
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(6, 306)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(60, 13)
        Me.Label25.TabIndex = 103
        Me.Label25.Text = "PWM 2 (%)"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(6, 270)
        Me.Label26.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(60, 13)
        Me.Label26.TabIndex = 102
        Me.Label26.Text = "PWM 1 (%)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(127, 162)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 147
        Me.Label4.Text = "IO4"
        '
        'IO4
        '
        Me.IO4.BackColor = System.Drawing.Color.White
        Me.IO4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IO4.Location = New System.Drawing.Point(185, 159)
        Me.IO4.Margin = New System.Windows.Forms.Padding(2)
        Me.IO4.Name = "IO4"
        Me.IO4.Size = New System.Drawing.Size(19, 20)
        Me.IO4.TabIndex = 146
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.LightGray
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Cambria", 7.8!)
        Me.Button4.Location = New System.Drawing.Point(167, 159)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(19, 20)
        Me.Button4.TabIndex = 145
        Me.Button4.Text = "I"
        Me.ToolTip1.SetToolTip(Me.Button4, "IO4 is Input")
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(127, 129)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 144
        Me.Label3.Text = "IO3"
        '
        'IO3
        '
        Me.IO3.BackColor = System.Drawing.Color.White
        Me.IO3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IO3.Location = New System.Drawing.Point(185, 126)
        Me.IO3.Margin = New System.Windows.Forms.Padding(2)
        Me.IO3.Name = "IO3"
        Me.IO3.Size = New System.Drawing.Size(19, 20)
        Me.IO3.TabIndex = 143
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightGray
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Cambria", 7.8!)
        Me.Button3.Location = New System.Drawing.Point(167, 126)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(19, 20)
        Me.Button3.TabIndex = 142
        Me.Button3.Text = "I"
        Me.ToolTip1.SetToolTip(Me.Button3, "IO3 is Input")
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 162)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 141
        Me.Label2.Text = "IO2"
        '
        'IO2
        '
        Me.IO2.BackColor = System.Drawing.Color.White
        Me.IO2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IO2.Location = New System.Drawing.Point(73, 159)
        Me.IO2.Margin = New System.Windows.Forms.Padding(2)
        Me.IO2.Name = "IO2"
        Me.IO2.Size = New System.Drawing.Size(19, 20)
        Me.IO2.TabIndex = 140
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightGray
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Cambria", 7.8!)
        Me.Button2.Location = New System.Drawing.Point(55, 159)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(19, 20)
        Me.Button2.TabIndex = 139
        Me.Button2.Text = "I"
        Me.ToolTip1.SetToolTip(Me.Button2, "IO2 is Input")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 129)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 138
        Me.Label5.Text = "IO1"
        '
        'IO1
        '
        Me.IO1.BackColor = System.Drawing.Color.White
        Me.IO1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IO1.Location = New System.Drawing.Point(73, 126)
        Me.IO1.Margin = New System.Windows.Forms.Padding(2)
        Me.IO1.Name = "IO1"
        Me.IO1.Size = New System.Drawing.Size(19, 20)
        Me.IO1.TabIndex = 137
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightGray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Cambria", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(55, 126)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(19, 20)
        Me.Button1.TabIndex = 136
        Me.Button1.Text = "I"
        Me.ToolTip1.SetToolTip(Me.Button1, "IO1 is Input")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 13)
        Me.Label6.TabIndex = 148
        Me.Label6.Text = "Digital Input/Output"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 13)
        Me.Label7.TabIndex = 149
        Me.Label7.Text = "Configurable Input/Output"
        '
        'AIN2Text
        '
        Me.AIN2Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AIN2Text.Location = New System.Drawing.Point(208, 212)
        Me.AIN2Text.Margin = New System.Windows.Forms.Padding(2)
        Me.AIN2Text.Name = "AIN2Text"
        Me.AIN2Text.Size = New System.Drawing.Size(76, 19)
        Me.AIN2Text.TabIndex = 153
        '
        'AIN1Text
        '
        Me.AIN1Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AIN1Text.Location = New System.Drawing.Point(67, 212)
        Me.AIN1Text.Margin = New System.Windows.Forms.Padding(2)
        Me.AIN1Text.Name = "AIN1Text"
        Me.AIN1Text.Size = New System.Drawing.Size(76, 19)
        Me.AIN1Text.TabIndex = 152
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(147, 215)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 151
        Me.Label8.Text = "AIN 2 (mV)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 215)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 150
        Me.Label9.Text = "AIN 1 (mV)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 193)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 13)
        Me.Label10.TabIndex = 154
        Me.Label10.Text = "Analog Input"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 245)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 13)
        Me.Label11.TabIndex = 155
        Me.Label11.Text = "PWM Output"
        '
        'frmDigitalIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(303, 352)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.AIN2Text)
        Me.Controls.Add(Me.AIN1Text)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.IO4)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.IO3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.IO2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.IO1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PWM2TrackBar)
        Me.Controls.Add(Me.PWM1TrackBar)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DI4)
        Me.Controls.Add(Me.DI3)
        Me.Controls.Add(Me.DI2)
        Me.Controls.Add(Me.DI1)
        Me.Controls.Add(Me.DI_Latch)
        Me.Controls.Add(Me.DO4)
        Me.Controls.Add(Me.DO3)
        Me.Controls.Add(Me.DO2)
        Me.Controls.Add(Me.DO1)
        Me.Controls.Add(Me.DO_Sync)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximumSize = New System.Drawing.Size(850, 400)
        Me.MinimumSize = New System.Drawing.Size(300, 239)
        Me.Name = "frmDigitalIO"
        Me.ShowIcon = False
        Me.Text = "Input/Output"
        Me.TopMost = True
        CType(Me.PWM2TrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PWM1TrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DI4 As System.Windows.Forms.Panel
    Friend WithEvents DI3 As System.Windows.Forms.Panel
    Friend WithEvents DI2 As System.Windows.Forms.Panel
    Friend WithEvents DI1 As System.Windows.Forms.Panel
    Friend WithEvents DI_Latch As System.Windows.Forms.Label
    Friend WithEvents DO4 As System.Windows.Forms.Panel
    Friend WithEvents DO3 As System.Windows.Forms.Panel
    Friend WithEvents DO2 As System.Windows.Forms.Panel
    Friend WithEvents DO1 As System.Windows.Forms.Panel
    Friend WithEvents DO_Sync As System.Windows.Forms.Label
    Friend WithEvents TimerIO As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PWM2TrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents PWM1TrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label4 As Label
    Friend WithEvents IO4 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents IO3 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents IO2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents IO1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents AIN2Text As TextBox
    Friend WithEvents AIN1Text As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
