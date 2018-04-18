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
        //private List<JIRA_TMobile> jSeaTransplant;

        private enum RequestServer
        {
            Thistle,
            Cloud,
            TMbobile
        }

        private RequestServer rs = RequestServer.Thistle;

        public Authenticating()
        {
            InitializeComponent();
        }


        #region UI Event Handler
        private void bUnauthGo_Click(object sender, EventArgs e)
        {
            try
            {
                ResetFormFieldsForRequest();
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

        private void ResetFormFieldsForRequest()
        {
            JSONOutput(String.Empty);
            DeserializedOutput(String.Empty);
            numValues.Minimum = 0;
            numValues.Maximum = 0;
            numValues.Enabled = false;
            bRecord.Enabled = false;
            gLocation.Enabled = false;
            gAuth.Enabled = false;
            jPerson = null;
        }


        private void btnDeseralize_Click(object sender, EventArgs e)
        {

            DebugOutput("Clearing/Resetting Deseralize");

            jPerson = null;

            DeserializedOutput(string.Empty);
            numValues.Minimum = 0;
            numValues.Maximum = 0;
            numValues.Enabled = false;
            bRecord.Enabled = false;


            if (ThistleChoice.Checked)
                ProcessThistle();
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


        #region DeSerialize_Thistle

        private void ProcessThistle()
        {
            jPerson = DeserializeJSONThistle(txtJSONOutput.Text.ToString());
            DebugOutput("Deserialize Completed");
            if (jPerson != null)
            {
                numValues.Minimum = 1;
                numValues.Maximum = jPerson.Count;
                numValues.Enabled = true;
                bRecord.Enabled = true;
            }

        }

        private List<UsersJSON> DeserializeJSONThistle(string strJSON)
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

        #region DeSerialize_JIRA_SeaTransplant

        /*       private void ProcessSeaTransplant()
               {
                   jSeaTransplant = DeserializeJSONSeaTransplant(txtJSONOutput.Text.ToString());
                   DebugOutput("Deserialize Completed");
                   if (jPerson != null)
                   {
                       numValues.Minimum = 1;
                       numValues.Maximum = jPerson.Count;
                       numValues.Enabled = true;
                       bRecord.Enabled = true;
                   }

               }

               private List<UsersJSON> DeserializeJSONSeaTransplant(string strJSON)
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
               */

        #endregion
        private void bRecord_Click(object sender, EventArgs e)
        {
            if (jPerson != null)
            {
                UsersJSON result = jPerson[(int)numValues.Value - 1];
                DeserializedOutput(
                    "Record ID: " + result.id + Environment.NewLine +
                    "Name: " + result.name + Environment.NewLine +
                    "Email: " + result.email + Environment.NewLine +
                    "Nationality: " + result.nationality);
            }
        }

        private void PopulateAndUpdateURI(object sender, EventArgs e)
        {
            if (ThistleChoice.Checked)
            {
                txtRequestURI.Text = "https://dry-cliffs-19849.herokuapp.com/users.json";
                txtUserName.Text = String.Empty;
                txtPassword.Text = String.Empty;
                rBtnAuthNone.Checked = true;
                rBtnTechNone.Checked = true;
                bUseAuthentication.Focus();
                rs = RequestServer.Thistle;

            }
            else if (SeaTransplantChoice.Checked)
            {
                txtRequestURI.Text = "https://seatransplant.atlassian.net/rest/api/2/issue/10144";
                txtUserName.Text = "kodacoda@live.com";
                txtPassword.Text = "@ndyR0se!";
                bUseAuthentication.Focus();
                radBasic.Checked = true;
                rs = RequestServer.Cloud;
            }
            else if (TMobileChoice.Checked)
            {
                txtRequestURI.Text = "https://jira.t-mobile.com/rest/api/2/issue/152518";
                txtUserName.Text = "scostan";
                txtPassword.Text = String.Empty;
                txtPassword.Focus();
                radBasic.Checked = true;
                rs = RequestServer.TMbobile;
            }

            Specifics.Enabled = (rs != RequestServer.Thistle);

            DebugOutput(string.Empty);

        }

        private void btnClearDebug_Click(object sender, EventArgs e)
        {
            DebugOutput(string.Empty);
        }

        private void bUseAuthentication_Click(object sender, EventArgs e)
        {
            ExecuteJSONRequest(txtRequestURI.Text.ToString());
        }

        private void ExecuteJSONRequest(string TargetURI)
        {
            try
            {
                ResetFormFieldsForRequest();
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

                ExecutionURI.Text = TargetURI;

                sResponse = RestInterface.MakeJSONRequest(TargetURI, aType, technique, txtUserName.Text.ToString(), txtPassword.Text.ToString());

                DebugOutput(sResponse);

                JSONOutput(sResponse);

                if (sResponse.IndexOf("error") == -1)
                    btnDeseralize.Enabled = true;
                else
                {
                    gAuth.Enabled = true;
                    gLocation.Enabled = true;
                }

                DebugOutput("Attempting to write output to clipboard");
                Clipboard.SetText(sResponse);
                DebugOutput("Completed clipboard write");
          
            }
            catch (Exception ex)
            {
                DebugOutput("Call Failed: " + ex.ToString() + Environment.NewLine);
                btnDeseralize.Enabled = false;
            }


        }

        private void bRestartProcess_Click(object sender, EventArgs e)
        {
            gAuth.Enabled = true;
            gLocation.Enabled = true;
            btnDeseralize.Enabled = false;
            ThistleChoice.Checked = true;
            txtJSONOutput.Text = string.Empty;
        }

        private void RequestSpecific_Click(object sender, EventArgs e)
        {
            string requestURI = txtRequestURI.Text.ToString();

            if (rs == RequestServer.Thistle)
                DebugOutput("Cannot do a specific search on this URI. Using unmodified");
            else
            {
                if (FilterRadio.Checked)
                {
                    int issueStart = 0;
                    issueStart = requestURI.IndexOf("issue");
                    requestURI = requestURI.Substring(0, issueStart);
                    requestURI += "search/?jql=filter=" + FilterID.Text.ToString() + "&maxResults=" + MaxResults.Text.ToString();

                }
            }

            
            ExecuteJSONRequest(requestURI);
        }

    }

}
