<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PanelTitleBar = New System.Windows.Forms.Panel()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblProfile = New System.Windows.Forms.LinkLabel()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.btnMinimize = New FontAwesome.Sharp.IconPictureBox()
        Me.btnExit = New FontAwesome.Sharp.IconPictureBox()
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.FrmPermisos = New FontAwesome.Sharp.IconButton()
        Me.FrmUsuarios = New FontAwesome.Sharp.IconButton()
        Me.btnCerrarSesion = New FontAwesome.Sharp.IconButton()
        Me.Registro_Facturas = New FontAwesome.Sharp.IconButton()
        Me.Cajas = New FontAwesome.Sharp.IconButton()
        Me.Consulta_Facturas = New FontAwesome.Sharp.IconButton()
        Me.Mantenimiento_Inventarios = New FontAwesome.Sharp.IconButton()
        Me.imgHome = New System.Windows.Forms.PictureBox()
        Me.PanelMenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        Me.PanelTitleBar.SuspendLayout()
        Me.PanelDesktop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.AutoScroll = True
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.FrmPermisos)
        Me.PanelMenu.Controls.Add(Me.FrmUsuarios)
        Me.PanelMenu.Controls.Add(Me.btnCerrarSesion)
        Me.PanelMenu.Controls.Add(Me.Registro_Facturas)
        Me.PanelMenu.Controls.Add(Me.Cajas)
        Me.PanelMenu.Controls.Add(Me.Consulta_Facturas)
        Me.PanelMenu.Controls.Add(Me.Mantenimiento_Inventarios)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(220, 700)
        Me.PanelMenu.TabIndex = 3
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.imgHome)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(220, 140)
        Me.PanelLogo.TabIndex = 0
        '
        'PanelTitleBar
        '
        Me.PanelTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PanelTitleBar.Controls.Add(Me.btnMinimize)
        Me.PanelTitleBar.Controls.Add(Me.btnExit)
        Me.PanelTitleBar.Controls.Add(Me.lblFormTitle)
        Me.PanelTitleBar.Controls.Add(Me.IconCurrentForm)
        Me.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitleBar.Location = New System.Drawing.Point(220, 0)
        Me.PanelTitleBar.Name = "PanelTitleBar"
        Me.PanelTitleBar.Size = New System.Drawing.Size(964, 72)
        Me.PanelTitleBar.TabIndex = 5
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblFormTitle.Location = New System.Drawing.Point(45, 30)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(32, 13)
        Me.lblFormTitle.TabIndex = 1
        Me.lblFormTitle.Text = "Inicio"
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.PanelDesktop.Controls.Add(Me.Panel1)
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(220, 72)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(964, 628)
        Me.PanelDesktop.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblProfile)
        Me.Panel1.Controls.Add(Me.lblEmail)
        Me.Panel1.Controls.Add(Me.lblUsername)
        Me.Panel1.Controls.Add(Me.IconPictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 546)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(964, 82)
        Me.Panel1.TabIndex = 0
        '
        'lblProfile
        '
        Me.lblProfile.ActiveLinkColor = System.Drawing.Color.DodgerBlue
        Me.lblProfile.AutoSize = True
        Me.lblProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfile.LinkColor = System.Drawing.Color.SteelBlue
        Me.lblProfile.Location = New System.Drawing.Point(79, 55)
        Me.lblProfile.Name = "lblProfile"
        Me.lblProfile.Size = New System.Drawing.Size(60, 13)
        Me.lblProfile.TabIndex = 65
        Me.lblProfile.TabStop = True
        Me.lblProfile.Text = "Editar Perfil"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.White
        Me.lblEmail.Location = New System.Drawing.Point(79, 34)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 64
        Me.lblEmail.Text = "Email"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.White
        Me.lblUsername.Location = New System.Drawing.Point(79, 12)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(80, 13)
        Me.lblUsername.TabIndex = 63
        Me.lblUsername.Text = "NombreUsuario"
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.IconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User
        Me.IconPictureBox1.IconColor = System.Drawing.Color.White
        Me.IconPictureBox1.IconSize = 65
        Me.IconPictureBox1.Location = New System.Drawing.Point(9, 11)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(65, 65)
        Me.IconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IconPictureBox1.TabIndex = 62
        Me.IconPictureBox1.TabStop = False
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnMinimize.ForeColor = System.Drawing.Color.MediumPurple
        Me.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.btnMinimize.IconColor = System.Drawing.Color.MediumPurple
        Me.btnMinimize.IconSize = 24
        Me.btnMinimize.Location = New System.Drawing.Point(909, 3)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(24, 30)
        Me.btnMinimize.TabIndex = 4
        Me.btnMinimize.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnExit.ForeColor = System.Drawing.Color.MediumPurple
        Me.btnExit.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.btnExit.IconColor = System.Drawing.Color.MediumPurple
        Me.btnExit.IconSize = 24
        Me.btnExit.Location = New System.Drawing.Point(937, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(24, 30)
        Me.btnExit.TabIndex = 2
        Me.btnExit.TabStop = False
        '
        'IconCurrentForm
        '
        Me.IconCurrentForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.IconCurrentForm.ForeColor = System.Drawing.Color.MediumPurple
        Me.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconCurrentForm.IconColor = System.Drawing.Color.MediumPurple
        Me.IconCurrentForm.Location = New System.Drawing.Point(6, 20)
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.Size = New System.Drawing.Size(32, 32)
        Me.IconCurrentForm.TabIndex = 0
        Me.IconCurrentForm.TabStop = False
        '
        'FrmPermisos
        '
        Me.FrmPermisos.Dock = System.Windows.Forms.DockStyle.Top
        Me.FrmPermisos.FlatAppearance.BorderSize = 0
        Me.FrmPermisos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FrmPermisos.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.FrmPermisos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FrmPermisos.IconChar = FontAwesome.Sharp.IconChar.IdCard
        Me.FrmPermisos.IconColor = System.Drawing.Color.White
        Me.FrmPermisos.IconSize = 32
        Me.FrmPermisos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FrmPermisos.Location = New System.Drawing.Point(0, 440)
        Me.FrmPermisos.Name = "FrmPermisos"
        Me.FrmPermisos.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.FrmPermisos.Rotation = 0R
        Me.FrmPermisos.Size = New System.Drawing.Size(220, 60)
        Me.FrmPermisos.TabIndex = 11
        Me.FrmPermisos.Text = "Permisos Usuarios"
        Me.FrmPermisos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FrmPermisos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.FrmPermisos.UseVisualStyleBackColor = True
        Me.FrmPermisos.Visible = False
        '
        'FrmUsuarios
        '
        Me.FrmUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.FrmUsuarios.FlatAppearance.BorderSize = 0
        Me.FrmUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FrmUsuarios.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.FrmUsuarios.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FrmUsuarios.IconChar = FontAwesome.Sharp.IconChar.User
        Me.FrmUsuarios.IconColor = System.Drawing.Color.White
        Me.FrmUsuarios.IconSize = 32
        Me.FrmUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FrmUsuarios.Location = New System.Drawing.Point(0, 380)
        Me.FrmUsuarios.Name = "FrmUsuarios"
        Me.FrmUsuarios.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.FrmUsuarios.Rotation = 0R
        Me.FrmUsuarios.Size = New System.Drawing.Size(220, 60)
        Me.FrmUsuarios.TabIndex = 9
        Me.FrmUsuarios.Text = "Nuevo Usuario"
        Me.FrmUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FrmUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.FrmUsuarios.UseVisualStyleBackColor = True
        Me.FrmUsuarios.Visible = False
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnCerrarSesion.FlatAppearance.BorderSize = 0
        Me.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarSesion.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.TimesCircle
        Me.btnCerrarSesion.IconColor = System.Drawing.Color.White
        Me.btnCerrarSesion.IconSize = 32
        Me.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrarSesion.Location = New System.Drawing.Point(0, 640)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnCerrarSesion.Rotation = 0R
        Me.btnCerrarSesion.Size = New System.Drawing.Size(220, 60)
        Me.btnCerrarSesion.TabIndex = 8
        Me.btnCerrarSesion.Text = "Cerrar Sesion"
        Me.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCerrarSesion.UseVisualStyleBackColor = True
        '
        'Registro_Facturas
        '
        Me.Registro_Facturas.Dock = System.Windows.Forms.DockStyle.Top
        Me.Registro_Facturas.FlatAppearance.BorderSize = 0
        Me.Registro_Facturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Registro_Facturas.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Registro_Facturas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Registro_Facturas.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart
        Me.Registro_Facturas.IconColor = System.Drawing.Color.White
        Me.Registro_Facturas.IconSize = 32
        Me.Registro_Facturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Registro_Facturas.Location = New System.Drawing.Point(0, 320)
        Me.Registro_Facturas.Name = "Registro_Facturas"
        Me.Registro_Facturas.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.Registro_Facturas.Rotation = 0R
        Me.Registro_Facturas.Size = New System.Drawing.Size(220, 60)
        Me.Registro_Facturas.TabIndex = 7
        Me.Registro_Facturas.Text = "Facturación"
        Me.Registro_Facturas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Registro_Facturas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Registro_Facturas.UseVisualStyleBackColor = True
        Me.Registro_Facturas.Visible = False
        '
        'Cajas
        '
        Me.Cajas.Dock = System.Windows.Forms.DockStyle.Top
        Me.Cajas.FlatAppearance.BorderSize = 0
        Me.Cajas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cajas.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Cajas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Cajas.IconChar = FontAwesome.Sharp.IconChar.CashRegister
        Me.Cajas.IconColor = System.Drawing.Color.White
        Me.Cajas.IconSize = 32
        Me.Cajas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cajas.Location = New System.Drawing.Point(0, 260)
        Me.Cajas.Name = "Cajas"
        Me.Cajas.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.Cajas.Rotation = 0R
        Me.Cajas.Size = New System.Drawing.Size(220, 60)
        Me.Cajas.TabIndex = 3
        Me.Cajas.Text = "Cajas"
        Me.Cajas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cajas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Cajas.UseVisualStyleBackColor = True
        Me.Cajas.Visible = False
        '
        'Consulta_Facturas
        '
        Me.Consulta_Facturas.Dock = System.Windows.Forms.DockStyle.Top
        Me.Consulta_Facturas.FlatAppearance.BorderSize = 0
        Me.Consulta_Facturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Consulta_Facturas.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Consulta_Facturas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Consulta_Facturas.IconChar = FontAwesome.Sharp.IconChar.FolderMinus
        Me.Consulta_Facturas.IconColor = System.Drawing.Color.White
        Me.Consulta_Facturas.IconSize = 32
        Me.Consulta_Facturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Consulta_Facturas.Location = New System.Drawing.Point(0, 200)
        Me.Consulta_Facturas.Name = "Consulta_Facturas"
        Me.Consulta_Facturas.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.Consulta_Facturas.Rotation = 0R
        Me.Consulta_Facturas.Size = New System.Drawing.Size(220, 60)
        Me.Consulta_Facturas.TabIndex = 2
        Me.Consulta_Facturas.Text = "Consulta Facturas"
        Me.Consulta_Facturas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Consulta_Facturas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Consulta_Facturas.UseVisualStyleBackColor = True
        Me.Consulta_Facturas.Visible = False
        '
        'Mantenimiento_Inventarios
        '
        Me.Mantenimiento_Inventarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.Mantenimiento_Inventarios.FlatAppearance.BorderSize = 0
        Me.Mantenimiento_Inventarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Mantenimiento_Inventarios.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Mantenimiento_Inventarios.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Mantenimiento_Inventarios.IconChar = FontAwesome.Sharp.IconChar.Trailer
        Me.Mantenimiento_Inventarios.IconColor = System.Drawing.Color.White
        Me.Mantenimiento_Inventarios.IconSize = 32
        Me.Mantenimiento_Inventarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Mantenimiento_Inventarios.Location = New System.Drawing.Point(0, 140)
        Me.Mantenimiento_Inventarios.Name = "Mantenimiento_Inventarios"
        Me.Mantenimiento_Inventarios.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.Mantenimiento_Inventarios.Rotation = 0R
        Me.Mantenimiento_Inventarios.Size = New System.Drawing.Size(220, 60)
        Me.Mantenimiento_Inventarios.TabIndex = 1
        Me.Mantenimiento_Inventarios.Text = "Inventarios"
        Me.Mantenimiento_Inventarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Mantenimiento_Inventarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Mantenimiento_Inventarios.UseVisualStyleBackColor = True
        Me.Mantenimiento_Inventarios.Visible = False
        '
        'imgHome
        '
        Me.imgHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgHome.Image = Global.Llantera.My.Resources.Resources.IconoRestaurante
        Me.imgHome.Location = New System.Drawing.Point(25, 20)
        Me.imgHome.Name = "imgHome"
        Me.imgHome.Size = New System.Drawing.Size(145, 86)
        Me.imgHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgHome.TabIndex = 0
        Me.imgHome.TabStop = False
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1184, 700)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.PanelTitleBar)
        Me.Controls.Add(Me.PanelMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MinimumSize = New System.Drawing.Size(1100, 700)
        Me.Name = "MenuPrincipal"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Restaurante Del Marisco"
        Me.TransparencyKey = System.Drawing.Color.Gray
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        Me.PanelTitleBar.ResumeLayout(False)
        Me.PanelTitleBar.PerformLayout()
        Me.PanelDesktop.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents imgHome As PictureBox
    Friend WithEvents Registro_Facturas As FontAwesome.Sharp.IconButton
    Friend WithEvents Cajas As FontAwesome.Sharp.IconButton
    Friend WithEvents Consulta_Facturas As FontAwesome.Sharp.IconButton
    Friend WithEvents Mantenimiento_Inventarios As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelTitleBar As Panel
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents btnMinimize As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnExit As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnCerrarSesion As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FrmPermisos As FontAwesome.Sharp.IconButton
    Friend WithEvents FrmUsuarios As FontAwesome.Sharp.IconButton
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lblProfile As LinkLabel
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblUsername As Label
End Class
