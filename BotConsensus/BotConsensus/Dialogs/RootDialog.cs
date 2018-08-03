using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using System.Collections.Generic;
using BotConsensus.Util;

namespace BotConsensus.Dialogs
{
    [Serializable]
    public class RootDialog : IDialog<object>
    {

        #region Properties

        private RestApiUtil _restApiUtil;
        DonationFirstDialog donationFirstDialog;

        #endregion

        #region Constructor

        public RootDialog()
        {
            _restApiUtil = new RestApiUtil();
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Starts conversation with Welcome card
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public async Task StartAsync(IDialogContext context)
        {
            var message = context.MakeMessage();
            var attachment = WelcomeCard();
            message.Attachments.Add(attachment);
            await context.PostAsync(message);

            // Show the list of plan
            context.Wait(this.ShowOptions);
        }

        /// <summary>
        /// Shows the option of functionality Bot offers
        /// </summary>
        /// <param name="context"></param>
        /// <param name="activity"></param>
        /// <returns></returns>
        public virtual async Task ShowOptions(IDialogContext context, IAwaitable<IMessageActivity> activity)
        {
            var message = await activity;

            PromptDialog.Choice(
               context: context,
               resume: ChoiceReceivedAsync,
               options: (IEnumerable<AdvanceOptions>)Enum.GetValues(typeof(AdvanceOptions)),
               prompt: "Hi User! I'm a consensus chatbot. I can help you with Donations or Courses. You can always go back to first step by sending 'Reset' keyword as a response. Please select how do you like us to serve from below options? ",
               retry: "Selected option not available. Please try again.",
               promptStyle: PromptStyle.Auto
               );
        }

        /// <summary>
        /// Processes depending on Option selected
        /// </summary>
        /// <param name="context"></param>
        /// <param name="activity"></param>
        /// <returns></returns>
        public virtual async Task ChoiceReceivedAsync(IDialogContext context, IAwaitable<AdvanceOptions> activity)
        {
            AdvanceOptions response = await activity;
            if (response == AdvanceOptions.Donation)
            {
                donationFirstDialog = new DonationFirstDialog(response.ToString());
                context.Call<object>(donationFirstDialog, ChildDialogComplete);
            }
            else
                context.Call<object>(new CourseFirstDialog(response.ToString()), CourseCompleteDialog);
        }

        #endregion

        #region Completion Dialogs

        /// <summary>
        /// Completion dialog for Donation
        /// </summary>
        /// <param name="context"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        public virtual async Task ChildDialogComplete(IDialogContext context, IAwaitable<object> response)
        {
            var message = context.MakeMessage();
            var count = donationFirstDialog.donationUrl.Length - 29;
            var donationId = donationFirstDialog.donationUrl.Substring(29, count);
            var donationUrl = _restApiUtil.ServerUrl + "" + donationFirstDialog.donationUrl;
            var attachment = ThankYouCard(donationUrl, donationId);
            message.Attachments.Add(attachment);
            await context.PostAsync(message);
            context.EndConversation(EndOfConversationCodes.CompletedSuccessfully);
        }

        /// <summary>
        /// Completion dialog for Course
        /// </summary>
        /// <param name="context"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        public virtual async Task CourseCompleteDialog(IDialogContext context, IAwaitable<object> response)
        {
            await context.PostAsync("Thanks for your interest. Our team will get back to you soon!!!");
            context.EndConversation(EndOfConversationCodes.CompletedSuccessfully);
        }

        #endregion

        #region Enums for Options

        /// <summary>
        /// Options Bot offers
        /// </summary>
        public enum AdvanceOptions
        {
            Donation,
            Courses,
        }

        #endregion

        #region Hero cards

        /// <summary>
        /// Design Title with Image and About US link
        /// </summary>
        /// <returns></returns>
        private static Attachment WelcomeCard()
        {
            var heroCard = new HeroCard
            {
                Title = "HackOverflow 2018",
                Subtitle = "VADODARA, 2 - 3 AUGUST 2018",
                Text = "Welcome to HackOverflow 2018 ! Here we present Virtual Assistant for Consensus.",
                Images = new List<CardImage> { new CardImage("https://www.oneadvanced.com/siteassets/images/backgrounds/jumbotron-example-bg.jpg") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "About US", value: "https://www.oneadvanced.com/") }
            };

            return heroCard.ToAttachment();
        }

        /// <summary>
        /// Thank you messgage for Donation received
        /// </summary>
        /// <returns></returns>
        private static Attachment ThankYouCard(string donationUrl, string donationId)
        {

            var heroCard = new HeroCard
            {
                Title = "Thank you so much for your kindness.",
                Subtitle = "",
                Text = "Please click on the following link to get the details of your donation. Cheers!!!",
                Images = new List<CardImage> { new CardImage("https://a5e42f25.ngrok.io/V7ChatBot/thankyou.png") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "Your Donation!", value: donationUrl) }
            };

            return heroCard.ToAttachment();
        }

        #endregion

    }
}