using System;
using System.Linq.Expressions;

namespace YumaKeyencePrinterComm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            Thread th = new Thread(() =>
            {
                Listen();
            });
            th.IsBackground = true;
            th.Start();
        }
        private void Listen()
        {
            while (true)
            {
                if (txtPath.Text != "")
                {
                    try
                    {
                        using (FileStream fs = new FileStream(txtPath.Text, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                        {
                            using (StreamReader sr = new StreamReader(fs))
                            {
                                string ln;
                                while ((ln = sr.ReadLine()) != null)
                                {
                                    string[] parameters = ln.Split('=');
                                    // Replace "Run Code" with actual parameter
                                    if (parameters[0] == "Run Code")
                                    {
                                        lblCode.Invoke((MethodInvoker)(() => lblCode.Text = parameters[1]));
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {

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

    }
}