Imports System.Data.SqlClient

Public Class DLConexion

    Public DBSistemaCnnStr As String = ""
    Public Sub DefineStrConexion()
        DBSistemaCnnStr = "Server=LARACD-P\SQL2017;Database=RanchoDelMariscoDB;Integrated Security=True;"
        'DBSistemaCnnStr = "Data Source=sql5111.site4now.net;Initial Catalog=db_aa04fd_llantasymas;User Id=db_aa04fd_llantasymas_admin;Password=tuco2023;"
    End Sub
End Class
