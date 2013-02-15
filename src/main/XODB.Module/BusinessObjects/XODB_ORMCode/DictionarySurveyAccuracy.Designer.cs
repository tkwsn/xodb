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

    [Persistent(@"X_DictionarySurveyAccuracy")]
    public partial class DictionarySurveyAccuracy : XPLiteObject
    {
        Guid fSurveyAccuracyID;
        [Key(true)]
        public Guid SurveyAccuracyID
        {
            get { return fSurveyAccuracyID; }
            set { SetPropertyValue<Guid>("SurveyAccuracyID", ref fSurveyAccuracyID, value); }
        }
        string fStandardSurveyAccuracyName;
        [Indexed(Name = @"IDictionarySurveyAccuracy", Unique = true)]
        [Size(16)]
        public string StandardSurveyAccuracyName
        {
            get { return fStandardSurveyAccuracyName; }
            set { SetPropertyValue<string>("StandardSurveyAccuracyName", ref fStandardSurveyAccuracyName, value); }
        }
        string fCoalSurveyAccuracyName;
        [Size(16)]
        public string CoalSurveyAccuracyName
        {
            get { return fCoalSurveyAccuracyName; }
            set { SetPropertyValue<string>("CoalSurveyAccuracyName", ref fCoalSurveyAccuracyName, value); }
        }
        string fGoldSurveyAccuracyName;
        [Size(16)]
        public string GoldSurveyAccuracyName
        {
            get { return fGoldSurveyAccuracyName; }
            set { SetPropertyValue<string>("GoldSurveyAccuracyName", ref fGoldSurveyAccuracyName, value); }
        }
        string fCustomSurveyAccuracyName;
        [Size(16)]
        public string CustomSurveyAccuracyName
        {
            get { return fCustomSurveyAccuracyName; }
            set { SetPropertyValue<string>("CustomSurveyAccuracyName", ref fCustomSurveyAccuracyName, value); }
        }
        string fDescription;
        [Size(255)]
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>("Description", ref fDescription, value); }
        }
        [Association(@"HeaderReferencesDictionarySurveyAccuracy", typeof(Header))]
        public XPCollection<Header> Headers { get { return GetCollection<Header>("Headers"); } }
    }

}
