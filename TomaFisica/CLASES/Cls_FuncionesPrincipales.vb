Imports System.IO

Public Class Cls_FuncionesPrincipales
    Public Shared Sub KeyDownFormulariosFacturacion(_e As KeyEventArgs, _formulario As Form, _txtCodigoProducto As TextBox, _txtNombreProducto As TextBox, _sucursal As Integer, _dgv As DataGridView)
        If _e.KeyCode = Keys.Escape Then
            _formulario.Dispose()
        ElseIf _e.KeyCode = Keys.F3 Then
            Using f As New FrmBusquedaProducto
                f.p_sucursal = _sucursal
                f.p_txtCodigoProducto = _txtCodigoProducto
                f.p_txtNombreProducto = _txtNombreProducto
                f.ShowDialog()
            End Using
        ElseIf _e.KeyCode = Keys.F6 Then
            Dim c As New Cls_Imprimir
            c.s_imprimirTicket(_dgv)
        End If
    End Sub
    Public Shared Sub EnviarObjetosParaBusqueda(_txtCodigoProducto As TextBox, _txtNombreProducto As TextBox, _sucursal As Integer)
        Using f As New FrmBusquedaProducto
            f.p_sucursal = _sucursal
            f.p_txtCodigoProducto = _txtCodigoProducto
            f.p_txtNombreProducto = _txtNombreProducto
            f.ShowDialog()
        End Using
    End Sub

    Public Shared Sub DigitarCantidadesEnteras(_e As KeyPressEventArgs)
        _e.Handled = Not IsNumeric(_e.KeyChar) And Not Char.IsControl(_e.KeyChar)
    End Sub
    Public Shared Sub VaciarValoresNuevaFacturaCredito(_tablaContenedoraMontos As TableLayoutPanel)
        Try

            For Each control1 As Control In _tablaContenedoraMontos.Controls
                If TypeOf control1 Is TextBox Then
                    control1.Text = ""
                End If
            Next
        Catch ex As Exception
            Dim st As New System.Diagnostics.StackTrace()

            MsgBox(ex.Message, vbCritical, "Facturación")
        End Try
    End Sub
    Public Shared Sub DevolverVersion(_frmInicial As Form)

        With _frmInicial
            .Text = _frmInicial.Text & " /" & g_usuario & " v." & My.Application.Info.Version.ToString
            Dim directorio = My.Computer.FileSystem.CurrentDirectory
            'If Directory.Exists(directorio) Then
            '    MsgBox("existe")
            'Else
            '    MsgBox("no eixste")
            'End If
            'MsgBox(directorio)
            .Icon = New Icon(directorio & "\icono.ico")
            .StartPosition = FormStartPosition.CenterScreen
            .MinimizeBox = False
            .MaximizeBox = False
            '.WindowState = FormWindowState.Maximized
        End With

    End Sub
    Public Shared Sub AbrirFomulario(frmFinal As Form)
        Try
            Dim nombreFormulario As String = g_nombreApp + frmFinal.Name.ToString
            Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
            Dim frm As Form = CType(asm.CreateInstance(nombreFormulario), Form)
            frm.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
