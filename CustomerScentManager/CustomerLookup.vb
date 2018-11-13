Public Class CustomerLookup
    Private Sub Cm_customersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Cm_customersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CustomersDataSet)

    End Sub

    Private Sub CustomerLookup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CustomersDataSet.cm_customers' table. You can move, or remove it, as needed.
        Me.Cm_customersTableAdapter.Fill(Me.CustomersDataSet.cm_customers)

    End Sub
End Class