using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
namespace XODB.Module.BusinessObjects.XODB
{

    public partial class GeophysicsMetadata
    {
        public GeophysicsMetadata(Session session) : base(session) { }
        public GeophysicsMetadata() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
