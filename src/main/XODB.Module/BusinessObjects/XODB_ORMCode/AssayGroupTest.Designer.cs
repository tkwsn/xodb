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

    [Persistent(@"X_AssayGroupTest")]
    public partial class AssayGroupTest : XPLiteObject
    {
        Guid fAssayGroupTestID;
        [Key(true)]
        public Guid AssayGroupTestID
        {
            get { return fAssayGroupTestID; }
            set { SetPropertyValue<Guid>("AssayGroupTestID", ref fAssayGroupTestID, value); }
        }
        AssayGroup fAssayGroupID;
        [Indexed(@"AssayTestName", Name = @"IAssayTest", Unique = true)]
        [Association(@"AssayGroupTestReferencesAssayGroup")]
        public AssayGroup AssayGroupID
        {
            get { return fAssayGroupID; }
            set { SetPropertyValue<AssayGroup>("AssayGroupID", ref fAssayGroupID, value); }
        }
        string fAssayTypeName;
        [Indexed(Name = @"iAssayType_AssayGroupTest")]
        [Size(16)]
        public string AssayTypeName
        {
            get { return fAssayTypeName; }
            set { SetPropertyValue<string>("AssayTypeName", ref fAssayTypeName, value); }
        }
        string fAssayTestName;
        [Size(16)]
        public string AssayTestName
        {
            get { return fAssayTestName; }
            set { SetPropertyValue<string>("AssayTestName", ref fAssayTestName, value); }
        }
        Parameter fParameterID;
        [Association(@"AssayGroupTestReferencesParameter")]
        public Parameter ParameterID
        {
            get { return fParameterID; }
            set { SetPropertyValue<Parameter>("ParameterID", ref fParameterID, value); }
        }
        int fAssayTestPriority;
        public int AssayTestPriority
        {
            get { return fAssayTestPriority; }
            set { SetPropertyValue<int>("AssayTestPriority", ref fAssayTestPriority, value); }
        }
        DictionaryAssayMethod fAssayMethodID;
        [Association(@"AssayGroupTestReferencesDictionaryAssayMethod")]
        public DictionaryAssayMethod AssayMethodID
        {
            get { return fAssayMethodID; }
            set { SetPropertyValue<DictionaryAssayMethod>("AssayMethodID", ref fAssayMethodID, value); }
        }
        DictionaryAssayType fAssayTypeID;
        [Association(@"AssayGroupTestReferencesDictionaryAssayType")]
        public DictionaryAssayType AssayTypeID
        {
            get { return fAssayTypeID; }
            set { SetPropertyValue<DictionaryAssayType>("AssayTypeID", ref fAssayTypeID, value); }
        }
        [Association(@"AssayGroupStandardTestResultReferencesAssayGroupTest", typeof(AssayGroupStandardTestResult))]
        public XPCollection<AssayGroupStandardTestResult> AssayGroupStandardTestResults { get { return GetCollection<AssayGroupStandardTestResult>("AssayGroupStandardTestResults"); } }
        [Association(@"AssayGroupTestResultReferencesAssayGroupTest", typeof(AssayGroupTestResult))]
        public XPCollection<AssayGroupTestResult> AssayGroupTestResults { get { return GetCollection<AssayGroupTestResult>("AssayGroupTestResults"); } }
    }

}
