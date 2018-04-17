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
            this.bUnauthGo = new System.Windows.Forms.Button();
            this.txtRequestURI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radNCC = new System.Windows.Forms.RadioButton();
            this.radRoll = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radNTLM = new System.Windows.Forms.RadioButton();
            this.radBasic = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numValues = new System.Windows.Forms.NumericUpDown();
            this.bRecord = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValues)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDeserialized
            // 
            this.txtDeserialized.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDeserialized.Location = new System.Drawing.Point(10, 466);
            this.txtDeserialized.Multiline = true;
            this.txtDeserialized.Name = "txtDeserialized";
            this.txtDeserialized.Size = new System.Drawing.Size(735, 244);
            this.txtDeserialized.TabIndex = 17;
            // 
            // btnClearDebug
            // 
            this.btnClearDebug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearDebug.Location = new System.Drawing.Point(672, 227);
            this.btnClearDebug.Name = "btnClearDebug";
            this.btnClearDebug.Size = new System.Drawing.Size(75, 23);
            this.btnClearDebug.TabIndex = 16;
            this.btnClearDebug.Text = "ClearDebug";
            this.btnClearDebug.UseVisualStyleBackColor = true;
            // 
            // btnDeseralize
            // 
            this.btnDeseralize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeseralize.Location = new System.Drawing.Point(672, 347);
            this.btnDeseralize.Name = "btnDeseralize";
            this.btnDeseralize.Size = new System.Drawing.Size(75, 23);
            this.btnDeseralize.TabIndex = 15;
            this.btnDeseralize.Text = "Deserialize";
            this.btnDeseralize.UseVisualStyleBackColor = true;
            this.btnDeseralize.Click += new System.EventHandler(this.btnDeseralize_Click);
            // 
            // txtJSONOutput
            // 
            this.txtJSONOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJSONOutput.Location = new System.Drawing.Point(10, 347);
            this.txtJSONOutput.Multiline = true;
            this.txtJSONOutput.Name = "txtJSONOutput";
            this.txtJSONOutput.Size = new System.Drawing.Size(611, 100);
            this.txtJSONOutput.TabIndex = 14;
            // 
            // txtResponse
            // 
            this.txtResponse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResponse.Location = new System.Drawing.Point(10, 227);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ReadOnly = true;
            this.txtResponse.Size = new System.Drawing.Size(652, 94);
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
            // bUnauthGo
            // 
            this.bUnauthGo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bUnauthGo.Location = new System.Drawing.Point(664, 20);
            this.bUnauthGo.Name = "bUnauthGo";
            this.bUnauthGo.Size = new System.Drawing.Size(75, 23);
            this.bUnauthGo.TabIndex = 11;
            this.bUnauthGo.Text = "Go (Unauth)";
            this.bUnauthGo.UseVisualStyleBackColor = true;
            this.bUnauthGo.Click += new System.EventHandler(this.bUnauthGo_Click);
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
            this.txtUserName.Size = new System.Drawing.Size(100, 20);
            this.txtUserName.TabIndex = 19;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(327, 19);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Password";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Location = new System.Drawing.Point(13, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(732, 162);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Authentication Required";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(617, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Go Authentication";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radNCC);
            this.groupBox3.Controls.Add(this.radRoll);
            this.groupBox3.Location = new System.Drawing.Point(260, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Technique";
            // 
            // radNCC
            // 
            this.radNCC.AutoSize = true;
            this.radNCC.Location = new System.Drawing.Point(7, 43);
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
            this.radRoll.Location = new System.Drawing.Point(6, 19);
            this.radRoll.Name = "radRoll";
            this.radRoll.Size = new System.Drawing.Size(93, 17);
            this.radRoll.TabIndex = 0;
            this.radRoll.TabStop = true;
            this.radRoll.Text = "Roll Your Own";
            this.radRoll.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radNTLM);
            this.groupBox2.Controls.Add(this.radBasic);
            this.groupBox2.Location = new System.Drawing.Point(18, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Auth Type";
            // 
            // radNTLM
            // 
            this.radNTLM.AutoSize = true;
            this.radNTLM.Location = new System.Drawing.Point(7, 44);
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
            this.radBasic.Location = new System.Drawing.Point(7, 20);
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
            this.label4.Location = new System.Drawing.Point(12, 450);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Result";
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
            this.numValues.Location = new System.Drawing.Point(630, 396);
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
            this.bRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bRecord.Location = new System.Drawing.Point(672, 396);
            this.bRecord.Name = "bRecord";
            this.bRecord.Size = new System.Drawing.Size(75, 23);
            this.bRecord.TabIndex = 27;
            this.bRecord.Text = "Record";
            this.bRecord.UseVisualStyleBackColor = true;
            this.bRecord.Click += new System.EventHandler(this.bRecord_Click);
            // 
            // Authenticating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 725);
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
            this.Controls.Add(this.bUnauthGo);
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
        private System.Windows.Forms.Button bUnauthGo;
        private System.Windows.Forms.TextBox txtRequestURI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
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
    }
}