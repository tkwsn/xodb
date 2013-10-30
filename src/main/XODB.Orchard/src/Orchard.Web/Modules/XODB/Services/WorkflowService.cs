﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Ionic.Zip;
using JetBrains.Annotations;
using Orchard.ContentManagement;
using Orchard.FileSystems.Media;
using Orchard.Localization;
using XODB.Models;
using Orchard.Security;
using Orchard.Settings;
using Orchard.Validation;
using Orchard;
using Orchard.Media.Models;
using Orchard.Media.Services;
using System.Transactions;
using Orchard.Logging;
using XODB.Import;
using XODB.ViewModels;
using System.Threading.Tasks;
using XODB.Reports;
using XODB.Import.FormatSpecification;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using XODB.Helpers;
using Orchard.Tasks.Scheduling;

using System.Runtime.DurableInstancing;
using System.ServiceModel.Activities.Description;
using System.Activities.DurableInstancing;
using System.Activities;
using XODB.Workflow;
using System.Xml.Linq;
using System.Activities.XamlIntegration;

namespace XODB.Services {

    [UsedImplicitly]
    public class WorkflowService : IWorkflowService {

        private static readonly XName workflowHostTypePropertyName = XNamespace.Get("urn:schemas-microsoft-com:System.Activities/4.0/properties").GetName("WorkflowHostType");
        
        private readonly IUsersService _users;
        private readonly WorkflowApplication _wfApp;

        public WorkflowService(
            IUsersService users
          
          )
        {            
            _users = users;
            T = NullLocalizer.Instance;
            Logger = NullLogger.Instance;
            SqlWorkflowInstanceStore store = new SqlWorkflowInstanceStore(_users.ApplicationConnectionString);            
            _wfApp = new WorkflowApplication(new XODB.Workflow.AssignResponsibility());
            _wfApp.InstanceStore = store;       
            InstanceHandle handle = store.CreateInstanceHandle(null); 
            XName wfHostTypeName = XName.Get("XODB", _users.ApplicationID.ToString());
            var cmd = new CreateWorkflowOwnerCommand 
            {
                 InstanceOwnerMetadata =
                    {
                        {workflowHostTypePropertyName, new InstanceValue(wfHostTypeName)}
                    }
            };
            InstanceOwner owner = store.Execute(handle, cmd , TimeSpan.MaxValue).InstanceOwner; 
            store.DefaultInstanceOwner = owner;
            handle.Free();

            _wfApp.PersistableIdle = delegate(WorkflowApplicationIdleEventArgs e)
            {
                return PersistableIdleAction.Persist;
            };

        }

        public Localizer T { get; set; }
        public ILogger Logger { get; set; }
                

        private static Activity LoadActivity(string path)
        {
            using (StringReader rdr = new StringReader(string.Join("\n", File.ReadAllLines(path))))
            {
                return ActivityXamlServices.Load(rdr);
            }
        }

        public Guid AssignResponsibility(Guid companyID, Guid contactID, Guid? tryWorkflowID = null, Guid referenceID = default(Guid), string referenceClass = null, string referenceTable = null)
        {
            if (tryWorkflowID.HasValue && tryWorkflowID.Value != default(Guid))
                _wfApp.Load(tryWorkflowID.Value);
            else
                _wfApp.LoadRunnableInstance();
            _wfApp.Run();
           //WorkflowInvoker.Invoke(
            
            return default(Guid); //Real Workflow ID
        }

        public string CurrentState
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Guid GetResponsibleCompanyID(Guid? workflowID)
        {
            return default(Guid);
        }

        public Guid GetResponsibleContactID(Guid? workflowID)
        {
            return default(Guid);
        }

        public void CompleteProcess(Guid companyID, Guid contactID, Guid workflowID)
        {
        }


       
    }
}
