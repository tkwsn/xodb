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

    [Persistent(@"X_Project")]
    public partial class Project : XPLiteObject
    {
        Guid fProjectID;
        [Key(true)]
        public Guid ProjectID
        {
            get { return fProjectID; }
            set { SetPropertyValue<Guid>("ProjectID", ref fProjectID, value); }
        }
        Tenement fTenementID;
        [Association(@"ProjectReferencesTenement")]
        public Tenement TenementID
        {
            get { return fTenementID; }
            set { SetPropertyValue<Tenement>("TenementID", ref fTenementID, value); }
        }
        string fProjectName;
        [Size(16)]
        public string ProjectName
        {
            get { return fProjectName; }
            set { SetPropertyValue<string>("ProjectName", ref fProjectName, value); }
        }
        string fProjectCode;
        [Size(16)]
        public string ProjectCode
        {
            get { return fProjectCode; }
            set { SetPropertyValue<string>("ProjectCode", ref fProjectCode, value); }
        }
        Company fClientCompanyID;
        [Association(@"ProjectReferencesCompany")]
        public Company ClientCompanyID
        {
            get { return fClientCompanyID; }
            set { SetPropertyValue<Company>("ClientCompanyID", ref fClientCompanyID, value); }
        }
        string fComment;
        [Size(SizeAttribute.Unlimited)]
        public string Comment
        {
            get { return fComment; }
            set { SetPropertyValue<string>("Comment", ref fComment, value); }
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
        [Association(@"BlockModelReferencesProject", typeof(BlockModel))]
        public XPCollection<BlockModel> BlockModels { get { return GetCollection<BlockModel>("BlockModels"); } }
        [Association(@"DrillCompanyContractReferencesProject", typeof(DrillCompanyContract))]
        public XPCollection<DrillCompanyContract> DrillCompanyContracts { get { return GetCollection<DrillCompanyContract>("DrillCompanyContracts"); } }
        [Association(@"ExperienceReferencesProject", typeof(Experience))]
        public XPCollection<Experience> Experiences { get { return GetCollection<Experience>("Experiences"); } }
        [Association(@"HeaderReferencesProject", typeof(Header))]
        public XPCollection<Header> Headers { get { return GetCollection<Header>("Headers"); } }
        [Association(@"SecurityBlacklistReferencesProject", typeof(SecurityBlacklist))]
        public XPCollection<SecurityBlacklist> SecurityBlacklists { get { return GetCollection<SecurityBlacklist>("SecurityBlacklists"); } }
        [Association(@"SecurityBlacklistReferencesProject1", typeof(SecurityBlacklist))]
        public XPCollection<SecurityBlacklist> SecurityBlacklists1 { get { return GetCollection<SecurityBlacklist>("SecurityBlacklists1"); } }
        [Association(@"SecurityWhitelistReferencesProject", typeof(SecurityWhitelist))]
        public XPCollection<SecurityWhitelist> SecurityWhitelists { get { return GetCollection<SecurityWhitelist>("SecurityWhitelists"); } }
        [Association(@"SecurityWhitelistReferencesProject1", typeof(SecurityWhitelist))]
        public XPCollection<SecurityWhitelist> SecurityWhitelists1 { get { return GetCollection<SecurityWhitelist>("SecurityWhitelists1"); } }
        [Association(@"AssayGroupReferencesProject", typeof(AssayGroup))]
        public XPCollection<AssayGroup> AssayGroups { get { return GetCollection<AssayGroup>("AssayGroups"); } }
        [Association(@"ProjectPlanReferencesProject", typeof(ProjectPlan))]
        public XPCollection<ProjectPlan> ProjectPlans { get { return GetCollection<ProjectPlan>("ProjectPlans"); } }
        [Association(@"X_ContractReferencesProject", typeof(Contract))]
        public XPCollection<Contract> X_Contracts { get { return GetCollection<Contract>("X_Contracts"); } }
        [Association(@"X_ProjectDeliverableReferencesProject", typeof(ProjectDeliverable))]
        public XPCollection<ProjectDeliverable> X_ProjectDeliverables { get { return GetCollection<ProjectDeliverable>("X_ProjectDeliverables"); } }
        [Association(@"X_OpportunityReferencesProject", typeof(Opportunity))]
        public XPCollection<Opportunity> X_Opportunitys { get { return GetCollection<Opportunity>("X_Opportunitys"); } }
    }

}
