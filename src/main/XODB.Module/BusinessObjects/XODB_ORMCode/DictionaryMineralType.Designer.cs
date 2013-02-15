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

    [Persistent(@"X_DictionaryMineralType")]
    public partial class DictionaryMineralType : XPLiteObject
    {
        Guid fMineralTypeID;
        [Key(true)]
        public Guid MineralTypeID
        {
            get { return fMineralTypeID; }
            set { SetPropertyValue<Guid>("MineralTypeID", ref fMineralTypeID, value); }
        }
        string fStandardMineralTypeName;
        [Indexed(Name = @"IDictionaryMineralType", Unique = true)]
        [Size(16)]
        public string StandardMineralTypeName
        {
            get { return fStandardMineralTypeName; }
            set { SetPropertyValue<string>("StandardMineralTypeName", ref fStandardMineralTypeName, value); }
        }
        string fCoalMineralTypeName;
        [Size(16)]
        public string CoalMineralTypeName
        {
            get { return fCoalMineralTypeName; }
            set { SetPropertyValue<string>("CoalMineralTypeName", ref fCoalMineralTypeName, value); }
        }
        string fGoldMineralTypeName;
        [Size(16)]
        public string GoldMineralTypeName
        {
            get { return fGoldMineralTypeName; }
            set { SetPropertyValue<string>("GoldMineralTypeName", ref fGoldMineralTypeName, value); }
        }
        string fCustomMineralTypeName;
        [Size(16)]
        public string CustomMineralTypeName
        {
            get { return fCustomMineralTypeName; }
            set { SetPropertyValue<string>("CustomMineralTypeName", ref fCustomMineralTypeName, value); }
        }
        string fDescription;
        [Size(255)]
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>("Description", ref fDescription, value); }
        }
        [Association(@"MineralogyReferencesDictionaryMineralType", typeof(Mineralogy))]
        public XPCollection<Mineralogy> Mineralogys { get { return GetCollection<Mineralogy>("Mineralogys"); } }
    }

}
