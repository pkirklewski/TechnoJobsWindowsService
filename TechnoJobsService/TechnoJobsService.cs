using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace TechnoJobsService
{
    public partial class TechnoJobsService : ServiceBase
    {
        // Added code ----------------------------------
        private System.ComponentModel.IContainer components;
        private System.Diagnostics.EventLog eventLog1;
        // End of Added Code ---------------------------

        public TechnoJobsService()
        {
            InitializeComponent();
        // Added code ----------------------------------
        eventLog1 = new System.Diagnostics.EventLog();
            if (!System.Diagnostics.EventLog.SourceExists("MySource"))
            {
                System.Diagnostics.EventLog.CreateEventSource(
                    "MySource", "MyNewLog");
            }
            eventLog1.Source = "MySource";
            eventLog1.Log = "MyNewLog";


            // End of Added Code ---------------------------

        }

        protected override void OnStart(string[] args)
        {
        }

        protected override void OnStop()
        {
        }
    }
}
