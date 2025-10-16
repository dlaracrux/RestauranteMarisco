Imports System.Drawing.Printing
Imports BusinessEntities
Imports BusinessLayer

Public Class FrmCajas
    Dim laCajaConsultada As New BECajas
    Dim blCajas As New BLCajas
    Dim codigoCajas As Integer = 0
    Dim elIdFacturaSeleccionada As Integer
    Dim elIndexDeFacturaSeleccionada As Integer
    Dim laFacturaSeleccionada As BEFacturas


    Private Sub Mantenimiento_Monedas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelFacturas.Visible = False
        panelAbrirCaja.Visible = False
        dgFacturas.AutoGenerateColumns = False
        laCajaConsultada = blCajas.VerificaSiLaCajaEstaAbierta(Environment.MachineName)
        If laCajaConsultada Is Nothing Then
            panelAbrirCaja.Visible = True
            txtNombreUsuario.Text = atBEUsuario.Nombre
            txtFechaInicial.Text = Now.ToString("dd/MM/yyyy")
            txtMontoInicial.Text = Format(0, "0.00")
            txtCaja.Text = Environment.MachineName
            btnActualizar.Enabled = True
            txtMontoInicial.Focus()
        ElseIf laCajaConsultada.FechaApertura.ToString("dd/MM/yyyy") = Now.ToString("dd/MM/yyyy") Then
            panelAbrirCaja.Visible = True
            txtNombreUsuario.Text = atBEUsuario.Nombre
            txtFechaInicial.Text = Now.ToString("dd/MM/yyyy")
            txtMontoInicial.Text = Format(laCajaConsultada.MontoInicial, "0.00")
            txtMontoInicial.Enabled = False
            btnActualizar.Enabled = True
            txtCaja.Text = Environment.MachineName
        Else
            MsgBox("Existe una caja abierta con una fecha anterior, para continuar debe cerrar la caja", MsgBoxStyle.Exclamation)
            CargueLasFacturasPendientes()
            panelFacturas.Visible = True
            dgFacturas.Enabled = False
            btnProcesar.Enabled = False
            btnCerrarCaja.Focus()
        End If

    End Sub

    Private Sub txtMontoInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMontoInicial.KeyDown
        If e.KeyCode = Keys.Return Then
            AperturaDeCajas()
        End If
    End Sub

    Private Sub AperturaDeCajas()
        If txtMontoInicial.Text = "" Then
            MsgBox("Debe de ingregar un monto inicial", MsgBoxStyle.Exclamation)
            txtMontoInicial.Focus()
        ElseIf laCajaConsultada Is Nothing Then
            Dim elmontoInicial = CDec(txtMontoInicial.Text)
            If MsgBox("¿Desea abrir la caja con el monto inicial de : " + Format(elmontoInicial, "0.00") + "?", vbYesNo + vbInformation + vbDefaultButton2, "Confirmacion") = vbYes Then
                codigoCajas = blCajas.InserteLaApertuaDeCaja(atBEUsuario.IdUsuario, CDbl(elmontoInicial), txtCaja.Text)
                If codigoCajas > 0 Then
                    CargueLasFacturasPendientes()
                    panelAbrirCaja.Visible = False
                    panelFacturas.Visible = True
                End If
            Else
                txtMontoInicial.Focus()
                txtMontoInicial.Select()
            End If
        ElseIf Not laCajaConsultada Is Nothing Then
            CargueLasFacturasPendientes()
            panelAbrirCaja.Visible = False
            panelFacturas.Visible = True
        End If
    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        AperturaDeCajas()
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
            btnProcesar.Enabled = True
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub CierreLaCaja()
        If Not laCajaConsultada Is Nothing Then
            Dim elMontoTotalFacturas = blCajas.ConsulteElMontoTotalDeFacturasProcesadasEnElDia(laCajaConsultada.IdMaquina)
            elMontoTotalFacturas += laCajaConsultada.MontoInicial
            If blCajas.CierreLaCaja(laCajaConsultada.IdMaquina, elMontoTotalFacturas) Then
                laCajaConsultada = Nothing
                panelFacturas.Visible = False
                panelAbrirCaja.Visible = True
                dgFacturas.AutoGenerateColumns = False
                dgFacturas.DataSource = Nothing
                btnProcesar.Enabled = False
                btnActualizar.Enabled = False

                txtNombreUsuario.Text = atBEUsuario.Nombre
                txtFechaInicial.Text = Now.ToString("dd/MM/yyyy")
                txtMontoInicial.Text = Format(0, "0.00")
                txtCaja.Text = Environment.MachineName
                txtMontoInicial.Focus()

            End If
        Else
            Dim elMontoTotalFacturas = blCajas.ConsulteElMontoTotalDeFacturasProcesadasEnElDia(txtCaja.Text)
            elMontoTotalFacturas += CDec(txtMontoInicial.Text)
            If blCajas.CierreLaCaja(txtCaja.Text, elMontoTotalFacturas) Then
                panelFacturas.Visible = False
                panelAbrirCaja.Visible = True
                dgFacturas.AutoGenerateColumns = False
                dgFacturas.DataSource = Nothing
                btnProcesar.Enabled = False
                btnActualizar.Enabled = False

                txtNombreUsuario.Text = atBEUsuario.Nombre
                txtFechaInicial.Text = Now.ToString("dd/MM/yyyy")
                txtMontoInicial.Text = Format(0, "0.00")
                txtCaja.Text = Environment.MachineName
                txtMontoInicial.Focus()
            End If
        End If

    End Sub
    Private Sub btnCerrarCaja_Click(sender As Object, e As EventArgs) Handles btnCerrarCaja.Click

        If dgFacturas.Rows.Count > 0 Then
            If MsgBox("¿Existen facturas pendientes desea cerrar la caja?", vbYesNo + vbInformation + vbDefaultButton2, "Confirmacion") = vbYes Then
                CierreLaCaja()
            End If
        Else
            If MsgBox("¿Desea cerrar la caja?", vbYesNo + vbInformation + vbDefaultButton2, "Confirmacion") = vbYes Then
                CierreLaCaja()
            End If
        End If

    End Sub

    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        If elIdFacturaSeleccionada > 0 Then
            If MsgBox("¿Desea procesar la factura : " + CStr(elIdFacturaSeleccionada) + "?", vbYesNo + vbInformation + vbDefaultButton2, "Confirmacion") = vbYes Then
                Dim frmPago As New FrmFormaPago
                CargarDatosDeFacturaSeleccionada(elIndexDeFacturaSeleccionada)
                frmPago.lblTotalFactura.Text = Format(dgFacturas.Rows.Item(elIndexDeFacturaSeleccionada).Cells.Item("totalFactura").Value, "###,###,##0.00")
                frmPago.elCodigoFacturaSeleccionada = elIdFacturaSeleccionada
                frmPago.laFacturaSeleccionada = laFacturaSeleccionada
                frmPago.laCaja = txtCaja.Text
                Dim result = frmPago.ShowDialog()
                If result = DialogResult.OK Then
                    CargueLasFacturasPendientes()
                End If
            End If
        End If
    End Sub

    Private Sub CargueLasFacturasPendientes()
        btnProcesar.Enabled = False
        elIdFacturaSeleccionada = 0
        elIndexDeFacturaSeleccionada = -1
        dgFacturas.DataSource = blCajas.CargueLaFacturasPendientesDeCobro()
        lblPendientes.Text = "Facturas Pendientes: " & dgFacturas.Rows.Count
    End Sub

    Sub CargarDatosDeFacturaSeleccionada(e As Integer)
        Dim laInstanciaDeFactura As New BLFacturas
        laFacturaSeleccionada = New BEFacturas
        laFacturaSeleccionada.Codigo = CInt(dgFacturas.Item("codigoFactura", e).Value)
        laFacturaSeleccionada.CedulaCliente = dgFacturas.Item("cliente", e).Value
        laFacturaSeleccionada.FechaFactura = CDate(dgFacturas.Item("fechaFactura", e).Value)
        laFacturaSeleccionada.NombreCliente = dgFacturas.Item("cliente", e).Value
        laFacturaSeleccionada.TotalFactura = dgFacturas.Item("totalFactura", e).Value
        laFacturaSeleccionada.Vendedor = dgFacturas.Item("vendedor", e).Value
        laFacturaSeleccionada.Lineas = New List(Of BEFacturaLinea)
        laFacturaSeleccionada.Lineas = laInstanciaDeFactura.CargueElDetalleDeLaFacturaSeleccionada(laFacturaSeleccionada.Codigo)
    End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        CargueLasFacturasPendientes()
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

    Private Sub dgFacturas_KeyDown(sender As Object, e As KeyEventArgs) Handles dgFacturas.KeyDown
        If e.KeyCode = Keys.Delete Then
            If dgFacturas.SelectedRows.Count > 0 Then
                If MsgBox("¿Desea eliminar la factura seleccionada?", vbYesNo + vbExclamation + vbDefaultButton2, "Confirmacion") = vbYes Then
                    Dim elCodigoDeFacturaSeleccionada = CInt(dgFacturas.Item(1, dgFacturas.CurrentRow.Index).Value.ToString)
                    If blCajas.EliminaLaFacturaSeleccionada(elCodigoDeFacturaSeleccionada) Then
                        CargueLasFacturasPendientes()
                    End If
                End If
            Else
                MsgBox("Seleccione una fila", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub
End Class