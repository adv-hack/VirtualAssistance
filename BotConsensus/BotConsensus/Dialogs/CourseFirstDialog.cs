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

namespace BotConsensus.Dialogs
{
    [Serializable]
    public class CourseFirstDialog : IDialog<object>
    {
        string firstName;
        string lastName;
        string email;
        string phone;
        string plandetails;
        string serverUrl = "http://brd-conse-vm1/v7chatbot";
        string courseType;
        string donationAmount;

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
               prompt: "Can I Help you for Registration ? ",
               retry: "Please try again.",
               promptStyle: PromptStyle.Auto
           );
        }

        public virtual async Task MessageReceivedAsync(IDialogContext context, IAwaitable<BooleanChoice> activity)
        {
            var response = await activity;
            if (response.Equals(BooleanChoice.Yes))
            {
                PromptDialog.Text(
                    context: context,
                    resume: ResumeGetName,
                    prompt: "Please share your good name",
                    retry: "Sorry, I didn't understand that. Please try again."
                );
            }
            else
            {
                context.Done(this);
            }
        }

        public virtual async Task ResumeGetName(IDialogContext context, IAwaitable<string> Username)
        {
            string response = await Username;
            firstName = response; ;

            PromptDialog.Text(
                context: context,
                resume: ResumeGetLastName,
                prompt: "Please share your Last Name",
                retry: "Sorry, I didn't understand that. Please try again."
            );
        }

        public virtual async Task ResumeGetLastName(IDialogContext context, IAwaitable<string> surname)
        {
            string response = await surname;
            lastName = response;

            PromptDialog.Text(
                context: context,
                resume: ResumeGetEmail,
                prompt: "Please share your Email Id",
                retry: "Sorry, I didn't understand that. Please try again."
            );
        }

        public virtual async Task ResumeGetEmail(IDialogContext context, IAwaitable<string> UserEmail)
        {
            string response = await UserEmail;
            email = response;

            PromptDialog.Text(
                context: context,
                resume: ResumeGetPhone,
                prompt: "Please share your Mobile Number",
                retry: "Sorry, I didn't understand that. Please try again."
            );
        }
        public async Task ResumeGetPhone(IDialogContext context, IAwaitable<string> mobile)
        {

            string response = await mobile;
            phone = response;

            string api = serverUrl + "/rest/learning/product/FetchCourseProduct";
            var responseFromServer = await GetResponseFromServer(api);

            var serializer = new JavaScriptSerializer();
            var courseProductList = serializer.Deserialize<List<CourseProduct>>(responseFromServer);
            var courseList = courseProductList.Select(x => x.Name).ToList();

            PromptDialog.Choice(context, ChildDialogComplete, courseProductList.Select(x => x.Name), "What course are you interested to inquire for?", "Selected course not available. Please try again.", 3, PromptStyle.Auto, courseProductList.Select(x => x.Name));
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

            string api = serverUrl + "/rest/learning/product/FetchCourseProduct";
            var responseFromServer = await GetResponseFromServer(api);

            var serializer = new JavaScriptSerializer();
            var courseProductList = serializer.Deserialize<List<CourseProduct>>(responseFromServer);

            var startDate = courseProductList.FirstOrDefault(x => x.Name == courseType).EntryDate;
            var CourseLength = courseProductList.FirstOrDefault(x => x.Name == courseType).CourseLength;

            await context.PostAsync("Here are the details of the course for you: Start Date:" + (!String.IsNullOrEmpty(startDate) ? startDate : "Not specified" )+ " Course Duration(days) :" + CourseLength);
            context.Done(this);
        }


    }
}