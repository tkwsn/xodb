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
        DictionaryProfession fProfessionID;
        [Association(@"DictionaryWorkTypeReferencesDictionaryProfession")]
        public DictionaryProfession ProfessionID
        {
            get { return fProfessionID; }
            set { SetPropertyValue<DictionaryProfession>("ProfessionID", ref fProfessionID, value); }
        }
        Guid fWorkTypeClassID;
        public Guid WorkTypeClassID
        {
            get { return fWorkTypeClassID; }
            set { SetPropertyValue<Guid>("WorkTypeClassID", ref fWorkTypeClassID, value); }
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
        [Association(@"DictionaryWorkTypeReferencesFileData")]
        public FileData OriginalFileDataID
        {
            get { return fOriginalFileDataID; }
            set { SetPropertyValue<FileData>("OriginalFileDataID", ref fOriginalFileDataID, value); }
        }
        int fVersion;
        public int Version
        {
            get { return fVersion; }
            set { SetPropertyValue<int>("Version", ref fVersion, value); }
        }
        Guid fVersionAntecedentID;
        public Guid VersionAntecedentID
        {
            get { return fVersionAntecedentID; }
            set { SetPropertyValue<Guid>("VersionAntecedentID", ref fVersionAntecedentID, value); }
        }
        int fVersionCertainty;
        public int VersionCertainty
        {
            get { return fVersionCertainty; }
            set { SetPropertyValue<int>("VersionCertainty", ref fVersionCertainty, value); }
        }
        Guid fVersionWorkflowInstanceID;
        public Guid VersionWorkflowInstanceID
        {
            get { return fVersionWorkflowInstanceID; }
            set { SetPropertyValue<Guid>("VersionWorkflowInstanceID", ref fVersionWorkflowInstanceID, value); }
        }
        Guid fVersionUpdatedBy;
        public Guid VersionUpdatedBy
        {
            get { return fVersionUpdatedBy; }
            set { SetPropertyValue<Guid>("VersionUpdatedBy", ref fVersionUpdatedBy, value); }
        }
        Guid fVersionDeletedBy;
        public Guid VersionDeletedBy
        {
            get { return fVersionDeletedBy; }
            set { SetPropertyValue<Guid>("VersionDeletedBy", ref fVersionDeletedBy, value); }
        }
        Guid fVersionOwnerContactID;
        public Guid VersionOwnerContactID
        {
            get { return fVersionOwnerContactID; }
            set { SetPropertyValue<Guid>("VersionOwnerContactID", ref fVersionOwnerContactID, value); }
        }
        Guid fVersionOwnerCompanyID;
        public Guid VersionOwnerCompanyID
        {
            get { return fVersionOwnerCompanyID; }
            set { SetPropertyValue<Guid>("VersionOwnerCompanyID", ref fVersionOwnerCompanyID, value); }
        }
        DateTime fVersionUpdated;
        public DateTime VersionUpdated
        {
            get { return fVersionUpdated; }
            set { SetPropertyValue<DateTime>("VersionUpdated", ref fVersionUpdated, value); }
        }
        [Association(@"DictionaryWorkTypeRelationReferencesX_DictionaryWorkType", typeof(DictionaryWorkTypeRelation))]
        public XPCollection<DictionaryWorkTypeRelation> DictionaryWorkTypeRelations { get { return GetCollection<DictionaryWorkTypeRelation>("DictionaryWorkTypeRelations"); } }
        [Association(@"DictionaryWorkTypeRelationReferencesX_DictionaryWorkType1", typeof(DictionaryWorkTypeRelation))]
        public XPCollection<DictionaryWorkTypeRelation> DictionaryWorkTypeRelations1 { get { return GetCollection<DictionaryWorkTypeRelation>("DictionaryWorkTypeRelations1"); } }
        [Association(@"ExperienceReferencesX_DictionaryWorkType", typeof(Experience))]
        public XPCollection<Experience> Experiences { get { return GetCollection<Experience>("Experiences"); } }
        [Association(@"ProjectPlanTaskResponseReferencesX_DictionaryWorkType", typeof(ProjectPlanTaskResponse))]
        public XPCollection<ProjectPlanTaskResponse> ProjectPlanTaskResponses { get { return GetCollection<ProjectPlanTaskResponse>("ProjectPlanTaskResponses"); } }
        [Association(@"ComplianceWorkTypeReferencesX_DictionaryWorkType", typeof(ComplianceWorkType))]
        public XPCollection<ComplianceWorkType> ComplianceWorkTypes { get { return GetCollection<ComplianceWorkType>("ComplianceWorkTypes"); } }
        [Association(@"OpportunityReferencesX_DictionaryWorkType", typeof(Opportunity))]
        public XPCollection<Opportunity> Opportunities { get { return GetCollection<Opportunity>("Opportunities"); } }
        [Association(@"OpportunityReferencesX_DictionaryWorkType1", typeof(Opportunity))]
        public XPCollection<Opportunity> Opportunities1 { get { return GetCollection<Opportunity>("Opportunities1"); } }
        [Association(@"ProjectDeliverableReferencesX_DictionaryWorkType", typeof(ProjectDeliverable))]
        public XPCollection<ProjectDeliverable> ProjectDeliverables { get { return GetCollection<ProjectDeliverable>("ProjectDeliverables"); } }
        [Association(@"ProjectPlanTaskReferencesX_DictionaryWorkType", typeof(ProjectPlanTask))]
        public XPCollection<ProjectPlanTask> ProjectPlanTasks { get { return GetCollection<ProjectPlanTask>("ProjectPlanTasks"); } }
    }

}
