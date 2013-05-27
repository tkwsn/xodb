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

    [Persistent(@"Q_DeliveryAdvice")]
    public partial class DeliveryAdvice : XPLiteObject
    {
        Guid fDeliveryAdviceID;
        [Key(true)]
        public Guid DeliveryAdviceID
        {
            get { return fDeliveryAdviceID; }
            set { SetPropertyValue<Guid>("DeliveryAdviceID", ref fDeliveryAdviceID, value); }
        }
        string fDeliveryAdviceName;
        [Indexed(Name = @"UQ__DELIVERY__8F63B2CF5A846E65", Unique = true)]
        [Size(60)]
        public string DeliveryAdviceName
        {
            get { return fDeliveryAdviceName; }
            set { SetPropertyValue<string>("DeliveryAdviceName", ref fDeliveryAdviceName, value); }
        }
        int fSequence;
        public int Sequence
        {
            get { return fSequence; }
            set { SetPropertyValue<int>("Sequence", ref fSequence, value); }
        }
        Company fShippingCompanyID;
        [Association(@"DeliveryAdviceReferencesCompany")]
        public Company ShippingCompanyID
        {
            get { return fShippingCompanyID; }
            set { SetPropertyValue<Company>("ShippingCompanyID", ref fShippingCompanyID, value); }
        }
        decimal fFreightCharge;
        public decimal FreightCharge
        {
            get { return fFreightCharge; }
            set { SetPropertyValue<decimal>("FreightCharge", ref fFreightCharge, value); }
        }
        decimal fFreightTax;
        public decimal FreightTax
        {
            get { return fFreightTax; }
            set { SetPropertyValue<decimal>("FreightTax", ref fFreightTax, value); }
        }
        string fConsignmentNote;
        public string ConsignmentNote
        {
            get { return fConsignmentNote; }
            set { SetPropertyValue<string>("ConsignmentNote", ref fConsignmentNote, value); }
        }
        string fAccessoriesSent;
        [Size(500)]
        public string AccessoriesSent
        {
            get { return fAccessoriesSent; }
            set { SetPropertyValue<string>("AccessoriesSent", ref fAccessoriesSent, value); }
        }
        string fDeliveryAdviceNotes;
        [Size(500)]
        public string DeliveryAdviceNotes
        {
            get { return fDeliveryAdviceNotes; }
            set { SetPropertyValue<string>("DeliveryAdviceNotes", ref fDeliveryAdviceNotes, value); }
        }
        bool fIsEditable;
        public bool IsEditable
        {
            get { return fIsEditable; }
            set { SetPropertyValue<bool>("IsEditable", ref fIsEditable, value); }
        }
        CompanyAddress fSourceCompanyAddressID;
        [Association(@"DeliveryAdviceReferencesCompanyAddress")]
        public CompanyAddress SourceCompanyAddressID
        {
            get { return fSourceCompanyAddressID; }
            set { SetPropertyValue<CompanyAddress>("SourceCompanyAddressID", ref fSourceCompanyAddressID, value); }
        }
        CompanyAddress fDestinationCompanyAddressID;
        [Association(@"DeliveryAdviceReferencesCompanyAddress1")]
        public CompanyAddress DestinationCompanyAddressID
        {
            get { return fDestinationCompanyAddressID; }
            set { SetPropertyValue<CompanyAddress>("DestinationCompanyAddressID", ref fDestinationCompanyAddressID, value); }
        }
        DictionaryDeliveryAdviceReason fDeliveryAdviceReasonID;
        [Association(@"DeliveryAdviceReferencesQ_DictionaryDeliveryAdviceReason")]
        public DictionaryDeliveryAdviceReason DeliveryAdviceReasonID
        {
            get { return fDeliveryAdviceReasonID; }
            set { SetPropertyValue<DictionaryDeliveryAdviceReason>("DeliveryAdviceReasonID", ref fDeliveryAdviceReasonID, value); }
        }
        string fDeliveryAdviceReasonNote;
        [Size(255)]
        public string DeliveryAdviceReasonNote
        {
            get { return fDeliveryAdviceReasonNote; }
            set { SetPropertyValue<string>("DeliveryAdviceReasonNote", ref fDeliveryAdviceReasonNote, value); }
        }
        Account fBillingAccountID;
        [Association(@"DeliveryAdviceReferencesQ_Account")]
        public Account BillingAccountID
        {
            get { return fBillingAccountID; }
            set { SetPropertyValue<Account>("BillingAccountID", ref fBillingAccountID, value); }
        }
        ProjectDeliverable fProjectDeliverableID;
        [Association(@"DeliveryAdviceReferencesProjectDeliverable")]
        public ProjectDeliverable ProjectDeliverableID
        {
            get { return fProjectDeliverableID; }
            set { SetPropertyValue<ProjectDeliverable>("ProjectDeliverableID", ref fProjectDeliverableID, value); }
        }
        Project fProjectID;
        [Association(@"DeliveryAdviceReferencesProject")]
        public Project ProjectID
        {
            get { return fProjectID; }
            set { SetPropertyValue<Project>("ProjectID", ref fProjectID, value); }
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
        [Association(@"DeliveryAdviceItemReferencesQ_DeliveryAdvice", typeof(DeliveryAdviceItem))]
        public XPCollection<DeliveryAdviceItem> DeliveryAdviceItems { get { return GetCollection<DeliveryAdviceItem>("DeliveryAdviceItems"); } }
    }

}
