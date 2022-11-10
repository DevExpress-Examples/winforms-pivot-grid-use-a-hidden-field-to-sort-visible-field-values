Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraPivotGrid
Imports System.Collections

Namespace Q181341

    Public Partial Class Form1
        Inherits Form

        Private fieldMonth As PivotGridField

        Public Sub New()
            InitializeComponent()
            fieldMonth = pivotGridControl1.Fields.Add("Month", PivotArea.ColumnArea)
            AddHandler pivotGridControl1.CustomFieldSort, New PivotGridCustomFieldSortEventHandler(AddressOf pivotGridControl1_CustomFieldSort)
            pivotGridControl1.DataSource = CreateData()
        End Sub

        Private Sub pivotGridControl1_CustomFieldSort(ByVal sender As Object, ByVal e As PivotGridCustomFieldSortEventArgs)
            If Equals(e.Field.FieldName, "Month") Then
                Dim orderValue1 As Object = e.GetListSourceColumnValue(e.ListSourceRowIndex1, "Order"), orderValue2 As Object = e.GetListSourceColumnValue(e.ListSourceRowIndex2, "Order")
                e.Result = Comparer.Default.Compare(orderValue1, orderValue2)
                e.Handled = True
            End If
        End Sub

        Private Function CreateData() As DataTable
            Dim res As DataTable = New DataTable()
            res.Columns.Add("Order", GetType(Integer))
            res.Columns.Add("Month", GetType(String))
            res.Rows.Add(1, "January")
            res.Rows.Add(2, "February")
            res.Rows.Add(3, "March")
            res.Rows.Add(4, "April")
            Return res
        End Function

        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            fieldMonth.SortMode = If(checkBox1.Checked, PivotSortMode.Custom, PivotSortMode.Default)
        End Sub
    End Class
End Namespace
