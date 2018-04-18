using Newtonsoft.Json;
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

    public partial class Authenticating : Form
    {
        private List<UsersJSON> jPerson;

        public Authenticating()
        {
            InitializeComponent();
        }


        #region UI Event Handler
        private void bUnauthGo_Click(object sender, EventArgs e)
        {
            try
            {
                ResetFormFields();
                DebugOutput("Calling Rest Interface");

                string sResponse = string.Empty;
                sResponse = RestInterface.MakeJSONRequest(txtRequestURI.Text.ToString(), AuthenticationType.None, AuthenticationTechnique.None,
                    string.Empty, string.Empty);

                DebugOutput(sResponse);

                JSONOutput(sResponse);
            }
            catch (Exception ex)
            {
                DebugOutput("Call Failed: " + ex.ToString() + Environment.NewLine);
            }
        }

        private void ResetFormFields()
        {
            JSONOutput(String.Empty);
            DeserializedOutput(String.Empty);
            numValues.Minimum = 0;
            numValues.Maximum = 0;
            numValues.Enabled = false;
            bRecord.Enabled = false;
        }


        private void btnDeseralize_Click(object sender, EventArgs e)
        {
            DeserializedOutput(string.Empty);
            numValues.Maximum = 0;
            jPerson = DeserializeJSON(txtJSONOutput.Text.ToString());
            DebugOutput("Completed");
            if (jPerson != null)
            {
                numValues.Minimum = 1;
                numValues.Maximum = jPerson.Count;
                numValues.Enabled = true;
                bRecord.Enabled = true;
            }
            else
            {
                numValues.Minimum = 0;
                numValues.Maximum = 0;
                numValues.Enabled = false;
                bRecord.Enabled = false;
            }

        }
        #endregion

        #region UpdateTextBoxes
        // after making the call to the RESTful API, put the data here
        private void DebugOutput(string strDebugText)
        {
            try
            {
                if (strDebugText == String.Empty)
                    txtResponse.Text = strDebugText;
                else
                {
                    System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                    txtResponse.Text = txtResponse.Text + strDebugText + Environment.NewLine;
                    txtResponse.SelectionStart = txtResponse.TextLength;
                    txtResponse.ScrollToCaret();
                }
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
                txtDeserialized.Text = string.Empty;
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

        private List<UsersJSON> DeserializeJSON(string strJSON)
        {

            try
            {
                DebugOutput("Deserializing JSON");
                List<UsersJSON> jPerson = JsonConvert.DeserializeObject<List<UsersJSON>>(strJSON);
                DebugOutput("Completed: " + jPerson.Count.ToString());
                return jPerson;
            }

            catch (Exception ex)
            {
                DebugOutput(Environment.NewLine + ">>> ErrorDesearlizing:" + ex.Message.ToString());
                return null;
            }

        }

        #endregion

        private void bRecord_Click(object sender, EventArgs e)
        {
            UsersJSON result = jPerson[(int)numValues.Value - 1];
            DeserializedOutput(
                "Record ID: " + result.id + Environment.NewLine +
                "Name: " + result.name + Environment.NewLine +
                "Email: " + result.email + Environment.NewLine +
                "Nationality: " + result.nationality);
        }

        private void bPopulate_Click(object sender, EventArgs e)
        {
            if (rBtnJSON.Checked)
            {
                txtRequestURI.Text = "https://dry-cliffs-19849.herokuapp.com/users.json";
                txtUserName.Text = String.Empty;
                txtPassword.Text = String.Empty;
                rBtnAuthNone.Checked = true;
                rBtnTechNone.Checked = true;
                bUseAuthentication.Focus();
            }
            /*           else if (rBtnJSONAuth.Checked)
                           {
                           txtRequestURI.Text = "http://192.168.0.16:8080/rest/api/2/issue/vp-1";
                           txtUserName.Text = String.Empty;
                           txtPassword.Text = String.Empty;
                           radBasic.Checked = true;
                           radRoll.Checked = true;
                       }
              */
            else if (rBtnSeaTransplant.Checked)
            {
                txtRequestURI.Text = "https://seatransplant.atlassian.net/rest/api/2/issue/10144";
                txtUserName.Text = "kodacoda@live.com";
                txtPassword.Text = "@ndyR0se!";
                bUseAuthentication.Focus();
            }
            else if (rBtnTMobile.Checked)
            {
                txtRequestURI.Text = "https://jira.t-mobile.com/rest/api/2/issue/152518";
                txtUserName.Text = "scostan";
                txtPassword.Text = String.Empty;
                txtPassword.Focus();
            }

            DebugOutput(string.Empty);

        }

        private void btnClearDebug_Click(object sender, EventArgs e)
        {
            DebugOutput(string.Empty);
        }

        private void bUseAuthentication_Click(object sender, EventArgs e)
        {
            try
            {
                ResetFormFields();
                DebugOutput("Calling Rest Interface");

                string sResponse = string.Empty;
                AuthenticationTechnique technique;
                AuthenticationType aType;

                if (rBtnAuthNone.Checked)
                    aType = AuthenticationType.None;
                else if (radBasic.Checked)
                    aType = AuthenticationType.Basic;
                else
                    aType = AuthenticationType.NTLM;

                if (rBtnTechNone.Checked)
                    technique = AuthenticationTechnique.None;
                else if (radRoll.Checked)
                    technique = AuthenticationTechnique.RollYourOwn;
                else
                    technique = AuthenticationTechnique.NetworkCredential;

                sResponse = RestInterface.MakeJSONRequest(txtRequestURI.Text.ToString(), aType, technique, txtUserName.Text.ToString(), txtPassword.Text.ToString());

                DebugOutput(sResponse);

                JSONOutput(sResponse);

                btnDeseralize.Enabled = true;

            }
            catch (Exception ex)
            {
                DebugOutput("Call Failed: " + ex.ToString() + Environment.NewLine);
                btnDeseralize.Enabled = false;
            }

        }
    }
}
