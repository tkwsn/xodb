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

    [Persistent(@"X_DictionaryLithologyQualifier")]
    public partial class DictionaryLithologyQualifier : XPLiteObject
    {
        Guid fLithologyQualifierID;
        [Key(true)]
        public Guid LithologyQualifierID
        {
            get { return fLithologyQualifierID; }
            set { SetPropertyValue<Guid>("LithologyQualifierID", ref fLithologyQualifierID, value); }
        }
        string fStandardLithologyQualifierName;
        [Indexed(Name = @"IDictionaryLithologyQualifiers", Unique = true)]
        [Size(16)]
        public string StandardLithologyQualifierName
        {
            get { return fStandardLithologyQualifierName; }
            set { SetPropertyValue<string>("StandardLithologyQualifierName", ref fStandardLithologyQualifierName, value); }
        }
        string fCoalLithologyQualifierName;
        [Size(16)]
        public string CoalLithologyQualifierName
        {
            get { return fCoalLithologyQualifierName; }
            set { SetPropertyValue<string>("CoalLithologyQualifierName", ref fCoalLithologyQualifierName, value); }
        }
        string fGoldLithologyQualifierName;
        [Size(16)]
        public string GoldLithologyQualifierName
        {
            get { return fGoldLithologyQualifierName; }
            set { SetPropertyValue<string>("GoldLithologyQualifierName", ref fGoldLithologyQualifierName, value); }
        }
        string fCustomLithologyQualifierName;
        [Size(16)]
        public string CustomLithologyQualifierName
        {
            get { return fCustomLithologyQualifierName; }
            set { SetPropertyValue<string>("CustomLithologyQualifierName", ref fCustomLithologyQualifierName, value); }
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
        System.Drawing.Image fThumbnail;
        [Size(SizeAttribute.Unlimited)]
        [ValueConverter(typeof(DevExpress.Xpo.Metadata.ImageValueConverter))]
        public System.Drawing.Image Thumbnail
        {
            get { return fThumbnail; }
            set { SetPropertyValue<System.Drawing.Image>("Thumbnail", ref fThumbnail, value); }
        }
        FileData fOriginalFileDataID;
        [Association(@"DictionaryLithologyQualifierReferencesFileData")]
        public FileData OriginalFileDataID
        {
            get { return fOriginalFileDataID; }
            set { SetPropertyValue<FileData>("OriginalFileDataID", ref fOriginalFileDataID, value); }
        }
        [Association(@"LithologyReferencesDictionaryLithologyQualifier", typeof(Lithology))]
        public XPCollection<Lithology> Lithologies { get { return GetCollection<Lithology>("Lithologies"); } }
    }

}
