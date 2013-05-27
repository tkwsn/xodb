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

    [Persistent(@"Q_DictionaryPartKit")]
    public partial class DictionaryPartKit : XPLiteObject
    {
        Guid fPartKitID;
        [Key(true)]
        public Guid PartKitID
        {
            get { return fPartKitID; }
            set { SetPropertyValue<Guid>("PartKitID", ref fPartKitID, value); }
        }
        string fStandardPartKitName;
        [Size(60)]
        public string StandardPartKitName
        {
            get { return fStandardPartKitName; }
            set { SetPropertyValue<string>("StandardPartKitName", ref fStandardPartKitName, value); }
        }
        string fCustomPartKitName;
        [Size(60)]
        public string CustomPartKitName
        {
            get { return fCustomPartKitName; }
            set { SetPropertyValue<string>("CustomPartKitName", ref fCustomPartKitName, value); }
        }
        string fDescription;
        [Size(255)]
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>("Description", ref fDescription, value); }
        }
        [Association(@"DictionaryPartKitItemReferencesQ_DictionaryPartKit", typeof(DictionaryPartKitItem))]
        public XPCollection<DictionaryPartKitItem> DictionaryPartKitItems { get { return GetCollection<DictionaryPartKitItem>("DictionaryPartKitItems"); } }
        [Association(@"ModelPartKitReferencesQ_DictionaryPartKit", typeof(ModelPartKit))]
        public XPCollection<ModelPartKit> ModelPartKits { get { return GetCollection<ModelPartKit>("ModelPartKits"); } }
    }

}
