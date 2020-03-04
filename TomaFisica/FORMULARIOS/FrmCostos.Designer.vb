<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCostos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tlpDatosDetalle = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCodigoProducto = New System.Windows.Forms.TextBox()
        Me.TxtNombreProducto = New System.Windows.Forms.TextBox()
        Me.BtnConsultarCostos = New System.Windows.Forms.Button()
        Me.DgvCostos = New System.Windows.Forms.DataGridView()
        Me.Disponible = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BodegaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SucursalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoPromedioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DisponibleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COSTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VISTAS = New TomaFisica.VISTAS()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmsMenuDgv = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TsmEditar = New System.Windows.Forms.ToolStripMenuItem()
        Me.COSTOSTableAdapter = New TomaFisica.VISTASTableAdapters.COSTOSTableAdapter()
        Me.tlpDatosDetalle.SuspendLayout()
        CType(Me.DgvCostos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COSTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VISTAS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsMenuDgv.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpDatosDetalle
        '
        Me.tlpDatosDetalle.ColumnCount = 6
        Me.tlpDatosDetalle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpDatosDetalle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpDatosDetalle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpDatosDetalle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpDatosDetalle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78.0!))
        Me.tlpDatosDetalle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpDatosDetalle.Controls.Add(Me.BtnAgregar, 3, 0)
        Me.tlpDatosDetalle.Controls.Add(Me.Label3, 0, 0)
        Me.tlpDatosDetalle.Controls.Add(Me.TxtCodigoProducto, 1, 0)
        Me.tlpDatosDetalle.Controls.Add(Me.TxtNombreProducto, 2, 0)
        Me.tlpDatosDetalle.Controls.Add(Me.BtnConsultarCostos, 4, 0)
        Me.tlpDatosDetalle.Location = New System.Drawing.Point(12, 2)
        Me.tlpDatosDetalle.Name = "tlpDatosDetalle"
        Me.tlpDatosDetalle.RowCount = 1
        Me.tlpDatosDetalle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpDatosDetalle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.tlpDatosDetalle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.tlpDatosDetalle.Size = New System.Drawing.Size(810, 33)
        Me.tlpDatosDetalle.TabIndex = 3
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.Location = New System.Drawing.Point(556, 3)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(73, 28)
        Me.BtnAgregar.TabIndex = 3
        Me.BtnAgregar.Text = "Buscar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Producto"
        '
        'TxtCodigoProducto
        '
        Me.TxtCodigoProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigoProducto.Location = New System.Drawing.Point(71, 3)
        Me.TxtCodigoProducto.Name = "TxtCodigoProducto"
        Me.TxtCodigoProducto.Size = New System.Drawing.Size(104, 23)
        Me.TxtCodigoProducto.TabIndex = 1
        '
        'TxtNombreProducto
        '
        Me.TxtNombreProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreProducto.Location = New System.Drawing.Point(181, 3)
        Me.TxtNombreProducto.Name = "TxtNombreProducto"
        Me.TxtNombreProducto.ReadOnly = True
        Me.TxtNombreProducto.Size = New System.Drawing.Size(369, 23)
        Me.TxtNombreProducto.TabIndex = 2
        '
        'BtnConsultarCostos
        '
        Me.BtnConsultarCostos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultarCostos.Location = New System.Drawing.Point(635, 3)
        Me.BtnConsultarCostos.Name = "BtnConsultarCostos"
        Me.BtnConsultarCostos.Size = New System.Drawing.Size(72, 28)
        Me.BtnConsultarCostos.TabIndex = 6
        Me.BtnConsultarCostos.Text = "Costos"
        Me.BtnConsultarCostos.UseVisualStyleBackColor = True
        '
        'DgvCostos
        '
        Me.DgvCostos.AllowUserToAddRows = False
        Me.DgvCostos.AutoGenerateColumns = False
        Me.DgvCostos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCostos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Disponible, Me.BodegaDataGridViewTextBoxColumn, Me.SucursalDataGridViewTextBoxColumn, Me.ProductoDataGridViewTextBoxColumn, Me.NombreProductoDataGridViewTextBoxColumn, Me.CostoPromedioDataGridViewTextBoxColumn, Me.DisponibleDataGridViewTextBoxColumn})
        Me.DgvCostos.DataSource = Me.COSTOSBindingSource
        Me.DgvCostos.Location = New System.Drawing.Point(12, 39)
        Me.DgvCostos.Name = "DgvCostos"
        Me.DgvCostos.Size = New System.Drawing.Size(877, 682)
        Me.DgvCostos.TabIndex = 4
        '
        'Disponible
        '
        Me.Disponible.DataPropertyName = "Disponible"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = "0"
        Me.Disponible.DefaultCellStyle = DataGridViewCellStyle1
        Me.Disponible.HeaderText = "Disponible"
        Me.Disponible.Name = "Disponible"
        '
        'BodegaDataGridViewTextBoxColumn
        '
        Me.BodegaDataGridViewTextBoxColumn.DataPropertyName = "Bodega"
        Me.BodegaDataGridViewTextBoxColumn.HeaderText = "Bodega"
        Me.BodegaDataGridViewTextBoxColumn.Name = "BodegaDataGridViewTextBoxColumn"
        '
        'SucursalDataGridViewTextBoxColumn
        '
        Me.SucursalDataGridViewTextBoxColumn.DataPropertyName = "Sucursal"
        Me.SucursalDataGridViewTextBoxColumn.HeaderText = "Sucursal"
        Me.SucursalDataGridViewTextBoxColumn.Name = "SucursalDataGridViewTextBoxColumn"
        '
        'ProductoDataGridViewTextBoxColumn
        '
        Me.ProductoDataGridViewTextBoxColumn.DataPropertyName = "Producto"
        Me.ProductoDataGridViewTextBoxColumn.HeaderText = "Producto"
        Me.ProductoDataGridViewTextBoxColumn.Name = "ProductoDataGridViewTextBoxColumn"
        '
        'NombreProductoDataGridViewTextBoxColumn
        '
        Me.NombreProductoDataGridViewTextBoxColumn.DataPropertyName = "Nombre Producto"
        Me.NombreProductoDataGridViewTextBoxColumn.HeaderText = "Nombre Producto"
        Me.NombreProductoDataGridViewTextBoxColumn.Name = "NombreProductoDataGridViewTextBoxColumn"
        '
        'CostoPromedioDataGridViewTextBoxColumn
        '
        Me.CostoPromedioDataGridViewTextBoxColumn.DataPropertyName = "Costo Promedio"
        Me.CostoPromedioDataGridViewTextBoxColumn.HeaderText = "Costo Promedio"
        Me.CostoPromedioDataGridViewTextBoxColumn.Name = "CostoPromedioDataGridViewTextBoxColumn"
        '
        'DisponibleDataGridViewTextBoxColumn
        '
        Me.DisponibleDataGridViewTextBoxColumn.DataPropertyName = "Disponible"
        Me.DisponibleDataGridViewTextBoxColumn.HeaderText = "Disponible"
        Me.DisponibleDataGridViewTextBoxColumn.Name = "DisponibleDataGridViewTextBoxColumn"
        '
        'COSTOSBindingSource
        '
        Me.COSTOSBindingSource.DataMember = "COSTOS"
        Me.COSTOSBindingSource.DataSource = Me.VISTAS
        '
        'VISTAS
        '
        Me.VISTAS.DataSetName = "VISTAS"
        Me.VISTAS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmsMenuDgv
        '
        Me.cmsMenuDgv.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsmEditar})
        Me.cmsMenuDgv.Name = "ContextMenuStrip1"
        Me.cmsMenuDgv.Size = New System.Drawing.Size(105, 26)
        '
        'TsmEditar
        '
        Me.TsmEditar.Name = "TsmEditar"
        Me.TsmEditar.Size = New System.Drawing.Size(104, 22)
        Me.TsmEditar.Text = "Editar"
        '
        'COSTOSTableAdapter
        '
        Me.COSTOSTableAdapter.ClearBeforeFill = True
        '
        'FrmCostos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 731)
        Me.Controls.Add(Me.DgvCostos)
        Me.Controls.Add(Me.tlpDatosDetalle)
        Me.KeyPreview = True
        Me.Name = "FrmCostos"
        Me.Text = "FrmCostos"
        Me.tlpDatosDetalle.ResumeLayout(False)
        Me.tlpDatosDetalle.PerformLayout()
        CType(Me.DgvCostos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COSTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VISTAS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsMenuDgv.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpDatosDetalle As TableLayoutPanel
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtCodigoProducto As TextBox
    Friend WithEvents TxtNombreProducto As TextBox
    Friend WithEvents BtnConsultarCostos As Button
    Friend WithEvents DgvCostos As DataGridView
    Friend WithEvents Disponible As DataGridViewTextBoxColumn
    Friend WithEvents BodegaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SucursalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostoPromedioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DisponibleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents COSTOSBindingSource As BindingSource
    Friend WithEvents VISTAS As VISTAS
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents cmsMenuDgv As ContextMenuStrip
    Friend WithEvents TsmEditar As ToolStripMenuItem
    Friend WithEvents COSTOSTableAdapter As VISTASTableAdapters.COSTOSTableAdapter
End Class
