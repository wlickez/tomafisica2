<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBusquedaProducto
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBusquedaProducto))
        Me.DgvDatosProducto = New System.Windows.Forms.DataGridView()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionGeneralDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CasaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DisponibleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AfectaExistenciaDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BarraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONSULTARPRODUCTOSEXISTENCIASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VISTAS = New TomaFisica.VISTAS()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBusquedaProducto = New System.Windows.Forms.TextBox()
        Me.CONSULTAR_PRODUCTOS_EXISTENCIASTableAdapter = New TomaFisica.VISTASTableAdapters.CONSULTAR_PRODUCTOS_EXISTENCIASTableAdapter()
        CType(Me.DgvDatosProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONSULTARPRODUCTOSEXISTENCIASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VISTAS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvDatosProducto
        '
        Me.DgvDatosProducto.AccessibleName = "dgvListadoProductosBuscados"
        Me.DgvDatosProducto.AllowUserToAddRows = False
        Me.DgvDatosProducto.AllowUserToDeleteRows = False
        Me.DgvDatosProducto.AutoGenerateColumns = False
        Me.DgvDatosProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDatosProducto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoDataGridViewTextBoxColumn, Me.DescripcionGeneralDataGridViewTextBoxColumn, Me.CasaDataGridViewTextBoxColumn, Me.DisponibleDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.AfectaExistenciaDataGridViewCheckBoxColumn, Me.BarraDataGridViewTextBoxColumn})
        Me.DgvDatosProducto.DataSource = Me.CONSULTARPRODUCTOSEXISTENCIASBindingSource
        Me.DgvDatosProducto.Location = New System.Drawing.Point(12, 77)
        Me.DgvDatosProducto.Name = "DgvDatosProducto"
        Me.DgvDatosProducto.ReadOnly = True
        Me.DgvDatosProducto.Size = New System.Drawing.Size(689, 308)
        Me.DgvDatosProducto.TabIndex = 5
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        Me.CodigoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoDataGridViewTextBoxColumn.Width = 75
        '
        'DescripcionGeneralDataGridViewTextBoxColumn
        '
        Me.DescripcionGeneralDataGridViewTextBoxColumn.DataPropertyName = "Descripcion General"
        Me.DescripcionGeneralDataGridViewTextBoxColumn.HeaderText = "Descripcion General"
        Me.DescripcionGeneralDataGridViewTextBoxColumn.Name = "DescripcionGeneralDataGridViewTextBoxColumn"
        Me.DescripcionGeneralDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionGeneralDataGridViewTextBoxColumn.Width = 200
        '
        'CasaDataGridViewTextBoxColumn
        '
        Me.CasaDataGridViewTextBoxColumn.DataPropertyName = "Casa"
        Me.CasaDataGridViewTextBoxColumn.HeaderText = "Casa"
        Me.CasaDataGridViewTextBoxColumn.Name = "CasaDataGridViewTextBoxColumn"
        Me.CasaDataGridViewTextBoxColumn.ReadOnly = True
        Me.CasaDataGridViewTextBoxColumn.Width = 200
        '
        'DisponibleDataGridViewTextBoxColumn
        '
        Me.DisponibleDataGridViewTextBoxColumn.DataPropertyName = "Disponible"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = "0"
        Me.DisponibleDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.DisponibleDataGridViewTextBoxColumn.HeaderText = "Disponible"
        Me.DisponibleDataGridViewTextBoxColumn.Name = "DisponibleDataGridViewTextBoxColumn"
        Me.DisponibleDataGridViewTextBoxColumn.ReadOnly = True
        Me.DisponibleDataGridViewTextBoxColumn.Width = 65
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "Precio"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0.00"
        Me.PrecioDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioDataGridViewTextBoxColumn.Width = 65
        '
        'AfectaExistenciaDataGridViewCheckBoxColumn
        '
        Me.AfectaExistenciaDataGridViewCheckBoxColumn.DataPropertyName = "Afecta Existencia"
        Me.AfectaExistenciaDataGridViewCheckBoxColumn.HeaderText = "Afecta Existencia"
        Me.AfectaExistenciaDataGridViewCheckBoxColumn.Name = "AfectaExistenciaDataGridViewCheckBoxColumn"
        Me.AfectaExistenciaDataGridViewCheckBoxColumn.ReadOnly = True
        Me.AfectaExistenciaDataGridViewCheckBoxColumn.Visible = False
        '
        'BarraDataGridViewTextBoxColumn
        '
        Me.BarraDataGridViewTextBoxColumn.DataPropertyName = "Barra"
        Me.BarraDataGridViewTextBoxColumn.HeaderText = "Barra"
        Me.BarraDataGridViewTextBoxColumn.Name = "BarraDataGridViewTextBoxColumn"
        Me.BarraDataGridViewTextBoxColumn.ReadOnly = True
        Me.BarraDataGridViewTextBoxColumn.Visible = False
        '
        'CONSULTARPRODUCTOSEXISTENCIASBindingSource
        '
        Me.CONSULTARPRODUCTOSEXISTENCIASBindingSource.DataMember = "CONSULTAR PRODUCTOS EXISTENCIAS"
        Me.CONSULTARPRODUCTOSEXISTENCIASBindingSource.DataSource = Me.VISTAS
        '
        'VISTAS
        '
        Me.VISTAS.DataSetName = "VISTAS"
        Me.VISTAS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.41467!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.19918!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.38614!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.BtnConsultar, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtBusquedaProducto, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 25)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(675, 46)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'BtnConsultar
        '
        Me.BtnConsultar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BtnConsultar.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultar.Image = CType(resources.GetObject("BtnConsultar.Image"), System.Drawing.Image)
        Me.BtnConsultar.Location = New System.Drawing.Point(445, 7)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(45, 32)
        Me.BtnConsultar.TabIndex = 5
        Me.BtnConsultar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Buscar por"
        '
        'TxtBusquedaProducto
        '
        Me.TxtBusquedaProducto.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBusquedaProducto.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBusquedaProducto.Location = New System.Drawing.Point(154, 7)
        Me.TxtBusquedaProducto.Name = "TxtBusquedaProducto"
        Me.TxtBusquedaProducto.Size = New System.Drawing.Size(285, 32)
        Me.TxtBusquedaProducto.TabIndex = 0
        '
        'CONSULTAR_PRODUCTOS_EXISTENCIASTableAdapter
        '
        Me.CONSULTAR_PRODUCTOS_EXISTENCIASTableAdapter.ClearBeforeFill = True
        '
        'FrmBusquedaProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DgvDatosProducto)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.KeyPreview = True
        Me.Name = "FrmBusquedaProducto"
        Me.Text = "Búsqueda de Producto"
        CType(Me.DgvDatosProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONSULTARPRODUCTOSEXISTENCIASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VISTAS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvDatosProducto As DataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BtnConsultar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBusquedaProducto As TextBox
    Friend WithEvents CONSULTARPRODUCTOSEXISTENCIASBindingSource As BindingSource
    Friend WithEvents VISTAS As VISTAS
    Friend WithEvents CONSULTAR_PRODUCTOS_EXISTENCIASTableAdapter As VISTASTableAdapters.CONSULTAR_PRODUCTOS_EXISTENCIASTableAdapter
    Friend WithEvents CodigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionGeneralDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CasaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DisponibleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AfectaExistenciaDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents BarraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
