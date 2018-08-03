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

namespace BotConsensus.Dialogs
{
    [Serializable]
    public class CourseFirstDialog : IDialog<object>
    {
        #region Properties

        private RestApiUtil _restApiUtil;

        public string plandetails;

        public string courseType;

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
            var response = await activity;
            if (response.Equals(BooleanChoice.Yes))
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
                context.Done(this);
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
            PriceList.AppendLine("\nBelow are the different price packs for your course:");
            foreach (CourseProductPrice price in pricelist)
            {
                PriceList.AppendLine("\nPack: " + price.ListName + "\nPrice: £ " + Math.Round(price.UnitPrice, 2));
            }


            await context.PostAsync("Here are the details of the course for you: \nStart Date: " + (!String.IsNullOrEmpty(startDate) ? startDate : "Not specified") + " \nCourse Duration(days) :" + CourseLength + PriceList.ToString());

            context.Done(this);
        }

        #endregion
    }
}