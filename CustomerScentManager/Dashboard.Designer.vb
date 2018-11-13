<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CustomerIDLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim TelephoneLabel As System.Windows.Forms.Label
        Dim AddedLabel As System.Windows.Forms.Label
        Dim ProductIDLabel As System.Windows.Forms.Label
        Dim ProductNameLabel As System.Windows.Forms.Label
        Dim ProductScentLabel As System.Windows.Forms.Label
        Dim ProductSizeLabel As System.Windows.Forms.Label
        Dim ProductColorLabel As System.Windows.Forms.Label
        Dim BonusTesterLabel As System.Windows.Forms.Label
        Dim OtherDetailsLabel As System.Windows.Forms.Label
        Dim CreatedLabel As System.Windows.Forms.Label
        Dim AddedByLabel As System.Windows.Forms.Label
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.linkLogout = New System.Windows.Forms.LinkLabel()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.btnNewCustomer = New System.Windows.Forms.Button()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnTester = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNewPhone = New System.Windows.Forms.TextBox()
        Me.txtNewAddress = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNewEmail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNewCustomer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.Cm_customersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersDataSet = New CustomerScentManager.CustomersDataSet()
        Me.AddedTextBox = New System.Windows.Forms.TextBox()
        Me.TelephoneTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.ProductIDTextBox = New System.Windows.Forms.TextBox()
        Me.Cm_productsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductNameTextBox = New System.Windows.Forms.TextBox()
        Me.ProductScentTextBox = New System.Windows.Forms.TextBox()
        Me.ProductSizeTextBox = New System.Windows.Forms.TextBox()
        Me.ProductColorTextBox = New System.Windows.Forms.TextBox()
        Me.BonusTesterCheckBox = New System.Windows.Forms.CheckBox()
        Me.OtherDetailsTextBox = New System.Windows.Forms.TextBox()
        Me.CreatedTextBox = New System.Windows.Forms.TextBox()
        Me.AddedByTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.btnAssign = New System.Windows.Forms.Button()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.txtProductID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtProductSearch = New System.Windows.Forms.TextBox()
        Me.txtEmailSearch = New System.Windows.Forms.TextBox()
        Me.Cm_productsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cm_customersDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Cm_customer_productDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cm_customer_productBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAddProduct = New System.Windows.Forms.Button()
        Me.txtNewDetails = New System.Windows.Forms.RichTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbNewTester = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNewColor = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNewSize = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNewScent = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNewProduct = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Cm_customersTableAdapter = New CustomerScentManager.CustomersDataSetTableAdapters.cm_customersTableAdapter()
        Me.TableAdapterManager = New CustomerScentManager.CustomersDataSetTableAdapters.TableAdapterManager()
        Me.Cm_productsTableAdapter = New CustomerScentManager.CustomersDataSetTableAdapters.cm_productsTableAdapter()
        Me.Cm_customer_productTableAdapter = New CustomerScentManager.CustomersDataSetTableAdapters.cm_customer_productTableAdapter()
        CustomerIDLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        TelephoneLabel = New System.Windows.Forms.Label()
        AddedLabel = New System.Windows.Forms.Label()
        ProductIDLabel = New System.Windows.Forms.Label()
        ProductNameLabel = New System.Windows.Forms.Label()
        ProductScentLabel = New System.Windows.Forms.Label()
        ProductSizeLabel = New System.Windows.Forms.Label()
        ProductColorLabel = New System.Windows.Forms.Label()
        BonusTesterLabel = New System.Windows.Forms.Label()
        OtherDetailsLabel = New System.Windows.Forms.Label()
        CreatedLabel = New System.Windows.Forms.Label()
        AddedByLabel = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        Me.pnlMenu.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        CType(Me.Cm_customersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage8.SuspendLayout()
        CType(Me.Cm_productsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage9.SuspendLayout()
        CType(Me.Cm_productsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cm_customersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.Cm_customer_productDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cm_customer_productBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CustomerIDLabel
        '
        CustomerIDLabel.AutoSize = True
        CustomerIDLabel.Location = New System.Drawing.Point(11, 7)
        CustomerIDLabel.Name = "CustomerIDLabel"
        CustomerIDLabel.Size = New System.Drawing.Size(22, 18)
        CustomerIDLabel.TabIndex = 5
        CustomerIDLabel.Text = "ID"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(75, 7)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(48, 18)
        NameLabel.TabIndex = 7
        NameLabel.Text = "Name:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(227, 7)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(47, 18)
        EmailLabel.TabIndex = 9
        EmailLabel.Text = "Email:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(11, 53)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(62, 18)
        AddressLabel.TabIndex = 11
        AddressLabel.Text = "Address:"
        '
        'TelephoneLabel
        '
        TelephoneLabel.AutoSize = True
        TelephoneLabel.Location = New System.Drawing.Point(224, 53)
        TelephoneLabel.Name = "TelephoneLabel"
        TelephoneLabel.Size = New System.Drawing.Size(76, 18)
        TelephoneLabel.TabIndex = 13
        TelephoneLabel.Text = "Telephone:"
        '
        'AddedLabel
        '
        AddedLabel.AutoSize = True
        AddedLabel.Location = New System.Drawing.Point(11, 102)
        AddedLabel.Name = "AddedLabel"
        AddedLabel.Size = New System.Drawing.Size(52, 18)
        AddedLabel.TabIndex = 15
        AddedLabel.Text = "Added:"
        '
        'ProductIDLabel
        '
        ProductIDLabel.AutoSize = True
        ProductIDLabel.Location = New System.Drawing.Point(14, 9)
        ProductIDLabel.Name = "ProductIDLabel"
        ProductIDLabel.Size = New System.Drawing.Size(79, 18)
        ProductIDLabel.TabIndex = 0
        ProductIDLabel.Text = "product ID:"
        '
        'ProductNameLabel
        '
        ProductNameLabel.AutoSize = True
        ProductNameLabel.Location = New System.Drawing.Point(14, 37)
        ProductNameLabel.Name = "ProductNameLabel"
        ProductNameLabel.Size = New System.Drawing.Size(99, 18)
        ProductNameLabel.TabIndex = 2
        ProductNameLabel.Text = "Product Name:"
        '
        'ProductScentLabel
        '
        ProductScentLabel.AutoSize = True
        ProductScentLabel.Location = New System.Drawing.Point(14, 65)
        ProductScentLabel.Name = "ProductScentLabel"
        ProductScentLabel.Size = New System.Drawing.Size(97, 18)
        ProductScentLabel.TabIndex = 4
        ProductScentLabel.Text = "Product Scent:"
        '
        'ProductSizeLabel
        '
        ProductSizeLabel.AutoSize = True
        ProductSizeLabel.Location = New System.Drawing.Point(14, 93)
        ProductSizeLabel.Name = "ProductSizeLabel"
        ProductSizeLabel.Size = New System.Drawing.Size(88, 18)
        ProductSizeLabel.TabIndex = 6
        ProductSizeLabel.Text = "Product Size:"
        '
        'ProductColorLabel
        '
        ProductColorLabel.AutoSize = True
        ProductColorLabel.Location = New System.Drawing.Point(14, 121)
        ProductColorLabel.Name = "ProductColorLabel"
        ProductColorLabel.Size = New System.Drawing.Size(96, 18)
        ProductColorLabel.TabIndex = 8
        ProductColorLabel.Text = "Product Color:"
        '
        'BonusTesterLabel
        '
        BonusTesterLabel.AutoSize = True
        BonusTesterLabel.Location = New System.Drawing.Point(14, 151)
        BonusTesterLabel.Name = "BonusTesterLabel"
        BonusTesterLabel.Size = New System.Drawing.Size(92, 18)
        BonusTesterLabel.TabIndex = 10
        BonusTesterLabel.Text = "Bonus Tester:"
        '
        'OtherDetailsLabel
        '
        OtherDetailsLabel.AutoSize = True
        OtherDetailsLabel.Location = New System.Drawing.Point(14, 179)
        OtherDetailsLabel.Name = "OtherDetailsLabel"
        OtherDetailsLabel.Size = New System.Drawing.Size(94, 18)
        OtherDetailsLabel.TabIndex = 12
        OtherDetailsLabel.Text = "Other Details:"
        '
        'CreatedLabel
        '
        CreatedLabel.AutoSize = True
        CreatedLabel.Location = New System.Drawing.Point(14, 207)
        CreatedLabel.Name = "CreatedLabel"
        CreatedLabel.Size = New System.Drawing.Size(61, 18)
        CreatedLabel.TabIndex = 14
        CreatedLabel.Text = "Created:"
        '
        'AddedByLabel
        '
        AddedByLabel.AutoSize = True
        AddedByLabel.Location = New System.Drawing.Point(14, 235)
        AddedByLabel.Name = "AddedByLabel"
        AddedByLabel.Size = New System.Drawing.Size(71, 18)
        AddedByLabel.TabIndex = 16
        AddedByLabel.Text = "Added By:"
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.Purple
        Me.pnlHeader.Controls.Add(Me.linkLogout)
        Me.pnlHeader.Controls.Add(Me.lblWelcome)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.ForeColor = System.Drawing.Color.White
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(816, 37)
        Me.pnlHeader.TabIndex = 0
        '
        'linkLogout
        '
        Me.linkLogout.ActiveLinkColor = System.Drawing.Color.Thistle
        Me.linkLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkLogout.AutoSize = True
        Me.linkLogout.LinkColor = System.Drawing.Color.White
        Me.linkLogout.Location = New System.Drawing.Point(754, 6)
        Me.linkLogout.Name = "linkLogout"
        Me.linkLogout.Size = New System.Drawing.Size(50, 18)
        Me.linkLogout.TabIndex = 2
        Me.linkLogout.TabStop = True
        Me.linkLogout.Text = "Logout"
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Location = New System.Drawing.Point(6, 6)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(179, 18)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome to your dashboard"
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btnDashboard.FlatAppearance.BorderSize = 3
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.Location = New System.Drawing.Point(12, 6)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(173, 41)
        Me.btnDashboard.TabIndex = 5
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'btnNewCustomer
        '
        Me.btnNewCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.btnNewCustomer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btnNewCustomer.FlatAppearance.BorderSize = 3
        Me.btnNewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewCustomer.ForeColor = System.Drawing.Color.White
        Me.btnNewCustomer.Location = New System.Drawing.Point(191, 6)
        Me.btnNewCustomer.Name = "btnNewCustomer"
        Me.btnNewCustomer.Size = New System.Drawing.Size(175, 41)
        Me.btnNewCustomer.TabIndex = 6
        Me.btnNewCustomer.Text = "New Customer"
        Me.btnNewCustomer.UseVisualStyleBackColor = False
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.pnlMenu.Controls.Add(Me.btnSettings)
        Me.pnlMenu.Controls.Add(Me.btnTester)
        Me.pnlMenu.Controls.Add(Me.btnNewCustomer)
        Me.pnlMenu.Controls.Add(Me.btnDashboard)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlMenu.Location = New System.Drawing.Point(0, 37)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(816, 44)
        Me.pnlMenu.TabIndex = 1
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btnSettings.FlatAppearance.BorderSize = 3
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.ForeColor = System.Drawing.Color.White
        Me.btnSettings.Location = New System.Drawing.Point(553, 6)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(175, 41)
        Me.btnSettings.TabIndex = 7
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.UseVisualStyleBackColor = False
        '
        'btnTester
        '
        Me.btnTester.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.btnTester.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btnTester.FlatAppearance.BorderSize = 3
        Me.btnTester.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTester.ForeColor = System.Drawing.Color.White
        Me.btnTester.Location = New System.Drawing.Point(372, 6)
        Me.btnTester.Name = "btnTester"
        Me.btnTester.Size = New System.Drawing.Size(175, 41)
        Me.btnTester.TabIndex = 7
        Me.btnTester.Text = "Assign Tester"
        Me.btnTester.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(12, 90)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(792, 377)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(784, 346)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Dashboard"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnCreate)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.txtNewPhone)
        Me.TabPage2.Controls.Add(Me.txtNewAddress)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.txtNewEmail)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.txtNewCustomer)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(784, 351)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "New Customer"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.Color.Purple
        Me.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreate.ForeColor = System.Drawing.Color.White
        Me.btnCreate.Location = New System.Drawing.Point(591, 176)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(146, 34)
        Me.btnCreate.TabIndex = 8
        Me.btnCreate.Text = "Create Customer"
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(374, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Telephone"
        '
        'txtNewPhone
        '
        Me.txtNewPhone.Location = New System.Drawing.Point(379, 130)
        Me.txtNewPhone.Name = "txtNewPhone"
        Me.txtNewPhone.Size = New System.Drawing.Size(358, 22)
        Me.txtNewPhone.TabIndex = 6
        '
        'txtNewAddress
        '
        Me.txtNewAddress.Location = New System.Drawing.Point(28, 130)
        Me.txtNewAddress.Name = "txtNewAddress"
        Me.txtNewAddress.Size = New System.Drawing.Size(340, 22)
        Me.txtNewAddress.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Address"
        '
        'txtNewEmail
        '
        Me.txtNewEmail.Location = New System.Drawing.Point(379, 46)
        Me.txtNewEmail.Name = "txtNewEmail"
        Me.txtNewEmail.Size = New System.Drawing.Size(358, 22)
        Me.txtNewEmail.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(374, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Email"
        '
        'txtNewCustomer
        '
        Me.txtNewCustomer.Location = New System.Drawing.Point(28, 46)
        Me.txtNewCustomer.Name = "txtNewCustomer"
        Me.txtNewCustomer.Size = New System.Drawing.Size(340, 22)
        Me.txtNewCustomer.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Name"
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(Me.TabControl2)
        Me.TabPage3.Controls.Add(Me.txtProductSearch)
        Me.TabPage3.Controls.Add(Me.txtEmailSearch)
        Me.TabPage3.Controls.Add(Me.Cm_productsDataGridView)
        Me.TabPage3.Controls.Add(Me.Cm_customersDataGridView)
        Me.TabPage3.Location = New System.Drawing.Point(4, 27)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(784, 346)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Assign Tester"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage7)
        Me.TabControl2.Controls.Add(Me.TabPage8)
        Me.TabControl2.Controls.Add(Me.TabPage9)
        Me.TabControl2.Location = New System.Drawing.Point(356, 7)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(406, 320)
        Me.TabControl2.TabIndex = 19
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.btnLogin)
        Me.TabPage7.Controls.Add(Me.NameTextBox)
        Me.TabPage7.Controls.Add(Me.AddedTextBox)
        Me.TabPage7.Controls.Add(AddedLabel)
        Me.TabPage7.Controls.Add(CustomerIDLabel)
        Me.TabPage7.Controls.Add(Me.TelephoneTextBox)
        Me.TabPage7.Controls.Add(Me.CustomerIDTextBox)
        Me.TabPage7.Controls.Add(TelephoneLabel)
        Me.TabPage7.Controls.Add(NameLabel)
        Me.TabPage7.Controls.Add(Me.AddressTextBox)
        Me.TabPage7.Controls.Add(AddressLabel)
        Me.TabPage7.Controls.Add(EmailLabel)
        Me.TabPage7.Controls.Add(Me.EmailTextBox)
        Me.TabPage7.Location = New System.Drawing.Point(4, 27)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(398, 289)
        Me.TabPage7.TabIndex = 0
        Me.TabPage7.Text = "Customer"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Purple
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(298, 249)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(92, 34)
        Me.btnLogin.TabIndex = 17
        Me.btnLogin.Text = "Continue"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cm_customersBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(78, 28)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(143, 22)
        Me.NameTextBox.TabIndex = 8
        '
        'Cm_customersBindingSource
        '
        Me.Cm_customersBindingSource.DataMember = "cm_customers"
        Me.Cm_customersBindingSource.DataSource = Me.CustomersDataSet
        '
        'CustomersDataSet
        '
        Me.CustomersDataSet.DataSetName = "CustomersDataSet"
        Me.CustomersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AddedTextBox
        '
        Me.AddedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cm_customersBindingSource, "Added", True))
        Me.AddedTextBox.Location = New System.Drawing.Point(14, 123)
        Me.AddedTextBox.Name = "AddedTextBox"
        Me.AddedTextBox.Size = New System.Drawing.Size(376, 22)
        Me.AddedTextBox.TabIndex = 16
        '
        'TelephoneTextBox
        '
        Me.TelephoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cm_customersBindingSource, "Telephone", True))
        Me.TelephoneTextBox.Location = New System.Drawing.Point(227, 74)
        Me.TelephoneTextBox.Name = "TelephoneTextBox"
        Me.TelephoneTextBox.Size = New System.Drawing.Size(163, 22)
        Me.TelephoneTextBox.TabIndex = 14
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cm_customersBindingSource, "customerID", True))
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(14, 28)
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(58, 22)
        Me.CustomerIDTextBox.TabIndex = 6
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cm_customersBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(14, 74)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(207, 22)
        Me.AddressTextBox.TabIndex = 12
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cm_customersBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(227, 28)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(163, 22)
        Me.EmailTextBox.TabIndex = 10
        '
        'TabPage8
        '
        Me.TabPage8.AutoScroll = True
        Me.TabPage8.Controls.Add(Me.btnContinue)
        Me.TabPage8.Controls.Add(ProductIDLabel)
        Me.TabPage8.Controls.Add(Me.ProductIDTextBox)
        Me.TabPage8.Controls.Add(ProductNameLabel)
        Me.TabPage8.Controls.Add(Me.ProductNameTextBox)
        Me.TabPage8.Controls.Add(ProductScentLabel)
        Me.TabPage8.Controls.Add(Me.ProductScentTextBox)
        Me.TabPage8.Controls.Add(ProductSizeLabel)
        Me.TabPage8.Controls.Add(Me.ProductSizeTextBox)
        Me.TabPage8.Controls.Add(ProductColorLabel)
        Me.TabPage8.Controls.Add(Me.ProductColorTextBox)
        Me.TabPage8.Controls.Add(BonusTesterLabel)
        Me.TabPage8.Controls.Add(Me.BonusTesterCheckBox)
        Me.TabPage8.Controls.Add(OtherDetailsLabel)
        Me.TabPage8.Controls.Add(Me.OtherDetailsTextBox)
        Me.TabPage8.Controls.Add(CreatedLabel)
        Me.TabPage8.Controls.Add(Me.CreatedTextBox)
        Me.TabPage8.Controls.Add(AddedByLabel)
        Me.TabPage8.Controls.Add(Me.AddedByTextBox)
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(398, 294)
        Me.TabPage8.TabIndex = 1
        Me.TabPage8.Text = "Product"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'btnContinue
        '
        Me.btnContinue.BackColor = System.Drawing.Color.Purple
        Me.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContinue.ForeColor = System.Drawing.Color.White
        Me.btnContinue.Location = New System.Drawing.Point(300, 249)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(92, 34)
        Me.btnContinue.TabIndex = 18
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = False
        '
        'ProductIDTextBox
        '
        Me.ProductIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cm_productsBindingSource, "productID", True))
        Me.ProductIDTextBox.Location = New System.Drawing.Point(119, 6)
        Me.ProductIDTextBox.Name = "ProductIDTextBox"
        Me.ProductIDTextBox.ReadOnly = True
        Me.ProductIDTextBox.Size = New System.Drawing.Size(104, 22)
        Me.ProductIDTextBox.TabIndex = 1
        '
        'Cm_productsBindingSource
        '
        Me.Cm_productsBindingSource.DataMember = "cm_products"
        Me.Cm_productsBindingSource.DataSource = Me.CustomersDataSet
        '
        'ProductNameTextBox
        '
        Me.ProductNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cm_productsBindingSource, "ProductName", True))
        Me.ProductNameTextBox.Location = New System.Drawing.Point(119, 34)
        Me.ProductNameTextBox.Name = "ProductNameTextBox"
        Me.ProductNameTextBox.ReadOnly = True
        Me.ProductNameTextBox.Size = New System.Drawing.Size(104, 22)
        Me.ProductNameTextBox.TabIndex = 3
        '
        'ProductScentTextBox
        '
        Me.ProductScentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cm_productsBindingSource, "ProductScent", True))
        Me.ProductScentTextBox.Location = New System.Drawing.Point(119, 62)
        Me.ProductScentTextBox.Name = "ProductScentTextBox"
        Me.ProductScentTextBox.ReadOnly = True
        Me.ProductScentTextBox.Size = New System.Drawing.Size(104, 22)
        Me.ProductScentTextBox.TabIndex = 5
        '
        'ProductSizeTextBox
        '
        Me.ProductSizeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cm_productsBindingSource, "ProductSize", True))
        Me.ProductSizeTextBox.Location = New System.Drawing.Point(119, 90)
        Me.ProductSizeTextBox.Name = "ProductSizeTextBox"
        Me.ProductSizeTextBox.ReadOnly = True
        Me.ProductSizeTextBox.Size = New System.Drawing.Size(104, 22)
        Me.ProductSizeTextBox.TabIndex = 7
        '
        'ProductColorTextBox
        '
        Me.ProductColorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cm_productsBindingSource, "ProductColor", True))
        Me.ProductColorTextBox.Location = New System.Drawing.Point(119, 118)
        Me.ProductColorTextBox.Name = "ProductColorTextBox"
        Me.ProductColorTextBox.ReadOnly = True
        Me.ProductColorTextBox.Size = New System.Drawing.Size(104, 22)
        Me.ProductColorTextBox.TabIndex = 9
        '
        'BonusTesterCheckBox
        '
        Me.BonusTesterCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Cm_productsBindingSource, "BonusTester", True))
        Me.BonusTesterCheckBox.Location = New System.Drawing.Point(119, 146)
        Me.BonusTesterCheckBox.Name = "BonusTesterCheckBox"
        Me.BonusTesterCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.BonusTesterCheckBox.TabIndex = 11
        Me.BonusTesterCheckBox.Text = "CheckBox1"
        Me.BonusTesterCheckBox.UseVisualStyleBackColor = True
        '
        'OtherDetailsTextBox
        '
        Me.OtherDetailsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cm_productsBindingSource, "OtherDetails", True))
        Me.OtherDetailsTextBox.Location = New System.Drawing.Point(119, 176)
        Me.OtherDetailsTextBox.Name = "OtherDetailsTextBox"
        Me.OtherDetailsTextBox.ReadOnly = True
        Me.OtherDetailsTextBox.Size = New System.Drawing.Size(104, 22)
        Me.OtherDetailsTextBox.TabIndex = 13
        '
        'CreatedTextBox
        '
        Me.CreatedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cm_productsBindingSource, "Created", True))
        Me.CreatedTextBox.Location = New System.Drawing.Point(119, 204)
        Me.CreatedTextBox.Name = "CreatedTextBox"
        Me.CreatedTextBox.ReadOnly = True
        Me.CreatedTextBox.Size = New System.Drawing.Size(104, 22)
        Me.CreatedTextBox.TabIndex = 15
        '
        'AddedByTextBox
        '
        Me.AddedByTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cm_productsBindingSource, "AddedBy", True))
        Me.AddedByTextBox.Location = New System.Drawing.Point(119, 232)
        Me.AddedByTextBox.Name = "AddedByTextBox"
        Me.AddedByTextBox.ReadOnly = True
        Me.AddedByTextBox.Size = New System.Drawing.Size(104, 22)
        Me.AddedByTextBox.TabIndex = 17
        '
        'TabPage9
        '
        Me.TabPage9.Controls.Add(Me.btnAssign)
        Me.TabPage9.Controls.Add(Me.txtCustomerID)
        Me.TabPage9.Controls.Add(Me.txtProductID)
        Me.TabPage9.Controls.Add(Me.Label6)
        Me.TabPage9.Controls.Add(Me.Label5)
        Me.TabPage9.Location = New System.Drawing.Point(4, 22)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage9.Size = New System.Drawing.Size(398, 294)
        Me.TabPage9.TabIndex = 2
        Me.TabPage9.Text = "Assign"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'btnAssign
        '
        Me.btnAssign.BackColor = System.Drawing.Color.Purple
        Me.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAssign.ForeColor = System.Drawing.Color.White
        Me.btnAssign.Location = New System.Drawing.Point(139, 249)
        Me.btnAssign.Name = "btnAssign"
        Me.btnAssign.Size = New System.Drawing.Size(253, 34)
        Me.btnAssign.TabIndex = 5
        Me.btnAssign.Text = "Assign this tester kit to this customer"
        Me.btnAssign.UseVisualStyleBackColor = False
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Location = New System.Drawing.Point(292, 30)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(100, 22)
        Me.txtCustomerID.TabIndex = 3
        '
        'txtProductID
        '
        Me.txtProductID.Location = New System.Drawing.Point(6, 30)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.Size = New System.Drawing.Size(100, 22)
        Me.txtProductID.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(289, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 18)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Customer ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 18)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Product ID"
        '
        'txtProductSearch
        '
        Me.txtProductSearch.Location = New System.Drawing.Point(19, 176)
        Me.txtProductSearch.Name = "txtProductSearch"
        Me.txtProductSearch.Size = New System.Drawing.Size(318, 22)
        Me.txtProductSearch.TabIndex = 18
        Me.txtProductSearch.Text = "Search by product name"
        '
        'txtEmailSearch
        '
        Me.txtEmailSearch.Location = New System.Drawing.Point(19, 7)
        Me.txtEmailSearch.Name = "txtEmailSearch"
        Me.txtEmailSearch.Size = New System.Drawing.Size(318, 22)
        Me.txtEmailSearch.TabIndex = 17
        Me.txtEmailSearch.Text = "Search by email"
        '
        'Cm_productsDataGridView
        '
        Me.Cm_productsDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Cm_productsDataGridView.AutoGenerateColumns = False
        Me.Cm_productsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Cm_productsDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.Cm_productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Cm_productsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4})
        Me.Cm_productsDataGridView.DataSource = Me.Cm_productsBindingSource
        Me.Cm_productsDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Cm_productsDataGridView.Location = New System.Drawing.Point(19, 204)
        Me.Cm_productsDataGridView.Name = "Cm_productsDataGridView"
        Me.Cm_productsDataGridView.RowHeadersVisible = False
        Me.Cm_productsDataGridView.Size = New System.Drawing.Size(318, 119)
        Me.Cm_productsDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ProductName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ProductName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ProductScent"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ProductScent"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Cm_customersDataGridView
        '
        Me.Cm_customersDataGridView.AutoGenerateColumns = False
        Me.Cm_customersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Cm_customersDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.Cm_customersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Cm_customersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3})
        Me.Cm_customersDataGridView.DataSource = Me.Cm_customersBindingSource
        Me.Cm_customersDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Cm_customersDataGridView.Location = New System.Drawing.Point(19, 33)
        Me.Cm_customersDataGridView.Name = "Cm_customersDataGridView"
        Me.Cm_customersDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Cm_customersDataGridView.RowHeadersVisible = False
        Me.Cm_customersDataGridView.Size = New System.Drawing.Size(318, 137)
        Me.Cm_customersDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'TabPage4
        '
        Me.TabPage4.AutoScroll = True
        Me.TabPage4.Controls.Add(Me.Cm_customer_productDataGridView)
        Me.TabPage4.Controls.Add(Me.Panel1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(784, 351)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Settings"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Cm_customer_productDataGridView
        '
        Me.Cm_customer_productDataGridView.AutoGenerateColumns = False
        Me.Cm_customer_productDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.Cm_customer_productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Cm_customer_productDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.Cm_customer_productDataGridView.DataSource = Me.Cm_customer_productBindingSource
        Me.Cm_customer_productDataGridView.Location = New System.Drawing.Point(304, 12)
        Me.Cm_customer_productDataGridView.Name = "Cm_customer_productDataGridView"
        Me.Cm_customer_productDataGridView.Size = New System.Drawing.Size(444, 220)
        Me.Cm_customer_productDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "productID"
        Me.DataGridViewTextBoxColumn5.HeaderText = "productID"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "customerID"
        Me.DataGridViewTextBoxColumn6.HeaderText = "customerID"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Added"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Added"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'Cm_customer_productBindingSource
        '
        Me.Cm_customer_productBindingSource.DataMember = "customerFK"
        Me.Cm_customer_productBindingSource.DataSource = Me.Cm_customersBindingSource
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Purple
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(6, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(281, 318)
        Me.Panel1.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 18)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Add New Products"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.btnAddProduct)
        Me.Panel2.Controls.Add(Me.txtNewDetails)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.cbNewTester)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.txtNewColor)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.txtNewSize)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.txtNewScent)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.txtNewProduct)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.ForeColor = System.Drawing.Color.Purple
        Me.Panel2.Location = New System.Drawing.Point(3, 29)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(275, 286)
        Me.Panel2.TabIndex = 0
        '
        'btnAddProduct
        '
        Me.btnAddProduct.BackColor = System.Drawing.Color.Purple
        Me.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddProduct.ForeColor = System.Drawing.Color.White
        Me.btnAddProduct.Location = New System.Drawing.Point(146, 237)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(105, 30)
        Me.btnAddProduct.TabIndex = 12
        Me.btnAddProduct.Text = "Add Product"
        Me.btnAddProduct.UseVisualStyleBackColor = False
        '
        'txtNewDetails
        '
        Me.txtNewDetails.Location = New System.Drawing.Point(22, 186)
        Me.txtNewDetails.Name = "txtNewDetails"
        Me.txtNewDetails.Size = New System.Drawing.Size(229, 45)
        Me.txtNewDetails.TabIndex = 11
        Me.txtNewDetails.Text = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(22, 164)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 18)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Other Details"
        '
        'cbNewTester
        '
        Me.cbNewTester.AutoSize = True
        Me.cbNewTester.Location = New System.Drawing.Point(129, 134)
        Me.cbNewTester.Name = "cbNewTester"
        Me.cbNewTester.Size = New System.Drawing.Size(15, 14)
        Me.cbNewTester.TabIndex = 9
        Me.cbNewTester.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(129, 116)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 18)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Bonus Tester"
        '
        'txtNewColor
        '
        Me.txtNewColor.Location = New System.Drawing.Point(22, 134)
        Me.txtNewColor.Name = "txtNewColor"
        Me.txtNewColor.Size = New System.Drawing.Size(100, 22)
        Me.txtNewColor.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(19, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 18)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Color"
        '
        'txtNewSize
        '
        Me.txtNewSize.Location = New System.Drawing.Point(146, 82)
        Me.txtNewSize.Name = "txtNewSize"
        Me.txtNewSize.Size = New System.Drawing.Size(105, 22)
        Me.txtNewSize.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(143, 61)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 18)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Size"
        '
        'txtNewScent
        '
        Me.txtNewScent.Location = New System.Drawing.Point(22, 82)
        Me.txtNewScent.Name = "txtNewScent"
        Me.txtNewScent.Size = New System.Drawing.Size(118, 22)
        Me.txtNewScent.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 18)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Scent"
        '
        'txtNewProduct
        '
        Me.txtNewProduct.Location = New System.Drawing.Point(22, 34)
        Me.txtNewProduct.Name = "txtNewProduct"
        Me.txtNewProduct.Size = New System.Drawing.Size(232, 22)
        Me.txtNewProduct.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 18)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Product Name"
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
        Me.TableAdapterManager.cm_productsTableAdapter = Me.Cm_productsTableAdapter
        Me.TableAdapterManager.cm_usersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CustomerScentManager.CustomersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Cm_productsTableAdapter
        '
        Me.Cm_productsTableAdapter.ClearBeforeFill = True
        '
        'Cm_customer_productTableAdapter
        '
        Me.Cm_customer_productTableAdapter.ClearBeforeFill = True
        '
        'Dashboard
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(816, 479)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Sitka Small", 9.0!)
        Me.ForeColor = System.Drawing.Color.Purple
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlMenu.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        CType(Me.Cm_customersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage8.PerformLayout()
        CType(Me.Cm_productsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage9.ResumeLayout(False)
        Me.TabPage9.PerformLayout()
        CType(Me.Cm_productsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cm_customersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.Cm_customer_productDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cm_customer_productBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblWelcome As Label
    Friend WithEvents linkLogout As LinkLabel
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnNewCustomer As Button
    Friend WithEvents pnlMenu As Panel
    Friend WithEvents btnSettings As Button
    Friend WithEvents btnTester As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNewPhone As TextBox
    Friend WithEvents txtNewAddress As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNewEmail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNewCustomer As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents btnCreate As Button
    Friend WithEvents CustomersDataSet As CustomersDataSet
    Friend WithEvents Cm_customersBindingSource As BindingSource
    Friend WithEvents Cm_customersTableAdapter As CustomersDataSetTableAdapters.cm_customersTableAdapter
    Friend WithEvents TableAdapterManager As CustomersDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Cm_customersDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Cm_productsTableAdapter As CustomersDataSetTableAdapters.cm_productsTableAdapter
    Friend WithEvents Cm_productsBindingSource As BindingSource
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents AddedTextBox As TextBox
    Friend WithEvents TelephoneTextBox As TextBox
    Friend WithEvents CustomerIDTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents ProductIDTextBox As TextBox
    Friend WithEvents ProductNameTextBox As TextBox
    Friend WithEvents ProductScentTextBox As TextBox
    Friend WithEvents ProductSizeTextBox As TextBox
    Friend WithEvents ProductColorTextBox As TextBox
    Friend WithEvents BonusTesterCheckBox As CheckBox
    Friend WithEvents OtherDetailsTextBox As TextBox
    Friend WithEvents CreatedTextBox As TextBox
    Friend WithEvents AddedByTextBox As TextBox
    Friend WithEvents TabPage9 As TabPage
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents txtProductID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtProductSearch As TextBox
    Friend WithEvents txtEmailSearch As TextBox
    Friend WithEvents Cm_productsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtNewDetails As RichTextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cbNewTester As CheckBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtNewColor As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtNewSize As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtNewScent As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtNewProduct As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnAddProduct As Button
    Friend WithEvents btnContinue As Button
    Friend WithEvents btnAssign As Button
    Friend WithEvents Cm_customer_productBindingSource As BindingSource
    Friend WithEvents Cm_customer_productTableAdapter As CustomersDataSetTableAdapters.cm_customer_productTableAdapter
    Friend WithEvents Cm_customer_productDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents btnLogin As Button
End Class
