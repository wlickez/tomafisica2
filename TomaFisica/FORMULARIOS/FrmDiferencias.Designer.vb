<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDiferencias
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNumeroEntrada = New System.Windows.Forms.TextBox()
        Me.TxtNumeroSalida = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtFecha = New System.Windows.Forms.DateTimePicker()
        Me.BtnCargarDiferencias = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CONSULTARDIFERENCIASTOMAFISICABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VISTAS = New TomaFisica.VISTAS()
        Me.CONSULTAR_DIFERENCIAS_TOMA_FISICATableAdapter = New TomaFisica.VISTASTableAdapters.CONSULTAR_DIFERENCIAS_TOMA_FISICATableAdapter()
        Me.ProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpresaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionMedidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadMedidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaVencimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RevisadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SucursalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BodegaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IngresoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EgresoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONSULTARDIFERENCIASTOMAFISICABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VISTAS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 7
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtNumeroEntrada, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtNumeroSalida, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtFecha, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnCargarDiferencias, 6, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(592, 31)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(179, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "No. Salida"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Entrada"
        '
        'TxtNumeroEntrada
        '
        Me.TxtNumeroEntrada.Location = New System.Drawing.Point(73, 3)
        Me.TxtNumeroEntrada.Name = "TxtNumeroEntrada"
        Me.TxtNumeroEntrada.Size = New System.Drawing.Size(100, 20)
        Me.TxtNumeroEntrada.TabIndex = 2
        '
        'TxtNumeroSalida
        '
        Me.TxtNumeroSalida.Location = New System.Drawing.Point(241, 3)
        Me.TxtNumeroSalida.Name = "TxtNumeroSalida"
        Me.TxtNumeroSalida.Size = New System.Drawing.Size(100, 20)
        Me.TxtNumeroSalida.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(347, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Label3"
        '
        'TxtFecha
        '
        Me.TxtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TxtFecha.Location = New System.Drawing.Point(392, 3)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Size = New System.Drawing.Size(100, 20)
        Me.TxtFecha.TabIndex = 5
        '
        'BtnCargarDiferencias
        '
        Me.BtnCargarDiferencias.Location = New System.Drawing.Point(498, 3)
        Me.BtnCargarDiferencias.Name = "BtnCargarDiferencias"
        Me.BtnCargarDiferencias.Size = New System.Drawing.Size(75, 23)
        Me.BtnCargarDiferencias.TabIndex = 6
        Me.BtnCargarDiferencias.Text = "&Cargar"
        Me.BtnCargarDiferencias.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductoDataGridViewTextBoxColumn, Me.NumeroDataGridViewTextBoxColumn, Me.TipoDataGridViewTextBoxColumn, Me.EmpresaDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.CostoDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.MedidaDataGridViewTextBoxColumn, Me.DescripcionMedidaDataGridViewTextBoxColumn, Me.CantidadMedidaDataGridViewTextBoxColumn, Me.LoteDataGridViewTextBoxColumn, Me.FechaVencimientoDataGridViewTextBoxColumn, Me.RevisadoDataGridViewTextBoxColumn, Me.SucursalDataGridViewTextBoxColumn, Me.BodegaDataGridViewTextBoxColumn, Me.Producto1DataGridViewTextBoxColumn, Me.IngresoDataGridViewTextBoxColumn, Me.EgresoDataGridViewTextBoxColumn, Me.SaldoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CONSULTARDIFERENCIASTOMAFISICABindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 49)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1059, 486)
        Me.DataGridView1.TabIndex = 1
        '
        'CONSULTARDIFERENCIASTOMAFISICABindingSource
        '
        Me.CONSULTARDIFERENCIASTOMAFISICABindingSource.DataMember = "CONSULTAR DIFERENCIAS TOMA FISICA"
        Me.CONSULTARDIFERENCIASTOMAFISICABindingSource.DataSource = Me.VISTAS
        '
        'VISTAS
        '
        Me.VISTAS.DataSetName = "VISTAS"
        Me.VISTAS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CONSULTAR_DIFERENCIAS_TOMA_FISICATableAdapter
        '
        Me.CONSULTAR_DIFERENCIAS_TOMA_FISICATableAdapter.ClearBeforeFill = True
        '
        'ProductoDataGridViewTextBoxColumn
        '
        Me.ProductoDataGridViewTextBoxColumn.DataPropertyName = "Producto"
        Me.ProductoDataGridViewTextBoxColumn.HeaderText = "Producto"
        Me.ProductoDataGridViewTextBoxColumn.Name = "ProductoDataGridViewTextBoxColumn"
        Me.ProductoDataGridViewTextBoxColumn.Width = 60
        '
        'NumeroDataGridViewTextBoxColumn
        '
        Me.NumeroDataGridViewTextBoxColumn.DataPropertyName = "Numero"
        Me.NumeroDataGridViewTextBoxColumn.HeaderText = "No."
        Me.NumeroDataGridViewTextBoxColumn.Name = "NumeroDataGridViewTextBoxColumn"
        Me.NumeroDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroDataGridViewTextBoxColumn.Width = 50
        '
        'TipoDataGridViewTextBoxColumn
        '
        Me.TipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.MinimumWidth = 55
        Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
        Me.TipoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoDataGridViewTextBoxColumn.Width = 55
        '
        'EmpresaDataGridViewTextBoxColumn
        '
        Me.EmpresaDataGridViewTextBoxColumn.DataPropertyName = "Empresa"
        Me.EmpresaDataGridViewTextBoxColumn.HeaderText = "Empresa"
        Me.EmpresaDataGridViewTextBoxColumn.Name = "EmpresaDataGridViewTextBoxColumn"
        Me.EmpresaDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmpresaDataGridViewTextBoxColumn.Width = 60
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 150
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cant."
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
        Me.CantidadDataGridViewTextBoxColumn.Width = 60
        '
        'CostoDataGridViewTextBoxColumn
        '
        Me.CostoDataGridViewTextBoxColumn.DataPropertyName = "Costo"
        Me.CostoDataGridViewTextBoxColumn.HeaderText = "Costo"
        Me.CostoDataGridViewTextBoxColumn.Name = "CostoDataGridViewTextBoxColumn"
        Me.CostoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CostoDataGridViewTextBoxColumn.Width = 60
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioDataGridViewTextBoxColumn.Width = 60
        '
        'MedidaDataGridViewTextBoxColumn
        '
        Me.MedidaDataGridViewTextBoxColumn.DataPropertyName = "Medida"
        Me.MedidaDataGridViewTextBoxColumn.HeaderText = "Medida"
        Me.MedidaDataGridViewTextBoxColumn.Name = "MedidaDataGridViewTextBoxColumn"
        Me.MedidaDataGridViewTextBoxColumn.ReadOnly = True
        Me.MedidaDataGridViewTextBoxColumn.Width = 60
        '
        'DescripcionMedidaDataGridViewTextBoxColumn
        '
        Me.DescripcionMedidaDataGridViewTextBoxColumn.DataPropertyName = "Descripcion Medida"
        Me.DescripcionMedidaDataGridViewTextBoxColumn.HeaderText = "Descr Med"
        Me.DescripcionMedidaDataGridViewTextBoxColumn.Name = "DescripcionMedidaDataGridViewTextBoxColumn"
        Me.DescripcionMedidaDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionMedidaDataGridViewTextBoxColumn.Width = 60
        '
        'CantidadMedidaDataGridViewTextBoxColumn
        '
        Me.CantidadMedidaDataGridViewTextBoxColumn.DataPropertyName = "Cantidad Medida"
        Me.CantidadMedidaDataGridViewTextBoxColumn.HeaderText = "Cant. Med."
        Me.CantidadMedidaDataGridViewTextBoxColumn.Name = "CantidadMedidaDataGridViewTextBoxColumn"
        Me.CantidadMedidaDataGridViewTextBoxColumn.ReadOnly = True
        Me.CantidadMedidaDataGridViewTextBoxColumn.Width = 60
        '
        'LoteDataGridViewTextBoxColumn
        '
        Me.LoteDataGridViewTextBoxColumn.DataPropertyName = "Lote"
        Me.LoteDataGridViewTextBoxColumn.HeaderText = "Lote"
        Me.LoteDataGridViewTextBoxColumn.Name = "LoteDataGridViewTextBoxColumn"
        Me.LoteDataGridViewTextBoxColumn.ReadOnly = True
        Me.LoteDataGridViewTextBoxColumn.Width = 60
        '
        'FechaVencimientoDataGridViewTextBoxColumn
        '
        Me.FechaVencimientoDataGridViewTextBoxColumn.DataPropertyName = "Fecha Vencimiento"
        Me.FechaVencimientoDataGridViewTextBoxColumn.HeaderText = "F. Venc."
        Me.FechaVencimientoDataGridViewTextBoxColumn.Name = "FechaVencimientoDataGridViewTextBoxColumn"
        Me.FechaVencimientoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaVencimientoDataGridViewTextBoxColumn.Width = 60
        '
        'RevisadoDataGridViewTextBoxColumn
        '
        Me.RevisadoDataGridViewTextBoxColumn.DataPropertyName = "Revisado"
        Me.RevisadoDataGridViewTextBoxColumn.HeaderText = "Rev."
        Me.RevisadoDataGridViewTextBoxColumn.Name = "RevisadoDataGridViewTextBoxColumn"
        Me.RevisadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.RevisadoDataGridViewTextBoxColumn.Width = 50
        '
        'SucursalDataGridViewTextBoxColumn
        '
        Me.SucursalDataGridViewTextBoxColumn.DataPropertyName = "Sucursal"
        Me.SucursalDataGridViewTextBoxColumn.HeaderText = "Sucursal"
        Me.SucursalDataGridViewTextBoxColumn.Name = "SucursalDataGridViewTextBoxColumn"
        Me.SucursalDataGridViewTextBoxColumn.ReadOnly = True
        Me.SucursalDataGridViewTextBoxColumn.Width = 60
        '
        'BodegaDataGridViewTextBoxColumn
        '
        Me.BodegaDataGridViewTextBoxColumn.DataPropertyName = "Bodega"
        Me.BodegaDataGridViewTextBoxColumn.HeaderText = "Bodega"
        Me.BodegaDataGridViewTextBoxColumn.Name = "BodegaDataGridViewTextBoxColumn"
        Me.BodegaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Producto1DataGridViewTextBoxColumn
        '
        Me.Producto1DataGridViewTextBoxColumn.DataPropertyName = "Producto1"
        Me.Producto1DataGridViewTextBoxColumn.HeaderText = "Producto1"
        Me.Producto1DataGridViewTextBoxColumn.Name = "Producto1DataGridViewTextBoxColumn"
        Me.Producto1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'IngresoDataGridViewTextBoxColumn
        '
        Me.IngresoDataGridViewTextBoxColumn.DataPropertyName = "Ingreso"
        Me.IngresoDataGridViewTextBoxColumn.HeaderText = "Ingreso"
        Me.IngresoDataGridViewTextBoxColumn.Name = "IngresoDataGridViewTextBoxColumn"
        Me.IngresoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EgresoDataGridViewTextBoxColumn
        '
        Me.EgresoDataGridViewTextBoxColumn.DataPropertyName = "Egreso"
        Me.EgresoDataGridViewTextBoxColumn.HeaderText = "Egreso"
        Me.EgresoDataGridViewTextBoxColumn.Name = "EgresoDataGridViewTextBoxColumn"
        Me.EgresoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaldoDataGridViewTextBoxColumn
        '
        Me.SaldoDataGridViewTextBoxColumn.DataPropertyName = "Saldo"
        Me.SaldoDataGridViewTextBoxColumn.HeaderText = "Saldo"
        Me.SaldoDataGridViewTextBoxColumn.Name = "SaldoDataGridViewTextBoxColumn"
        Me.SaldoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FrmDiferencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1102, 557)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FrmDiferencias"
        Me.Text = "Diferencias"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONSULTARDIFERENCIASTOMAFISICABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VISTAS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNumeroEntrada As TextBox
    Friend WithEvents TxtNumeroSalida As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtFecha As DateTimePicker
    Friend WithEvents BtnCargarDiferencias As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents CONSULTARDIFERENCIASTOMAFISICABindingSource As BindingSource
    Friend WithEvents VISTAS As VISTAS
    Friend WithEvents CONSULTAR_DIFERENCIAS_TOMA_FISICATableAdapter As VISTASTableAdapters.CONSULTAR_DIFERENCIAS_TOMA_FISICATableAdapter
    Friend WithEvents ProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumeroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpresaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionMedidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadMedidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LoteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaVencimientoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RevisadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SucursalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BodegaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Producto1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IngresoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EgresoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
