Imports System.Drawing.Printing
Imports BusinessEntities
Imports BusinessLayer

Public Class FrmValidaContrasenia
    Private Sub btnCambiar_Click(sender As Object, e As EventArgs) Handles btnCambiar.Click
        If Not txtContrasenia.Text = "" Then
            If txtContrasenia.Text = atBEUsuario.Contrasenia.ToUpper Then
                DialogResult = DialogResult.OK
                Me.Close()
            Else
                MsgBox("Debe de ingregar una contraseña válida", MsgBoxStyle.Exclamation)
            End If
        Else
            MsgBox("Debe de ingregar una contraseña", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub FrmValidaContrasenia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtContrasenia.CharacterCasing = CharacterCasing.Upper
        txtContrasenia.Focus()
        txtContrasenia.SelectAll()
    End Sub

    Private Sub txtContrasenia_KeyDown(sender As Object, e As KeyEventArgs) Handles txtContrasenia.KeyDown
        If e.KeyCode = Keys.Return Then
            btnCambiar_Click(sender, e)
        End If
    End Sub
End Class