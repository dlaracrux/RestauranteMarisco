Imports BusinessEntities
Imports DataLayer

Public Class BLCajas
    Public Function VerificaSiLaCajaEstaAbierta(ByVal IdMaquina As String) As BECajas
        Dim dlCajas As New DLCajas
        Return dlCajas.VerificaSiLaCajaEstaAbierta(IdMaquina)
    End Function
    Public Function CargueLaFacturasPendientesDeCobro() As DataTable
        Dim dlCajas As New DLCajas
        Return dlCajas.CargueLaFacturasPendientesDeCobro()
    End Function

    Public Function InserteLaApertuaDeCaja(ByVal idUsuario As Integer, ByVal elMontoInicial As Double, ByVal laCaja As String) As Integer
        Dim dlCajas As New DLCajas
        Return dlCajas.InserteLaApertuaDeCaja(idUsuario, elMontoInicial, laCaja)
    End Function

    Public Function ConsulteElMontoTotalDeFacturasProcesadasEnElDia(ByVal laCaja As String) As Decimal
        Dim dlCajas As New DLCajas
        Return dlCajas.ConsulteElMontoTotalDeFacturasProcesadasEnElDia(laCaja)
    End Function

    Public Function CierreLaCaja(ByVal laCaja As String, ByVal elMontoTotalFacturas As Decimal) As Boolean
        Dim dlCajas As New DLCajas
        Return dlCajas.CierreLaCaja(laCaja, elMontoTotalFacturas)
    End Function

    Public Function ProceseLaFacturaSeleccionada(ByVal elCodigoFacturaSeleccionada As Integer, ByVal laCaja As String,
                                                 ByVal laFormaDePago As String, ByVal idUsuario As Integer) As Boolean
        Dim dlCajas As New DLCajas
        Return dlCajas.ProceseLaFacturaSeleccionada(elCodigoFacturaSeleccionada, laCaja, laFormaDePago, idUsuario)
    End Function

    Public Function EliminaLaFacturaSeleccionada(ByVal elCodigoFactura As Integer) As Boolean
        Dim dlCajas As New DLCajas
        Return dlCajas.EliminaLaFacturaSeleccionada(elCodigoFactura)
    End Function
End Class
