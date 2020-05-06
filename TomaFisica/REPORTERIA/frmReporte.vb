Public Class frmReporte
    Public p_numero As Integer
    Public p_usuario As String
    Public p_bodega As Integer
    Private Sub FrmReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Cls_FuncionesPrincipales.DevolverVersion(Me)
            Me.CONSULTAR_TOMA_FISICA2TableAdapter.Fill(Me.VISTAS.CONSULTAR_TOMA_FISICA2, g_empresa, p_numero, p_usuario, p_bodega, 1000, 1, g_fechaTomaFisica, g_sucursal)
            ' Me.CONSULTAR_TOMA_FISICA2TableAdapter.Fill(Me.VISTAS.CONSULTAR_TOMA_FISICA2, g_empresa, p_numero, p_usuario, p_bodega, 1000, 1, g_fechaTomaFisica)
            Me.visor.RefreshReport()
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, "Error al cargar", MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
        Me.visor.RefreshReport
    End Sub


End Class