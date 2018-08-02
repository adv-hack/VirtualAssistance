using BotConsensus.Model;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;

namespace BotConsensus.Dialogs
{
    [Serializable]
    public class DonationFirstDialog : IDialog<object>
    {
        string firstName;
        string lastName;
        string email;
        string phone;
        string plandetails;
        string donationType;
        string donationAmount;
        string serverUrl = "http://brd-conse-vm1/v7chatbot";
        string donationUrl = "";

        public enum DonationType
        {
            HomeLess,
            Orphanage,
            Charity,
            EndowmentFunds
        }

        public enum BooleanChoice { Yes, No }

        public DonationFirstDialog(string plan)
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

        /*
         * Thank you. Your donation will be 100% Tax deductible
         * 
            What's your name?  -- input

            How much would you like to donate?
            10
            30
            50
            100
            More than 100 


            $10 will help us buy food for a 2-3 people for one day
            button- Happy to help  -- no input

            Can you share your email address? We don't spam -- input validate email

            Would you like to subscribe to our email updates on how your donations are helping the people?
            button Yes,NO  -- no input

            Are you interested in being a volunteer for fund raising?
            button Yes,NO  -- no input

            Okay. Thank you for your valuable time

         * */

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

            string api = serverUrl + "/rest/learning/product/FetchDonationProduct";
            var responseFromServer = await GetResponseFromServer(api);

            var serializer = new JavaScriptSerializer();
            var donationProductList = serializer.Deserialize<List<DonationProduct>>(responseFromServer);
            var donationList = donationProductList.Select(x => x.Name).ToList();

            PromptDialog.Choice(context, ChildDialogComplete, donationProductList.Select(x => x.Id), "What type of donation you want to do?", "Selected plan not available. Please try again.", 3, PromptStyle.Auto, donationProductList.Select(x => x.Name));

        }

        public async Task ChildDialogComplete(IDialogContext context, IAwaitable<String> response)
        {
            var message = await response;
            donationType = message.ToString();
            List<string> amountList = new List<string>() { "10", "50", "100", "1000" };

            PromptDialog.Choice(
             context: context,
             resume: ResumeGetDonationAmount,
              options: amountList,
             prompt: "How much amount would you like to donate?",
             retry: "Selected plan not available. Please try again.",
             promptStyle: PromptStyle.Auto
             );
        }

        private async Task ResumeGetDonationAmount(IDialogContext context, IAwaitable<object> result)
        {
            var response = await result;
            donationAmount = response.ToString();

            string api = serverUrl + "/rest/learning/product/CreateDonationProduct?personName=" + firstName + "&surname=" + lastName + "&email=" + email + "&phone=" + phone + "&price=" + donationType + "&productId=" + donationType;

            var responseFromServer = await GetResponseFromServer(api);

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

        public async Task CashType(IDialogContext context, IAwaitable<String> response)
        {

            await context.PostAsync("Thank you so much for your kindness. Donation added successfully. Please click following " + serverUrl + "" + donationUrl + " link to check the details. Cheers!!!!!");

            context.Done(this);
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

    }
}