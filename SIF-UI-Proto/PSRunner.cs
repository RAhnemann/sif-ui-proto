using System;
using System.Drawing;
using System.IO;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIF_UI_Proto
{
    public partial class PSRunner : Form
    {
        private PowerShell m_PSInst;
        private Runspace m_Runspace;

        public PSRunner()
        {
            InitializeComponent();
            InitialSessionState init = InitialSessionState.CreateDefault();
            init.ImportPSModule(new[] { "WebAdministration" });
            m_Runspace = RunspaceFactory.CreateRunspace(init);
            m_PSInst = PowerShell.Create(RunspaceMode.NewRunspace);
            m_PSInst.Runspace = m_Runspace;
            m_Runspace.Open();
            
        }


        public void AddError(string value)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(AddError), value);
                return;
            }

            errorTextbox.AppendText(value, Color.Red);
            allOutputTextbox.AppendText(value, Color.Red);

            Application.DoEvents();
        }

        public void AddWarning(string value)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(AddWarning), value);
                return;
            }

            warningTextbox.AppendText(value, Color.Gold);
            allOutputTextbox.AppendText(value, Color.Gold);

            Application.DoEvents();
        }


        public void AddInfo(string value)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(AddInfo), value);
                return;
            }

            infoTextbox.AppendText(value, Color.White);
            allOutputTextbox.AppendText(value, Color.White);

            Application.DoEvents();
        }


        public void AddDebug(string value)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(AddDebug), value);
                return;
            }

            debugTextbox.AppendText(value, Color.White);
            allOutputTextbox.AppendText(value, Color.White);

            Application.DoEvents();
        }

        public void Run(string fileName)
        {
            var start = DateTime.Now;

            //We're gonna need to grant some permissions...just for this process

            try
            {
             
                m_PSInst.Streams.Error.DataAdded += (sender, args) =>
                {
                    var psData = (PSDataCollection<ErrorRecord>)sender;

                    var results = psData.ReadAll();

                    foreach (var result in results)
                    {
                        AddError(result.ToString());
                    }
                };

                m_PSInst.Streams.Warning.DataAdded += (sender, args) =>
                {
                    var psData = (PSDataCollection<WarningRecord>)sender;

                    var results = psData.ReadAll();

                    foreach (var result in results)
                    {
                        AddWarning(result.ToString());
                    }
                };

                m_PSInst.Streams.Information.DataAdded += (sender, args) =>
                {
                    var psData = (PSDataCollection<InformationRecord>)sender;

                    var results = psData.ReadAll();

                    foreach (var result in results)
                    {
                        AddInfo(result.ToString());
                    }
                };


                m_PSInst.Streams.Debug.DataAdded += (sender, args) =>
                {
                    var psData = (PSDataCollection<DebugRecord>)sender;

                    var results = psData.ReadAll();

                    foreach (var result in results)
                    {
                        AddDebug(result.ToString());
                    }
                };

                m_PSInst.Streams.Verbose.DataAdded += (sender, args) =>
                {
                    var psData = (PSDataCollection<VerboseRecord>)sender;

                    var results = psData.ReadAll();

                    foreach (var result in results)
                    {
                        AddDebug(result.ToString());
                    }
                };


                m_PSInst.InvocationStateChanged += Powershell_InvocationStateChanged;

                m_PSInst.AddScript("Set-ExecutionPolicy -Scope Process -ExecutionPolicy Unrestricted");
                m_PSInst.Invoke();
                // m_PSInst.AddCommand("Get-WebBinding");
                //m_PSInst.AddCommand("Write-Information").AddParameter("MessageData", "Test it");
                //m_PSInst.Invoke();

                m_PSInst.AddScript(@"Import-Module WebAdministration -Force;");
               // m_PSInst.Invoke();

               // m_PSInst.AddCommand("Write-Information").AddParameter("MessageData", "Test it2");
               // m_PSInst.Invoke();
                 m_PSInst.AddScript(fileName);

                //m_PSInst.Streams.Progress.DataAdded += (sender, args) =>
                //{
                //    var psData = (PSDataCollection<ProgressRecord>)sender;

                //    var results = psData.ReadAll();

                //    foreach (var result in results)
                //    {
                //        AddDebug(result.ToString());
                //    }
                //};

                // Invoke the pipeline asynchronously.
                 var asyncResult = m_PSInst.BeginInvoke();

                while (!asyncResult.IsCompleted)
                {
                    Thread.Sleep(500);
                    Application.DoEvents();
                    
                }
                //  var s = Task.Factory.FromAsync(m_PSInst.BeginInvoke(), pResult => m_PSInst.EndInvoke(pResult));
                


                //  MessageBox.Show($"Done executing in {elapsed.ToReadableString()}");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Running Script: {ex.Message}", "MERP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Powershell_InvocationStateChanged(object sender, PSInvocationStateChangedEventArgs e)
        {
            switch (e.InvocationStateInfo.State)
            {
                case PSInvocationState.Failed:
                    AddError("Errored out: " + e.InvocationStateInfo.Reason.Message);
                    break;
                default:
                    AddInfo(e.InvocationStateInfo.State.ToString());
                    break;
            }
        }


        private void PSRunner_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            outputTabControl.SelectedTab = allTab;

            Run(Path.Combine(Environment.CurrentDirectory, "SIFless.ps1"));
        }

        private void PSRunner_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_PSInst.InvocationStateInfo.State == PSInvocationState.Running)
                m_PSInst.Stop();
            m_PSInst.Dispose();
        }
    }
}
