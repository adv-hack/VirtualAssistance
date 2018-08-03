using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;

namespace BotConsensus.Util
{
    [Serializable]
    public class RestApiUtil
    {
        #region Properties

        private readonly string _serverUrl;

        #endregion

        #region Constructor
        public RestApiUtil()
        {
            _serverUrl = "http://a5e42f25.ngrok.io/V7ChatBot";
        }

        #endregion

        #region Public Methods        

        /// <summary>
        /// Gets response from server
        /// </summary>
        /// <param name="api"></param>
        /// <returns></returns>
        public async Task<string> GetResponseFromServer(string api)
        {
            var url = _serverUrl + "" + api;
            WebRequest request = WebRequest.Create(url);
            request.Method = "GET";

            // Get the response.
            var response2 = await request.GetResponseAsync();
            // Get the stream containing content returned by the server.
            Stream dataStream = response2.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            return responseFromServer;
        }

        #endregion

    }
}