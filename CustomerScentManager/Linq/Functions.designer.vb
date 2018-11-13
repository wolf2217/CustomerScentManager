﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="Customers")>  _
Partial Public Class FunctionsDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub Insertcm_customer(instance As cm_customer)
    End Sub
  Partial Private Sub Updatecm_customer(instance As cm_customer)
    End Sub
  Partial Private Sub Deletecm_customer(instance As cm_customer)
    End Sub
  Partial Private Sub Insertcm_product(instance As cm_product)
    End Sub
  Partial Private Sub Updatecm_product(instance As cm_product)
    End Sub
  Partial Private Sub Deletecm_product(instance As cm_product)
    End Sub
  Partial Private Sub Insertcm_user(instance As cm_user)
    End Sub
  Partial Private Sub Updatecm_user(instance As cm_user)
    End Sub
  Partial Private Sub Deletecm_user(instance As cm_user)
    End Sub
  Partial Private Sub Insertcm_customer_product(instance As cm_customer_product)
    End Sub
  Partial Private Sub Updatecm_customer_product(instance As cm_customer_product)
    End Sub
  Partial Private Sub Deletecm_customer_product(instance As cm_customer_product)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.CustomerScentManager.My.MySettings.Default.CustomersConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property cm_customers() As System.Data.Linq.Table(Of cm_customer)
		Get
			Return Me.GetTable(Of cm_customer)
		End Get
	End Property
	
	Public ReadOnly Property cm_products() As System.Data.Linq.Table(Of cm_product)
		Get
			Return Me.GetTable(Of cm_product)
		End Get
	End Property
	
	Public ReadOnly Property cm_users() As System.Data.Linq.Table(Of cm_user)
		Get
			Return Me.GetTable(Of cm_user)
		End Get
	End Property
	
	Public ReadOnly Property cm_customer_products() As System.Data.Linq.Table(Of cm_customer_product)
		Get
			Return Me.GetTable(Of cm_customer_product)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.cm_customers")>  _
