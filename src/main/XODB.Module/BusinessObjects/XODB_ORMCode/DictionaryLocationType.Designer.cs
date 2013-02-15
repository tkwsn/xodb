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

    [Persistent(@"X_DictionaryLocationType")]
    public partial class DictionaryLocationType : XPLiteObject
    {
        Guid fLocationTypeID;
        [Key(true)]
        public Guid LocationTypeID
        {
            get { return fLocationTypeID; }
            set { SetPropertyValue<Guid>("LocationTypeID", ref fLocationTypeID, value); }
        }
        string fStandardLocationTypeName;
        [Indexed(Name = @"IDictionaryLocationType", Unique = true)]
        [Size(16)]
        public string StandardLocationTypeName
        {
            get { return fStandardLocationTypeName; }
            set { SetPropertyValue<string>("StandardLocationTypeName", ref fStandardLocationTypeName, value); }
        }
        string fCoalLocationTypeName;
        [Size(16)]
        public string CoalLocationTypeName
        {
            get { return fCoalLocationTypeName; }
            set { SetPropertyValue<string>("CoalLocationTypeName", ref fCoalLocationTypeName, value); }
        }
        string fGoldLocationTypeName;
        [Size(16)]
        public string GoldLocationTypeName
        {
            get { return fGoldLocationTypeName; }
            set { SetPropertyValue<string>("GoldLocationTypeName", ref fGoldLocationTypeName, value); }
        }
        string fCustomLocationTypeName;
        [Size(16)]
        public string CustomLocationTypeName
        {
            get { return fCustomLocationTypeName; }
            set { SetPropertyValue<string>("CustomLocationTypeName", ref fCustomLocationTypeName, value); }
        }
        string fDescription;
        [Size(255)]
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>("Description", ref fDescription, value); }
        }
        [Association(@"LocationReferencesDictionaryLocationType", typeof(Location))]
        public XPCollection<Location> Locations { get { return GetCollection<Location>("Locations"); } }
    }

}
