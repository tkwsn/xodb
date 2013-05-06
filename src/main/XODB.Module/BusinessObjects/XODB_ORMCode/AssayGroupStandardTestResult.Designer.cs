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

    [Persistent(@"X_AssayGroupStandardTestResult")]
    public partial class AssayGroupStandardTestResult : XPLiteObject
    {
        Guid fAssayGroupStandardTestResultID;
        [Key(true)]
        public Guid AssayGroupStandardTestResultID
        {
            get { return fAssayGroupStandardTestResultID; }
            set { SetPropertyValue<Guid>("AssayGroupStandardTestResultID", ref fAssayGroupStandardTestResultID, value); }
        }
        AssayGroupTestSample fAssayGroupTestSampleID;
        [Association(@"AssayGroupStandardTestResultReferencesAssayGroupTestSample")]
        public AssayGroupTestSample AssayGroupTestSampleID
        {
            get { return fAssayGroupTestSampleID; }
            set { SetPropertyValue<AssayGroupTestSample>("AssayGroupTestSampleID", ref fAssayGroupTestSampleID, value); }
        }
        AssayGroupTest fAssayGroupTestID;
        [Association(@"AssayGroupStandardTestResultReferencesAssayGroupTest")]
        public AssayGroupTest AssayGroupTestID
        {
            get { return fAssayGroupTestID; }
            set { SetPropertyValue<AssayGroupTest>("AssayGroupTestID", ref fAssayGroupTestID, value); }
        }
        DictionaryAssayStandard fAssayStandardID;
        [Association(@"AssayGroupStandardTestResultReferencesDictionaryAssayStandard")]
        public DictionaryAssayStandard AssayStandardID
        {
            get { return fAssayStandardID; }
            set { SetPropertyValue<DictionaryAssayStandard>("AssayStandardID", ref fAssayStandardID, value); }
        }
        DictionarySampleCategory fSampleCategoryID;
        [Association(@"AssayGroupStandardTestResultReferencesDictionarySampleCategory")]
        public DictionarySampleCategory SampleCategoryID
        {
            get { return fSampleCategoryID; }
            set { SetPropertyValue<DictionarySampleCategory>("SampleCategoryID", ref fSampleCategoryID, value); }
        }
        DictionarySampleState fSampleStateID;
        [Association(@"AssayGroupStandardTestResultReferencesDictionarySampleState")]
        public DictionarySampleState SampleStateID
        {
            get { return fSampleStateID; }
            set { SetPropertyValue<DictionarySampleState>("SampleStateID", ref fSampleStateID, value); }
        }
        DictionarySampleType fSampleTypeID;
        [Association(@"AssayGroupStandardTestResultReferencesDictionarySampleType")]
        public DictionarySampleType SampleTypeID
        {
            get { return fSampleTypeID; }
            set { SetPropertyValue<DictionarySampleType>("SampleTypeID", ref fSampleTypeID, value); }
        }
        string fLabResultText;
        [Size(58)]
        public string LabResultText
        {
            get { return fLabResultText; }
            set { SetPropertyValue<string>("LabResultText", ref fLabResultText, value); }
        }
        decimal fLabResult;
        public decimal LabResult
        {
            get { return fLabResult; }
            set { SetPropertyValue<decimal>("LabResult", ref fLabResult, value); }
        }
        string fLabSampleNumber;
        [Size(16)]
        public string LabSampleNumber
        {
            get { return fLabSampleNumber; }
            set { SetPropertyValue<string>("LabSampleNumber", ref fLabSampleNumber, value); }
        }
        string fLabBatchNumber;
        [Size(16)]
        public string LabBatchNumber
        {
            get { return fLabBatchNumber; }
            set { SetPropertyValue<string>("LabBatchNumber", ref fLabBatchNumber, value); }
        }
        DateTime fSampled;
        public DateTime Sampled
        {
            get { return fSampled; }
            set { SetPropertyValue<DateTime>("Sampled", ref fSampled, value); }
        }
        string fSampledBy;
        [Size(50)]
        public string SampledBy
        {
            get { return fSampledBy; }
            set { SetPropertyValue<string>("SampledBy", ref fSampledBy, value); }
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
