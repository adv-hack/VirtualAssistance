using Consensus.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Web.Script.Serialization;

namespace Consensus.Finance
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="DirectDebitModel" /> object.
    /// </summary>
    public partial class LocalDirectDebitFactory
    {
        /// <summary>
        /// Validates account number and sort code. If valid returns bank details
        /// </summary>
        /// <param name="accountNumber">Account number</param>
        /// <param name="sortCode">Sort code</param>
        /// <returns>Returns bank details if account number and sort code is valid else returns error message</returns>
        public AfdResponse AfdBankFinderAccountNumberValidation(string accountNumber, string sortCode)
        {
            var sysConfigList = this.Provider.DataProvider.Common.SysConfig.FetchAll();

            //AFD Url
            var afdUrl = sysConfigList.FirstOrDefault(x => x.KeyName == "SC_AFDAnywhereFind").CharValue;
            //AFD Serial Number
            var serialNo = sysConfigList.FirstOrDefault(x => x.KeyName == "SC_AFD_USERNAME").CharValue;
            //AFD Password
            var password = sysConfigList.FirstOrDefault(x => x.KeyName == "SC_AFD_KEY").CharValue;

            string apiForAccountNumberValidation = afdUrl + "?Serial=" + serialNo + "&Password=" + password + "&UserID=MyApp&Data=Bank&Task=Account&Fields=Account&Format=JSON&SortCode=" + sortCode + "&AccountNumber=" + accountNumber;

            var afdResponseForAccountNumberValidation = GetResponseFromAfdApi(apiForAccountNumberValidation);

            if (afdResponseForAccountNumberValidation != null)
            {
                //Account number is valid
                if (Convert.ToInt32(afdResponseForAccountNumberValidation.Result) > 0)
                {
                    //Api call for fetching bank details
                    string apiForFetchingBankDetails = afdUrl + "?Serial=" + serialNo + "&Password=" + password + "&UserID=MyApp&Data=Bank&Task=FastFind&Fields=Standard&CallBack=JSON&Lookup=" + sortCode;
                    var afdResponseForBankDetails = GetResponseFromAfdApi(apiForFetchingBankDetails);
                    if (afdResponseForBankDetails != null)
                    {
                        //Returns bank details
                        return afdResponseForBankDetails;
                    }
                }
                else
                {
                    //Returns error message
                    return afdResponseForAccountNumberValidation;
                }
            }
            return null;            
        }

        /// <summary>
        /// Gets response from AFD api
        /// </summary>
        /// <param name="api">Api for AFD</param>
        /// <returns>Response from AFD api</returns>
        public AfdResponse GetResponseFromAfdApi(string api)
        {
            WebRequest request = WebRequest.Create(api);
            request.Method = "GET";

            // Get the response.
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();

            //Checks if response contains JSON
            if (responseFromServer.IndexOf("JSON") > -1)
            {
                string prefix = "JSON";
                if (Regex.IsMatch(responseFromServer, "^" + prefix))
                {
                    responseFromServer = responseFromServer.Remove(0, prefix.Length + 1);
                    responseFromServer = responseFromServer.Substring(0, responseFromServer.Length - 2);
                }
            }
            
            var serializer = new JavaScriptSerializer();
            var afdResponse = serializer.Deserialize<AfdResponse>(responseFromServer);
            return afdResponse;
        }

    }

}
