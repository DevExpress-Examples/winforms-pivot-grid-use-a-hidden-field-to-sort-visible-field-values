using DevExpress.Data.PivotGrid;
using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid;
using System;

namespace CustomSortingExample {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            excelDataSource1.FileName = "SalesPerson.xlsx";
            excelDataSource1.Fill();
            pivotGridControl1.BestFit();

            // Create a hidden field to apply custom sorting
            fieldLastName.Area = PivotArea.DataArea;
            fieldLastName.Visible = false;
            fieldLastName.SummaryType = PivotSummaryType.Max;
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e) {
            fieldSalesPerson.SortBySummaryInfo.Field = ((CheckEdit)sender).Checked ? fieldLastName : null;
        }
    }
}