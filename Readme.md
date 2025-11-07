<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1276)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# XAF - How to sort a ListView in code

This example sorts list view data by a class property and prevents users from modifying the sorting settings.

![Data sorted by Modified On column value](blazor-sorted-grid.png)

## Implementation Details

1. Create a view controller in the application model and configure sorting settings for the list view's column:

    _File to review:_ [SortListViewController.cs](CS/EFCore/SortListViewEF/SortListViewEF.Module/Controllers/SortListViewController.cs) 
    ```cs
    protected override void OnActivated() {
        base.OnActivated();
        string propertyName = nameof(Issue.ModifiedOn);
        bool demoFlag = true;
        // This code applies a client side sorting.
        if(demoFlag) {
            IModelColumn columnInfo = View.Model.Columns[propertyName];
            if(columnInfo != null) {
                columnInfo.SortIndex = 0;
                columnInfo.SortOrder = ColumnSortOrder.Descending;
            }
        } else {
            // This code is used for the server side sorting.
            if(View.Model.Sorting[propertyName] == null) {
                IModelSortProperty sortProperty = View.Model.Sorting.AddNode<IModelSortProperty>(propertyName);
                sortProperty.Direction = SortingDirection.Descending;
                sortProperty.PropertyName = propertyName;
            }
        }
    }
    ```

2. Implement platform-dependent controllers that disable the sorting functionality in underlying grid controls:

    _File to review:_ [BlazorSortListViewController.cs](CS/EFCore/SortListViewEF/SortListViewEF.Blazor.Server/Controllers/BlazorSortListViewController.cs) 
    ```cs
    protected override void OnViewControlsCreated() {
        base.OnViewControlsCreated();
        if(View.Editor is DxGridListEditor gridListEditor) {
            foreach(DxGridDataColumnModel columnModel in gridListEditor.GridDataColumnModels) {
                columnModel.AllowSort = false;
            }
        }
    }
    ```

    _File to review:_ [WinSortListViewController.cs](CS/EFCore/SortListViewEF/SortListViewEF.Win/Controllers/WinSortListViewController.cs) 

    ```cs
    protected override void OnViewControlsCreated() {
        base.OnViewControlsCreated();
        if(View.Editor is GridListEditor gridListEditor) {
            gridListEditor.GridView.OptionsCustomization.AllowSort = false;
        }
    }
    ```

This approach allows you to sort both nested and root list views, and works if server mode is enabled in the list view.

## Documentation 

- [Application Model (UI Settings Storage)](https://docs.devexpress.com/eXpressAppFramework/112579/ui-construction/application-model-ui-settings-storage)
- [Read and Set Values for Built-in Application Model Nodes in Code](https://docs.devexpress.com/eXpressAppFramework/112810/ui-construction/application-model-ui-settings-storage/customize-application-model-in-code/access-the-application-model-in-code)
- [How to: Access the Grid Component in a List View](https://docs.devexpress.com/eXpressAppFramework/402154/ui-construction/list-editors/how-to-access-list-editor-control)

## Files to Review

- [SortListViewController.cs](CS/EFCore/SortListViewEF/SortListViewEF.Module/Controllers/SortListViewController.cs)
- [BlazorSortListViewController.cs](CS/EFCore/SortListViewEF/SortListViewEF.Blazor.Server/Controllers/BlazorSortListViewController.cs) 
- [WinSortListViewController.cs](CS/EFCore/SortListViewEF/SortListViewEF.Win/Controllers/WinSortListViewController.cs) 



<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=xaf-how-to-sort-a-listview-in-code&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=xaf-how-to-sort-a-listview-in-code&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
