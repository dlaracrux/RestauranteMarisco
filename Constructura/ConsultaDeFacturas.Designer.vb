<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaDeFacturas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnReimprimir = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.chkNombreCliente = New System.Windows.Forms.CheckBox()
        Me.chkCodigo = New System.Windows.Forms.CheckBox()
        Me.btnBuscar = New FontAwesome.Sharp.IconButton()
        Me.ReimpresionFactura = New System.Drawing.Printing.PrintDocument()
        Me.chkFechas = New System.Windows.Forms.CheckBox()
        Me.dpFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.dpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.dgFacturas = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.seleccionaFactura = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn()
        Me.codigoFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vendedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cajas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.formaDePago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalImpuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCerrar.BackColor = System.Drawing.Color.Maroon
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Location = New System.Drawing.Point(493, 584)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(153, 35)
        Me.btnCerrar.TabIndex = 155
        Me.btnCerrar.Text = "Limpiar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnReimprimir
        '
        Me.btnReimprimir.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnReimprimir.BackColor = System.Drawing.Color.SeaGreen
        Me.btnReimprimir.Enabled = False
        Me.btnReimprimir.FlatAppearance.BorderSize = 0
        Me.btnReimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReimprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReimprimir.ForeColor = System.Drawing.Color.White
        Me.btnReimprimir.Location = New System.Drawing.Point(305, 584)
        Me.btnReimprimir.Name = "btnReimprimir"
        Me.btnReimprimir.Size = New System.Drawing.Size(153, 35)
        Me.btnReimprimir.TabIndex = 154
        Me.btnReimprimir.Text = "Reimprimir"
        Me.btnReimprimir.UseVisualStyleBackColor = False
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtNombre.Enabled = False
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtNombre.Location = New System.Drawing.Point(170, 53)
        Me.txtNombre.MaxLength = 20
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(207, 23)
        Me.txtNombre.TabIndex = 164
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(20, 571)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(194, 17)
        Me.Label6.TabIndex = 163
        Me.Label6.Text = "Doble click para ver el detalle"
        '
        'txtCodigo
        '
        Me.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtCodigo.Location = New System.Drawing.Point(170, 25)
        Me.txtCodigo.MaxLength = 20
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(207, 23)
        Me.txtCodigo.TabIndex = 162
        '
        'chkNombreCliente
        '
        Me.chkNombreCliente.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkNombreCliente.AutoSize = True
        Me.chkNombreCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNombreCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.chkNombreCliente.Location = New System.Drawing.Point(21, 55)
        Me.chkNombreCliente.Name = "chkNombreCliente"
        Me.chkNombreCliente.Size = New System.Drawing.Size(127, 21)
        Me.chkNombreCliente.TabIndex = 161
        Me.chkNombreCliente.Text = "Nombre Cliente"
        Me.chkNombreCliente.UseVisualStyleBackColor = True
        '
        'chkCodigo
        '
        Me.chkCodigo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkCodigo.AutoSize = True
        Me.chkCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCodigo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.chkCodigo.Location = New System.Drawing.Point(21, 27)
        Me.chkCodigo.Name = "chkCodigo"
        Me.chkCodigo.Size = New System.Drawing.Size(132, 21)
        Me.chkCodigo.TabIndex = 160
        Me.chkCodigo.Text = "Número Factura"
        Me.chkCodigo.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnBuscar.BackColor = System.Drawing.Color.SeaGreen
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.btnBuscar.IconColor = System.Drawing.Color.White
        Me.btnBuscar.IconSize = 25
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnBuscar.Location = New System.Drawing.Point(763, 78)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnBuscar.Rotation = 0R
        Me.btnBuscar.Size = New System.Drawing.Size(122, 34)
        Me.btnBuscar.TabIndex = 159
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'ReimpresionFactura
        '
        '
        'chkFechas
        '
        Me.chkFechas.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkFechas.AutoSize = True
        Me.chkFechas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFechas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.chkFechas.Location = New System.Drawing.Point(21, 85)
        Me.chkFechas.Name = "chkFechas"
        Me.chkFechas.Size = New System.Drawing.Size(122, 21)
        Me.chkFechas.TabIndex = 165
        Me.chkFechas.Text = "Rango Fechas"
        Me.chkFechas.UseVisualStyleBackColor = True
        '
        'dpFechaInicial
        '
        Me.dpFechaInicial.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dpFechaInicial.CustomFormat = "dd/MM/yyyy"
        Me.dpFechaInicial.Enabled = False
        Me.dpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpFechaInicial.Location = New System.Drawing.Point(170, 83)
        Me.dpFechaInicial.Name = "dpFechaInicial"
        Me.dpFechaInicial.Size = New System.Drawing.Size(207, 23)
        Me.dpFechaInicial.TabIndex = 166
        '
        'dpFechaFinal
        '
        Me.dpFechaFinal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dpFechaFinal.CustomFormat = "dd/MM/yyyy"
        Me.dpFechaFinal.Enabled = False
        Me.dpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpFechaFinal.Location = New System.Drawing.Point(401, 83)
        Me.dpFechaFinal.Name = "dpFechaFinal"
        Me.dpFechaFinal.Size = New System.Drawing.Size(207, 23)
        Me.dpFechaFinal.TabIndex = 167
        '
        'dgFacturas
        '
        Me.dgFacturas.AllowUserToAddRows = False
        Me.dgFacturas.AllowUserToDeleteRows = False
        Me.dgFacturas.AllowUserToResizeRows = False
        Me.dgFacturas.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dgFacturas.BackgroundColor = System.Drawing.Color.SkyBlue
        Me.dgFacturas.ColumnHeadersHeight = 29
        Me.dgFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgFacturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.seleccionaFactura, Me.codigoFactura, Me.cliente, Me.fechaFactura, Me.totalFactura, Me.vendedor, Me.cajas, Me.formaDePago, Me.totalImpuesto})
        Me.dgFacturas.Location = New System.Drawing.Point(23, 148)
        Me.dgFacturas.MultiSelect = False
        Me.dgFacturas.Name = "dgFacturas"
        Me.dgFacturas.ReadOnly = True
        Me.dgFacturas.RowHeadersWidth = 5
        Me.dgFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgFacturas.Size = New System.Drawing.Size(900, 409)
        Me.dgFacturas.TabIndex = 168
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.chkCodigo)
        Me.GroupBox1.Controls.Add(Me.chkNombreCliente)
        Me.GroupBox1.Controls.Add(Me.dpFechaFinal)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.dpFechaInicial)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.chkFechas)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(23, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(900, 130)
        Me.GroupBox1.TabIndex = 169
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Filtros "
        '
        'seleccionaFactura
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.NullValue = False
        Me.seleccionaFactura.DefaultCellStyle = DataGridViewCellStyle1
        Me.seleccionaFactura.FalseValue = Nothing
        Me.seleccionaFactura.HeaderText = ""
        Me.seleccionaFactura.IndeterminateValue = Nothing
        Me.seleccionaFactura.MinimumWidth = 6
        Me.seleccionaFactura.Name = "seleccionaFactura"
        Me.seleccionaFactura.ReadOnly = True
        Me.seleccionaFactura.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.seleccionaFactura.TrueValue = Nothing
        Me.seleccionaFactura.Width = 30
        '
        'codigoFactura
        '
        Me.codigoFactura.DataPropertyName = "codigoFactura"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.codigoFactura.DefaultCellStyle = DataGridViewCellStyle2
        Me.codigoFactura.HeaderText = "Código"
        Me.codigoFactura.MinimumWidth = 6
        Me.codigoFactura.Name = "codigoFactura"
        Me.codigoFactura.ReadOnly = True
        Me.codigoFactura.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.codigoFactura.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.codigoFactura.Width = 70
        '
        'cliente
        '
        Me.cliente.DataPropertyName = "cliente"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.cliente.DefaultCellStyle = DataGridViewCellStyle3
        Me.cliente.HeaderText = "Cliente"
        Me.cliente.MinimumWidth = 6
        Me.cliente.Name = "cliente"
        Me.cliente.ReadOnly = True
        Me.cliente.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.cliente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cliente.Width = 300
        '
        'fechaFactura
        '
        Me.fechaFactura.DataPropertyName = "fechaFactura"
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.fechaFactura.DefaultCellStyle = DataGridViewCellStyle4
        Me.fechaFactura.HeaderText = "Fecha Factura"
        Me.fechaFactura.MinimumWidth = 6
        Me.fechaFactura.Name = "fechaFactura"
        Me.fechaFactura.ReadOnly = True
        Me.fechaFactura.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.fechaFactura.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.fechaFactura.Width = 150
        '
        'totalFactura
        '
        Me.totalFactura.DataPropertyName = "totalFactura"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.totalFactura.DefaultCellStyle = DataGridViewCellStyle5
        Me.totalFactura.HeaderText = "Total Factura"
        Me.totalFactura.MinimumWidth = 6
        Me.totalFactura.Name = "totalFactura"
        Me.totalFactura.ReadOnly = True
        Me.totalFactura.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.totalFactura.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.totalFactura.Width = 130
        '
        'vendedor
        '
        Me.vendedor.DataPropertyName = "vendedor"
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.vendedor.DefaultCellStyle = DataGridViewCellStyle6
        Me.vendedor.HeaderText = "Vendedor"
        Me.vendedor.MinimumWidth = 6
        Me.vendedor.Name = "vendedor"
        Me.vendedor.ReadOnly = True
        Me.vendedor.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.vendedor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.vendedor.Width = 300
        '
        'cajas
        '
        Me.cajas.DataPropertyName = "IdMaquina"
        Me.cajas.HeaderText = "cajas"
        Me.cajas.MinimumWidth = 6
        Me.cajas.Name = "cajas"
        Me.cajas.ReadOnly = True
        Me.cajas.Visible = False
        Me.cajas.Width = 125
        '
        'formaDePago
        '
        Me.formaDePago.DataPropertyName = "FormaPago"
        Me.formaDePago.HeaderText = "formaDePago"
        Me.formaDePago.MinimumWidth = 6
        Me.formaDePago.Name = "formaDePago"
        Me.formaDePago.ReadOnly = True
        Me.formaDePago.Visible = False
        Me.formaDePago.Width = 125
        '
        'totalImpuesto
        '
        Me.totalImpuesto.DataPropertyName = "totalImpuesto"
        Me.totalImpuesto.HeaderText = "totalImpuesto"
        Me.totalImpuesto.MinimumWidth = 6
        Me.totalImpuesto.Name = "totalImpuesto"
        Me.totalImpuesto.ReadOnly = True
        Me.totalImpuesto.Visible = False
        Me.totalImpuesto.Width = 125
        '
        'ConsultaDeFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(948, 656)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgFacturas)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnReimprimir)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ConsultaDeFacturas"
        Me.Text = "Consulta Facturas"
        CType(Me.dgFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnReimprimir As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents chkNombreCliente As CheckBox
    Friend WithEvents chkCodigo As CheckBox
    Friend WithEvents btnBuscar As FontAwesome.Sharp.IconButton
    Friend WithEvents ReimpresionFactura As Printing.PrintDocument
    Friend WithEvents chkFechas As CheckBox
    Friend WithEvents dpFechaInicial As DateTimePicker
    Friend WithEvents dpFechaFinal As DateTimePicker
    Friend WithEvents dgFacturas As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents seleccionaFactura As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn
    Friend WithEvents codigoFactura As DataGridViewTextBoxColumn
    Friend WithEvents cliente As DataGridViewTextBoxColumn
    Friend WithEvents fechaFactura As DataGridViewTextBoxColumn
    Friend WithEvents totalFactura As DataGridViewTextBoxColumn
    Friend WithEvents vendedor As DataGridViewTextBoxColumn
    Friend WithEvents cajas As DataGridViewTextBoxColumn
    Friend WithEvents formaDePago As DataGridViewTextBoxColumn
    Friend WithEvents totalImpuesto As DataGridViewTextBoxColumn
End Class
