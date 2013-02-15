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

    [Persistent(@"X_DictionarySurfaceRoughness")]
    public partial class DictionarySurfaceRoughness : XPLiteObject
    {
        Guid fSurfaceRoughnessID;
        [Key(true)]
        public Guid SurfaceRoughnessID
        {
            get { return fSurfaceRoughnessID; }
            set { SetPropertyValue<Guid>("SurfaceRoughnessID", ref fSurfaceRoughnessID, value); }
        }
        string fStandardSurfaceRoughnessName;
        [Indexed(Name = @"IDictionarySurfaceRoughness", Unique = true)]
        [Size(16)]
        public string StandardSurfaceRoughnessName
        {
            get { return fStandardSurfaceRoughnessName; }
            set { SetPropertyValue<string>("StandardSurfaceRoughnessName", ref fStandardSurfaceRoughnessName, value); }
        }
        string fCoalSurfaceRoughnessName;
        [Size(16)]
        public string CoalSurfaceRoughnessName
        {
            get { return fCoalSurfaceRoughnessName; }
            set { SetPropertyValue<string>("CoalSurfaceRoughnessName", ref fCoalSurfaceRoughnessName, value); }
        }
        string fGoldSurfaceRoughnessName;
        [Size(16)]
        public string GoldSurfaceRoughnessName
        {
            get { return fGoldSurfaceRoughnessName; }
            set { SetPropertyValue<string>("GoldSurfaceRoughnessName", ref fGoldSurfaceRoughnessName, value); }
        }
        string fCustomSurfaceRoughnessName;
        [Size(16)]
        public string CustomSurfaceRoughnessName
        {
            get { return fCustomSurfaceRoughnessName; }
            set { SetPropertyValue<string>("CustomSurfaceRoughnessName", ref fCustomSurfaceRoughnessName, value); }
        }
        string fDescription;
        [Size(255)]
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>("Description", ref fDescription, value); }
        }
        [Association(@"DefectReferencesDictionarySurfaceRoughness", typeof(Defect))]
        public XPCollection<Defect> Defects { get { return GetCollection<Defect>("Defects"); } }
    }

}
