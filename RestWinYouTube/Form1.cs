using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestWinYouTube
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        #region UI Event Handler
        private void button1_Click(object sender, EventArgs e)
        {
            //debugOutput("Clicked Button");
            RestClient rClient = new RestClient();
            rClient.endPoint = txtRequestURI.Text;
            debugOutput("Rest Client Created");

            string sResponse = string.Empty;

            sResponse = rClient.makeRequest();

            debugOutput(sResponse);

            JSONOutput(sResponse);
        }
        #endregion

        private void debugOutput(string strDebugText)
        { try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                txtResponse.Text = txtResponse.Text + strDebugText + Environment.NewLine;
                txtResponse.SelectionStart = txtResponse.TextLength;
                txtResponse.ScrollToCaret();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }

        private void JSONOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                txtJSONOutput.Text = string.Empty;
                txtJSONOutput.Text = strDebugText;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
                debugOutput("Error During JSONOutput:" + ex.Message.ToString());
            }
        }

        private void btnClearDebug_Click(object sender, EventArgs e)
        {
            txtJSONOutput.Text = string.Empty;
            txtDeserialized.Text = string.Empty;
            txtResponse.Text = string.Empty;
        }
    }
}
