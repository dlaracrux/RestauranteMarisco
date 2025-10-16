<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCambiarPrecioUnitario
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
        Me.btnCambiar = New System.Windows.Forms.Button()
        Me.txtPrecioNuevo = New System.Windows.Forms.TextBox()
        Me.ReimpresionFactura = New System.Drawing.Printing.PrintDocument()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCambiar
        '
        Me.btnCambiar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCambiar.BackColor = System.Drawing.Color.SeaGreen
        Me.btnCambiar.FlatAppearance.BorderSize = 0
        Me.btnCambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCambiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambiar.ForeColor = System.Drawing.Color.White
        Me.btnCambiar.Location = New System.Drawing.Point(272, 20)
        Me.btnCambiar.Name = "btnCambiar"
        Me.btnCambiar.Size = New System.Drawing.Size(153, 35)
        Me.btnCambiar.TabIndex = 154
        Me.btnCambiar.Text = "Cambiar"
        Me.btnCambiar.UseVisualStyleBackColor = False
        '
        'txtPrecioNuevo
        '
        Me.txtPrecioNuevo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtPrecioNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioNuevo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtPrecioNuevo.Location = New System.Drawing.Point(28, 28)
        Me.txtPrecioNuevo.MaxLength = 20
        Me.txtPrecioNuevo.Name = "txtPrecioNuevo"
        Me.txtPrecioNuevo.Size = New System.Drawing.Size(207, 23)
        Me.txtPrecioNuevo.TabIndex = 162
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.btnCambiar)
        Me.GroupBox1.Controls.Add(Me.txtPrecioNuevo)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(37, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(456, 74)
        Me.GroupBox1.TabIndex = 169
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "   Nuevo Precio  "
        '
        'FrmCambiarPrecioUnitario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(521, 104)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmCambiarPrecioUnitario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Precio"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCambiar As Button
    Friend WithEvents txtPrecioNuevo As TextBox
    Friend WithEvents ReimpresionFactura As Printing.PrintDocument
    Friend WithEvents GroupBox1 As GroupBox
End Class
