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

    [Persistent(@"X_DictionaryMineralStyle")]
    public partial class DictionaryMineralStyle : XPLiteObject
    {
        Guid fMineralStyleID;
        [Key(true)]
        public Guid MineralStyleID
        {
            get { return fMineralStyleID; }
            set { SetPropertyValue<Guid>("MineralStyleID", ref fMineralStyleID, value); }
        }
        string fStandardMineralStyleName;
        [Indexed(Name = @"IDictionaryMineralStyle", Unique = true)]
        [Size(16)]
        public string StandardMineralStyleName
        {
            get { return fStandardMineralStyleName; }
            set { SetPropertyValue<string>("StandardMineralStyleName", ref fStandardMineralStyleName, value); }
        }
        string fCoalMineralStyleName;
        [Size(16)]
        public string CoalMineralStyleName
        {
            get { return fCoalMineralStyleName; }
            set { SetPropertyValue<string>("CoalMineralStyleName", ref fCoalMineralStyleName, value); }
        }
        string fGoldMineralStyleName;
        [Size(16)]
        public string GoldMineralStyleName
        {
            get { return fGoldMineralStyleName; }
            set { SetPropertyValue<string>("GoldMineralStyleName", ref fGoldMineralStyleName, value); }
        }
        string fCustomMineralStyleName;
        [Size(16)]
        public string CustomMineralStyleName
        {
            get { return fCustomMineralStyleName; }
            set { SetPropertyValue<string>("CustomMineralStyleName", ref fCustomMineralStyleName, value); }
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
        [Association(@"DictionaryMineralStyleReferencesFileData")]
        public FileData OriginalFileDataID
        {
            get { return fOriginalFileDataID; }
            set { SetPropertyValue<FileData>("OriginalFileDataID", ref fOriginalFileDataID, value); }
        }
        [Association(@"MineralogyReferencesDictionaryMineralStyle", typeof(Mineralogy))]
        public XPCollection<Mineralogy> Mineralogies { get { return GetCollection<Mineralogy>("Mineralogies"); } }
    }

}
