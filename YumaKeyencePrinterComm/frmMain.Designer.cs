namespace YumaKeyencePrinterComm
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCode = new Label();
            label2 = new Label();
            tcMainPanel = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            txtPath = new TextBox();
            label1 = new Label();
            btnFile = new Button();
            txtIP = new TextBox();
            label3 = new Label();
            tcMainPanel.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCode.Location = new Point(122, 69);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(0, 21);
            lblCode.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 42);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 4;
            label2.Text = "Code";
            // 
            // tcMainPanel
            // 
            tcMainPanel.Controls.Add(tabPage1);
            tcMainPanel.Controls.Add(tabPage2);
            tcMainPanel.Location = new Point(12, 12);
            tcMainPanel.Name = "tcMainPanel";
            tcMainPanel.SelectedIndex = 0;
            tcMainPanel.Size = new Size(289, 185);
            tcMainPanel.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(lblCode);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(281, 157);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Printer Code";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(txtIP);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(txtPath);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(btnFile);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(281, 157);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Settings";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtPath
            // 
            txtPath.Location = new Point(72, 19);
            txtPath.Name = "txtPath";
            txtPath.ReadOnly = true;
            txtPath.Size = new Size(160, 23);
            txtPath.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 22);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 4;
            label1.Text = "Source File";
            // 
            // btnFile
            // 
            btnFile.Location = new Point(238, 19);
            btnFile.Name = "btnFile";
            btnFile.Size = new Size(38, 24);
            btnFile.TabIndex = 5;
            btnFile.Text = "...";
            btnFile.UseVisualStyleBackColor = true;
            // 
            // txtIP
            // 
            txtIP.Location = new Point(72, 48);
            txtIP.Name = "txtIP";
            txtIP.ReadOnly = true;
            txtIP.Size = new Size(160, 23);
            txtIP.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 51);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 7;
            label3.Text = "IP Address";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 209);
            Controls.Add(tcMainPanel);
            Name = "frmMain";
            Text = "Printer Settings";
            tcMainPanel.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblCode;
        private Label label2;
        private TabControl tcMainPanel;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox txtPath;
        private Label label1;
        private Button btnFile;
        private TextBox txtIP;
        private Label label3;
    }
}