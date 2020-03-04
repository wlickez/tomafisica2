Public Class frmReporte
    Public p_numero As Integer
    Public p_usuario As String
    Public p_bodega As Integer
    Private Sub FrmReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cls_FuncionesPrincipales.DevolverVersion(Me)
        Me.CONSULTAR_TOMA_FISICATableAdapter.Fill(Me.VISTAS.CONSULTAR_TOMA_FISICA, g_empresa, p_numero, p_usuario, p_bodega, 1000, 1, g_fechaTomaFisica)
        Me.visor.RefreshReport()
    End Sub
End Class