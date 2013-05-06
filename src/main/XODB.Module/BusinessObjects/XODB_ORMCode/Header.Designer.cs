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

    [Persistent(@"X_Header")]
    public partial class Header : XPLiteObject
    {
        Guid fHeaderID;
        [Key(true)]
        public Guid HeaderID
        {
            get { return fHeaderID; }
            set { SetPropertyValue<Guid>("HeaderID", ref fHeaderID, value); }
        }
        Project fProjectID;
        [Association(@"HeaderReferencesProject")]
        public Project ProjectID
        {
            get { return fProjectID; }
            set { SetPropertyValue<Project>("ProjectID", ref fProjectID, value); }
        }
        string fHoleName;
        [Size(16)]
        public string HoleName
        {
            get { return fHoleName; }
            set { SetPropertyValue<string>("HoleName", ref fHoleName, value); }
        }
        string fSite;
        [Size(16)]
        public string Site
        {
            get { return fSite; }
            set { SetPropertyValue<string>("Site", ref fSite, value); }
        }
        DictionaryHoleType fHoleTypeID;
        [Association(@"HeaderReferencesDictionaryHoleType")]
        public DictionaryHoleType HoleTypeID
        {
            get { return fHoleTypeID; }
            set { SetPropertyValue<DictionaryHoleType>("HoleTypeID", ref fHoleTypeID, value); }
        }
        DictionaryDataStatus fDataStatusID;
        [Association(@"HeaderReferencesDictionaryDataStatus")]
        public DictionaryDataStatus DataStatusID
        {
            get { return fDataStatusID; }
            set { SetPropertyValue<DictionaryDataStatus>("DataStatusID", ref fDataStatusID, value); }
        }
        DictionaryHolePurpose fPrimaryHolePurposeID;
        [Association(@"HeaderReferencesDictionaryHolePurpose")]
        public DictionaryHolePurpose PrimaryHolePurposeID
        {
            get { return fPrimaryHolePurposeID; }
            set { SetPropertyValue<DictionaryHolePurpose>("PrimaryHolePurposeID", ref fPrimaryHolePurposeID, value); }
        }
        DictionaryHolePurpose fSecondaryHolePurposeID;
        [Association(@"HeaderReferencesDictionaryHolePurpose1")]
        public DictionaryHolePurpose SecondaryHolePurposeID
        {
            get { return fSecondaryHolePurposeID; }
            set { SetPropertyValue<DictionaryHolePurpose>("SecondaryHolePurposeID", ref fSecondaryHolePurposeID, value); }
        }
        DictionarySurveyAccuracy fSurveyAccuracyID;
        [Association(@"HeaderReferencesDictionarySurveyAccuracy")]
        public DictionarySurveyAccuracy SurveyAccuracyID
        {
            get { return fSurveyAccuracyID; }
            set { SetPropertyValue<DictionarySurveyAccuracy>("SurveyAccuracyID", ref fSurveyAccuracyID, value); }
        }
        DictionaryGeodeticDatum fGeodeticDatumID;
        [Association(@"HeaderReferencesDictionaryGeodeticDatum")]
        public DictionaryGeodeticDatum GeodeticDatumID
        {
            get { return fGeodeticDatumID; }
            set { SetPropertyValue<DictionaryGeodeticDatum>("GeodeticDatumID", ref fGeodeticDatumID, value); }
        }
        int fUtmZoneNumber;
        public int UtmZoneNumber
        {
            get { return fUtmZoneNumber; }
            set { SetPropertyValue<int>("UtmZoneNumber", ref fUtmZoneNumber, value); }
        }
        string fUtmZoneHemisphere;
        [Size(1)]
        public string UtmZoneHemisphere
        {
            get { return fUtmZoneHemisphere; }
            set { SetPropertyValue<string>("UtmZoneHemisphere", ref fUtmZoneHemisphere, value); }
        }
        DictionaryHeightDatum fHeightDatumID;
        [Association(@"HeaderReferencesDictionaryHeightDatum")]
        public DictionaryHeightDatum HeightDatumID
        {
            get { return fHeightDatumID; }
            set { SetPropertyValue<DictionaryHeightDatum>("HeightDatumID", ref fHeightDatumID, value); }
        }
        decimal fEasting;
        public decimal Easting
        {
            get { return fEasting; }
            set { SetPropertyValue<decimal>("Easting", ref fEasting, value); }
        }
        decimal fNorthing;
        public decimal Northing
        {
            get { return fNorthing; }
            set { SetPropertyValue<decimal>("Northing", ref fNorthing, value); }
        }
        decimal fElevation;
        public decimal Elevation
        {
            get { return fElevation; }
            set { SetPropertyValue<decimal>("Elevation", ref fElevation, value); }
        }
        int fInclination;
        public int Inclination
        {
            get { return fInclination; }
            set { SetPropertyValue<int>("Inclination", ref fInclination, value); }
        }
        int fAzimuth;
        public int Azimuth
        {
            get { return fAzimuth; }
            set { SetPropertyValue<int>("Azimuth", ref fAzimuth, value); }
        }
        DateTime fStartDate;
        public DateTime StartDate
        {
            get { return fStartDate; }
            set { SetPropertyValue<DateTime>("StartDate", ref fStartDate, value); }
        }
        DateTime fCompleteDate;
        public DateTime CompleteDate
        {
            get { return fCompleteDate; }
            set { SetPropertyValue<DateTime>("CompleteDate", ref fCompleteDate, value); }
        }
        decimal fTotalDepth;
        public decimal TotalDepth
        {
            get { return fTotalDepth; }
            set { SetPropertyValue<decimal>("TotalDepth", ref fTotalDepth, value); }
        }
        string fHoleRedrilled;
        [Size(16)]
        public string HoleRedrilled
        {
            get { return fHoleRedrilled; }
            set { SetPropertyValue<string>("HoleRedrilled", ref fHoleRedrilled, value); }
        }
        Guid fGeologyCompanyID;
        public Guid GeologyCompanyID
        {
            get { return fGeologyCompanyID; }
            set { SetPropertyValue<Guid>("GeologyCompanyID", ref fGeologyCompanyID, value); }
        }
        bool fHasHadGeotechLogs;
        public bool HasHadGeotechLogs
        {
            get { return fHasHadGeotechLogs; }
            set { SetPropertyValue<bool>("HasHadGeotechLogs", ref fHasHadGeotechLogs, value); }
        }
        bool fHasHadCorePhotos;
        public bool HasHadCorePhotos
        {
            get { return fHasHadCorePhotos; }
            set { SetPropertyValue<bool>("HasHadCorePhotos", ref fHasHadCorePhotos, value); }
        }
        Guid fGeophysicalLoggingCompanyID;
        public Guid GeophysicalLoggingCompanyID
        {
            get { return fGeophysicalLoggingCompanyID; }
            set { SetPropertyValue<Guid>("GeophysicalLoggingCompanyID", ref fGeophysicalLoggingCompanyID, value); }
        }
        DictionaryGeophysicalLogType fGeophysicalLogTypeID1;
        [Association(@"HeaderReferencesDictionaryGeophysicalLogType")]
        public DictionaryGeophysicalLogType GeophysicalLogTypeID1
        {
            get { return fGeophysicalLogTypeID1; }
            set { SetPropertyValue<DictionaryGeophysicalLogType>("GeophysicalLogTypeID1", ref fGeophysicalLogTypeID1, value); }
        }
        DictionaryGeophysicalLogType fGeophysicalLogTypeID2;
        [Association(@"HeaderReferencesDictionaryGeophysicalLogType6")]
        public DictionaryGeophysicalLogType GeophysicalLogTypeID2
        {
            get { return fGeophysicalLogTypeID2; }
            set { SetPropertyValue<DictionaryGeophysicalLogType>("GeophysicalLogTypeID2", ref fGeophysicalLogTypeID2, value); }
        }
        DictionaryGeophysicalLogType fGeophysicalLogTypeID3;
        [Association(@"HeaderReferencesDictionaryGeophysicalLogType7")]
        public DictionaryGeophysicalLogType GeophysicalLogTypeID3
        {
            get { return fGeophysicalLogTypeID3; }
            set { SetPropertyValue<DictionaryGeophysicalLogType>("GeophysicalLogTypeID3", ref fGeophysicalLogTypeID3, value); }
        }
        DictionaryGeophysicalLogType fGeophysicalLogTypeID4;
        [Association(@"HeaderReferencesDictionaryGeophysicalLogType8")]
        public DictionaryGeophysicalLogType GeophysicalLogTypeID4
        {
            get { return fGeophysicalLogTypeID4; }
            set { SetPropertyValue<DictionaryGeophysicalLogType>("GeophysicalLogTypeID4", ref fGeophysicalLogTypeID4, value); }
        }
        DictionaryGeophysicalLogType fGeophysicalLogTypeID5;
        [Association(@"HeaderReferencesDictionaryGeophysicalLogType9")]
        public DictionaryGeophysicalLogType GeophysicalLogTypeID5
        {
            get { return fGeophysicalLogTypeID5; }
            set { SetPropertyValue<DictionaryGeophysicalLogType>("GeophysicalLogTypeID5", ref fGeophysicalLogTypeID5, value); }
        }
        DictionaryGeophysicalLogType fGeophysicalLogTypeID6;
        [Association(@"HeaderReferencesDictionaryGeophysicalLogType10")]
        public DictionaryGeophysicalLogType GeophysicalLogTypeID6
        {
            get { return fGeophysicalLogTypeID6; }
            set { SetPropertyValue<DictionaryGeophysicalLogType>("GeophysicalLogTypeID6", ref fGeophysicalLogTypeID6, value); }
        }
        DictionaryGeophysicalLogType fGeophysicalLogTypeID7;
        [Association(@"HeaderReferencesDictionaryGeophysicalLogType11")]
        public DictionaryGeophysicalLogType GeophysicalLogTypeID7
        {
            get { return fGeophysicalLogTypeID7; }
            set { SetPropertyValue<DictionaryGeophysicalLogType>("GeophysicalLogTypeID7", ref fGeophysicalLogTypeID7, value); }
        }
        DictionaryGeophysicalLogType fGeophysicalLogTypeID8;
        [Association(@"HeaderReferencesDictionaryGeophysicalLogType2")]
        public DictionaryGeophysicalLogType GeophysicalLogTypeID8
        {
            get { return fGeophysicalLogTypeID8; }
            set { SetPropertyValue<DictionaryGeophysicalLogType>("GeophysicalLogTypeID8", ref fGeophysicalLogTypeID8, value); }
        }
        DictionaryGeophysicalLogType fGeophysicalLogTypeID9;
        [Association(@"HeaderReferencesDictionaryGeophysicalLogType3")]
        public DictionaryGeophysicalLogType GeophysicalLogTypeID9
        {
            get { return fGeophysicalLogTypeID9; }
            set { SetPropertyValue<DictionaryGeophysicalLogType>("GeophysicalLogTypeID9", ref fGeophysicalLogTypeID9, value); }
        }
        DictionaryGeophysicalLogType fGeophysicalLogTypeID10;
        [Association(@"HeaderReferencesDictionaryGeophysicalLogType1")]
        public DictionaryGeophysicalLogType GeophysicalLogTypeID10
        {
            get { return fGeophysicalLogTypeID10; }
            set { SetPropertyValue<DictionaryGeophysicalLogType>("GeophysicalLogTypeID10", ref fGeophysicalLogTypeID10, value); }
        }
        DictionaryGeophysicalLogType fGeophysicalLogTypeID11;
        [Association(@"HeaderReferencesDictionaryGeophysicalLogType4")]
        public DictionaryGeophysicalLogType GeophysicalLogTypeID11
        {
            get { return fGeophysicalLogTypeID11; }
            set { SetPropertyValue<DictionaryGeophysicalLogType>("GeophysicalLogTypeID11", ref fGeophysicalLogTypeID11, value); }
        }
        DictionaryGeophysicalLogType fGeophysicalLogTypeID12;
        [Association(@"HeaderReferencesDictionaryGeophysicalLogType5")]
        public DictionaryGeophysicalLogType GeophysicalLogTypeID12
        {
            get { return fGeophysicalLogTypeID12; }
            set { SetPropertyValue<DictionaryGeophysicalLogType>("GeophysicalLogTypeID12", ref fGeophysicalLogTypeID12, value); }
        }
        Contact fGeophysicalLoggerID;
        [Association(@"HeaderReferencesContact")]
        public Contact GeophysicalLoggerID
        {
            get { return fGeophysicalLoggerID; }
            set { SetPropertyValue<Contact>("GeophysicalLoggerID", ref fGeophysicalLoggerID, value); }
        }
        decimal fStandingWaterLevel;
        public decimal StandingWaterLevel
        {
            get { return fStandingWaterLevel; }
            set { SetPropertyValue<decimal>("StandingWaterLevel", ref fStandingWaterLevel, value); }
        }
        DateTime fStandingWaterLevelDate;
        public DateTime StandingWaterLevelDate
        {
            get { return fStandingWaterLevelDate; }
            set { SetPropertyValue<DateTime>("StandingWaterLevelDate", ref fStandingWaterLevelDate, value); }
        }
        DateTime fDateRehabilitated;
        public DateTime DateRehabilitated
        {
            get { return fDateRehabilitated; }
            set { SetPropertyValue<DateTime>("DateRehabilitated", ref fDateRehabilitated, value); }
        }
        DictionaryHoleStatus fHoleStatusID;
        [Association(@"HeaderReferencesDictionaryHoleStatus")]
        public DictionaryHoleStatus HoleStatusID
        {
            get { return fHoleStatusID; }
            set { SetPropertyValue<DictionaryHoleStatus>("HoleStatusID", ref fHoleStatusID, value); }
        }
        string fComment;
        [Size(SizeAttribute.Unlimited)]
        public string Comment
        {
            get { return fComment; }
            set { SetPropertyValue<string>("Comment", ref fComment, value); }
        }
        Location fLocationID;
        [Association(@"HeaderReferencesLocation")]
        public Location LocationID
        {
            get { return fLocationID; }
            set { SetPropertyValue<Location>("LocationID", ref fLocationID, value); }
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
        [Association(@"CasingReferencesHeader", typeof(Casing))]
        public XPCollection<Casing> Casings { get { return GetCollection<Casing>("Casings"); } }
        [Association(@"CementingReferencesHeader", typeof(Cementing))]
        public XPCollection<Cementing> Cementings { get { return GetCollection<Cementing>("Cementings"); } }
        [Association(@"CompositeReferencesHeader", typeof(Composite))]
        public XPCollection<Composite> Composites { get { return GetCollection<Composite>("Composites"); } }
        [Association(@"DefectReferencesHeader", typeof(Defect))]
        public XPCollection<Defect> Defects { get { return GetCollection<Defect>("Defects"); } }
        [Association(@"DrillingReferencesHeader", typeof(Drilling))]
        public XPCollection<Drilling> Drillings { get { return GetCollection<Drilling>("Drillings"); } }
        [Association(@"GeologyReferencesHeader", typeof(Geology))]
        public XPCollection<Geology> Geologies { get { return GetCollection<Geology>("Geologies"); } }
        [Association(@"GeophysicsReferencesHeader", typeof(Geophysics))]
        public XPCollection<Geophysics> GeophysicsCollection { get { return GetCollection<Geophysics>("GeophysicsCollection"); } }
        [Association(@"HeaderRelationReferencesHeader", typeof(HeaderRelation))]
        public XPCollection<HeaderRelation> HeaderRelations { get { return GetCollection<HeaderRelation>("HeaderRelations"); } }
        [Association(@"HeaderRelationReferencesHeader1", typeof(HeaderRelation))]
        public XPCollection<HeaderRelation> HeaderRelations1 { get { return GetCollection<HeaderRelation>("HeaderRelations1"); } }
        [Association(@"LithologyReferencesHeader", typeof(Lithology))]
        public XPCollection<Lithology> Lithologies { get { return GetCollection<Lithology>("Lithologies"); } }
        [Association(@"MineralogyReferencesHeader", typeof(Mineralogy))]
        public XPCollection<Mineralogy> Mineralogies { get { return GetCollection<Mineralogy>("Mineralogies"); } }
        [Association(@"PointLoadReferencesHeader", typeof(PointLoad))]
        public XPCollection<PointLoad> PointLoads { get { return GetCollection<PointLoad>("PointLoads"); } }
        [Association(@"RecoveryReferencesHeader", typeof(Recovery))]
        public XPCollection<Recovery> Recoveries { get { return GetCollection<Recovery>("Recoveries"); } }
        [Association(@"SurveyReferencesHeader", typeof(Survey))]
        public XPCollection<Survey> Surveys { get { return GetCollection<Survey>("Surveys"); } }
        [Association(@"WaterFlowReferencesHeader", typeof(WaterFlow))]
        public XPCollection<WaterFlow> WaterFlows { get { return GetCollection<WaterFlow>("WaterFlows"); } }
        [Association(@"SampleReferencesHeader", typeof(Sample))]
        public XPCollection<Sample> Samples { get { return GetCollection<Sample>("Samples"); } }
    }

}
