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

    [Persistent(@"X_TenementProvince")]
    public partial class TenementProvince : XPLiteObject
    {
        Guid fTenementProvinceID;
        [Key(true)]
        public Guid TenementProvinceID
        {
            get { return fTenementProvinceID; }
            set { SetPropertyValue<Guid>("TenementProvinceID", ref fTenementProvinceID, value); }
        }
        Tenement fTenementID;
        [Association(@"TenementProvinceReferencesTenement")]
        public Tenement TenementID
        {
            get { return fTenementID; }
            set { SetPropertyValue<Tenement>("TenementID", ref fTenementID, value); }
        }
        Province fProvinceID;
        [Association(@"TenementProvinceReferencesProvince")]
        public Province ProvinceID
        {
            get { return fProvinceID; }
            set { SetPropertyValue<Province>("ProvinceID", ref fProvinceID, value); }
        }
    }

}
