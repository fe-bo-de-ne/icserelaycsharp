namespace TestRelay
{
    partial class frmIcStationRelay
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
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnInit = new System.Windows.Forms.Button();
            this.btnRequestID = new System.Windows.Forms.Button();
            this.cbSerialPorts = new System.Windows.Forms.ComboBox();
            this.btnLoadSerialPorts = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbrelays = new System.Windows.Forms.GroupBox();
            this.btnSendRelays = new System.Windows.Forms.Button();
            this.cbRelay6 = new System.Windows.Forms.CheckBox();
            this.cbRelay7 = new System.Windows.Forms.CheckBox();
            this.cbRelay8 = new System.Windows.Forms.CheckBox();
            this.cbRelay5 = new System.Windows.Forms.CheckBox();
            this.cbRelay4 = new System.Windows.Forms.CheckBox();
            this.cbRelay3 = new System.Windows.Forms.CheckBox();
            this.cbRelay2 = new System.Windows.Forms.CheckBox();
            this.cbRelay1 = new System.Windows.Forms.CheckBox();
            this.udFreq = new System.Windows.Forms.NumericUpDown();
            this.btnAlterna = new System.Windows.Forms.Button();
            this.btnStopAlternate = new System.Windows.Forms.Button();
            this.bwAlterna = new System.ComponentModel.BackgroundWorker();
            this.pbRelay = new System.Windows.Forms.PictureBox();
            this.gbrelays.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRelay)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(27, 296);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(617, 134);
            this.txtOutput.TabIndex = 14;
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(27, 146);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(121, 23);
            this.btnInit.TabIndex = 4;
            this.btnInit.Text = "Send Init Code*";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // btnRequestID
            // 
            this.btnRequestID.Location = new System.Drawing.Point(27, 95);
            this.btnRequestID.Name = "btnRequestID";
            this.btnRequestID.Size = new System.Drawing.Size(121, 23);
            this.btnRequestID.TabIndex = 3;
            this.btnRequestID.Text = "Request ID*";
            this.btnRequestID.UseVisualStyleBackColor = true;
            this.btnRequestID.Click += new System.EventHandler(this.btnDeinit_Click);
            // 
            // cbSerialPorts
            // 
            this.cbSerialPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSerialPorts.FormattingEnabled = true;
            this.cbSerialPorts.Location = new System.Drawing.Point(27, 60);
            this.cbSerialPorts.Name = "cbSerialPorts";
            this.cbSerialPorts.Size = new System.Drawing.Size(121, 21);
            this.cbSerialPorts.TabIndex = 1;
            // 
            // btnLoadSerialPorts
            // 
            this.btnLoadSerialPorts.Location = new System.Drawing.Point(155, 58);
            this.btnLoadSerialPorts.Name = "btnLoadSerialPorts";
            this.btnLoadSerialPorts.Size = new System.Drawing.Size(121, 23);
            this.btnLoadSerialPorts.TabIndex = 2;
            this.btnLoadSerialPorts.Text = "Refresh Serial Ports";
            this.btnLoadSerialPorts.UseVisualStyleBackColor = true;
            this.btnLoadSerialPorts.Click += new System.EventHandler(this.btnLoadSerialPorts_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "*  (works only when just plugged in, before the init command is sent)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "*  (send at least once, otherwise relays won\'t work!)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Choose the right serial port (look in device manager if unsure)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Output";
            // 
            // gbrelays
            // 
            this.gbrelays.Controls.Add(this.btnSendRelays);
            this.gbrelays.Controls.Add(this.cbRelay6);
            this.gbrelays.Controls.Add(this.cbRelay7);
            this.gbrelays.Controls.Add(this.cbRelay8);
            this.gbrelays.Controls.Add(this.cbRelay5);
            this.gbrelays.Controls.Add(this.cbRelay4);
            this.gbrelays.Controls.Add(this.cbRelay3);
            this.gbrelays.Controls.Add(this.cbRelay2);
            this.gbrelays.Controls.Add(this.cbRelay1);
            this.gbrelays.Location = new System.Drawing.Point(27, 188);
            this.gbrelays.Name = "gbrelays";
            this.gbrelays.Size = new System.Drawing.Size(617, 78);
            this.gbrelays.TabIndex = 15;
            this.gbrelays.TabStop = false;
            this.gbrelays.Text = "Switch Relays";
            // 
            // btnSendRelays
            // 
            this.btnSendRelays.Location = new System.Drawing.Point(12, 49);
            this.btnSendRelays.Name = "btnSendRelays";
            this.btnSendRelays.Size = new System.Drawing.Size(156, 23);
            this.btnSendRelays.TabIndex = 13;
            this.btnSendRelays.Text = "Send Combined Command";
            this.btnSendRelays.UseVisualStyleBackColor = true;
            this.btnSendRelays.Click += new System.EventHandler(this.btnSendRelays_Click);
            // 
            // cbRelay6
            // 
            this.cbRelay6.AutoSize = true;
            this.cbRelay6.Location = new System.Drawing.Point(359, 24);
            this.cbRelay6.Name = "cbRelay6";
            this.cbRelay6.Size = new System.Drawing.Size(62, 17);
            this.cbRelay6.TabIndex = 10;
            this.cbRelay6.Text = "Relay 6";
            this.cbRelay6.UseVisualStyleBackColor = true;
            // 
            // cbRelay7
            // 
            this.cbRelay7.AutoSize = true;
            this.cbRelay7.Location = new System.Drawing.Point(427, 24);
            this.cbRelay7.Name = "cbRelay7";
            this.cbRelay7.Size = new System.Drawing.Size(62, 17);
            this.cbRelay7.TabIndex = 11;
            this.cbRelay7.Text = "Relay 7";
            this.cbRelay7.UseVisualStyleBackColor = true;
            // 
            // cbRelay8
            // 
            this.cbRelay8.AutoSize = true;
            this.cbRelay8.Location = new System.Drawing.Point(495, 24);
            this.cbRelay8.Name = "cbRelay8";
            this.cbRelay8.Size = new System.Drawing.Size(62, 17);
            this.cbRelay8.TabIndex = 12;
            this.cbRelay8.Text = "Relay 8";
            this.cbRelay8.UseVisualStyleBackColor = true;
            // 
            // cbRelay5
            // 
            this.cbRelay5.AutoSize = true;
            this.cbRelay5.Location = new System.Drawing.Point(291, 24);
            this.cbRelay5.Name = "cbRelay5";
            this.cbRelay5.Size = new System.Drawing.Size(62, 17);
            this.cbRelay5.TabIndex = 9;
            this.cbRelay5.Text = "Relay 5";
            this.cbRelay5.UseVisualStyleBackColor = true;
            // 
            // cbRelay4
            // 
            this.cbRelay4.AutoSize = true;
            this.cbRelay4.Location = new System.Drawing.Point(223, 24);
            this.cbRelay4.Name = "cbRelay4";
            this.cbRelay4.Size = new System.Drawing.Size(62, 17);
            this.cbRelay4.TabIndex = 8;
            this.cbRelay4.Text = "Relay 4";
            this.cbRelay4.UseVisualStyleBackColor = true;
            // 
            // cbRelay3
            // 
            this.cbRelay3.AutoSize = true;
            this.cbRelay3.Location = new System.Drawing.Point(155, 24);
            this.cbRelay3.Name = "cbRelay3";
            this.cbRelay3.Size = new System.Drawing.Size(62, 17);
            this.cbRelay3.TabIndex = 7;
            this.cbRelay3.Text = "Relay 3";
            this.cbRelay3.UseVisualStyleBackColor = true;
            // 
            // cbRelay2
            // 
            this.cbRelay2.AutoSize = true;
            this.cbRelay2.Location = new System.Drawing.Point(87, 24);
            this.cbRelay2.Name = "cbRelay2";
            this.cbRelay2.Size = new System.Drawing.Size(62, 17);
            this.cbRelay2.TabIndex = 6;
            this.cbRelay2.Text = "Relay 2";
            this.cbRelay2.UseVisualStyleBackColor = true;
            // 
            // cbRelay1
            // 
            this.cbRelay1.AutoSize = true;
            this.cbRelay1.Location = new System.Drawing.Point(19, 24);
            this.cbRelay1.Name = "cbRelay1";
            this.cbRelay1.Size = new System.Drawing.Size(62, 17);
            this.cbRelay1.TabIndex = 5;
            this.cbRelay1.Text = "Relay 1";
            this.cbRelay1.UseVisualStyleBackColor = true;
            // 
            // udFreq
            // 
            this.udFreq.Location = new System.Drawing.Point(282, 439);
            this.udFreq.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.udFreq.Name = "udFreq";
            this.udFreq.Size = new System.Drawing.Size(76, 20);
            this.udFreq.TabIndex = 16;
            this.udFreq.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // btnAlterna
            // 
            this.btnAlterna.Location = new System.Drawing.Point(114, 436);
            this.btnAlterna.Name = "btnAlterna";
            this.btnAlterna.Size = new System.Drawing.Size(162, 23);
            this.btnAlterna.TabIndex = 15;
            this.btnAlterna.Text = "Alternate R1/R2 w/ delay ms";
            this.btnAlterna.UseVisualStyleBackColor = true;
            this.btnAlterna.Click += new System.EventHandler(this.btnAlterna_Click);
            // 
            // btnStopAlternate
            // 
            this.btnStopAlternate.Location = new System.Drawing.Point(411, 436);
            this.btnStopAlternate.Name = "btnStopAlternate";
            this.btnStopAlternate.Size = new System.Drawing.Size(143, 23);
            this.btnStopAlternate.TabIndex = 17;
            this.btnStopAlternate.Text = "STOP Alternate R1/R2";
            this.btnStopAlternate.UseVisualStyleBackColor = true;
            this.btnStopAlternate.Click += new System.EventHandler(this.btnStopAlternate_Click);
            // 
            // bwAlterna
            // 
            this.bwAlterna.WorkerSupportsCancellation = true;
            this.bwAlterna.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwAlterna_DoWork);
            // 
            // pbRelay
            // 
            this.pbRelay.Image = global::TestRelay.Properties.Resources.relay_symbol;
            this.pbRelay.Location = new System.Drawing.Point(544, 32);
            this.pbRelay.Name = "pbRelay";
            this.pbRelay.Size = new System.Drawing.Size(76, 110);
            this.pbRelay.TabIndex = 19;
            this.pbRelay.TabStop = false;
            // 
            // frmIcStationRelay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 468);
            this.Controls.Add(this.pbRelay);
            this.Controls.Add(this.btnStopAlternate);
            this.Controls.Add(this.btnAlterna);
            this.Controls.Add(this.udFreq);
            this.Controls.Add(this.gbrelays);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoadSerialPorts);
            this.Controls.Add(this.cbSerialPorts);
            this.Controls.Add(this.btnRequestID);
            this.Controls.Add(this.btnInit);
            this.Controls.Add(this.txtOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmIcStationRelay";
            this.Text = "ICStation ICSE012A ICSE013A ICSE014A Tester - v1.01 26/8/2017 ";
            this.Load += new System.EventHandler(this.frmIcStationRelay_Load);
            this.gbrelays.ResumeLayout(false);
            this.gbrelays.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Button btnRequestID;
        private System.Windows.Forms.ComboBox cbSerialPorts;
        private System.Windows.Forms.Button btnLoadSerialPorts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbrelays;
        private System.Windows.Forms.Button btnSendRelays;
        private System.Windows.Forms.CheckBox cbRelay6;
        private System.Windows.Forms.CheckBox cbRelay7;
        private System.Windows.Forms.CheckBox cbRelay8;
        private System.Windows.Forms.CheckBox cbRelay5;
        private System.Windows.Forms.CheckBox cbRelay4;
        private System.Windows.Forms.CheckBox cbRelay3;
        private System.Windows.Forms.CheckBox cbRelay2;
        private System.Windows.Forms.CheckBox cbRelay1;
        private System.Windows.Forms.NumericUpDown udFreq;
        private System.Windows.Forms.Button btnAlterna;
        private System.Windows.Forms.Button btnStopAlternate;
        private System.ComponentModel.BackgroundWorker bwAlterna;
        private System.Windows.Forms.PictureBox pbRelay;
    }
}

