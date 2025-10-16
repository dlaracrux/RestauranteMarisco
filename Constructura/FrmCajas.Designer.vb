<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCajas
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgFacturas = New System.Windows.Forms.DataGridView()
        Me.seleccionaFactura = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn()
        Me.codigoFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vendedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lEstadoMoneda = New System.Windows.Forms.Label()
        Me.lNombreMoneda = New System.Windows.Forms.Label()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.panelAbrirCaja = New System.Windows.Forms.Panel()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMontoInicial = New System.Windows.Forms.TextBox()
        Me.txtFechaInicial = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCaja = New System.Windows.Forms.TextBox()
        Me.panelFacturas = New System.Windows.Forms.Panel()
        Me.lblPendientes = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnCerrarCaja = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelAbrirCaja.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.panelFacturas.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1051, 40)
        Me.Panel1.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(13, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = ">> Cajas"
        '
        'dgFacturas
        '
        Me.dgFacturas.AllowUserToAddRows = False
        Me.dgFacturas.AllowUserToDeleteRows = False
        Me.dgFacturas.AllowUserToResizeRows = False
        Me.dgFacturas.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dgFacturas.BackgroundColor = System.Drawing.Color.SkyBlue
        Me.dgFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgFacturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.seleccionaFactura, Me.codigoFactura, Me.cliente, Me.fechaFactura, Me.totalFactura, Me.vendedor})
        Me.dgFacturas.Location = New System.Drawing.Point(17, 40)
        Me.dgFacturas.MultiSelect = False
        Me.dgFacturas.Name = "dgFacturas"
        Me.dgFacturas.ReadOnly = True
        Me.dgFacturas.RowHeadersWidth = 5
        Me.dgFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgFacturas.Size = New System.Drawing.Size(990, 484)
        Me.dgFacturas.TabIndex = 131
        '
        'seleccionaFactura
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.NullValue = False
        Me.seleccionaFactura.DefaultCellStyle = DataGridViewCellStyle1
        Me.seleccionaFactura.FalseValue = Nothing
        Me.seleccionaFactura.HeaderText = ""
        Me.seleccionaFactura.IndeterminateValue = Nothing
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
        Me.vendedor.Name = "vendedor"
        Me.vendedor.ReadOnly = True
        Me.vendedor.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.vendedor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.vendedor.Width = 300
        '
        'lEstadoMoneda
        '
        Me.lEstadoMoneda.AutoSize = True
        Me.lEstadoMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lEstadoMoneda.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lEstadoMoneda.Location = New System.Drawing.Point(56, 82)
        Me.lEstadoMoneda.Name = "lEstadoMoneda"
        Me.lEstadoMoneda.Size = New System.Drawing.Size(28, 13)
        Me.lEstadoMoneda.TabIndex = 126
        Me.lEstadoMoneda.Text = "Caja"
        '
        'lNombreMoneda
        '
        Me.lNombreMoneda.AutoSize = True
        Me.lNombreMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lNombreMoneda.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lNombreMoneda.Location = New System.Drawing.Point(41, 47)
        Me.lNombreMoneda.Name = "lNombreMoneda"
        Me.lNombreMoneda.Size = New System.Drawing.Size(43, 13)
        Me.lNombreMoneda.TabIndex = 125
        Me.lNombreMoneda.Text = "Usuario"
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.Enabled = False
        Me.txtNombreUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreUsuario.Location = New System.Drawing.Point(102, 43)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.Size = New System.Drawing.Size(176, 20)
        Me.txtNombreUsuario.TabIndex = 0
        '
        'panelAbrirCaja
        '
        Me.panelAbrirCaja.Controls.Add(Me.btnCerrar)
        Me.panelAbrirCaja.Controls.Add(Me.btnIniciar)
        Me.panelAbrirCaja.Controls.Add(Me.GroupBox1)
        Me.panelAbrirCaja.Location = New System.Drawing.Point(0, 46)
        Me.panelAbrirCaja.Name = "panelAbrirCaja"
        Me.panelAbrirCaja.Size = New System.Drawing.Size(1037, 600)
        Me.panelAbrirCaja.TabIndex = 0
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCerrar.BackColor = System.Drawing.Color.Brown
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Location = New System.Drawing.Point(538, 307)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(153, 32)
        Me.btnCerrar.TabIndex = 132
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnIniciar
        '
        Me.btnIniciar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnIniciar.BackColor = System.Drawing.Color.SeaGreen
        Me.btnIniciar.FlatAppearance.BorderSize = 0
        Me.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIniciar.ForeColor = System.Drawing.Color.White
        Me.btnIniciar.Location = New System.Drawing.Point(366, 307)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(153, 32)
        Me.btnIniciar.TabIndex = 131
        Me.btnIniciar.Text = "Iniciar"
        Me.btnIniciar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.txtMontoInicial)
        Me.GroupBox1.Controls.Add(Me.txtFechaInicial)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCaja)
        Me.GroupBox1.Controls.Add(Me.txtNombreUsuario)
        Me.GroupBox1.Controls.Add(Me.lEstadoMoneda)
        Me.GroupBox1.Controls.Add(Me.lNombreMoneda)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(181, 98)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(682, 135)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "  Datos Apertura Caja  "
        '
        'txtMontoInicial
        '
        Me.txtMontoInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoInicial.Location = New System.Drawing.Point(427, 78)
        Me.txtMontoInicial.Name = "txtMontoInicial"
        Me.txtMontoInicial.Size = New System.Drawing.Size(176, 20)
        Me.txtMontoInicial.TabIndex = 4
        '
        'txtFechaInicial
        '
        Me.txtFechaInicial.Enabled = False
        Me.txtFechaInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaInicial.Location = New System.Drawing.Point(427, 43)
        Me.txtFechaInicial.Name = "txtFechaInicial"
        Me.txtFechaInicial.Size = New System.Drawing.Size(176, 20)
        Me.txtFechaInicial.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(343, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 129
        Me.Label3.Text = "Monto Inicial"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(373, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 128
        Me.Label2.Text = "Fecha"
        '
        'txtCaja
        '
        Me.txtCaja.Enabled = False
        Me.txtCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCaja.Location = New System.Drawing.Point(102, 78)
        Me.txtCaja.Name = "txtCaja"
        Me.txtCaja.Size = New System.Drawing.Size(176, 20)
        Me.txtCaja.TabIndex = 1
        '
        'panelFacturas
        '
        Me.panelFacturas.Controls.Add(Me.lblPendientes)
        Me.panelFacturas.Controls.Add(Me.btnActualizar)
        Me.panelFacturas.Controls.Add(Me.btnCerrarCaja)
        Me.panelFacturas.Controls.Add(Me.Label5)
        Me.panelFacturas.Controls.Add(Me.dgFacturas)
        Me.panelFacturas.Controls.Add(Me.btnSalir)
        Me.panelFacturas.Controls.Add(Me.btnProcesar)
        Me.panelFacturas.Location = New System.Drawing.Point(17, 49)
        Me.panelFacturas.Name = "panelFacturas"
        Me.panelFacturas.Size = New System.Drawing.Size(1017, 594)
        Me.panelFacturas.TabIndex = 133
        '
        'lblPendientes
        '
        Me.lblPendientes.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblPendientes.AutoSize = True
        Me.lblPendientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPendientes.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblPendientes.Location = New System.Drawing.Point(829, 11)
        Me.lblPendientes.Name = "lblPendientes"
        Me.lblPendientes.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblPendientes.Size = New System.Drawing.Size(181, 18)
        Me.lblPendientes.TabIndex = 134
        Me.lblPendientes.Text = "Facturas Pendientes: 0"
        '
        'btnActualizar
        '
        Me.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnActualizar.BackColor = System.Drawing.Color.SeaGreen
        Me.btnActualizar.Enabled = False
        Me.btnActualizar.FlatAppearance.BorderSize = 0
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.ForeColor = System.Drawing.Color.White
        Me.btnActualizar.Location = New System.Drawing.Point(17, 544)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(153, 32)
        Me.btnActualizar.TabIndex = 133
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'btnCerrarCaja
        '
        Me.btnCerrarCaja.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCerrarCaja.BackColor = System.Drawing.Color.Chocolate
        Me.btnCerrarCaja.FlatAppearance.BorderSize = 0
        Me.btnCerrarCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarCaja.ForeColor = System.Drawing.Color.White
        Me.btnCerrarCaja.Location = New System.Drawing.Point(854, 544)
        Me.btnCerrarCaja.Name = "btnCerrarCaja"
        Me.btnCerrarCaja.Size = New System.Drawing.Size(153, 32)
        Me.btnCerrarCaja.TabIndex = 132
        Me.btnCerrarCaja.Text = "Cerrar Caja"
        Me.btnCerrarCaja.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(13, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(321, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Seleccione una factura que desee procesar:"
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSalir.BackColor = System.Drawing.Color.Brown
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(499, 544)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(153, 32)
        Me.btnSalir.TabIndex = 130
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnProcesar
        '
        Me.btnProcesar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnProcesar.BackColor = System.Drawing.Color.SeaGreen
        Me.btnProcesar.Enabled = False
        Me.btnProcesar.FlatAppearance.BorderSize = 0
        Me.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcesar.ForeColor = System.Drawing.Color.White
        Me.btnProcesar.Location = New System.Drawing.Point(327, 544)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(153, 32)
        Me.btnProcesar.TabIndex = 129
        Me.btnProcesar.Text = "Procesar"
        Me.btnProcesar.UseVisualStyleBackColor = False
        '
        'FrmCajas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1051, 660)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelFacturas)
        Me.Controls.Add(Me.panelAbrirCaja)
        Me.Name = "FrmCajas"
        Me.Text = "Cajas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelAbrirCaja.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.panelFacturas.ResumeLayout(False)
        Me.panelFacturas.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents dgFacturas As New System.Windows.Forms.DataGridView()
    Friend WithEvents lEstadoMoneda As Label
    Friend WithEvents lNombreMoneda As Label
    Friend WithEvents txtNombreUsuario As TextBox
    Friend WithEvents panelAbrirCaja As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtMontoInicial As TextBox
    Friend WithEvents txtFechaInicial As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCaja As TextBox
    Friend WithEvents panelFacturas As Panel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnIniciar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnProcesar As Button
    Friend WithEvents btnCerrarCaja As Button
    Friend WithEvents seleccionaFactura As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn
    Friend WithEvents codigoFactura As DataGridViewTextBoxColumn
    Friend WithEvents cliente As DataGridViewTextBoxColumn
    Friend WithEvents fechaFactura As DataGridViewTextBoxColumn
    Friend WithEvents totalFactura As DataGridViewTextBoxColumn
    Friend WithEvents vendedor As DataGridViewTextBoxColumn
    Friend WithEvents btnActualizar As Button
    Friend WithEvents lblPendientes As Label
End Class
