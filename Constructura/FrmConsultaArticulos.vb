Imports BusinessEntities
Imports BusinessLayer

Public Class FrmConsultaArticulos
    Public elArticuloSeleccionado As Articulo

    Private Sub chkCodigo_CheckedChanged(sender As Object, e As EventArgs) Handles chkCodigo.CheckedChanged
        If chkCodigo.Checked Then
            txtCodigo.Enabled = True
            txtCodigo.Focus()
        Else
            txtCodigo.Enabled = False
            txtCodigo.Text = ""
        End If
    End Sub

    Private Sub chkNombre_CheckedChanged(sender As Object, e As EventArgs) Handles chkNombre.CheckedChanged
        If chkNombre.Checked Then
            txtNombre.Enabled = True
            txtNombre.Focus()
        Else
            txtNombre.Enabled = False
            txtNombre.Text = ""
        End If
    End Sub

    Private Sub FrmConsultaDocuCxP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgConsultaArticulos.AutoGenerateColumns = False
        txtNombre.CharacterCasing = CharacterCasing.Upper
        chkCodigo.Checked = False
        chkNombre.Checked = False
        txtCodigo.Text = ""
        txtNombre.Text = ""
    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs)
        chkCodigo.Checked = False
        chkNombre.Checked = False
        txtCodigo.Text = ""
        txtNombre.Text = ""
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim SeSeleccionoNombre As String = "N"
        Dim SeSeleccionoCodigo As String = "N"
        Dim elCampoCodigo As Integer = 0

        If chkCodigo.Checked Then
            SeSeleccionoCodigo = "S"
            If txtCodigo.Text = "" Then
                elCampoCodigo = 0
            Else
                Integer.TryParse(txtCodigo.Text, elCampoCodigo)
            End If
        End If

        If chkNombre.Checked Then
            SeSeleccionoNombre = "S"
        End If

        Dim laInstanciaDeFactura As New BLFacturas
        dgConsultaArticulos.DataSource = laInstanciaDeFactura.CargueLaConsultaDeArticulosPorFiltros(SeSeleccionoNombre, SeSeleccionoCodigo, elCampoCodigo, txtNombre.Text)
        If dgConsultaArticulos.Rows.Count = 0 Then
            MsgBox("No se han encontrado artículos", MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub dgConsultaArticulos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgConsultaArticulos.CellDoubleClick
        If dgConsultaArticulos.Rows().Count > 0 Then
            cargarDatos(e.RowIndex)
        End If
    End Sub
    Sub cargarDatos(e As Integer)
        elArticuloSeleccionado = New Articulo
        elArticuloSeleccionado.codigo = dgConsultaArticulos.Item("codigo", e).Value
        elArticuloSeleccionado.cantidad = dgConsultaArticulos.Item("cantidad", e).Value
        elArticuloSeleccionado.nombre = dgConsultaArticulos.Item("nombre", e).Value
        elArticuloSeleccionado.tipo = dgConsultaArticulos.Item("tipoIndex", e).Value
        elArticuloSeleccionado.precio = dgConsultaArticulos.Item("precio", e).Value
        DialogResult = DialogResult.OK
        Me.Close()
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
End Class