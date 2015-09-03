Imports System.Text
Imports System.Threading.Tasks
Imports System.Data.Entity
Imports System.Reactive.Concurrency
Imports System.Threading
Imports System.Reactive
Imports System.Reactive.Linq
Public Class Customers
    Private _IsBusy As Boolean = False
    Property IsBusy As Boolean
        Get
            Return _IsBusy
        End Get
        Set(value As Boolean)

            If Me.InvokeRequired Then
                Me.Invoke(Sub()
                              _IsBusy = value
                              pbBusy.Image = If(value, My.Resources.spinner, Nothing)
                          End Sub)


            Else
                _IsBusy = value
                pbBusy.Image = If(value, My.Resources.spinner, Nothing)
               
            End If

        End Set
    End Property

    Private Async Sub btnAddCustomerd_Click(sender As Object, e As EventArgs) Handles btnAddCustomers.Click
        Me.btnAddCustomers.Enabled = False
        IsBusy = True
        Await SetupDB()

        IsBusy = False
        Me.btnAddCustomers.Enabled = True
        MessageBox.Show("Sample data loaded")

        Await LoadCustomers()

    End Sub

    Function SetupDB() As Task
        Dim tsk As New Task(Sub()
                                Using db As New SampleContext

                                    'db.Database.Log = Sub(s)
                                    '                      Console.WriteLine(s)
                                    '                  End Sub

                                    db.Database.CreateIfNotExists()

                                    For x As Integer = 1 To 500
                                        Dim c As New Customer
                                        With c
                                            .Name = GenerateRandomString()
                                            .BillingAddress = New Address() With {
                                                .Address1 = GenerateRandomString(),
                                                .City = GenerateRandomString(),
                                                .State = GenerateRandomString(2),
                                                .Zip = GenerateRandomString(5)
                                            }

                                            .ShippingAddress = New Address() With {
                                             .Address1 = GenerateRandomString(),
                                                .City = GenerateRandomString(),
                                                .State = GenerateRandomString(2),
                                                .Zip = GenerateRandomString(5)
                                          }
                                            db.Customers.Add(c)
                                        End With
                                    Next

                                    db.SaveChanges()



                                End Using
                            End Sub)

        tsk.Start()
        Return tsk

    End Function
    Dim rnd As New Random
    Private Function GenerateRandomString(Optional length As Integer = 20) As String
        Dim sb As New StringBuilder


        For x As Integer = 1 To length
            sb.Append(ChrW(rnd.Next(69, 121)))
        Next
        Return sb.ToString
    End Function

    Private Async Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        ctx = SynchronizationContext.Current

        Await LoadCustomers()



    End Sub
    Private ctx As SynchronizationContext
    Private Function LoadCustomers() As Task
        Dim customers As New List(Of Customer)
        CustomerBindingSource.DataSource = customers
        cboCust.Items.Clear()
        Dim tsk As New Task(Sub()


                                IsBusy = True

                                Dim loader = GetCustomers.ToObservable(Scheduler.ThreadPool).
                                Buffer(500).ObserveOn(ctx).Finally(Sub()
                                                                       IsBusy = False

                                                                   End Sub).
                                Subscribe(Sub(loadedData)
                                              If loadedData IsNot Nothing AndAlso loadedData.Count > 0 Then
                                                  customers.AddRange(loadedData)
                                                  Me.Invoke(Sub()
                                                                CustomerBindingSource.ResetBindings(False)
                                                                dgCustomers.FirstDisplayedScrollingRowIndex = customers.Count - 1
                                                                lblCount.Text = String.Format("{0} records loaded.", customers.Count)
                                                                cboCust.Items.AddRange(loadedData.ToArray)
                                                            End Sub)

                                              End If

                                          End Sub)

                            End Sub)

        tsk.Start()
        Return tsk
    End Function

    Private Iterator Function GetCustomers() As IEnumerable(Of Customer)
        Using db As New SampleContext
            Debug.WriteLine(db.Customers.Count)




            For Each c In db.Customers.
                Include(Function(cust) cust.BillingAddress).
                Include(Function(cust) cust.ShippingAddress)
                Yield c
                'todo uncomment next line to slow things down
                ' Thread.Sleep(10)
            Next


        End Using
    End Function


    Private Sub dgCustomers_SelectionChanged(sender As Object, e As EventArgs) Handles dgCustomers.SelectionChanged
        If dgCustomers.SelectedCells.Count = 0 Then Return
        Dim cust As Customer = dgCustomers.SelectedCells(0).OwningRow.DataBoundItem
        lblBilling.Text = cust.BillingAddress.ToString
        lblShipping.Text = cust.ShippingAddress.ToString
    End Sub


End Class
