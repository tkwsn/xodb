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

    [Persistent(@"X_DictionaryIntervalStatus")]
    public partial class DictionaryIntervalStatus : XPLiteObject
    {
        Guid fIntervalStatusID;
        [Key(true)]
        public Guid IntervalStatusID
        {
            get { return fIntervalStatusID; }
            set { SetPropertyValue<Guid>("IntervalStatusID", ref fIntervalStatusID, value); }
        }
        string fStandardIntervalStatusName;
        [Indexed(Name = @"IDictionaryIntervalStatus", Unique = true)]
        [Size(16)]
        public string StandardIntervalStatusName
        {
            get { return fStandardIntervalStatusName; }
            set { SetPropertyValue<string>("StandardIntervalStatusName", ref fStandardIntervalStatusName, value); }
        }
        string fCoalIntervalStatusName;
        [Size(16)]
        public string CoalIntervalStatusName
        {
            get { return fCoalIntervalStatusName; }
            set { SetPropertyValue<string>("CoalIntervalStatusName", ref fCoalIntervalStatusName, value); }
        }
        string fGoldIntervalStatusName;
        [Size(16)]
        public string GoldIntervalStatusName
        {
            get { return fGoldIntervalStatusName; }
            set { SetPropertyValue<string>("GoldIntervalStatusName", ref fGoldIntervalStatusName, value); }
        }
        string fCustomIntervalStatusName;
        [Size(16)]
        public string CustomIntervalStatusName
        {
            get { return fCustomIntervalStatusName; }
            set { SetPropertyValue<string>("CustomIntervalStatusName", ref fCustomIntervalStatusName, value); }
        }
        string fDescription;
        [Size(255)]
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>("Description", ref fDescription, value); }
        }
        [Association(@"LithologyReferencesDictionaryIntervalStatus", typeof(Lithology))]
        public XPCollection<Lithology> Lithologys { get { return GetCollection<Lithology>("Lithologys"); } }
    }

}
