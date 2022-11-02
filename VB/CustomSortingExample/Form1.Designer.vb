Namespace CustomSortingExample

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomSortingExample.Form1))
            Dim fieldInfo12 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim fieldInfo13 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim fieldInfo14 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim fieldInfo15 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim fieldInfo16 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim fieldInfo17 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim fieldInfo18 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim fieldInfo19 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim fieldInfo20 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim fieldInfo21 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim fieldInfo22 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim excelWorksheetSettings2 As DevExpress.DataAccess.Excel.ExcelWorksheetSettings = New DevExpress.DataAccess.Excel.ExcelWorksheetSettings()
            Dim excelSourceOptions2 As DevExpress.DataAccess.Excel.ExcelSourceOptions = New DevExpress.DataAccess.Excel.ExcelSourceOptions(excelWorksheetSettings2)
            Dim dataSourceColumnBinding6 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding7 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding8 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding9 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding10 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.excelDataSource1 = New DevExpress.DataAccess.Excel.ExcelDataSource()
            Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
            Me.pivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.pivotGridField3 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldSalesPerson = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.pivotGridField10 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldLastName = New DevExpress.XtraPivotGrid.PivotGridField()
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' pivotGridControl1
            ' 
            Me.pivotGridControl1.Anchor = CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.pivotGridControl1.DataSource = Me.excelDataSource1
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.pivotGridField1, Me.pivotGridField3, Me.fieldSalesPerson, Me.pivotGridField10, Me.fieldLastName})
            Me.pivotGridControl1.Location = New System.Drawing.Point(20, 53)
            Me.pivotGridControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Me.pivotGridControl1.OptionsDataField.RowHeaderWidth = 150
            Me.pivotGridControl1.OptionsView.RowTreeOffset = 31
            Me.pivotGridControl1.OptionsView.RowTreeWidth = 150
            Me.pivotGridControl1.Size = New System.Drawing.Size(1150, 552)
            Me.pivotGridControl1.TabIndex = 0
            ' 
            ' excelDataSource1
            ' 
            Me.excelDataSource1.FileName = "C:\Data\SalesPersonLastNames.xlsx"
            Me.excelDataSource1.Name = "excelDataSource1"
            Me.excelDataSource1.ResultSchemaSerializable = resources.GetString("excelDataSource1.ResultSchemaSerializable")
            fieldInfo12.Name = "CategoryName"
            fieldInfo12.OriginalName = Nothing
            fieldInfo12.Type = GetType(String)
            fieldInfo13.Name = "Country"
            fieldInfo13.OriginalName = Nothing
            fieldInfo13.Type = GetType(String)
            fieldInfo14.Name = "ProductName"
            fieldInfo14.OriginalName = Nothing
            fieldInfo14.Type = GetType(String)
            fieldInfo15.Name = "Sales Person"
            fieldInfo15.OriginalName = Nothing
            fieldInfo15.Type = GetType(String)
            fieldInfo16.Name = "Last Name"
            fieldInfo16.OriginalName = Nothing
            fieldInfo16.Type = GetType(String)
            fieldInfo17.Name = "OrderDate"
            fieldInfo17.OriginalName = Nothing
            fieldInfo17.Type = GetType(System.DateTime)
            fieldInfo18.Name = "OrderID"
            fieldInfo18.OriginalName = Nothing
            fieldInfo18.Type = GetType(Double)
            fieldInfo19.Name = "Quantity"
            fieldInfo19.OriginalName = Nothing
            fieldInfo19.Type = GetType(Double)
            fieldInfo20.Name = "Discount"
            fieldInfo20.OriginalName = Nothing
            fieldInfo20.Type = GetType(Double)
            fieldInfo21.Name = "Extended Price"
            fieldInfo21.OriginalName = Nothing
            fieldInfo21.Type = GetType(Double)
            fieldInfo22.Name = "UnitPrice"
            fieldInfo22.OriginalName = Nothing
            fieldInfo22.Type = GetType(Double)
            Me.excelDataSource1.Schema.AddRange(New DevExpress.DataAccess.Excel.FieldInfo() {fieldInfo12, fieldInfo13, fieldInfo14, fieldInfo15, fieldInfo16, fieldInfo17, fieldInfo18, fieldInfo19, fieldInfo20, fieldInfo21, fieldInfo22})
            excelWorksheetSettings2.CellRange = Nothing
            excelWorksheetSettings2.WorksheetIndex = Nothing
            excelWorksheetSettings2.WorksheetName = "Data"
            excelSourceOptions2.ImportSettings = excelWorksheetSettings2
            Me.excelDataSource1.SourceOptions = excelSourceOptions2
            ' 
            ' checkEdit1
            ' 
            Me.checkEdit1.Location = New System.Drawing.Point(18, 16)
            Me.checkEdit1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.checkEdit1.Name = "checkEdit1"
            Me.checkEdit1.Properties.Caption = "Enable custom sorting by Sales Person's Last Name"
            Me.checkEdit1.Size = New System.Drawing.Size(396, 25)
            Me.checkEdit1.TabIndex = 2
            AddHandler Me.checkEdit1.CheckedChanged, New System.EventHandler(AddressOf Me.checkEdit1_CheckedChanged)
            ' 
            ' pivotGridField1
            ' 
            Me.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.pivotGridField1.AreaIndex = 0
            Me.pivotGridField1.Caption = "Category Name"
            dataSourceColumnBinding6.ColumnName = "CategoryName"
            Me.pivotGridField1.DataBinding = dataSourceColumnBinding6
            Me.pivotGridField1.MinWidth = 30
            Me.pivotGridField1.Name = "pivotGridField1"
            Me.pivotGridField1.Width = 150
            ' 
            ' pivotGridField3
            ' 
            Me.pivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.pivotGridField3.AreaIndex = 1
            Me.pivotGridField3.Caption = "Product Name"
            dataSourceColumnBinding7.ColumnName = "ProductName"
            Me.pivotGridField3.DataBinding = dataSourceColumnBinding7
            Me.pivotGridField3.MinWidth = 30
            Me.pivotGridField3.Name = "pivotGridField3"
            Me.pivotGridField3.Width = 150
            ' 
            ' fieldSalesPerson
            ' 
            Me.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldSalesPerson.AreaIndex = 0
            Me.fieldSalesPerson.Caption = "Sales Person"
            dataSourceColumnBinding8.ColumnName = "Sales Person"
            Me.fieldSalesPerson.DataBinding = dataSourceColumnBinding8
            Me.fieldSalesPerson.MinWidth = 30
            Me.fieldSalesPerson.Name = "fieldSalesPerson"
            Me.fieldSalesPerson.Width = 150
            ' 
            ' pivotGridField10
            ' 
            Me.pivotGridField10.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.pivotGridField10.AreaIndex = 0
            Me.pivotGridField10.Caption = "Extended Price"
            dataSourceColumnBinding9.ColumnName = "Extended Price"
            Me.pivotGridField10.DataBinding = dataSourceColumnBinding9
            Me.pivotGridField10.MinWidth = 30
            Me.pivotGridField10.Name = "pivotGridField10"
            Me.pivotGridField10.Width = 150
            ' 
            ' fieldLastName
            ' 
            Me.fieldLastName.AreaIndex = 0
            dataSourceColumnBinding10.ColumnName = "Last Name"
            Me.fieldLastName.DataBinding = dataSourceColumnBinding10
            Me.fieldLastName.MinWidth = 30
            Me.fieldLastName.Name = "fieldLastName"
            Me.fieldLastName.Width = 150
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(9F, 19F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1188, 623)
            Me.Controls.Add(Me.checkEdit1)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.Name = "Form1"
            Me.Text = "CustomFieldSort Example"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl

        Private checkEdit1 As DevExpress.XtraEditors.CheckEdit

        Private excelDataSource1 As DevExpress.DataAccess.Excel.ExcelDataSource

        Private pivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField

        Private pivotGridField3 As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldSalesPerson As DevExpress.XtraPivotGrid.PivotGridField

        Private pivotGridField10 As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldLastName As DevExpress.XtraPivotGrid.PivotGridField
    End Class
End Namespace
