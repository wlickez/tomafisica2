<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.TxtClave = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtFechaTomaFisica = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CmbSucursales = New System.Windows.Forms.ComboBox()
        Me.FISICOPORUSUARIOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VISTAS = New TomaFisica.VISTAS()
        Me.BODEGAPORSUCURSALBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FISICO_POR_USUARIOTableAdapter = New TomaFisica.VISTASTableAdapters.FISICO_POR_USUARIOTableAdapter()
        Me.BODEGA_POR_SUCURSALTableAdapter = New TomaFisica.VISTASTableAdapters.BODEGA_POR_SUCURSALTableAdapter()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.FISICOPORUSUARIOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VISTAS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BODEGAPORSUCURSALBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 179.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TxtUsuario, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtClave, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnLogin, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtFechaTomaFisica, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.CmbSucursales, 1, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(61, 34)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(233, 152)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TxtUsuario.Location = New System.Drawing.Point(57, 3)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(104, 20)
        Me.TxtUsuario.TabIndex = 1
        '
        'TxtClave
        '
        Me.TxtClave.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TxtClave.Location = New System.Drawing.Point(57, 29)
        Me.TxtClave.Name = "TxtClave"
        Me.TxtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtClave.Size = New System.Drawing.Size(104, 20)
        Me.TxtClave.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Clave"
        '
        'BtnLogin
        '
        Me.BtnLogin.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BtnLogin.Location = New System.Drawing.Point(57, 110)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(104, 36)
        Me.BtnLogin.TabIndex = 6
        Me.BtnLogin.Text = "Ingresar"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 26)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha"
        '
        'TxtFechaTomaFisica
        '
        Me.TxtFechaTomaFisica.Location = New System.Drawing.Point(57, 55)
        Me.TxtFechaTomaFisica.Mask = "00/00/0000"
        Me.TxtFechaTomaFisica.Name = "TxtFechaTomaFisica"
        Me.TxtFechaTomaFisica.Size = New System.Drawing.Size(100, 20)
        Me.TxtFechaTomaFisica.TabIndex = 5
        Me.TxtFechaTomaFisica.ValidatingType = GetType(Date)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Sucursal"
        '
        'CmbSucursales
        '
        Me.CmbSucursales.DataSource = Me.FISICOPORUSUARIOBindingSource
        Me.CmbSucursales.DisplayMember = "NombreSucursal"
        Me.CmbSucursales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSucursales.FormattingEnabled = True
        Me.CmbSucursales.Location = New System.Drawing.Point(57, 81)
        Me.CmbSucursales.Name = "CmbSucursales"
        Me.CmbSucursales.Size = New System.Drawing.Size(156, 21)
        Me.CmbSucursales.TabIndex = 9
        Me.CmbSucursales.ValueMember = "Sucursal"
        '
        'FISICOPORUSUARIOBindingSource
        '
        Me.FISICOPORUSUARIOBindingSource.DataMember = "FISICO POR USUARIO"
        Me.FISICOPORUSUARIOBindingSource.DataSource = Me.VISTAS
        '
        'VISTAS
        '
        Me.VISTAS.DataSetName = "VISTAS"
        Me.VISTAS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BODEGAPORSUCURSALBindingSource
        '
        Me.BODEGAPORSUCURSALBindingSource.DataMember = "BODEGA POR SUCURSAL"
        Me.BODEGAPORSUCURSALBindingSource.DataSource = Me.VISTAS
        '
        'FISICO_POR_USUARIOTableAdapter
        '
        Me.FISICO_POR_USUARIOTableAdapter.ClearBeforeFill = True
        '
        'BODEGA_POR_SUCURSALTableAdapter
        '
        Me.BODEGA_POR_SUCURSALTableAdapter.ClearBeforeFill = True
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 205)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.KeyPreview = True
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingresar"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.FISICOPORUSUARIOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VISTAS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BODEGAPORSUCURSALBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents TxtClave As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnLogin As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtFechaTomaFisica As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CmbSucursales As ComboBox
    Friend WithEvents FISICOPORUSUARIOBindingSource As BindingSource
    Friend WithEvents VISTAS As VISTAS
    Friend WithEvents FISICO_POR_USUARIOTableAdapter As VISTASTableAdapters.FISICO_POR_USUARIOTableAdapter
    Friend WithEvents BODEGAPORSUCURSALBindingSource As BindingSource
    Friend WithEvents BODEGA_POR_SUCURSALTableAdapter As VISTASTableAdapters.BODEGA_POR_SUCURSALTableAdapter
End Class
