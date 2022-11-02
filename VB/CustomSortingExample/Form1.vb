Imports DevExpress.Data.PivotGrid
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPivotGrid
Imports System

Namespace CustomSortingExample

    Public Partial Class Form1
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            excelDataSource1.FileName = "SalesPerson.xlsx"
            excelDataSource1.Fill()
            pivotGridControl1.BestFit()
            ' Create a hidden field to apply custom sorting
            fieldLastName.Area = PivotArea.DataArea
            fieldLastName.Visible = False
            fieldLastName.SummaryType = PivotSummaryType.Max
        End Sub

        Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            fieldSalesPerson.SortBySummaryInfo.Field = If(CType(sender, CheckEdit).Checked, fieldLastName, Nothing)
        End Sub
    End Class
End Namespace
