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

    [Persistent(@"X_DictionaryPlasticity")]
    public partial class DictionaryPlasticity : XPLiteObject
    {
        Guid fPlasticityID;
        [Key(true)]
        public Guid PlasticityID
        {
            get { return fPlasticityID; }
            set { SetPropertyValue<Guid>("PlasticityID", ref fPlasticityID, value); }
        }
        string fStandardPlasticityName;
        [Indexed(Name = @"IDictionaryPlasticity", Unique = true)]
        [Size(16)]
        public string StandardPlasticityName
        {
            get { return fStandardPlasticityName; }
            set { SetPropertyValue<string>("StandardPlasticityName", ref fStandardPlasticityName, value); }
        }
        string fCoalPlasticityName;
        [Size(16)]
        public string CoalPlasticityName
        {
            get { return fCoalPlasticityName; }
            set { SetPropertyValue<string>("CoalPlasticityName", ref fCoalPlasticityName, value); }
        }
        string fGoldPlasticityName;
        [Size(16)]
        public string GoldPlasticityName
        {
            get { return fGoldPlasticityName; }
            set { SetPropertyValue<string>("GoldPlasticityName", ref fGoldPlasticityName, value); }
        }
        string fCustomPlasticityName;
        [Size(16)]
        public string CustomPlasticityName
        {
            get { return fCustomPlasticityName; }
            set { SetPropertyValue<string>("CustomPlasticityName", ref fCustomPlasticityName, value); }
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
        [Association(@"DictionaryPlasticityReferencesFileData")]
        public FileData OriginalFileDataID
        {
            get { return fOriginalFileDataID; }
            set { SetPropertyValue<FileData>("OriginalFileDataID", ref fOriginalFileDataID, value); }
        }
        [Association(@"X_DefectReferencesDictionaryPlasticity1", typeof(Defect))]
        public XPCollection<Defect> X_Defects1 { get { return GetCollection<Defect>("X_Defects1"); } }
        [Association(@"X_DefectReferencesDictionaryPlasticity", typeof(Defect))]
        public XPCollection<Defect> X_Defects { get { return GetCollection<Defect>("X_Defects"); } }
    }

}
