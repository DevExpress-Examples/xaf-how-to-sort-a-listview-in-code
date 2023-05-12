using DevExpress.ExpressApp;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Persistent.BaseImpl;
using SortListView.Module.BusinessObjects;

namespace SortListView.Module.DatabaseUpdate;

// For more typical usage scenarios, be sure to check out https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Updating.ModuleUpdater
public class Updater : ModuleUpdater {
    public Updater(IObjectSpace objectSpace, Version currentDBVersion) :
        base(objectSpace, currentDBVersion) {
    }
    public override void UpdateDatabaseAfterUpdateSchema() {
        base.UpdateDatabaseAfterUpdateSchema();
        //string name = "MyName";
        //DomainObject1 theObject = ObjectSpace.FirstOrDefault<DomainObject1>(u => u.Name == name);
        //if(theObject == null) {
        //    theObject = ObjectSpace.CreateObject<DomainObject1>();
        //    theObject.Name = name;
        //}
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
        //if(CurrentDBVersion < new Version("1.1.0.0") && CurrentDBVersion > new Version("0.0.0.0")) {
        //    RenameColumn("DomainObject1Table", "OldColumnName", "NewColumnName");
        //}
    }
}
