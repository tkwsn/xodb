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

    [Persistent(@"X_DictionaryUnit")]
    public partial class DictionaryUnit : XPLiteObject
    {
        Guid fUnitID;
        [Key(true)]
        public Guid UnitID
        {
            get { return fUnitID; }
            set { SetPropertyValue<Guid>("UnitID", ref fUnitID, value); }
        }
        string fStandardUnitName;
        [Indexed(Name = @"IDictionaryUnit", Unique = true)]
        [Size(16)]
        public string StandardUnitName
        {
            get { return fStandardUnitName; }
            set { SetPropertyValue<string>("StandardUnitName", ref fStandardUnitName, value); }
        }
        string fCoalUnitName;
        [Size(16)]
        public string CoalUnitName
        {
            get { return fCoalUnitName; }
            set { SetPropertyValue<string>("CoalUnitName", ref fCoalUnitName, value); }
        }
        string fGoldUnitName;
        [Size(16)]
        public string GoldUnitName
        {
            get { return fGoldUnitName; }
            set { SetPropertyValue<string>("GoldUnitName", ref fGoldUnitName, value); }
        }
        string fCustomUnitName;
        [Size(16)]
        public string CustomUnitName
        {
            get { return fCustomUnitName; }
            set { SetPropertyValue<string>("CustomUnitName", ref fCustomUnitName, value); }
        }
        string fDescription;
        [Size(255)]
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>("Description", ref fDescription, value); }
        }
        bool fStrictlySI;
        public bool StrictlySI
        {
            get { return fStrictlySI; }
            set { SetPropertyValue<bool>("StrictlySI", ref fStrictlySI, value); }
        }
        Guid fEquivalentUnit;
        public Guid EquivalentUnit
        {
            get { return fEquivalentUnit; }
            set { SetPropertyValue<Guid>("EquivalentUnit", ref fEquivalentUnit, value); }
        }
        decimal fEquivalentMultiplier;
        public decimal EquivalentMultiplier
        {
            get { return fEquivalentMultiplier; }
            set { SetPropertyValue<decimal>("EquivalentMultiplier", ref fEquivalentMultiplier, value); }
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
        [Association(@"DictionaryUnitReferencesFileData")]
        public FileData OriginalFileDataID
        {
            get { return fOriginalFileDataID; }
            set { SetPropertyValue<FileData>("OriginalFileDataID", ref fOriginalFileDataID, value); }
        }
        [Association(@"ParameterReferencesDictionaryUnit", typeof(Parameter))]
        public XPCollection<Parameter> Parameters { get { return GetCollection<Parameter>("Parameters"); } }
        [Association(@"ProjectDeliverableReferencesDictionaryUnit", typeof(ProjectDeliverable))]
        public XPCollection<ProjectDeliverable> ProjectDeliverables { get { return GetCollection<ProjectDeliverable>("ProjectDeliverables"); } }
    }

}
