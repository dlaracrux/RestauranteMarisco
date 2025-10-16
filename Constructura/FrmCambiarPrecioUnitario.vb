Imports System.Drawing.Printing
Imports BusinessEntities
Imports BusinessLayer

Public Class FrmCambiarPrecioUnitario
    Public elPrecioNuevo As Decimal
    Private Sub btnCambiar_Click(sender As Object, e As EventArgs) Handles btnCambiar.Click
        If Not txtPrecioNuevo.Text = "" Then
            Dim elPrecio As Decimal = 0
            Decimal.TryParse(txtPrecioNuevo.Text, elPrecio)
            If elPrecio > 0 Then
                elPrecioNuevo = elPrecio
                DialogResult = DialogResult.OK
                Me.Close()
            Else
                MsgBox("Debe de ingregar un precio mayor a 0", MsgBoxStyle.Exclamation)
            End If
        Else
            MsgBox("Debe de ingregar un precio mayor a 0", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub txtPrecioNuevo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPrecioNuevo.KeyDown
        If e.KeyCode = Keys.Return Then
            Dim elCosto As Decimal = 0
            Decimal.TryParse(txtPrecioNuevo.Text, elCosto)
            txtPrecioNuevo.Text = Format(elCosto, "0.00")
            btnCambiar_Click(sender, e)
        End If
    End Sub
End Class