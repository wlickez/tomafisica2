Public Class FrmLogin
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.TxtFechaTomaFisica.Text = CDate(Date.Now.ToShortDateString)
            Cls_FuncionesPrincipales.DevolverVersion(Me)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub IniciarSesion()
        If Cls_Data.Login(TxtUsuario.Text, TxtClave.Text, Me) Then
            g_usuario = TxtUsuario.Text
            g_fechaTomaFisica = TxtFechaTomaFisica.Text
            If (Cls_Data.ConsultaDatosUsuario(g_empresa, g_usuario, g_fechaTomaFisica, Me) = False) Then
                Cls_Data.ConsultaDatosUsuarioAdministrador(g_empresa, g_usuario, g_fechaTomaFisica, Me)
            End If
            Me.Hide()
            If Cls_Data.AdministracionCostos(g_empresa, TxtUsuario.Text) Then
                Using f1 As New FrmElecciones
                    f1.flogin = Me
                    f1.StartPosition = FormStartPosition.CenterScreen
                    f1.ShowDialog()
                End Using
                Exit Sub
            Else
                Using f As New FrmPrincipal
                    f.flogin = Me
                    f.StartPosition = FormStartPosition.CenterScreen
                    f.ShowDialog()
                End Using
            End If
        End If
    End Sub
    Private Sub FrmLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            IniciarSesion()
        ElseIf e.KeyCode = Keys.F6 Then
            Dim c As New Cls_Imprimir
            c.s_imprimirTicket(New DataGridView)
            'ElseIf e.KeyCode = Keys.F11 Then
            '    Dim c As New cls_obtenerHora
            '    MessageBox.Show(c.s_sincronizar(txtUsuario.Text, CInt(txtClave.Text)))
        End If
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        IniciarSesion()
    End Sub

    Private Sub TxtFechaTomaFisica_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtFechaTomaFisica.KeyPress
        Cls_FuncionesPrincipales.DigitarCantidadesEnteras(e)
    End Sub

    Private Sub TxtFechaTomaFisica_Click(sender As Object, e As EventArgs) Handles TxtFechaTomaFisica.Click
        'txtFechaTomaFisica.Select(1, txtFechaTomaFisica.Text.Length)
        TxtFechaTomaFisica.SelectAll()
    End Sub

    Private Sub TxtFechaTomaFisica_Enter(sender As Object, e As EventArgs) Handles TxtFechaTomaFisica.Enter
        TxtFechaTomaFisica.SelectAll()
    End Sub


    Private Sub TxtFechaTomaFisica_Leave(sender As Object, e As EventArgs) Handles TxtFechaTomaFisica.Leave
        Try
            Me.FISICO_POR_USUARIOTableAdapter.Fill(Me.VISTAS.FISICO_POR_USUARIO, TxtUsuario.Text, TxtFechaTomaFisica.Text)
            SeleccionarSucursal()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CmbSucursales_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSucursales.SelectedIndexChanged
        SeleccionarSucursal()
    End Sub

    Private Sub SeleccionarSucursal()
        Try
            Me.BODEGA_POR_SUCURSALTableAdapter.Fill(Me.VISTAS.BODEGA_POR_SUCURSAL, g_empresa, CInt(CmbSucursales.SelectedValue))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
