<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128593846/22.2.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1276)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [BlazorSortRootListViewController.cs](CS/EFCore/SortListViewEF/SortListViewEF.Blazor.Server/Controllers/BlazorSortRootListViewController.cs) 
* [WinSortListViewController.cs](CS/EFCore/SortListViewEF/SortListViewEF.Win/Controllers/WinSortListViewController.cs) 
* **[SortListViewController.cs](CS/EFCore/SortListViewEF/SortListViewEF.Module/Controllers/SortListViewController.cs)**
<!-- default file list end -->
# How to sort a ListView in code

<p>In this example, we demonstrate how to apply sorting by a property of your business object, and disallow end-users from changing this sorting themselves. Consider the following scenario: we have an Issue business class that has the ModifiedOn property, and we need to show the last modified issue always on the top of the grid. This can be done if we implement a ViewController for the Issue ListView, and configure sorting for the required column of this ListView in the application model. This is done in the SortListViewControllerBase class, which is platform-agnostic.<br />
After that, we should implement platform-dependant controllers that will disable the sorting functionality in the grid. Take special note that by using this approach, your end-users will see that the grid is sorted by a column (a small arrow will be shown in the column header). Alternatively, you can use the <a href="http://documentation.devexpress.com/#Xaf/clsDevExpressExpressAppModelIModelSortingtopic"><u>Sorting</u></a> property of the ListView application model element.<br />
This approach can be used to sort both nested and root ListViews, and also will work if the server mode is enabled in the ListView.</p><p><strong>See Also:</strong><br />
<a href="https://www.devexpress.com/Support/Center/p/E1253">How to sort a nested ListView at the business objects level, in code</a><br />
<a href="https://www.devexpress.com/Support/Center/p/E1254">How to prevent sorting and grouping by certain columns in a ListView</a><br />
<a href="http://documentation.devexpress.com/#Xaf/CustomDocument2810"><u>How to: Access the Application Model in Code</u></a></p>

<br/>


