Imports System.IO
Imports System.IO.Ports

Namespace MonyetSoft.EnronModBus

    Public Class frmDemo


        Private _SerialPort As SerialPort


        Private Sub LoadPortList()
            Dim PortNames() As String = SerialPort.GetPortNames()

            For Each s As String In PortNames
                cboCOMPort.Items.Add(s)
            Next
        End Sub

        Private Sub btnReadSingle_Click(sender As Object, e As EventArgs) Handles btnReadSingle.Click

            Try
                Dim Value As Single = EnronSerialHelper.ReadSingle(_SerialPort, txtReadSlaveID.Text, txtReadAddress.Text)
                txtReadValue.Text = Value
            Catch ex As Exception
                MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End Sub

        Private Sub btnWriteSingle_Click(sender As Object, e As EventArgs) Handles btnWriteSingle.Click
            Try
                EnronSerialHelper.WriteSingle(_SerialPort, txtWriteSlaveID.Text, txtWriteAddress.Text, txtWriteValue.Text)
            Catch ex As Exception
                MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub btnOpenPort_Click(sender As Object, e As EventArgs) Handles btnOpenPort.Click
            Try
                _SerialPort = New SerialPort(CStr(cboCOMPort.Text))


                _SerialPort.BaudRate = cboBaudRate.Text
                _SerialPort.DataBits = cboDatabits.Text


                Select Case cboParity.Text
                    Case "None"
                        _SerialPort.Parity = Parity.None
                    Case "Odd"
                        _SerialPort.Parity = Parity.Odd
                    Case "Even"
                        _SerialPort.Parity = Parity.Even
                    Case "Mark"
                        _SerialPort.Parity = Parity.Mark
                    Case "Space"
                        _SerialPort.Parity = Parity.Space
                End Select

                Select Case cboStopBits.Text
                    Case "1"
                        _SerialPort.StopBits = StopBits.One
                    Case "2"
                        _SerialPort.StopBits = StopBits.Two
                    Case "1.5"
                        _SerialPort.StopBits = StopBits.OnePointFive
                End Select

                If chkRTSEnable.Checked Then
                    _SerialPort.RtsEnable = True
                Else
                    _SerialPort.RtsEnable = False
                End If


                _SerialPort.ReadTimeout = txtReadTimeOut.Text
                _SerialPort.WriteTimeout = txtReadTimeOut.Text

                _SerialPort.Open()

                btnClosePort.Enabled = True
                btnOpenPort.Enabled = False

                grpSerialSettings.Enabled = False
                grpReadSingle.Enabled = True
                grpWriteSingle.Enabled = True


            Catch ex As Exception
                MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub btnClosePort_Click(sender As Object, e As EventArgs) Handles btnClosePort.Click
            _SerialPort.Close()

            btnClosePort.Enabled = False
            btnOpenPort.Enabled = True

            grpSerialSettings.Enabled = True
            grpReadSingle.Enabled = False
            grpWriteSingle.Enabled = False
        End Sub

        Private Sub frmDemo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

            LoadPortList()

            'Default Values

            cboCOMPort.SelectedIndex = 0
            cboBaudRate.SelectedIndex = cboBaudRate.FindString("19200")
            cboParity.SelectedIndex = cboParity.FindString("None")
            cboDatabits.SelectedIndex = cboDatabits.FindString("8")
            cboStopBits.SelectedIndex = cboStopBits.FindString("1")

            btnClosePort.Enabled = False
            btnOpenPort.Enabled = True

            grpSerialSettings.Enabled = True
            grpReadSingle.Enabled = False
            grpWriteSingle.Enabled = False
        End Sub

    End Class

End Namespace