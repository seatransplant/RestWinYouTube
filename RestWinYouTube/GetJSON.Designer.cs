namespace RestWinYouTube
{
    partial class GetJSON
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
            this.txtRequestURI = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtJSONOutput = new System.Windows.Forms.TextBox();
            this.btnDeseralize = new System.Windows.Forms.Button();
            this.btnClearDebug = new System.Windows.Forms.Button();
            this.txtDeserialized = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bAuthenticate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRequestURI
            // 
            this.txtRequestURI.Location = new System.Drawing.Point(114, 43);
            this.txtRequestURI.Name = "txtRequestURI";
            this.txtRequestURI.Size = new System.Drawing.Size(529, 20);
            this.txtRequestURI.TabIndex = 0;
            this.txtRequestURI.Text = "https://dry-cliffs-19849.herokuapp.com/users.json";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(676, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.RequestResponse);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Request URI";
            // 
            // txtResponse
            // 
            this.txtResponse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResponse.Location = new System.Drawing.Point(18, 92);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ReadOnly = true;
            this.txtResponse.Size = new System.Drawing.Size(733, 94);
            this.txtResponse.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Debug Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "JSON Output";
            // 
            // txtJSONOutput
            // 
            this.txtJSONOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJSONOutput.Location = new System.Drawing.Point(18, 209);
            this.txtJSONOutput.Multiline = true;
            this.txtJSONOutput.Name = "txtJSONOutput";
            this.txtJSONOutput.Size = new System.Drawing.Size(652, 100);
            this.txtJSONOutput.TabIndex = 6;
            // 
            // btnDeseralize
            // 
            this.btnDeseralize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeseralize.Location = new System.Drawing.Point(676, 209);
            this.btnDeseralize.Name = "btnDeseralize";
            this.btnDeseralize.Size = new System.Drawing.Size(75, 23);
            this.btnDeseralize.TabIndex = 7;
            this.btnDeseralize.Text = "Deserialize";
            this.btnDeseralize.UseVisualStyleBackColor = true;
            this.btnDeseralize.Click += new System.EventHandler(this.btnDeseralize_Click);
            // 
            // btnClearDebug
            // 
            this.btnClearDebug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearDebug.Location = new System.Drawing.Point(676, 239);
            this.btnClearDebug.Name = "btnClearDebug";
            this.btnClearDebug.Size = new System.Drawing.Size(75, 23);
            this.btnClearDebug.TabIndex = 8;
            this.btnClearDebug.Text = "ClearDebug";
            this.btnClearDebug.UseVisualStyleBackColor = true;
            this.btnClearDebug.Click += new System.EventHandler(this.ClearDebug_Click);
            // 
            // txtDeserialized
            // 
            this.txtDeserialized.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDeserialized.Location = new System.Drawing.Point(18, 343);
            this.txtDeserialized.Multiline = true;
            this.txtDeserialized.Name = "txtDeserialized";
            this.txtDeserialized.Size = new System.Drawing.Size(735, 244);
            this.txtDeserialized.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Result";
            // 
            // bAuthenticate
            // 
            this.bAuthenticate.Location = new System.Drawing.Point(677, 285);
            this.bAuthenticate.Name = "bAuthenticate";
            this.bAuthenticate.Size = new System.Drawing.Size(75, 23);
            this.bAuthenticate.TabIndex = 11;
            this.bAuthenticate.Text = "Authenticate";
            this.bAuthenticate.UseVisualStyleBackColor = true;
            this.bAuthenticate.Click += new System.EventHandler(this.bAuthenticate_Click);
            // 
            // GetJSON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 590);
            this.Controls.Add(this.bAuthenticate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDeserialized);
            this.Controls.Add(this.btnClearDebug);
            this.Controls.Add(this.btnDeseralize);
            this.Controls.Add(this.txtJSONOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtRequestURI);
            this.Name = "GetJSON";
            this.Text = "GetJSON";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRequestURI;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtJSONOutput;
        private System.Windows.Forms.Button btnDeseralize;
        private System.Windows.Forms.Button btnClearDebug;
        private System.Windows.Forms.TextBox txtDeserialized;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bAuthenticate;
    }
}

