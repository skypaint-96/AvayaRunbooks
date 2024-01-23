namespace AvayaRunbooks.Service
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.ServiceProcess;
    using System.Text;
    using System.Threading.Tasks;

    public partial class AvayaWatcher : ServiceBase
    {
        public AvayaWatcher()
        {
            InitializeComponent();
        }

        public bool IsCallActive { get; private set; }

        protected override void OnStart(string[] args)
        {
            
        }
        protected override void OnStop()
        {
        }

        private FileSystemWatcher avayaDir { get; set; }

        private void fswEvent(object sender, FileSystemEventArgs e)
        {
            IsCallActive = !IsCallActive;
        }
    }
}
