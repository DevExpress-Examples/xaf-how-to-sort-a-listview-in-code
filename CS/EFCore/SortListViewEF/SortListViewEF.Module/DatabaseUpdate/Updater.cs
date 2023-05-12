using DevExpress.ExpressApp;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Updating;
using DevExpress.ExpressApp.EF;
using DevExpress.Persistent.BaseImpl.EF;
using SortListView.Module.BusinessObjects;

namespace SortListViewEF.Module.DatabaseUpdate;

// For more typical usage scenarios, be sure to check out https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Updating.ModuleUpdater
public class Updater : ModuleUpdater {
    public Updater(IObjectSpace objectSpace, Version currentDBVersion) :
        base(objectSpace, currentDBVersion) {
    }
    public override void UpdateDatabaseAfterUpdateSchema() {
        base.UpdateDatabaseAfterUpdateSchema();
        var cnt = ObjectSpace.GetObjectsCount(typeof(Issue), null);
        if (cnt > 0) {
            return;
        }

        Issue obj1 = ObjectSpace.CreateObject<Issue>();
        obj1.Subject = "Issue 3";
        obj1.UpdateModifiedOn();
        Issue obj2 = ObjectSpace.CreateObject<Issue>();
        obj2.Subject = "Issue 2";
        obj2.UpdateModifiedOn(new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day - 1));
        Issue obj3 = ObjectSpace.CreateObject<Issue>();
        obj3.Subject = "Issue 1";
        obj3.UpdateModifiedOn(new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day - 2));
        ObjectSpace.CommitChanges(); //Uncomment this line to persist created object(s).
    }
    public override void UpdateDatabaseBeforeUpdateSchema() {
        base.UpdateDatabaseBeforeUpdateSchema();
    }
}
