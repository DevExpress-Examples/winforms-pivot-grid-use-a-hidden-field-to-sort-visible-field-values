using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid;
using System;
using System.Collections;

namespace CustomFieldSortExample
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            pivotGridControl1.CustomFieldSort += new PivotGridCustomFieldSortEventHandler(pivotGridControl1_CustomFieldSort);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            excelDataSource1.FileName = "SalesPerson.xlsx";
            excelDataSource1.Fill();
            pivotGridControl1.BestFit();
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            fieldSalesPerson1.SortMode = ((CheckEdit)sender).Checked ? PivotSortMode.Custom : PivotSortMode.Default;
        }
        void pivotGridControl1_CustomFieldSort(object sender, PivotGridCustomFieldSortEventArgs e)
        {
            if (e.Field.FieldName == "Sales Person")
            {
                if (e.SortLocation == PivotSortLocation.Pivot)
                {
                    object orderValue1 = e.GetListSourceColumnValue(e.ListSourceRowIndex1, "Last Name"),
                        orderValue2 = e.GetListSourceColumnValue(e.ListSourceRowIndex2, "Last Name");
                    e.Result = Comparer.Default.Compare(orderValue1, orderValue2);
                }
                else
                {
                    e.Result = Comparer.Default.Compare(e.Value1.ToString().Split(' ')[1], e.Value2.ToString().Split(' ')[1]);
                }
                e.Handled = true;
            }
        }
    }
}