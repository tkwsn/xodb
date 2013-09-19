//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XODB.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Experience
    {
        public System.Guid ExperienceID { get; set; }
        public string ExperienceName { get; set; }
        public Nullable<System.Guid> CompanyID { get; set; }
        public Nullable<System.Guid> ProjectID { get; set; }
        public Nullable<System.Guid> ContactID { get; set; }
        public Nullable<System.Guid> LocationID { get; set; }
        public Nullable<System.Guid> ProvinceID { get; set; }
        public Nullable<System.Guid> WorkTypeID { get; set; }
        public Nullable<System.Guid> ProfessionID { get; set; }
        public Nullable<System.Guid> PositionID { get; set; }
        public string ClientAlias { get; set; }
        public string Division { get; set; }
        public string OfficeLocationAlias { get; set; }
        public string ExternalProjectCode { get; set; }
        public Nullable<int> EstimatedDurationDays { get; set; }
        public Nullable<int> UserExperienceLevel { get; set; }
        public Nullable<int> AssignedExperienceLevel { get; set; }
        public Nullable<int> NormalizedExperienceLevel { get; set; }
        public System.DateTime DateStart { get; set; }
        public Nullable<System.DateTime> DateFinished { get; set; }
        public Nullable<System.DateTime> Expiry { get; set; }
        public Nullable<decimal> HourlyRate { get; set; }
        public Nullable<decimal> DailyRate { get; set; }
        public Nullable<decimal> AnnualRate { get; set; }
        public Nullable<decimal> BlendedHourlyRate { get; set; }
        public Nullable<decimal> BlendedHourlyCost { get; set; }
        public string Comment { get; set; }
        public Nullable<bool> IsApproved { get; set; }
        public int Version { get; set; }
        public Nullable<System.Guid> VersionAntecedentID { get; set; }
        public Nullable<int> VersionCertainty { get; set; }
        public Nullable<System.Guid> VersionWorkflowInstanceID { get; set; }
        public Nullable<System.Guid> VersionUpdatedBy { get; set; }
        public Nullable<System.Guid> VersionDeletedBy { get; set; }
        public Nullable<System.Guid> VersionOwnerContactID { get; set; }
        public Nullable<System.Guid> VersionOwnerCompanyID { get; set; }
        public Nullable<System.DateTime> VersionUpdated { get; set; }
        public Nullable<System.Guid> ExperienceGroupID { get; set; }
    
        public virtual Company X_Company { get; set; }
        public virtual Contact X_Contact { get; set; }
    }
}
