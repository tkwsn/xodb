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

    [Persistent(@"X_DictionaryBasalContact")]
    public partial class DictionaryBasalContact : XPLiteObject
    {
        Guid fBasalContactID;
        [Key(true)]
        public Guid BasalContactID
        {
            get { return fBasalContactID; }
            set { SetPropertyValue<Guid>("BasalContactID", ref fBasalContactID, value); }
        }
        string fStandardBasalContactName;
        [Indexed(Name = @"IDictionaryBasalContact", Unique = true)]
        [Size(16)]
        public string StandardBasalContactName
        {
            get { return fStandardBasalContactName; }
            set { SetPropertyValue<string>("StandardBasalContactName", ref fStandardBasalContactName, value); }
        }
        string fCoalBasalContactName;
        [Size(16)]
        public string CoalBasalContactName
        {
            get { return fCoalBasalContactName; }
            set { SetPropertyValue<string>("CoalBasalContactName", ref fCoalBasalContactName, value); }
        }
        string fGoldBasalContactName;
        [Size(16)]
        public string GoldBasalContactName
        {
            get { return fGoldBasalContactName; }
            set { SetPropertyValue<string>("GoldBasalContactName", ref fGoldBasalContactName, value); }
        }
        string fCustomBasalContactName;
        [Size(16)]
        public string CustomBasalContactName
        {
            get { return fCustomBasalContactName; }
            set { SetPropertyValue<string>("CustomBasalContactName", ref fCustomBasalContactName, value); }
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
        [Association(@"DictionaryBasalContactReferencesFileData")]
        public FileData OriginalFileDataID
        {
            get { return fOriginalFileDataID; }
            set { SetPropertyValue<FileData>("OriginalFileDataID", ref fOriginalFileDataID, value); }
        }
        [Association(@"LithologyReferencesDictionaryBasalContact", typeof(Lithology))]
        public XPCollection<Lithology> Lithologys { get { return GetCollection<Lithology>("Lithologys"); } }
    }

}
