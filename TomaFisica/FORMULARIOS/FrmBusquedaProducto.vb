Public Class FrmBusquedaProducto
    Public p_bodega As Integer
    Public p_txtCodigoProducto As TextBox
    Public p_txtNombreProducto As TextBox
    Private Sub FrmBusquedaProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Cls_FuncionesPrincipales.DevolverVersion(Me)
            TxtBusquedaProducto.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click
        Try
            If TxtBusquedaProducto.Text <> "" Or TxtBusquedaProducto.Text <> Nothing Then
                Me.CONSULTAR_PRODUCTOS_EXISTENCIASTableAdapter.CONSULTAREXISTENCIAS(Me.VISTAS.CONSULTAR_PRODUCTOS_EXISTENCIAS, g_empresa, p_bodega, TxtBusquedaProducto.Text, "", 1)
                If DgvDatosProducto.RowCount > 0 Then
                    DgvDatosProducto.Focus()
                End If
            Else
                TxtBusquedaProducto.Focus()
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub TxtBusquedaProducto_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtBusquedaProducto.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnConsultar_Click(sender, e)
        End If
    End Sub
    Private Sub FrmBusquedaProducto_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
    Private Sub DgvDatosProducto_KeyDown(sender As Object, e As KeyEventArgs) Handles DgvDatosProducto.KeyDown
        If e.KeyCode = Keys.Enter Then
            If DgvDatosProducto.Rows.Count > 0 Then
                Try
                    p_txtCodigoProducto.Text = CStr(DgvDatosProducto.CurrentRow.Cells(0).Value)
                    p_txtNombreProducto.Text = CStr(DgvDatosProducto.CurrentRow.Cells(1).Value)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    Me.Dispose()
                End Try
            End If
        End If
    End Sub
    Private Sub DgvDatosProducto_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvDatosProducto.CellDoubleClick
        If DgvDatosProducto.Rows.Count > 0 Then
            Try
                p_txtCodigoProducto.Text = CStr(DgvDatosProducto.CurrentRow.Cells(0).Value)
                p_txtNombreProducto.Text = CStr(DgvDatosProducto.CurrentRow.Cells(1).Value)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                Me.Dispose()
            End Try
        End If
    End Sub
End Class