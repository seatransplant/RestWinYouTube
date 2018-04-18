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
            this.txtDeserialized = new System.Windows.Forms.TextBox();
            this.btnClearDebug = new System.Windows.Forms.Button();
            this.btnDeseralize = new System.Windows.Forms.Button();
            this.txtJSONOutput = new System.Windows.Forms.TextBox();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRequestURI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bUseAuthentication = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rBtnTechNone = new System.Windows.Forms.RadioButton();
            this.radNCC = new System.Windows.Forms.RadioButton();
            this.radRoll = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rBtnAuthNone = new System.Windows.Forms.RadioButton();
            this.radNTLM = new System.Windows.Forms.RadioButton();
            this.radBasic = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numValues = new System.Windows.Forms.NumericUpDown();
            this.bRecord = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bPopulate = new System.Windows.Forms.Button();
            this.rBtnTMobile = new System.Windows.Forms.RadioButton();
            this.rBtnSeaTransplant = new System.Windows.Forms.RadioButton();
            this.rBtnJSON = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValues)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDeserialized
            // 
            this.txtDeserialized.Location = new System.Drawing.Point(11, 466);
            this.txtDeserialized.Multiline = true;
            this.txtDeserialized.Name = "txtDeserialized";
            this.txtDeserialized.Size = new System.Drawing.Size(756, 244);
            this.txtDeserialized.TabIndex = 17;
            // 
            // btnClearDebug
            // 
            this.btnClearDebug.Location = new System.Drawing.Point(692, 227);
            this.btnClearDebug.Name = "btnClearDebug";
            this.btnClearDebug.Size = new System.Drawing.Size(75, 23);
            this.btnClearDebug.TabIndex = 16;
            this.btnClearDebug.Text = "ClearDebug";
            this.btnClearDebug.UseVisualStyleBackColor = true;
            this.btnClearDebug.Click += new System.EventHandler(this.btnClearDebug_Click);
            // 
            // btnDeseralize
            // 
            this.btnDeseralize.Enabled = false;
            this.btnDeseralize.Location = new System.Drawing.Point(692, 347);
            this.btnDeseralize.Name = "btnDeseralize";
            this.btnDeseralize.Size = new System.Drawing.Size(75, 23);
            this.btnDeseralize.TabIndex = 15;
            this.btnDeseralize.Text = "Deserialize";
            this.btnDeseralize.UseVisualStyleBackColor = true;
            this.btnDeseralize.Click += new System.EventHandler(this.btnDeseralize_Click);
            // 
            // txtJSONOutput
            // 
            this.txtJSONOutput.Location = new System.Drawing.Point(10, 347);
            this.txtJSONOutput.Multiline = true;
            this.txtJSONOutput.Name = "txtJSONOutput";
            this.txtJSONOutput.Size = new System.Drawing.Size(642, 100);
            this.txtJSONOutput.TabIndex = 14;
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(10, 227);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ReadOnly = true;
            this.txtResponse.Size = new System.Drawing.Size(642, 94);
            this.txtResponse.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Request URI";
            // 
            // txtRequestURI
            // 
            this.txtRequestURI.Location = new System.Drawing.Point(108, 20);
            this.txtRequestURI.Name = "txtRequestURI";
            this.txtRequestURI.Size = new System.Drawing.Size(529, 20);
            this.txtRequestURI.TabIndex = 10;
            this.txtRequestURI.Text = "https://dry-cliffs-19849.herokuapp.com/users.json";
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
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(85, 19);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(195, 20);
            this.txtUserName.TabIndex = 19;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(368, 19);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(133, 20);
            this.txtPassword.TabIndex = 21;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bUseAuthentication);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Location = new System.Drawing.Point(13, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 162);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Authentication Required";
            // 
            // bUseAuthentication
            // 
            this.bUseAuthentication.Location = new System.Drawing.Point(645, 71);
            this.bUseAuthentication.Name = "bUseAuthentication";
            this.bUseAuthentication.Size = new System.Drawing.Size(109, 23);
            this.bUseAuthentication.TabIndex = 24;
            this.bUseAuthentication.Text = "Request";
            this.bUseAuthentication.UseVisualStyleBackColor = true;
            this.bUseAuthentication.Click += new System.EventHandler(this.bUseAuthentication_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rBtnTechNone);
            this.groupBox3.Controls.Add(this.radNCC);
            this.groupBox3.Controls.Add(this.radRoll);
            this.groupBox3.Location = new System.Drawing.Point(301, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Technique";
            // 
            // rBtnTechNone
            // 
            this.rBtnTechNone.AutoSize = true;
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
            this.radNCC.TabStop = true;
            this.radNCC.Text = "Network Credential Class";
            this.radNCC.UseVisualStyleBackColor = true;
            // 
            // radRoll
            // 
            this.radRoll.AutoSize = true;
            this.radRoll.Checked = true;
            this.radRoll.Location = new System.Drawing.Point(5, 43);
            this.radRoll.Name = "radRoll";
            this.radRoll.Size = new System.Drawing.Size(93, 17);
            this.radRoll.TabIndex = 0;
            this.radRoll.TabStop = true;
            this.radRoll.Text = "Roll Your Own";
            this.radRoll.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rBtnAuthNone);
            this.groupBox2.Controls.Add(this.radNTLM);
            this.groupBox2.Controls.Add(this.radBasic);
            this.groupBox2.Location = new System.Drawing.Point(18, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 100);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Auth Type";
            // 
            // rBtnAuthNone
            // 
            this.rBtnAuthNone.AutoSize = true;
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
            this.radBasic.Checked = true;
            this.radBasic.Location = new System.Drawing.Point(6, 43);
            this.radBasic.Name = "radBasic";
            this.radBasic.Size = new System.Drawing.Size(122, 17);
            this.radBasic.TabIndex = 0;
            this.radBasic.TabStop = true;
            this.radBasic.Text = "Basic Authentication";
            this.radBasic.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(12, 450);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Record";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "JSON Output";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Debug Information";
            // 
            // numValues
            // 
            this.numValues.Enabled = false;
            this.numValues.Location = new System.Drawing.Point(658, 399);
            this.numValues.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numValues.Name = "numValues";
            this.numValues.Size = new System.Drawing.Size(32, 20);
            this.numValues.TabIndex = 26;
            // 
            // bRecord
            // 
            this.bRecord.Enabled = false;
            this.bRecord.Location = new System.Drawing.Point(692, 396);
            this.bRecord.Name = "bRecord";
            this.bRecord.Size = new System.Drawing.Size(75, 39);
            this.bRecord.TabIndex = 27;
            this.bRecord.Text = "Show Record";
            this.bRecord.UseVisualStyleBackColor = true;
            this.bRecord.Click += new System.EventHandler(this.bRecord_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bPopulate);
            this.groupBox4.Controls.Add(this.rBtnTMobile);
            this.groupBox4.Controls.Add(this.rBtnSeaTransplant);
            this.groupBox4.Controls.Add(this.rBtnJSON);
            this.groupBox4.Location = new System.Drawing.Point(865, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(254, 301);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // bPopulate
            // 
            this.bPopulate.Location = new System.Drawing.Point(173, 19);
            this.bPopulate.Name = "bPopulate";
            this.bPopulate.Size = new System.Drawing.Size(75, 23);
            this.bPopulate.TabIndex = 3;
            this.bPopulate.Text = "Populate";
            this.bPopulate.UseVisualStyleBackColor = true;
            this.bPopulate.Click += new System.EventHandler(this.bPopulate_Click);
            // 
            // rBtnTMobile
            // 
            this.rBtnTMobile.AutoSize = true;
            this.rBtnTMobile.Location = new System.Drawing.Point(21, 91);
            this.rBtnTMobile.Name = "rBtnTMobile";
            this.rBtnTMobile.Size = new System.Drawing.Size(89, 17);
            this.rBtnTMobile.TabIndex = 2;
            this.rBtnTMobile.Text = "T-Mobile Item";
            this.rBtnTMobile.UseVisualStyleBackColor = true;
            // 
            // rBtnSeaTransplant
            // 
            this.rBtnSeaTransplant.AutoSize = true;
            this.rBtnSeaTransplant.Location = new System.Drawing.Point(21, 68);
            this.rBtnSeaTransplant.Name = "rBtnSeaTransplant";
            this.rBtnSeaTransplant.Size = new System.Drawing.Size(117, 17);
            this.rBtnSeaTransplant.TabIndex = 1;
            this.rBtnSeaTransplant.Text = "SeaTransplant Item";
            this.rBtnSeaTransplant.UseVisualStyleBackColor = true;
            // 
            // rBtnJSON
            // 
            this.rBtnJSON.AutoSize = true;
            this.rBtnJSON.Checked = true;
            this.rBtnJSON.Location = new System.Drawing.Point(21, 26);
            this.rBtnJSON.Name = "rBtnJSON";
            this.rBtnJSON.Size = new System.Drawing.Size(83, 17);
            this.rBtnJSON.TabIndex = 0;
            this.rBtnJSON.TabStop = true;
            this.rBtnJSON.Text = "Users JSON";
            this.rBtnJSON.UseVisualStyleBackColor = true;
            // 
            // Authenticating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 725);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.bRecord);
            this.Controls.Add(this.numValues);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDeserialized);
            this.Controls.Add(this.btnClearDebug);
            this.Controls.Add(this.btnDeseralize);
            this.Controls.Add(this.txtJSONOutput);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRequestURI);
            this.Name = "Authenticating";
            this.Text = "Authenticating";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValues)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDeserialized;
        private System.Windows.Forms.Button btnClearDebug;
        private System.Windows.Forms.Button btnDeseralize;
        private System.Windows.Forms.TextBox txtJSONOutput;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRequestURI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bUseAuthentication;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radNCC;
        private System.Windows.Forms.RadioButton radRoll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radNTLM;
        private System.Windows.Forms.RadioButton radBasic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numValues;
        private System.Windows.Forms.Button bRecord;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bPopulate;
        private System.Windows.Forms.RadioButton rBtnTMobile;
        private System.Windows.Forms.RadioButton rBtnSeaTransplant;
        private System.Windows.Forms.RadioButton rBtnJSON;
        private System.Windows.Forms.RadioButton rBtnTechNone;
        private System.Windows.Forms.RadioButton rBtnAuthNone;
    }
}