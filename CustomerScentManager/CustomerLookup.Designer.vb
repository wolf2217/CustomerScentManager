<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerLookup
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CustomerIDLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim TelephoneLabel As System.Windows.Forms.Label
        Dim AddedLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.CustomersDataSet = New CustomerScentManager.CustomersDataSet()
        Me.Cm_customersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cm_customersTableAdapter = New CustomerScentManager.CustomersDataSetTableAdapters.cm_customersTableAdapter()
        Me.TableAdapterManager = New CustomerScentManager.CustomersDataSetTableAdapters.TableAdapterManager()
        Me.Cm_customersDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.TelephoneTextBox = New System.Windows.Forms.TextBox()
        Me.AddedTextBox = New System.Windows.Forms.TextBox()
        Me.btnSelect = New System.Windows.Forms.Button()
        CustomerIDLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        TelephoneLabel = New System.Windows.Forms.Label()
        AddedLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.CustomersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cm_customersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cm_customersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Purple
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Sitka Small", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(629, 46)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Small", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Lookup"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Email Lookup"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(106, 64)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(460, 21)
        Me.txtEmail.TabIndex = 2
        '
        'CustomersDataSet
        '
        Me.CustomersDataSet.DataSetName = "CustomersDataSet"
        Me.CustomersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Cm_customersBindingSource
        '
        Me.Cm_customersBindingSource.DataMember = "cm_customers"
        Me.Cm_customersBindingSource.DataSource = Me.CustomersDataSet
        '
        'Cm_customersTableAdapter
        '
        Me.Cm_customersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cm_customer_productTableAdapter = Nothing
        Me.TableAdapterManager.cm_customersTableAdapter = Me.Cm_customersTableAdapter
        Me.TableAdapterManager.cm_productsTableAdapter = Nothing
        Me.TableAdapterManager.cm_usersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CustomerScentManager.CustomersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Cm_customersDataGridView
        '
        Me.Cm_customersDataGridView.AutoGenerateColumns = False
        Me.Cm_customersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Cm_customersDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.Cm_customersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Cm_customersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.Cm_customersDataGridView.DataSource = Me.Cm_customersBindingSource
        Me.Cm_customersDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Cm_customersDataGridView.Location = New System.Drawing.Point(18, 91)
        Me.Cm_customersDataGridView.Name = "Cm_customersDataGridView"
        Me.Cm_customersDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Cm_customersDataGridView.RowHeadersVisible = False
        Me.Cm_customersDataGridView.Size = New System.Drawing.Size(591, 110)
        Me.Cm_customersDataGridView.TabIndex = 4
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Telephone"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Telephone"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'CustomerIDLabel
        '
        CustomerIDLabel.AutoSize = True
        CustomerIDLabel.Location = New System.Drawing.Point(20, 217)
        CustomerIDLabel.Name = "CustomerIDLabel"
        CustomerIDLabel.Size = New System.Drawing.Size(80, 16)
        CustomerIDLabel.TabIndex = 4
        CustomerIDLabel.Text = "customer ID:"
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cm_customersBindingSource, "customerID", True))
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(106, 214)
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(100, 21)
        Me.CustomerIDTextBox.TabIndex = 5
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(231, 217)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(44, 16)
        NameLabel.TabIndex = 6
        NameLabel.Text = "Name:"
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cm_customersBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(317, 214)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(292, 21)
        Me.NameTextBox.TabIndex = 7
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(20, 244)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(44, 16)
        EmailLabel.TabIndex = 8
        EmailLabel.Text = "Email:"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cm_customersBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(106, 241)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(292, 21)
        Me.EmailTextBox.TabIndex = 9
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(20, 271)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(57, 16)
        AddressLabel.TabIndex = 10
        AddressLabel.Text = "Address:"
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cm_customersBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(106, 268)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(292, 21)
        Me.AddressTextBox.TabIndex = 11
        '
        'TelephoneLabel
        '
        TelephoneLabel.AutoSize = True
        TelephoneLabel.Location = New System.Drawing.Point(20, 298)
        TelephoneLabel.Name = "TelephoneLabel"
        TelephoneLabel.Size = New System.Drawing.Size(68, 16)
        TelephoneLabel.TabIndex = 12
        TelephoneLabel.Text = "Telephone:"
        '
        'TelephoneTextBox
        '
        Me.TelephoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cm_customersBindingSource, "Telephone", True))
        Me.TelephoneTextBox.Location = New System.Drawing.Point(106, 295)
        Me.TelephoneTextBox.Name = "TelephoneTextBox"
        Me.TelephoneTextBox.Size = New System.Drawing.Size(292, 21)
        Me.TelephoneTextBox.TabIndex = 13
        '
        'AddedLabel
        '
        AddedLabel.AutoSize = True
        AddedLabel.Location = New System.Drawing.Point(20, 325)
        AddedLabel.Name = "AddedLabel"
        AddedLabel.Size = New System.Drawing.Size(47, 16)
        AddedLabel.TabIndex = 14
        AddedLabel.Text = "Added:"
        '
        'AddedTextBox
        '
        Me.AddedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cm_customersBindingSource, "Added", True))
        Me.AddedTextBox.Location = New System.Drawing.Point(106, 322)
        Me.AddedTextBox.Name = "AddedTextBox"
        Me.AddedTextBox.Size = New System.Drawing.Size(292, 21)
        Me.AddedTextBox.TabIndex = 15
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.Color.Purple
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelect.ForeColor = System.Drawing.Color.White
        Me.btnSelect.Location = New System.Drawing.Point(486, 307)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(123, 34)
        Me.btnSelect.TabIndex = 16
        Me.btnSelect.Text = "Select Customer"
        Me.btnSelect.UseVisualStyleBackColor = False
        '
        'CustomerLookup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(629, 358)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(CustomerIDLabel)
        Me.Controls.Add(Me.CustomerIDTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(TelephoneLabel)
        Me.Controls.Add(Me.TelephoneTextBox)
        Me.Controls.Add(AddedLabel)
        Me.Controls.Add(Me.AddedTextBox)
        Me.Controls.Add(Me.Cm_customersDataGridView)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Sitka Small", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Purple
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "CustomerLookup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CustomerLookup"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.CustomersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cm_customersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cm_customersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents CustomersDataSet As CustomersDataSet
    Friend WithEvents Cm_customersBindingSource As BindingSource
    Friend WithEvents Cm_customersTableAdapter As CustomersDataSetTableAdapters.cm_customersTableAdapter
    Friend WithEvents TableAdapterManager As CustomersDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Cm_customersDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents CustomerIDTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents TelephoneTextBox As TextBox
    Friend WithEvents AddedTextBox As TextBox
    Friend WithEvents btnSelect As Button
End Class
