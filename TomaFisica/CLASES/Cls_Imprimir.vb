Imports System.IO.Ports

Public Class Cls_Imprimir

    Private mySerialPort As New SerialPort
    'Public Sub configuracionPuerto(_nombrePuerto As String)
    '    With mySerialPort
    '        .PortName = _nombrePuerto
    '        .BaudRate = 34800
    '        .DataBits = 8
    '        .Parity = Parity.None
    '        .StopBits = StopBits.One
    '        .Handshake = Handshake.None
    '    End With

    '    Try
    '        mySerialPort.Open()

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub

    Public Sub s_imprimirTicket(dgvTomaFisica As DataGridView)

        Dim objFSO
        Dim objStream
        objFSO = CreateObject("Scripting.FileSystemObject")
        objStream = objFSO.CreateTextFile("LPT1") 'Puerto al cual se envía la impresión
        Dim Texto As String = ""

        Try

            ' objStream.Writeline(Chr(77) & Chr(99) & Chr(48) & Chr(3)) 'Le pedimos que imprima tanto en el rollo Receipt como en el Journal
            'objStream.Writeline(Chr(27) & Chr(122) & Chr(0)) 'Ponemos en Off la impresion paralela

            For Each f As DataGridViewRow In dgvTomaFisica.Rows
                Texto = "Código: " & f.Cells(8).Value & " Cantidad: " & f.Cells(10).Value
                ' Dim Texto1 As String = "esta linea es diferente"
                Texto = Texto
                'Texto1 = Espacios(Texto1)
                objStream.Writeline(Texto)
                '17:             objStream.Writeline(Texto & "*******")

                '19:             objStream.Writeline("")
            Next
            objStream.Writeline("") 'Espacio en blanco
            objStream.Writeline("") 'Espacio en blanco
            objStream.Writeline("") 'Espacio en blanco
            objStream.Writeline("") 'Espacio en blanco
            objStream.Writeline("") 'Espacio en blanco
            objStream.Writeline("") 'Espacio en blanco
            objStream.Writeline("") 'Espacio en blanco
            objStream.Writeline("") 'Espacio en blanco
            objStream.Writeline(Chr(27) & Chr(109)) ' este es un corte de ticket, no completo
            ' objStream.Writeline(Chr(27) & "p" & Chr(&H0) & Chr(&H64) & Chr(&H64)) ' este abre el cajon del dinero
            If dgvTomaFisica.Rows.Count <= 0 Then
                Texto = "9"
                objStream.Writeline(Texto)
                objStream.Writeline("") 'Espacio en blanco
                objStream.Writeline("") 'Espacio en blanco
                objStream.Writeline("") 'Espacio en blanco
                objStream.Writeline("") 'Espacio en blanco
                objStream.Writeline("") 'Espacio en blanco
                objStream.Writeline("") 'Espacio en blanco
                objStream.Writeline("") 'Espacio en blanco
                objStream.Writeline("") 'Espacio en blanco
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            objStream.Writeline(Chr(27) & Chr(64)) ' limpia Buffer de la impresora
            objStream.Writeline(Chr(27) & Chr(60)) ' la deja en Posicion Stand BY

            objStream.Close()

            objFSO = Nothing
            objStream = Nothing


        End Try
    End Sub

    Public Function Espacios(ByVal dato As String) As String
        Dim rta As String = dato
        Try
            Dim h As Long
            h = 1
            If Len(dato) >= 40 Then
                dato = Mid(dato, 1, 40)
                Return rta
            End If
            Do
                If Len(dato) < 40 Then
                    dato = dato & " "
                End If
                If Len(dato) = 40 Then
                    rta = dato
                    Return rta
                End If
                h = h + 1
            Loop

        Catch ex As Exception
            Return rta
        End Try
    End Function

End Class
