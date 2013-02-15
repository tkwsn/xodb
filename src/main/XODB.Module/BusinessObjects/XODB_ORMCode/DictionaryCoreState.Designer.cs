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

    [Persistent(@"X_DictionaryCoreState")]
    public partial class DictionaryCoreState : XPLiteObject
    {
        Guid fCoreStateID;
        [Key(true)]
        public Guid CoreStateID
        {
            get { return fCoreStateID; }
            set { SetPropertyValue<Guid>("CoreStateID", ref fCoreStateID, value); }
        }
        string fStandardCoreStateName;
        [Indexed(Name = @"IDictionaryCoreState", Unique = true)]
        [Size(16)]
        public string StandardCoreStateName
        {
            get { return fStandardCoreStateName; }
            set { SetPropertyValue<string>("StandardCoreStateName", ref fStandardCoreStateName, value); }
        }
        string fCoalCoreStateName;
        [Size(16)]
        public string CoalCoreStateName
        {
            get { return fCoalCoreStateName; }
            set { SetPropertyValue<string>("CoalCoreStateName", ref fCoalCoreStateName, value); }
        }
        string fGoldCoreStateName;
        [Size(16)]
        public string GoldCoreStateName
        {
            get { return fGoldCoreStateName; }
            set { SetPropertyValue<string>("GoldCoreStateName", ref fGoldCoreStateName, value); }
        }
        string fCustomCoreStateName;
        [Size(16)]
        public string CustomCoreStateName
        {
            get { return fCustomCoreStateName; }
            set { SetPropertyValue<string>("CustomCoreStateName", ref fCustomCoreStateName, value); }
        }
        string fDescription;
        [Size(255)]
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>("Description", ref fDescription, value); }
        }
        [Association(@"LithologyReferencesDictionaryCoreState", typeof(Lithology))]
        public XPCollection<Lithology> Lithologys { get { return GetCollection<Lithology>("Lithologys"); } }
    }

}
