Imports System.Data.SqlClient
Public Class Cls_Data
    Public Shared Function AdministracionCostos(_empresa As Integer, _nombreUsuario As String) As Boolean
        Dim valorDevuelto As Boolean
        Using conexionBD As New SqlConnection(My.Settings.MiCadenaConexion.ToString)
            Try
                conexionBD.Open()
                Dim cmd As New SqlCommand("select dbo.[FCN ADMIN COSTOS] (@empresa,@usuario)", conexionBD)
                With cmd
                    .CommandType = CommandType.Text
                    With .Parameters
                        .AddWithValue("@empresa", _empresa)
                        .AddWithValue("usuario", _nombreUsuario)
                    End With
                End With
                valorDevuelto = cmd.ExecuteScalar
                If valorDevuelto = True Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                MessageBox.Show("Error al ingresar: " + ex.Message)
                Return False
            End Try
        End Using
    End Function
    Public Shared Function Login(_nombreUsuario As String, _claveUsuario As String, _formulario As Form) As Boolean
        Dim valorDevuelto As Boolean
        Using conexionBD As New SqlConnection(My.Settings.MiCadenaConexion.ToString)
            Try
                conexionBD.Open()
                'MsgBox(conexionBD.ConnectionTimeout)
                Using comangoLogin As New SqlCommand("select dbo.FCN_LOGIN (@nombreUsuario, @claveUsuario)", conexionBD)
                    comangoLogin.CommandType = CommandType.Text
                    comangoLogin.Parameters.AddWithValue("@nombreUsuario", _nombreUsuario)
                    comangoLogin.Parameters.AddWithValue("@claveUsuario", _claveUsuario)
                    valorDevuelto = comangoLogin.ExecuteScalar
                End Using
                If valorDevuelto = True Then
                    Return True
                Else
                    MessageBox.Show("El nombre de usuario y/o la contraseña son incorrectas. Por favor verifique e intente nuevamente", "Ingreso incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
            Catch ex As Exception
                Dim st As New System.Diagnostics.StackTrace()
                MessageBox.Show("Error al ingresar: " + ex.Message)
                Return False
            End Try
        End Using

    End Function
    Public Shared Function ConsultaDatosUsuario(_empresa As Integer, _usuario As String, _fecha As Date, _frm As Form) As Boolean
        Using conexionBD As New SqlConnection(My.Settings.MiCadenaConexion.ToString)
            Try
                conexionBD.Open()
                Dim cmd As New SqlCommand("select * FROM dbo.DATOS_USUARIO(@empresa, @usuario, @fecha)", conexionBD)
                With cmd
                    .CommandType = CommandType.Text
                    With .Parameters
                        .AddWithValue("@empresa", _empresa)
                        .AddWithValue("@usuario", _usuario)
                        .AddWithValue("@fecha", _fecha)
                    End With
                End With
                Dim adaptadorTabla As New SqlDataAdapter(cmd)
                Dim tablaDatos As New DataTable()
                adaptadorTabla.Fill(tablaDatos)
                If tablaDatos.Rows.Count > 0 Then
                    Dim fila As DataRow = tablaDatos.Rows(0)
                    If CStr(fila(0)).Length = 0 Or CStr(fila(0)) <> Nothing Then
                        g_numeroTomaFisica = fila(1)
                        g_sucursal = fila(2)
                        g_nombreSucursal = fila(3)
                        g_observacionesTomaFisica = fila(4)
                        g_fechaTomaFisica = fila(5)
                        Return True
                    End If
                    Return False
                End If
                Return False
            Catch ex As Exception
                MessageBox.Show("Error: " + ex.Message)
                Return False
            End Try
        End Using
    End Function
    Public Shared Function ConsultaDatosUsuarioAdministrador(_empresa As Integer, _usuario As String, _fecha As Date, _frm As Form) As Boolean
        Using conexionBD As New SqlConnection(My.Settings.MiCadenaConexion.ToString)
            Try
                conexionBD.Open()
                Dim cmd As New SqlCommand("select * FROM [dbo].[DATOS_USUARIO_ADMINISTRADOR](@empresa, @usuario, @fecha)", conexionBD)
                With cmd
                    .CommandType = CommandType.Text
                    With .Parameters
                        .AddWithValue("@empresa", _empresa)
                        .AddWithValue("@usuario", _usuario)
                        .AddWithValue("@fecha", _fecha)
                    End With
                End With
                Dim adaptadorTabla As New SqlDataAdapter(cmd)
                Dim tablaDatos As New DataTable()
                adaptadorTabla.Fill(tablaDatos)
                If tablaDatos.Rows.Count > 0 Then
                    Dim fila As DataRow = tablaDatos.Rows(0)
                    If CStr(fila(0)) <> "" Or CStr(fila(0)) <> Nothing Then
                        g_numeroTomaFisica = fila(1)
                        g_sucursal = fila(2)
                        g_nombreSucursal = fila(3)
                        g_observacionesTomaFisica = fila(4)
                        g_fechaTomaFisica = fila(5)
                        Return True
                    End If
                    Return False
                End If
                Return False
            Catch ex As Exception
                MessageBox.Show("Error: " + ex.Message)
                Return False
            End Try
        End Using
    End Function
    Public Shared Function ConsultarProducto(_empresa As Integer, _sucursal As Integer, _descripcion As String, _codigo As String, txtCodigo As TextBox, txtDescripcion As TextBox) As Boolean
        Using conexion As New SqlConnection(My.Settings.MiCadenaConexion)
            Try
                conexion.Open()
                Dim cmd As New SqlCommand("[CONSULTAR PRODUCTOS EXISTENCIAS]", conexion)
                With cmd
                    .CommandType = CommandType.StoredProcedure
                    With .Parameters
                        .AddWithValue("@empresa", _empresa)
                        .AddWithValue("@bodega", _sucursal)
                        .AddWithValue("@descripcion", _descripcion)
                        .AddWithValue("@codigo", _codigo)
                        .AddWithValue("@buscarpor", 2)
                    End With
                End With
                Dim adaptadorTabla As New SqlDataAdapter(cmd)
                Dim tablaDatos As New DataTable()
                adaptadorTabla.Fill(tablaDatos)
                If tablaDatos.Rows.Count > 0 Then
                    Dim fila As DataRow = tablaDatos.Rows(0)
                    txtCodigo.Text = fila(0)
                    txtDescripcion.Text = fila(1)
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " + ex.Message)
                Return False
            End Try
        End Using
    End Function

    Public Shared Function CrudTomaFisicaMaestro(_empresa As Integer, _numero As Integer, _fecha As Date, _observaciones As String, _estatus As String, _usuario As String, _fechaanulacion As Date, _sucursal As Integer, _tipoop As Integer) As Boolean
        Using conexion As New SqlConnection(My.Settings.MiCadenaConexion.ToString)
            conexion.Open()
            Dim tran As SqlTransaction
            Dim cmd As New SqlCommand("[CRUD MAESTRO TOMA FISICA]", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            tran = conexion.BeginTransaction(IsolationLevel.Serializable)
            Try
                With cmd
                    .Transaction = tran
                    With .Parameters
                        .AddWithValue("@empresa", _empresa)
                        .AddWithValue("@numero", _numero)
                        .AddWithValue("@fecha", _fecha)
                        .AddWithValue("@observaciones", _observaciones)
                        .AddWithValue("@estatus", _estatus)
                        .AddWithValue("@usuario", _usuario)
                        .AddWithValue("@fechaanulacion", _fechaanulacion)
                        .AddWithValue("@sucursal", _sucursal)
                        .AddWithValue("@tipoop", _tipoop)
                    End With
                    .ExecuteNonQuery()
                End With
                tran.Commit()
                Return True
            Catch ex As Exception
                tran.Rollback()
                MessageBox.Show("Error al intentar insertar:" + ex.Message)
                Return False
            End Try
        End Using
    End Function

    Public Shared Function CrudCostos(_codigoProducto As String, _bodega As Integer, _costo As Double, _tipoop As Integer) As Boolean
        Using conexion As New SqlConnection(My.Settings.MiCadenaConexion.ToString)
            conexion.Open()
            Dim tran As SqlTransaction
            Dim cmd As New SqlCommand("[CRUD COSTOS]", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            tran = conexion.BeginTransaction(IsolationLevel.Serializable)
            Try
                With cmd
                    .Transaction = tran
                    With .Parameters
                        .AddWithValue("@producto", _codigoProducto)
                        .AddWithValue("@bodega", _bodega)
                        .AddWithValue("@costo", _costo)
                        .AddWithValue("@tipoop", _tipoop)
                    End With
                    .ExecuteNonQuery()
                End With
                tran.Commit()
                Return True
            Catch ex As Exception
                tran.Rollback()
                MessageBox.Show("Error al intentar insertar:" + ex.Message)
                Return False
            End Try
        End Using
    End Function
    Public Shared Function CrudTomaFisicaDetalle(_numero As Integer, _codigoProducto As String, _tipo As Integer, _empresa As Integer, _cantidadFisica As Integer, _sucursal As Integer, _tipoop As Integer, _posicion As Integer, _fecha As Date) As Boolean
        Using conexion As New SqlConnection(My.Settings.MiCadenaConexion.ToString)
            conexion.Open()
            Dim tran As SqlTransaction
            Dim cmd As New SqlCommand("[CRUD DETALLE TOMA FISICA]", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            tran = conexion.BeginTransaction(IsolationLevel.Serializable)
            Try
                With cmd
                    .Transaction = tran
                    With .Parameters
                        .AddWithValue("@numero", _numero)
                        .AddWithValue("@producto", _codigoProducto)
                        .AddWithValue("@tipo", _tipo)
                        .AddWithValue("@empresa", _empresa)
                        .AddWithValue("@cantidad", _cantidadFisica)
                        .AddWithValue("@sucursal", _sucursal)
                        .AddWithValue("@tipoop", _tipoop) '1 = insertar
                        .AddWithValue("@posicion", _posicion) 'valor default, en el procedimiento lo calcula, si opcion 1
                        .AddWithValue("@fecha", _fecha)
                    End With
                    .ExecuteNonQuery()
                End With
                tran.Commit()
                Return True
            Catch ex As Exception
                tran.Rollback()
                MessageBox.Show("Error al intentar insertar: " + ex.Message)
                Return False
            End Try
        End Using
    End Function
End Class
