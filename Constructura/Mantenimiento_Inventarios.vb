Imports System.IO
Imports BusinessEntities
Imports BusinessLayer
Imports OfficeOpenXml

Public Class Mantenimiento_Inventarios

    Dim elArticuloSeleccionado As New Articulo
    Dim blInventario As New BLInventarios
    Dim elIdSeleccionado As Integer
    Private Sub Mantenimiento_Bancos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNombreArticulo.CharacterCasing = CharacterCasing.Upper
        dgArticulos.AutoGenerateColumns = False
        txtCantidad.Text = Format(1, "0.00")
        CargaElComboTipo()
        ObtengaLosArticulosEnElGrid()
        limpiarCampos()
        If cmbTipo.SelectedIndex <> 0 Then
            txtCantidad.Text = Format(1, "1.00")
            txtCantidad.Enabled = False
        Else
            txtCantidad.Text = Format(0, "0.00")
            txtCantidad.Enabled = True
        End If
    End Sub

    Private Sub limpiarCampos()
        elArticuloSeleccionado = New Articulo
        txtNombreArticulo.Text = ""
        cmbTipo.SelectedIndex = 0
        txtCantidad.Text = Format(0, "0.00")
        txtCosto.Text = ""
        txtPrecio.Text = ""
        txtCantidad.Enabled = True
    End Sub
    Private Sub CargaElComboTipo()
        cmbTipo.Items.Clear()
        cmbTipo.Items.Insert(0, "Producto")
        cmbTipo.Items.Insert(1, "Plato")
        cmbTipo.Items.Insert(2, "Bebida")
        cmbTipo.Items.Insert(3, "Postre")
        cmbTipo.Items.Insert(4, "Otro")
        cmbTipo.SelectedIndex = 0

    End Sub


    Private Sub ObtengaLosArticulosEnElGrid()
        Dim blInventario As New BLInventarios
        dgArticulos.DataSource = blInventario.ObtengaLosArticulosDesdeBaseDeDatos()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Trim(txtNombreArticulo.Text) = "" Then
            MsgBox("Debe de ingregar un nombre de artículo", MsgBoxStyle.Exclamation)
            txtNombreArticulo.Text = ""
        ElseIf txtCosto.Text = "" Then
            MsgBox("Debe de ingregar el costo del artículo", MsgBoxStyle.Exclamation)
        ElseIf txtPrecio.Text = "" Then
            MsgBox("Debe de ingregar el precio del artículo", MsgBoxStyle.Exclamation)
        ElseIf txtCantidad.Text = "" Then
            MsgBox("Debe de ingregar la cantidad del artículo", MsgBoxStyle.Exclamation)
        ElseIf CInt(txtCantidad.Text) = 0 Then
            MsgBox("Debe de ingregar almenos 1 cantidad del artículo", MsgBoxStyle.Exclamation)
        Else

            If elArticuloSeleccionado.codigo <> 0 Then
                elArticuloSeleccionado.nombre = Trim(txtNombreArticulo.Text)
                elArticuloSeleccionado.costo = Trim(txtCosto.Text)
                elArticuloSeleccionado.precio = Trim(txtPrecio.Text)
                elArticuloSeleccionado.cantidad = Trim(txtCantidad.Text)
                elArticuloSeleccionado.tipo = cmbTipo.SelectedIndex
                blInventario.ModifiqueElArticulo(elArticuloSeleccionado)
            Else
                elArticuloSeleccionado.nombre = Trim(txtNombreArticulo.Text)
                elArticuloSeleccionado.costo = Trim(txtCosto.Text)
                elArticuloSeleccionado.precio = Trim(txtPrecio.Text)
                elArticuloSeleccionado.cantidad = Trim(txtCantidad.Text)
                elArticuloSeleccionado.tipo = cmbTipo.SelectedIndex
                blInventario.GuardeElArticuloNuevo(elArticuloSeleccionado)
            End If
            bCancelar_Click(sender, e)
            ObtengaLosArticulosEnElGrid()
        End If
    End Sub

    Private Sub dgBancos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgArticulos.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then

            elArticuloSeleccionado.codigo = CInt(dgArticulos.Item(0, e.RowIndex).Value.ToString)
            elArticuloSeleccionado.nombre = CStr(dgArticulos.Item(1, e.RowIndex).Value.ToString)
            elArticuloSeleccionado.costo = CStr(dgArticulos.Item(3, e.RowIndex).Value.ToString)
            elArticuloSeleccionado.precio = CStr(dgArticulos.Item(4, e.RowIndex).Value.ToString)
            elArticuloSeleccionado.cantidad = CStr(dgArticulos.Item(5, e.RowIndex).Value.ToString)

            If CStr(dgArticulos.Item(2, e.RowIndex).Value.ToString) = "Producto" Then
                elArticuloSeleccionado.tipo = 0
                txtCantidad.Enabled = True
            ElseIf CStr(dgArticulos.Item(2, e.RowIndex).Value.ToString) = "Plato" Then
                elArticuloSeleccionado.tipo = 1
                txtCantidad.Enabled = False
            ElseIf CStr(dgArticulos.Item(2, e.RowIndex).Value.ToString) = "Bebida" Then
                elArticuloSeleccionado.tipo = 2
                txtCantidad.Enabled = False
            ElseIf CStr(dgArticulos.Item(2, e.RowIndex).Value.ToString) = "Postre" Then
                elArticuloSeleccionado.tipo = 3
                txtCantidad.Enabled = False
            Else
                elArticuloSeleccionado.tipo = 4
                txtCantidad.Enabled = False
            End If

            txtNombreArticulo.Text = elArticuloSeleccionado.nombre
            txtCosto.Text = Format(elArticuloSeleccionado.costo, "0.00")
            txtPrecio.Text = Format(elArticuloSeleccionado.precio, "0.00")
            txtCantidad.Text = Format(elArticuloSeleccionado.cantidad, "0.00")
            cmbTipo.SelectedIndex = elArticuloSeleccionado.tipo
        End If
    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        CargaElComboTipo()
        limpiarCampos()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles txtCosto.KeyPress
        Dim cadena As String = txtCosto.Text
        Dim Ocurrencias As Byte = 0
        Dim str As String() = cadena.Split(".")
        For I As Integer = 0 To str.Length - 1
            Ocurrencias = Ocurrencias + 1
        Next
        Ocurrencias = Ocurrencias - 1
        If (Char.IsDigit(e.KeyChar) = False And e.KeyChar <> ("."c)) Or
        (e.KeyChar = ("."c) And Ocurrencias <> 0) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrecio_KeyPress(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        Dim cadena As String = txtCosto.Text
        Dim Ocurrencias As Byte = 0
        Dim str As String() = cadena.Split(".")
        For I As Integer = 0 To str.Length - 1
            Ocurrencias = Ocurrencias + 1
        Next
        Ocurrencias = Ocurrencias - 1
        If (Char.IsDigit(e.KeyChar) = False And e.KeyChar <> ("."c)) Or
        (e.KeyChar = ("."c) And Ocurrencias <> 0) Then
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

    Private Sub cmbTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipo.SelectedIndexChanged
        If cmbTipo.SelectedIndex <> 0 Then
            txtCantidad.Text = Format(1, "0.00")
            txtCantidad.Enabled = False
        Else
            txtCantidad.Text = Format(CInt(txtCantidad.Text), "0.00")
            txtCantidad.Enabled = True
        End If
    End Sub

    Private Sub txtCosto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCosto.KeyDown
        If e.KeyCode = Keys.Return Then
            Dim elCosto As Double = 0
            Double.TryParse(txtCosto.Text, elCosto)
            txtCosto.Text = Format(elCosto, "0.00")
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtPrecio_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPrecio.KeyDown
        If e.KeyCode = Keys.Return Then
            Dim elPrecio As Double = 0
            Double.TryParse(txtPrecio.Text, elPrecio)
            txtPrecio.Text = Format(elPrecio, "0.00")
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtCantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCantidad.KeyDown
        If e.KeyCode = Keys.Return Then
            Dim laCantidad As Double = 0
            Double.TryParse(txtCantidad.Text, laCantidad)
            txtCantidad.Text = Format(laCantidad, "0.00")
            btnGuardar_Click(sender, e)
        End If
    End Sub

    Private Sub cmbTipo_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbTipo.KeyDown
        If e.KeyCode = Keys.Return Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtNombreArticulo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombreArticulo.KeyDown
        If e.KeyCode = Keys.Return Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub dgArticulos_KeyDown(sender As Object, e As KeyEventArgs) Handles dgArticulos.KeyDown
        If e.KeyCode = Keys.Delete Then
            If dgArticulos.SelectedRows.Count > 0 Then
                If MsgBox("¿Desea eliminar el articulo seleccionado?", vbYesNo + vbExclamation + vbDefaultButton2, "Confirmacion") = vbYes Then
                    elIdSeleccionado = CInt(dgArticulos.Item(0, dgArticulos.CurrentRow.Index).Value.ToString)
                    If blInventario.EliminaElArticuloSeleccionado(elIdSeleccionado) Then
                        bCancelar_Click(sender, e)
                        ObtengaLosArticulosEnElGrid()
                    End If
                End If
            Else
                MsgBox("Seleccione una fila", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Try
            If dgArticulos.Rows.Count > 0 Then



                ExcelPackage.LicenseContext = LicenseContext.NonCommercial
                Dim TablaDatos As New DataTable
                TablaDatos.Columns.Add("Código")
                TablaDatos.Columns.Add("Artículo")
                TablaDatos.Columns.Add("Tipo")
                TablaDatos.Columns.Add("Costo")
                TablaDatos.Columns.Add("Precio")
                TablaDatos.Columns.Add("Cantidad")
                For i As Integer = 0 To dgArticulos.Rows.Count - 1
                    TablaDatos.Rows.Add(dgArticulos.Rows.Item(i).Cells("codigo").Value, dgArticulos.Rows.Item(i).Cells("articulo").Value,
                                        dgArticulos.Rows.Item(i).Cells("Tipo").Value, dgArticulos.Rows.Item(i).Cells("Costo").Value,
                                        dgArticulos.Rows.Item(i).Cells("Precio").Value, dgArticulos.Rows.Item(i).Cells("Cantidad").Value)
                Next
                Dim directorio As String = My.Computer.FileSystem.CurrentDirectory
                Dim fileg As New FileInfo("C:\LlantasYMas\LlantasYMasInventario.xlsx")
                Using package As New ExcelPackage(fileg)
                    Dim ws As ExcelWorksheet = package.Workbook.Worksheets.Item("Hoja1")
                    ws.Cells("A1").LoadFromDataTable(TablaDatos, True)
                    Dim SaveFileDialog As New SaveFileDialog
                    SaveFileDialog.Title = "Inventarios Llantas Y Mas"
                    SaveFileDialog.Filter = "Excel files|*.xlsx|All files|*.*"
                    SaveFileDialog.FileName = "InventariosLlantasYMas_" + DateTime.Now.ToString("dd-MM-yyyy") + ".xlsx"
                    If SaveFileDialog.ShowDialog() = DialogResult.OK Then
                        Dim file As New FileInfo(SaveFileDialog.FileName)
                        package.SaveAs(file)
                        MsgBox("Se exportó con éxito", MessageBoxIcon.Information, "Exportación Excel")
                        System.Diagnostics.Process.Start(SaveFileDialog.FileName)
                    Else
                        Exit Sub
                    End If
                End Using
            Else
                MsgBox("Deben existir datos cargados", MessageBoxIcon.Warning, "Exportación Excel")
            End If
        Catch ex As Exception
            MsgBox("Se presentó un problema al exportar los datos. Por favor vuelva a intentar.", MessageBoxIcon.Error, "Exportación Excel")
        End Try
    End Sub
End Class