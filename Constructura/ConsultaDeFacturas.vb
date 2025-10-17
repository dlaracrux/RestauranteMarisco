Imports System.Drawing.Printing
Imports BusinessEntities
Imports BusinessLayer

Public Class ConsultaDeFacturas
    Dim elIdFacturaSeleccionada As Integer
    Dim elIndexDeFacturaSeleccionada As Integer
    Dim laFacturaSeleccionada As BEFacturas
    Dim Lineasocupa As Integer = 0

    Private Sub chkCodigo_CheckedChanged(sender As Object, e As EventArgs) Handles chkCodigo.CheckedChanged
        If chkCodigo.Checked Then
            txtCodigo.Enabled = True
            txtCodigo.Text = "0"
            txtCodigo.Focus()
            txtCodigo.Select()
        Else
            txtCodigo.Enabled = False
            txtCodigo.Text = ""
        End If
    End Sub

    Private Sub chkNombre_CheckedChanged(sender As Object, e As EventArgs) Handles chkNombreCliente.CheckedChanged
        If chkNombreCliente.Checked Then
            txtNombre.Enabled = True
            txtNombre.Focus()
        Else
            txtNombre.Enabled = False
            txtNombre.Text = ""
        End If
    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub chkFechas_CheckedChanged(sender As Object, e As EventArgs) Handles chkFechas.CheckedChanged
        If chkFechas.Checked Then
            dpFechaInicial.Enabled = True
            dpFechaFinal.Enabled = True
            dpFechaInicial.Focus()
        Else
            dpFechaInicial.Enabled = False
            dpFechaFinal.Enabled = False
            dpFechaInicial.Value = Now
            dpFechaFinal.Value = Now
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim SeSeleccionoNombre As String = "N"
        Dim SeSeleccionoCodigo As String = "N"
        Dim SeSeleccionoFechas As String = "N"
        Dim elCampoCodigo As Integer

        If chkCodigo.Checked Then
            SeSeleccionoCodigo = "S"
            If txtCodigo.Text = "" Then
                elCampoCodigo = 0
            Else
                Integer.TryParse(txtCodigo.Text, elCampoCodigo)
            End If
        End If

        If chkFechas.Checked Then
            SeSeleccionoFechas = "S"
        End If

        If chkNombreCliente.Checked Then
            SeSeleccionoNombre = "S"
        End If

        Dim laInstanciaDeFactura As New BLFacturas
        dgFacturas.DataSource = laInstanciaDeFactura.CargueLaConsultaDeFacturasPorFiltros(SeSeleccionoCodigo,
                                                                                          SeSeleccionoNombre,
                                                                                          SeSeleccionoFechas,
                                                                                          elCampoCodigo,
                                                                                          txtNombre.Text,
                                                                                          dpFechaInicial.Text,
                                                                                          dpFechaFinal.Text)
        If dgFacturas.Rows.Count = 0 Then
            MsgBox("No se han encontrado facturas", MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnReimprimir.Click
        If elIdFacturaSeleccionada > 0 Then
            If MsgBox("¿Desea reimprimir la factura : " + CStr(elIdFacturaSeleccionada) + "?", vbYesNo + vbInformation + vbDefaultButton2, "Confirmacion") = vbYes Then
                CargarDatosDeFacturaSeleccionada(elIndexDeFacturaSeleccionada)
                If laFacturaSeleccionada.Lineas.Count > 0 Then
                    With ReimpresionFactura
                        .PrinterSettings.DefaultPageSettings.Landscape = False
                        .PrintController = New System.Drawing.Printing.StandardPrintController()
                        .Print()
                    End With
                Else
                    MsgBox("La factura seleccionada no contiene líneas", MessageBoxIcon.Warning)
                End If
            End If
        Else
            MsgBox("Debe seleccionar una factura", MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub Mantenimiento_Beneficiarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimpiarCampos()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        LimpiarCampos()
    End Sub
    Private Sub LimpiarCampos()
        dgFacturas.DataSource = Nothing
        btnReimprimir.Enabled = False
        elIdFacturaSeleccionada = 0
        elIndexDeFacturaSeleccionada = 0
        dgFacturas.AutoGenerateColumns = False
        chkCodigo.Checked = False
        chkNombreCliente.Checked = False
        chkFechas.Checked = False
        txtCodigo.Text = ""
        txtNombre.Text = ""
        dpFechaInicial.Value = Now
        dpFechaFinal.Value = Now
    End Sub
    Private Sub dgFacturas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgFacturas.CellClick
        For elIndice As Integer = 0 To dgFacturas.Rows.Count - 1
            If elIndice <> e.RowIndex Then
                dgFacturas.Rows.Item(elIndice).Cells.Item(0).Value = False
            End If
        Next
        If e.RowIndex >= 0 Then
            dgFacturas.Rows.Item(e.RowIndex).Cells.Item(0).Value = True
            elIdFacturaSeleccionada = dgFacturas.Rows.Item(e.RowIndex).Cells.Item("codigoFactura").Value
            elIndexDeFacturaSeleccionada = e.RowIndex
            CargarDatosDeFacturaSeleccionada(e.RowIndex)
            btnReimprimir.Enabled = True
        End If
    End Sub

    Private Sub dgFacturas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgFacturas.CellDoubleClick
        If dgFacturas.Rows().Count > 0 Then
            CargarDatosDeFacturaSeleccionada(e.RowIndex)
            Dim frmDetalle As New FrmDetalleFactura
            frmDetalle.CargueElGridConElDetalle(laFacturaSeleccionada.Lineas)
            Dim result = frmDetalle.ShowDialog()
            If result = DialogResult.OK Then
            End If
        End If
    End Sub

    Sub CargarDatosDeFacturaSeleccionada(e As Integer)
        Dim laInstanciaDeFactura As New BLFacturas
        laFacturaSeleccionada = New BEFacturas
        laFacturaSeleccionada.Codigo = CInt(dgFacturas.Item("codigoFactura", e).Value)
        laFacturaSeleccionada.CedulaCliente = dgFacturas.Item("cliente", e).Value
        laFacturaSeleccionada.FechaFactura = CDate(dgFacturas.Item("fechaFactura", e).Value)
        laFacturaSeleccionada.NombreCliente = dgFacturas.Item("cliente", e).Value
        laFacturaSeleccionada.TotalFactura = dgFacturas.Item("totalFactura", e).Value
        laFacturaSeleccionada.TotalImpuesto = dgFacturas.Item("totalImpuesto", e).Value
        laFacturaSeleccionada.Vendedor = dgFacturas.Item("vendedor", e).Value
        laFacturaSeleccionada.FormaDePago = dgFacturas.Item("formaDePago", e).Value
        laFacturaSeleccionada.Caja = dgFacturas.Item("cajas", e).Value
        laFacturaSeleccionada.Lineas = New List(Of BEFacturaLinea)
        laFacturaSeleccionada.Lineas = laInstanciaDeFactura.CargueElDetalleDeLaFacturaSeleccionada(laFacturaSeleccionada.Codigo)
    End Sub

    Private Sub ReimpresionFactura_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles ReimpresionFactura.PrintPage

        Dim Mensaje As String
        Dim Num_Linea As Integer = 2
        Dim fuente = New System.Drawing.Font("Arial", 10, FontStyle.Bold)
        Dim xPos, yPos As Integer
        Dim altoNecesario As Single


        Dim Textlayout As New System.Drawing.StringFormat

        e.PageSettings.PrinterSettings.PrinterName = "FACTURAS"
        e.PageSettings.Margins.Top = 0
        e.PageSettings.Margins.Left = 0

        e.PageSettings.Landscape = False

        fuente = New System.Drawing.Font("Arial", 12, FontStyle.Bold)
        Mensaje = "REIMPRESIÓN"
        e.Graphics.DrawString(Mensaje, fuente, Brushes.Black, 70, Num_Linea)
        Num_Linea += e.Graphics.MeasureString(Mensaje, fuente).Height
        Num_Linea += e.Graphics.MeasureString(Mensaje, fuente).Height

        ' Tipo de Factura
        fuente = New System.Drawing.Font("Arial", 16, FontStyle.Bold)
        Mensaje = "Rancho Del Marisco"
        e.Graphics.DrawString(Mensaje, fuente, Brushes.Black, 1, Num_Linea)
        Num_Linea += e.Graphics.MeasureString(Mensaje, fuente).Height

        fuente = New System.Drawing.Font("Arial", 9, FontStyle.Regular)


        Mensaje = "                         Tel: 87959109 "
        e.Graphics.DrawString(Mensaje, fuente, Brushes.Black, 1, Num_Linea)
        Num_Linea += e.Graphics.MeasureString(Mensaje, fuente).Height

        Mensaje = "                 Cariari, Pococí, Limón "
        e.Graphics.DrawString(Mensaje, fuente, Brushes.Black, 1, Num_Linea)
        Num_Linea += e.Graphics.MeasureString(Mensaje, fuente).Height

        Mensaje = "    Correo: delmariscorancho@gmail.com"
        e.Graphics.DrawString(Mensaje, fuente, Brushes.Black, 1, Num_Linea)
        Num_Linea += e.Graphics.MeasureString(Mensaje, fuente).Height

        Mensaje = "                 FACTURA CONTADO: " & laFacturaSeleccionada.Codigo
        e.Graphics.DrawString(Mensaje, fuente, Brushes.Black, 1, Num_Linea)
        Num_Linea += e.Graphics.MeasureString(Mensaje, fuente).Height
        Num_Linea += e.Graphics.MeasureString(Mensaje, fuente).Height

        Mensaje = "Fecha Factura:  " & laFacturaSeleccionada.FechaFactura.ToString("dd/MM/yyyy")
        e.Graphics.DrawString(Mensaje, fuente, Brushes.Black, 1, Num_Linea)
        Num_Linea += e.Graphics.MeasureString(Mensaje, fuente).Height

        Mensaje = "-----------------------------------------------------------------"
        e.Graphics.DrawString(Mensaje, fuente, Brushes.Black, 1, Num_Linea)
        Num_Linea += e.Graphics.MeasureString(Mensaje, fuente).Height
        Num_Linea += e.Graphics.MeasureString(Mensaje, fuente).Height

        ' nombre de cliente
        Mensaje = "Cliente:"
        e.Graphics.DrawString(Mensaje, fuente, Brushes.Black, 1, Num_Linea)
        Num_Linea += e.Graphics.MeasureString(Mensaje, fuente).Height

        Mensaje = "     " & laFacturaSeleccionada.NombreCliente
        e.Graphics.DrawString(Mensaje, fuente, Brushes.Black, 1, Num_Linea)
        Num_Linea += e.Graphics.MeasureString(Mensaje, fuente).Height

        ' Número de caja
        Mensaje = "Caja: "
        e.Graphics.DrawString(Mensaje, fuente, Brushes.Black, 1, Num_Linea)
        Num_Linea += e.Graphics.MeasureString(Mensaje, fuente).Height

        ' Número de caja
        Mensaje = "     " & laFacturaSeleccionada.Caja
        e.Graphics.DrawString(Mensaje, fuente, Brushes.Black, 1, Num_Linea)
        Num_Linea += e.Graphics.MeasureString(Mensaje, fuente).Height

        ' Vendedor
        Mensaje = "Vendedor: "
        e.Graphics.DrawString(Mensaje, fuente, Brushes.Black, 1, Num_Linea)
        Num_Linea += e.Graphics.MeasureString(Mensaje, fuente).Height

        ' Vendedor
        Mensaje = "     " & laFacturaSeleccionada.Vendedor.ToUpper
        e.Graphics.DrawString(Mensaje, fuente, Brushes.Black, 1, Num_Linea)
        Num_Linea += e.Graphics.MeasureString(Mensaje, fuente).Height
        Num_Linea += e.Graphics.MeasureString(Mensaje, fuente).Height

        Mensaje = "CANT        PRODUCTO                   P.UNIDAD"
        e.Graphics.DrawString(Mensaje, fuente, Brushes.Black, 1, Num_Linea)
        Num_Linea += e.Graphics.MeasureString(Mensaje, fuente).Height

        Mensaje = "-----------------------------------------------------------------"
        e.Graphics.DrawString(Mensaje, fuente, Brushes.Black, 1, Num_Linea)
        Num_Linea += e.Graphics.MeasureString(Mensaje, fuente).Height

        Textlayout.Alignment = StringAlignment.Far

        For Each linea As BEFacturaLinea In laFacturaSeleccionada.Lineas

            Mensaje = Format(linea.Cantidad, "0.00")
            e.Graphics.DrawString(Mensaje, fuente, Brushes.Black, 1, Num_Linea)
            yPos = Num_Linea
            xPos = 55

            altoNecesario = calcularAltoNecesario(linea.NombreArticulo, fuente, e, e.MarginBounds.Right - (xPos + 10))

            e.Graphics.DrawString(linea.NombreArticulo, fuente, Brushes.Black, New RectangleF(xPos, yPos, e.MarginBounds.Right - xPos, altoNecesario))

            Mensaje = Space(13 - Len(Format(linea.PrecioTotalLinea, "##,###,##0.00").ToString)) & Format(linea.PrecioTotalLinea, "##,###,##0.00").ToString
            e.Graphics.DrawString(Mensaje, fuente, Brushes.Black, 190, Num_Linea)



            Num_Linea += altoNecesario
        Next
        Num_Linea += e.Graphics.MeasureString(Mensaje, fuente).Height
        Mensaje = "-----------------------------------------------------------------"
        e.Graphics.DrawString(Mensaje, fuente, Brushes.Black, 1, Num_Linea)
        Num_Linea += e.Graphics.MeasureString(Mensaje, fuente).Height
        Num_Linea += e.Graphics.MeasureString(Mensaje, fuente).Height


        '*************************************************************************
        '  Imprime las líneas de la factura
        '*************************************************************************

        'SUBTOTAL
        fuente = New System.Drawing.Font("Arial", 9, FontStyle.Bold)
        Mensaje = "SUBTOTAL:   " & Format(CDbl(laFacturaSeleccionada.TotalFactura) - CDbl(laFacturaSeleccionada.TotalImpuesto), "₡###,###,##0.00")
        e.Graphics.DrawString(Mensaje, fuente, Brushes.Black, 5, Num_Linea)
        Num_Linea += e.Graphics.MeasureString(Mensaje, fuente).Height


        'Total Impuesto
        fuente = New System.Drawing.Font("Arial", 9, FontStyle.Bold)
        Mensaje = "TOTAL IMPUESTO:   " & Format(laFacturaSeleccionada.TotalImpuesto, "₡###,###,##0.00")
        e.Graphics.DrawString(Mensaje, fuente, Brushes.Black, 5, Num_Linea)
        Num_Linea += e.Graphics.MeasureString(Mensaje, fuente).Height


        'Total
        fuente = New System.Drawing.Font("Arial", 9, FontStyle.Bold)
        Mensaje = "TOTAL:   " & Format(laFacturaSeleccionada.TotalFactura, "₡###,###,##0.00")
        e.Graphics.DrawString(Mensaje, fuente, Brushes.Black, 5, Num_Linea)
        Num_Linea += e.Graphics.MeasureString(Mensaje, fuente).Height
        Num_Linea += e.Graphics.MeasureString(Mensaje, fuente).Height


        'Forma Pago
        Mensaje = "Forma Pago:   " & laFacturaSeleccionada.FormaDePago.ToUpper
        e.Graphics.DrawString(Mensaje, fuente, Brushes.Black, 5, Num_Linea)


    End Sub

    Private Function calcularAltoNecesario(ByVal strTexto As String, ByVal fuenteA As Font,
                                       ByVal e As PrintPageEventArgs, ByVal espacioDisponible As Single) As Single


        If e.Graphics.MeasureString(strTexto, fuenteA).Width > espacioDisponible Then
            'Varias lineas
            Dim numLineas1 As Single = e.Graphics.MeasureString(strTexto, fuenteA).Width / espacioDisponible

            If (numLineas1 - CInt(numLineas1)) > 0 Then
                numLineas1 += 1
            End If

            Lineasocupa = numLineas1 * 10

            Return e.Graphics.MeasureString(strTexto, fuenteA).Height * CInt(numLineas1)
        End If

        'Una linea
        Lineasocupa = 10

        Return e.Graphics.MeasureString(strTexto, fuenteA).Height
    End Function
End Class