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

    [Persistent(@"X_DictionaryLocationType")]
    public partial class DictionaryLocationType : XPLiteObject
    {
        Guid fLocationTypeID;
        [Key(true)]
        public Guid LocationTypeID
        {
            get { return fLocationTypeID; }
            set { SetPropertyValue<Guid>("LocationTypeID", ref fLocationTypeID, value); }
        }
        string fStandardLocationTypeName;
        [Indexed(Name = @"IDictionaryLocationType", Unique = true)]
        [Size(16)]
        public string StandardLocationTypeName
        {
            get { return fStandardLocationTypeName; }
            set { SetPropertyValue<string>("StandardLocationTypeName", ref fStandardLocationTypeName, value); }
        }
        string fCoalLocationTypeName;
        [Size(16)]
        public string CoalLocationTypeName
        {
            get { return fCoalLocationTypeName; }
            set { SetPropertyValue<string>("CoalLocationTypeName", ref fCoalLocationTypeName, value); }
        }
        string fGoldLocationTypeName;
        [Size(16)]
        public string GoldLocationTypeName
        {
            get { return fGoldLocationTypeName; }
            set { SetPropertyValue<string>("GoldLocationTypeName", ref fGoldLocationTypeName, value); }
        }
        string fCustomLocationTypeName;
        [Size(16)]
        public string CustomLocationTypeName
        {
            get { return fCustomLocationTypeName; }
            set { SetPropertyValue<string>("CustomLocationTypeName", ref fCustomLocationTypeName, value); }
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
        [Association(@"DictionaryLocationTypeReferencesFileData")]
        public FileData OriginalFileDataID
        {
            get { return fOriginalFileDataID; }
            set { SetPropertyValue<FileData>("OriginalFileDataID", ref fOriginalFileDataID, value); }
        }
        [Association(@"LocationReferencesDictionaryLocationType", typeof(Location))]
        public XPCollection<Location> Locations { get { return GetCollection<Location>("Locations"); } }
        [Association(@"LocationReferencesDictionaryLocationType1", typeof(Location))]
        public XPCollection<Location> Locations1 { get { return GetCollection<Location>("Locations1"); } }
    }

}
