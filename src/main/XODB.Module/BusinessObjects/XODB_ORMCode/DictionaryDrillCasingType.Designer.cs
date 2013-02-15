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

    [Persistent(@"X_DictionaryDrillCasingType")]
    public partial class DictionaryDrillCasingType : XPLiteObject
    {
        Guid fDrillCasingTypeID;
        [Key(true)]
        public Guid DrillCasingTypeID
        {
            get { return fDrillCasingTypeID; }
            set { SetPropertyValue<Guid>("DrillCasingTypeID", ref fDrillCasingTypeID, value); }
        }
        string fStandardDrillCasingTypeName;
        [Indexed(Name = @"IDictionaryDrillCasingType", Unique = true)]
        [Size(16)]
        public string StandardDrillCasingTypeName
        {
            get { return fStandardDrillCasingTypeName; }
            set { SetPropertyValue<string>("StandardDrillCasingTypeName", ref fStandardDrillCasingTypeName, value); }
        }
        string fCoalDrillCasingTypeName;
        [Size(16)]
        public string CoalDrillCasingTypeName
        {
            get { return fCoalDrillCasingTypeName; }
            set { SetPropertyValue<string>("CoalDrillCasingTypeName", ref fCoalDrillCasingTypeName, value); }
        }
        string fGoldDrillCasingTypeName;
        [Size(16)]
        public string GoldDrillCasingTypeName
        {
            get { return fGoldDrillCasingTypeName; }
            set { SetPropertyValue<string>("GoldDrillCasingTypeName", ref fGoldDrillCasingTypeName, value); }
        }
        string fCustomDrillCasingTypeName;
        [Size(16)]
        public string CustomDrillCasingTypeName
        {
            get { return fCustomDrillCasingTypeName; }
            set { SetPropertyValue<string>("CustomDrillCasingTypeName", ref fCustomDrillCasingTypeName, value); }
        }
        string fDescription;
        [Size(255)]
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>("Description", ref fDescription, value); }
        }
        [Association(@"CasingReferencesDictionaryDrillCasingType", typeof(Casing))]
        public XPCollection<Casing> Casings { get { return GetCollection<Casing>("Casings"); } }
    }

}
