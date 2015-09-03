Imports System.ComponentModel.DataAnnotations

Public Class Address
    Property ID As Long
    Property Address1 As String
    Property Address2 As String
    Property City As String
    Property State As String
    <StringLength(5)>
    Property Zip As String

    Public Overrides Function ToString() As String
        Return String.Format("{0} {1} {3}, {4}", Address1, Address2, City, State, Zip)
    End Function
End Class
