using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Web.Script.Serialization;
using BotConsensus.Model;
using System.Text;

namespace BotConsensus.Dialogs
{
    [Serializable]
    [Serializable]
    public class CourseFirstDialog : IDialog<object>
    {
        string plandetails;
        private readonly string serverUrl = "http://a5e42f25.ngrok.io/V7ChatBot";
        string courseType;

        public enum BooleanChoice { Yes, No }

        public CourseFirstDialog(string plan)
        {
            plandetails = plan;
        }

        public async Task StartAsync(IDialogContext context)
        {
            await context.PostAsync("Thank you for selecting " + plandetails + " option");

            PromptDialog.Choice(
               context: context,
               resume: MessageReceivedAsync,
               options: (IEnumerable<BooleanChoice>)Enum.GetValues(typeof(BooleanChoice)),
               prompt: "Can i help you with list of courses we offer? ",
               retry: "Please try again.",
               promptStyle: PromptStyle.Auto
           );
        }

        public virtual async Task MessageReceivedAsync(IDialogContext context, IAwaitable<BooleanChoice> activity)
        {
            var response = await activity;
            if (response.Equals(BooleanChoice.Yes))
            {

                string api = serverUrl + "/rest/learning/product/FetchCourseProduct";
                var responseFromServer = await GetResponseFromServer(api);

                var serializer = new JavaScriptSerializer();
                var courseProductList = serializer.Deserialize<List<CourseProduct>>(responseFromServer);
                var courseList = courseProductList.Select(x => x.Name).ToList();

                PromptDialog.Choice(context, ChildDialogComplete, courseProductList.Select(x => x.Name), "What course are you interested to inquire for?", "Selected course not available. Please try again.", 3, PromptStyle.Auto, courseProductList.Select(x => x.Name));
            }
            else
            {
                context.Done(this);
            }
        }

        public async Task<string> GetResponseFromServer(string api)
        {
            WebRequest request = WebRequest.Create(api);
            request.Method = "GET";

            // If required by the server, set the credentials.

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

        public async Task ChildDialogComplete(IDialogContext context, IAwaitable<String> response)
        {
            string complete = await response;
            courseType = complete;
            StringBuilder PriceList = new StringBuilder();
            string api = serverUrl + "/rest/learning/product/FetchCourseProduct";
            var responseFromServer = await GetResponseFromServer(api);

            var serializer = new JavaScriptSerializer();
            var courseProductList = serializer.Deserialize<List<CourseProduct>>(responseFromServer);

            var startDate = courseProductList.FirstOrDefault(x => x.Name == courseType).EntryDate;
            var CourseLength = courseProductList.FirstOrDefault(x => x.Name == courseType).CourseLength;

            var pricelist = courseProductList.FirstOrDefault(x => x.Name == courseType).PriceList;
            PriceList.AppendLine("\nBelow are the different price packs for your course:");
            foreach (CourseProductPrice price in pricelist)
            {
                PriceList.AppendLine("\nPack: " + price.ListName + "\nPrice($): " + Math.Round(price.UnitPrice, 2));
            }


            await context.PostAsync("Here are the details of the course for you: \nStart Date: " + (!String.IsNullOrEmpty(startDate) ? startDate : "Not specified") + " \nCourse Duration(days) :" + CourseLength + PriceList.ToString());

            context.Done(this);
        }


    }
}