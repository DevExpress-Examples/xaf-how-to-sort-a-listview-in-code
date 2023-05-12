using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Blazor.Editors.Models;
using DevExpress.ExpressApp.Blazor.Editors;

namespace WinWebSolution.Module.Win {
    public class BlazorSortRootListViewController : SortListViewControllerBase {
        protected override void OnViewControlsCreated() {
            base.OnViewControlsCreated();
            if (View.Editor is DxGridListEditor gridListEditor) {
                IDxGridAdapter dataGridAdapter = gridListEditor.GetGridAdapter();
                foreach (DxGridDataColumnModel columnModel in dataGridAdapter.GridDataColumnModels) {
                    columnModel.AllowSort = false;
                }
            }
        }
    }
}