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

    [Persistent(@"X_DictionaryGasDetected")]
    public partial class DictionaryGasDetected : XPLiteObject
    {
        Guid fGasDetectedID;
        [Key(true)]
        public Guid GasDetectedID
        {
            get { return fGasDetectedID; }
            set { SetPropertyValue<Guid>("GasDetectedID", ref fGasDetectedID, value); }
        }
        string fStandardGasDetectedName;
        [Indexed(Name = @"IDictionaryGasDetected", Unique = true)]
        [Size(16)]
        public string StandardGasDetectedName
        {
            get { return fStandardGasDetectedName; }
            set { SetPropertyValue<string>("StandardGasDetectedName", ref fStandardGasDetectedName, value); }
        }
        string fCoalGasDetectedName;
        [Size(16)]
        public string CoalGasDetectedName
        {
            get { return fCoalGasDetectedName; }
            set { SetPropertyValue<string>("CoalGasDetectedName", ref fCoalGasDetectedName, value); }
        }
        string fGoldGasDetectedName;
        [Size(16)]
        public string GoldGasDetectedName
        {
            get { return fGoldGasDetectedName; }
            set { SetPropertyValue<string>("GoldGasDetectedName", ref fGoldGasDetectedName, value); }
        }
        string fCustomGasDetectedName;
        [Size(16)]
        public string CustomGasDetectedName
        {
            get { return fCustomGasDetectedName; }
            set { SetPropertyValue<string>("CustomGasDetectedName", ref fCustomGasDetectedName, value); }
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
        [Association(@"DictionaryGasDetectedReferencesFileData")]
        public FileData OriginalFileDataID
        {
            get { return fOriginalFileDataID; }
            set { SetPropertyValue<FileData>("OriginalFileDataID", ref fOriginalFileDataID, value); }
        }
        [Association(@"LithologyReferencesDictionaryGasDetected", typeof(Lithology))]
        public XPCollection<Lithology> Lithologies { get { return GetCollection<Lithology>("Lithologies"); } }
    }

}
