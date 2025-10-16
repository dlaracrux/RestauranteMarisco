Imports BusinessEntities
Imports BusinessLayer

Public Class FrmPermisos
    Public UsuarioPErmisos As New BEUsuario
    Dim BLUsuario As New BLUsuario
    Private Sub cargaComboUsuario()
        Dim TablaFormularios As DataTable
        TablaFormularios = BLUsuario.ConsultaFormularios()
        listaFormularios.DataSource = TablaFormularios
        listaFormularios.DisplayMember = "descripcion"
        listaFormularios.ValueMember = "idFormulario"


        Dim TablaUsuarios As DataTable
        TablaUsuarios = BLUsuario.ConsultaUsuarios()
        cmbUsuarios.DisplayMember = "nombreUsuario"
        cmbUsuarios.ValueMember = "idUsuario"
        cmbUsuarios.DataSource = TablaUsuarios

    End Sub

    Private Sub LimpiarCampos()
        If cmbUsuarios.SelectedIndex > -1 Then
            cmbUsuarios.SelectedIndex = 0
        End If
        listaFormularios = Nothing
    End Sub

    Private Sub FrmPermisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargaComboUsuario()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If Not cmbUsuarios.SelectedIndex > -1 Then
            MsgBox("Debe seleccionar un nombre usuario", MsgBoxStyle.Exclamation, "Asignación Permisos Usuarios")
            cmbUsuarios.Focus()
            Exit Sub
        ElseIf Not listaFormularios.CheckedItems.Count > 0 Then
            MsgBox("Debe marcar al menos un formulario para asignar el permiso", MsgBoxStyle.Exclamation, "Asignación Permisos Usuarios")
            listaFormularios.Focus()
        End If

        Dim BLUsuario As BLUsuario
        Dim ListaPermisosFormularios As New List(Of BEPermisosFormularios)
        Dim PermisosFormularios As BEPermisosFormularios
        For Each item As Object In listaFormularios.CheckedItems
            Dim RowView As DataRowView = TryCast(item, DataRowView)
            PermisosFormularios = New BEPermisosFormularios
            PermisosFormularios.IdUsuario = CInt(cmbUsuarios.SelectedValue)
            PermisosFormularios.IdFormulario = CInt(RowView("idFormulario"))
            ListaPermisosFormularios.Add(PermisosFormularios)
        Next

        If ListaPermisosFormularios.Count > 0 Then
            BLUsuario = New BLUsuario
            If BLUsuario.Mantenimiento_PermisosUsuarios(ListaPermisosFormularios) Then
                MsgBox("Se asignaron los permisos exitosamente", MsgBoxStyle.Information, "Asignación Permisos Usuarios")
                'LimpiarCampos()
                cargaComboUsuario()
                cmbUsuarios.Focus()
            Else
                MsgBox("No se han podido asignar los permisos de usuario. Intente de nuevo.", MsgBoxStyle.Critical, "Asignación Permisos Usuarios")
            End If

        End If

    End Sub

    Private Sub cmbUsuarios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUsuarios.SelectedIndexChanged
        If cmbUsuarios.SelectedIndex > -1 Then
            For i As Integer = 0 To listaFormularios.Items.Count - 1
                listaFormularios.SetItemChecked(i, False)
            Next
            UsuarioPErmisos = BLUsuario.ConsultaPermisosFormularios(CInt(cmbUsuarios.SelectedValue))
            If Not UsuarioPErmisos Is Nothing Then
                For cont As Integer = 0 To UsuarioPErmisos.ListaFormularios.Count - 1
                    For i As Integer = 0 To listaFormularios.Items.Count - 1
                        Dim RowView As DataRowView = TryCast(listaFormularios.Items(i), DataRowView)
                        If CInt(RowView("idFormulario")) = UsuarioPErmisos.ListaFormularios(cont).IdFormulario Then
                            listaFormularios.SetItemChecked(i, True)
                            Exit For
                        End If
                    Next
                Next
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class