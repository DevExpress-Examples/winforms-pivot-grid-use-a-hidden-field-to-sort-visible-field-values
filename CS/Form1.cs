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
		IList dataSource;
		PropertyDescriptor orderPropDesc;
		PivotGridField field;

		public Form1() {
			InitializeComponent();

			field = pivotGridControl1.Fields.Add("Desc", PivotArea.ColumnArea);		
			pivotGridControl1.CustomFieldSort += new PivotGridCustomFieldSortEventHandler(pivotGridControl1_CustomFieldSort);

			dataSource = CreateData().DefaultView;
			orderPropDesc = ((ITypedList)dataSource).GetItemProperties(null)["Order"];

			pivotGridControl1.DataSource = dataSource;
		}

		void pivotGridControl1_CustomFieldSort(object sender, PivotGridCustomFieldSortEventArgs e) {
			if(e.Field.FieldName != "Desc") return;
			int order1 = Convert.ToInt32(orderPropDesc.GetValue(dataSource[e.ListSourceRowIndex1])),
				order2 = Convert.ToInt32(orderPropDesc.GetValue(dataSource[e.ListSourceRowIndex2]));
			e.Result = Comparer<int>.Default.Compare(order1, order2);
			e.Handled = true;
		}

		DataTable CreateData() {
			DataTable res = new DataTable();
			res.Columns.Add("Order", typeof(int));
			res.Columns.Add("Desc", typeof(string));
			res.Rows.Add(1, "January");
			res.Rows.Add(2, "February");
			res.Rows.Add(3, "March");
			res.Rows.Add(4, "April");
			return res;
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e) {
			field.SortMode = checkBox1.Checked ? PivotSortMode.Custom : PivotSortMode.Default;
		}
	}
}