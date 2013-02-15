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

    [Persistent(@"X_DictionaryWorkType")]
    public partial class DictionaryWorkType : XPLiteObject
    {
        Guid fWorkTypeID;
        [Key(true)]
        public Guid WorkTypeID
        {
            get { return fWorkTypeID; }
            set { SetPropertyValue<Guid>("WorkTypeID", ref fWorkTypeID, value); }
        }
        Company fCompanyID;
        [Association(@"DictionaryWorkTypeReferencesCompany")]
        public Company CompanyID
        {
            get { return fCompanyID; }
            set { SetPropertyValue<Company>("CompanyID", ref fCompanyID, value); }
        }
        DictionaryProfession fProfessionID;
        [Association(@"DictionaryWorkTypeReferencesDictionaryProfession")]
        public DictionaryProfession ProfessionID
        {
            get { return fProfessionID; }
            set { SetPropertyValue<DictionaryProfession>("ProfessionID", ref fProfessionID, value); }
        }
        string fWorkTypeClass;
        [Size(50)]
        public string WorkTypeClass
        {
            get { return fWorkTypeClass; }
            set { SetPropertyValue<string>("WorkTypeClass", ref fWorkTypeClass, value); }
        }
        string fWorkTypeName;
        [Size(50)]
        public string WorkTypeName
        {
            get { return fWorkTypeName; }
            set { SetPropertyValue<string>("WorkTypeName", ref fWorkTypeName, value); }
        }
        string fWorkTypeDescription;
        [Size(255)]
        public string WorkTypeDescription
        {
            get { return fWorkTypeDescription; }
            set { SetPropertyValue<string>("WorkTypeDescription", ref fWorkTypeDescription, value); }
        }
        [Association(@"DictionaryWorkTypeRelationReferencesDictionaryWorkType", typeof(DictionaryWorkTypeRelation))]
        public XPCollection<DictionaryWorkTypeRelation> DictionaryWorkTypeRelations { get { return GetCollection<DictionaryWorkTypeRelation>("DictionaryWorkTypeRelations"); } }
        [Association(@"DictionaryWorkTypeRelationReferencesDictionaryWorkType1", typeof(DictionaryWorkTypeRelation))]
        public XPCollection<DictionaryWorkTypeRelation> DictionaryWorkTypeRelations1 { get { return GetCollection<DictionaryWorkTypeRelation>("DictionaryWorkTypeRelations1"); } }
        [Association(@"ExperienceReferencesDictionaryWorkType", typeof(Experience))]
        public XPCollection<Experience> Experiences { get { return GetCollection<Experience>("Experiences"); } }
    }

}
