Public Class BEFacturas
	Public Codigo As Integer
	Public NombreCliente As String
	Public FechaFactura As Date
	Public CedulaCliente As String
	Public Usuario As Integer
	Public TotalFactura As Decimal
	Public FormaDePago As String
	Public Vendedor As String
	Public Caja As String
	Public Estado As String
	Public Lineas As List(Of BEFacturaLinea)

End Class
