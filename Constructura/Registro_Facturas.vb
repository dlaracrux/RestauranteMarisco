Imports BusinessEntities
Imports BusinessLayer

Public Class Registro_Facturas
    Dim blFacturas As New BLFacturas
    Public elUsuarioEnSesion As BEUsuario
    Private elArticuloCargado As Articulo
    Private Sub Registro_Facturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNombreCliente.CharacterCasing = CharacterCasing.Upper
        CargueLosControlesPorDefecto()
        CargaElComboTipo()
        txtNombreCliente.Focus()
        txtNombreCliente.Select()
    End Sub
    Private Sub CargaElComboTipo()
        cmbTipo.Items.Clear()
        cmbTipo.Items.Insert(0, "Producto")
        cmbTipo.Items.Insert(1, "Plato")
        cmbTipo.Items.Insert(2, "Bebida")
        cmbTipo.Items.Insert(3, "Postre")
        cmbTipo.Items.Insert(4, "Otro")
        cmbTipo.SelectedIndex = 1
    End Sub

    Private Sub CargueLosControlesPorDefecto()
        txtNombreCliente.Text = "Cliente Contado"
        txtCedula.Text = "999999999"
        txtFechaFactura.Text = Now.ToString("dd/MM/yyyy")
        txtTotalImpuesto.Text = Format(0, "0.00")
        txtTotalFactura.Text = Format(0, "0.00")
        txtPrecioUnitario.Text = Format(0, "0.00")
        txtCantidad.Text = Format(0, "0.00")
        txtExistencias.Text = Format(0, "0.00")
        txtVendedor.Text = atBEUsuario.Nombre
    End Sub

    Private Sub txtCedula_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCedula.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCodigoArticulo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigoArticulo.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCodigoArticulo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigoArticulo.KeyDown
        If e.KeyCode = Keys.Return Then
            If txtCodigoArticulo.Text = "" Then
                MsgBox("Debe de ingregar un código de artículo", MsgBoxStyle.Exclamation)
            Else
                elArticuloCargado = blFacturas.CargueElArticuloPorCodigo(txtCodigoArticulo.Text)
                CargueElArticuloALosCampos(elArticuloCargado)
            End If
            'FrmConsultaDocuCxP

        ElseIf (e.KeyCode = Keys.Back) OrElse (e.KeyCode = Keys.Delete) Then
            limpiarLosCampos()
        ElseIf (e.KeyCode = Keys.F1) Then
            Dim frmConsulta As New FrmConsultaArticulos

            Dim result = frmConsulta.ShowDialog()
            If result = DialogResult.OK Then
                Dim elArticuloSeleccionadoConsulta As Articulo = frmConsulta.elArticuloSeleccionado
                txtCodigoArticulo.Text = elArticuloSeleccionadoConsulta.codigo
                CargueElArticuloALosCampos(elArticuloSeleccionadoConsulta)
            End If

        End If
    End Sub

    Private Sub CargueElArticuloALosCampos(ByVal elArticulo As Articulo)
        If Not elArticulo Is Nothing Then
            If elArticulo.cantidad > 0 Then
                txtCantidad.Text = Format(0, "0.00")
                txtPrecioUnitario.Text = Format(elArticulo.precio, "0.00")
                txtExistencias.Text = Format(elArticulo.cantidad, "0.00")
                txtNombreArticulo.Text = elArticulo.nombre

                If elArticulo.tipo = 0 Then
                    cmbTipo.SelectedIndex = 0
                ElseIf elArticulo.tipo = 1 Then
                    cmbTipo.SelectedIndex = 1
                ElseIf elArticulo.tipo = 2 Then
                    cmbTipo.SelectedIndex = 2
                ElseIf elArticulo.tipo = 3 Then
                    cmbTipo.SelectedIndex = 4
                Else
                    cmbTipo.SelectedIndex = 5
                End If
                txtCantidad.Focus()
            Else
                MsgBox("El artículo no cuenta con existencias en inventario", MsgBoxStyle.Exclamation)
                txtCodigoArticulo.Focus()
                txtCodigoArticulo.SelectAll()
            End If
        Else
            MsgBox("No existe un artículo con el código: " + txtCodigoArticulo.Text, MsgBoxStyle.Exclamation)
            txtCodigoArticulo.Focus()
            txtCodigoArticulo.SelectAll()
        End If
    End Sub

    Private Sub limpiarLosCampos()
        txtPrecioUnitario.Text = Format(0, "0.00")
        txtCantidad.Text = Format(0, "0.00")
        txtExistencias.Text = Format(0, "0.00")
        txtNombreArticulo.Text = ""
        cmbTipo.SelectedIndex = 1
        elArticuloCargado = Nothing
        txtCodigoArticulo.Focus()
    End Sub

    Private Sub txtNombreCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombreCliente.KeyDown
        If e.KeyCode = Keys.Return Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtCedula_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCedula.KeyDown
        If e.KeyCode = Keys.Return Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtCantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCantidad.KeyDown
        If e.KeyCode = Keys.Return Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub btnAgregarLinea_Click(sender As Object, e As EventArgs) Handles btnAgregarLinea.Click
        Dim ingreseLaLineaAlGrid As Boolean = True
        Dim cantidadConsultada As Integer = 0
        If Not txtCodigoArticulo.Text = "" Then
            If CInt(txtCantidad.Text) > 0 Then
                If cmbTipo.SelectedIndex <> 0 Then
                    If dgLinea.Rows.Count > 0 Then
                        For Each Fila As DataGridViewRow In dgLinea.Rows
                            If Not Fila Is Nothing Then
                                If Fila.Cells("codigo").Value = Trim(txtCodigoArticulo.Text) Then
                                    MsgBox("El artículo " + txtNombreArticulo.Text + " ya se encuentra agregado a la lista de la factura.", MsgBoxStyle.Exclamation)
                                    ingreseLaLineaAlGrid = False
                                End If
                            End If
                        Next
                    End If
                    cantidadConsultada = blFacturas.CargueLaCantidadDelArticulo(txtCodigoArticulo.Text)
                    If CInt(txtExistencias.Text) = cantidadConsultada Then
                        If ingreseLaLineaAlGrid Then
                            AgregueElArticuloAlDetalleDeFactura()
                            txtCodigoArticulo.Text = ""
                            limpiarLosCampos()
                        End If
                    Else
                        MsgBox("Las existencias del artículo han cambiado, se va proceder a actualizar las nuevas existencias", MsgBoxStyle.Exclamation)
                        txtExistencias.Text = Format(cantidadConsultada, "0.00")
                        txtCantidad.Focus()
                        txtCantidad.Select()
                    End If
                Else
                    If Not CInt(txtCantidad.Text) > CInt(txtExistencias.Text) Then
                        If dgLinea.Rows.Count > 0 Then
                            For Each Fila As DataGridViewRow In dgLinea.Rows
                                If Not Fila Is Nothing Then
                                    If Fila.Cells("codigo").Value = Trim(txtCodigoArticulo.Text) Then
                                        MsgBox("El artículo " + txtNombreArticulo.Text + " ya se encuentra agregado a la lista de la factura.", MsgBoxStyle.Exclamation)
                                        ingreseLaLineaAlGrid = False
                                    End If
                                End If
                            Next
                        End If
                        cantidadConsultada = blFacturas.CargueLaCantidadDelArticulo(txtCodigoArticulo.Text)
                        If CInt(txtExistencias.Text) = cantidadConsultada Then
                            If ingreseLaLineaAlGrid Then
                                AgregueElArticuloAlDetalleDeFactura()
                                txtCodigoArticulo.Text = ""
                                limpiarLosCampos()
                            End If
                        Else
                            MsgBox("Las existencias del artículo han cambiado, se va proceder a actualizar las nuevas existencias", MsgBoxStyle.Exclamation)
                            txtExistencias.Text = Format(cantidadConsultada, "0.00")
                            txtCantidad.Focus()
                            txtCantidad.Select()
                        End If
                    Else
                        MsgBox("La cantidad ingresada no puede superar las existencias del artículo", MsgBoxStyle.Exclamation)
                        txtCantidad.Focus()
                        txtCantidad.Select()
                    End If
                End If

            Else
                MsgBox("Debe agregar una cantidad mayor a 0", MsgBoxStyle.Exclamation)
                txtCantidad.Focus()
                txtCantidad.Select()
            End If
        Else
            MsgBox("Debe cargar un artículo", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub AgregueElArticuloAlDetalleDeFactura()
        Dim elPrecioTotalLinea As Decimal = (CDec(txtCantidad.Text) * CDec(txtPrecioUnitario.Text))
        Dim elPrecioTotalImpuesto As Decimal = (CDec(0.13) * elPrecioTotalLinea)
        Dim elPrecioTotalFactura As Decimal = (CDec(txtTotalFactura.Text) + elPrecioTotalLinea + elPrecioTotalImpuesto)

        dgLinea.Rows.Add(txtCodigoArticulo.Text, txtNombreArticulo.Text, txtCantidad.Text,
                         txtPrecioUnitario.Text, cmbTipo.SelectedItem,
                         elPrecioTotalLinea, txtExistencias.Text, cmbTipo.SelectedIndex, elPrecioTotalFactura)
        txtTotalImpuesto.Text = Format(elPrecioTotalImpuesto, "0.00")
        txtTotalFactura.Text = Format(elPrecioTotalFactura, "0.00")
    End Sub

    Private Sub txtCantidad_Leave(sender As Object, e As EventArgs) Handles txtCantidad.Leave
        Dim laCantidad As Integer = 0
        Integer.TryParse(txtCantidad.Text, laCantidad)
        txtCantidad.Text = Format(laCantidad, "0.00")
    End Sub

    Private Sub dgLinea_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgLinea.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            txtCodigoArticulo.Text = CStr(dgLinea.Item(dgLinea.Columns.IndexOf(codigo), e.RowIndex).Value.ToString)
            txtCantidad.Text = CStr(dgLinea.Item(dgLinea.Columns.IndexOf(cantidad), e.RowIndex).Value.ToString)
            txtNombreArticulo.Text = CStr(dgLinea.Item(dgLinea.Columns.IndexOf(nombre), e.RowIndex).Value.ToString)
            txtPrecioUnitario.Text = CStr(dgLinea.Item(dgLinea.Columns.IndexOf(precio), e.RowIndex).Value.ToString)
            txtExistencias.Text = CStr(dgLinea.Item(dgLinea.Columns.IndexOf(existencias), e.RowIndex).Value.ToString)
            cmbTipo.SelectedIndex = CInt(dgLinea.Item(dgLinea.Columns.IndexOf(tipoIndex), e.RowIndex).Value)
            dgLinea.Rows.RemoveAt(e.RowIndex)
        End If

        Dim elPrecioTotalLinea As Decimal = (CDec(txtCantidad.Text) * CDec(txtPrecioUnitario.Text))
        Dim elPrecioTotalImpuesto As Decimal = (CDec(txtTotalImpuesto.Text) - (CDec(0.13) * elPrecioTotalLinea))
        Dim elPrecioTotalFactura As Decimal = (CDec(txtTotalFactura.Text) - elPrecioTotalLinea - (CDec(0.13) * elPrecioTotalLinea))

        txtTotalImpuesto.Text = Format(elPrecioTotalImpuesto, "0.00")
        txtTotalFactura.Text = Format(elPrecioTotalFactura, "0.00")
        txtCantidad.Focus()
        txtCantidad.Select()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If MsgBox("¿Desea guardar la factura?", vbYesNo + vbInformation + vbDefaultButton2, "Confirmacion") = vbYes Then
            Dim listaFacturas As BEFacturaLinea
            Dim facturaEncabezado As New BEFacturas
            If dgLinea.Rows.Count > 0 Then
                facturaEncabezado.NombreCliente = txtNombreCliente.Text
                facturaEncabezado.CedulaCliente = txtCedula.Text
                facturaEncabezado.Usuario = atBEUsuario.IdUsuario
                facturaEncabezado.TotalFactura = CDec(txtTotalFactura.Text)
                facturaEncabezado.TotalImpuesto = CDec(txtTotalImpuesto.Text)
                facturaEncabezado.FechaFactura = Now
                facturaEncabezado.Estado = "P"
                facturaEncabezado.Lugar = IIf(rbBarra.Checked, 0, 1)
                facturaEncabezado.Lineas = New List(Of BEFacturaLinea)
                For Each Fila As DataGridViewRow In dgLinea.Rows
                    If Not Fila Is Nothing Then
                        listaFacturas = New BEFacturaLinea
                        listaFacturas.CodigoArticulo = Fila.Cells("codigo").Value
                        listaFacturas.Cantidad = Fila.Cells("cantidad").Value
                        listaFacturas.PrecioTotalLinea = Fila.Cells("precioTotal").Value
                        listaFacturas.PrecioUnitario = Fila.Cells("precio").Value
                        facturaEncabezado.Lineas.Add(listaFacturas)
                    End If
                Next

                If blFacturas.RegistreLaFactura(facturaEncabezado) Then
                    limpiarCampos()
                    dgLinea.DataSource = Nothing
                    dgLinea.Rows.Clear()
                End If
            Else
                MsgBox("Debe agregar al menos una línea", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub limpiarCampos()
        CargueLosControlesPorDefecto()
        CargaElComboTipo()
        txtNombreCliente.Focus()
        txtNombreCliente.Select()
    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MsgBox("Si cancela, se perdera el registro actual de factura no guardado. Desea Cancelar?", vbYesNo + vbExclamation + vbDefaultButton2, "Confirmacion") = vbYes Then
            limpiarCampos()
            dgLinea.DataSource = Nothing
            dgLinea.Rows.Clear()
        End If
    End Sub

    Private Sub lblModificaPrecio_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblModificaPrecio.LinkClicked
        If Not (txtCodigoArticulo.Text = "" AndAlso txtNombreArticulo.Text = "") Then
            Dim frmValidaContra As New FrmValidaContrasenia
            Dim result = frmValidaContra.ShowDialog()
            If result = DialogResult.OK Then
                Dim frmCambiaElPrecio As New FrmCambiarPrecioUnitario
                frmCambiaElPrecio.txtPrecioNuevo.Text = txtPrecioUnitario.Text
                Dim elResultado = frmCambiaElPrecio.ShowDialog()
                If elResultado = DialogResult.OK Then
                    txtPrecioUnitario.Text = Format(frmCambiaElPrecio.elPrecioNuevo, "0.00")

                End If
            End If
        End If
    End Sub

    Private Sub dgLinea_KeyDown(sender As Object, e As KeyEventArgs) Handles dgLinea.KeyDown
        If e.KeyCode = Keys.Delete Then
            If dgLinea.SelectedRows.Count > 0 Then
                If MsgBox("¿Desea eliminar el articulo seleccionado?", vbYesNo + vbExclamation + vbDefaultButton2, "Confirmacion") = vbYes Then
                    dgLinea.Rows.RemoveAt(dgLinea.CurrentRow.Index)
                End If
            Else
                MsgBox("Seleccione una fila", MsgBoxStyle.Exclamation)
            End If

        End If
    End Sub

    'Private Sub chkMesada_CheckedChanged(sender As Object, e As EventArgs) Handles chkMesada.CheckedChanged
    '    If chkMesada.Checked Then
    '        If dgLinea.Rows.Count > 0 Then
    '            Dim elPrecioTotalLinea As Double = 0
    '            For Each Fila As DataGridViewRow In dgLinea.Rows
    '                If Not Fila Is Nothing Then
    '                    elPrecioTotalLinea = elPrecioTotalLinea + Fila.Cells("TotalPrecioConImpuesto").Value
    '                End If
    '            Next
    '        End If

    '    Else

    '    End If

    'End Sub
End Class