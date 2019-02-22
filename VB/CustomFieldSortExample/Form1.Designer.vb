Namespace CustomFieldSortExample
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim fieldInfo67 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo68 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo69 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo70 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo71 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo72 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo73 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo74 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo75 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo76 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo77 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim excelWorksheetSettings7 As New DevExpress.DataAccess.Excel.ExcelWorksheetSettings()
			Dim excelSourceOptions7 As New DevExpress.DataAccess.Excel.ExcelSourceOptions(excelWorksheetSettings7)
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
			Me.excelDataSource1 = New DevExpress.DataAccess.Excel.ExcelDataSource()
			Me.fieldCategoryName1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldCountry1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldProductName1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldSalesPerson1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldLastName1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldOrderDate1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldOrderID1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldQuantity1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldDiscount1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldExtendedPrice1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldUnitPrice1 = New DevExpress.XtraPivotGrid.PivotGridField()
			DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
			Me.pivotGridControl1.DataSource = Me.excelDataSource1
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldCategoryName1, Me.fieldCountry1, Me.fieldProductName1, Me.fieldSalesPerson1, Me.fieldLastName1, Me.fieldOrderDate1, Me.fieldOrderID1, Me.fieldQuantity1, Me.fieldDiscount1, Me.fieldExtendedPrice1, Me.fieldUnitPrice1})
			Me.pivotGridControl1.Location = New System.Drawing.Point(13, 36)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.Size = New System.Drawing.Size(767, 378)
			Me.pivotGridControl1.TabIndex = 0
			' 
			' checkEdit1
			' 
			Me.checkEdit1.Location = New System.Drawing.Point(12, 11)
			Me.checkEdit1.Name = "checkEdit1"
			Me.checkEdit1.Properties.Caption = "Enable custom sorting"
			Me.checkEdit1.Size = New System.Drawing.Size(132, 18)
			Me.checkEdit1.TabIndex = 2
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
			' 
			' excelDataSource1
			' 
			Me.excelDataSource1.FileName = "C:\Data\SalesPersonLastNames.xlsx"
			Me.excelDataSource1.Name = "excelDataSource1"
			Me.excelDataSource1.ResultSchemaSerializable = resources.GetString("excelDataSource1.ResultSchemaSerializable")
			fieldInfo67.Name = "CategoryName"
			fieldInfo67.Type = GetType(String)
			fieldInfo68.Name = "Country"
			fieldInfo68.Type = GetType(String)
			fieldInfo69.Name = "ProductName"
			fieldInfo69.Type = GetType(String)
			fieldInfo70.Name = "Sales Person"
			fieldInfo70.Type = GetType(String)
			fieldInfo71.Name = "Last Name"
			fieldInfo71.Type = GetType(String)
			fieldInfo72.Name = "OrderDate"
			fieldInfo72.Type = GetType(Date)
			fieldInfo73.Name = "OrderID"
			fieldInfo73.Type = GetType(Double)
			fieldInfo74.Name = "Quantity"
			fieldInfo74.Type = GetType(Double)
			fieldInfo75.Name = "Discount"
			fieldInfo75.Type = GetType(Double)
			fieldInfo76.Name = "Extended Price"
			fieldInfo76.Type = GetType(Double)
			fieldInfo77.Name = "UnitPrice"
			fieldInfo77.Type = GetType(Double)
			Me.excelDataSource1.Schema.AddRange(New DevExpress.DataAccess.Excel.FieldInfo() { fieldInfo67, fieldInfo68, fieldInfo69, fieldInfo70, fieldInfo71, fieldInfo72, fieldInfo73, fieldInfo74, fieldInfo75, fieldInfo76, fieldInfo77})
			excelWorksheetSettings7.CellRange = Nothing
			excelWorksheetSettings7.WorksheetName = "Data"
			excelSourceOptions7.ImportSettings = excelWorksheetSettings7
			Me.excelDataSource1.SourceOptions = excelSourceOptions7
			' 
			' fieldCategoryName1
			' 
			Me.fieldCategoryName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldCategoryName1.AreaIndex = 0
			Me.fieldCategoryName1.Caption = "Category Name"
			Me.fieldCategoryName1.FieldName = "CategoryName"
			Me.fieldCategoryName1.Name = "fieldCategoryName1"
			' 
			' fieldCountry1
			' 
			Me.fieldCountry1.AreaIndex = 0
			Me.fieldCountry1.Caption = "Country"
			Me.fieldCountry1.FieldName = "Country"
			Me.fieldCountry1.Name = "fieldCountry1"
			' 
			' fieldProductName1
			' 
			Me.fieldProductName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldProductName1.AreaIndex = 1
			Me.fieldProductName1.Caption = "Product Name"
			Me.fieldProductName1.FieldName = "ProductName"
			Me.fieldProductName1.Name = "fieldProductName1"
			' 
			' fieldSalesPerson1
			' 
			Me.fieldSalesPerson1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldSalesPerson1.AreaIndex = 0
			Me.fieldSalesPerson1.Caption = "Sales Person"
			Me.fieldSalesPerson1.FieldName = "Sales Person"
			Me.fieldSalesPerson1.Name = "fieldSalesPerson1"
			' 
			' fieldLastName1
			' 
			Me.fieldLastName1.AreaIndex = 1
			Me.fieldLastName1.Caption = "Last Name"
			Me.fieldLastName1.FieldName = "Last Name"
			Me.fieldLastName1.Name = "fieldLastName1"
			' 
			' fieldOrderDate1
			' 
			Me.fieldOrderDate1.AreaIndex = 2
			Me.fieldOrderDate1.Caption = "OrderDate"
			Me.fieldOrderDate1.FieldName = "OrderDate"
			Me.fieldOrderDate1.Name = "fieldOrderDate1"
			' 
			' fieldOrderID1
			' 
			Me.fieldOrderID1.AreaIndex = 3
			Me.fieldOrderID1.Caption = "Order ID"
			Me.fieldOrderID1.FieldName = "OrderID"
			Me.fieldOrderID1.Name = "fieldOrderID1"
			' 
			' fieldQuantity1
			' 
			Me.fieldQuantity1.AreaIndex = 4
			Me.fieldQuantity1.Caption = "Quantity"
			Me.fieldQuantity1.FieldName = "Quantity"
			Me.fieldQuantity1.Name = "fieldQuantity1"
			' 
			' fieldDiscount1
			' 
			Me.fieldDiscount1.AreaIndex = 5
			Me.fieldDiscount1.Caption = "Discount"
			Me.fieldDiscount1.FieldName = "Discount"
			Me.fieldDiscount1.Name = "fieldDiscount1"
			' 
			' fieldExtendedPrice1
			' 
			Me.fieldExtendedPrice1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldExtendedPrice1.AreaIndex = 0
			Me.fieldExtendedPrice1.Caption = "Extended Price"
			Me.fieldExtendedPrice1.FieldName = "Extended Price"
			Me.fieldExtendedPrice1.Name = "fieldExtendedPrice1"
			' 
			' fieldUnitPrice1
			' 
			Me.fieldUnitPrice1.AreaIndex = 6
			Me.fieldUnitPrice1.Caption = "Unit Price"
			Me.fieldUnitPrice1.FieldName = "UnitPrice"
			Me.fieldUnitPrice1.Name = "fieldUnitPrice1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(792, 426)
			Me.Controls.Add(Me.checkEdit1)
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Name = "Form1"
			Me.Text = "CustomFieldSort Example"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Load += new System.EventHandler(this.Form1_Load);
			DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private WithEvents checkEdit1 As DevExpress.XtraEditors.CheckEdit
		Private excelDataSource1 As DevExpress.DataAccess.Excel.ExcelDataSource
		Private fieldCategoryName1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldCountry1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldProductName1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldSalesPerson1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldLastName1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldOrderDate1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldOrderID1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldQuantity1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldDiscount1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldExtendedPrice1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldUnitPrice1 As DevExpress.XtraPivotGrid.PivotGridField
	End Class
End Namespace

