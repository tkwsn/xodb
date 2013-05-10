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

    [Persistent(@"X_DictionaryProfession")]
    public partial class DictionaryProfession : XPLiteObject
    {
        Guid fProfessionID;
        [Key(true)]
        public Guid ProfessionID
        {
            get { return fProfessionID; }
            set { SetPropertyValue<Guid>("ProfessionID", ref fProfessionID, value); }
        }
        string fStandardProfessionName;
        [Indexed(Name = @"IDictionaryProfession", Unique = true)]
        [Size(16)]
        public string StandardProfessionName
        {
            get { return fStandardProfessionName; }
            set { SetPropertyValue<string>("StandardProfessionName", ref fStandardProfessionName, value); }
        }
        string fCoalProfessionName;
        [Size(16)]
        public string CoalProfessionName
        {
            get { return fCoalProfessionName; }
            set { SetPropertyValue<string>("CoalProfessionName", ref fCoalProfessionName, value); }
        }
        string fGoldProfessionName;
        [Size(16)]
        public string GoldProfessionName
        {
            get { return fGoldProfessionName; }
            set { SetPropertyValue<string>("GoldProfessionName", ref fGoldProfessionName, value); }
        }
        string fCustomProfessionName;
        [Size(16)]
        public string CustomProfessionName
        {
            get { return fCustomProfessionName; }
            set { SetPropertyValue<string>("CustomProfessionName", ref fCustomProfessionName, value); }
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
        [Association(@"DictionaryProfessionReferencesFileData")]
        public FileData OriginalFileDataID
        {
            get { return fOriginalFileDataID; }
            set { SetPropertyValue<FileData>("OriginalFileDataID", ref fOriginalFileDataID, value); }
        }
        [Association(@"X_DictionaryWorkTypeReferencesDictionaryProfession", typeof(DictionaryWorkType))]
        public XPCollection<DictionaryWorkType> X_DictionaryWorkTypes { get { return GetCollection<DictionaryWorkType>("X_DictionaryWorkTypes"); } }
        [Association(@"ExperienceReferencesDictionaryProfession", typeof(Experience))]
        public XPCollection<Experience> Experiences { get { return GetCollection<Experience>("Experiences"); } }
    }

}
