Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraPivotGrid
Imports System.Collections

Namespace Q181341
	Partial Public Class Form1
		Inherits Form
		Private dataSource As IList
		Private orderPropDesc As PropertyDescriptor
		Private field As PivotGridField

		Public Sub New()
			InitializeComponent()

			field = pivotGridControl1.Fields.Add("Desc", PivotArea.ColumnArea)
			AddHandler pivotGridControl1.CustomFieldSort, AddressOf pivotGridControl1_CustomFieldSort

			dataSource = CreateData().DefaultView
			orderPropDesc = (CType(dataSource, ITypedList)).GetItemProperties(Nothing)("Order")

			pivotGridControl1.DataSource = dataSource
		End Sub

		Private Sub pivotGridControl1_CustomFieldSort(ByVal sender As Object, ByVal e As PivotGridCustomFieldSortEventArgs)
			If e.Field.FieldName <> "Desc" Then
				Return
			End If
			Dim order1 As Integer = Convert.ToInt32(orderPropDesc.GetValue(dataSource(e.ListSourceRowIndex1))), order2 As Integer = Convert.ToInt32(orderPropDesc.GetValue(dataSource(e.ListSourceRowIndex2)))
			e.Result = Comparer(Of Integer).Default.Compare(order1, order2)
			e.Handled = True
		End Sub

		Private Function CreateData() As DataTable
			Dim res As New DataTable()
			res.Columns.Add("Order", GetType(Integer))
			res.Columns.Add("Desc", GetType(String))
			res.Rows.Add(1, "January")
			res.Rows.Add(2, "February")
			res.Rows.Add(3, "March")
			res.Rows.Add(4, "April")
			Return res
		End Function

		Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
			If checkBox1.Checked Then
				field.SortMode = PivotSortMode.Custom
			Else
				field.SortMode = PivotSortMode.Default
			End If
		End Sub
	End Class
End Namespace