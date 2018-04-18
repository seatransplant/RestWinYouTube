namespace RestWinYouTube
{
    partial class Authenticating
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
            this.bRecord = new System.Windows.Forms.Button();
            this.numValues = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDeserialized = new System.Windows.Forms.TextBox();
            this.txtJSONOutput = new System.Windows.Forms.TextBox();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.btnDeseralize = new System.Windows.Forms.Button();
            this.btnClearDebug = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RequestSpecific = new System.Windows.Forms.Button();
            this.Specifics = new System.Windows.Forms.GroupBox();
            this.FilterID = new System.Windows.Forms.TextBox();
            this.FilterRadio = new System.Windows.Forms.RadioButton();
            this.bRestartProcess = new System.Windows.Forms.Button();
            this.bUseAuthentication = new System.Windows.Forms.Button();
            this.gLocation = new System.Windows.Forms.GroupBox();
            this.TMobileChoice = new System.Windows.Forms.RadioButton();
            this.SeaTransplantChoice = new System.Windows.Forms.RadioButton();
            this.ThistleChoice = new System.Windows.Forms.RadioButton();
            this.gAuth = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rBtnTechNone = new System.Windows.Forms.RadioButton();
            this.radNCC = new System.Windows.Forms.RadioButton();
            this.radRoll = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rBtnAuthNone = new System.Windows.Forms.RadioButton();
            this.radNTLM = new System.Windows.Forms.RadioButton();
            this.radBasic = new System.Windows.Forms.RadioButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtRequestURI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExecutionURI = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MaxResults = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numValues)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Specifics.SuspendLayout();
            this.gLocation.SuspendLayout();
            this.gAuth.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // bRecord
            // 
            this.bRecord.Enabled = false;
            this.bRecord.Location = new System.Drawing.Point(11, 338);
            this.bRecord.Name = "bRecord";
            this.bRecord.Size = new System.Drawing.Size(86, 28);
            this.bRecord.TabIndex = 35;
            this.bRecord.Text = "Show Record";
            this.bRecord.UseVisualStyleBackColor = true;
            this.bRecord.Click += new System.EventHandler(this.bRecord_Click);
            // 
            // numValues
            // 
            this.numValues.Enabled = false;
            this.numValues.Location = new System.Drawing.Point(14, 312);
            this.numValues.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numValues.Name = "numValues";
            this.numValues.Size = new System.Drawing.Size(32, 20);
            this.numValues.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(11, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Record";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "JSON Output";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Debug Information";
            // 
            // txtDeserialized
            // 
            this.txtDeserialized.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDeserialized.Location = new System.Drawing.Point(116, 283);
            this.txtDeserialized.Multiline = true;
            this.txtDeserialized.Name = "txtDeserialized";
            this.txtDeserialized.Size = new System.Drawing.Size(1152, 205);
            this.txtDeserialized.TabIndex = 30;
            // 
            // txtJSONOutput
            // 
            this.txtJSONOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJSONOutput.Location = new System.Drawing.Point(116, 177);
            this.txtJSONOutput.Multiline = true;
            this.txtJSONOutput.Name = "txtJSONOutput";
            this.txtJSONOutput.Size = new System.Drawing.Size(1152, 100);
            this.txtJSONOutput.TabIndex = 29;
            // 
            // txtResponse
            // 
            this.txtResponse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResponse.Location = new System.Drawing.Point(116, 77);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ReadOnly = true;
            this.txtResponse.Size = new System.Drawing.Size(1152, 94);
            this.txtResponse.TabIndex = 28;
            // 
            // btnDeseralize
            // 
            this.btnDeseralize.Enabled = false;
            this.btnDeseralize.Location = new System.Drawing.Point(7, 204);
            this.btnDeseralize.Name = "btnDeseralize";
            this.btnDeseralize.Size = new System.Drawing.Size(90, 23);
            this.btnDeseralize.TabIndex = 36;
            this.btnDeseralize.Text = "Deserialize";
            this.btnDeseralize.UseVisualStyleBackColor = true;
            this.btnDeseralize.Click += new System.EventHandler(this.btnDeseralize_Click);
            // 
            // btnClearDebug
            // 
            this.btnClearDebug.Location = new System.Drawing.Point(7, 120);
            this.btnClearDebug.Name = "btnClearDebug";
            this.btnClearDebug.Size = new System.Drawing.Size(90, 23);
            this.btnClearDebug.TabIndex = 37;
            this.btnClearDebug.Text = "ClearDebug";
            this.btnClearDebug.UseVisualStyleBackColor = true;
            this.btnClearDebug.Click += new System.EventHandler(this.btnClearDebug_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtRequestURI);
            this.groupBox1.Controls.Add(this.Specifics);
            this.groupBox1.Controls.Add(this.bRestartProcess);
            this.groupBox1.Controls.Add(this.gLocation);
            this.groupBox1.Controls.Add(this.gAuth);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1280, 213);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // RequestSpecific
            // 
            this.RequestSpecific.Location = new System.Drawing.Point(411, 77);
            this.RequestSpecific.Name = "RequestSpecific";
            this.RequestSpecific.Size = new System.Drawing.Size(103, 23);
            this.RequestSpecific.TabIndex = 43;
            this.RequestSpecific.Text = "Request Specific";
            this.RequestSpecific.UseVisualStyleBackColor = true;
            this.RequestSpecific.Click += new System.EventHandler(this.RequestSpecific_Click);
            // 
            // Specifics
            // 
            this.Specifics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Specifics.Controls.Add(this.label8);
            this.Specifics.Controls.Add(this.MaxResults);
            this.Specifics.Controls.Add(this.FilterID);
            this.Specifics.Controls.Add(this.RequestSpecific);
            this.Specifics.Controls.Add(this.FilterRadio);
            this.Specifics.Enabled = false;
            this.Specifics.Location = new System.Drawing.Point(748, 15);
            this.Specifics.Name = "Specifics";
            this.Specifics.Size = new System.Drawing.Size(520, 186);
            this.Specifics.TabIndex = 42;
            this.Specifics.TabStop = false;
            this.Specifics.Text = "Specific Options";
            // 
            // FilterID
            // 
            this.FilterID.Location = new System.Drawing.Point(90, 17);
            this.FilterID.Name = "FilterID";
            this.FilterID.Size = new System.Drawing.Size(100, 20);
            this.FilterID.TabIndex = 1;
            // 
            // FilterRadio
            // 
            this.FilterRadio.AutoSize = true;
            this.FilterRadio.Location = new System.Drawing.Point(15, 20);
            this.FilterRadio.Name = "FilterRadio";
            this.FilterRadio.Size = new System.Drawing.Size(69, 17);
            this.FilterRadio.TabIndex = 0;
            this.FilterRadio.TabStop = true;
            this.FilterRadio.Text = "Use Filter";
            this.FilterRadio.UseVisualStyleBackColor = true;
            // 
            // bRestartProcess
            // 
            this.bRestartProcess.Location = new System.Drawing.Point(6, 21);
            this.bRestartProcess.Name = "bRestartProcess";
            this.bRestartProcess.Size = new System.Drawing.Size(109, 23);
            this.bRestartProcess.TabIndex = 41;
            this.bRestartProcess.Text = "Restart";
            this.bRestartProcess.UseVisualStyleBackColor = true;
            this.bRestartProcess.Click += new System.EventHandler(this.bRestartProcess_Click);
            // 
            // bUseAuthentication
            // 
            this.bUseAuthentication.Location = new System.Drawing.Point(392, 61);
            this.bUseAuthentication.Name = "bUseAuthentication";
            this.bUseAuthentication.Size = new System.Drawing.Size(109, 23);
            this.bUseAuthentication.TabIndex = 39;
            this.bUseAuthentication.Text = "Request Simple";
            this.bUseAuthentication.UseVisualStyleBackColor = true;
            this.bUseAuthentication.Click += new System.EventHandler(this.bUseAuthentication_Click);
            // 
            // gLocation
            // 
            this.gLocation.Controls.Add(this.TMobileChoice);
            this.gLocation.Controls.Add(this.SeaTransplantChoice);
            this.gLocation.Controls.Add(this.ThistleChoice);
            this.gLocation.Location = new System.Drawing.Point(7, 69);
            this.gLocation.Name = "gLocation";
            this.gLocation.Size = new System.Drawing.Size(213, 100);
            this.gLocation.TabIndex = 40;
            this.gLocation.TabStop = false;
            this.gLocation.Text = "Location";
            // 
            // TMobileChoice
            // 
            this.TMobileChoice.AutoSize = true;
            this.TMobileChoice.Location = new System.Drawing.Point(21, 71);
            this.TMobileChoice.Name = "TMobileChoice";
            this.TMobileChoice.Size = new System.Drawing.Size(89, 17);
            this.TMobileChoice.TabIndex = 2;
            this.TMobileChoice.Text = "T-Mobile Item";
            this.TMobileChoice.UseVisualStyleBackColor = true;
            this.TMobileChoice.CheckedChanged += new System.EventHandler(this.PopulateAndUpdateURI);
            // 
            // SeaTransplantChoice
            // 
            this.SeaTransplantChoice.AutoSize = true;
            this.SeaTransplantChoice.Location = new System.Drawing.Point(21, 48);
            this.SeaTransplantChoice.Name = "SeaTransplantChoice";
            this.SeaTransplantChoice.Size = new System.Drawing.Size(117, 17);
            this.SeaTransplantChoice.TabIndex = 1;
            this.SeaTransplantChoice.Text = "SeaTransplant Item";
            this.SeaTransplantChoice.UseVisualStyleBackColor = true;
            this.SeaTransplantChoice.CheckedChanged += new System.EventHandler(this.PopulateAndUpdateURI);
            // 
            // ThistleChoice
            // 
            this.ThistleChoice.AutoSize = true;
            this.ThistleChoice.Checked = true;
            this.ThistleChoice.Location = new System.Drawing.Point(21, 26);
            this.ThistleChoice.Name = "ThistleChoice";
            this.ThistleChoice.Size = new System.Drawing.Size(83, 17);
            this.ThistleChoice.TabIndex = 0;
            this.ThistleChoice.TabStop = true;
            this.ThistleChoice.Text = "Users JSON";
            this.ThistleChoice.UseVisualStyleBackColor = true;
            this.ThistleChoice.CheckedChanged += new System.EventHandler(this.PopulateAndUpdateURI);
            // 
            // gAuth
            // 
            this.gAuth.Controls.Add(this.groupBox3);
            this.gAuth.Controls.Add(this.groupBox2);
            this.gAuth.Controls.Add(this.txtPassword);
            this.gAuth.Controls.Add(this.label2);
            this.gAuth.Controls.Add(this.bUseAuthentication);
            this.gAuth.Controls.Add(this.label3);
            this.gAuth.Controls.Add(this.txtUserName);
            this.gAuth.Location = new System.Drawing.Point(226, 15);
            this.gAuth.Name = "gAuth";
            this.gAuth.Size = new System.Drawing.Size(516, 154);
            this.gAuth.TabIndex = 38;
            this.gAuth.TabStop = false;
            this.gAuth.Text = "Authentication";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rBtnTechNone);
            this.groupBox3.Controls.Add(this.radNCC);
            this.groupBox3.Controls.Add(this.radRoll);
            this.groupBox3.Location = new System.Drawing.Point(197, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(174, 100);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Technique";
            // 
            // rBtnTechNone
            // 
            this.rBtnTechNone.AutoSize = true;
            this.rBtnTechNone.Checked = true;
            this.rBtnTechNone.Location = new System.Drawing.Point(5, 19);
            this.rBtnTechNone.Name = "rBtnTechNone";
            this.rBtnTechNone.Size = new System.Drawing.Size(51, 17);
            this.rBtnTechNone.TabIndex = 3;
            this.rBtnTechNone.TabStop = true;
            this.rBtnTechNone.Text = "None";
            this.rBtnTechNone.UseVisualStyleBackColor = true;
            // 
            // radNCC
            // 
            this.radNCC.AutoSize = true;
            this.radNCC.Location = new System.Drawing.Point(6, 67);
            this.radNCC.Name = "radNCC";
            this.radNCC.Size = new System.Drawing.Size(143, 17);
            this.radNCC.TabIndex = 1;
            this.radNCC.Text = "Network Credential Class";
            this.radNCC.UseVisualStyleBackColor = true;
            // 
            // radRoll
            // 
            this.radRoll.AutoSize = true;
            this.radRoll.Location = new System.Drawing.Point(5, 43);
            this.radRoll.Name = "radRoll";
            this.radRoll.Size = new System.Drawing.Size(93, 17);
            this.radRoll.TabIndex = 0;
            this.radRoll.Text = "Roll Your Own";
            this.radRoll.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rBtnAuthNone);
            this.groupBox2.Controls.Add(this.radNTLM);
            this.groupBox2.Controls.Add(this.radBasic);
            this.groupBox2.Location = new System.Drawing.Point(18, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(149, 100);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Auth Type";
            // 
            // rBtnAuthNone
            // 
            this.rBtnAuthNone.AutoSize = true;
            this.rBtnAuthNone.Checked = true;
            this.rBtnAuthNone.Location = new System.Drawing.Point(7, 20);
            this.rBtnAuthNone.Name = "rBtnAuthNone";
            this.rBtnAuthNone.Size = new System.Drawing.Size(51, 17);
            this.rBtnAuthNone.TabIndex = 2;
            this.rBtnAuthNone.TabStop = true;
            this.rBtnAuthNone.Text = "None";
            this.rBtnAuthNone.UseVisualStyleBackColor = true;
            // 
            // radNTLM
            // 
            this.radNTLM.AutoSize = true;
            this.radNTLM.Location = new System.Drawing.Point(6, 67);
            this.radNTLM.Name = "radNTLM";
            this.radNTLM.Size = new System.Drawing.Size(108, 17);
            this.radNTLM.TabIndex = 1;
            this.radNTLM.Text = "NTLM (Windows)";
            this.radNTLM.UseVisualStyleBackColor = true;
            // 
            // radBasic
            // 
            this.radBasic.AutoSize = true;
            this.radBasic.Location = new System.Drawing.Point(6, 43);
            this.radBasic.Name = "radBasic";
            this.radBasic.Size = new System.Drawing.Size(122, 17);
            this.radBasic.TabIndex = 0;
            this.radBasic.Text = "Basic Authentication";
            this.radBasic.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(368, 19);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(133, 20);
            this.txtPassword.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "User Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Password";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(85, 19);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(195, 20);
            this.txtUserName.TabIndex = 19;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.ExecutionURI);
            this.groupBox4.Controls.Add(this.btnClearDebug);
            this.groupBox4.Controls.Add(this.txtJSONOutput);
            this.groupBox4.Controls.Add(this.btnDeseralize);
            this.groupBox4.Controls.Add(this.txtResponse);
            this.groupBox4.Controls.Add(this.bRecord);
            this.groupBox4.Controls.Add(this.txtDeserialized);
            this.groupBox4.Controls.Add(this.numValues);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(12, 231);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1280, 506);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            // 
            // txtRequestURI
            // 
            this.txtRequestURI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRequestURI.Location = new System.Drawing.Point(116, 181);
            this.txtRequestURI.Name = "txtRequestURI";
            this.txtRequestURI.Size = new System.Drawing.Size(481, 20);
            this.txtRequestURI.TabIndex = 44;
            this.txtRequestURI.Text = "https://dry-cliffs-19849.herokuapp.com/users.json";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Initial URI:";
            // 
            // ExecutionURI
            // 
            this.ExecutionURI.Location = new System.Drawing.Point(116, 19);
            this.ExecutionURI.Name = "ExecutionURI";
            this.ExecutionURI.Size = new System.Drawing.Size(1152, 20);
            this.ExecutionURI.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Request URI";
            // 
            // MaxResults
            // 
            this.MaxResults.Location = new System.Drawing.Point(411, 48);
            this.MaxResults.Name = "MaxResults";
            this.MaxResults.Size = new System.Drawing.Size(100, 20);
            this.MaxResults.TabIndex = 44;
            this.MaxResults.Text = "50";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(408, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Max Results";
            // 
            // Authenticating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 749);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Authenticating";
            this.Text = "Authenticating";
            ((System.ComponentModel.ISupportInitialize)(this.numValues)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Specifics.ResumeLayout(false);
            this.Specifics.PerformLayout();
            this.gLocation.ResumeLayout(false);
            this.gLocation.PerformLayout();
            this.gAuth.ResumeLayout(false);
            this.gAuth.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bRecord;
        private System.Windows.Forms.NumericUpDown numValues;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDeserialized;
        private System.Windows.Forms.TextBox txtJSONOutput;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Button btnDeseralize;
        private System.Windows.Forms.Button btnClearDebug;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button RequestSpecific;
        private System.Windows.Forms.GroupBox Specifics;
        private System.Windows.Forms.TextBox FilterID;
        private System.Windows.Forms.RadioButton FilterRadio;
        private System.Windows.Forms.Button bRestartProcess;
        private System.Windows.Forms.Button bUseAuthentication;
        private System.Windows.Forms.GroupBox gLocation;
        private System.Windows.Forms.RadioButton TMobileChoice;
        private System.Windows.Forms.RadioButton SeaTransplantChoice;
        private System.Windows.Forms.RadioButton ThistleChoice;
        private System.Windows.Forms.GroupBox gAuth;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rBtnTechNone;
        private System.Windows.Forms.RadioButton radNCC;
        private System.Windows.Forms.RadioButton radRoll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rBtnAuthNone;
        private System.Windows.Forms.RadioButton radNTLM;
        private System.Windows.Forms.RadioButton radBasic;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRequestURI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ExecutionURI;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MaxResults;
    }
}