Partial Public Class cm_customer
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _customerID As Integer
	
	Private _Name As String
	
	Private _Email As String
	
	Private _Address As String
	
	Private _Telephone As String
	
	Private _Added As String
	
	Private _cm_customer_products As EntitySet(Of cm_customer_product)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OncustomerIDChanging(value As Integer)
    End Sub
    Partial Private Sub OncustomerIDChanged()
    End Sub
    Partial Private Sub OnNameChanging(value As String)
    End Sub
    Partial Private Sub OnNameChanged()
    End Sub
    Partial Private Sub OnEmailChanging(value As String)
    End Sub
    Partial Private Sub OnEmailChanged()
    End Sub
    Partial Private Sub OnAddressChanging(value As String)
    End Sub
    Partial Private Sub OnAddressChanged()
    End Sub
    Partial Private Sub OnTelephoneChanging(value As String)
    End Sub
    Partial Private Sub OnTelephoneChanged()
    End Sub
    Partial Private Sub OnAddedChanging(value As String)
    End Sub
    Partial Private Sub OnAddedChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._cm_customer_products = New EntitySet(Of cm_customer_product)(AddressOf Me.attach_cm_customer_products, AddressOf Me.detach_cm_customer_products)
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_customerID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property customerID() As Integer
		Get
			Return Me._customerID
		End Get
		Set
			If ((Me._customerID = value)  _
						= false) Then
				Me.OncustomerIDChanging(value)
				Me.SendPropertyChanging
				Me._customerID = value
				Me.SendPropertyChanged("customerID")
				Me.OncustomerIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Name", DbType:="NVarChar(100)")>  _
	Public Property Name() As String
		Get
			Return Me._Name
		End Get
		Set
			If (String.Equals(Me._Name, value) = false) Then
				Me.OnNameChanging(value)
				Me.SendPropertyChanging
				Me._Name = value
				Me.SendPropertyChanged("Name")
				Me.OnNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Email", DbType:="NVarChar(100)")>  _
	Public Property Email() As String
		Get
			Return Me._Email
		End Get
		Set
			If (String.Equals(Me._Email, value) = false) Then
				Me.OnEmailChanging(value)
				Me.SendPropertyChanging
				Me._Email = value
				Me.SendPropertyChanged("Email")
				Me.OnEmailChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Address", DbType:="NVarChar(50)")>  _
	Public Property Address() As String
		Get
			Return Me._Address
		End Get
		Set
			If (String.Equals(Me._Address, value) = false) Then
				Me.OnAddressChanging(value)
				Me.SendPropertyChanging
				Me._Address = value
				Me.SendPropertyChanged("Address")
				Me.OnAddressChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Telephone", DbType:="NVarChar(50)")>  _
	Public Property Telephone() As String
		Get
			Return Me._Telephone
		End Get
		Set
			If (String.Equals(Me._Telephone, value) = false) Then
				Me.OnTelephoneChanging(value)
				Me.SendPropertyChanging
				Me._Telephone = value
				Me.SendPropertyChanged("Telephone")
				Me.OnTelephoneChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Added", DbType:="NVarChar(50)")>  _
	Public Property Added() As String
		Get
			Return Me._Added
		End Get
		Set
			If (String.Equals(Me._Added, value) = false) Then
				Me.OnAddedChanging(value)
				Me.SendPropertyChanging
				Me._Added = value
				Me.SendPropertyChanged("Added")
				Me.OnAddedChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="cm_customer_cm_customer_product", Storage:="_cm_customer_products", ThisKey:="customerID", OtherKey:="customerID")>  _
	Public Property cm_customer_products() As EntitySet(Of cm_customer_product)
		Get
			Return Me._cm_customer_products
		End Get
		Set
			Me._cm_customer_products.Assign(value)
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
	
	Private Sub attach_cm_customer_products(ByVal entity As cm_customer_product)
		Me.SendPropertyChanging
		entity.cm_customer = Me
	End Sub
	
	Private Sub detach_cm_customer_products(ByVal entity As cm_customer_product)
		Me.SendPropertyChanging
		entity.cm_customer = Nothing
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.cm_products")>  _
Partial Public Class cm_product
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _productID As Integer
	
	Private _ProductName As String
	
	Private _ProductScent As String
	
	Private _ProductSize As String
	
	Private _ProductColor As String
	
	Private _BonusTester As System.Nullable(Of Boolean)
	
	Private _OtherDetails As String
	
	Private _Created As String
	
	Private _AddedBy As String
	
	Private _cm_customer_products As EntitySet(Of cm_customer_product)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnproductIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnproductIDChanged()
    End Sub
    Partial Private Sub OnProductNameChanging(value As String)
    End Sub
    Partial Private Sub OnProductNameChanged()
    End Sub
    Partial Private Sub OnProductScentChanging(value As String)
    End Sub
    Partial Private Sub OnProductScentChanged()
    End Sub
    Partial Private Sub OnProductSizeChanging(value As String)
    End Sub
    Partial Private Sub OnProductSizeChanged()
    End Sub
    Partial Private Sub OnProductColorChanging(value As String)
    End Sub
    Partial Private Sub OnProductColorChanged()
    End Sub
    Partial Private Sub OnBonusTesterChanging(value As System.Nullable(Of Boolean))
    End Sub
    Partial Private Sub OnBonusTesterChanged()
    End Sub
    Partial Private Sub OnOtherDetailsChanging(value As String)
    End Sub
    Partial Private Sub OnOtherDetailsChanged()
    End Sub
    Partial Private Sub OnCreatedChanging(value As String)
    End Sub
    Partial Private Sub OnCreatedChanged()
    End Sub
    Partial Private Sub OnAddedByChanging(value As String)
    End Sub
    Partial Private Sub OnAddedByChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._cm_customer_products = New EntitySet(Of cm_customer_product)(AddressOf Me.attach_cm_customer_products, AddressOf Me.detach_cm_customer_products)
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_productID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property productID() As Integer
		Get
			Return Me._productID
		End Get
		Set
			If ((Me._productID = value)  _
						= false) Then
				Me.OnproductIDChanging(value)
				Me.SendPropertyChanging
				Me._productID = value
				Me.SendPropertyChanged("productID")
				Me.OnproductIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ProductName", DbType:="NVarChar(50)")>  _
	Public Property ProductName() As String
		Get
			Return Me._ProductName
		End Get
		Set
			If (String.Equals(Me._ProductName, value) = false) Then
				Me.OnProductNameChanging(value)
				Me.SendPropertyChanging
				Me._ProductName = value
				Me.SendPropertyChanged("ProductName")
				Me.OnProductNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ProductScent", DbType:="NVarChar(50)")>  _
	Public Property ProductScent() As String
		Get
			Return Me._ProductScent
		End Get
		Set
			If (String.Equals(Me._ProductScent, value) = false) Then
				Me.OnProductScentChanging(value)
				Me.SendPropertyChanging
				Me._ProductScent = value
				Me.SendPropertyChanged("ProductScent")
				Me.OnProductScentChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ProductSize", DbType:="NVarChar(50)")>  _
	Public Property ProductSize() As String
		Get
			Return Me._ProductSize
		End Get
		Set
			If (String.Equals(Me._ProductSize, value) = false) Then
				Me.OnProductSizeChanging(value)
				Me.SendPropertyChanging
				Me._ProductSize = value
				Me.SendPropertyChanged("ProductSize")
				Me.OnProductSizeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ProductColor", DbType:="NVarChar(50)")>  _
	Public Property ProductColor() As String
		Get
			Return Me._ProductColor
		End Get
		Set
			If (String.Equals(Me._ProductColor, value) = false) Then
				Me.OnProductColorChanging(value)
				Me.SendPropertyChanging
				Me._ProductColor = value
				Me.SendPropertyChanged("ProductColor")
				Me.OnProductColorChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_BonusTester", DbType:="Bit")>  _
	Public Property BonusTester() As System.Nullable(Of Boolean)
		Get
			Return Me._BonusTester
		End Get
		Set
			If (Me._BonusTester.Equals(value) = false) Then
				Me.OnBonusTesterChanging(value)
				Me.SendPropertyChanging
				Me._BonusTester = value
				Me.SendPropertyChanged("BonusTester")
				Me.OnBonusTesterChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_OtherDetails", DbType:="NVarChar(MAX)")>  _
	Public Property OtherDetails() As String
		Get
			Return Me._OtherDetails
		End Get
		Set
			If (String.Equals(Me._OtherDetails, value) = false) Then
				Me.OnOtherDetailsChanging(value)
				Me.SendPropertyChanging
				Me._OtherDetails = value
				Me.SendPropertyChanged("OtherDetails")
				Me.OnOtherDetailsChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Created", DbType:="NVarChar(50)")>  _
	Public Property Created() As String
		Get
			Return Me._Created
		End Get
		Set
			If (String.Equals(Me._Created, value) = false) Then
				Me.OnCreatedChanging(value)
				Me.SendPropertyChanging
				Me._Created = value
				Me.SendPropertyChanged("Created")
				Me.OnCreatedChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_AddedBy", DbType:="NVarChar(50)")>  _
	Public Property AddedBy() As String
		Get
			Return Me._AddedBy
		End Get
		Set
			If (String.Equals(Me._AddedBy, value) = false) Then
				Me.OnAddedByChanging(value)
				Me.SendPropertyChanging
				Me._AddedBy = value
				Me.SendPropertyChanged("AddedBy")
				Me.OnAddedByChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="cm_product_cm_customer_product", Storage:="_cm_customer_products", ThisKey:="productID", OtherKey:="productID")>  _
	Public Property cm_customer_products() As EntitySet(Of cm_customer_product)
		Get
			Return Me._cm_customer_products
		End Get
		Set
			Me._cm_customer_products.Assign(value)
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
	
	Private Sub attach_cm_customer_products(ByVal entity As cm_customer_product)
		Me.SendPropertyChanging
		entity.cm_product = Me
	End Sub
	
	Private Sub detach_cm_customer_products(ByVal entity As cm_customer_product)
		Me.SendPropertyChanging
		entity.cm_product = Nothing
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.cm_users")>  _
Partial Public Class cm_user
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _userID As Integer
	
	Private _Username As String
	
	Private _Password As String
	
	Private _Created As String
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnuserIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnuserIDChanged()
    End Sub
    Partial Private Sub OnUsernameChanging(value As String)
    End Sub
    Partial Private Sub OnUsernameChanged()
    End Sub
    Partial Private Sub OnPasswordChanging(value As String)
    End Sub
    Partial Private Sub OnPasswordChanged()
    End Sub
    Partial Private Sub OnCreatedChanging(value As String)
    End Sub
    Partial Private Sub OnCreatedChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_userID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property userID() As Integer
		Get
			Return Me._userID
		End Get
		Set
			If ((Me._userID = value)  _
						= false) Then
				Me.OnuserIDChanging(value)
				Me.SendPropertyChanging
				Me._userID = value
				Me.SendPropertyChanged("userID")
				Me.OnuserIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Username", DbType:="NVarChar(50)")>  _
	Public Property Username() As String
		Get
			Return Me._Username
		End Get
		Set
			If (String.Equals(Me._Username, value) = false) Then
				Me.OnUsernameChanging(value)
				Me.SendPropertyChanging
				Me._Username = value
				Me.SendPropertyChanged("Username")
				Me.OnUsernameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Password", DbType:="NVarChar(50)")>  _
	Public Property Password() As String
		Get
			Return Me._Password
		End Get
		Set
			If (String.Equals(Me._Password, value) = false) Then
				Me.OnPasswordChanging(value)
				Me.SendPropertyChanging
				Me._Password = value
				Me.SendPropertyChanged("Password")
				Me.OnPasswordChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Created", DbType:="NVarChar(50)")>  _
	Public Property Created() As String
		Get
			Return Me._Created
		End Get
		Set
			If (String.Equals(Me._Created, value) = false) Then
				Me.OnCreatedChanging(value)
				Me.SendPropertyChanging
				Me._Created = value
				Me.SendPropertyChanged("Created")
				Me.OnCreatedChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.cm_customer_product")>  _
