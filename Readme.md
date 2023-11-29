<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1276)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->


# How to sort a ListView in code

This example shows how to sort a list view by a class property and disallow end-users from changing this sorting themselves.
![image](https://github.com/DevExpress-Examples/XAF_how-to-sort-a-listview-in-code-e1276/assets/14300209/5b0a91c3-3b8e-4b02-b5aa-62a6b6a25314)

## Implementation Details
Create a base plaform-agnostic ViewController and sort the required columns in the [Application Model](https://docs.devexpress.com/eXpressAppFramework/112579/ui-construction/application-model-ui-settings-storage) in it. After that, implement its platform-dependent descendants that disable the sorting functionality in the underlying grid controls. 

This approach can be used to sort both nested and root ListViews, and also will work if the server mode is enabled in the ListView.


## Documentation 


- [Read and Set Values for Built-in Application Model Nodes in Code](https://docs.devexpress.com/eXpressAppFramework/112810/ui-construction/application-model-ui-settings-storage/customize-application-model-in-code/access-the-application-model-in-code)
- [Access List View Grid Component Settings Using a Controller (.NET 5)](https://docs.devexpress.com/eXpressAppFramework/402154/getting-started/in-depth-tutorial-blazor/extend-functionality/access-data-grid-settings)


## Files to Review

- **[SortListViewController.cs](CS/EFCore/SortListViewEF/SortListViewEF.Module/Controllers/SortListViewController.cs)**
- [BlazorSortRootListViewController.cs](CS/EFCore/SortListViewEF/SortListViewEF.Blazor.Server/Controllers/BlazorSortRootListViewController.cs) 
- [WinSortListViewController.cs](CS/EFCore/SortListViewEF/SortListViewEF.Win/Controllers/WinSortListViewController.cs) 



