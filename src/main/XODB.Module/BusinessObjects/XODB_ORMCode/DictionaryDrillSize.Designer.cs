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

    [Persistent(@"X_DictionaryDrillSize")]
    public partial class DictionaryDrillSize : XPLiteObject
    {
        Guid fDrillSizeID;
        [Key(true)]
        public Guid DrillSizeID
        {
            get { return fDrillSizeID; }
            set { SetPropertyValue<Guid>("DrillSizeID", ref fDrillSizeID, value); }
        }
        string fStandardDrillSizeName;
        [Indexed(Name = @"IDictionaryDrillSize", Unique = true)]
        [Size(16)]
        public string StandardDrillSizeName
        {
            get { return fStandardDrillSizeName; }
            set { SetPropertyValue<string>("StandardDrillSizeName", ref fStandardDrillSizeName, value); }
        }
        string fCoalDrillSizeName;
        [Size(16)]
        public string CoalDrillSizeName
        {
            get { return fCoalDrillSizeName; }
            set { SetPropertyValue<string>("CoalDrillSizeName", ref fCoalDrillSizeName, value); }
        }
        string fGoldDrillSizeName;
        [Size(16)]
        public string GoldDrillSizeName
        {
            get { return fGoldDrillSizeName; }
            set { SetPropertyValue<string>("GoldDrillSizeName", ref fGoldDrillSizeName, value); }
        }
        string fCustomDrillSizeName;
        [Size(16)]
        public string CustomDrillSizeName
        {
            get { return fCustomDrillSizeName; }
            set { SetPropertyValue<string>("CustomDrillSizeName", ref fCustomDrillSizeName, value); }
        }
        string fDescription;
        [Size(255)]
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>("Description", ref fDescription, value); }
        }
        string fFullDescription;
        [Size(SizeAttribute.Unlimited)]
        public string FullDescription
        {
            get { return fFullDescription; }
            set { SetPropertyValue<string>("FullDescription", ref fFullDescription, value); }
        }
        byte[] fThumbnail;
        [Size(SizeAttribute.Unlimited)]
        public byte[] Thumbnail
        {
            get { return fThumbnail; }
            set { SetPropertyValue<byte[]>("Thumbnail", ref fThumbnail, value); }
        }
        FileData fOriginalFileDataID;
        [Association(@"DictionaryDrillSizeReferencesFileData")]
        public FileData OriginalFileDataID
        {
            get { return fOriginalFileDataID; }
            set { SetPropertyValue<FileData>("OriginalFileDataID", ref fOriginalFileDataID, value); }
        }
        [Association(@"DrillingReferencesDictionaryDrillSize", typeof(Drilling))]
        public XPCollection<Drilling> Drillings { get { return GetCollection<Drilling>("Drillings"); } }
        [Association(@"RecoveryReferencesDictionaryDrillSize", typeof(Recovery))]
        public XPCollection<Recovery> Recoverys { get { return GetCollection<Recovery>("Recoverys"); } }
    }

}
