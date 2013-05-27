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

    [Persistent(@"X_ProjectPlanTaskResponse")]
    public partial class ProjectPlanTaskResponse : XPLiteObject
    {
        Guid fProjectPlanTaskResponseID;
        [Key(true)]
        public Guid ProjectPlanTaskResponseID
        {
            get { return fProjectPlanTaskResponseID; }
            set { SetPropertyValue<Guid>("ProjectPlanTaskResponseID", ref fProjectPlanTaskResponseID, value); }
        }
        ProjectPlanTask fProjectPlanTaskID;
        [Association(@"ProjectPlanTaskResponseReferencesX_ProjectPlanTask")]
        public ProjectPlanTask ProjectPlanTaskID
        {
            get { return fProjectPlanTaskID; }
            set { SetPropertyValue<ProjectPlanTask>("ProjectPlanTaskID", ref fProjectPlanTaskID, value); }
        }
        Contact fResponsibleContactID;
        [Association(@"ProjectPlanTaskResponseReferencesContact")]
        public Contact ResponsibleContactID
        {
            get { return fResponsibleContactID; }
            set { SetPropertyValue<Contact>("ResponsibleContactID", ref fResponsibleContactID, value); }
        }
        DateTime fCompleted;
        public DateTime Completed
        {
            get { return fCompleted; }
            set { SetPropertyValue<DateTime>("Completed", ref fCompleted, value); }
        }
        string fComments;
        [Size(255)]
        public string Comments
        {
            get { return fComments; }
            set { SetPropertyValue<string>("Comments", ref fComments, value); }
        }
        DictionaryWorkType fActualWorkTypeID;
        [Association(@"ProjectPlanTaskResponseReferencesX_DictionaryWorkType")]
        public DictionaryWorkType ActualWorkTypeID
        {
            get { return fActualWorkTypeID; }
            set { SetPropertyValue<DictionaryWorkType>("ActualWorkTypeID", ref fActualWorkTypeID, value); }
        }
        DateTime fBegan;
        public DateTime Began
        {
            get { return fBegan; }
            set { SetPropertyValue<DateTime>("Began", ref fBegan, value); }
        }
        decimal fHours;
        public decimal Hours
        {
            get { return fHours; }
            set { SetPropertyValue<decimal>("Hours", ref fHours, value); }
        }
        decimal fEstimatedProRataUnits;
        public decimal EstimatedProRataUnits
        {
            get { return fEstimatedProRataUnits; }
            set { SetPropertyValue<decimal>("EstimatedProRataUnits", ref fEstimatedProRataUnits, value); }
        }
        decimal fEstimatedProRataCost;
        public decimal EstimatedProRataCost
        {
            get { return fEstimatedProRataCost; }
            set { SetPropertyValue<decimal>("EstimatedProRataCost", ref fEstimatedProRataCost, value); }
        }
        decimal fEstimatedValue;
        public decimal EstimatedValue
        {
            get { return fEstimatedValue; }
            set { SetPropertyValue<decimal>("EstimatedValue", ref fEstimatedValue, value); }
        }
        decimal fApprovedProRataUnits;
        public decimal ApprovedProRataUnits
        {
            get { return fApprovedProRataUnits; }
            set { SetPropertyValue<decimal>("ApprovedProRataUnits", ref fApprovedProRataUnits, value); }
        }
        decimal fApprovedProRataCost;
        public decimal ApprovedProRataCost
        {
            get { return fApprovedProRataCost; }
            set { SetPropertyValue<decimal>("ApprovedProRataCost", ref fApprovedProRataCost, value); }
        }
        DateTime fApproved;
        public DateTime Approved
        {
            get { return fApproved; }
            set { SetPropertyValue<DateTime>("Approved", ref fApproved, value); }
        }
        Contact fApprovedBy;
        [Association(@"ProjectPlanTaskResponseReferencesContact1")]
        public Contact ApprovedBy
        {
            get { return fApprovedBy; }
            set { SetPropertyValue<Contact>("ApprovedBy", ref fApprovedBy, value); }
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
        [Association(@"ProjectPlanTaskComplianceResponseReferencesProjectPlanTaskResponse", typeof(ProjectPlanTaskComplianceResponse))]
        public XPCollection<ProjectPlanTaskComplianceResponse> ProjectPlanTaskComplianceResponses { get { return GetCollection<ProjectPlanTaskComplianceResponse>("ProjectPlanTaskComplianceResponses"); } }
        [Association(@"SupplyItemReferencesProjectPlanTaskResponse", typeof(SupplyItem))]
        public XPCollection<SupplyItem> SupplyItems { get { return GetCollection<SupplyItem>("SupplyItems"); } }
    }

}
