namespace EM.UI
{
    partial class ElasticSearchMerge
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ip_toTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.port_toTextBox = new MetroFramework.Controls.MetroTextBox();
            this.toPingTest = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.port_fromTextBox = new MetroFramework.Controls.MetroTextBox();
            this.ip_fromTextBox = new MetroFramework.Controls.MetroTextBox();
            this.fromPingTest = new MetroFramework.Controls.MetroButton();
            this.startMergeProcess = new MetroFramework.Controls.MetroButton();
            this.mergeProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.toPingResult = new MetroFramework.Controls.MetroLabel();
            this.fromPingResult = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.progressLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // ip_toTextBox
            // 
            // 
            // 
            // 
            this.ip_toTextBox.CustomButton.Image = null;
            this.ip_toTextBox.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.ip_toTextBox.CustomButton.Name = "";
            this.ip_toTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ip_toTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ip_toTextBox.CustomButton.TabIndex = 1;
            this.ip_toTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ip_toTextBox.CustomButton.UseSelectable = true;
            this.ip_toTextBox.CustomButton.Visible = false;
            this.ip_toTextBox.Lines = new string[0];
            this.ip_toTextBox.Location = new System.Drawing.Point(185, 127);
            this.ip_toTextBox.MaxLength = 32767;
            this.ip_toTextBox.Name = "ip_toTextBox";
            this.ip_toTextBox.PasswordChar = '\0';
            this.ip_toTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ip_toTextBox.SelectedText = "";
            this.ip_toTextBox.SelectionLength = 0;
            this.ip_toTextBox.SelectionStart = 0;
            this.ip_toTextBox.ShortcutsEnabled = true;
            this.ip_toTextBox.Size = new System.Drawing.Size(154, 23);
            this.ip_toTextBox.TabIndex = 0;
            this.ip_toTextBox.UseSelectable = true;
            this.ip_toTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ip_toTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(66, 120);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(20, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "IP";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(145, 127);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(12, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = ":";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(66, 169);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(43, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "PORT";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(145, 169);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(12, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = ":";
            // 
            // port_toTextBox
            // 
            // 
            // 
            // 
            this.port_toTextBox.CustomButton.Image = null;
            this.port_toTextBox.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.port_toTextBox.CustomButton.Name = "";
            this.port_toTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.port_toTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.port_toTextBox.CustomButton.TabIndex = 1;
            this.port_toTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.port_toTextBox.CustomButton.UseSelectable = true;
            this.port_toTextBox.CustomButton.Visible = false;
            this.port_toTextBox.Lines = new string[0];
            this.port_toTextBox.Location = new System.Drawing.Point(185, 169);
            this.port_toTextBox.MaxLength = 32767;
            this.port_toTextBox.Name = "port_toTextBox";
            this.port_toTextBox.PasswordChar = '\0';
            this.port_toTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.port_toTextBox.SelectedText = "";
            this.port_toTextBox.SelectionLength = 0;
            this.port_toTextBox.SelectionStart = 0;
            this.port_toTextBox.ShortcutsEnabled = true;
            this.port_toTextBox.Size = new System.Drawing.Size(154, 23);
            this.port_toTextBox.TabIndex = 5;
            this.port_toTextBox.UseSelectable = true;
            this.port_toTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.port_toTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // toPingTest
            // 
            this.toPingTest.Location = new System.Drawing.Point(66, 222);
            this.toPingTest.Name = "toPingTest";
            this.toPingTest.Size = new System.Drawing.Size(273, 29);
            this.toPingTest.TabIndex = 6;
            this.toPingTest.Text = "PING";
            this.toPingTest.UseSelectable = true;
            this.toPingTest.Click += new System.EventHandler(this.toPingTest_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(495, 169);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(12, 19);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = ":";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(416, 169);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(43, 19);
            this.metroLabel6.TabIndex = 9;
            this.metroLabel6.Text = "PORT";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(495, 127);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(12, 19);
            this.metroLabel7.TabIndex = 8;
            this.metroLabel7.Text = ":";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(416, 127);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(20, 19);
            this.metroLabel8.TabIndex = 7;
            this.metroLabel8.Text = "IP";
            // 
            // port_fromTextBox
            // 
            // 
            // 
            // 
            this.port_fromTextBox.CustomButton.Image = null;
            this.port_fromTextBox.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.port_fromTextBox.CustomButton.Name = "";
            this.port_fromTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.port_fromTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.port_fromTextBox.CustomButton.TabIndex = 1;
            this.port_fromTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.port_fromTextBox.CustomButton.UseSelectable = true;
            this.port_fromTextBox.CustomButton.Visible = false;
            this.port_fromTextBox.Lines = new string[0];
            this.port_fromTextBox.Location = new System.Drawing.Point(535, 169);
            this.port_fromTextBox.MaxLength = 32767;
            this.port_fromTextBox.Name = "port_fromTextBox";
            this.port_fromTextBox.PasswordChar = '\0';
            this.port_fromTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.port_fromTextBox.SelectedText = "";
            this.port_fromTextBox.SelectionLength = 0;
            this.port_fromTextBox.SelectionStart = 0;
            this.port_fromTextBox.ShortcutsEnabled = true;
            this.port_fromTextBox.Size = new System.Drawing.Size(154, 23);
            this.port_fromTextBox.TabIndex = 12;
            this.port_fromTextBox.UseSelectable = true;
            this.port_fromTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.port_fromTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ip_fromTextBox
            // 
            // 
            // 
            // 
            this.ip_fromTextBox.CustomButton.Image = null;
            this.ip_fromTextBox.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.ip_fromTextBox.CustomButton.Name = "";
            this.ip_fromTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ip_fromTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ip_fromTextBox.CustomButton.TabIndex = 1;
            this.ip_fromTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ip_fromTextBox.CustomButton.UseSelectable = true;
            this.ip_fromTextBox.CustomButton.Visible = false;
            this.ip_fromTextBox.Lines = new string[0];
            this.ip_fromTextBox.Location = new System.Drawing.Point(535, 127);
            this.ip_fromTextBox.MaxLength = 32767;
            this.ip_fromTextBox.Name = "ip_fromTextBox";
            this.ip_fromTextBox.PasswordChar = '\0';
            this.ip_fromTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ip_fromTextBox.SelectedText = "";
            this.ip_fromTextBox.SelectionLength = 0;
            this.ip_fromTextBox.SelectionStart = 0;
            this.ip_fromTextBox.ShortcutsEnabled = true;
            this.ip_fromTextBox.Size = new System.Drawing.Size(154, 23);
            this.ip_fromTextBox.TabIndex = 11;
            this.ip_fromTextBox.UseSelectable = true;
            this.ip_fromTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ip_fromTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // fromPingTest
            // 
            this.fromPingTest.Location = new System.Drawing.Point(416, 222);
            this.fromPingTest.Name = "fromPingTest";
            this.fromPingTest.Size = new System.Drawing.Size(273, 29);
            this.fromPingTest.TabIndex = 13;
            this.fromPingTest.Text = "PING";
            this.fromPingTest.UseSelectable = true;
            this.fromPingTest.Click += new System.EventHandler(this.fromPingTest_Click);
            // 
            // startMergeProcess
            // 
            this.startMergeProcess.Location = new System.Drawing.Point(66, 344);
            this.startMergeProcess.Name = "startMergeProcess";
            this.startMergeProcess.Size = new System.Drawing.Size(623, 36);
            this.startMergeProcess.TabIndex = 16;
            this.startMergeProcess.Text = "START MERGE PROCESS";
            this.startMergeProcess.UseSelectable = true;
            this.startMergeProcess.Click += new System.EventHandler(this.startMergeProcess_Click);
            // 
            // mergeProgressBar
            // 
            this.mergeProgressBar.Location = new System.Drawing.Point(66, 424);
            this.mergeProgressBar.Name = "mergeProgressBar";
            this.mergeProgressBar.Size = new System.Drawing.Size(623, 23);
            this.mergeProgressBar.TabIndex = 17;
            this.mergeProgressBar.Visible = false;
            // 
            // toPingResult
            // 
            this.toPingResult.AutoSize = true;
            this.toPingResult.Location = new System.Drawing.Point(145, 271);
            this.toPingResult.Name = "toPingResult";
            this.toPingResult.Size = new System.Drawing.Size(0, 0);
            this.toPingResult.TabIndex = 14;
            // 
            // fromPingResult
            // 
            this.fromPingResult.AutoSize = true;
            this.fromPingResult.Location = new System.Drawing.Point(495, 271);
            this.fromPingResult.Name = "fromPingResult";
            this.fromPingResult.Size = new System.Drawing.Size(0, 0);
            this.fromPingResult.TabIndex = 15;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(66, 271);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(84, 19);
            this.metroLabel9.TabIndex = 18;
            this.metroLabel9.Text = "Ping Result : ";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(416, 271);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(84, 19);
            this.metroLabel10.TabIndex = 19;
            this.metroLabel10.Text = "Ping Result : ";
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Location = new System.Drawing.Point(335, 402);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(0, 0);
            this.progressLabel.TabIndex = 20;
            this.progressLabel.Visible = false;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel11.Location = new System.Drawing.Point(145, 71);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(64, 25);
            this.metroLabel11.TabIndex = 21;
            this.metroLabel11.Text = "FROM";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel12.Location = new System.Drawing.Point(573, 71);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(36, 25);
            this.metroLabel12.TabIndex = 22;
            this.metroLabel12.Text = "TO";
            // 
            // ElasticSearchMerge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 519);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.mergeProgressBar);
            this.Controls.Add(this.startMergeProcess);
            this.Controls.Add(this.fromPingResult);
            this.Controls.Add(this.toPingResult);
            this.Controls.Add(this.fromPingTest);
            this.Controls.Add(this.port_fromTextBox);
            this.Controls.Add(this.ip_fromTextBox);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.toPingTest);
            this.Controls.Add(this.port_toTextBox);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.ip_toTextBox);
            this.Name = "ElasticSearchMerge";
            this.Text = "Elasticsearch Merge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox ip_toTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox port_toTextBox;
        private MetroFramework.Controls.MetroButton toPingTest;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox port_fromTextBox;
        private MetroFramework.Controls.MetroTextBox ip_fromTextBox;
        private MetroFramework.Controls.MetroButton fromPingTest;
        private MetroFramework.Controls.MetroButton startMergeProcess;
        private MetroFramework.Controls.MetroProgressBar mergeProgressBar;
        private MetroFramework.Controls.MetroLabel toPingResult;
        private MetroFramework.Controls.MetroLabel fromPingResult;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel progressLabel;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
    }
}

