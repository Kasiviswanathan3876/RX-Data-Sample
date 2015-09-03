Imports System.Data.Entity

Public Class SampleContext
    Inherits DbContext
    Public Sub New()
        MyBase.New("RX_Data_Sample.My.MySettings.SampleCustomersConnectionString")
    End Sub

    Property Customers As DbSet(Of Customer)
    Property Addresses As DbSet(Of Address)


End Class
