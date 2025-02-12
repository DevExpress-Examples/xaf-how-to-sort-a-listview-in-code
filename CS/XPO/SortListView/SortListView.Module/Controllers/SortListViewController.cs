using DevExpress.Data;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Model;
using DevExpress.Xpo.DB;
using SortListView.Module.BusinessObjects;

namespace SortListView.Module {
    public abstract class SortListViewControllerBase : ObjectViewController<ListView, Issue> {
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
    }
}