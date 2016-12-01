Imports System.Linq
Imports System.Net
Imports System.Text

'Notes : Taken From ModbusUtility.cs From Github Project NModbus4 (Previously NModbus in GoogleCode) , Converted To VB Net
'        There's minor changes in CalculateCrc, since C# is unchecked while vb is checked
'        and NOT all Functions are taken, for the sake of simplicity


Namespace MonyetSoft.EnronModBus

    ''' <summary>
    '''     Modbus utility methods.
    ''' </summary>
    Public NotInheritable Class ModbusUtility
        Private Sub New()

        End Sub

        Private Shared ReadOnly CrcTable As UShort() = {
            &H0, &HC0C1, &HC181, &H140, &HC301, &H3C0,
            &H280, &HC241, &HC601, &H6C0, &H780, &HC741,
            &H500, &HC5C1, &HC481, &H440, &HCC01, &HCC0,
            &HD80, &HCD41, &HF00, &HCFC1, &HCE81, &HE40,
            &HA00, &HCAC1, &HCB81, &HB40, &HC901, &H9C0,
            &H880, &HC841, &HD801, &H18C0, &H1980, &HD941,
            &H1B00, &HDBC1, &HDA81, &H1A40, &H1E00, &HDEC1,
            &HDF81, &H1F40, &HDD01, &H1DC0, &H1C80, &HDC41,
            &H1400, &HD4C1, &HD581, &H1540, &HD701, &H17C0,
            &H1680, &HD641, &HD201, &H12C0, &H1380, &HD341,
            &H1100, &HD1C1, &HD081, &H1040, &HF001, &H30C0,
            &H3180, &HF141, &H3300, &HF3C1, &HF281, &H3240,
            &H3600, &HF6C1, &HF781, &H3740, &HF501, &H35C0,
            &H3480, &HF441, &H3C00, &HFCC1, &HFD81, &H3D40,
            &HFF01, &H3FC0, &H3E80, &HFE41, &HFA01, &H3AC0,
            &H3B80, &HFB41, &H3900, &HF9C1, &HF881, &H3840,
            &H2800, &HE8C1, &HE981, &H2940, &HEB01, &H2BC0,
            &H2A80, &HEA41, &HEE01, &H2EC0, &H2F80, &HEF41,
            &H2D00, &HEDC1, &HEC81, &H2C40, &HE401, &H24C0,
            &H2580, &HE541, &H2700, &HE7C1, &HE681, &H2640,
            &H2200, &HE2C1, &HE381, &H2340, &HE101, &H21C0,
            &H2080, &HE041, &HA001, &H60C0, &H6180, &HA141,
            &H6300, &HA3C1, &HA281, &H6240, &H6600, &HA6C1,
            &HA781, &H6740, &HA501, &H65C0, &H6480, &HA441,
            &H6C00, &HACC1, &HAD81, &H6D40, &HAF01, &H6FC0,
            &H6E80, &HAE41, &HAA01, &H6AC0, &H6B80, &HAB41,
            &H6900, &HA9C1, &HA881, &H6840, &H7800, &HB8C1,
            &HB981, &H7940, &HBB01, &H7BC0, &H7A80, &HBA41,
            &HBE01, &H7EC0, &H7F80, &HBF41, &H7D00, &HBDC1,
            &HBC81, &H7C40, &HB401, &H74C0, &H7580, &HB541,
            &H7700, &HB7C1, &HB681, &H7640, &H7200, &HB2C1,
            &HB381, &H7340, &HB101, &H71C0, &H7080, &HB041,
            &H5000, &H90C1, &H9181, &H5140, &H9301, &H53C0,
            &H5280, &H9241, &H9601, &H56C0, &H5780, &H9741,
            &H5500, &H95C1, &H9481, &H5440, &H9C01, &H5CC0,
            &H5D80, &H9D41, &H5F00, &H9FC1, &H9E81, &H5E40,
            &H5A00, &H9AC1, &H9B81, &H5B40, &H9901, &H59C0,
            &H5880, &H9841, &H8801, &H48C0, &H4980, &H8941,
            &H4B00, &H8BC1, &H8A81, &H4A40, &H4E00, &H8EC1,
            &H8F81, &H4F40, &H8D01, &H4DC0, &H4C80, &H8C41,
            &H4400, &H84C1, &H8581, &H4540, &H8701, &H47C0,
            &H4680, &H8641, &H8201, &H42C0, &H4380, &H8341,
            &H4100, &H81C1, &H8081, &H4040}

        ''' <summary>
        '''     Converts two UInt16 values into a IEEE 32 floating point format
        ''' </summary>
        ''' <param name="highOrderValue">High order ushort value</param>
        ''' <param name="lowOrderValue">Low order ushort value</param>
        ''' <returns>IEEE 32 floating point value</returns>
        Public Shared Function GetSingle(highOrderValue As UShort, lowOrderValue As UShort) As Single
            Return BitConverter.ToSingle(BitConverter.GetBytes(lowOrderValue).Concat(BitConverter.GetBytes(highOrderValue)).ToArray(), 0)
        End Function


        ''' <summary>
        '''     Calculate Cyclical Redundancy Check
        ''' </summary>
        ''' <param name="data">The data used in CRC</param>
        ''' <returns>CRC value</returns>
        Public Shared Function CalculateCrc(data As Byte()) As Byte()
            If data Is Nothing Then
                Throw New ArgumentNullException(NameOf(data))
            End If

            Dim crc As UShort = UShort.MaxValue

            For Each b As Byte In data

                'overflowchecking
                Dim temp As UShort = crc Xor b

                If temp > Byte.MaxValue Then
                    Dim bb() As Byte = BitConverter.GetBytes(temp)
                    temp = CUShort(bb(0))
                End If

                While temp > Byte.MaxValue
                    temp -= Byte.MaxValue
                End While

                Dim tableIndex As Byte = CByte(temp)


                crc >>= 8
                crc = crc Xor CrcTable(tableIndex)
            Next

            Return BitConverter.GetBytes(crc)

        End Function

    End Class
End Namespace
