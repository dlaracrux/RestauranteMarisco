Public Class FrmEditarPerfil

    Private Sub loadUserData() 'Cargamos los datos a las etiquetas y textoxs// We Load the data to the labels And textxs
        'Normal
        lblLastName.Text = atBEUsuario.Apellidos
        lblMail.Text = atBEUsuario.Correo
        lblUser.Text = atBEUsuario.NombreUsuario
        lblName.Text = atBEUsuario.Nombre
        'Edit
        txtEmail.Text = atBEUsuario.Correo
        txtFirstName.Text = atBEUsuario.Nombre
        txtLastName.Text = atBEUsuario.Apellidos
        txtPassword.Text = atBEUsuario.Contrasenia
        txtConfirmPass.Text = atBEUsuario.Contrasenia
        txtUsername.Text = atBEUsuario.NombreUsuario
    End Sub

    Private Sub initializeControlsPass()
        txtPassword.UseSystemPasswordChar = True
        txtConfirmPass.UseSystemPasswordChar = True
    End Sub

    Private Sub reset() 'reiniciamos todo // all reset
        initializeControlsPass() 'we again invoke the methods to update the data on the screen (in the form), with the new user data, or the existing data, if not updated.
        loadUserData() 'volvemos a invocar los metodo para actualizar los datos en la pantalla (en el formulario), con los nuevos datos del usuario, o los datos existentes, si no actualizó.
    End Sub

    Private Sub linkEdit_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkEdit.LinkClicked
        loadUserData()
        Panel1.Width = 10
        Panel1.Visible = True

    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtPassword.Text = txtConfirmPass.Text AndAlso txtPassword.Text <> "" Then

            '    Dim userModel As New UserModel(
            '           idUser:=ActiveUser.idUser,
            '           loginName:=txtUsername.Text,
            '           password:=txtPassword.Text,
            '           firstName:=txtFirstName.Text,
            '           lastName:=txtLastName.Text,
            '           position:="",
            '           email:=txtEmail.Text)
            '    Dim result = userModel.editUserProfile()
            '    MessageBox.Show(result)
            '    reset() 'reiniciamos todo // all reset

        Else
            MessageBox.Show("the passwords do not match, do you want to try again?" & vbNewLine &
                             "Las contraseñas no coinciden, ¿quieres intentarlo de nuevo?")
            txtPassword.Focus()
        End If

    End Sub

    Private Sub FrmEditarPerfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initializeControlsPass()
        loadUserData()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

    End Sub
End Class