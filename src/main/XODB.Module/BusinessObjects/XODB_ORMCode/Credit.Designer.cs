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

    [Persistent(@"E_Credit")]
    public partial class Credit : XPLiteObject
    {
        Guid fCreditID;
        [Key(true)]
        public Guid CreditID
        {
            get { return fCreditID; }
            set { SetPropertyValue<Guid>("CreditID", ref fCreditID, value); }
        }
        Supply fSupplyID;
        [Association(@"E_CreditReferencesSupply")]
        public Supply SupplyID
        {
            get { return fSupplyID; }
            set { SetPropertyValue<Supply>("SupplyID", ref fSupplyID, value); }
        }
        Invoice fInvoiceID;
        [Association(@"E_CreditReferencesInvoice")]
        public Invoice InvoiceID
        {
            get { return fInvoiceID; }
            set { SetPropertyValue<Invoice>("InvoiceID", ref fInvoiceID, value); }
        }
        InvoiceLine fInvoiceLineID;
        [Association(@"E_CreditReferencesInvoiceLine")]
        public InvoiceLine InvoiceLineID
        {
            get { return fInvoiceLineID; }
            set { SetPropertyValue<InvoiceLine>("InvoiceLineID", ref fInvoiceLineID, value); }
        }
        bool fIsCreditNote;
        public bool IsCreditNote
        {
            get { return fIsCreditNote; }
            set { SetPropertyValue<bool>("IsCreditNote", ref fIsCreditNote, value); }
        }
        bool fIsRefund;
        public bool IsRefund
        {
            get { return fIsRefund; }
            set { SetPropertyValue<bool>("IsRefund", ref fIsRefund, value); }
        }
        decimal fOriginalCredit;
        public decimal OriginalCredit
        {
            get { return fOriginalCredit; }
            set { SetPropertyValue<decimal>("OriginalCredit", ref fOriginalCredit, value); }
        }
        Currency fCurrencyID;
        [Association(@"E_CreditReferencesCurrency")]
        public Currency CurrencyID
        {
            get { return fCurrencyID; }
            set { SetPropertyValue<Currency>("CurrencyID", ref fCurrencyID, value); }
        }
        decimal fCreditAmount;
        public decimal CreditAmount
        {
            get { return fCreditAmount; }
            set { SetPropertyValue<decimal>("CreditAmount", ref fCreditAmount, value); }
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
    }

}