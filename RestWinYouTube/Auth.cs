﻿using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace RestWinYouTube
{
    public partial class GetJSON : Form
    {
        public GetJSON()
        {
            InitializeComponent();
        }

        #region UI Event Handler
        private void RequestResponse(object sender, EventArgs e)
        {
            //debugOutput("Clicked Button");
            try
            {
                RestClient rClient = new RestClient();
                rClient.endPoint = txtRequestURI.Text;
                DebugOutput("Rest Client Created");

                string sResponse = string.Empty;

                sResponse = rClient.makeRequest();

                DebugOutput(sResponse);

                JSONOutput(sResponse);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
                DebugOutput(Environment.NewLine + ">>> Error RequestResponse:" + ex.Message.ToString());
            }

        }

        private void btnDeseralize_Click(object sender, EventArgs e)
        {
            DeserializedOutput(string.Empty);
            DeserializeJSON(txtJSONOutput.Text.ToString());
        }

        private void ClearDebug_Click(object sender, EventArgs e)
        {
            txtJSONOutput.Text = string.Empty;
            txtDeserialized.Text = string.Empty;
            txtResponse.Text = string.Empty;

        }
        #endregion

        #region UpdateTextBoxes
        // after making the call to the RESTful API, put the data here
        private void DebugOutput(string strDebugText)
        {
            try
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
                System.Diagnostics.Debug.Write(ex.Message.ToString() + Environment.NewLine);
                DebugOutput(Environment.NewLine + ">>> Error During JSONOutput:" + ex.Message.ToString());
            }
        }

        // After getting the RESTful API result deserialized, put it in the box
        private void DeserializedOutput(string strDeserialized)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDeserialized + Environment.NewLine);
                txtDeserialized.Text = strDeserialized;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message.ToString() + Environment.NewLine);
                DebugOutput(Environment.NewLine + ">>> Error Durng DeserializedOutput:" + ex.Message.ToString());
            }
        }
        #endregion


        #region DeSerialize

        private void DeserializeJSON(string strJSON)
        {

            try
            {
                List<UsersJSON> jPerson = JsonConvert.DeserializeObject<List<UsersJSON>>(strJSON);
                DebugOutput("Sending JSON Result");
                DeserializedOutput(jPerson[0].name);

            }

            catch (Exception ex)
            {
                DebugOutput(Environment.NewLine + ">>> ErrorDesearlizing:" + ex.Message.ToString());
            }

        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
