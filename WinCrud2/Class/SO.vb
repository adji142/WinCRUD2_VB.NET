Imports WinCrud2.Test.Data
Imports MySql.Data.MySqlClient

Namespace Test.SO
    Public Class SO
        Public Property RowID As Guid
        Public Property NoSO As String
        Public Property TglSO As DateTime
        Public Property KodeCust As String
        Public Property SalesID As String
        Public Property Nprint As Integer
    End Class

    Public Class AddSO
        Private _DBConnection As New DBConnection

        'Public Function AddHeader(ByVal data As SO) As Integer
        '    Dim SQL As String

        '    SQL = "Insert into salesorder values" +
        '        "(@RowID,@NoSO,@TglSO,@KodeCust,@SalesID,'',now(),@nprint)"

        '    Using DBX As IDbConnection = _DBConnection.Connection
        '        AddHeader = DBX.Execute(SQL, data)
        '    End Using
        'End Function
    End Class
End Namespace
