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

    [Persistent(@"X_DictionaryCharacteristicType")]
    public partial class DictionaryCharacteristicType : XPLiteObject
    {
        Guid fCharacteristicTypeID;
        [Key(true)]
        public Guid CharacteristicTypeID
        {
            get { return fCharacteristicTypeID; }
            set { SetPropertyValue<Guid>("CharacteristicTypeID", ref fCharacteristicTypeID, value); }
        }
        string fStandardCharacteristicTypeName;
        [Size(16)]
        public string StandardCharacteristicTypeName
        {
            get { return fStandardCharacteristicTypeName; }
            set { SetPropertyValue<string>("StandardCharacteristicTypeName", ref fStandardCharacteristicTypeName, value); }
        }
        string fCustomCharacteristicTypeName;
        [Size(16)]
        public string CustomCharacteristicTypeName
        {
            get { return fCustomCharacteristicTypeName; }
            set { SetPropertyValue<string>("CustomCharacteristicTypeName", ref fCustomCharacteristicTypeName, value); }
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
        [Association(@"DictionaryCharacteristicTypeReferencesFileData")]
        public FileData OriginalFileDataID
        {
            get { return fOriginalFileDataID; }
            set { SetPropertyValue<FileData>("OriginalFileDataID", ref fOriginalFileDataID, value); }
        }
        [Association(@"DictionaryCharacteristicReferencesX_DictionaryCharacteristicType", typeof(DictionaryCharacteristic))]
        public XPCollection<DictionaryCharacteristic> DictionaryCharacteristics { get { return GetCollection<DictionaryCharacteristic>("DictionaryCharacteristics"); } }
    }

}
