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
    
    public partial class SecurityWhitelist
    {
        public System.Guid SecurityWhitelistID { get; set; }
        public Nullable<System.Guid> OwnerApplicationID { get; set; }
        public Nullable<System.Guid> OwnerCompanyID { get; set; }
        public Nullable<System.Guid> OwnerContactID { get; set; }
        public Nullable<System.Guid> OwnerProjectID { get; set; }
        public string OwnerEntitySystemType { get; set; }
        public string OwnerTableType { get; set; }
        public string OwnerField { get; set; }
        public Nullable<System.Guid> OwnerReferenceID { get; set; }
        public Nullable<System.Guid> AccessorApplicationID { get; set; }
        public Nullable<System.Guid> AccessorCompanyID { get; set; }
        public Nullable<System.Guid> AccessorProjectID { get; set; }
        public Nullable<System.Guid> AccessorContactID { get; set; }
        public Nullable<System.Guid> AccessorRoleID { get; set; }
        public Nullable<bool> CanCreate { get; set; }
        public Nullable<bool> CanRead { get; set; }
        public Nullable<bool> CanUpdate { get; set; }
        public Nullable<bool> CanDelete { get; set; }
        public int Version { get; set; }
        public Nullable<System.Guid> VersionAntecedentID { get; set; }
        public Nullable<int> VersionCertainty { get; set; }
        public Nullable<System.Guid> VersionWorkflowInstanceID { get; set; }
        public Nullable<System.Guid> VersionUpdatedBy { get; set; }
        public Nullable<System.Guid> VersionDeletedBy { get; set; }
        public Nullable<System.Guid> VersionOwnerContactID { get; set; }
        public Nullable<System.Guid> VersionOwnerCompanyID { get; set; }
        public Nullable<System.DateTime> VersionUpdated { get; set; }
    
        public virtual Company X_Company { get; set; }
        public virtual Company X_Company1 { get; set; }
        public virtual Contact X_Contact { get; set; }
        public virtual Contact X_Contact1 { get; set; }
    }
}
