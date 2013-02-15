//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
namespace XODB.Module.BusinessObjects.XODB
{

    [Persistent(@"X_GeophysicsCompany")]
    public partial class GeophysicsCompany : XPLiteObject
    {
        Guid fGeophysicsCompanyID;
        [Key(true)]
        public Guid GeophysicsCompanyID
        {
            get { return fGeophysicsCompanyID; }
            set { SetPropertyValue<Guid>("GeophysicsCompanyID", ref fGeophysicsCompanyID, value); }
        }
        Company fCompanyID;
        [Association(@"GeophysicsCompanyReferencesCompany")]
        public Company CompanyID
        {
            get { return fCompanyID; }
            set { SetPropertyValue<Company>("CompanyID", ref fCompanyID, value); }
        }
        [Association(@"HeaderReferencesGeophysicsCompany", typeof(Header))]
        public XPCollection<Header> Headers { get { return GetCollection<Header>("Headers"); } }
    }

}
