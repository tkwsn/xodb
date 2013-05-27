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

    [Persistent(@"E_Currency")]
    public partial class Currency : XPLiteObject
    {
        Guid fCurrencyID;
        [Key(true)]
        public Guid CurrencyID
        {
            get { return fCurrencyID; }
            set { SetPropertyValue<Guid>("CurrencyID", ref fCurrencyID, value); }
        }
        DictionaryCountry fCountryID;
        [Size(2)]
        [Association(@"CurrencyReferencesDictionaryCountry")]
        public DictionaryCountry CountryID
        {
            get { return fCountryID; }
            set { SetPropertyValue<DictionaryCountry>("CountryID", ref fCountryID, value); }
        }
        decimal fEquivalentMultiplier;
        public decimal EquivalentMultiplier
        {
            get { return fEquivalentMultiplier; }
            set { SetPropertyValue<decimal>("EquivalentMultiplier", ref fEquivalentMultiplier, value); }
        }
        decimal fBuyMultiplier;
        public decimal BuyMultiplier
        {
            get { return fBuyMultiplier; }
            set { SetPropertyValue<decimal>("BuyMultiplier", ref fBuyMultiplier, value); }
        }
        decimal fSellMultiplier;
        public decimal SellMultiplier
        {
            get { return fSellMultiplier; }
            set { SetPropertyValue<decimal>("SellMultiplier", ref fSellMultiplier, value); }
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
        [Association(@"PurchaseOrderReferencesE_Currency", typeof(PurchaseOrder))]
        public XPCollection<PurchaseOrder> PurchaseOrders { get { return GetCollection<PurchaseOrder>("PurchaseOrders"); } }
        [Association(@"PaymentReferencesE_Currency", typeof(Payment))]
        public XPCollection<Payment> Payments { get { return GetCollection<Payment>("Payments"); } }
        [Association(@"InvoiceReferencesE_Currency", typeof(Invoice))]
        public XPCollection<Invoice> Invoices { get { return GetCollection<Invoice>("Invoices"); } }
        [Association(@"JournalReferencesE_Currency", typeof(Journal))]
        public XPCollection<Journal> Journals { get { return GetCollection<Journal>("Journals"); } }
        [Association(@"InvoiceLineReferencesE_Currency", typeof(InvoiceLine))]
        public XPCollection<InvoiceLine> InvoiceLines { get { return GetCollection<InvoiceLine>("InvoiceLines"); } }
        [Association(@"SupplyItemReferencesCurrency", typeof(SupplyItem))]
        public XPCollection<SupplyItem> SupplyItems { get { return GetCollection<SupplyItem>("SupplyItems"); } }
        [Association(@"CreditReferencesCurrency", typeof(Credit))]
        public XPCollection<Credit> Credits { get { return GetCollection<Credit>("Credits"); } }
    }

}
