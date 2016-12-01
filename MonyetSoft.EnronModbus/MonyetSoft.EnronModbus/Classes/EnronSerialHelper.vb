Imports System.IO
Imports System.IO.Ports



Namespace MonyetSoft.EnronModBus

    Public Class EnronSerialHelper


        Public Shared Sub WriteSingle(ByRef pSerialPort As SerialPort, pSlaveID As Byte, pRegisterAddress As UShort, ByRef pValueToWrite As Single)

            'This command is writing the contents of analog output holding register # 7001
            'to the slave device with address 17.

            '11 06 1B59 44FA0000 CDEC

            '11: The Slave Address (11 hex = address17 )
            '06: The Function Code (Preset Single Register)
            '1B59: The Data Address of the register. (1B59 hex = 7001)
            '44FA0000: The value to write (2000)
            'CDEC: The CRC (cyclic redundancy check) for error checking.


            Const FUNCTION_CODE As Byte = 6

            Dim SlaveAddressVals() As Byte = BitConverter.GetBytes(pSlaveID)
            Debug.WriteLine("Slave Address : " & String.Join(", ", SlaveAddressVals.ToArray))

            Dim functionVals() As Byte = BitConverter.GetBytes(FUNCTION_CODE)
            Debug.WriteLine("Function Code : " & String.Join(", ", functionVals.ToArray))

            Dim RegisterAddressVals() As Byte = BitConverter.GetBytes(pRegisterAddress)
            If (BitConverter.IsLittleEndian) Then RegisterAddressVals = RegisterAddressVals.Reverse().ToArray()
            Debug.WriteLine("Register Address : " & String.Join(", ", RegisterAddressVals.ToArray))

            Dim floatVals() As Byte = BitConverter.GetBytes(pValueToWrite)
            If (BitConverter.IsLittleEndian) Then floatVals = floatVals.Reverse().ToArray()
            Debug.WriteLine("Value To Write : " & String.Join(", ", floatVals.ToArray))


            Dim messageFrame As New MemoryStream(RegisterAddressVals.Length + floatVals.Length + 2)

            messageFrame.Write(SlaveAddressVals, 0, 1)
            messageFrame.Write(functionVals, 0, 1)
            messageFrame.Write(RegisterAddressVals, 0, RegisterAddressVals.Length)
            messageFrame.Write(floatVals, 0, floatVals.Length)

            Debug.WriteLine("Message Frame : " & String.Join(", ", messageFrame.ToArray))

            Dim crc() As Byte = ModbusUtility.CalculateCrc(messageFrame.ToArray)

            'Dim crc() As Byte = BitConverter.GetBytes(CalculateCRC(messageFrame.ToArray))


            Dim messageBody As New MemoryStream(messageFrame.Length + crc.Length)

            messageBody.Write(messageFrame.ToArray, 0, messageFrame.Length)
            messageBody.Write(crc, 0, crc.Length)

            'write 
            Debug.WriteLine("TX: " & String.Join(", ", messageBody.ToArray))
            pSerialPort.Write(messageBody.ToArray, 0, messageBody.Length)

            'read response (The normal response is an echo of the query, returned after the register contents have been written)
            Dim responseBuffer(messageBody.Length - 1) As Byte 'minus 1 because in vb array starts from 0 to Length

            pSerialPort.Read(responseBuffer, 0, messageBody.Length)
            Debug.WriteLine("RX: " & String.Join(", ", responseBuffer))

            If Not responseBuffer.SequenceEqual(messageBody.ToArray) Then
                Throw New Exception("Invalid Response")
            End If

            pSerialPort.DiscardInBuffer()

        End Sub


        Public Shared Function ReadSingle(ByRef pSerialPort As SerialPort, pSlaveID As Byte, pRegisterAddress As UShort) As Single

            'Request 
            'This command is requesting the contents of numeric variable # 7021
            'from the slave device with address 17.

            '11 03 1B6D 0001 11A3

            '11: The Slave Address (11 hex = address17 )
            '03: The Function Code (read Numeric variables)
            '1B6D: The Data Address of the first variable requested. ( 1B6D hex = 7021 )
            '0001: The total number of variables requested. (read 1 variable) 
            '11A3: The CRC (cyclic redundancy check) for error checking.

            'Response

            '11 03 04 476C4A00 083B

            '11: The Slave Address (11 hex = address17 )
            '03: The Function() Code(read Numeric variables)
            '04 The number of data bytes to follow (1 registers x 4 bytes each = 4 bytes)
            '476C4A00: The contents of  32-bit variable # 7021
            '083B: The crc(cyclic redundancy check).

            Const FUNCTION_CODE As Byte = 3
            Const NUM_OF_VARIABLE_REQUESTED As UShort = 1
            Const CONST_RESPONSE_LENGTH As Integer = 9

            Dim SlaveAddressVals() As Byte = BitConverter.GetBytes(pSlaveID)
            Debug.WriteLine("Slave Address : " & String.Join(", ", SlaveAddressVals.ToArray))

            Dim functionVals() As Byte = BitConverter.GetBytes(FUNCTION_CODE)
            Debug.WriteLine("Function Code : " & String.Join(", ", functionVals.ToArray))

            Dim RegisterAddressVals() As Byte = BitConverter.GetBytes(pRegisterAddress)
            If (BitConverter.IsLittleEndian) Then RegisterAddressVals = RegisterAddressVals.Reverse().ToArray()
            Debug.WriteLine("Register Address : " & String.Join(", ", RegisterAddressVals.ToArray))

            Dim numVariableVals() As Byte = BitConverter.GetBytes(NUM_OF_VARIABLE_REQUESTED)
            If (BitConverter.IsLittleEndian) Then numVariableVals = numVariableVals.Reverse().ToArray()
            Debug.WriteLine("Number Of Variable Requested : " & String.Join(", ", numVariableVals.ToArray))


            Dim messageFrame As New MemoryStream(RegisterAddressVals.Length + numVariableVals.Length + 2)

            messageFrame.Write(SlaveAddressVals, 0, 1)
            messageFrame.Write(functionVals, 0, 1)
            messageFrame.Write(RegisterAddressVals, 0, RegisterAddressVals.Length)
            messageFrame.Write(numVariableVals, 0, numVariableVals.Length)

            Debug.WriteLine("Message Frame : " & String.Join(", ", messageFrame.ToArray))

            Dim crc() As Byte = ModbusUtility.CalculateCrc(messageFrame.ToArray)
            Dim messageBody As New MemoryStream(messageFrame.Length + crc.Length)

            messageBody.Write(messageFrame.ToArray, 0, messageFrame.Length)
            messageBody.Write(crc, 0, crc.Length)

            'write 
            Debug.WriteLine("TX: " & String.Join(", ", messageBody.ToArray))
            pSerialPort.Write(messageBody.ToArray, 0, messageBody.Length)



            Dim responseBuffer(CONST_RESPONSE_LENGTH - 1) As Byte 'Length = 9 because array in vb starts from 0 to 8

            pSerialPort.Read(responseBuffer, 0, CONST_RESPONSE_LENGTH)
            Debug.WriteLine("RX: " & String.Join(", ", responseBuffer))

            ' responseBuffer(0) -> should Contain Slave Address
            ' responseBuffer(1) -> should Contain Function Code
            ' responseBuffer(2) -> should Contain Length (4 for 1 single floating point)
            ' responseBuffer(3) To responseBuffer(7) -> should contain value being read (length = 4)
            ' responseBuffer(8) To responseBuffer(9) -> CRC

            Dim ValueStream As New MemoryStream(4)
            ValueStream.Write(responseBuffer, 3, 4)

            Debug.WriteLine("Values Read : " & String.Join(", ", ValueStream.ToArray))

            Dim f As Single

            If (BitConverter.IsLittleEndian) Then
                f = BitConverter.ToSingle(ValueStream.ToArray.Reverse.ToArray(), 0)
            Else
                f = BitConverter.ToSingle(ValueStream.ToArray(), 0)
            End If

            Debug.WriteLine("Values Read (Single) : " & f)


            'calculate CRC
            Debug.WriteLine("CRC 1 : " & BitConverter.ToUInt16(responseBuffer, responseBuffer.Length - 2))


            Dim crcBuffer(responseBuffer.Length - 2) As Byte
            Dim ResponseCRCStream As New MemoryStream(responseBuffer.Length - 2)
            ResponseCRCStream.Write(responseBuffer, 0, responseBuffer.Length - 2)
            crcBuffer = ResponseCRCStream.ToArray

            'Debug.WriteLine("CRC 2 : " & BitConverter.ToUInt16(ModbusUtility.CalculateCrc(crcBuffer), 0))

            'If Not (BitConverter.ToUInt16(ModbusUtility.CalculateCrc(crcBuffer), 0) = BitConverter.ToUInt16(responseBuffer, responseBuffer.Length - 2)) Then
            '    Throw New Exception("CRC Failed")
            'End If

            pSerialPort.DiscardInBuffer()

            Return f


        End Function



    End Class



End Namespace


