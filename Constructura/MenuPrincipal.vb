Imports System.Runtime.InteropServices
Imports BusinessEntities
Imports BusinessLayer
Imports FontAwesome.Sharp
Public Class MenuPrincipal
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form
    Public elUsuarioEnSesion As BEUsuario

    Public Sub New()
        InitializeComponent()
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 60)
        PanelMenu.Controls.Add(leftBorderBtn)

        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub

    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Button'
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(37, 36, 81)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'Left Border'
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
            'current Form icon'
            IconCurrentForm.IconChar = currentBtn.IconChar
            IconCurrentForm.IconColor = customColor
        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(31, 30, 68)
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.IconColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub
    Private Sub OpenChildForm(childForm As Form)
        'Open only form'
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'end'
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(childForm)
        PanelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        lblFormTitle.Text = childForm.Text
    End Sub
    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuPermisos()
    End Sub
    Private Sub MenuPermisos()
        Dim UsuarioPErmisos As New BEUsuario
        Dim BLUsuario As New BLUsuario
        Dim TablaFormularios As DataTable
        TablaFormularios = BLUsuario.ConsultaFormularios()
        If Not TablaFormularios Is Nothing Then
            For Each row As DataRow In TablaFormularios.Rows
                Me.PanelMenu.Controls(row("nombreFormulario").ToString).Visible = False
            Next
        End If
        UsuarioPErmisos = BLUsuario.ConsultaPermisosFormularios(atBEUsuario.IdUsuario)
        If Not UsuarioPErmisos Is Nothing Then
            For cont As Integer = 0 To UsuarioPErmisos.ListaFormularios.Count - 1
                Me.PanelMenu.Controls(UsuarioPErmisos.ListaFormularios(cont).NombreFormulario).Visible = True
            Next
        End If
    End Sub
    Private Sub btnBancos_Click(sender As Object, e As EventArgs) Handles Mantenimiento_Inventarios.Click
        ActivateButton(sender, RGBColors.color1)
        OpenChildForm(New Mantenimiento_Inventarios)
    End Sub

    Private Sub btnBeneficiarios_Click(sender As Object, e As EventArgs) Handles Consulta_Facturas.Click
        ActivateButton(sender, RGBColors.color2)
        OpenChildForm(New ConsultaDeFacturas)
    End Sub

    Private Sub btnMonedas_Click(sender As Object, e As EventArgs) Handles Cajas.Click
        ActivateButton(sender, RGBColors.color3)
        OpenChildForm(New FrmCajas)
    End Sub

    Private Sub btnFacturas_Click(sender As Object, e As EventArgs) Handles Registro_Facturas.Click
        ActivateButton(sender, RGBColors.color7)
        OpenChildForm(New Registro_Facturas)
    End Sub
    Private Sub Reset()
        DisableButton()
        leftBorderBtn.Visible = False
        IconCurrentForm.IconChar = IconChar.Home
        IconCurrentForm.IconColor = Color.MediumPurple
        lblFormTitle.Text = "Inicio"

    End Sub
    Private Sub imgHome_Click(sender As Object, e As EventArgs) Handles imgHome.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        Reset()
        MenuPermisos()
    End Sub

    'Drag Form'
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub PanelTitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTitleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
    Private Sub btnMaximize_Click(sender As Object, e As EventArgs)
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else
            FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub

    Private Sub FrmUsuarios_Click(sender As Object, e As EventArgs) Handles FrmUsuarios.Click
        ActivateButton(sender, RGBColors.color8)
        OpenChildForm(New FrmUsuarios)
    End Sub

    Private Sub FrmPermisos_Click(sender As Object, e As EventArgs) Handles FrmPermisos.Click
        ActivateButton(sender, RGBColors.color10)
        OpenChildForm(New FrmPermisos)
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        If MessageBox.Show("¿Desea cerrar la sesión?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub lblProfile_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblProfile.LinkClicked
        OpenChildForm(New FrmEditarPerfil)
    End Sub


    Private Sub FrmConsultaDocuCxP_Click(sender As Object, e As EventArgs)
        ActivateButton(sender, RGBColors.color6)
        OpenChildForm(New FrmConsultaArticulos)
    End Sub

End Class