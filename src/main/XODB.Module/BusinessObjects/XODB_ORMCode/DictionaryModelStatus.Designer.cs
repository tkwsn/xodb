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

    [Persistent(@"X_DictionaryModelStatus")]
    public partial class DictionaryModelStatus : XPLiteObject
    {
        Guid fModelStatusID;
        [Key(true)]
        public Guid ModelStatusID
        {
            get { return fModelStatusID; }
            set { SetPropertyValue<Guid>("ModelStatusID", ref fModelStatusID, value); }
        }
        string fStandardModelStatusName;
        [Size(16)]
        public string StandardModelStatusName
        {
            get { return fStandardModelStatusName; }
            set { SetPropertyValue<string>("StandardModelStatusName", ref fStandardModelStatusName, value); }
        }
        string fCustomModelStatusName;
        [Size(16)]
        public string CustomModelStatusName
        {
            get { return fCustomModelStatusName; }
            set { SetPropertyValue<string>("CustomModelStatusName", ref fCustomModelStatusName, value); }
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
        [Association(@"X_DictionaryModelStatusReferencesFileData")]
        public FileData OriginalFileDataID
        {
            get { return fOriginalFileDataID; }
            set { SetPropertyValue<FileData>("OriginalFileDataID", ref fOriginalFileDataID, value); }
        }
        [Association(@"X_DictionaryModelReferencesX_DictionaryModelStatus", typeof(DictionaryModel))]
        public XPCollection<DictionaryModel> X_DictionaryModels { get { return GetCollection<DictionaryModel>("X_DictionaryModels"); } }
    }

}
