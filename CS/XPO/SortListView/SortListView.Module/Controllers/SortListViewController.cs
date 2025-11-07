using DevExpress.Data;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;
using DevExpress.Xpo.DB;
using SortListView.Module.BusinessObjects;

namespace SortListView.Module {
    public abstract class SortListViewControllerBase : ObjectViewController<ListView, Issue> {
        
        string propertyName = nameof(Issue.ModifiedOn);
        bool demoFlag = true;

        protected override void OnActivated()
        {
            base.OnActivated();
            if (!demoFlag && View.Model.Sorting[propertyName] == null)
            {
                // This code applies a server side sorting.
                IModelSortProperty sortProperty = View.Model.Sorting.AddNode<IModelSortProperty>(propertyName);
                sortProperty.Direction = SortingDirection.Ascending;
                sortProperty.PropertyName = propertyName;
            }
        }

        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            if (View.Editor is ColumnsListEditor listEditor)
            {
                foreach (var columnWrapper in listEditor.Columns)
                {
                    columnWrapper.AllowSortingChange = true;
                    // This code applies a client side sorting.
                    if (demoFlag && columnWrapper.PropertyName == propertyName)
                    {
                        columnWrapper.SortIndex = 0;
                        columnWrapper.SortOrder = ColumnSortOrder.Descending;
                    }
                }
            }
        }
    }
}