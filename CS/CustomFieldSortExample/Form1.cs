using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid;
using System;
using System.Collections;

namespace CustomFieldSortExample
{
    public partial class Form1 : XtraForm {
		public Form1() {
			InitializeComponent();
			pivotGridControl1.CustomFieldSort += new PivotGridCustomFieldSortEventHandler(pivotGridControl1_CustomFieldSort);
		}

        private void Form1_Load(object sender, EventArgs e) {
            this.salesPersonTableAdapter.Fill(this.nwindDataSet.SalesPerson);
            pivotGridControl1.BestFit();
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e) {
            fieldSalesPerson1.SortMode = ((CheckEdit)sender).Checked ? PivotSortMode.Custom : PivotSortMode.Default;
        }
        void pivotGridControl1_CustomFieldSort(object sender, PivotGridCustomFieldSortEventArgs e) {
            if (e.Field.FieldName == "Sales Person") {
                object orderValue1 = e.GetListSourceColumnValue(e.ListSourceRowIndex1, "LastName"),
                    orderValue2 = e.GetListSourceColumnValue(e.ListSourceRowIndex2, "LastName");
                e.Result = Comparer.Default.Compare(orderValue1, orderValue2);
                e.Handled = true;
            }
		}
    }
}