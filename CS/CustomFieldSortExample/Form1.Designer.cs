namespace CustomFieldSortExample {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo67 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo68 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo69 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo70 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo71 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo72 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo73 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo74 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo75 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo76 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo77 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.ExcelWorksheetSettings excelWorksheetSettings7 = new DevExpress.DataAccess.Excel.ExcelWorksheetSettings();
            DevExpress.DataAccess.Excel.ExcelSourceOptions excelSourceOptions7 = new DevExpress.DataAccess.Excel.ExcelSourceOptions(excelWorksheetSettings7);
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.excelDataSource1 = new DevExpress.DataAccess.Excel.ExcelDataSource();
            this.fieldCategoryName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCountry1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSalesPerson1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldLastName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOrderDate1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOrderID1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQuantity1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDiscount1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldExtendedPrice1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldUnitPrice1 = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pivotGridControl1.DataSource = this.excelDataSource1;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldCategoryName1,
            this.fieldCountry1,
            this.fieldProductName1,
            this.fieldSalesPerson1,
            this.fieldLastName1,
            this.fieldOrderDate1,
            this.fieldOrderID1,
            this.fieldQuantity1,
            this.fieldDiscount1,
            this.fieldExtendedPrice1,
            this.fieldUnitPrice1});
            this.pivotGridControl1.Location = new System.Drawing.Point(13, 36);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(767, 378);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(12, 11);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Enable custom sorting";
            this.checkEdit1.Size = new System.Drawing.Size(132, 18);
            this.checkEdit1.TabIndex = 2;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // excelDataSource1
            // 
            this.excelDataSource1.FileName = "C:\\Data\\SalesPersonLastNames.xlsx";
            this.excelDataSource1.Name = "excelDataSource1";
            this.excelDataSource1.ResultSchemaSerializable = resources.GetString("excelDataSource1.ResultSchemaSerializable");
            fieldInfo67.Name = "CategoryName";
            fieldInfo67.Type = typeof(string);
            fieldInfo68.Name = "Country";
            fieldInfo68.Type = typeof(string);
            fieldInfo69.Name = "ProductName";
            fieldInfo69.Type = typeof(string);
            fieldInfo70.Name = "Sales Person";
            fieldInfo70.Type = typeof(string);
            fieldInfo71.Name = "Last Name";
            fieldInfo71.Type = typeof(string);
            fieldInfo72.Name = "OrderDate";
            fieldInfo72.Type = typeof(System.DateTime);
            fieldInfo73.Name = "OrderID";
            fieldInfo73.Type = typeof(double);
            fieldInfo74.Name = "Quantity";
            fieldInfo74.Type = typeof(double);
            fieldInfo75.Name = "Discount";
            fieldInfo75.Type = typeof(double);
            fieldInfo76.Name = "Extended Price";
            fieldInfo76.Type = typeof(double);
            fieldInfo77.Name = "UnitPrice";
            fieldInfo77.Type = typeof(double);
            this.excelDataSource1.Schema.AddRange(new DevExpress.DataAccess.Excel.FieldInfo[] {
            fieldInfo67,
            fieldInfo68,
            fieldInfo69,
            fieldInfo70,
            fieldInfo71,
            fieldInfo72,
            fieldInfo73,
            fieldInfo74,
            fieldInfo75,
            fieldInfo76,
            fieldInfo77});
            excelWorksheetSettings7.CellRange = null;
            excelWorksheetSettings7.WorksheetName = "Data";
            excelSourceOptions7.ImportSettings = excelWorksheetSettings7;
            this.excelDataSource1.SourceOptions = excelSourceOptions7;
            // 
            // fieldCategoryName1
            // 
            this.fieldCategoryName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCategoryName1.AreaIndex = 0;
            this.fieldCategoryName1.Caption = "Category Name";
            this.fieldCategoryName1.FieldName = "CategoryName";
            this.fieldCategoryName1.Name = "fieldCategoryName1";
            // 
            // fieldCountry1
            // 
            this.fieldCountry1.AreaIndex = 0;
            this.fieldCountry1.Caption = "Country";
            this.fieldCountry1.FieldName = "Country";
            this.fieldCountry1.Name = "fieldCountry1";
            // 
            // fieldProductName1
            // 
            this.fieldProductName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProductName1.AreaIndex = 1;
            this.fieldProductName1.Caption = "Product Name";
            this.fieldProductName1.FieldName = "ProductName";
            this.fieldProductName1.Name = "fieldProductName1";
            // 
            // fieldSalesPerson1
            // 
            this.fieldSalesPerson1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldSalesPerson1.AreaIndex = 0;
            this.fieldSalesPerson1.Caption = "Sales Person";
            this.fieldSalesPerson1.FieldName = "Sales Person";
            this.fieldSalesPerson1.Name = "fieldSalesPerson1";
            // 
            // fieldLastName1
            // 
            this.fieldLastName1.AreaIndex = 1;
            this.fieldLastName1.Caption = "Last Name";
            this.fieldLastName1.FieldName = "Last Name";
            this.fieldLastName1.Name = "fieldLastName1";
            // 
            // fieldOrderDate1
            // 
            this.fieldOrderDate1.AreaIndex = 2;
            this.fieldOrderDate1.Caption = "OrderDate";
            this.fieldOrderDate1.FieldName = "OrderDate";
            this.fieldOrderDate1.Name = "fieldOrderDate1";
            // 
            // fieldOrderID1
            // 
            this.fieldOrderID1.AreaIndex = 3;
            this.fieldOrderID1.Caption = "Order ID";
            this.fieldOrderID1.FieldName = "OrderID";
            this.fieldOrderID1.Name = "fieldOrderID1";
            // 
            // fieldQuantity1
            // 
            this.fieldQuantity1.AreaIndex = 4;
            this.fieldQuantity1.Caption = "Quantity";
            this.fieldQuantity1.FieldName = "Quantity";
            this.fieldQuantity1.Name = "fieldQuantity1";
            // 
            // fieldDiscount1
            // 
            this.fieldDiscount1.AreaIndex = 5;
            this.fieldDiscount1.Caption = "Discount";
            this.fieldDiscount1.FieldName = "Discount";
            this.fieldDiscount1.Name = "fieldDiscount1";
            // 
            // fieldExtendedPrice1
            // 
            this.fieldExtendedPrice1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldExtendedPrice1.AreaIndex = 0;
            this.fieldExtendedPrice1.Caption = "Extended Price";
            this.fieldExtendedPrice1.FieldName = "Extended Price";
            this.fieldExtendedPrice1.Name = "fieldExtendedPrice1";
            // 
            // fieldUnitPrice1
            // 
            this.fieldUnitPrice1.AreaIndex = 6;
            this.fieldUnitPrice1.Caption = "Unit Price";
            this.fieldUnitPrice1.FieldName = "UnitPrice";
            this.fieldUnitPrice1.Name = "fieldUnitPrice1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 426);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "Form1";
            this.Text = "CustomFieldSort Example";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.DataAccess.Excel.ExcelDataSource excelDataSource1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCategoryName1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCountry1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductName1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSalesPerson1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldLastName1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOrderDate1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOrderID1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldQuantity1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldDiscount1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldExtendedPrice1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldUnitPrice1;
    }
}

