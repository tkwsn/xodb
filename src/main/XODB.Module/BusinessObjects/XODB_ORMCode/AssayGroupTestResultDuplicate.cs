using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
namespace XODB.Module.BusinessObjects.XODB
{

    public partial class AssayGroupTestResultDuplicate
    {
        public AssayGroupTestResultDuplicate(Session session) : base(session) { }
        public AssayGroupTestResultDuplicate() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
