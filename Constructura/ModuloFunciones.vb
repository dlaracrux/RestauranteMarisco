Imports System.Text.RegularExpressions
Imports BusinessEntities

Module ModuloFunciones
    Public atBEUsuario As BEUsuario

    Function ValidarCorreo(ByVal sMail As String) As Boolean

        ' retorna true o false  
        Dim todosmailvalidos As Boolean = True

        For Each mail As String In Split(sMail, ",")

            If Regex.IsMatch(mail, "^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" + "(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$") = False Then

                MsgBox("Debe de ingresar un correo válido", MsgBoxStyle.Exclamation)

                todosmailvalidos = False
                Exit For
            End If
        Next

        Return todosmailvalidos

    End Function
End Module
