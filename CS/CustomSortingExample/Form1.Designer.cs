namespace CustomSortingExample {
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
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo12 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo13 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo14 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo15 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo16 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo17 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo18 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo19 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo20 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo21 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo22 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.ExcelWorksheetSettings excelWorksheetSettings2 = new DevExpress.DataAccess.Excel.ExcelWorksheetSettings();
            DevExpress.DataAccess.Excel.ExcelSourceOptions excelSourceOptions2 = new DevExpress.DataAccess.Excel.ExcelSourceOptions(excelWorksheetSettings2);
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding6 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding7 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding8 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding9 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding10 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.excelDataSource1 = new DevExpress.DataAccess.Excel.ExcelDataSource();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.pivotGridField1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField3 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSalesPerson = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField10 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldLastName = new DevExpress.XtraPivotGrid.PivotGridField();
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
            this.pivotGridField1,
            this.pivotGridField3,
            this.fieldSalesPerson,
            this.pivotGridField10,
            this.fieldLastName});
            this.pivotGridControl1.Location = new System.Drawing.Point(20, 53);
            this.pivotGridControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized;
            this.pivotGridControl1.OptionsDataField.RowHeaderWidth = 150;
            this.pivotGridControl1.OptionsView.RowTreeOffset = 31;
            this.pivotGridControl1.OptionsView.RowTreeWidth = 150;
            this.pivotGridControl1.Size = new System.Drawing.Size(1150, 552);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // excelDataSource1
            // 
            this.excelDataSource1.FileName = "C:\\Data\\SalesPersonLastNames.xlsx";
            this.excelDataSource1.Name = "excelDataSource1";
            this.excelDataSource1.ResultSchemaSerializable = resources.GetString("excelDataSource1.ResultSchemaSerializable");
            fieldInfo12.Name = "CategoryName";
            fieldInfo12.OriginalName = null;
            fieldInfo12.Type = typeof(string);
            fieldInfo13.Name = "Country";
            fieldInfo13.OriginalName = null;
            fieldInfo13.Type = typeof(string);
            fieldInfo14.Name = "ProductName";
            fieldInfo14.OriginalName = null;
            fieldInfo14.Type = typeof(string);
            fieldInfo15.Name = "Sales Person";
            fieldInfo15.OriginalName = null;
            fieldInfo15.Type = typeof(string);
            fieldInfo16.Name = "Last Name";
            fieldInfo16.OriginalName = null;
            fieldInfo16.Type = typeof(string);
            fieldInfo17.Name = "OrderDate";
            fieldInfo17.OriginalName = null;
            fieldInfo17.Type = typeof(System.DateTime);
            fieldInfo18.Name = "OrderID";
            fieldInfo18.OriginalName = null;
            fieldInfo18.Type = typeof(double);
            fieldInfo19.Name = "Quantity";
            fieldInfo19.OriginalName = null;
            fieldInfo19.Type = typeof(double);
            fieldInfo20.Name = "Discount";
            fieldInfo20.OriginalName = null;
            fieldInfo20.Type = typeof(double);
            fieldInfo21.Name = "Extended Price";
            fieldInfo21.OriginalName = null;
            fieldInfo21.Type = typeof(double);
            fieldInfo22.Name = "UnitPrice";
            fieldInfo22.OriginalName = null;
            fieldInfo22.Type = typeof(double);
            this.excelDataSource1.Schema.AddRange(new DevExpress.DataAccess.Excel.FieldInfo[] {
            fieldInfo12,
            fieldInfo13,
            fieldInfo14,
            fieldInfo15,
            fieldInfo16,
            fieldInfo17,
            fieldInfo18,
            fieldInfo19,
            fieldInfo20,
            fieldInfo21,
            fieldInfo22});
            excelWorksheetSettings2.CellRange = null;
            excelWorksheetSettings2.WorksheetIndex = null;
            excelWorksheetSettings2.WorksheetName = "Data";
            excelSourceOptions2.ImportSettings = excelWorksheetSettings2;
            this.excelDataSource1.SourceOptions = excelSourceOptions2;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(18, 16);
            this.checkEdit1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Enable custom sorting by Sales Person\'s Last Name";
            this.checkEdit1.Size = new System.Drawing.Size(396, 25);
            this.checkEdit1.TabIndex = 2;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // pivotGridField1
            // 
            this.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField1.AreaIndex = 0;
            this.pivotGridField1.Caption = "Category Name";
            dataSourceColumnBinding6.ColumnName = "CategoryName";
            this.pivotGridField1.DataBinding = dataSourceColumnBinding6;
            this.pivotGridField1.MinWidth = 30;
            this.pivotGridField1.Name = "pivotGridField1";
            this.pivotGridField1.Width = 150;
            // 
            // pivotGridField3
            // 
            this.pivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField3.AreaIndex = 1;
            this.pivotGridField3.Caption = "Product Name";
            dataSourceColumnBinding7.ColumnName = "ProductName";
            this.pivotGridField3.DataBinding = dataSourceColumnBinding7;
            this.pivotGridField3.MinWidth = 30;
            this.pivotGridField3.Name = "pivotGridField3";
            this.pivotGridField3.Width = 150;
            // 
            // fieldSalesPerson
            // 
            this.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldSalesPerson.AreaIndex = 0;
            this.fieldSalesPerson.Caption = "Sales Person";
            dataSourceColumnBinding8.ColumnName = "Sales Person";
            this.fieldSalesPerson.DataBinding = dataSourceColumnBinding8;
            this.fieldSalesPerson.MinWidth = 30;
            this.fieldSalesPerson.Name = "fieldSalesPerson";
            this.fieldSalesPerson.Width = 150;
            // 
            // pivotGridField10
            // 
            this.pivotGridField10.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField10.AreaIndex = 0;
            this.pivotGridField10.Caption = "Extended Price";
            dataSourceColumnBinding9.ColumnName = "Extended Price";
            this.pivotGridField10.DataBinding = dataSourceColumnBinding9;
            this.pivotGridField10.MinWidth = 30;
            this.pivotGridField10.Name = "pivotGridField10";
            this.pivotGridField10.Width = 150;
            // 
            // fieldLastName
            // 
            this.fieldLastName.AreaIndex = 0;
            dataSourceColumnBinding10.ColumnName = "Last Name";
            this.fieldLastName.DataBinding = dataSourceColumnBinding10;
            this.fieldLastName.MinWidth = 30;
            this.fieldLastName.Name = "fieldLastName";
            this.fieldLastName.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 623);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.pivotGridControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField3;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSalesPerson;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField10;
        private DevExpress.XtraPivotGrid.PivotGridField fieldLastName;
    }
}

