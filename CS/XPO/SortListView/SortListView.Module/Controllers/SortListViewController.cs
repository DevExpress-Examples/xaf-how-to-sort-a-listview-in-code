using System;
using DevExpress.Data;
using DevExpress.Xpo.DB;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Model;
using SortListView.Module.BusinessObjects;

namespace WinWebSolution.Module {
    public abstract class SortListViewControllerBase : ViewController<ListView> {
        public SortListViewControllerBase() {
            TargetObjectType = typeof(Issue);
        }
        protected override void OnActivated() {
            base.OnActivated();
            string propertyName = "ModifiedOn";
            bool demoFlag = true;
            //Dennis: This code applies a client side sorting.
            if (demoFlag) {
                IModelColumn columnInfo = ((IModelList<IModelColumn>)View.Model.Columns)[propertyName];
                if (columnInfo != null) {
                    columnInfo.SortIndex = 0;
                    columnInfo.SortOrder = ColumnSortOrder.Descending;
                }
            } else {
                //Dennis: This code is used for the server side sorting.
                if (((IModelList<IModelSortProperty>)View.Model.Sorting)[propertyName] == null) {
                    IModelSortProperty sortProperty = View.Model.Sorting.AddNode<IModelSortProperty>(propertyName);
                    sortProperty.Direction = SortingDirection.Descending;
                    sortProperty.PropertyName = propertyName;
                }
            }
        }
    }
}