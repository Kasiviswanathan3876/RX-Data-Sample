Imports System.ComponentModel.DataAnnotations

Public Class Customer
   
    Property ID As Long
    Property Name As String
    Property ShippingAddress As Address
    Property BillingAddress As Address
    Public Overrides Function ToString() As String
        Return String.Format("{0} ({1})", Name, ID)
    End Function
End Class
