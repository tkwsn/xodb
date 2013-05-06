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

    [Persistent(@"X_DictionaryFlowTestType")]
    public partial class DictionaryFlowTestType : XPLiteObject
    {
        Guid fFlowTestTypeID;
        [Key(true)]
        public Guid FlowTestTypeID
        {
            get { return fFlowTestTypeID; }
            set { SetPropertyValue<Guid>("FlowTestTypeID", ref fFlowTestTypeID, value); }
        }
        string fStandardFlowTestTypeName;
        [Indexed(Name = @"IDictionaryFlowTestType", Unique = true)]
        [Size(16)]
        public string StandardFlowTestTypeName
        {
            get { return fStandardFlowTestTypeName; }
            set { SetPropertyValue<string>("StandardFlowTestTypeName", ref fStandardFlowTestTypeName, value); }
        }
        string fCoalFlowTestTypeName;
        [Size(16)]
        public string CoalFlowTestTypeName
        {
            get { return fCoalFlowTestTypeName; }
            set { SetPropertyValue<string>("CoalFlowTestTypeName", ref fCoalFlowTestTypeName, value); }
        }
        string fGoldFlowTestTypeName;
        [Size(16)]
        public string GoldFlowTestTypeName
        {
            get { return fGoldFlowTestTypeName; }
            set { SetPropertyValue<string>("GoldFlowTestTypeName", ref fGoldFlowTestTypeName, value); }
        }
        string fCustomFlowTestTypeName;
        [Size(16)]
        public string CustomFlowTestTypeName
        {
            get { return fCustomFlowTestTypeName; }
            set { SetPropertyValue<string>("CustomFlowTestTypeName", ref fCustomFlowTestTypeName, value); }
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
        [Association(@"DictionaryFlowTestTypeReferencesFileData")]
        public FileData OriginalFileDataID
        {
            get { return fOriginalFileDataID; }
            set { SetPropertyValue<FileData>("OriginalFileDataID", ref fOriginalFileDataID, value); }
        }
        [Association(@"WaterFlowReferencesDictionaryFlowTestType", typeof(WaterFlow))]
        public XPCollection<WaterFlow> WaterFlows { get { return GetCollection<WaterFlow>("WaterFlows"); } }
    }

}
