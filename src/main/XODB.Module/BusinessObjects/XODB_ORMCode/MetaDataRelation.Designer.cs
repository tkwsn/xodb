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

    [Persistent(@"X_MetaDataRelation")]
    public partial class MetaDataRelation : XPLiteObject
    {
        Guid fMetaDataRelationID;
        [Key(true)]
        public Guid MetaDataRelationID
        {
            get { return fMetaDataRelationID; }
            set { SetPropertyValue<Guid>("MetaDataRelationID", ref fMetaDataRelationID, value); }
        }
        MetaData fMetaDataID;
        [Association(@"MetaDataRelationReferencesMetaData")]
        public MetaData MetaDataID
        {
            get { return fMetaDataID; }
            set { SetPropertyValue<MetaData>("MetaDataID", ref fMetaDataID, value); }
        }
        string fTableType;
        [Size(50)]
        public string TableType
        {
            get { return fTableType; }
            set { SetPropertyValue<string>("TableType", ref fTableType, value); }
        }
        Guid fReferenceID;
        public Guid ReferenceID
        {
            get { return fReferenceID; }
            set { SetPropertyValue<Guid>("ReferenceID", ref fReferenceID, value); }
        }
    }

}
