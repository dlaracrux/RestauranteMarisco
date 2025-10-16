Imports System.Runtime.InteropServices
Imports Domain
Imports Common
Imports BusinessLayer
Imports BusinessEntities

Public Class FormLogin
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CustomizeComponents()
        'txtUser
        txtUser.AutoSize = False
        txtUser.Size = New Size(350, 30)
        'txtPass
        txtPass.AutoSize = False
        txtPass.Size = New Size(350, 30)
        txtPass.UseSystemPasswordChar = True
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomizeComponents()
    End Sub

    Private Sub btnLogin_Paint(sender As Object, e As PaintEventArgs) Handles btnLogin.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = btnLogin.ClientRectangle
        myRectangle.Inflate(0, 30)
        buttonPath.AddEllipse(myRectangle)
        btnLogin.Region = New Region(buttonPath)
    End Sub

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub
    Private Sub titleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles titleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub FormLogin_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub txtUser_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUser.KeyDown
        If e.KeyCode = Keys.Return Then
            txtPass.Focus()
        End If
    End Sub

    Private Sub txtPass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPass.KeyDown
        If e.KeyCode = Keys.Return Then
            btnLogin_Click(sender, e)
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim BLUsuario As New BLUsuario
        Dim BEUsuarios As New BEUsuario
        atBEUsuario = BLUsuario.ValidaInicioSesion(txtUser.Text, txtPass.Text)
        If Not atBEUsuario Is Nothing Then
            Me.Hide()
            Dim frm As New MenuPrincipal()
            frm.lblUsername.Text = atBEUsuario.NombreUsuario
            frm.lblEmail.Text = atBEUsuario.Correo
            frm.elUsuarioEnSesion = New BEUsuario
            frm.elUsuarioEnSesion = atBEUsuario
            frm.Show()
            AddHandler frm.FormClosed, AddressOf Me.Logout
        Else
            MessageBox.Show("Usuario o contraseña incorrecta" + vbNewLine + "Por favor intente de nuevo.")
            txtPass.Clear()
            txtPass.Focus()
        End If
    End Sub

    Private Sub lblrecoverPassword_Click(sender As Object, e As EventArgs)
        Me.Opacity = 0.7
        Dim frmRecoverPassword As New FrmRecuperarContrasenia()
        frmRecoverPassword.ShowDialog()
        Me.Opacity = 0.95
    End Sub

    Private Sub Logout(sender As Object, e As FormClosedEventArgs)
        txtUser.Clear()
        txtPass.Clear()
        Me.Show()
        txtUser.Focus()
    End Sub
End Class