//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XODBImportLib.DataModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class X_BlockModelMetadata
    {
        public System.Guid BlockModelMetadataID { get; set; }
        public System.Guid BlockModelID { get; set; }
        public System.Guid ParameterID { get; set; }
        public bool IsColumnData { get; set; }
        public string BlockModelMetadataText { get; set; }
        public Nullable<decimal> BlockModelMetadataValue { get; set; }
        public int Version { get; set; }
        public Nullable<System.Guid> VersionAntecedentID { get; set; }
        public Nullable<int> VersionCertainty { get; set; }
        public Nullable<System.Guid> VersionWorkflowInstanceID { get; set; }
        public Nullable<System.Guid> VersionUpdatedBy { get; set; }
        public Nullable<System.Guid> VersionDeletedBy { get; set; }
        public Nullable<System.Guid> VersionOwnerContactID { get; set; }
        public Nullable<System.Guid> VersionOwnerCompanyID { get; set; }
        public Nullable<System.DateTime> VersionUpdated { get; set; }
    
        public virtual X_BlockModel X_BlockModel { get; set; }
        public virtual X_Parameter X_Parameter { get; set; }
    }
}
