﻿Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.ComponentModel
Imports System
Imports DevExpress.Xpf.Grid

Namespace DXGrid_ConditionalFormatting
	Partial Public Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()
			grid.DataSource = Products.GetData()
		End Sub
	End Class
	Public Class ColumnRowIndexesCellValueConverter
		Inherits MarkupExtension
		Implements IMultiValueConverter
		Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
			Return Me
		End Function

		#Region "IMultiValueConverter Members"

		Public Function Convert(ByVal values() As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IMultiValueConverter.Convert
			If values(0) Is Nothing Then
				Return Brushes.Transparent
			End If
			Dim columnIndex As Integer= CInt(Fix((TryCast(values(0), GridColumn)).VisibleIndex))
			Dim rowIndex As Integer = CInt(Fix(values(1)))
			If columnIndex = 1 AndAlso rowIndex = 1 Then
				Return Brushes.Red
			Else
				Return Brushes.Transparent
			End If
		End Function

		Public Function ConvertBack(ByVal value As Object, ByVal targetTypes() As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object() Implements IMultiValueConverter.ConvertBack
			Throw New NotImplementedException()
		End Function

		#End Region
	End Class
	Public Class Products
		Public Shared Function GetData() As List(Of Product)
			Dim data As New List(Of Product)()
			data.Add(New Product() With {.ProductName = "Chai", .UnitPrice = 18, .UnitsOnOrder = 10})
			data.Add(New Product() With {.ProductName = "Ipoh Coffee", .UnitPrice = 36.8, .UnitsOnOrder = 12})
			data.Add(New Product() With {.ProductName = "Outback Lager", .UnitPrice = 12, .UnitsOnOrder = 25})
			data.Add(New Product() With {.ProductName = "Boston Crab Meat", .UnitPrice = 18.4, .UnitsOnOrder = 18})
			data.Add(New Product() With {.ProductName = "Konbu", .UnitPrice = 6, .UnitsOnOrder = 24})
			Return data
		End Function
	End Class
	Public Class Product
		Private privateProductName As String
		Public Property ProductName() As String
			Get
				Return privateProductName
			End Get
			Set(ByVal value As String)
				privateProductName = value
			End Set
		End Property
		Private privateUnitPrice As Double
		Public Property UnitPrice() As Double
			Get
				Return privateUnitPrice
			End Get
			Set(ByVal value As Double)
				privateUnitPrice = value
			End Set
		End Property
		Private privateUnitsOnOrder As Integer
		Public Property UnitsOnOrder() As Integer
			Get
				Return privateUnitsOnOrder
			End Get
			Set(ByVal value As Integer)
				privateUnitsOnOrder = value
			End Set
		End Property
	End Class
End Namespace