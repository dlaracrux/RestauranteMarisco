Imports System.Drawing.Printing
Imports BusinessEntities
Imports BusinessLayer

Public Class FrmFormaPago
    Public elCodigoFacturaSeleccionada As Integer
    Dim Pagacon As Double
    Dim Vuelto As Double = 0
    Dim blCajas As New BLCajas
    Public laFacturaSeleccionada As BEFacturas
    Public laCaja As String
    Dim Lineasocupa As Integer = 0


    Private Sub FrmConsultaDocuCxP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaElComboFormaPago()
        txtMontoPago.Text = Format(0, "0.00")
        lblVuelto.Text = Format(0, "₡###,###,##0.00")
    End Sub

    Private Sub CargaElComboFormaPago()
        cmbFormaPago.Items.Clear()
        cmbFormaPago.Items.Insert(0, "Efectivo")
        cmbFormaPago.Items.Insert(1, "Tarjeta")
        cmbFormaPago.Items.Insert(2, "Sinpe Móvil")
        cmbFormaPago.SelectedIndex = 0
    End Sub
    Sub cargarDatos(e As Integer)

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim elMontoAPagar As Double = 0
        Dim elMontoDeLaFactura As Double = 0
        Double.TryParse(txtMontoPago.Text, elMontoAPagar)
        Double.TryParse(lblTotalFactura.Text, elMontoDeLaFactura)

        If elMontoAPagar <= 0 Then
            MsgBox("El monto a pagar debe ser mayor a 0.00", MsgBoxStyle.Exclamation)
            Exit Sub
        ElseIf elMontoAPagar < elMontoDeLaFactura Then
            MsgBox("El monto a pagar no puede ser menor al total de la factura", MsgBoxStyle.Exclamation)
            Exit Sub
        Else
            If blCajas.ProceseLaFacturaSeleccionada(elCodigoFacturaSeleccionada, Environment.MachineName, cmbFormaPago.SelectedItem, atBEUsuario.IdUsuario) Then
                laFacturaSeleccionada.FormaDePago = cmbFormaPago.SelectedItem
                If laFacturaSeleccionada.Lineas.Count > 0 Then
                    With ImpresionFactura
                        .PrinterSettings.DefaultPageSettings.Landscape = False
                        .PrintController = New System.Drawing.Printing.StandardPrintController()
                        .Print()
                    End With
                Else
                    MsgBox("La factura seleccionada no contiene líneas", MessageBoxIcon.Warning)
                End If

                DialogResult = DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub



    Private Sub txtMontoPago_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMontoPago.KeyPress
        Dim punto As Boolean = IIf(InStr(txtMontoPago.Text, ".", CompareMethod.Text) > 0, True, False)
        If Asc(e.KeyChar) = 13 Then
            Totales()
            btnGuardar.Focus()
        Else
            If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = ""
            ElseIf e.KeyChar = "." And punto = True Then
                e.KeyChar = ""
            End If
        End If
    End Sub
    Sub Totales()
        Pagacon = ValidaMOnto(txtMontoPago)
        Vuelto = (CDec(lblTotalFactura.Text) - Pagacon) * -1
        If (FormatNumber(Vuelto, 2, TriState.True, TriState.False, TriState.UseDefault) < 0) Then
            lblVuelto.Text = Format(0, "₡###,###,##0.00")
        Else
            lblVuelto.Text = Format(Vuelto, "₡###,###,##0.00")
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub cmbFormaPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFormaPago.SelectedIndexChanged
        txtMontoPago.Text = Format(0, "0.00")
        lblVuelto.Text = Format(0, "₡###,###,##0.00")
        txtMontoPago.Focus()
        txtMontoPago.Select()

    End Sub

    Function ValidaMOnto(ByRef monto As Control) As Double
        Dim ValorRetorno As Double = 0
        If Len(Trim(monto.Text)) > 0 Then
            ValorRetorno = Convert.ToDouble(Trim(monto.Text))
        End If
        monto.Text = FormatNumber(ValorRetorno, 2, TriState.True, TriState.False, TriState.UseDefault)
        Return ValorRetorno
    End Function

    Private Sub ImpresionFactura_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles ImpresionFactura.PrintPage

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

        ' Tipo de Factura
        fuente = New System.Drawing.Font("Arial", 16, FontStyle.Bold)
        Mensaje = "Restaurante Del Marisco"
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