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

    [Persistent(@"X_DictionaryDefectCompleteness")]
    public partial class DictionaryDefectCompleteness : XPLiteObject
    {
        Guid fDefectCompletenessID;
        [Key(true)]
        public Guid DefectCompletenessID
        {
            get { return fDefectCompletenessID; }
            set { SetPropertyValue<Guid>("DefectCompletenessID", ref fDefectCompletenessID, value); }
        }
        string fStandardDefectCompletenessName;
        [Indexed(Name = @"IDictionaryDefectCompleteness", Unique = true)]
        [Size(16)]
        public string StandardDefectCompletenessName
        {
            get { return fStandardDefectCompletenessName; }
            set { SetPropertyValue<string>("StandardDefectCompletenessName", ref fStandardDefectCompletenessName, value); }
        }
        string fCoalDefectCompletenessName;
        [Size(16)]
        public string CoalDefectCompletenessName
        {
            get { return fCoalDefectCompletenessName; }
            set { SetPropertyValue<string>("CoalDefectCompletenessName", ref fCoalDefectCompletenessName, value); }
        }
        string fGoldDefectCompletenessName;
        [Size(16)]
        public string GoldDefectCompletenessName
        {
            get { return fGoldDefectCompletenessName; }
            set { SetPropertyValue<string>("GoldDefectCompletenessName", ref fGoldDefectCompletenessName, value); }
        }
        string fCustomDefectCompletenessName;
        [Size(16)]
        public string CustomDefectCompletenessName
        {
            get { return fCustomDefectCompletenessName; }
            set { SetPropertyValue<string>("CustomDefectCompletenessName", ref fCustomDefectCompletenessName, value); }
        }
        string fDescription;
        [Size(255)]
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>("Description", ref fDescription, value); }
        }
        [Association(@"DefectReferencesDictionaryDefectCompleteness", typeof(Defect))]
        public XPCollection<Defect> Defects { get { return GetCollection<Defect>("Defects"); } }
        [Association(@"LithologyReferencesDictionaryDefectCompleteness", typeof(Lithology))]
        public XPCollection<Lithology> Lithologys { get { return GetCollection<Lithology>("Lithologys"); } }
    }

}
