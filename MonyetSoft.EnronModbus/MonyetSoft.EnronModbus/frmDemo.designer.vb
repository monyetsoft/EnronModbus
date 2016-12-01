Namespace MonyetSoft.EnronModBus



    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmDemo
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
            Me.btnClosePort = New System.Windows.Forms.Button()
            Me.grpWriteSingle = New System.Windows.Forms.GroupBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.txtWriteSlaveID = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtWriteValue = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.btnWriteSingle = New System.Windows.Forms.Button()
            Me.txtWriteAddress = New System.Windows.Forms.TextBox()
            Me.btnOpenPort = New System.Windows.Forms.Button()
            Me.grpReadSingle = New System.Windows.Forms.GroupBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtReadSlaveID = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtReadValue = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtReadAddress = New System.Windows.Forms.TextBox()
            Me.btnReadSingle = New System.Windows.Forms.Button()
            Me.grpSerialSettings = New System.Windows.Forms.GroupBox()
            Me.cboCOMPort = New System.Windows.Forms.ComboBox()
            Me.cboStopBits = New System.Windows.Forms.ComboBox()
            Me.cboDatabits = New System.Windows.Forms.ComboBox()
            Me.cboParity = New System.Windows.Forms.ComboBox()
            Me.txtReadTimeOut = New System.Windows.Forms.TextBox()
            Me.Label102 = New System.Windows.Forms.Label()
            Me.cboBaudRate = New System.Windows.Forms.ComboBox()
            Me.chkRTSEnable = New System.Windows.Forms.CheckBox()
            Me.Label103 = New System.Windows.Forms.Label()
            Me.Label104 = New System.Windows.Forms.Label()
            Me.Label105 = New System.Windows.Forms.Label()
            Me.Label106 = New System.Windows.Forms.Label()
            Me.Label107 = New System.Windows.Forms.Label()
            Me.Label108 = New System.Windows.Forms.Label()
            Me.grpWriteSingle.SuspendLayout()
            Me.grpReadSingle.SuspendLayout()
            Me.grpSerialSettings.SuspendLayout()
            Me.SuspendLayout()
            '
            'btnClosePort
            '
            Me.btnClosePort.Location = New System.Drawing.Point(139, 256)
            Me.btnClosePort.Name = "btnClosePort"
            Me.btnClosePort.Size = New System.Drawing.Size(75, 23)
            Me.btnClosePort.TabIndex = 19
            Me.btnClosePort.Text = "Close Port"
            Me.btnClosePort.UseVisualStyleBackColor = True
            '
            'grpWriteSingle
            '
            Me.grpWriteSingle.Controls.Add(Me.Label6)
            Me.grpWriteSingle.Controls.Add(Me.txtWriteSlaveID)
            Me.grpWriteSingle.Controls.Add(Me.Label2)
            Me.grpWriteSingle.Controls.Add(Me.txtWriteValue)
            Me.grpWriteSingle.Controls.Add(Me.Label1)
            Me.grpWriteSingle.Controls.Add(Me.btnWriteSingle)
            Me.grpWriteSingle.Controls.Add(Me.txtWriteAddress)
            Me.grpWriteSingle.Location = New System.Drawing.Point(512, 12)
            Me.grpWriteSingle.Name = "grpWriteSingle"
            Me.grpWriteSingle.Size = New System.Drawing.Size(200, 238)
            Me.grpWriteSingle.TabIndex = 22
            Me.grpWriteSingle.TabStop = False
            Me.grpWriteSingle.Text = "Write Single"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(11, 27)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(48, 13)
            Me.Label6.TabIndex = 12
            Me.Label6.Text = "Slave ID"
            '
            'txtWriteSlaveID
            '
            Me.txtWriteSlaveID.Location = New System.Drawing.Point(72, 23)
            Me.txtWriteSlaveID.Name = "txtWriteSlaveID"
            Me.txtWriteSlaveID.Size = New System.Drawing.Size(100, 20)
            Me.txtWriteSlaveID.TabIndex = 11
            Me.txtWriteSlaveID.Text = "17"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(11, 79)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(34, 13)
            Me.Label2.TabIndex = 6
            Me.Label2.Text = "Value"
            '
            'txtWriteValue
            '
            Me.txtWriteValue.Location = New System.Drawing.Point(72, 75)
            Me.txtWriteValue.Name = "txtWriteValue"
            Me.txtWriteValue.Size = New System.Drawing.Size(100, 20)
            Me.txtWriteValue.TabIndex = 5
            Me.txtWriteValue.Text = "2000"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(11, 53)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(45, 13)
            Me.Label1.TabIndex = 4
            Me.Label1.Text = "Address"
            '
            'btnWriteSingle
            '
            Me.btnWriteSingle.Location = New System.Drawing.Point(3, 103)
            Me.btnWriteSingle.Name = "btnWriteSingle"
            Me.btnWriteSingle.Size = New System.Drawing.Size(75, 23)
            Me.btnWriteSingle.TabIndex = 3
            Me.btnWriteSingle.Text = "Write"
            Me.btnWriteSingle.UseVisualStyleBackColor = True
            '
            'txtWriteAddress
            '
            Me.txtWriteAddress.Location = New System.Drawing.Point(72, 49)
            Me.txtWriteAddress.Name = "txtWriteAddress"
            Me.txtWriteAddress.Size = New System.Drawing.Size(100, 20)
            Me.txtWriteAddress.TabIndex = 3
            Me.txtWriteAddress.Text = "7021"
            '
            'btnOpenPort
            '
            Me.btnOpenPort.Location = New System.Drawing.Point(52, 256)
            Me.btnOpenPort.Name = "btnOpenPort"
            Me.btnOpenPort.Size = New System.Drawing.Size(75, 23)
            Me.btnOpenPort.TabIndex = 18
            Me.btnOpenPort.Text = "Open Port"
            Me.btnOpenPort.UseVisualStyleBackColor = True
            '
            'grpReadSingle
            '
            Me.grpReadSingle.Controls.Add(Me.Label5)
            Me.grpReadSingle.Controls.Add(Me.txtReadSlaveID)
            Me.grpReadSingle.Controls.Add(Me.Label4)
            Me.grpReadSingle.Controls.Add(Me.txtReadValue)
            Me.grpReadSingle.Controls.Add(Me.Label3)
            Me.grpReadSingle.Controls.Add(Me.txtReadAddress)
            Me.grpReadSingle.Controls.Add(Me.btnReadSingle)
            Me.grpReadSingle.Location = New System.Drawing.Point(295, 12)
            Me.grpReadSingle.Name = "grpReadSingle"
            Me.grpReadSingle.Size = New System.Drawing.Size(199, 238)
            Me.grpReadSingle.TabIndex = 21
            Me.grpReadSingle.TabStop = False
            Me.grpReadSingle.Text = "Read Single"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(14, 33)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(48, 13)
            Me.Label5.TabIndex = 10
            Me.Label5.Text = "Slave ID"
            '
            'txtReadSlaveID
            '
            Me.txtReadSlaveID.Location = New System.Drawing.Point(75, 29)
            Me.txtReadSlaveID.Name = "txtReadSlaveID"
            Me.txtReadSlaveID.Size = New System.Drawing.Size(100, 20)
            Me.txtReadSlaveID.TabIndex = 9
            Me.txtReadSlaveID.Text = "17"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(14, 124)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(34, 13)
            Me.Label4.TabIndex = 8
            Me.Label4.Text = "Value"
            '
            'txtReadValue
            '
            Me.txtReadValue.Location = New System.Drawing.Point(75, 121)
            Me.txtReadValue.Name = "txtReadValue"
            Me.txtReadValue.Size = New System.Drawing.Size(100, 20)
            Me.txtReadValue.TabIndex = 7
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(14, 59)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(45, 13)
            Me.Label3.TabIndex = 6
            Me.Label3.Text = "Address"
            '
            'txtReadAddress
            '
            Me.txtReadAddress.Location = New System.Drawing.Point(75, 55)
            Me.txtReadAddress.Name = "txtReadAddress"
            Me.txtReadAddress.Size = New System.Drawing.Size(100, 20)
            Me.txtReadAddress.TabIndex = 5
            Me.txtReadAddress.Text = "7001"
            '
            'btnReadSingle
            '
            Me.btnReadSingle.Location = New System.Drawing.Point(6, 87)
            Me.btnReadSingle.Name = "btnReadSingle"
            Me.btnReadSingle.Size = New System.Drawing.Size(75, 23)
            Me.btnReadSingle.TabIndex = 2
            Me.btnReadSingle.Text = "Read"
            Me.btnReadSingle.UseVisualStyleBackColor = True
            '
            'grpSerialSettings
            '
            Me.grpSerialSettings.Controls.Add(Me.cboCOMPort)
            Me.grpSerialSettings.Controls.Add(Me.cboStopBits)
            Me.grpSerialSettings.Controls.Add(Me.cboDatabits)
            Me.grpSerialSettings.Controls.Add(Me.cboParity)
            Me.grpSerialSettings.Controls.Add(Me.txtReadTimeOut)
            Me.grpSerialSettings.Controls.Add(Me.Label102)
            Me.grpSerialSettings.Controls.Add(Me.cboBaudRate)
            Me.grpSerialSettings.Controls.Add(Me.chkRTSEnable)
            Me.grpSerialSettings.Controls.Add(Me.Label103)
            Me.grpSerialSettings.Controls.Add(Me.Label104)
            Me.grpSerialSettings.Controls.Add(Me.Label105)
            Me.grpSerialSettings.Controls.Add(Me.Label106)
            Me.grpSerialSettings.Controls.Add(Me.Label107)
            Me.grpSerialSettings.Controls.Add(Me.Label108)
            Me.grpSerialSettings.Location = New System.Drawing.Point(12, 12)
            Me.grpSerialSettings.Name = "grpSerialSettings"
            Me.grpSerialSettings.Size = New System.Drawing.Size(253, 238)
            Me.grpSerialSettings.TabIndex = 20
            Me.grpSerialSettings.TabStop = False
            Me.grpSerialSettings.Text = "Serial Port Settings"
            '
            'cboCOMPort
            '
            Me.cboCOMPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboCOMPort.FormattingEnabled = True
            Me.cboCOMPort.Location = New System.Drawing.Point(127, 31)
            Me.cboCOMPort.Margin = New System.Windows.Forms.Padding(4)
            Me.cboCOMPort.Name = "cboCOMPort"
            Me.cboCOMPort.Size = New System.Drawing.Size(112, 21)
            Me.cboCOMPort.TabIndex = 1
            '
            'cboStopBits
            '
            Me.cboStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboStopBits.FormattingEnabled = True
            Me.cboStopBits.Items.AddRange(New Object() {"1", "2", "1.5"})
            Me.cboStopBits.Location = New System.Drawing.Point(127, 147)
            Me.cboStopBits.Margin = New System.Windows.Forms.Padding(4)
            Me.cboStopBits.Name = "cboStopBits"
            Me.cboStopBits.Size = New System.Drawing.Size(112, 21)
            Me.cboStopBits.TabIndex = 9
            '
            'cboDatabits
            '
            Me.cboDatabits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboDatabits.FormattingEnabled = True
            Me.cboDatabits.Items.AddRange(New Object() {"4", "5", "6", "7", "8"})
            Me.cboDatabits.Location = New System.Drawing.Point(127, 118)
            Me.cboDatabits.Margin = New System.Windows.Forms.Padding(4)
            Me.cboDatabits.Name = "cboDatabits"
            Me.cboDatabits.Size = New System.Drawing.Size(112, 21)
            Me.cboDatabits.TabIndex = 7
            '
            'cboParity
            '
            Me.cboParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboParity.FormattingEnabled = True
            Me.cboParity.Items.AddRange(New Object() {"None", "Odd", "Even", "Mark", "Space"})
            Me.cboParity.Location = New System.Drawing.Point(127, 89)
            Me.cboParity.Margin = New System.Windows.Forms.Padding(4)
            Me.cboParity.Name = "cboParity"
            Me.cboParity.Size = New System.Drawing.Size(112, 21)
            Me.cboParity.TabIndex = 5
            '
            'txtReadTimeOut
            '
            Me.txtReadTimeOut.Location = New System.Drawing.Point(127, 199)
            Me.txtReadTimeOut.Margin = New System.Windows.Forms.Padding(4)
            Me.txtReadTimeOut.Name = "txtReadTimeOut"
            Me.txtReadTimeOut.Size = New System.Drawing.Size(84, 20)
            Me.txtReadTimeOut.TabIndex = 13
            Me.txtReadTimeOut.Text = "1000"
            '
            'Label102
            '
            Me.Label102.AutoSize = True
            Me.Label102.Location = New System.Drawing.Point(14, 202)
            Me.Label102.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label102.Name = "Label102"
            Me.Label102.Size = New System.Drawing.Size(101, 13)
            Me.Label102.TabIndex = 12
            Me.Label102.Text = "Read Time Out (ms)"
            '
            'cboBaudRate
            '
            Me.cboBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboBaudRate.FormattingEnabled = True
            Me.cboBaudRate.Items.AddRange(New Object() {"2400", "4800", "7200", "9600", "14400", "19200", "28800", "33600", "38400", "57600", "76800", "115200"})
            Me.cboBaudRate.Location = New System.Drawing.Point(127, 60)
            Me.cboBaudRate.Margin = New System.Windows.Forms.Padding(4)
            Me.cboBaudRate.Name = "cboBaudRate"
            Me.cboBaudRate.Size = New System.Drawing.Size(112, 21)
            Me.cboBaudRate.TabIndex = 3
            '
            'chkRTSEnable
            '
            Me.chkRTSEnable.AutoSize = True
            Me.chkRTSEnable.Location = New System.Drawing.Point(127, 175)
            Me.chkRTSEnable.Name = "chkRTSEnable"
            Me.chkRTSEnable.Size = New System.Drawing.Size(15, 14)
            Me.chkRTSEnable.TabIndex = 11
            Me.chkRTSEnable.UseVisualStyleBackColor = True
            '
            'Label103
            '
            Me.Label103.AutoSize = True
            Me.Label103.Location = New System.Drawing.Point(14, 150)
            Me.Label103.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label103.Name = "Label103"
            Me.Label103.Size = New System.Drawing.Size(49, 13)
            Me.Label103.TabIndex = 8
            Me.Label103.Text = "Stop Bits"
            '
            'Label104
            '
            Me.Label104.AutoSize = True
            Me.Label104.Location = New System.Drawing.Point(14, 175)
            Me.Label104.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label104.Name = "Label104"
            Me.Label104.Size = New System.Drawing.Size(65, 13)
            Me.Label104.TabIndex = 10
            Me.Label104.Text = "RTS Enable"
            '
            'Label105
            '
            Me.Label105.AutoSize = True
            Me.Label105.Location = New System.Drawing.Point(14, 121)
            Me.Label105.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label105.Name = "Label105"
            Me.Label105.Size = New System.Drawing.Size(50, 13)
            Me.Label105.TabIndex = 6
            Me.Label105.Text = "Data Bits"
            '
            'Label106
            '
            Me.Label106.AutoSize = True
            Me.Label106.Location = New System.Drawing.Point(14, 92)
            Me.Label106.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label106.Name = "Label106"
            Me.Label106.Size = New System.Drawing.Size(33, 13)
            Me.Label106.TabIndex = 4
            Me.Label106.Text = "Parity"
            '
            'Label107
            '
            Me.Label107.AutoSize = True
            Me.Label107.Location = New System.Drawing.Point(14, 63)
            Me.Label107.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label107.Name = "Label107"
            Me.Label107.Size = New System.Drawing.Size(58, 13)
            Me.Label107.TabIndex = 2
            Me.Label107.Text = "Baud Rate"
            '
            'Label108
            '
            Me.Label108.AutoSize = True
            Me.Label108.Location = New System.Drawing.Point(14, 34)
            Me.Label108.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label108.Name = "Label108"
            Me.Label108.Size = New System.Drawing.Size(53, 13)
            Me.Label108.TabIndex = 0
            Me.Label108.Text = "COM Port"
            '
            'frmDemo
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(909, 307)
            Me.Controls.Add(Me.btnClosePort)
            Me.Controls.Add(Me.grpWriteSingle)
            Me.Controls.Add(Me.btnOpenPort)
            Me.Controls.Add(Me.grpReadSingle)
            Me.Controls.Add(Me.grpSerialSettings)
            Me.Name = "frmDemo"
            Me.Text = "Demo"
            Me.grpWriteSingle.ResumeLayout(False)
            Me.grpWriteSingle.PerformLayout()
            Me.grpReadSingle.ResumeLayout(False)
            Me.grpReadSingle.PerformLayout()
            Me.grpSerialSettings.ResumeLayout(False)
            Me.grpSerialSettings.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents btnClosePort As Button
        Friend WithEvents grpWriteSingle As GroupBox
        Friend WithEvents Label2 As Label
        Friend WithEvents txtWriteValue As TextBox
        Friend WithEvents Label1 As Label
        Friend WithEvents btnWriteSingle As Button
        Friend WithEvents txtWriteAddress As TextBox
        Friend WithEvents btnOpenPort As Button
        Friend WithEvents grpReadSingle As GroupBox
        Friend WithEvents Label4 As Label
        Friend WithEvents txtReadValue As TextBox
        Friend WithEvents Label3 As Label
        Friend WithEvents txtReadAddress As TextBox
        Friend WithEvents btnReadSingle As Button
        Friend WithEvents grpSerialSettings As GroupBox
        Friend WithEvents cboCOMPort As ComboBox
        Friend WithEvents cboStopBits As ComboBox
        Friend WithEvents cboDatabits As ComboBox
        Friend WithEvents cboParity As ComboBox
        Friend WithEvents txtReadTimeOut As TextBox
        Friend WithEvents Label102 As Label
        Friend WithEvents cboBaudRate As ComboBox
        Friend WithEvents chkRTSEnable As CheckBox
        Friend WithEvents Label103 As Label
        Friend WithEvents Label104 As Label
        Friend WithEvents Label105 As Label
        Friend WithEvents Label106 As Label
        Friend WithEvents Label107 As Label
        Friend WithEvents Label108 As Label
        Friend WithEvents Label5 As Label
        Friend WithEvents txtReadSlaveID As TextBox
        Friend WithEvents Label6 As Label
        Friend WithEvents txtWriteSlaveID As TextBox
    End Class
End Namespace