<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro_Facturas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblModificaPrecio = New System.Windows.Forms.LinkLabel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.lEstadoBanco = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPrecioUnitario = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtExistencias = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtNombreArticulo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAgregarLinea = New FontAwesome.Sharp.IconButton()
        Me.txtCodigoArticulo = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtVendedor = New System.Windows.Forms.TextBox()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.txtFechaFactura = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.dgLinea = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.existencias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoIndex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTotalFactura = New System.Windows.Forms.TextBox()
        Me.lblTotalImpuesto = New System.Windows.Forms.Label()
        Me.txtTotalImpuesto = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgLinea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1315, 49)
        Me.Panel1.TabIndex = 131
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Location = New System.Drawing.Point(17, 12)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(213, 25)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = ">> Registro Facturas"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.Controls.Add(Me.lblModificaPrecio)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cmbTipo)
        Me.GroupBox2.Controls.Add(Me.lEstadoBanco)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtPrecioUnitario)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtExistencias)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtCantidad)
        Me.GroupBox2.Controls.Add(Me.txtNombreArticulo)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btnAgregarLinea)
        Me.GroupBox2.Controls.Add(Me.txtCodigoArticulo)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(44, 257)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(1219, 148)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "  Artículo  "
        '
        'lblModificaPrecio
        '
        Me.lblModificaPrecio.AutoSize = True
        Me.lblModificaPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModificaPrecio.LinkColor = System.Drawing.Color.White
        Me.lblModificaPrecio.Location = New System.Drawing.Point(291, 105)
        Me.lblModificaPrecio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblModificaPrecio.Name = "lblModificaPrecio"
        Me.lblModificaPrecio.Size = New System.Drawing.Size(114, 18)
        Me.lblModificaPrecio.TabIndex = 138
        Me.lblModificaPrecio.TabStop = True
        Me.lblModificaPrecio.Text = "Modificar precio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(289, 58)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(161, 17)
        Me.Label6.TabIndex = 137
        Me.Label6.Text = "F1 para buscar articulos"
        '
        'cmbTipo
        '
        Me.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipo.Enabled = False
        Me.cmbTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Location = New System.Drawing.Point(803, 97)
        Me.cmbTipo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(141, 25)
        Me.cmbTipo.TabIndex = 5
        '
        'lEstadoBanco
        '
        Me.lEstadoBanco.AutoSize = True
        Me.lEstadoBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lEstadoBanco.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lEstadoBanco.Location = New System.Drawing.Point(757, 102)
        Me.lEstadoBanco.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lEstadoBanco.Name = "lEstadoBanco"
        Me.lEstadoBanco.Size = New System.Drawing.Size(36, 17)
        Me.lEstadoBanco.TabIndex = 135
        Me.lEstadoBanco.Text = "Tipo"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Location = New System.Drawing.Point(29, 103)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 17)
        Me.Label12.TabIndex = 134
        Me.Label12.Text = "Precio Unitario"
        '
        'txtPrecioUnitario
        '
        Me.txtPrecioUnitario.Enabled = False
        Me.txtPrecioUnitario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioUnitario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtPrecioUnitario.Location = New System.Drawing.Point(139, 98)
        Me.txtPrecioUnitario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPrecioUnitario.Name = "txtPrecioUnitario"
        Me.txtPrecioUnitario.Size = New System.Drawing.Size(141, 23)
        Me.txtPrecioUnitario.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(715, 69)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 17)
        Me.Label9.TabIndex = 132
        Me.Label9.Text = "Existencias"
        '
        'txtExistencias
        '
        Me.txtExistencias.Enabled = False
        Me.txtExistencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExistencias.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtExistencias.Location = New System.Drawing.Point(803, 64)
        Me.txtExistencias.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtExistencias.Name = "txtExistencias"
        Me.txtExistencias.ReadOnly = True
        Me.txtExistencias.Size = New System.Drawing.Size(141, 23)
        Me.txtExistencias.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(65, 69)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 17)
        Me.Label4.TabIndex = 130
        Me.Label4.Text = "Cantidad"
        '
        'txtCantidad
        '
        Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtCantidad.Location = New System.Drawing.Point(139, 64)
        Me.txtCantidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(141, 23)
        Me.txtCantidad.TabIndex = 2
        '
        'txtNombreArticulo
        '
        Me.txtNombreArticulo.Enabled = False
        Me.txtNombreArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreArticulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtNombreArticulo.Location = New System.Drawing.Point(289, 30)
        Me.txtNombreArticulo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNombreArticulo.Name = "txtNombreArticulo"
        Me.txtNombreArticulo.Size = New System.Drawing.Size(655, 23)
        Me.txtNombreArticulo.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(24, 34)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 17)
        Me.Label3.TabIndex = 127
        Me.Label3.Text = "Código Artículo"
        '
        'btnAgregarLinea
        '
        Me.btnAgregarLinea.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAgregarLinea.BackColor = System.Drawing.Color.SeaGreen
        Me.btnAgregarLinea.FlatAppearance.BorderSize = 0
        Me.btnAgregarLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarLinea.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnAgregarLinea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarLinea.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAgregarLinea.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.btnAgregarLinea.IconColor = System.Drawing.Color.White
        Me.btnAgregarLinea.IconSize = 25
        Me.btnAgregarLinea.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnAgregarLinea.Location = New System.Drawing.Point(1033, 94)
        Me.btnAgregarLinea.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAgregarLinea.Name = "btnAgregarLinea"
        Me.btnAgregarLinea.Padding = New System.Windows.Forms.Padding(13, 0, 27, 0)
        Me.btnAgregarLinea.Rotation = 0R
        Me.btnAgregarLinea.Size = New System.Drawing.Size(149, 34)
        Me.btnAgregarLinea.TabIndex = 6
        Me.btnAgregarLinea.Text = "Agregar"
        Me.btnAgregarLinea.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAgregarLinea.UseVisualStyleBackColor = False
        '
        'txtCodigoArticulo
        '
        Me.txtCodigoArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoArticulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtCodigoArticulo.Location = New System.Drawing.Point(139, 30)
        Me.txtCodigoArticulo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCodigoArticulo.Name = "txtCodigoArticulo"
        Me.txtCodigoArticulo.Size = New System.Drawing.Size(141, 23)
        Me.txtCodigoArticulo.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.txtNombreCliente)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtVendedor)
        Me.GroupBox1.Controls.Add(Me.txtCedula)
        Me.GroupBox1.Controls.Add(Me.txtFechaFactura)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(44, 57)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1219, 190)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "  Encabezado  "
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtNombreCliente.Location = New System.Drawing.Point(145, 23)
        Me.txtNombreCliente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNombreCliente.MaxLength = 100
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(483, 23)
        Me.txtNombreCliente.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(9, 137)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(123, 17)
        Me.Label11.TabIndex = 126
        Me.Label11.Text = "Fecha Documento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(31, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(65, 100)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Vendedor"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(83, 64)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 17)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Cédula"
        '
        'txtVendedor
        '
        Me.txtVendedor.Enabled = False
        Me.txtVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVendedor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtVendedor.Location = New System.Drawing.Point(144, 95)
        Me.txtVendedor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtVendedor.MaxLength = 20
        Me.txtVendedor.Name = "txtVendedor"
        Me.txtVendedor.Size = New System.Drawing.Size(483, 23)
        Me.txtVendedor.TabIndex = 2
        '
        'txtCedula
        '
        Me.txtCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedula.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtCedula.Location = New System.Drawing.Point(145, 59)
        Me.txtCedula.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCedula.MaxLength = 100
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(483, 23)
        Me.txtCedula.TabIndex = 1
        '
        'txtFechaFactura
        '
        Me.txtFechaFactura.Enabled = False
        Me.txtFechaFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaFactura.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtFechaFactura.Location = New System.Drawing.Point(144, 132)
        Me.txtFechaFactura.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFechaFactura.MaxLength = 10
        Me.txtFechaFactura.Name = "txtFechaFactura"
        Me.txtFechaFactura.Size = New System.Drawing.Size(483, 23)
        Me.txtFechaFactura.TabIndex = 3
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnGuardar.BackColor = System.Drawing.Color.SeaGreen
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(441, 777)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(204, 43)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "Guardar "
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancelar.BackColor = System.Drawing.Color.Brown
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(680, 777)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(204, 43)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'dgLinea
        '
        Me.dgLinea.AllowUserToAddRows = False
        Me.dgLinea.AllowUserToDeleteRows = False
        Me.dgLinea.AllowUserToResizeRows = False
        Me.dgLinea.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.dgLinea.BackgroundColor = System.Drawing.Color.SkyBlue
        Me.dgLinea.ColumnHeadersHeight = 29
        Me.dgLinea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgLinea.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.nombre, Me.cantidad, Me.precio, Me.tipo, Me.precioTotal, Me.existencias, Me.tipoIndex})
        Me.dgLinea.Location = New System.Drawing.Point(44, 426)
        Me.dgLinea.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgLinea.MultiSelect = False
        Me.dgLinea.Name = "dgLinea"
        Me.dgLinea.ReadOnly = True
        Me.dgLinea.RowHeadersWidth = 5
        Me.dgLinea.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgLinea.Size = New System.Drawing.Size(1219, 287)
        Me.dgLinea.TabIndex = 2
        '
        'codigo
        '
        Me.codigo.DataPropertyName = "codigo"
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        Me.codigo.DefaultCellStyle = DataGridViewCellStyle8
        Me.codigo.HeaderText = "Código"
        Me.codigo.MinimumWidth = 6
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.codigo.Width = 125
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        Me.nombre.DefaultCellStyle = DataGridViewCellStyle9
        Me.nombre.HeaderText = "Artículo"
        Me.nombre.MinimumWidth = 6
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.nombre.Width = 300
        '
        'cantidad
        '
        Me.cantidad.DataPropertyName = "cantidad"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle10.Format = "N2"
        DataGridViewCellStyle10.NullValue = Nothing
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        Me.cantidad.DefaultCellStyle = DataGridViewCellStyle10
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.MinimumWidth = 6
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        Me.cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.cantidad.Width = 125
        '
        'precio
        '
        Me.precio.DataPropertyName = "precio"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle11.Format = "N2"
        DataGridViewCellStyle11.NullValue = Nothing
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black
        Me.precio.DefaultCellStyle = DataGridViewCellStyle11
        Me.precio.HeaderText = "Precio Unitario"
        Me.precio.MinimumWidth = 6
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        Me.precio.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.precio.Width = 150
        '
        'tipo
        '
        Me.tipo.DataPropertyName = "tipo"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        Me.tipo.DefaultCellStyle = DataGridViewCellStyle12
        Me.tipo.HeaderText = "Tipo"
        Me.tipo.MinimumWidth = 6
        Me.tipo.Name = "tipo"
        Me.tipo.ReadOnly = True
        Me.tipo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tipo.Width = 125
        '
        'precioTotal
        '
        Me.precioTotal.DataPropertyName = "precioTotal"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle13.Format = "N2"
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black
        Me.precioTotal.DefaultCellStyle = DataGridViewCellStyle13
        Me.precioTotal.HeaderText = "Precio Total "
        Me.precioTotal.MinimumWidth = 6
        Me.precioTotal.Name = "precioTotal"
        Me.precioTotal.ReadOnly = True
        Me.precioTotal.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.precioTotal.Width = 150
        '
        'existencias
        '
        Me.existencias.DataPropertyName = "existencias"
        DataGridViewCellStyle14.Format = "N2"
        Me.existencias.DefaultCellStyle = DataGridViewCellStyle14
        Me.existencias.HeaderText = "Existencias"
        Me.existencias.MinimumWidth = 6
        Me.existencias.Name = "existencias"
        Me.existencias.ReadOnly = True
        Me.existencias.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.existencias.Visible = False
        Me.existencias.Width = 125
        '
        'tipoIndex
        '
        Me.tipoIndex.HeaderText = "tipoIndex"
        Me.tipoIndex.MinimumWidth = 6
        Me.tipoIndex.Name = "tipoIndex"
        Me.tipoIndex.ReadOnly = True
        Me.tipoIndex.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tipoIndex.Visible = False
        Me.tipoIndex.Width = 125
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(1002, 726)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 17)
        Me.Label5.TabIndex = 136
        Me.Label5.Text = "Total Factura"
        '
        'txtTotalFactura
        '
        Me.txtTotalFactura.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtTotalFactura.Enabled = False
        Me.txtTotalFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalFactura.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtTotalFactura.Location = New System.Drawing.Point(1104, 721)
        Me.txtTotalFactura.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTotalFactura.MaxLength = 10
        Me.txtTotalFactura.Name = "txtTotalFactura"
        Me.txtTotalFactura.Size = New System.Drawing.Size(159, 23)
        Me.txtTotalFactura.TabIndex = 3
        Me.txtTotalFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTotalImpuesto
        '
        Me.lblTotalImpuesto.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblTotalImpuesto.AutoSize = True
        Me.lblTotalImpuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalImpuesto.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTotalImpuesto.Location = New System.Drawing.Point(726, 724)
        Me.lblTotalImpuesto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalImpuesto.Name = "lblTotalImpuesto"
        Me.lblTotalImpuesto.Size = New System.Drawing.Size(101, 17)
        Me.lblTotalImpuesto.TabIndex = 138
        Me.lblTotalImpuesto.Text = "Total Impuesto"
        '
        'txtTotalImpuesto
        '
        Me.txtTotalImpuesto.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtTotalImpuesto.Enabled = False
        Me.txtTotalImpuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalImpuesto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtTotalImpuesto.Location = New System.Drawing.Point(835, 721)
        Me.txtTotalImpuesto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalImpuesto.MaxLength = 10
        Me.txtTotalImpuesto.Name = "txtTotalImpuesto"
        Me.txtTotalImpuesto.Size = New System.Drawing.Size(159, 23)
        Me.txtTotalImpuesto.TabIndex = 137
        Me.txtTotalImpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Registro_Facturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1315, 874)
        Me.Controls.Add(Me.lblTotalImpuesto)
        Me.Controls.Add(Me.txtTotalImpuesto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTotalFactura)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgLinea)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Registro_Facturas"
        Me.Text = "Registro Facturas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgLinea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbTipo As ComboBox
    Friend WithEvents lEstadoBanco As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtPrecioUnitario As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtExistencias As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtNombreArticulo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAgregarLinea As FontAwesome.Sharp.IconButton
    Friend WithEvents txtCodigoArticulo As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtVendedor As TextBox
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents txtFechaFactura As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents dgLinea As New System.Windows.Forms.DataGridView()
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTotalFactura As TextBox
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents tipo As DataGridViewTextBoxColumn
    Friend WithEvents precioTotal As DataGridViewTextBoxColumn
    Friend WithEvents existencias As DataGridViewTextBoxColumn
    Friend WithEvents tipoIndex As DataGridViewTextBoxColumn
    Friend WithEvents lblModificaPrecio As LinkLabel
    Friend WithEvents lblTotalImpuesto As Label
    Friend WithEvents txtTotalImpuesto As TextBox
End Class
