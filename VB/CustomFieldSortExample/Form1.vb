Imports DevExpress.XtraEditors
Imports DevExpress.XtraPivotGrid
Imports System
Imports System.Collections

Namespace CustomFieldSortExample
	Partial Public Class Form1
		Inherits XtraForm

		Public Sub New()
			InitializeComponent()
			AddHandler pivotGridControl1.CustomFieldSort, AddressOf pivotGridControl1_CustomFieldSort
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			excelDataSource1.FileName = "SalesPerson.xlsx"
			excelDataSource1.Fill()
			pivotGridControl1.BestFit()
		End Sub

		Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEdit1.CheckedChanged
			fieldSalesPerson1.SortMode = If(DirectCast(sender, CheckEdit).Checked, PivotSortMode.Custom, PivotSortMode.Default)
		End Sub
		Private Sub pivotGridControl1_CustomFieldSort(ByVal sender As Object, ByVal e As PivotGridCustomFieldSortEventArgs)
			If e.Field.FieldName = "Sales Person" Then
				Dim orderValue1 As Object = e.GetListSourceColumnValue(e.ListSourceRowIndex1, "Last Name"), orderValue2 As Object = e.GetListSourceColumnValue(e.ListSourceRowIndex2, "Last Name")
				e.Result = Comparer.Default.Compare(orderValue1, orderValue2)
				e.Handled = True
			End If
		End Sub
	End Class
End Namespace