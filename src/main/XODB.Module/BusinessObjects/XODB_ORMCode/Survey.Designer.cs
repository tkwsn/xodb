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

    [Persistent(@"X_Survey")]
    public partial class Survey : XPLiteObject
    {
        Guid fSurveyID;
        [Key(true)]
        public Guid SurveyID
        {
            get { return fSurveyID; }
            set { SetPropertyValue<Guid>("SurveyID", ref fSurveyID, value); }
        }
        Header fHeaderID;
        [Association(@"SurveyReferencesHeader")]
        public Header HeaderID
        {
            get { return fHeaderID; }
            set { SetPropertyValue<Header>("HeaderID", ref fHeaderID, value); }
        }
        decimal fDepth;
        public decimal Depth
        {
            get { return fDepth; }
            set { SetPropertyValue<decimal>("Depth", ref fDepth, value); }
        }
        decimal fDip;
        public decimal Dip
        {
            get { return fDip; }
            set { SetPropertyValue<decimal>("Dip", ref fDip, value); }
        }
        decimal fMagneticDip;
        public decimal MagneticDip
        {
            get { return fMagneticDip; }
            set { SetPropertyValue<decimal>("MagneticDip", ref fMagneticDip, value); }
        }
        bool fMagnetAffected;
        public bool MagnetAffected
        {
            get { return fMagnetAffected; }
            set { SetPropertyValue<bool>("MagnetAffected", ref fMagnetAffected, value); }
        }
        decimal fOriginalAzimuth;
        public decimal OriginalAzimuth
        {
            get { return fOriginalAzimuth; }
            set { SetPropertyValue<decimal>("OriginalAzimuth", ref fOriginalAzimuth, value); }
        }
        decimal fCorrectedAzimuth;
        public decimal CorrectedAzimuth
        {
            get { return fCorrectedAzimuth; }
            set { SetPropertyValue<decimal>("CorrectedAzimuth", ref fCorrectedAzimuth, value); }
        }
        decimal fGravity;
        public decimal Gravity
        {
            get { return fGravity; }
            set { SetPropertyValue<decimal>("Gravity", ref fGravity, value); }
        }
        string fInstrument;
        [Size(16)]
        public string Instrument
        {
            get { return fInstrument; }
            set { SetPropertyValue<string>("Instrument", ref fInstrument, value); }
        }
        DateTime fSurveyed;
        public DateTime Surveyed
        {
            get { return fSurveyed; }
            set { SetPropertyValue<DateTime>("Surveyed", ref fSurveyed, value); }
        }
        Contact fSurveyContactID;
        [Association(@"SurveyReferencesContact")]
        public Contact SurveyContactID
        {
            get { return fSurveyContactID; }
            set { SetPropertyValue<Contact>("SurveyContactID", ref fSurveyContactID, value); }
        }
        SurveyCompany fSurveyCompanyID;
        [Association(@"SurveyReferencesSurveyCompany")]
        public SurveyCompany SurveyCompanyID
        {
            get { return fSurveyCompanyID; }
            set { SetPropertyValue<SurveyCompany>("SurveyCompanyID", ref fSurveyCompanyID, value); }
        }
        [Association(@"DesurveyReferencesSurvey", typeof(Desurvey))]
        public XPCollection<Desurvey> Desurveys { get { return GetCollection<Desurvey>("Desurveys"); } }
    }

}
