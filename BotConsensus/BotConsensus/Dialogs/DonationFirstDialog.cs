using BotConsensus.Model;
using BotConsensus.Util;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;

namespace BotConsensus.Dialogs
{
    [Serializable]
    public class DonationFirstDialog : IDialog<object>
    {

        #region Properties

        private RestApiUtil _restApiUtil;
        string firstName;
        string lastName;
        string email;
        string phone;
        private string plandetails;
        string donationType;
        string donationAmount;
        string donationUrl = "";

        public enum DonationType
        {
            HomeLess,
            Orphanage,
            Charity,
            EndowmentFunds
        }

        public enum BooleanChoice { Yes, No }

        #endregion

        #region Constructor

        public DonationFirstDialog(string plan)
        {
            plandetails = plan;
            _restApiUtil = new RestApiUtil();
        }

        #endregion

        #region Public Methods        

        /// <summary>
        /// Starts Donation process 
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
               prompt: "Amazing! Your contribution will help a lot of people. We need some basic information to process your donation. Shall we get started?",
               retry: "Please try again.",
               promptStyle: PromptStyle.Auto
           );
        }

        /// <summary>
        /// If Donation is selected then will continue with the flow
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
                            prompt: "What's your first name?",
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

        /// <summary>
        /// Gets first name
        /// </summary>
        /// <param name="context"></param>
        /// <param name="Username"></param>
        /// <returns></returns>
        public virtual async Task ResumeGetFirstName(IDialogContext context, IAwaitable<string> username)
        {
            string response = await username;
            firstName = response; ;
            if (firstName.Equals("reset", StringComparison.InvariantCultureIgnoreCase))
            {
                context.EndConversation("End");
            }
            else
            {
                PromptDialog.Text(
                context: context,
                resume: ResumeGetLastName,
                prompt: "What's your last name?",
                retry: "Sorry, I didn't understand that. Please try again."
            );
            }
        }

        /// <summary>
        /// Gets last name
        /// </summary>
        /// <param name="context"></param>
        /// <param name="surname"></param>
        /// <returns></returns>
       	public virtual async Task ResumeGetLastName(IDialogContext context, IAwaitable<string> surname)
        {
            string response = await surname;
            lastName = response;
            if (lastName.Equals("reset", StringComparison.InvariantCultureIgnoreCase))
            {
                context.EndConversation("End");
            }
            else
            {
                PromptDialog.Text(
                context: context,
                resume: ResumeGetEmail,
                prompt: "Can you share your email address? We don't spam",
                retry: "Sorry, I didn't understand that. Please try again."
            );
            }
        }

        /// <summary>
        /// Gets email
        /// </summary>
        /// <param name="context"></param>
        /// <param name="UserEmail"></param>
        /// <returns></returns>
        public virtual async Task ResumeGetEmail(IDialogContext context, IAwaitable<string> UserEmail)
        {
            string response = await UserEmail;
            email = response;

            if (email.Equals("reset", StringComparison.InvariantCultureIgnoreCase))
            {
                context.EndConversation("End");
            }
            else if (Regex.IsMatch(email, @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"))
            {
                PromptDialog.Text(
               context: context,
               resume: ResumeGetPhone,
               prompt: "Please share your contact number",
               retry: "Sorry, I didn't understand that. Please try again.");
            }
            else
            {
                PromptDialog.Text(
               context: context,
               resume: ResumeGetEmail,
               prompt: "Kindly provide valid email address? We don't spam",
               retry: "Sorry, I didn't understand that. Please try again."
           );
            }
        }

        /// <summary>
        /// Gets phone
        /// </summary>
        /// <param name="context"></param>
        /// <param name="mobile"></param>
        /// <returns></returns>
        public async Task ResumeGetPhone(IDialogContext context, IAwaitable<string> mobile)
        {
            string response = await mobile;
            phone = response;
            if (phone.Equals("reset", StringComparison.InvariantCultureIgnoreCase))
            {
                context.EndConversation("End");
            }
            else if (Regex.IsMatch(phone, @"^+\d[0-9]"))
            {
                string api = "/rest/learning/product/FetchDonationProduct";
                var responseFromServer = await _restApiUtil.GetResponseFromServer(api);

                var serializer = new JavaScriptSerializer();
                var donationProductList = serializer.Deserialize<List<DonationProduct>>(responseFromServer);
                var donationList = donationProductList.Select(x => x.Name).ToList();

                PromptDialog.Choice(context, ChildDialogComplete, donationProductList.Select(x => x.Id), "We have number of donation options where you can make real difference. Please Select.", "Selected donation not available. Please try again.", 3, PromptStyle.Auto, donationProductList.Select(x => x.Name));
            }
            else
            {
                PromptDialog.Text(
                context: context,
                resume: ResumeGetPhone,
                prompt: "Kindly share valid contact number",
                retry: "Sorry, I didn't understand that. Please try again."
            );
            }

        }

        /// <summary>
        /// Gets donation amount
        /// </summary>
        /// <param name="context"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        public async Task ChildDialogComplete(IDialogContext context, IAwaitable<String> response)
        {
            var message = await response;
            donationType = message.ToString();
            if (donationType.Equals("reset", StringComparison.InvariantCultureIgnoreCase))
            {
                context.EndConversation("End");
            }
            else
            { 
                List<string> amountList = new List<string>() { "£ 10", "£ 50", "£ 100", "£ 1000" };

                PromptDialog.Choice(
                 context: context,
                 resume: ResumeGetDonationAmount,
                  options: amountList,
                 prompt: "How much amount would you like to donate?",
                 retry: "Selected amount not available. Please try again.",
                 promptStyle: PromptStyle.Auto
                 );
            }
        }

        /// <summary>
        /// Creates new donation for that user
        /// </summary>
        /// <param name="context"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        private async Task ResumeGetDonationAmount(IDialogContext context, IAwaitable<object> result)
        {
            var response = await result;
            donationAmount = response.ToString().Remove(0, 2);
            if (donationAmount.Equals("reset", StringComparison.InvariantCultureIgnoreCase))
            {
                context.EndConversation("End");
            }
            else
            {
                string api = "/rest/learning/product/CreateDonationProduct?personName=" + firstName + "&surname=" + lastName + "&email=" + email + "&phone=" + phone + "&price=" + donationAmount + "&productId=" + donationType;

                var responseFromServer = await _restApiUtil.GetResponseFromServer(api);

                var serializer = new JavaScriptSerializer();
                donationUrl = serializer.Deserialize<string>(responseFromServer);

                List<string> cashOptions = new List<string>() { "Cash", "Cheque", "Credit card", "Debit card", "Net banking", "Wallets" };
                PromptDialog.Choice(
                 context: context,
                 resume: CashType,
                  options: cashOptions,
                 prompt: "How would you like to donate?",
                 retry: "Selected plan not available . Please try again.",
                 promptStyle: PromptStyle.Auto
                 );
            }
        }

        /// <summary>
        /// Determins how would person like to donate
        /// </summary>
        /// <param name="context"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        public async Task CashType(IDialogContext context, IAwaitable<String> response)
        {
            await context.PostAsync("Thank you so much for your kindness. Donation added successfully. Please click following " + _restApiUtil.ServerUrl + "" + donationUrl + " link to check the details. Cheers !!!");
            context.Done(this);
        }

        #endregion

    }
}