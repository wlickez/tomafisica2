Public Class FrmCostos
    Public flogin As Form
    Private Sub ConsultaCostos(_codigoProducto As String)
        Try
            If String.IsNullOrEmpty(_codigoProducto) Then
                MessageBox.Show("No puede hacer búsquedas sin campos vacios")
                TxtCodigoProducto.Focus()
            Else
                Me.COSTOSTableAdapter.Fill(Me.VISTAS.COSTOS, _codigoProducto, g_empresa)
                For Each f As DataGridViewRow In DgvCostos.Rows
                    If CInt(f.Cells(5).Value <= 0 And f.Cells(6).Value > 0) Then
                        f.DefaultCellStyle.BackColor = Color.LightGray
                        'For Each c As DataGridViewCell In f.Cells
                        '    c.Style.BackColor = Color.AliceBlue
                        'Next
                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Cls_FuncionesPrincipales.EnviarObjetosParaBusqueda(TxtCodigoProducto, TxtNombreProducto, 1)
        If TxtCodigoProducto.Text.Length > 0 Then
            TxtCodigoProducto.Focus()
        End If
    End Sub
    Private Sub BtnConsultarCostos_Click(sender As Object, e As EventArgs) Handles BtnConsultarCostos.Click
        ConsultaCostos(TxtCodigoProducto.Text)
    End Sub
    Private Sub TxtCodigoProducto_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCodigoProducto.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TxtCodigoProducto.Text.Length = 0 Then
                MessageBox.Show("Ingrese un [Código de Etiqueta Amarilla] o [Código Barra] ", "Campo vacio", MessageBoxButtons.OK)
            Else
                If Cls_Data.ConsultarProducto(g_empresa, 1, "", TxtCodigoProducto.Text, TxtCodigoProducto, TxtNombreProducto) Then
                    TxtCodigoProducto.Focus()
                Else
                    MessageBox.Show("Ingrese un [Código de Etiqueta amarilla] o [CódigoBarra] correcto", "Código incorrecto", MessageBoxButtons.OK)
                End If
            End If
        End If
    End Sub
    Private Sub TxtCodigoProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCodigoProducto.KeyPress
        Cls_FuncionesPrincipales.DigitarCantidadesEnteras(e)
    End Sub

    Private Sub TsmEditar_Click(sender As Object, e As EventArgs) Handles TsmEditar.Click
        If DgvCostos.Rows.Count > 0 Then
            Try
                Dim valor As Double = InputBox("Costo nuevo", "Modificación")
                If valor <= 0 Then
                    MessageBox.Show("Ha ocurrido un error: No puede actualizar con cantidad cero (0)", "Seleccionar fila", MessageBoxButtons.OK)
                    Exit Sub
                End If
                Dim fila As DataGridViewRow = DgvCostos.CurrentRow
                If Cls_Data.CrudCostos(CStr(fila.Cells(2).Value), CInt(fila.Cells(0).Value), valor, 2) Then
                    ConsultaCostos(TxtCodigoProducto.Text)
                    TxtCodigoProducto.Focus()
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If
    End Sub
    Private Sub ColorPickEdit1_ColorChanged(sender As Object, e As EventArgs)
        ConsultaCostos(TxtCodigoProducto.Text)
    End Sub
    Private Sub FrmCostos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cls_FuncionesPrincipales.DevolverVersion(Me)
        Me.DgvCostos.ContextMenuStrip = Me.cmsMenuDgv
    End Sub
    Private Sub FrmPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        flogin.Show()
        Me.Dispose()
    End Sub
End Class