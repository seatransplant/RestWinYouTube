using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestWinYouTube
{
    static class RestInterface
    {
        public static string MakeJSONRequest(string RequestURI, AuthenticationType aType, AuthenticationTechnique aTech, string _UserName, string _Password)
        {
            string sResponse = string.Empty;
            try
            {
                RestClient rClient = new RestClient();

                rClient.EndPoint = RequestURI;
                rClient.AuthType = aType;
                rClient.AuthTech = aTech;
                rClient.UserName = _UserName;
                rClient.UserPassword = _Password;

                System.Diagnostics.Debug.Write("Calling Object");
                sResponse = rClient.MakeRequest();

                System.Diagnostics.Debug.Write("Call Completed Successfully");
            }
            catch (Exception ex)
            {
                sResponse = ex.Message;
                System.Diagnostics.Debug.Write("Call Failed: " + sResponse);
                throw ex;
            }

            return sResponse;
        }
    }
}
