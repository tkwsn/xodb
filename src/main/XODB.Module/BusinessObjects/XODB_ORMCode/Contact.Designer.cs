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

    [Persistent(@"X_Contact")]
    public partial class Contact : XPLiteObject
    {
        Guid fContactID;
        [Key(true)]
        public Guid ContactID
        {
            get { return fContactID; }
            set { SetPropertyValue<Guid>("ContactID", ref fContactID, value); }
        }
        string fContactName;
        [Indexed(Name = @"IPerson", Unique = true)]
        [Size(120)]
        public string ContactName
        {
            get { return fContactName; }
            set { SetPropertyValue<string>("ContactName", ref fContactName, value); }
        }
        string fTitle;
        [Size(16)]
        public string Title
        {
            get { return fTitle; }
            set { SetPropertyValue<string>("Title", ref fTitle, value); }
        }
        string fSurname;
        [Size(60)]
        public string Surname
        {
            get { return fSurname; }
            set { SetPropertyValue<string>("Surname", ref fSurname, value); }
        }
        string fFirstname;
        [Size(60)]
        public string Firstname
        {
            get { return fFirstname; }
            set { SetPropertyValue<string>("Firstname", ref fFirstname, value); }
        }
        string fUsername;
        public string Username
        {
            get { return fUsername; }
            set { SetPropertyValue<string>("Username", ref fUsername, value); }
        }
        string fMiddleNames;
        [Size(60)]
        public string MiddleNames
        {
            get { return fMiddleNames; }
            set { SetPropertyValue<string>("MiddleNames", ref fMiddleNames, value); }
        }
        string fInitials;
        [Size(16)]
        public string Initials
        {
            get { return fInitials; }
            set { SetPropertyValue<string>("Initials", ref fInitials, value); }
        }
        DateTime fDOB;
        public DateTime DOB
        {
            get { return fDOB; }
            set { SetPropertyValue<DateTime>("DOB", ref fDOB, value); }
        }
        DictionaryCountry fBirthCountryID;
        [Size(2)]
        [Association(@"ContactReferencesDictionaryCountry")]
        public DictionaryCountry BirthCountryID
        {
            get { return fBirthCountryID; }
            set { SetPropertyValue<DictionaryCountry>("BirthCountryID", ref fBirthCountryID, value); }
        }
        string fBirthCity;
        [Size(60)]
        public string BirthCity
        {
            get { return fBirthCity; }
            set { SetPropertyValue<string>("BirthCity", ref fBirthCity, value); }
        }
        Guid fAspNetUserID;
        [Indexed(Name = @"iAspNetUserID_Contact")]
        public Guid AspNetUserID
        {
            get { return fAspNetUserID; }
            set { SetPropertyValue<Guid>("AspNetUserID", ref fAspNetUserID, value); }
        }
        Guid fXafUserID;
        [Indexed(Name = @"iXafUserID_Contact")]
        public Guid XafUserID
        {
            get { return fXafUserID; }
            set { SetPropertyValue<Guid>("XafUserID", ref fXafUserID, value); }
        }
        string fOAuthID;
        [Size(256)]
        public string OAuthID
        {
            get { return fOAuthID; }
            set { SetPropertyValue<string>("OAuthID", ref fOAuthID, value); }
        }
        byte[] fPhoto;
        [Size(SizeAttribute.Unlimited)]
        public byte[] Photo
        {
            get { return fPhoto; }
            set { SetPropertyValue<byte[]>("Photo", ref fPhoto, value); }
        }
        string fShortBiography;
        [Size(SizeAttribute.Unlimited)]
        public string ShortBiography
        {
            get { return fShortBiography; }
            set { SetPropertyValue<string>("ShortBiography", ref fShortBiography, value); }
        }
        string fHash;
        [Size(255)]
        public string Hash
        {
            get { return fHash; }
            set { SetPropertyValue<string>("Hash", ref fHash, value); }
        }
        string fDefaultEmail;
        [Size(255)]
        public string DefaultEmail
        {
            get { return fDefaultEmail; }
            set { SetPropertyValue<string>("DefaultEmail", ref fDefaultEmail, value); }
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
        [Association(@"AssayGroupReferencesContact", typeof(AssayGroup))]
        public XPCollection<AssayGroup> AssayGroups { get { return GetCollection<AssayGroup>("AssayGroups"); } }
        [Association(@"AssayGroupReferencesContact1", typeof(AssayGroup))]
        public XPCollection<AssayGroup> AssayGroupsReceivedBy { get { return GetCollection<AssayGroup>("AssayGroupsReceivedBy"); } }
        [Association(@"AssayGroupReferencesContact2", typeof(AssayGroup))]
        public XPCollection<AssayGroup> AssayGroupsEnteredBy { get { return GetCollection<AssayGroup>("AssayGroupsEnteredBy"); } }
        [Association(@"BlockModelReferencesContact", typeof(BlockModel))]
        public XPCollection<BlockModel> BlockModels { get { return GetCollection<BlockModel>("BlockModels"); } }
        [Association(@"BlockModelReferencesContact1", typeof(BlockModel))]
        public XPCollection<BlockModel> BlockModelsResponsibleParties { get { return GetCollection<BlockModel>("BlockModelsResponsibleParties"); } }
        [Association(@"BlockModelReferencesContact2", typeof(BlockModel))]
        public XPCollection<BlockModel> BlockModelsApprovers { get { return GetCollection<BlockModel>("BlockModelsApprovers"); } }
        [Association(@"BlockModelReferencesContact3", typeof(BlockModel))]
        public XPCollection<BlockModel> BlockModels3 { get { return GetCollection<BlockModel>("BlockModels3"); } }
        [Association(@"CompanyReferencesContact", typeof(Company))]
        public XPCollection<Company> Companies { get { return GetCollection<Company>("Companies"); } }
        [Association(@"ContactAddressReferencesContact", typeof(ContactAddress))]
        public XPCollection<ContactAddress> ContactAddressCollection { get { return GetCollection<ContactAddress>("ContactAddressCollection"); } }
        [Association(@"DrillingReferencesContact", typeof(Drilling))]
        public XPCollection<Drilling> Drillings { get { return GetCollection<Drilling>("Drillings"); } }
        [Association(@"ExperienceReferencesContact", typeof(Experience))]
        public XPCollection<Experience> Experiences { get { return GetCollection<Experience>("Experiences"); } }
        [Association(@"GeologyReferencesContact", typeof(Geology))]
        public XPCollection<Geology> Geologies { get { return GetCollection<Geology>("Geologies"); } }
        [Association(@"HeaderReferencesContact", typeof(Header))]
        public XPCollection<Header> Headers { get { return GetCollection<Header>("Headers"); } }
        [Association(@"LeaseReferencesContact", typeof(Lease))]
        public XPCollection<Lease> Leases { get { return GetCollection<Lease>("Leases"); } }
        [Association(@"LeaseApplicationReferencesContact", typeof(LeaseApplication))]
        public XPCollection<LeaseApplication> LeaseApplications { get { return GetCollection<LeaseApplication>("LeaseApplications"); } }
        [Association(@"ProjectPlanReferencesContact", typeof(ProjectPlan))]
        public XPCollection<ProjectPlan> ProjectPlans { get { return GetCollection<ProjectPlan>("ProjectPlans"); } }
        [Association(@"ProjectPlanTaskResponseReferencesContact", typeof(ProjectPlanTaskResponse))]
        public XPCollection<ProjectPlanTaskResponse> ProjectPlanTaskResponses { get { return GetCollection<ProjectPlanTaskResponse>("ProjectPlanTaskResponses"); } }
        [Association(@"ProvinceReferencesContact", typeof(Province))]
        public XPCollection<Province> Provinces { get { return GetCollection<Province>("Provinces"); } }
        [Association(@"SecurityBlacklistReferencesContact", typeof(SecurityBlacklist))]
        public XPCollection<SecurityBlacklist> SecurityBlacklists { get { return GetCollection<SecurityBlacklist>("SecurityBlacklists"); } }
        [Association(@"SecurityWhitelistReferencesContact", typeof(SecurityWhitelist))]
        public XPCollection<SecurityWhitelist> SecurityWhitelists { get { return GetCollection<SecurityWhitelist>("SecurityWhitelists"); } }
        [Association(@"ProjectPlanTaskResponseReferencesContact1", typeof(ProjectPlanTaskResponse))]
        public XPCollection<ProjectPlanTaskResponse> ProjectPlanTaskResponses1 { get { return GetCollection<ProjectPlanTaskResponse>("ProjectPlanTaskResponses1"); } }
        [Association(@"ComplianceReferencesContact", typeof(Compliance))]
        public XPCollection<Compliance> Compliances { get { return GetCollection<Compliance>("Compliances"); } }
        [Association(@"ProjectPlanTaskComplianceResponseReferencesContact", typeof(ProjectPlanTaskComplianceResponse))]
        public XPCollection<ProjectPlanTaskComplianceResponse> ProjectPlanTaskComplianceResponses { get { return GetCollection<ProjectPlanTaskComplianceResponse>("ProjectPlanTaskComplianceResponses"); } }
        [Association(@"ProjectPlanTaskComplianceResponseReferencesContact1", typeof(ProjectPlanTaskComplianceResponse))]
        public XPCollection<ProjectPlanTaskComplianceResponse> ProjectPlanTaskComplianceResponses1 { get { return GetCollection<ProjectPlanTaskComplianceResponse>("ProjectPlanTaskComplianceResponses1"); } }
        [Association(@"LocationHistoryReferencesContact", typeof(LocationHistory))]
        public XPCollection<LocationHistory> LocationHistories { get { return GetCollection<LocationHistory>("LocationHistories"); } }
        [Association(@"OpportunityReferencesContact", typeof(Opportunity))]
        public XPCollection<Opportunity> Opportunitys { get { return GetCollection<Opportunity>("Opportunitys"); } }
        [Association(@"OpportunityReferencesContact1", typeof(Opportunity))]
        public XPCollection<Opportunity> OpportunitiesOpenedBy { get { return GetCollection<Opportunity>("OpportunitiesOpenedBy"); } }
        [Association(@"OpportunityReferencesContact2", typeof(Opportunity))]
        public XPCollection<Opportunity> OpportunitiesAssignedBy { get { return GetCollection<Opportunity>("OpportunitiesAssignedBy"); } }
        [Association(@"OpportunityReferencesContact3", typeof(Opportunity))]
        public XPCollection<Opportunity> OpportunitiesMaintainedBy { get { return GetCollection<Opportunity>("OpportunitiesMaintainedBy"); } }
        [Association(@"OpportunityReferencesContact4", typeof(Opportunity))]
        public XPCollection<Opportunity> OpportunitiesConvertedBy { get { return GetCollection<Opportunity>("OpportunitiesConvertedBy"); } }
        [Association(@"OpportunityReferencesContact5", typeof(Opportunity))]
        public XPCollection<Opportunity> Opportunities { get { return GetCollection<Opportunity>("Opportunities"); } }
        [Association(@"ProjectDeliverableReferencesContact", typeof(ProjectDeliverable))]
        public XPCollection<ProjectDeliverable> ProjectDeliverables { get { return GetCollection<ProjectDeliverable>("ProjectDeliverables"); } }
        [Association(@"ProjectDeliverableReferencesContact1", typeof(ProjectDeliverable))]
        public XPCollection<ProjectDeliverable> ProjectDeliverables1 { get { return GetCollection<ProjectDeliverable>("ProjectDeliverables1"); } }
        [Association(@"ProjectDeliverableReferencesContact2", typeof(ProjectDeliverable))]
        public XPCollection<ProjectDeliverable> ProjectDeliverables2 { get { return GetCollection<ProjectDeliverable>("ProjectDeliverables2"); } }
        [Association(@"ContractReferencesContact", typeof(Contract))]
        public XPCollection<Contract> Contracts { get { return GetCollection<Contract>("Contracts"); } }
        [Association(@"ContractReferencesContact1", typeof(Contract))]
        public XPCollection<Contract> Contracts1 { get { return GetCollection<Contract>("Contracts1"); } }
        [Association(@"ContractReferencesContact2", typeof(Contract))]
        public XPCollection<Contract> Contracts2 { get { return GetCollection<Contract>("Contracts2"); } }
        [Association(@"ContractReferencesContact3", typeof(Contract))]
        public XPCollection<Contract> Contracts3 { get { return GetCollection<Contract>("Contracts3"); } }
        [Association(@"SurveyReferencesContact", typeof(Survey))]
        public XPCollection<Survey> Surveys { get { return GetCollection<Survey>("Surveys"); } }
        [Association(@"LocationReferencesContact", typeof(Location))]
        public XPCollection<Location> Locations { get { return GetCollection<Location>("Locations"); } }
        [Association(@"TenementReferencesContact", typeof(Tenement))]
        public XPCollection<Tenement> Tenements { get { return GetCollection<Tenement>("Tenements"); } }
        [Association(@"RecallReferencesContact", typeof(Recall))]
        public XPCollection<Recall> Recalls { get { return GetCollection<Recall>("Recalls"); } }
        [Association(@"RecallReferencesContact1", typeof(Recall))]
        public XPCollection<Recall> Recalls1 { get { return GetCollection<Recall>("Recalls1"); } }
        [Association(@"RecallReferencesContact2", typeof(Recall))]
        public XPCollection<Recall> Recalls2 { get { return GetCollection<Recall>("Recalls2"); } }
        [Association(@"RecallReferencesContact3", typeof(Recall))]
        public XPCollection<Recall> Recalls3 { get { return GetCollection<Recall>("Recalls3"); } }
        [Association(@"PurchaseOrderReferencesContact", typeof(PurchaseOrder))]
        public XPCollection<PurchaseOrder> PurchaseOrders { get { return GetCollection<PurchaseOrder>("PurchaseOrders"); } }
        [Association(@"PurchaseOrderReferencesContact1", typeof(PurchaseOrder))]
        public XPCollection<PurchaseOrder> PurchaseOrders1 { get { return GetCollection<PurchaseOrder>("PurchaseOrders1"); } }
        [Association(@"SupplyReferencesContact", typeof(Supply))]
        public XPCollection<Supply> Supplies { get { return GetCollection<Supply>("Supplies"); } }
        [Association(@"SupplyReferencesContact1", typeof(Supply))]
        public XPCollection<Supply> Supplies1 { get { return GetCollection<Supply>("Supplies1"); } }
    }

}
