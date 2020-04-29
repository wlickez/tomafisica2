Public Class FrmPrincipal
    Public flogin As Form

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Cls_FuncionesPrincipales.DevolverVersion(Me)
            TxtTop.Value = 10
            TxtFechaTomaFisicaReferencia.Text = g_fechaTomaFisica
            Me.BODEGATableAdapter.Fill(Me.VISTAS.BODEGA, g_empresa)
            TxtCodigoAlmacen.Text = g_sucursal
            TxtNombreAlmacen.Text = g_nombreSucursal
            TxtNumeroToma.Text = g_numeroTomaFisica
            TxtObservacionesTomaFisica.Text = g_observacionesTomaFisica
            's_cargarDatosFisicoDetalle(txtNumeroToma.Text, g_usuario, g_sucursal)
            Me.DgvTomaFisica.ContextMenuStrip = Me.menucontextoDGV
            CmbBodegas.SelectedValue = g_sucursal
            Me.FISICO_MAESTROTableAdapter.Fill(Me.VISTAS.FISICO_MAESTRO, g_empresa, CmbBodegas.SelectedValue, g_usuario, g_fechaTomaFisica)
            CargarDatosFisicoDetalle(CmbTomas.SelectedValue, g_usuario, CmbBodegas.SelectedValue, TxtTop.Value)
            If (g_usuario.ToLower = "wlickez" Or g_usuario.ToLower = "dtrujillo" Or g_usuario.ToLower = "dchen") Then
                CmbBodegas.Enabled = True
                CmbBodegas.SelectedValue = 1
                TxtBuscarPosicion.Visible = True
                BtnBuscarPosicion.Visible = True
                For Each t As ToolStripMenuItem In Me.MenuStripPrincipal.Items
                    If t.Tag = "1" Then
                        t.Visible = True
                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        flogin.Show()
        Me.Dispose()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Dispose()
        Application.Exit()
    End Sub
    Private Sub AdministrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarToolStripMenuItem.Click
        Using f As New FrmAdministracionTomasFisicas
            f.StartPosition = FormStartPosition.CenterScreen
            f.ShowDialog()
        End Using
    End Sub
    Private Sub SeleccionadasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeleccionadasToolStripMenuItem.Click
        Using f As New FrmImpresionVarias
            f.p_numero = CInt(CmbTomas.SelectedValue)
            f.p_usuario = g_usuario
            f.p_bodega = CInt(CmbBodegas.SelectedValue)
            f.StartPosition = FormStartPosition.CenterScreen
            f.ShowDialog()
        End Using
    End Sub
    Private Sub BtnReporte_Click(sender As Object, e As EventArgs) Handles BtnReporte.Click
        Using f As New frmReporte
            f.p_numero = CInt(CmbTomas.SelectedValue)
            f.p_usuario = g_usuario
            f.p_bodega = CInt(CmbBodegas.SelectedValue)
            f.StartPosition = FormStartPosition.CenterScreen
            f.ShowDialog()
        End Using
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Cls_FuncionesPrincipales.EnviarObjetosParaBusqueda(TxtCodigoProducto, TxtNombreProducto, CInt(CmbBodegas.SelectedValue))
        If TxtCodigoProducto.Text.Length > 0 Then
            TxtFisico.Focus()
        End If
    End Sub

    Private Sub BtnAgregarDetalle_Click(sender As Object, e As EventArgs) Handles BtnAgregarDetalle.Click

        'hacer el insert a la base de datos
        'leer el registro de la base de datos y mostrarlo en el dgv
        If (TxtCodigoProducto.Text.Length > 0 And TxtNombreProducto.Text.Length > 0 And TxtFisico.Text.Length > 0) Then
            'dgvTomaFisica.Rows.Add()
            'Dim cantFilas As Integer = dgvTomaFisica.Rows.Count - 1
            'dgvTomaFisica.Rows(cantFilas).Cells(0).Value = txtCodigoProducto.Text
            'dgvTomaFisica.Rows(cantFilas).Cells(1).Value = txtNombreProducto.Text
            'dgvTomaFisica.Rows(cantFilas).Cells(2).Value = txtFisico.Text
            'If cls_Data.f_crudTomaFisicaDetalle(CInt(txtNumeroToma.Text), txtCodigoProducto.Text, 1, 1, CInt(txtFisico.Text), CInt(txtCodigoAlmacen.Text), 1, 0) Then
            If Cls_Data.CrudTomaFisicaDetalle(CInt(CmbTomas.SelectedValue), TxtCodigoProducto.Text, 1, g_empresa, CInt(TxtFisico.Text), CInt(CmbBodegas.SelectedValue), 1, 0, g_fechaTomaFisica) Then
                Cls_FuncionesPrincipales.VaciarValoresNuevaFacturaCredito(TlpDatosDetalle)
                CargarDatosFisicoDetalle(CInt(CmbTomas.SelectedValue), g_usuario, CInt(CmbBodegas.SelectedValue), TxtTop.Value)
                Me.TxtCodigoProducto.Focus()
            End If
        Else
            MessageBox.Show("Algún dato importante falta, por favor verifique", "Datos importante", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub TxtCodigoProducto_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCodigoProducto.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TxtCodigoProducto.Text.Length <= 6 Then
                MessageBox.Show("Ingrese un [Código de Etiqueta Amarilla] o [Código Barra] ", "Campo vacio", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If Cls_Data.ConsultarProducto(g_empresa, CInt(CmbBodegas.SelectedValue), "", TxtCodigoProducto.Text, TxtCodigoProducto, TxtNombreProducto) Then
                    TxtFisico.Focus()
                Else
                    MessageBox.Show("Ingrese un [Código de Etiqueta amarilla] o [CódigoBarra] correcto", "Código incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub
    Private Sub CargarDatosFisicoDetalle(_numeroToma As Integer, _usuario As String, _sucursal As Integer, _top As Integer)
        Try
            Me.CONSULTAR_TOMA_FISICATableAdapter.Fill(Me.VISTAS.CONSULTAR_TOMA_FISICA, g_empresa, _numeroToma, _usuario, _sucursal, _top, 2, g_fechaTomaFisica)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub TxtCodigoProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCodigoProducto.KeyPress
        Cls_FuncionesPrincipales.DigitarCantidadesEnteras(e)
    End Sub
    Private Sub TxtFisico_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtFisico.KeyPress
        Cls_FuncionesPrincipales.DigitarCantidadesEnteras(e)
    End Sub
    Private Sub TxtBuscarPosicion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBuscarPosicion.KeyPress
        Cls_FuncionesPrincipales.DigitarCantidadesEnteras(e)
    End Sub
    Private Sub BtnBuscarPosicion_Click(sender As Object, e As EventArgs) Handles BtnBuscarPosicion.Click
        BuscarPosicion()
    End Sub
    Private Sub BuscarPosicion()
        Dim contadoras As Integer = 0
        Try
            For Each d As DataGridViewRow In DgvTomaFisica.Rows
                'MessageBox.Show(d.Cells(12).Value.ToString)
                If d.Cells(12).Value.ToString = TxtBuscarPosicion.Text Then
                    DgvTomaFisica.CurrentCell = DgvTomaFisica.Item(d.Cells(12).ColumnIndex, contadoras)
                    TxtBuscarPosicion.Clear()
                    Exit For
                End If
                contadoras += 1
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub TxtTop_ValueChanged(sender As Object, e As EventArgs) Handles TxtTop.ValueChanged
        CargarDatosFisicoDetalle(CmbTomas.SelectedValue, g_usuario, CmbBodegas.SelectedValue, TxtTop.Value)
    End Sub
    Private Sub FrmPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        flogin.Show()
        Me.Dispose()
    End Sub
    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        If DgvTomaFisica.Rows.Count > 0 Then
            Try
                Dim valor As Integer = InputBox("Cantidad", "Modificación")
                If valor = 0 Then
                    MessageBox.Show("Ha ocurrido un error: No puede actualizar con cantidad cero (0)", "Seleccionar fila", MessageBoxButtons.OK)
                    Exit Sub
                End If

                Dim fila As DataGridViewRow = DgvTomaFisica.CurrentRow
                'If cls_Data.f_crudTomaFisicaDetalle(CInt(fila.Cells(7).Value), fila.Cells(8).Value, 1, 1, valor, CInt(fila.Cells(5).Value), 2, CInt(fila.Cells(12).Value)) Then
                If Cls_Data.CrudTomaFisicaDetalle(CInt(fila.Cells(7).Value), fila.Cells(8).Value, 1, g_empresa, valor, CInt(fila.Cells(5).Value), 2, CInt(fila.Cells(12).Value), g_fechaTomaFisica) Then
                    CargarDatosFisicoDetalle(CInt(CmbTomas.SelectedValue), g_usuario, CInt(CmbBodegas.SelectedValue), TxtTop.Value)
                    Me.TxtCodigoProducto.Focus()
                End If

            Catch ex As Exception
                MessageBox.Show("Ha ocurrido un error: " & ex.Message, "Seleccionar fila", MessageBoxButtons.OK)
            End Try
        End If
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If DgvTomaFisica.Rows.Count > 0 Then
            Dim fila As DataGridViewRow = DgvTomaFisica.CurrentRow
            If Cls_Data.CrudTomaFisicaDetalle(CInt(fila.Cells(7).Value), fila.Cells(8).Value, 1, g_empresa, 0, CInt(fila.Cells(5).Value), 3, CInt(fila.Cells(12).Value), g_fechaTomaFisica) Then
                CargarDatosFisicoDetalle(CInt(CmbTomas.SelectedValue), g_usuario, CInt(CmbBodegas.SelectedValue), TxtTop.Value)
                Me.TxtCodigoProducto.Focus()
            End If
        End If
    End Sub

    Private Sub FrmPrincipal_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Cls_FuncionesPrincipales.KeyDownFormulariosFacturacion(e, Me, TxtCodigoProducto, TxtNombreProducto, CInt(CmbBodegas.SelectedValue), DgvTomaFisica)
    End Sub
    Private Sub CmbBodegas_SelectedValueChanged(sender As Object, e As EventArgs) Handles CmbBodegas.SelectedValueChanged
        Me.FISICO_MAESTROTableAdapter.Fill(Me.VISTAS.FISICO_MAESTRO, g_empresa, CmbBodegas.SelectedValue, g_usuario, g_fechaTomaFisica)
        TxtCodigoAlmacen.Text = CmbBodegas.SelectedValue
    End Sub
    Private Sub CmbTomas_SelectedValueChanged(sender As Object, e As EventArgs) Handles CmbTomas.SelectedValueChanged
        CargarDatosFisicoDetalle(CmbTomas.SelectedValue, g_usuario, CmbBodegas.SelectedValue, TxtTop.Value)
        TxtNumeroToma.Text = CmbTomas.SelectedValue
    End Sub

    Private Sub TxtBuscarPosicion_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtBuscarPosicion.KeyDown
        If e.KeyCode = Keys.Enter Then
            BuscarPosicion()
        End If
    End Sub
    Private Sub DiferenciasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DiferenciasToolStripMenuItem1.Click
        Dim f As New FrmDiferencias
        f.p_sucursal = CInt(CmbBodegas.SelectedValue)
        f.StartPosition = FormStartPosition.CenterScreen
        f.ShowDialog()
    End Sub
End Class