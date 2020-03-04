<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdministracionTomasFisicas
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
        Me.tlpDatos = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CmbUsuario = New System.Windows.Forms.ComboBox()
        Me.USUARIOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VISTAS = New TomaFisica.VISTAS()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtObservaciones = New System.Windows.Forms.TextBox()
        Me.CmbSucursal = New System.Windows.Forms.ComboBox()
        Me.BODEGABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TxtFecha = New System.Windows.Forms.MaskedTextBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.TxtNumero = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgvTomasFisicas = New System.Windows.Forms.DataGridView()
        Me.NumeroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservacionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BodegaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaAnulacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DCortaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FISICOMAESTROBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.menucontextoDGV = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrabajandoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RevisandoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnuladaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerradaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FISICO_MAESTROTableAdapter = New TomaFisica.VISTASTableAdapters.FISICO_MAESTROTableAdapter()
        Me.BODEGATableAdapter = New TomaFisica.VISTASTableAdapters.BODEGATableAdapter()
        Me.USUARIOTableAdapter = New TomaFisica.VISTASTableAdapters.USUARIOTableAdapter()
        Me.tlpDatos.SuspendLayout()
        CType(Me.USUARIOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VISTAS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BODEGABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvTomasFisicas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FISICOMAESTROBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menucontextoDGV.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpDatos
        '
        Me.tlpDatos.ColumnCount = 3
        Me.tlpDatos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpDatos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpDatos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpDatos.Controls.Add(Me.Label5, 0, 0)
        Me.tlpDatos.Controls.Add(Me.CmbUsuario, 1, 4)
        Me.tlpDatos.Controls.Add(Me.Label4, 0, 4)
        Me.tlpDatos.Controls.Add(Me.TxtObservaciones, 1, 3)
        Me.tlpDatos.Controls.Add(Me.CmbSucursal, 1, 2)
        Me.tlpDatos.Controls.Add(Me.TxtFecha, 1, 1)
        Me.tlpDatos.Controls.Add(Me.BtnGuardar, 2, 4)
        Me.tlpDatos.Controls.Add(Me.TxtNumero, 1, 0)
        Me.tlpDatos.Controls.Add(Me.Label2, 0, 3)
        Me.tlpDatos.Controls.Add(Me.Label3, 0, 2)
        Me.tlpDatos.Controls.Add(Me.Label1, 0, 1)
        Me.tlpDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tlpDatos.Location = New System.Drawing.Point(12, 12)
        Me.tlpDatos.Name = "tlpDatos"
        Me.tlpDatos.RowCount = 5
        Me.tlpDatos.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpDatos.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpDatos.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpDatos.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpDatos.Size = New System.Drawing.Size(468, 171)
        Me.tlpDatos.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Número"
        '
        'CmbUsuario
        '
        Me.CmbUsuario.DataSource = Me.USUARIOBindingSource
        Me.CmbUsuario.DisplayMember = "Nombre"
        Me.CmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbUsuario.FormattingEnabled = True
        Me.CmbUsuario.Location = New System.Drawing.Point(87, 137)
        Me.CmbUsuario.Name = "CmbUsuario"
        Me.CmbUsuario.Size = New System.Drawing.Size(261, 21)
        Me.CmbUsuario.TabIndex = 7
        Me.CmbUsuario.ValueMember = "Nombre"
        '
        'USUARIOBindingSource
        '
        Me.USUARIOBindingSource.DataMember = "USUARIO"
        Me.USUARIOBindingSource.DataSource = Me.VISTAS
        '
        'VISTAS
        '
        Me.VISTAS.DataSetName = "VISTAS"
        Me.VISTAS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Usuario"
        '
        'TxtObservaciones
        '
        Me.TxtObservaciones.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TxtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TxtObservaciones.Location = New System.Drawing.Point(87, 88)
        Me.TxtObservaciones.Multiline = True
        Me.TxtObservaciones.Name = "TxtObservaciones"
        Me.TxtObservaciones.Size = New System.Drawing.Size(261, 43)
        Me.TxtObservaciones.TabIndex = 5
        '
        'CmbSucursal
        '
        Me.CmbSucursal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.CmbSucursal.DataSource = Me.BODEGABindingSource
        Me.CmbSucursal.DisplayMember = "Descripcion"
        Me.CmbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CmbSucursal.FormattingEnabled = True
        Me.CmbSucursal.Location = New System.Drawing.Point(87, 58)
        Me.CmbSucursal.Name = "CmbSucursal"
        Me.CmbSucursal.Size = New System.Drawing.Size(261, 24)
        Me.CmbSucursal.TabIndex = 3
        Me.CmbSucursal.ValueMember = "Codigo"
        '
        'BODEGABindingSource
        '
        Me.BODEGABindingSource.DataMember = "BODEGA"
        Me.BODEGABindingSource.DataSource = Me.VISTAS
        '
        'TxtFecha
        '
        Me.TxtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TxtFecha.Location = New System.Drawing.Point(87, 29)
        Me.TxtFecha.Mask = "00/00/0000"
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Size = New System.Drawing.Size(100, 23)
        Me.TxtFecha.TabIndex = 1
        Me.TxtFecha.ValidatingType = GetType(Date)
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BtnGuardar.Location = New System.Drawing.Point(354, 138)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(73, 28)
        Me.BtnGuardar.TabIndex = 8
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'TxtNumero
        '
        Me.TxtNumero.Location = New System.Drawing.Point(87, 3)
        Me.TxtNumero.Name = "TxtNumero"
        Me.TxtNumero.Size = New System.Drawing.Size(100, 20)
        Me.TxtNumero.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Observaciones"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Sucursal"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha"
        '
        'DgvTomasFisicas
        '
        Me.DgvTomasFisicas.AllowUserToAddRows = False
        Me.DgvTomasFisicas.AllowUserToDeleteRows = False
        Me.DgvTomasFisicas.AutoGenerateColumns = False
        Me.DgvTomasFisicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvTomasFisicas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.ObservacionesDataGridViewTextBoxColumn, Me.EstatusDataGridViewTextBoxColumn, Me.UsuarioDataGridViewTextBoxColumn, Me.BodegaDataGridViewTextBoxColumn, Me.FechaAnulacionDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.DCortaDataGridViewTextBoxColumn})
        Me.DgvTomasFisicas.DataSource = Me.FISICOMAESTROBindingSource
        Me.DgvTomasFisicas.Location = New System.Drawing.Point(12, 189)
        Me.DgvTomasFisicas.Name = "DgvTomasFisicas"
        Me.DgvTomasFisicas.ReadOnly = True
        Me.DgvTomasFisicas.Size = New System.Drawing.Size(648, 424)
        Me.DgvTomasFisicas.TabIndex = 2
        '
        'NumeroDataGridViewTextBoxColumn
        '
        Me.NumeroDataGridViewTextBoxColumn.DataPropertyName = "Numero"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = "0"
        Me.NumeroDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.NumeroDataGridViewTextBoxColumn.HeaderText = "Numero"
        Me.NumeroDataGridViewTextBoxColumn.Name = "NumeroDataGridViewTextBoxColumn"
        Me.NumeroDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroDataGridViewTextBoxColumn.Width = 65
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.FechaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Width = 75
        '
        'ObservacionesDataGridViewTextBoxColumn
        '
        Me.ObservacionesDataGridViewTextBoxColumn.DataPropertyName = "Observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.Name = "ObservacionesDataGridViewTextBoxColumn"
        Me.ObservacionesDataGridViewTextBoxColumn.ReadOnly = True
        Me.ObservacionesDataGridViewTextBoxColumn.Width = 175
        '
        'EstatusDataGridViewTextBoxColumn
        '
        Me.EstatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.HeaderText = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.Name = "EstatusDataGridViewTextBoxColumn"
        Me.EstatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstatusDataGridViewTextBoxColumn.Width = 65
        '
        'UsuarioDataGridViewTextBoxColumn
        '
        Me.UsuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.Name = "UsuarioDataGridViewTextBoxColumn"
        Me.UsuarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.UsuarioDataGridViewTextBoxColumn.Width = 65
        '
        'BodegaDataGridViewTextBoxColumn
        '
        Me.BodegaDataGridViewTextBoxColumn.DataPropertyName = "Bodega"
        Me.BodegaDataGridViewTextBoxColumn.HeaderText = "Bodega"
        Me.BodegaDataGridViewTextBoxColumn.Name = "BodegaDataGridViewTextBoxColumn"
        Me.BodegaDataGridViewTextBoxColumn.ReadOnly = True
        Me.BodegaDataGridViewTextBoxColumn.Width = 65
        '
        'FechaAnulacionDataGridViewTextBoxColumn
        '
        Me.FechaAnulacionDataGridViewTextBoxColumn.DataPropertyName = "FechaAnulacion"
        Me.FechaAnulacionDataGridViewTextBoxColumn.HeaderText = "Fecha Anulacion"
        Me.FechaAnulacionDataGridViewTextBoxColumn.Name = "FechaAnulacionDataGridViewTextBoxColumn"
        Me.FechaAnulacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaAnulacionDataGridViewTextBoxColumn.Width = 65
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Visible = False
        Me.DescripcionDataGridViewTextBoxColumn.Width = 200
        '
        'DCortaDataGridViewTextBoxColumn
        '
        Me.DCortaDataGridViewTextBoxColumn.DataPropertyName = "DCorta"
        Me.DCortaDataGridViewTextBoxColumn.HeaderText = "DCorta"
        Me.DCortaDataGridViewTextBoxColumn.Name = "DCortaDataGridViewTextBoxColumn"
        Me.DCortaDataGridViewTextBoxColumn.ReadOnly = True
        Me.DCortaDataGridViewTextBoxColumn.Visible = False
        '
        'FISICOMAESTROBindingSource
        '
        Me.FISICOMAESTROBindingSource.DataMember = "FISICO MAESTRO"
        Me.FISICOMAESTROBindingSource.DataSource = Me.VISTAS
        '
        'menucontextoDGV
        '
        Me.menucontextoDGV.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarToolStripMenuItem, Me.ImprimirToolStripMenuItem})
        Me.menucontextoDGV.Name = "ContextMenuStrip1"
        Me.menucontextoDGV.Size = New System.Drawing.Size(158, 48)
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TrabajandoToolStripMenuItem, Me.RevisandoToolStripMenuItem, Me.AnuladaToolStripMenuItem, Me.CerradaToolStripMenuItem})
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.EliminarToolStripMenuItem.Text = "Cambiar estado"
        '
        'TrabajandoToolStripMenuItem
        '
        Me.TrabajandoToolStripMenuItem.Name = "TrabajandoToolStripMenuItem"
        Me.TrabajandoToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.TrabajandoToolStripMenuItem.Text = "Trabajando"
        '
        'RevisandoToolStripMenuItem
        '
        Me.RevisandoToolStripMenuItem.Name = "RevisandoToolStripMenuItem"
        Me.RevisandoToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.RevisandoToolStripMenuItem.Text = "Revisando"
        '
        'AnuladaToolStripMenuItem
        '
        Me.AnuladaToolStripMenuItem.Name = "AnuladaToolStripMenuItem"
        Me.AnuladaToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.AnuladaToolStripMenuItem.Text = "Anulada"
        '
        'CerradaToolStripMenuItem
        '
        Me.CerradaToolStripMenuItem.Name = "CerradaToolStripMenuItem"
        Me.CerradaToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.CerradaToolStripMenuItem.Text = "Cerrada"
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'FISICO_MAESTROTableAdapter
        '
        Me.FISICO_MAESTROTableAdapter.ClearBeforeFill = True
        '
        'BODEGATableAdapter
        '
        Me.BODEGATableAdapter.ClearBeforeFill = True
        '
        'USUARIOTableAdapter
        '
        Me.USUARIOTableAdapter.ClearBeforeFill = True
        '
        'FrmAdministracionTomasFisicas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 649)
        Me.Controls.Add(Me.DgvTomasFisicas)
        Me.Controls.Add(Me.tlpDatos)
        Me.KeyPreview = True
        Me.Name = "FrmAdministracionTomasFisicas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de Tomas Físicas"
        Me.tlpDatos.ResumeLayout(False)
        Me.tlpDatos.PerformLayout()
        CType(Me.USUARIOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VISTAS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BODEGABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvTomasFisicas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FISICOMAESTROBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menucontextoDGV.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpDatos As TableLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents CmbUsuario As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtObservaciones As TextBox
    Friend WithEvents CmbSucursal As ComboBox
    Friend WithEvents TxtFecha As MaskedTextBox
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents TxtNumero As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DgvTomasFisicas As DataGridView
    Friend WithEvents menucontextoDGV As ContextMenuStrip
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TrabajandoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RevisandoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnuladaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerradaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BODEGABindingSource As BindingSource
    Friend WithEvents VISTAS As VISTAS
    Friend WithEvents FISICOMAESTROBindingSource As BindingSource
    Friend WithEvents FISICO_MAESTROTableAdapter As VISTASTableAdapters.FISICO_MAESTROTableAdapter
    Friend WithEvents BODEGATableAdapter As VISTASTableAdapters.BODEGATableAdapter
    Friend WithEvents USUARIOBindingSource As BindingSource
    Friend WithEvents USUARIOTableAdapter As VISTASTableAdapters.USUARIOTableAdapter
    Friend WithEvents NumeroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObservacionesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BodegaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaAnulacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DCortaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
