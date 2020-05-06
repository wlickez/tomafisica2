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
                    LblCantidadDiferencias.Text = dgvDiferencias.Rows.Count.ToString
                End If
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnCargarDiferencias_Click(sender As Object, e As EventArgs) Handles BtnCargarDiferencias.Click
        CargarDiferenciasTomaFisicas()
    End Sub

    Private Sub BtnExcel_Click(sender As Object, e As EventArgs) Handles BtnExcel.Click
        Try
            Dim excel As New Cls_ExportToExcel
            excel.ExportToExcel(dgvDiferencias)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function ConvertToList(dgv As Object) As List(Of String)
        'Dim filaDatos As New List(Of String)
        'Dim datos As New List(Of String)
        ''Dim d() As New String = 
        'Dim i As Integer = 0
        'Dim j As Integer = 0


        'For Each fila As DataGridViewRow In dgv.Rows
        '    For Each celda As DataGridViewCell In fila.Cells
        '        d(i) = celda.Value
        '    Next
        '    filaDatos.Add(d.ToString())
        '    datos.Add(filaDatos.ToString)
        'Next

        'Return datos
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnConvertToList.Click
        Try
            Dim obj As New Object
            obj = dgvDiferencias
            MessageBox.Show(ConvertToList(obj).ToList().ToString())
        Catch ex As Exception

        End Try
    End Sub
End Class