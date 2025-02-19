using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;
using System.ComponentModel;

namespace SortListView.Module.BusinessObjects {
    [DefaultClassOptions]
    public class Issue : BaseObject {

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
        protected override void OnPropertyChanged(object sender, PropertyChangedEventArgs e) {
            base.OnPropertyChanged(sender, e);
            if (e.PropertyName == nameof(Subject) || e.PropertyName == nameof(Description)) {
                UpdateModifiedOn();
            }
        }
        public virtual string Subject { get; set; }
        public virtual string Description { get; set; }
        [HideInUI(HideInUI.All)]
        public virtual DateTime _ModifiedOn { get; set; } = DateTime.Now;
    }
}