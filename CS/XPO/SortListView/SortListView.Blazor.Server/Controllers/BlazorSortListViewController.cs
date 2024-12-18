using DevExpress.ExpressApp.Blazor.Editors;
using DevExpress.ExpressApp.Blazor.Editors.Models;
using SortListView.Module;

namespace SortListView.Blazor.Server.Controllers {
    public class BlazorSortListViewController : SortListViewControllerBase {
        protected override void OnViewControlsCreated() {
            base.OnViewControlsCreated();
            if(View.Editor is DxGridListEditor gridListEditor) {
                foreach(DxGridDataColumnModel columnModel in gridListEditor.GridDataColumnModels) {
                    columnModel.AllowSort = false;
                }
            }
        }
    }
}