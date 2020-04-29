Public Class FrmElecciones
    Public flogin As Form
    Private Sub FrmElecciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Cls_FuncionesPrincipales.DevolverVersion(Me)
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, "Error al cargar")
        End Try

    End Sub

    Private Sub BtnTomasFisicas_Click(sender As Object, e As EventArgs) Handles BtnTomasFisicas.Click
        Using f As New FrmPrincipal
            f.flogin = Me
            f.StartPosition = FormStartPosition.CenterScreen
            f.ShowDialog()
        End Using
    End Sub

    Private Sub BtnCostos_Click(sender As Object, e As EventArgs) Handles BtnCostos.Click
        Using f As New FrmCostos
            f.flogin = Me
            f.StartPosition = FormStartPosition.CenterScreen
            f.ShowDialog()
        End Using
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        flogin.Show()
        Me.Dispose()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Dispose()
        Application.Exit()
    End Sub
    Private Sub FrmElecciones_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        flogin.Show()
        Me.Dispose()
    End Sub

End Class