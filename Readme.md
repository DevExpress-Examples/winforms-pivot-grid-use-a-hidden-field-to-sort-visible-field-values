<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E331)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Pivot Grid for WinForms - How to Use a Hidden Field to Sort the Visible Field Values

This example demonstrates how to sort the _Sales Person_ field by the hidden _Last Name_ data field.

Check the _Enable custom sorting_ box to sort the _Sales Person_ values by _Last Name_ instead of the default alphabetical sort order.

![](./images/screenshot.png)

The checked _Enable custom sorting_ box enables the [Sorting by Summary](https://docs.devexpress.com/WindowsForms/9726/controls-and-libraries/pivot-grid/data-shaping/sorting/sorting-by-summary) functionality for the _Sales Person_ field. The _Last Name_ field is placed in the Data Area to calculate a summary value that is used to sort the _Sales Person_ field values.

This example uses the following API:

* [PivotGridFieldBase.SortBySummaryInfo](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotGridFieldBase.SortBySummaryInfo) property
* [PivotGridFieldSortBySummaryInfo.Field](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotGridFieldSortBySummaryInfo.Field) property
* [PivotGridFieldBase.SummaryType](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotGridFieldBase.SummaryType) property
* [PivotGridFieldBase.Visible](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotGridFieldBase.Visible) property
* [PivotGridFieldBase.Area](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotGridFieldBase.Area) property

## Files to Review

* [Form1.cs](./CS/CustomSortingExample/Form1.cs) (VB: [Form1.vb](./VB/CustomSortingExample/Form1.vb))

## Documentation

* [Sorting](https://docs.devexpress.com/WindowsForms/1809)
* [Binding to Excel Data Source](https://docs.devexpress.com/WindowsForms/115529)
