Public Class Dashboard
    Private db As New FunctionsDataContext
    Private Sub Cm_customersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Cm_customersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CustomersDataSet)

    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CustomersDataSet.cm_customer_product' table. You can move, or remove it, as needed.
        Me.Cm_customer_productTableAdapter.Fill(Me.CustomersDataSet.cm_customer_product)
        'TODO: This line of code loads data into the 'CustomersDataSet.cm_products' table. You can move, or remove it, as needed.
        'Me.Cm_productsTableAdapter.Fill(Me.CustomersDataSet.cm_products)
        'TODO: This line of code loads data into the 'CustomersDataSet.cm_customers' table. You can move, or remove it, as needed.
        'Me.Cm_customersTableAdapter.Fill(Me.CustomersDataSet.cm_customers)

    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        'check to see if customer exits, if not create
        Dim checkCustomer = From cm_customers In db.cm_customers
                            Where cm_customers.Email = txtNewEmail.Text

        If checkCustomer.Count = 1 Then
            MsgBox("Customer could not be created because this customer already exists", MsgBoxStyle.Critical)
        Else
            Dim createCustomer = New cm_customer With {
                .Added = DateTime.Now.ToLongDateString(),
                .Address = txtNewAddress.Text,
                .Email = txtNewEmail.Text,
                .Name = txtNewCustomer.Text,
                .Telephone = txtNewPhone.Text
            }
            db.cm_customers.InsertOnSubmit(createCustomer)
            Try
                db.SubmitChanges()
                MsgBox("Customer has been created", MsgBoxStyle.Information)
                'Cm_customersTableAdapter.Fill(CustomersDataSet.cm_customers)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        'check if product and product scent exits
        Dim checkProduct = From cm_products In db.cm_products
                           Where cm_products.ProductName = txtNewProduct.Text And cm_products.ProductScent = txtNewScent.Text

        If checkProduct.Count = 1 Then
            MsgBox("This product is already in your inventory", MsgBoxStyle.Information)
        Else
            'add product to inventory
            Dim addProduct = New cm_product With {
                .AddedBy = My.Settings.Username,
                .BonusTester = cbNewTester.CheckState,
                .Created = DateTime.Now.ToLongDateString(),
                .OtherDetails = txtNewDetails.Text,
                .ProductColor = txtNewColor.Text,
                .ProductName = txtNewProduct.Text,
                .ProductScent = txtNewScent.Text,
                .ProductSize = txtNewSize.Text
            }
            db.cm_products.InsertOnSubmit(addProduct)
            Try
                db.SubmitChanges()
                MsgBox("Product has been added to your inventory", MsgBoxStyle.Information)
                'Cm_productsTableAdapter.Fill(CustomersDataSet.cm_products)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Cm_customersDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Cm_customersDataGridView.CellContentClick
        TabControl2.Visible = True
        txtCustomerID.Text = CustomerIDTextBox.Text
    End Sub

    Private Sub Cm_productsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Cm_productsDataGridView.CellContentClick
        TabControl2.SelectedTab = TabPage8
        txtProductID.Text = ProductIDTextBox.Text
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        TabControl2.SelectedTab = TabPage9
        txtProductID.Text = ProductIDTextBox.Text
    End Sub

    Private Sub btnAssign_Click(sender As Object, e As EventArgs) Handles btnAssign.Click
        Dim assignTester = New cm_customer_product With {
            .customerID = CustomerIDTextBox.Text,
            .productID = ProductIDTextBox.Text
        }
        db.cm_customer_products.InsertOnSubmit(assignTester)
        Try
            db.SubmitChanges()
            MsgBox("This product has been assigned to " & NameTextBox.Text, MsgBoxStyle.Information)
            Cm_customer_productTableAdapter.Fill(CustomersDataSet.cm_customer_product)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        txtCustomerID.Text = CustomerIDTextBox.Text
        TabControl2.SelectedTab = TabPage8
    End Sub

    Private Sub txtEmailSearch_TextChanged(sender As Object, e As EventArgs) Handles txtEmailSearch.TextChanged
        Try
            Me.Cm_customersTableAdapter.FillByEmail(Me.CustomersDataSet.cm_customers, txtEmailSearch.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtProductSearch_TextChanged(sender As Object, e As EventArgs) Handles txtProductSearch.TextChanged
        Try
            Me.Cm_productsTableAdapter.FillByProductName(Me.CustomersDataSet.cm_products, txtProductSearch.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class