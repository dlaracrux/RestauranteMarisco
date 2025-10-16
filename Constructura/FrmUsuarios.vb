Imports System.Text.RegularExpressions
Imports BusinessEntities
Imports BusinessLayer

Public Class FrmUsuarios
    Dim BEUsuario As BEUsuario
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtUsername.Text = "" Then
            MsgBox("Debe ingresar un nombre de usuario", MsgBoxStyle.Exclamation, "Mantenimiento Usuarios")
            txtUsername.Focus()
            Exit Sub
        ElseIf txtFirstName.Text = "" Then
            MsgBox("Debe ingresar un nombre", MsgBoxStyle.Exclamation, "Mantenimiento Usuarios")
            txtUsername.Focus()
            Exit Sub
        ElseIf txtLastName.Text = "" Then
            MsgBox("Debe ingresar un apellido", MsgBoxStyle.Exclamation, "Mantenimiento Usuarios")
            txtUsername.Focus()
            Exit Sub
        ElseIf txtEmail.Text = "" Then
            MsgBox("Debe ingresar un correo electrónico", MsgBoxStyle.Exclamation, "Mantenimiento Usuarios")
            txtUsername.Focus()
            Exit Sub
        End If

        If validar_Mail(txtEmail.Text) Then
            If txtPassword.Text = txtConfirmPass.Text AndAlso txtPassword.Text <> "" Then
                BEUsuario = New BEUsuario
                BEUsuario.NombreUsuario = txtUsername.Text
                BEUsuario.Nombre = txtFirstName.Text
                BEUsuario.Apellidos = txtLastName.Text
                BEUsuario.Correo = txtEmail.Text
                BEUsuario.Contrasenia = txtPassword.Text
                If MsgBox("¿Desea ingresar el nuevo usuario?", MsgBoxStyle.YesNo, "Mantenimiento Usuarios") = MsgBoxResult.Yes Then
                    Dim BLUsuario As New BLUsuario
                    If BLUsuario.MantenimientoUsuarios(BEUsuario) Then
                        MsgBox("El usuarios se ha registrado correctamente", MsgBoxStyle.Information, "Mantenimiento Usuarios")
                        limpiarCampos()
                        txtUsername.Focus()
                    Else
                        MsgBox("Se presentó un problema al guardar en la base de datos", MsgBoxStyle.Information, "Mantenimiento Usuarios")
                    End If
                End If

            Else
                MessageBox.Show("Las contraseñas no coinciden, ¿quieres intentarlo de nuevo?", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtPassword.Focus()
            End If
        Else
            txtEmail.Focus()
            Exit Sub
        End If


    End Sub
    Private Sub limpiarCampos()
        txtUsername.Text = ""
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtEmail.Text = ""
        txtPassword.Text = ""
        txtConfirmPass.Text = ""
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        limpiarCampos()
    End Sub

    Private Sub FrmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = BorderStyle.None
    End Sub


    Function validar_Mail(ByVal sMail As String) As Boolean

        ' retorna true o false  
        Dim todosmailvalidos As Boolean = True

        For Each mail As String In Split(sMail, ",")

            If Regex.IsMatch(mail, "^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$") = False Then
                MsgBox("Cuenta de correo con formato inválido.", MsgBoxStyle.Exclamation, "Mantenimiento Usuarios")
                todosmailvalidos = False
                Exit For
            End If

        Next

        Return todosmailvalidos

    End Function
End Class