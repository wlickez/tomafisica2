<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrincipal
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TxtBuscarPosicion = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DgvTomaFisica = New System.Windows.Forms.DataGridView()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservacionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaAnulacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BodegaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DBodegaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PosicionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONSULTARTOMAFISICABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VISTAS = New TomaFisica.VISTAS()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.TxtCodigoProducto = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnReporte = New System.Windows.Forms.Button()
        Me.CmbBodegas = New System.Windows.Forms.ComboBox()
        Me.BODEGABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNombreAlmacen = New System.Windows.Forms.TextBox()
        Me.TxtCodigoAlmacen = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNumeroToma = New System.Windows.Forms.TextBox()
        Me.CmbTomas = New System.Windows.Forms.ComboBox()
        Me.FISICOMAESTROBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TxtObservacionesTomaFisica = New System.Windows.Forms.TextBox()
        Me.BtnBuscarPosicion = New System.Windows.Forms.Button()
        Me.TxtFechaTomaFisicaReferencia = New System.Windows.Forms.MaskedTextBox()
        Me.FECHASFISICOMAESTROBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.MenuStripPrincipal = New System.Windows.Forms.MenuStrip()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiferenciasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TodasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeleccionadasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TlpDatosDetalle = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNombreProducto = New System.Windows.Forms.TextBox()
        Me.Físico = New System.Windows.Forms.Label()
        Me.TxtFisico = New System.Windows.Forms.TextBox()
        Me.TxtTop = New System.Windows.Forms.NumericUpDown()
        Me.BtnAgregarDetalle = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.menucontextoDGV = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FISICO_MAESTROTableAdapter = New TomaFisica.VISTASTableAdapters.FISICO_MAESTROTableAdapter()
        Me.CONSULTAR_TOMA_FISICATableAdapter = New TomaFisica.VISTASTableAdapters.CONSULTAR_TOMA_FISICATableAdapter()
        Me.BODEGATableAdapter = New TomaFisica.VISTASTableAdapters.BODEGATableAdapter()
        Me.FECHAS_FISICO_MAESTROTableAdapter = New TomaFisica.VISTASTableAdapters.FECHAS_FISICO_MAESTROTableAdapter()
        CType(Me.DgvTomaFisica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONSULTARTOMAFISICABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VISTAS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.BODEGABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FISICOMAESTROBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FECHASFISICOMAESTROBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStripPrincipal.SuspendLayout()
        Me.TlpDatosDetalle.SuspendLayout()
        CType(Me.TxtTop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menucontextoDGV.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtBuscarPosicion
        '
        Me.TxtBuscarPosicion.Location = New System.Drawing.Point(623, 37)
        Me.TxtBuscarPosicion.Name = "TxtBuscarPosicion"
        Me.TxtBuscarPosicion.Size = New System.Drawing.Size(26, 20)
        Me.TxtBuscarPosicion.TabIndex = 18
        Me.TxtBuscarPosicion.Visible = False
        '
        'DgvTomaFisica
        '
        Me.DgvTomaFisica.AllowUserToAddRows = False
        Me.DgvTomaFisica.AllowUserToDeleteRows = False
        Me.DgvTomaFisica.AllowUserToResizeColumns = False
        Me.DgvTomaFisica.AllowUserToResizeRows = False
        Me.DgvTomaFisica.AutoGenerateColumns = False
        Me.DgvTomaFisica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvTomaFisica.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechaDataGridViewTextBoxColumn, Me.ObservacionesDataGridViewTextBoxColumn, Me.EstatusDataGridViewTextBoxColumn, Me.UsuarioDataGridViewTextBoxColumn, Me.FechaAnulacionDataGridViewTextBoxColumn, Me.BodegaDataGridViewTextBoxColumn, Me.DBodegaDataGridViewTextBoxColumn, Me.NumeroDataGridViewTextBoxColumn, Me.ProductoDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.PosicionDataGridViewTextBoxColumn})
        Me.DgvTomaFisica.DataSource = Me.CONSULTARTOMAFISICABindingSource
        Me.DgvTomaFisica.Location = New System.Drawing.Point(12, 168)
        Me.DgvTomaFisica.Name = "DgvTomaFisica"
        Me.DgvTomaFisica.ReadOnly = True
        Me.DgvTomaFisica.Size = New System.Drawing.Size(713, 445)
        Me.DgvTomaFisica.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.DgvTomaFisica, "Detalle de la toma física por sección")
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Visible = False
        '
        'ObservacionesDataGridViewTextBoxColumn
        '
        Me.ObservacionesDataGridViewTextBoxColumn.DataPropertyName = "Observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.Name = "ObservacionesDataGridViewTextBoxColumn"
        Me.ObservacionesDataGridViewTextBoxColumn.ReadOnly = True
        Me.ObservacionesDataGridViewTextBoxColumn.Visible = False
        '
        'EstatusDataGridViewTextBoxColumn
        '
        Me.EstatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.HeaderText = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.Name = "EstatusDataGridViewTextBoxColumn"
        Me.EstatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstatusDataGridViewTextBoxColumn.Visible = False
        '
        'UsuarioDataGridViewTextBoxColumn
        '
        Me.UsuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.Name = "UsuarioDataGridViewTextBoxColumn"
        Me.UsuarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.UsuarioDataGridViewTextBoxColumn.Visible = False
        '
        'FechaAnulacionDataGridViewTextBoxColumn
        '
        Me.FechaAnulacionDataGridViewTextBoxColumn.DataPropertyName = "FechaAnulacion"
        Me.FechaAnulacionDataGridViewTextBoxColumn.HeaderText = "FechaAnulacion"
        Me.FechaAnulacionDataGridViewTextBoxColumn.Name = "FechaAnulacionDataGridViewTextBoxColumn"
        Me.FechaAnulacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaAnulacionDataGridViewTextBoxColumn.Visible = False
        '
        'BodegaDataGridViewTextBoxColumn
        '
        Me.BodegaDataGridViewTextBoxColumn.DataPropertyName = "Bodega"
        Me.BodegaDataGridViewTextBoxColumn.HeaderText = "Bodega"
        Me.BodegaDataGridViewTextBoxColumn.Name = "BodegaDataGridViewTextBoxColumn"
        Me.BodegaDataGridViewTextBoxColumn.ReadOnly = True
        Me.BodegaDataGridViewTextBoxColumn.Visible = False
        '
        'DBodegaDataGridViewTextBoxColumn
        '
        Me.DBodegaDataGridViewTextBoxColumn.DataPropertyName = "DBodega"
        Me.DBodegaDataGridViewTextBoxColumn.HeaderText = "DBodega"
        Me.DBodegaDataGridViewTextBoxColumn.Name = "DBodegaDataGridViewTextBoxColumn"
        Me.DBodegaDataGridViewTextBoxColumn.ReadOnly = True
        Me.DBodegaDataGridViewTextBoxColumn.Visible = False
        '
        'NumeroDataGridViewTextBoxColumn
        '
        Me.NumeroDataGridViewTextBoxColumn.DataPropertyName = "Numero"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.NumeroDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.NumeroDataGridViewTextBoxColumn.HeaderText = "Numero"
        Me.NumeroDataGridViewTextBoxColumn.Name = "NumeroDataGridViewTextBoxColumn"
        Me.NumeroDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroDataGridViewTextBoxColumn.Width = 50
        '
        'ProductoDataGridViewTextBoxColumn
        '
        Me.ProductoDataGridViewTextBoxColumn.DataPropertyName = "Producto"
        Me.ProductoDataGridViewTextBoxColumn.HeaderText = "Producto"
        Me.ProductoDataGridViewTextBoxColumn.Name = "ProductoDataGridViewTextBoxColumn"
        Me.ProductoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductoDataGridViewTextBoxColumn.Width = 65
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 320
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.CantidadDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
        Me.CantidadDataGridViewTextBoxColumn.Width = 65
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "Precio"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0.00"
        Me.PrecioDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioDataGridViewTextBoxColumn.Width = 75
        '
        'PosicionDataGridViewTextBoxColumn
        '
        Me.PosicionDataGridViewTextBoxColumn.DataPropertyName = "Posicion"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.PosicionDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.PosicionDataGridViewTextBoxColumn.HeaderText = "Posicion"
        Me.PosicionDataGridViewTextBoxColumn.Name = "PosicionDataGridViewTextBoxColumn"
        Me.PosicionDataGridViewTextBoxColumn.ReadOnly = True
        Me.PosicionDataGridViewTextBoxColumn.Width = 75
        '
        'CONSULTARTOMAFISICABindingSource
        '
        Me.CONSULTARTOMAFISICABindingSource.DataMember = "CONSULTAR TOMA FISICA"
        Me.CONSULTARTOMAFISICABindingSource.DataSource = Me.VISTAS
        '
        'VISTAS
        '
        Me.VISTAS.DataSetName = "VISTAS"
        Me.VISTAS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnAgregar
        '
        Me.TlpDatosDetalle.SetColumnSpan(Me.BtnAgregar, 2)
        Me.BtnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.Location = New System.Drawing.Point(544, 3)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(96, 28)
        Me.BtnAgregar.TabIndex = 3
        Me.BtnAgregar.Text = "Buscar (F3)"
        Me.ToolTip1.SetToolTip(Me.BtnAgregar, "Puede presionar también F3")
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'TxtCodigoProducto
        '
        Me.TxtCodigoProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigoProducto.Location = New System.Drawing.Point(59, 3)
        Me.TxtCodigoProducto.Name = "TxtCodigoProducto"
        Me.TxtCodigoProducto.Size = New System.Drawing.Size(104, 23)
        Me.TxtCodigoProducto.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.TxtCodigoProducto, "Presione Enter para confirmar búsqueda")
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
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnReporte, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CmbBodegas, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtNombreAlmacen, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtCodigoAlmacen, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtNumeroToma, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.CmbTomas, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtObservacionesTomaFisica, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtBuscarPosicion, 5, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnBuscarPosicion, 6, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtFechaTomaFisicaReferencia, 4, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 28)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(713, 64)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label5, 2)
        Me.Label5.Location = New System.Drawing.Point(623, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Posición"
        '
        'BtnReporte
        '
        Me.BtnReporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BtnReporte.Location = New System.Drawing.Point(544, 3)
        Me.BtnReporte.Name = "BtnReporte"
        Me.BtnReporte.Size = New System.Drawing.Size(73, 28)
        Me.BtnReporte.TabIndex = 4
        Me.BtnReporte.Text = "Reporte"
        Me.BtnReporte.UseVisualStyleBackColor = True
        '
        'CmbBodegas
        '
        Me.CmbBodegas.DataSource = Me.BODEGABindingSource
        Me.CmbBodegas.DisplayMember = "Descripcion"
        Me.CmbBodegas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBodegas.Enabled = False
        Me.CmbBodegas.FormattingEnabled = True
        Me.CmbBodegas.Location = New System.Drawing.Point(110, 3)
        Me.CmbBodegas.Name = "CmbBodegas"
        Me.CmbBodegas.Size = New System.Drawing.Size(322, 21)
        Me.CmbBodegas.TabIndex = 2
        Me.CmbBodegas.ValueMember = "Codigo"
        '
        'BODEGABindingSource
        '
        Me.BODEGABindingSource.DataMember = "BODEGA"
        Me.BODEGABindingSource.DataSource = Me.VISTAS
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Sucursal"
        '
        'TxtNombreAlmacen
        '
        Me.TxtNombreAlmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreAlmacen.Location = New System.Drawing.Point(438, 3)
        Me.TxtNombreAlmacen.Name = "TxtNombreAlmacen"
        Me.TxtNombreAlmacen.ReadOnly = True
        Me.TxtNombreAlmacen.Size = New System.Drawing.Size(100, 23)
        Me.TxtNombreAlmacen.TabIndex = 3
        Me.TxtNombreAlmacen.Visible = False
        '
        'TxtCodigoAlmacen
        '
        Me.TxtCodigoAlmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigoAlmacen.Location = New System.Drawing.Point(63, 3)
        Me.TxtCodigoAlmacen.Name = "TxtCodigoAlmacen"
        Me.TxtCodigoAlmacen.ReadOnly = True
        Me.TxtCodigoAlmacen.Size = New System.Drawing.Size(41, 23)
        Me.TxtCodigoAlmacen.TabIndex = 1
        Me.TxtCodigoAlmacen.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "No. Toma"
        '
        'TxtNumeroToma
        '
        Me.TxtNumeroToma.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumeroToma.Location = New System.Drawing.Point(63, 37)
        Me.TxtNumeroToma.Name = "TxtNumeroToma"
        Me.TxtNumeroToma.ReadOnly = True
        Me.TxtNumeroToma.Size = New System.Drawing.Size(41, 23)
        Me.TxtNumeroToma.TabIndex = 6
        Me.TxtNumeroToma.Visible = False
        '
        'CmbTomas
        '
        Me.CmbTomas.DataSource = Me.FISICOMAESTROBindingSource
        Me.CmbTomas.DisplayMember = "Observaciones"
        Me.CmbTomas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTomas.FormattingEnabled = True
        Me.CmbTomas.Location = New System.Drawing.Point(110, 37)
        Me.CmbTomas.Name = "CmbTomas"
        Me.CmbTomas.Size = New System.Drawing.Size(322, 21)
        Me.CmbTomas.TabIndex = 7
        Me.CmbTomas.ValueMember = "Numero"
        '
        'FISICOMAESTROBindingSource
        '
        Me.FISICOMAESTROBindingSource.DataMember = "FISICO MAESTRO"
        Me.FISICOMAESTROBindingSource.DataSource = Me.VISTAS
        '
        'TxtObservacionesTomaFisica
        '
        Me.TxtObservacionesTomaFisica.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtObservacionesTomaFisica.Location = New System.Drawing.Point(438, 37)
        Me.TxtObservacionesTomaFisica.Name = "TxtObservacionesTomaFisica"
        Me.TxtObservacionesTomaFisica.ReadOnly = True
        Me.TxtObservacionesTomaFisica.Size = New System.Drawing.Size(100, 23)
        Me.TxtObservacionesTomaFisica.TabIndex = 7
        Me.TxtObservacionesTomaFisica.Visible = False
        '
        'BtnBuscarPosicion
        '
        Me.BtnBuscarPosicion.Location = New System.Drawing.Point(655, 37)
        Me.BtnBuscarPosicion.Name = "BtnBuscarPosicion"
        Me.BtnBuscarPosicion.Size = New System.Drawing.Size(34, 23)
        Me.BtnBuscarPosicion.TabIndex = 20
        Me.BtnBuscarPosicion.Text = "Ir"
        Me.BtnBuscarPosicion.UseVisualStyleBackColor = True
        Me.BtnBuscarPosicion.Visible = False
        '
        'TxtFechaTomaFisicaReferencia
        '
        Me.TxtFechaTomaFisicaReferencia.Location = New System.Drawing.Point(544, 37)
        Me.TxtFechaTomaFisicaReferencia.Mask = "00/00/0000"
        Me.TxtFechaTomaFisicaReferencia.Name = "TxtFechaTomaFisicaReferencia"
        Me.TxtFechaTomaFisicaReferencia.ReadOnly = True
        Me.TxtFechaTomaFisicaReferencia.Size = New System.Drawing.Size(73, 20)
        Me.TxtFechaTomaFisicaReferencia.TabIndex = 21
        Me.TxtFechaTomaFisicaReferencia.ValidatingType = GetType(Date)
        '
        'FECHASFISICOMAESTROBindingSource
        '
        Me.FECHASFISICOMAESTROBindingSource.DataMember = "FECHAS FISICO MAESTRO"
        Me.FECHASFISICOMAESTROBindingSource.DataSource = Me.VISTAS
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button1.Location = New System.Drawing.Point(3, -83)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 28)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Reporte"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(3, -49)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(123, 23)
        Me.TextBox1.TabIndex = 21
        '
        'ComboBox1
        '
        Me.ComboBox1.DisplayMember = "Codigo"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(63, -83)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(322, 21)
        Me.ComboBox1.TabIndex = 12
        Me.ComboBox1.ValueMember = "Codigo"
        '
        'ComboBox2
        '
        Me.ComboBox2.DisplayMember = "Numero"
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(63, -49)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(322, 21)
        Me.ComboBox2.TabIndex = 19
        Me.ComboBox2.ValueMember = "Numero"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(391, -83)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(123, 23)
        Me.TextBox2.TabIndex = 14
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(63, -49)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(41, 23)
        Me.TextBox3.TabIndex = 10
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(63, -83)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(41, 23)
        Me.TextBox4.TabIndex = 17
        '
        'MenuStripPrincipal
        '
        Me.MenuStripPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.SalirToolStripMenuItem, Me.AdministrarToolStripMenuItem, Me.DiferenciasToolStripMenuItem1, Me.ImprimirToolStripMenuItem1})
        Me.MenuStripPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripPrincipal.Name = "MenuStripPrincipal"
        Me.MenuStripPrincipal.Size = New System.Drawing.Size(762, 24)
        Me.MenuStripPrincipal.TabIndex = 16
        Me.MenuStripPrincipal.Text = "MenuStrip1"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.LoginToolStripMenuItem.Tag = "0"
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Tag = "0"
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'AdministrarToolStripMenuItem
        '
        Me.AdministrarToolStripMenuItem.Name = "AdministrarToolStripMenuItem"
        Me.AdministrarToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.AdministrarToolStripMenuItem.Tag = "1"
        Me.AdministrarToolStripMenuItem.Text = "Administrar"
        Me.AdministrarToolStripMenuItem.Visible = False
        '
        'DiferenciasToolStripMenuItem1
        '
        Me.DiferenciasToolStripMenuItem1.Name = "DiferenciasToolStripMenuItem1"
        Me.DiferenciasToolStripMenuItem1.Size = New System.Drawing.Size(77, 20)
        Me.DiferenciasToolStripMenuItem1.Tag = "1"
        Me.DiferenciasToolStripMenuItem1.Text = "Diferencias"
        Me.DiferenciasToolStripMenuItem1.Visible = False
        '
        'ImprimirToolStripMenuItem1
        '
        Me.ImprimirToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TodasToolStripMenuItem, Me.SeleccionadasToolStripMenuItem})
        Me.ImprimirToolStripMenuItem1.Name = "ImprimirToolStripMenuItem1"
        Me.ImprimirToolStripMenuItem1.Size = New System.Drawing.Size(65, 20)
        Me.ImprimirToolStripMenuItem1.Tag = "1"
        Me.ImprimirToolStripMenuItem1.Text = "Imprimir"
        Me.ImprimirToolStripMenuItem1.Visible = False
        '
        'TodasToolStripMenuItem
        '
        Me.TodasToolStripMenuItem.Name = "TodasToolStripMenuItem"
        Me.TodasToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.TodasToolStripMenuItem.Text = "Todas"
        '
        'SeleccionadasToolStripMenuItem
        '
        Me.SeleccionadasToolStripMenuItem.Name = "SeleccionadasToolStripMenuItem"
        Me.SeleccionadasToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.SeleccionadasToolStripMenuItem.Text = "Seleccionadas"
        '
        'TlpDatosDetalle
        '
        Me.TlpDatosDetalle.ColumnCount = 6
        Me.TlpDatosDetalle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TlpDatosDetalle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TlpDatosDetalle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TlpDatosDetalle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TlpDatosDetalle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TlpDatosDetalle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79.0!))
        Me.TlpDatosDetalle.Controls.Add(Me.Label3, 0, 0)
        Me.TlpDatosDetalle.Controls.Add(Me.TxtCodigoProducto, 1, 0)
        Me.TlpDatosDetalle.Controls.Add(Me.TxtNombreProducto, 2, 0)
        Me.TlpDatosDetalle.Controls.Add(Me.Físico, 0, 1)
        Me.TlpDatosDetalle.Controls.Add(Me.TxtFisico, 1, 1)
        Me.TlpDatosDetalle.Controls.Add(Me.BtnAgregar, 3, 0)
        Me.TlpDatosDetalle.Controls.Add(Me.TxtTop, 5, 1)
        Me.TlpDatosDetalle.Controls.Add(Me.BtnAgregarDetalle, 3, 1)
        Me.TlpDatosDetalle.Controls.Add(Me.Label4, 5, 0)
        Me.TlpDatosDetalle.Location = New System.Drawing.Point(12, 98)
        Me.TlpDatosDetalle.Name = "TlpDatosDetalle"
        Me.TlpDatosDetalle.RowCount = 2
        Me.TlpDatosDetalle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TlpDatosDetalle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TlpDatosDetalle.Size = New System.Drawing.Size(713, 67)
        Me.TlpDatosDetalle.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Producto"
        '
        'TxtNombreProducto
        '
        Me.TxtNombreProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreProducto.Location = New System.Drawing.Point(169, 3)
        Me.TxtNombreProducto.Name = "TxtNombreProducto"
        Me.TxtNombreProducto.ReadOnly = True
        Me.TxtNombreProducto.Size = New System.Drawing.Size(369, 23)
        Me.TxtNombreProducto.TabIndex = 2
        '
        'Físico
        '
        Me.Físico.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Físico.AutoSize = True
        Me.Físico.Location = New System.Drawing.Point(3, 44)
        Me.Físico.Name = "Físico"
        Me.Físico.Size = New System.Drawing.Size(36, 13)
        Me.Físico.TabIndex = 4
        Me.Físico.Text = "Físico"
        '
        'TxtFisico
        '
        Me.TxtFisico.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFisico.Location = New System.Drawing.Point(59, 37)
        Me.TxtFisico.MaxLength = 5
        Me.TxtFisico.Name = "TxtFisico"
        Me.TxtFisico.Size = New System.Drawing.Size(104, 23)
        Me.TxtFisico.TabIndex = 5
        '
        'TxtTop
        '
        Me.TxtTop.Location = New System.Drawing.Point(646, 37)
        Me.TxtTop.Maximum = New Decimal(New Integer() {700, 0, 0, 0})
        Me.TxtTop.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.TxtTop.Name = "TxtTop"
        Me.TxtTop.Size = New System.Drawing.Size(56, 20)
        Me.TxtTop.TabIndex = 7
        Me.TxtTop.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'BtnAgregarDetalle
        '
        Me.TlpDatosDetalle.SetColumnSpan(Me.BtnAgregarDetalle, 2)
        Me.BtnAgregarDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarDetalle.Location = New System.Drawing.Point(544, 37)
        Me.BtnAgregarDetalle.Name = "BtnAgregarDetalle"
        Me.BtnAgregarDetalle.Size = New System.Drawing.Size(96, 28)
        Me.BtnAgregarDetalle.TabIndex = 6
        Me.BtnAgregarDetalle.Text = "Agregar"
        Me.BtnAgregarDetalle.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(646, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Top"
        '
        'menucontextoDGV
        '
        Me.menucontextoDGV.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.menucontextoDGV.Name = "ContextMenuStrip1"
        Me.menucontextoDGV.Size = New System.Drawing.Size(118, 48)
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'FISICO_MAESTROTableAdapter
        '
        Me.FISICO_MAESTROTableAdapter.ClearBeforeFill = True
        '
        'CONSULTAR_TOMA_FISICATableAdapter
        '
        Me.CONSULTAR_TOMA_FISICATableAdapter.ClearBeforeFill = True
        '
        'BODEGATableAdapter
        '
        Me.BODEGATableAdapter.ClearBeforeFill = True
        '
        'FECHAS_FISICO_MAESTROTableAdapter
        '
        Me.FECHAS_FISICO_MAESTROTableAdapter.ClearBeforeFill = True
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 645)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.MenuStripPrincipal)
        Me.Controls.Add(Me.DgvTomaFisica)
        Me.Controls.Add(Me.TlpDatosDetalle)
        Me.KeyPreview = True
        Me.Name = "FrmPrincipal"
        Me.Text = "Toma Física"
        CType(Me.DgvTomaFisica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONSULTARTOMAFISICABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VISTAS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.BODEGABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FISICOMAESTROBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FECHASFISICOMAESTROBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStripPrincipal.ResumeLayout(False)
        Me.MenuStripPrincipal.PerformLayout()
        Me.TlpDatosDetalle.ResumeLayout(False)
        Me.TlpDatosDetalle.PerformLayout()
        CType(Me.TxtTop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menucontextoDGV.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtBuscarPosicion As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents DgvTomaFisica As DataGridView
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents TxtCodigoProducto As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BtnReporte As Button
    Friend WithEvents TxtObservacionesTomaFisica As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CmbBodegas As ComboBox
    Friend WithEvents CmbTomas As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNombreAlmacen As TextBox
    Friend WithEvents TxtNumeroToma As TextBox
    Friend WithEvents TxtCodigoAlmacen As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents MenuStripPrincipal As MenuStrip
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DiferenciasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TodasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeleccionadasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnBuscarPosicion As Button
    Friend WithEvents TlpDatosDetalle As TableLayoutPanel
    Friend WithEvents BtnAgregarDetalle As Button
    Friend WithEvents TxtTop As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNombreProducto As TextBox
    Friend WithEvents Físico As Label
    Friend WithEvents TxtFisico As TextBox
    Friend WithEvents menucontextoDGV As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VISTAS As VISTAS
    Friend WithEvents FISICOMAESTROBindingSource As BindingSource
    Friend WithEvents FISICO_MAESTROTableAdapter As VISTASTableAdapters.FISICO_MAESTROTableAdapter
    Friend WithEvents CONSULTARTOMAFISICABindingSource As BindingSource
    Friend WithEvents CONSULTAR_TOMA_FISICATableAdapter As VISTASTableAdapters.CONSULTAR_TOMA_FISICATableAdapter
    Friend WithEvents BODEGABindingSource As BindingSource
    Friend WithEvents BODEGATableAdapter As VISTASTableAdapters.BODEGATableAdapter
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObservacionesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaAnulacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BodegaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DBodegaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumeroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PosicionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FECHASFISICOMAESTROBindingSource As BindingSource
    Friend WithEvents FECHAS_FISICO_MAESTROTableAdapter As VISTASTableAdapters.FECHAS_FISICO_MAESTROTableAdapter
    Friend WithEvents TxtFechaTomaFisicaReferencia As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
