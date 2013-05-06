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

    [Persistent(@"X_DictionarySeam")]
    public partial class DictionarySeam : XPLiteObject
    {
        Guid fSeamID;
        [Key(true)]
        public Guid SeamID
        {
            get { return fSeamID; }
            set { SetPropertyValue<Guid>("SeamID", ref fSeamID, value); }
        }
        string fStandardSeamName;
        [Indexed(Name = @"IDictionarySeam", Unique = true)]
        [Size(16)]
        public string StandardSeamName
        {
            get { return fStandardSeamName; }
            set { SetPropertyValue<string>("StandardSeamName", ref fStandardSeamName, value); }
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
        [Association(@"DictionarySeamReferencesFileData")]
        public FileData OriginalFileDataID
        {
            get { return fOriginalFileDataID; }
            set { SetPropertyValue<FileData>("OriginalFileDataID", ref fOriginalFileDataID, value); }
        }
        [Association(@"DictionarySeamAliasReferencesDictionarySeam", typeof(DictionarySeamAlias))]
        public XPCollection<DictionarySeamAlias> DictionarySeamAliasCollection { get { return GetCollection<DictionarySeamAlias>("DictionarySeamAliasCollection"); } }
        [Association(@"LithologyReferencesDictionarySeam", typeof(Lithology))]
        public XPCollection<Lithology> Lithologies { get { return GetCollection<Lithology>("Lithologies"); } }
    }

}
