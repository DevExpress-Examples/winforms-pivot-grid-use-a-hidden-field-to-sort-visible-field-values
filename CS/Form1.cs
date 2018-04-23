using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid;
using System.Collections;

namespace Q181341 {
	public partial class Form1 : Form {

        PivotGridField fieldMonth;
		public Form1() {
			InitializeComponent();

            fieldMonth = pivotGridControl1.Fields.Add("Month", PivotArea.ColumnArea);		
			pivotGridControl1.CustomFieldSort += new PivotGridCustomFieldSortEventHandler(pivotGridControl1_CustomFieldSort);
            pivotGridControl1.DataSource = CreateData();
		}

		void pivotGridControl1_CustomFieldSort(object sender, PivotGridCustomFieldSortEventArgs e) {
            if (e.Field.FieldName == "Month")
            {

                object orderValue1 = e.GetListSourceColumnValue(e.ListSourceRowIndex1, "Order"),
                    orderValue2 = e.GetListSourceColumnValue(e.ListSourceRowIndex2, "Order");
                e.Result = Comparer.Default.Compare(orderValue1, orderValue2);
                e.Handled = true;
            }
		}

		DataTable CreateData() {
			DataTable res = new DataTable();
			res.Columns.Add("Order", typeof(int));
			res.Columns.Add("Month", typeof(string));
			res.Rows.Add(1, "January");
			res.Rows.Add(2, "February");
			res.Rows.Add(3, "March");
			res.Rows.Add(4, "April");
			return res;
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e) {
			fieldMonth.SortMode = checkBox1.Checked ? PivotSortMode.Custom : PivotSortMode.Default;
		}
	}
}