<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128579525/18.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E331)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/CustomSortingExample/Form1.cs) (VB: [Form1.vb](./VB/CustomSortingExample/Form1.vb))
<!-- default file list end -->
# Pivot Grid for WinForms - How to use a hidden field to sort the visible field

This example demonstrates how to sort a field (_Sales Person)_ by the hidden data field values (_Last Name_).

Check the _Enable custom sorting_ box to sort the _Sales Person_ values by _Last Name_ instead of the default alphabetical sorting order.

![](./images/screenshot.png)

The checked _Enable custom sorting_ box enables the [Sorting by Summary](https://docs.devexpress.com/WindowsForms/9726/controls-and-libraries/pivot-grid/data-shaping/sorting/sorting-by-summary) functionality for the _Sales Person_ field. The  _Last Name_ field is placed in the Data Area to calculate a  summary value that should be used to sort the _Sales Person_ field values.

This example uses the following API:
* [PivotGridFieldBase.SortBySummaryInfo](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotGridFieldBase.SortBySummaryInfo) property
* [PivotGridFieldSortBySummaryInfo.Field](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotGridFieldSortBySummaryInfo.Field) property
* [PivotGridFieldBase.SummaryType](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotGridFieldBase.SummaryType) property
* [PivotGridFieldBase.Visible](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotGridFieldBase.Visible) property
* [PivotGridFieldBase.Area](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotGridFieldBase.Area) property

**See also:**

* [Sorting](https://docs.devexpress.com/WindowsForms/1809)
* [Binding to Excel Data Source](https://docs.devexpress.com/WindowsForms/115529)