Public Class FrmDiferencias
    Public p_sucursal As Integer
    Private Sub TxtNumeroEntrada_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNumeroEntrada.KeyPress
        Cls_FuncionesPrincipales.DigitarCantidadesEnteras(e)
    End Sub

    Private Sub TxtNumeroSalida_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNumeroSalida.KeyPress
        Cls_FuncionesPrincipales.DigitarCantidadesEnteras(e)
    End Sub

    Private Sub FrmDiferencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            TxtFecha.Value = g_fechaTomaFisica
            Cls_FuncionesPrincipales.DevolverVersion(Me)
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, "Error al cargar")
        End Try
    End Sub

    Private Sub CargarDiferenciasTomaFisicas()
        Try
            If TxtNumeroEntrada.Text <> String.Empty Then
                If TxtNumeroSalida.Text <> String.Empty Then
                    Me.CONSULTAR_DIFERENCIAS_TOMA_FISICATableAdapter.Fill(Me.VISTAS.CONSULTAR_DIFERENCIAS_TOMA_FISICA, g_empresa, p_sucursal, 1, CInt(TxtNumeroSalida.Text), CInt(TxtNumeroEntrada.Text), g_fechaTomaFisica)
                End If
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnCargarDiferencias_Click(sender As Object, e As EventArgs) Handles BtnCargarDiferencias.Click
        CargarDiferenciasTomaFisicas()
    End Sub
End Class