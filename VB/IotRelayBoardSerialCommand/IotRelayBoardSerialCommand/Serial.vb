Module Serial
    Public Function SendSerialData(ByVal data As String, ByVal ComPort As String)
        Using com As IO.Ports.SerialPort =
                My.Computer.Ports.OpenSerialPort(ComPort)
            com.WriteLine(data)
        End Using
        Return "0"
    End Function


    Sub Main()
        Console.Write("Enter Com Port :")
        Dim ComPortNo As String = Console.ReadLine()
        Console.Write("Enter argument :")
        SendSerialData(Console.ReadLine() + "\r\n", ComPortNo) 'sending
    End Sub
End Module
