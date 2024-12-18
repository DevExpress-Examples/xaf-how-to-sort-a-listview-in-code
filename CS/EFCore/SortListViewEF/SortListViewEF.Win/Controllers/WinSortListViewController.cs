using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Win.Editors;
using SortListViewEF.Module;

namespace SortListViewEF.Win.Controllers {
    public class WinSortListViewController : SortListViewControllerBase {
        protected override void OnViewControlsCreated() {
            base.OnViewControlsCreated();
            if(View.Editor is GridListEditor gridListEditor) {
                gridListEditor.GridView.OptionsCustomization.AllowSort = false;
            }
        }
    }
}
