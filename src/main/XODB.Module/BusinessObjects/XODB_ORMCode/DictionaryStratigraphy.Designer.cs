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

    [Persistent(@"X_DictionaryStratigraphy")]
    public partial class DictionaryStratigraphy : XPLiteObject
    {
        Guid fStratigraphyID;
        [Key(true)]
        public Guid StratigraphyID
        {
            get { return fStratigraphyID; }
            set { SetPropertyValue<Guid>("StratigraphyID", ref fStratigraphyID, value); }
        }
        string fStandardStratigraphyName;
        [Indexed(Name = @"IDictionaryStratigraphy", Unique = true)]
        [Size(16)]
        public string StandardStratigraphyName
        {
            get { return fStandardStratigraphyName; }
            set { SetPropertyValue<string>("StandardStratigraphyName", ref fStandardStratigraphyName, value); }
        }
        string fCoalStratigraphyName;
        [Size(16)]
        public string CoalStratigraphyName
        {
            get { return fCoalStratigraphyName; }
            set { SetPropertyValue<string>("CoalStratigraphyName", ref fCoalStratigraphyName, value); }
        }
        string fGoldStratigraphyName;
        [Size(16)]
        public string GoldStratigraphyName
        {
            get { return fGoldStratigraphyName; }
            set { SetPropertyValue<string>("GoldStratigraphyName", ref fGoldStratigraphyName, value); }
        }
        string fCustomStratigraphyName;
        [Size(16)]
        public string CustomStratigraphyName
        {
            get { return fCustomStratigraphyName; }
            set { SetPropertyValue<string>("CustomStratigraphyName", ref fCustomStratigraphyName, value); }
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
        [Association(@"DictionaryStratigraphyReferencesFileData")]
        public FileData OriginalFileDataID
        {
            get { return fOriginalFileDataID; }
            set { SetPropertyValue<FileData>("OriginalFileDataID", ref fOriginalFileDataID, value); }
        }
        [Association(@"LithologyReferencesDictionaryStratigraphy", typeof(Lithology))]
        public XPCollection<Lithology> Lithologys { get { return GetCollection<Lithology>("Lithologys"); } }
    }

}
