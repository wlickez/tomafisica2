Public Class FrmAdministracionTomasFisicas
    Dim l_numero As Integer
    Private Sub FrmAdministracionTomasFisicas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Cls_FuncionesPrincipales.DevolverVersion(Me)
            Me.BODEGATableAdapter.Fill(Me.VISTAS.SUCURSAL, g_empresa)
            Me.USUARIOTableAdapter.Fill(Me.VISTAS.USUARIO)
            CmbSucursal.SelectedIndex = 0
            Me.DgvTomasFisicas.ContextMenuStrip = Me.menucontextoDGV
            ConsultarTomaFisicoMaestro(sender, e)
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, "Error al cargar", MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
    Private Sub ConsultarTomaFisicoMaestro(sender As Object, e As EventArgs)
        Try
            Me.FISICO_MAESTROTableAdapter.Fill(Me.VISTAS.FISICO_MAESTRO, g_empresa, CmbSucursal.SelectedValue, g_usuario, g_fechaTomaFisica)
        Catch ex As System.Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub CmbSucursal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSucursal.SelectedIndexChanged
        ConsultarTomaFisicoMaestro(sender, e)
    End Sub
    Private Sub ImprimirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirToolStripMenuItem.Click
        If DgvTomasFisicas.Rows.Count > 0 Then
            Using f As New frmReporte
                f.p_numero = DgvTomasFisicas.CurrentRow.Cells(0).Value
                f.p_usuario = g_usuario
                f.p_bodega = DgvTomasFisicas.CurrentRow.Cells(5).Value
                f.StartPosition = FormStartPosition.CenterScreen
                f.ShowDialog()
            End Using
        End If
    End Sub
    Private Sub AnuladaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnuladaToolStripMenuItem.Click
        If Cls_Data.CrudTomaFisicaMaestro(g_empresa, DgvTomasFisicas.CurrentRow.Cells(0).Value, TxtFecha.Text, TxtObservaciones.Text, "A", CmbUsuario.SelectedValue, Date.Now.ToShortDateString, CmbSucursal.SelectedValue, 3) Then
            ConsultarTomaFisicoMaestro(sender, e)
        End If
    End Sub
    Private Sub RevisandoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RevisandoToolStripMenuItem.Click
        If Cls_Data.CrudTomaFisicaMaestro(g_empresa, DgvTomasFisicas.CurrentRow.Cells(0).Value, TxtFecha.Text, TxtObservaciones.Text, "R", CmbUsuario.SelectedValue, g_fechaTomaFisica, CmbSucursal.SelectedValue, 3) Then
            ConsultarTomaFisicoMaestro(sender, e)
        End If
    End Sub
    Private Sub CerradaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerradaToolStripMenuItem.Click
        If Cls_Data.CrudTomaFisicaMaestro(g_empresa, DgvTomasFisicas.CurrentRow.Cells(0).Value, TxtFecha.Text, TxtObservaciones.Text, "C", CmbUsuario.SelectedValue, g_fechaTomaFisica, CmbSucursal.SelectedValue, 3) Then
            ConsultarTomaFisicoMaestro(sender, e)
        End If
    End Sub
    Private Sub TrabajandoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrabajandoToolStripMenuItem.Click
        If Cls_Data.CrudTomaFisicaMaestro(g_empresa, DgvTomasFisicas.CurrentRow.Cells(0).Value, TxtFecha.Text, TxtObservaciones.Text, "G", CmbUsuario.SelectedValue, g_fechaTomaFisica, CmbSucursal.SelectedValue, 3) Then
            ConsultarTomaFisicoMaestro(sender, e)
        End If
    End Sub
    Private Sub DgvTomasFisicas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvTomasFisicas.CellClick
        Try
            If DgvTomasFisicas.RowCount > 0 Then
                TxtFecha.Text = DgvTomasFisicas.CurrentRow.Cells(1).Value
                TxtObservaciones.Text = DgvTomasFisicas.CurrentRow.Cells(2).Value
                CmbUsuario.SelectedText = DgvTomasFisicas.CurrentRow.Cells(4).Value
                l_numero = DgvTomasFisicas.CurrentRow.Cells(0).Value
                TxtNumero.Text = l_numero
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim tipo As Integer = 1
        If CmbSucursal.SelectedValue <> 0 And IsDate(TxtFecha.Text) And TxtObservaciones.Text <> "" Then
            For Each d As DataGridViewRow In DgvTomasFisicas.Rows
                If (TxtNumero.Text) = CInt(d.Cells(0).Value) Then
                    tipo = 2
                    Exit For
                End If
            Next
            If Cls_Data.CrudTomaFisicaMaestro(g_empresa, CInt(TxtNumero.Text), TxtFecha.Text, TxtObservaciones.Text, "G", CmbUsuario.SelectedValue, TxtFecha.Text, CmbSucursal.SelectedValue, tipo) Then
                ConsultarTomaFisicoMaestro(sender, e)
            End If
        End If
    End Sub
    Private Sub DgvTomasFisicas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvTomasFisicas.CellDoubleClick
        Using f As New frmReporte
            f.p_numero = CInt(DgvTomasFisicas.CurrentRow.Cells(0).Value)
            f.p_usuario = g_usuario
            f.p_bodega = CInt(DgvTomasFisicas.CurrentRow.Cells(5).Value)
            f.StartPosition = FormStartPosition.CenterScreen
            f.ShowDialog()
        End Using
    End Sub
End Class