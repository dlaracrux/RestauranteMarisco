<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Mantenimiento_Inventarios
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtNombreArticulo = New System.Windows.Forms.TextBox()
        Me.lNombreBanco = New System.Windows.Forms.Label()
        Me.lEstadoBanco = New System.Windows.Forms.Label()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgArticulos = New System.Windows.Forms.DataGridView()
        Me.btnExportar = New FontAwesome.Sharp.IconButton()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.articulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNombreArticulo
        '
        Me.txtNombreArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreArticulo.Location = New System.Drawing.Point(123, 71)
        Me.txtNombreArticulo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNombreArticulo.Name = "txtNombreArticulo"
        Me.txtNombreArticulo.Size = New System.Drawing.Size(575, 23)
        Me.txtNombreArticulo.TabIndex = 1
        '
        'lNombreBanco
        '
        Me.lNombreBanco.AutoSize = True
        Me.lNombreBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lNombreBanco.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lNombreBanco.Location = New System.Drawing.Point(56, 76)
        Me.lNombreBanco.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lNombreBanco.Name = "lNombreBanco"
        Me.lNombreBanco.Size = New System.Drawing.Size(55, 17)
        Me.lNombreBanco.TabIndex = 0
        Me.lNombreBanco.Text = "Articulo"
        '
        'lEstadoBanco
        '
        Me.lEstadoBanco.AutoSize = True
        Me.lEstadoBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lEstadoBanco.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lEstadoBanco.Location = New System.Drawing.Point(75, 30)
        Me.lEstadoBanco.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lEstadoBanco.Name = "lEstadoBanco"
        Me.lEstadoBanco.Size = New System.Drawing.Size(36, 17)
        Me.lEstadoBanco.TabIndex = 2
        Me.lEstadoBanco.Text = "Tipo"
        '
        'cmbTipo
        '
        Me.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Location = New System.Drawing.Point(123, 25)
        Me.cmbTipo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(160, 25)
        Me.cmbTipo.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1319, 49)
        Me.Panel1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(17, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = ">> Mantenimiento Inventarios"
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconPictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.IconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.IconPictureBox1.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Trailer
        Me.IconPictureBox1.IconColor = System.Drawing.Color.White
        Me.IconPictureBox1.IconSize = 212
        Me.IconPictureBox1.Location = New System.Drawing.Point(952, 23)
        Me.IconPictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(221, 212)
        Me.IconPictureBox1.TabIndex = 62
        Me.IconPictureBox1.TabStop = False
        '
        'bCancelar
        '
        Me.bCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bCancelar.BackColor = System.Drawing.Color.Brown
        Me.bCancelar.FlatAppearance.BorderSize = 0
        Me.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bCancelar.ForeColor = System.Drawing.Color.White
        Me.bCancelar.Location = New System.Drawing.Point(688, 748)
        Me.bCancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(204, 42)
        Me.bCancelar.TabIndex = 3
        Me.bCancelar.Text = "Limpiar"
        Me.bCancelar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnGuardar.BackColor = System.Drawing.Color.SeaGreen
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(419, 748)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(204, 42)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'txtPrecio
        '
        Me.txtPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.Location = New System.Drawing.Point(123, 111)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(160, 23)
        Me.txtPrecio.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(9, 114)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Precio Sin Imp."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(47, 159)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Cantidad"
        '
        'txtCantidad
        '
        Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(123, 154)
        Me.txtCantidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(160, 23)
        Me.txtCantidad.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.txtNombreArticulo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lNombreBanco)
        Me.GroupBox1.Controls.Add(Me.txtCantidad)
        Me.GroupBox1.Controls.Add(Me.IconPictureBox1)
        Me.GroupBox1.Controls.Add(Me.lEstadoBanco)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbTipo)
        Me.GroupBox1.Controls.Add(Me.txtPrecio)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 57)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1263, 247)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'dgArticulos
        '
        Me.dgArticulos.AllowUserToAddRows = False
        Me.dgArticulos.AllowUserToDeleteRows = False
        Me.dgArticulos.AllowUserToResizeRows = False
        Me.dgArticulos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgArticulos.BackgroundColor = System.Drawing.Color.SkyBlue
        Me.dgArticulos.ColumnHeadersHeight = 29
        Me.dgArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgArticulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.articulo, Me.Tipo, Me.Precio, Me.Cantidad})
        Me.dgArticulos.Location = New System.Drawing.Point(23, 322)
        Me.dgArticulos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgArticulos.MultiSelect = False
        Me.dgArticulos.Name = "dgArticulos"
        Me.dgArticulos.ReadOnly = True
        Me.dgArticulos.RowHeadersWidth = 5
        Me.dgArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgArticulos.Size = New System.Drawing.Size(1263, 393)
        Me.dgArticulos.TabIndex = 1
        '
        'btnExportar
        '
        Me.btnExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExportar.BackColor = System.Drawing.Color.SeaGreen
        Me.btnExportar.FlatAppearance.BorderSize = 0
        Me.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExportar.IconChar = FontAwesome.Sharp.IconChar.FileExport
        Me.btnExportar.IconColor = System.Drawing.Color.White
        Me.btnExportar.IconSize = 25
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnExportar.Location = New System.Drawing.Point(23, 748)
        Me.btnExportar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Padding = New System.Windows.Forms.Padding(13, 0, 27, 0)
        Me.btnExportar.Rotation = 0R
        Me.btnExportar.Size = New System.Drawing.Size(160, 42)
        Me.btnExportar.TabIndex = 9
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExportar.UseVisualStyleBackColor = False
        '
        'codigo
        '
        Me.codigo.DataPropertyName = "codigo"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.codigo.DefaultCellStyle = DataGridViewCellStyle1
        Me.codigo.HeaderText = "Código"
        Me.codigo.MinimumWidth = 6
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.codigo.Width = 70
        '
        'articulo
        '
        Me.articulo.DataPropertyName = "nombre"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.articulo.DefaultCellStyle = DataGridViewCellStyle2
        Me.articulo.HeaderText = "Artículo"
        Me.articulo.MinimumWidth = 6
        Me.articulo.Name = "articulo"
        Me.articulo.ReadOnly = True
        Me.articulo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.articulo.Width = 400
        '
        'Tipo
        '
        Me.Tipo.DataPropertyName = "tipo"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.Tipo.DefaultCellStyle = DataGridViewCellStyle3
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.MinimumWidth = 6
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        Me.Tipo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Tipo.Width = 150
        '
        'Precio
        '
        Me.Precio.DataPropertyName = "precio"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.Precio.DefaultCellStyle = DataGridViewCellStyle4
        Me.Precio.HeaderText = "Precio"
        Me.Precio.MinimumWidth = 6
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        Me.Precio.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Precio.Width = 125
        '
        'Cantidad
        '
        Me.Cantidad.DataPropertyName = "cantidad"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle5
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.MinimumWidth = 6
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Cantidad.Width = 125
        '
        'Mantenimiento_Inventarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1319, 809)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.dgArticulos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Mantenimiento_Inventarios"
        Me.Text = "Inventarios"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtNombreArticulo As TextBox
    Friend WithEvents lNombreBanco As Label
    Friend WithEvents lEstadoBanco As Label
    Friend WithEvents cmbTipo As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents bCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgArticulos As DataGridView
    Friend WithEvents btnExportar As FontAwesome.Sharp.IconButton
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents articulo As DataGridViewTextBoxColumn
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
End Class
