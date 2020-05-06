<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReporte
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.VISTAS = New TomaFisica.VISTAS()
        Me.CONSULTAR_TOMA_FISICA2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONSULTAR_TOMA_FISICA2TableAdapter = New TomaFisica.VISTASTableAdapters.CONSULTAR_TOMA_FISICA2TableAdapter()
        Me.visor = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.VISTAS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONSULTAR_TOMA_FISICA2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VISTAS
        '
        Me.VISTAS.DataSetName = "VISTAS"
        Me.VISTAS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CONSULTAR_TOMA_FISICA2BindingSource
        '
        Me.CONSULTAR_TOMA_FISICA2BindingSource.DataMember = "CONSULTAR TOMA FISICA2"
        Me.CONSULTAR_TOMA_FISICA2BindingSource.DataSource = Me.VISTAS
        '
        'CONSULTAR_TOMA_FISICA2TableAdapter
        '
        Me.CONSULTAR_TOMA_FISICA2TableAdapter.ClearBeforeFill = True
        '
        'visor
        '
        Me.visor.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource3.Name = "TOMAFISICA"
        ReportDataSource3.Value = Me.CONSULTAR_TOMA_FISICA2BindingSource
        Me.visor.LocalReport.DataSources.Add(ReportDataSource3)
        Me.visor.LocalReport.ReportEmbeddedResource = "TomaFisica.rptTomaFisica.rdlc"
        Me.visor.Location = New System.Drawing.Point(0, 0)
        Me.visor.Name = "visor"
        Me.visor.Size = New System.Drawing.Size(800, 450)
        Me.visor.TabIndex = 0
        '
        'frmReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.visor)
        Me.Name = "frmReporte"
        Me.Text = "FrmReporte"
        CType(Me.VISTAS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONSULTAR_TOMA_FISICA2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CONSULTAR_TOMA_FISICA2BindingSource As BindingSource
    Friend WithEvents VISTAS As VISTAS
    Friend WithEvents CONSULTAR_TOMA_FISICA2TableAdapter As VISTASTableAdapters.CONSULTAR_TOMA_FISICA2TableAdapter
    Friend WithEvents visor As Microsoft.Reporting.WinForms.ReportViewer
End Class
