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

    [Persistent(@"X_DictionaryProvinceType")]
    public partial class DictionaryProvinceType : XPLiteObject
    {
        Guid fProvinceTypeID;
        [Key(true)]
        public Guid ProvinceTypeID
        {
            get { return fProvinceTypeID; }
            set { SetPropertyValue<Guid>("ProvinceTypeID", ref fProvinceTypeID, value); }
        }
        string fStandardProvinceTypeName;
        [Indexed(Name = @"IDictionaryProvinceType", Unique = true)]
        [Size(16)]
        public string StandardProvinceTypeName
        {
            get { return fStandardProvinceTypeName; }
            set { SetPropertyValue<string>("StandardProvinceTypeName", ref fStandardProvinceTypeName, value); }
        }
        string fCoalProvinceTypeName;
        [Size(16)]
        public string CoalProvinceTypeName
        {
            get { return fCoalProvinceTypeName; }
            set { SetPropertyValue<string>("CoalProvinceTypeName", ref fCoalProvinceTypeName, value); }
        }
        string fGoldProvinceTypeName;
        [Size(16)]
        public string GoldProvinceTypeName
        {
            get { return fGoldProvinceTypeName; }
            set { SetPropertyValue<string>("GoldProvinceTypeName", ref fGoldProvinceTypeName, value); }
        }
        string fCustomProvinceTypeName;
        [Size(16)]
        public string CustomProvinceTypeName
        {
            get { return fCustomProvinceTypeName; }
            set { SetPropertyValue<string>("CustomProvinceTypeName", ref fCustomProvinceTypeName, value); }
        }
        string fDescription;
        [Size(255)]
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>("Description", ref fDescription, value); }
        }
        [Association(@"DictionaryProvinceGroupReferencesDictionaryProvinceType", typeof(DictionaryProvinceGroup))]
        public XPCollection<DictionaryProvinceGroup> DictionaryProvinceGroups { get { return GetCollection<DictionaryProvinceGroup>("DictionaryProvinceGroups"); } }
        [Association(@"ProvinceReferencesDictionaryProvinceType", typeof(Province))]
        public XPCollection<Province> Provinces { get { return GetCollection<Province>("Provinces"); } }
    }

}