Partial Public Class cm_customer_product
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _Id As Integer
	
	Private _productID As Integer
	
	Private _customerID As Integer
	
	Private _Added As String
	
	Private _cm_customer As EntityRef(Of cm_customer)
	
	Private _cm_product As EntityRef(Of cm_product)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnIdChanged()
    End Sub
    Partial Private Sub OnproductIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnproductIDChanged()
    End Sub
    Partial Private Sub OncustomerIDChanging(value As Integer)
    End Sub
    Partial Private Sub OncustomerIDChanged()
    End Sub
    Partial Private Sub OnAddedChanging(value As String)
    End Sub
    Partial Private Sub OnAddedChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._cm_customer = CType(Nothing, EntityRef(Of cm_customer))
		Me._cm_product = CType(Nothing, EntityRef(Of cm_product))
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Id", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property Id() As Integer
		Get
			Return Me._Id
		End Get
		Set
			If ((Me._Id = value)  _
						= false) Then
				Me.OnIdChanging(value)
				Me.SendPropertyChanging
				Me._Id = value
				Me.SendPropertyChanged("Id")
				Me.OnIdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_productID", DbType:="Int NOT NULL")>  _
	Public Property productID() As Integer
		Get
			Return Me._productID
		End Get
		Set
			If ((Me._productID = value)  _
						= false) Then
				If Me._cm_product.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OnproductIDChanging(value)
				Me.SendPropertyChanging
				Me._productID = value
				Me.SendPropertyChanged("productID")
				Me.OnproductIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_customerID", DbType:="Int NOT NULL")>  _
	Public Property customerID() As Integer
		Get
			Return Me._customerID
		End Get
		Set
			If ((Me._customerID = value)  _
						= false) Then
				If Me._cm_customer.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OncustomerIDChanging(value)
				Me.SendPropertyChanging
				Me._customerID = value
				Me.SendPropertyChanged("customerID")
				Me.OncustomerIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Added", DbType:="NVarChar(50)")>  _
	Public Property Added() As String
		Get
			Return Me._Added
		End Get
		Set
			If (String.Equals(Me._Added, value) = false) Then
				Me.OnAddedChanging(value)
				Me.SendPropertyChanging
				Me._Added = value
				Me.SendPropertyChanged("Added")
				Me.OnAddedChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="cm_customer_cm_customer_product", Storage:="_cm_customer", ThisKey:="customerID", OtherKey:="customerID", IsForeignKey:=true)>  _
	Public Property cm_customer() As cm_customer
		Get
			Return Me._cm_customer.Entity
		End Get
		Set
			Dim previousValue As cm_customer = Me._cm_customer.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._cm_customer.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._cm_customer.Entity = Nothing
					previousValue.cm_customer_products.Remove(Me)
				End If
				Me._cm_customer.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.cm_customer_products.Add(Me)
					Me._customerID = value.customerID
				Else
					Me._customerID = CType(Nothing, Integer)
				End If
				Me.SendPropertyChanged("cm_customer")
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="cm_product_cm_customer_product", Storage:="_cm_product", ThisKey:="productID", OtherKey:="productID", IsForeignKey:=true)>  _
	Public Property cm_product() As cm_product
		Get
			Return Me._cm_product.Entity
		End Get
		Set
			Dim previousValue As cm_product = Me._cm_product.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._cm_product.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._cm_product.Entity = Nothing
					previousValue.cm_customer_products.Remove(Me)
				End If
				Me._cm_product.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.cm_customer_products.Add(Me)
					Me._productID = value.productID
				Else
					Me._productID = CType(Nothing, Integer)
				End If
				Me.SendPropertyChanged("cm_product")
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class