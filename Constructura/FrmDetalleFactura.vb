Imports BusinessEntities

Public Class FrmDetalleFactura
    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Public Sub CargueElGridConElDetalle(laListaDetalle As List(Of BEFacturaLinea))
        For Each linea As BEFacturaLinea In laListaDetalle
            dgDetalle.Rows.Add(linea.CodigoDetalle, linea.CodigoArticulo, linea.NombreArticulo, linea.Cantidad, linea.PrecioTotalLinea, linea.PrecioUnitario)
        Next
    End Sub
End Class