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

    [Persistent(@"X_DictionaryHoleType")]
    public partial class DictionaryHoleType : XPLiteObject
    {
        Guid fHoleTypeID;
        [Key(true)]
        public Guid HoleTypeID
        {
            get { return fHoleTypeID; }
            set { SetPropertyValue<Guid>("HoleTypeID", ref fHoleTypeID, value); }
        }
        string fStandardHoleTypeName;
        [Indexed(Name = @"IDictionaryHoleType", Unique = true)]
        [Size(16)]
        public string StandardHoleTypeName
        {
            get { return fStandardHoleTypeName; }
            set { SetPropertyValue<string>("StandardHoleTypeName", ref fStandardHoleTypeName, value); }
        }
        string fCoalHoleTypeName;
        [Size(16)]
        public string CoalHoleTypeName
        {
            get { return fCoalHoleTypeName; }
            set { SetPropertyValue<string>("CoalHoleTypeName", ref fCoalHoleTypeName, value); }
        }
        string fGoldHoleTypeName;
        [Size(16)]
        public string GoldHoleTypeName
        {
            get { return fGoldHoleTypeName; }
            set { SetPropertyValue<string>("GoldHoleTypeName", ref fGoldHoleTypeName, value); }
        }
        string fCustomHoleTypeName;
        [Size(16)]
        public string CustomHoleTypeName
        {
            get { return fCustomHoleTypeName; }
            set { SetPropertyValue<string>("CustomHoleTypeName", ref fCustomHoleTypeName, value); }
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
        [Association(@"DictionaryHoleTypeReferencesFileData")]
        public FileData OriginalFileDataID
        {
            get { return fOriginalFileDataID; }
            set { SetPropertyValue<FileData>("OriginalFileDataID", ref fOriginalFileDataID, value); }
        }
        [Association(@"HeaderReferencesDictionaryHoleType", typeof(Header))]
        public XPCollection<Header> Headers { get { return GetCollection<Header>("Headers"); } }
    }

}
