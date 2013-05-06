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

    [Persistent(@"X_DictionarySurveyAccuracy")]
    public partial class DictionarySurveyAccuracy : XPLiteObject
    {
        Guid fSurveyAccuracyID;
        [Key(true)]
        public Guid SurveyAccuracyID
        {
            get { return fSurveyAccuracyID; }
            set { SetPropertyValue<Guid>("SurveyAccuracyID", ref fSurveyAccuracyID, value); }
        }
        string fStandardSurveyAccuracyName;
        [Indexed(Name = @"IDictionarySurveyAccuracy", Unique = true)]
        [Size(16)]
        public string StandardSurveyAccuracyName
        {
            get { return fStandardSurveyAccuracyName; }
            set { SetPropertyValue<string>("StandardSurveyAccuracyName", ref fStandardSurveyAccuracyName, value); }
        }
        string fCoalSurveyAccuracyName;
        [Size(16)]
        public string CoalSurveyAccuracyName
        {
            get { return fCoalSurveyAccuracyName; }
            set { SetPropertyValue<string>("CoalSurveyAccuracyName", ref fCoalSurveyAccuracyName, value); }
        }
        string fGoldSurveyAccuracyName;
        [Size(16)]
        public string GoldSurveyAccuracyName
        {
            get { return fGoldSurveyAccuracyName; }
            set { SetPropertyValue<string>("GoldSurveyAccuracyName", ref fGoldSurveyAccuracyName, value); }
        }
        string fCustomSurveyAccuracyName;
        [Size(16)]
        public string CustomSurveyAccuracyName
        {
            get { return fCustomSurveyAccuracyName; }
            set { SetPropertyValue<string>("CustomSurveyAccuracyName", ref fCustomSurveyAccuracyName, value); }
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
        [Association(@"DictionarySurveyAccuracyReferencesFileData")]
        public FileData OriginalFileDataID
        {
            get { return fOriginalFileDataID; }
            set { SetPropertyValue<FileData>("OriginalFileDataID", ref fOriginalFileDataID, value); }
        }
        [Association(@"HeaderReferencesDictionarySurveyAccuracy", typeof(Header))]
        public XPCollection<Header> Headers { get { return GetCollection<Header>("Headers"); } }
    }

}
