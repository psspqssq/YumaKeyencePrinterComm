using libplctag.DataTypes;
using libplctag;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Linq.Expressions;

namespace YumaKeyencePrinterComm
{
    public partial class frmMain : Form
    {

        string globalFilePath = "";
        string globalIP = "";
        public frmMain()
        {
            InitializeComponent();
            InitializeApplication();
            //A new process is started in a background thread so it doesn't blocks form UI and the children threads are killed on form close
            Thread th = new Thread(() =>
            {
                Listen();
            });
            th.IsBackground = true;
            th.Start();
        }
        private void InitializeApplication()
        {

            globalFilePath = Properties.Settings.Default.LineFilePath;
            globalIP = Properties.Settings.Default.PLCIP;
            txtIP.Text = globalIP;
            txtPath.Text = globalFilePath;
        }
        private void Listen()
        {
            string oldString = "";
            while (true)
            {
                if (txtPath.Text != "")
                {
                    try
                    {
                        //File mode in readonly and shared so it doesn't block access from another program to modify it
                        using (FileStream fs = new FileStream(globalFilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                        {
                            using (StreamReader sr = new StreamReader(fs))
                            {
                                string ln;
                                while ((ln = sr.ReadLine()) != null)
                                {
                                    string[] parameters = ln.Split('=');
                                    // Replace "Run Code" with actual parameter
                                    if (parameters[0] == "Manual Text" && oldString != parameters[1])
                                    {
                                        lblCode.Invoke((MethodInvoker)(() => lblCode.Text = parameters[1]));
                                        var stringTag = new Tag<StringPlcMapper, string[]>()
                                        {
                                            Name = "PrintCodeTest",
                                            Gateway = globalIP,
                                            Path = "1,0",
                                            Protocol = Protocol.ab_eip,
                                            PlcType = PlcType.ControlLogix,
                                        };
                                        string[] WritingText = new string[1];
                                        WritingText[0] = parameters[1];
                                        stringTag.Write(WritingText);
                                        oldString = parameters[1];
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex);
                    }
                }
                Thread.Sleep(50);
            }
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtPath.Text = openFileDialog.FileName;
            }
        }

        private void txtIP_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.PLCIP = txtIP.Text;
            Properties.Settings.Default.Save();
        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.LineFilePath = txtPath.Text;
            Properties.Settings.Default.Save();
        }
    }
}