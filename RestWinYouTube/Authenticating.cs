using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RestWinYouTube
{

   public partial class Authenticating : Form
   {
      private List<Thistle_Schema> jPerson;
      private SeaTransplant_JIRA_Schema.RootObject jSeaTransplant;
      private TMobile_INFUOPS_Schema.RootObject jTMobile;
      private string BaseURI = string.Empty;

      public string DebugOutputValue
      {
         set
         {
            DebugOutput(value);
         }
      }

      private enum RequestServer
      {
         Thistle,
         Cloud,
         TMobile
      }

      private RequestServer rs = RequestServer.Thistle;

      public Authenticating()
      {
         InitializeComponent();
         TMobileChoice.Checked = true;
         PopulateAndUpdateURI(null, null);
      }


      #region UI Event Handler

      private void ResetFormFieldsForRequest()
      {
         JSONOutput(String.Empty);
         ResetDeseralize();
         gLocation.Enabled = false;
         gAuth.Enabled = false;
      }

      private void Deseralize_Click(object sender, EventArgs e)
      {
         ResetDeseralize();
         DebugOutput("Calling Process for " + rs.ToString());

         if (rs == RequestServer.Thistle)
            ProcessThistle();
         else if (rs == RequestServer.Cloud)
            ProcessSeaTransplant();
         else if (rs == RequestServer.TMobile)
            ProcessTMobile_INFUOPS();
         else
            DebugOutput("rs is in an invalid state. " + rs.ToString());
      }

      private void Record_Click(object sender, EventArgs e)
      {
         int recordNumber = (int)numValues.Value - 1;
         DebugOutput(String.Format("Clicked record {0} for {1}", recordNumber, rs.ToString()));

         if (recordNumber > numValues.Maximum)
         {
            DebugOutput(String.Format("Recheck your value {0} entered, max number {1}", recordNumber, jSeaTransplant.issues.Count().ToString()));
         }
         else
         {
            try
            {
               if (rs == RequestServer.Thistle)
                  if (jPerson != null)
                  {
                     Thistle_Schema result = jPerson[recordNumber];
                     DisplayThistleSingleRecord(result);
                  }

               if (rs == RequestServer.Cloud)
                  if (jSeaTransplant != null)
                  {
                     SeaTransplant_JIRA_Schema.Issue result = jSeaTransplant.issues[recordNumber];
                     DisplaySeaTransplantRecord(result);
                  }
               if (rs == RequestServer.TMobile)
                  if (jTMobile != null)
                  {
                     TMobile_INFUOPS_Schema.Issue result = jTMobile.issues[recordNumber];
                     DisplayTMobile_INFUOPS_Record(result);
                  }
            }
            catch (Exception ex)
            {
               DebugOutput("Error while Pulling Record: " + ex.ToString());
            }
         }
      }

      private void PopulateAndUpdateURI(object sender, EventArgs e)
      {
         if (sender != null)
            DebugOutput(string.Format("Populating URI data, etc. for {0}", sender.ToString()));
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
            BaseURI = "https://seatransplant.atlassian.net/rest/api/2/";
            txtRequestURI.Text = BaseURI + "/issue/10144";
            txtUserName.Text = "kodacoda@live.com";
            txtPassword.Text = "@ndyR0se!";
            bUseAuthentication.Focus();
            radBasic.Checked = true;
            rs = RequestServer.Cloud;
         }
         else if (TMobileChoice.Checked)
         {
            BaseURI = "https://jira.t-mobile.com/rest/api/2/";
            txtRequestURI.Text = BaseURI + "issue/136357";
            txtUserName.Text = "scostan";
#if DEBUG
            txtPassword.Text = "BECU8108!";
#else
            txtPassword.Text = String.Empty;
#endif
            txtPassword.Focus();
            radBasic.Checked = true;
            rs = RequestServer.TMobile;
         }

         Specifics.Enabled = (rs != RequestServer.Thistle);

         DebugOutput(string.Empty);

      }

      private void ClearDebug_Click(object sender, EventArgs e)
      {
         DebugOutput(string.Empty);
      }

      private void UseAuthentication_Click(object sender, EventArgs e)
      {
         ExecutionURI.Text = txtRequestURI.Text; // Necessary as all other calls reference the ExecutionURI
         ExecuteJSONRequest(ExecutionURI.Text);
      }

      private void RestartProcess_Click(object sender, EventArgs e)
      {
         gAuth.Enabled = true;
         gLocation.Enabled = true;
         btnDeseralize.Enabled = false;
         ThistleChoice.Checked = true;
         txtJSONOutput.Text = string.Empty;
         ExecutionURI.Text = string.Empty;
         ResetDeseralize();
      }

      private void RequestSpecific_Click(object sender, EventArgs e)
      {
         string targetURI = BaseURI;

         if (rs == RequestServer.Thistle)
            DebugOutput("Cannot do a specific search on this URI. Using unmodified");
         else
         {
            if (FilterRadio.Checked)
               targetURI += "search/?jql=filter=" + FilterID.Text.ToString() + "&maxResults=" + MaxResults.Text.ToString() + "&startAt=" + StartAt.Text.ToString();
            else // use this block IF the secondary checkboxes can apply
            {
               if (IssueIDRadio.Checked)
                  targetURI += "issue/" + IssueID.Text;
               if (IssueKeyRadio.Checked)
                  targetURI += "issue/" + IssueKey.Text;

               if (CheckChangeLog.Checked)
                  targetURI += "?expand=changelog";
            }
            ExecutionURI.Text = targetURI;
            ExecutionURI.Refresh();
         }

         ExecuteJSONRequest(targetURI);
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
            if (txtJSONOutput.Text == string.Empty)
               btnDeseralize.Enabled = false;
            else
            {
               txtJSONOutput.Refresh();
               btnDeseralize.Enabled = true;
            }

         }
         catch (Exception ex)
         {
            System.Diagnostics.Debug.Write(ex.Message.ToString() + Environment.NewLine);
            DebugOutput(Environment.NewLine + ">>> Error During JSONOutput:" + ex.Message.ToString());
         }
      }

      private void ResetDeseralize()
      {
         DebugOutput("Clearing/Resetting Deseralize");

         jPerson = null;
         jSeaTransplant = null;
         jTMobile = null;

         DeserializedOutput(string.Empty);
         numValues.Minimum = 0;
         numValues.Maximum = 0;
         MaximumRecords.Text = numValues.Maximum.ToString();
         numValues.Enabled = false;
         bRecord.Enabled = false;
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

      #region ThistleSpecific

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
      private List<Thistle_Schema> DeserializeJSONThistle(string strJSON)
      {

         try
         {
            DebugOutput("Deserializing JSON");
            List<Thistle_Schema> jPerson = JsonConvert.DeserializeObject<List<Thistle_Schema>>(strJSON);
            DebugOutput("Completed: " + jPerson.Count.ToString());
            return jPerson;
         }

         catch (Exception ex)
         {
            DebugOutput(Environment.NewLine + ">>> ErrorDesearlizing:" + ex.Message.ToString());
            return null;
         }

      }

      private void DisplayThistleSingleRecord(Thistle_Schema result)
      {
         DeserializedOutput(
             "Record ID: " + result.id + Environment.NewLine +
             "Name: " + result.name + Environment.NewLine +
             "Email: " + result.email + Environment.NewLine +
             "Nationality: " + result.nationality);

      }
      #endregion
      #region SeaTransplantSpecific
      private void ProcessSeaTransplant()
      {
         string JSONOutput = txtJSONOutput.Text.ToString();

         if (ExecutionURI.Text.ToString().IndexOf("/issue/") == -1)
         {

            jSeaTransplant = SeaTransplantInterface.ProcessSeaTransplant(this, ExecutionURI.Text.ToString(), JSONOutput);
            if (jSeaTransplant != null)
            {
               numValues.Minimum = 1;
               numValues.Maximum = jSeaTransplant.issues.Count();
               MaximumRecords.Text = numValues.Maximum.ToString();
               numValues.Enabled = true;
               bRecord.Enabled = true;
            }
            else
               DebugOutput("No Records Returned");
         }
         else
         {
            SeaTransplant_JIRA_Schema.Issue jSingleIssue;
            DebugOutput("Single Issue, deserializing");
            jSingleIssue = SeaTransplantInterface.DeserializeJSONSeaTransplantSingle(this, JSONOutput);
            if (jSingleIssue != null)
            {
               DebugOutput("Completed. Displaying");
               DisplaySeaTransplantRecord(jSingleIssue);
            }
            else
               DebugOutput("No Records Returned");


         }
      }

      private void DisplaySeaTransplantRecord(SeaTransplant_JIRA_Schema.Issue result)
      {
         SeaTransplant_JIRA_Schema.Fields IssueFields = result.fields;
         DeserializedOutput(
             "Key: " + result.key + Environment.NewLine +
             "Issue Type: " + IssueFields.issuetype.name + Environment.NewLine +
             "Summary: " + IssueFields.summary + Environment.NewLine +
             "Status: " + IssueFields.status.name
             );
      }

      #endregion
      #region TMobileSpecific
      private void ProcessTMobile_INFUOPS()
      {

         string JSONOutput = txtJSONOutput.Text.ToString();

         DebugOutput("In ProcessTMobile");
         if (ExecutionURI.Text.ToString().IndexOf("/issue/") == -1)
         {
            DebugOutput("Non-Issue Process");
            jTMobile = TMobile_INFUOPS_Interface.ProcessINFUOP(this, ExecutionURI.Text.ToString(), JSONOutput);
            if (jTMobile != null && jTMobile.issues != null)
            {
               numValues.Minimum = 1;
               numValues.Maximum = jTMobile.issues.Count();
               MaximumRecords.Text = numValues.Maximum.ToString();
               numValues.Enabled = true;
               bRecord.Enabled = true;
            }
            else
               DebugOutput("No Records Returned");
         }
         else
         {
            TMobile_INFUOPS_Schema.Issue jSingleIssue;
            DebugOutput("Single Issue, deserializing");
            jSingleIssue = TMobile_INFUOPS_Interface.DeserializeJSONINFUOPSingle(this, JSONOutput);
            if (jSingleIssue != null)
            {
               DebugOutput("Completed. Displaying");
               DisplayTMobile_INFUOPS_Record(jSingleIssue);
            }
            else
               DebugOutput("No Records Returned");


         }
      }

      private void DisplayTMobile_INFUOPS_Record(TMobile_INFUOPS_Schema.Issue result)
      {
         TMobile_INFUOPS_Schema.Fields IssueFields = result.fields;
         TMobile_INFUOPS_Schema.Changelog ChangeLog = result.changelog;

         string ENL = Environment.NewLine;
         string dOutput = string.Empty;

         dOutput =
             "Key: " + result.key + Environment.NewLine +
             "ID: " + result.id + Environment.NewLine +
             "Issue Type: " + IssueFields.issuetype.name + Environment.NewLine +
             "Summary: " + IssueFields.summary + Environment.NewLine +
             "Status: " + IssueFields.status.name + ENL +
             "History Records: " + ChangeLog.total + ENL;

         foreach (TMobile_INFUOPS_Schema.History history in ChangeLog.histories)
         {
            foreach (TMobile_INFUOPS_Schema.Item item in history.items)
            {
               if (item.field == "Expected Unblocked Date")
                  dOutput += "Expected Unblocked Date: " + item.toString + ENL;
            }
         }



         DeserializedOutput(dOutput);
      }

      #endregion

      // Regardless of the target, all will execute a standard JSON Request
      private void ExecuteJSONRequest(string TargetURI)
      {
         try
         {
            ResetFormFieldsForRequest();
            DebugOutput("Calling Rest Interface");

            JSONOutput(String.Empty);

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


   }

}
