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
using BotConsensus.Util;
using System.Text.RegularExpressions;

namespace BotConsensus.Dialogs
{
    [Serializable]
    public class CourseFirstDialog : IDialog<object>
    {
        #region Properties

        private RestApiUtil _restApiUtil;

        public string plandetails;

        public string courseType;

        public string firstName;
        public enum BooleanChoice { Yes, No }

        #endregion

        #region Constructor

        public CourseFirstDialog(string plan)
        {
            plandetails = plan;
            _restApiUtil = new RestApiUtil();
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Starts flow of fetching course details
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Fetches course details
        /// </summary>
        /// <param name="context"></param>
        /// <param name="activity"></param>
        /// <returns></returns>
        public virtual async Task MessageReceivedAsync(IDialogContext context, IAwaitable<BooleanChoice> activity)
        {
            try
            {
                var response = await activity;
                if (response.Equals(BooleanChoice.Yes))
                {
                    PromptDialog.Text(
                            context: context,
                            resume: ResumeGetFirstName,
                            prompt: "Sure. May I have your contact number or email address ?",
                            retry: "Sorry, I didn't understand that. Please try again."
                        );
                }
                else
                {
                    await context.PostAsync("Thanks for your valuable time !!!");
                    context.EndConversation(EndOfConversationCodes.CompletedSuccessfully);
                }
            }
            catch
            {
                await context.PostAsync("Thanks for your valuable time !!!");
                context.EndConversation(EndOfConversationCodes.CompletedSuccessfully);
            }
        }
        public virtual async Task ResumeGetFirstName(IDialogContext context, IAwaitable<string> Username)
        {
            string response = await Username;
            firstName = response;
            if (firstName.Equals("reset", StringComparison.InvariantCultureIgnoreCase))
            {
                context.EndConversation("End");
            }
            else if ((Regex.IsMatch(firstName, @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")) || (Regex.IsMatch(firstName, @"^[0][1-9]\d{9}$|^[1-9]\d{9}$")))
            {
                string api = "/rest/learning/product/FetchCourseProduct";
                var responseFromServer = await _restApiUtil.GetResponseFromServer(api);

                var serializer = new JavaScriptSerializer();
                var courseProductList = serializer.Deserialize<List<CourseProduct>>(responseFromServer);
                var courseList = courseProductList.Select(x => x.Name).ToList();

                PromptDialog.Choice(context, ChildDialogComplete, courseProductList.Select(x => x.Name), "What course are you interested to inquire for?", "Selected course not available. Please try again.", 3, PromptStyle.Auto, courseProductList.Select(x => x.Name));
            }
            else
            {
                PromptDialog.Text(
                            context: context,
                            resume: ResumeGetFirstName,
                            prompt: "Kindly share valid email address or contact number",
                            retry: "Sorry, I didn't understand that. Please try again."
                        );
            }
        }

        /// <summary>
        /// Displays selected course detail
        /// </summary>
        /// <param name="context"></param>
        /// <param name="response"></param>
        /// <returns></returns>

        public async Task ChildDialogComplete(IDialogContext context, IAwaitable<String> response)
        {
            string complete = await response;
            courseType = complete;
            StringBuilder PriceList = new StringBuilder();
            string api = "/rest/learning/product/FetchCourseProduct";
            var responseFromServer = await _restApiUtil.GetResponseFromServer(api);

            var serializer = new JavaScriptSerializer();
            var courseProductList = serializer.Deserialize<List<CourseProduct>>(responseFromServer);

            var startDate = courseProductList.FirstOrDefault(x => x.Name == courseType).EntryDate;
            var CourseLength = courseProductList.FirstOrDefault(x => x.Name == courseType).CourseLength;

            var pricelist = courseProductList.FirstOrDefault(x => x.Name == courseType).PriceList;
            
            foreach (CourseProductPrice price in pricelist)
            {
                PriceList.AppendLine(", Pack: " + price.ListName + " and Price: £ " + Math.Round(price.UnitPrice, 2));
                break;
            }            

            var heroCard = new HeroCard
            {
                Title = courseType +" details.",
                Subtitle = "Below are the different price packs and other details for this course:",
                Text = "Start Date: " + (!String.IsNullOrEmpty(startDate) ? startDate : "Not specified") + ", Course Duration (days): " + CourseLength + PriceList.ToString()                                
            };

            var message = context.MakeMessage();
            message.TextFormat = "xml";                  
            message.Attachments.Add(heroCard.ToAttachment());            
            await context.PostAsync(message);


            PromptDialog.Choice(
             context: context,
             resume: CourseLastStep,
             options: (IEnumerable<BooleanChoice>)Enum.GetValues(typeof(BooleanChoice)),
             prompt: "\n\nWould you like to go ahead and get further assistance on enrolling into this course? ",
             retry: "Please try again.",
             promptStyle: PromptStyle.Auto
         );
        }

        public async Task CourseLastStep(IDialogContext context, IAwaitable<BooleanChoice> activity)
        {
            try
            {
                var response = await activity;
                if (response.Equals(BooleanChoice.Yes))
                {
                    context.Done(this);
                }
                else
                {
                    await context.PostAsync("Thanks for your valuable time. I would be glad to help you if you might be interested for enrollment in future !!!");
                    context.EndConversation(EndOfConversationCodes.CompletedSuccessfully);
                }
            }
            catch
            {
                await context.PostAsync("Thanks for your valuable time !!!");
                context.EndConversation(EndOfConversationCodes.CompletedSuccessfully);
            }
        }

        #endregion
    }
}