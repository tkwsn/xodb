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

    [Persistent(@"X_ProjectPlan")]
    public partial class ProjectPlan : XPLiteObject
    {
        Guid fProjectPlanID;
        [Key(true)]
        public Guid ProjectPlanID
        {
            get { return fProjectPlanID; }
            set { SetPropertyValue<Guid>("ProjectPlanID", ref fProjectPlanID, value); }
        }
        ProjectPlan fParentProjectPlanID;
        [Association(@"ProjectPlanReferencesProjectPlan")]
        public ProjectPlan ParentProjectPlanID
        {
            get { return fParentProjectPlanID; }
            set { SetPropertyValue<ProjectPlan>("ParentProjectPlanID", ref fParentProjectPlanID, value); }
        }
        string fProjectPlanName;
        [Size(50)]
        public string ProjectPlanName
        {
            get { return fProjectPlanName; }
            set { SetPropertyValue<string>("ProjectPlanName", ref fProjectPlanName, value); }
        }
        Contact fResponsibleContactID;
        [Association(@"ProjectPlanReferencesContact")]
        public Contact ResponsibleContactID
        {
            get { return fResponsibleContactID; }
            set { SetPropertyValue<Contact>("ResponsibleContactID", ref fResponsibleContactID, value); }
        }
        string fComment;
        [Size(255)]
        public string Comment
        {
            get { return fComment; }
            set { SetPropertyValue<string>("Comment", ref fComment, value); }
        }
        [Association(@"ProjectPlanReferencesProjectPlan", typeof(ProjectPlan))]
        public XPCollection<ProjectPlan> ProjectPlanCollection { get { return GetCollection<ProjectPlan>("ProjectPlanCollection"); } }
        [Association(@"ProjectPlanTaskReferencesProjectPlan", typeof(ProjectPlanTask))]
        public XPCollection<ProjectPlanTask> ProjectPlanTasks { get { return GetCollection<ProjectPlanTask>("ProjectPlanTasks"); } }
    }

}
