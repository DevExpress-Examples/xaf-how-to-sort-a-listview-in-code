using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.BaseImpl.EF;

namespace SortListView.Module.BusinessObjects {
    [DefaultClassOptions]
    public class Issue : BaseObject {
        protected DateTime _ModifiedOn = DateTime.Now;
        [ModelDefault("EditMask", "G")]
        [ModelDefault("DisplayFormat", "{0:G}")]
        public DateTime ModifiedOn {
            get { return _ModifiedOn; }
        }
        internal virtual void UpdateModifiedOn() {
            UpdateModifiedOn(DateTime.Now);
        }
        internal virtual void UpdateModifiedOn(DateTime date) {
            _ModifiedOn = date;
        }
        public virtual string Subject { get; set; }
        public virtual string Description { get; set; }
    }
}