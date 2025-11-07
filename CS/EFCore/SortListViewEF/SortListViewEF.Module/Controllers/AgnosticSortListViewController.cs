using DevExpress.ExpressApp.Editors;
using SortListView.Module;

namespace SortListViewEF.Module.Controllers
{
    public partial class AgnosticSortListViewController : SortListViewControllerBase
    {
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            if (View.Editor is ColumnsListEditor listEditor)
            {
                foreach (var column in listEditor.Columns)
                {
                    column.AllowSortingChange = false;
                }
            }
        }
    }
}
