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

    [Persistent(@"Q_ModelProcedureTask")]
    public partial class ModelProcedureTask : XPLiteObject
    {
        Guid fModelProcedureTaskID;
        [Key(true)]
        public Guid ModelProcedureTaskID
        {
            get { return fModelProcedureTaskID; }
            set { SetPropertyValue<Guid>("ModelProcedureTaskID", ref fModelProcedureTaskID, value); }
        }
        ModelProcedure fModelProcedureID;
        [Association(@"ModelProcedureTaskReferencesQ_ModelProcedure")]
        public ModelProcedure ModelProcedureID
        {
            get { return fModelProcedureID; }
            set { SetPropertyValue<ModelProcedure>("ModelProcedureID", ref fModelProcedureID, value); }
        }
        Task fTaskID;
        [Association(@"ModelProcedureTaskReferencesX_Task")]
        public Task TaskID
        {
            get { return fTaskID; }
            set { SetPropertyValue<Task>("TaskID", ref fTaskID, value); }
        }
        int fSequence;
        public int Sequence
        {
            get { return fSequence; }
            set { SetPropertyValue<int>("Sequence", ref fSequence, value); }
        }
        FileData fFileDataID;
        [Association(@"ModelProcedureTaskReferencesFileData")]
        public FileData FileDataID
        {
            get { return fFileDataID; }
            set { SetPropertyValue<FileData>("FileDataID", ref fFileDataID, value); }
        }
        string fStatedRevisionNumber;
        [Size(40)]
        public string StatedRevisionNumber
        {
            get { return fStatedRevisionNumber; }
            set { SetPropertyValue<string>("StatedRevisionNumber", ref fStatedRevisionNumber, value); }
        }
        DateTime fStatedRevisionPublishDate;
        public DateTime StatedRevisionPublishDate
        {
            get { return fStatedRevisionPublishDate; }
            set { SetPropertyValue<DateTime>("StatedRevisionPublishDate", ref fStatedRevisionPublishDate, value); }
        }
        decimal fEstimatedDuration;
        public decimal EstimatedDuration
        {
            get { return fEstimatedDuration; }
            set { SetPropertyValue<decimal>("EstimatedDuration", ref fEstimatedDuration, value); }
        }
        DictionaryUnit fEstimatedDurationUnitID;
        [Association(@"ModelProcedureTaskReferencesDictionaryUnit")]
        public DictionaryUnit EstimatedDurationUnitID
        {
            get { return fEstimatedDurationUnitID; }
            set { SetPropertyValue<DictionaryUnit>("EstimatedDurationUnitID", ref fEstimatedDurationUnitID, value); }
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
        [Association(@"ModelProcedureTaskPartReferencesQ_ModelProcedureTask", typeof(ModelProcedureTaskPart))]
        public XPCollection<ModelProcedureTaskPart> ModelProcedureTaskParts { get { return GetCollection<ModelProcedureTaskPart>("ModelProcedureTaskParts"); } }
    }

}
