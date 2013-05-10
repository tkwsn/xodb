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

    [Persistent(@"X_DictionaryAlteration")]
    public partial class DictionaryAlteration : XPLiteObject
    {
        Guid fAlterationID;
        [Key(true)]
        public Guid AlterationID
        {
            get { return fAlterationID; }
            set { SetPropertyValue<Guid>("AlterationID", ref fAlterationID, value); }
        }
        string fStandardAlterationName;
        [Indexed(Name = @"IDictionaryAlteration", Unique = true)]
        [Size(16)]
        public string StandardAlterationName
        {
            get { return fStandardAlterationName; }
            set { SetPropertyValue<string>("StandardAlterationName", ref fStandardAlterationName, value); }
        }
        string fCoalAlterationName;
        [Size(16)]
        public string CoalAlterationName
        {
            get { return fCoalAlterationName; }
            set { SetPropertyValue<string>("CoalAlterationName", ref fCoalAlterationName, value); }
        }
        string fGoldAlterationName;
        [Size(16)]
        public string GoldAlterationName
        {
            get { return fGoldAlterationName; }
            set { SetPropertyValue<string>("GoldAlterationName", ref fGoldAlterationName, value); }
        }
        string fCustomAlterationName;
        [Size(16)]
        public string CustomAlterationName
        {
            get { return fCustomAlterationName; }
            set { SetPropertyValue<string>("CustomAlterationName", ref fCustomAlterationName, value); }
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
        [Association(@"DictionaryAlterationReferencesFileData")]
        public FileData OriginalFileDataID
        {
            get { return fOriginalFileDataID; }
            set { SetPropertyValue<FileData>("OriginalFileDataID", ref fOriginalFileDataID, value); }
        }
        [Association(@"X_DefectReferencesDictionaryAlteration", typeof(Defect))]
        public XPCollection<Defect> X_Defects { get { return GetCollection<Defect>("X_Defects"); } }
    }

}
