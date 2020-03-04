Public Class Cls_ObtenerHora

    Public Function SincronizarHorario(_servidor As String, _puerto As Integer) As String
        Dim tcp As New System.Net.Sockets.TcpClient
        Try
            With tcp
                .Connect(_servidor, _puerto)
                Dim data As [Byte]()
                Dim stream As System.Net.Sockets.NetworkStream = tcp.GetStream()
                data = New [Byte](256) {}
                Dim responseData As [String] = [String].Empty
                Dim bytes As Int32 = stream.Read(data, 0, data.Length)
                '
                'Cortamos la parte de la cadena que nos interesa
                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes).Trim(Chr(10)).Substring(6, 17)
                '
                'La convertimos a un formato de fecha manejable
                responseData = responseData.Substring(6, 2) & "/" & responseData.Substring(3, 2) & "/" & responseData.Substring(0, 2) & " " & responseData.Substring(9)
                '
                'Cerramos la conexión
                tcp.Close()
                '
                ''Asignamos la hora a nuestro sistema
                ''Le resto cuatro horas porque en Venezuela la hora es -4GMT
                ''deben adaptar el valor a su zona horaria
                'TimeOfDay = DateTime.Parse(responseData).AddHours(-6)
                'Today = DateTime.Parse(responseData).AddHours(-6)
                Return responseData
            End With
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

End Class
