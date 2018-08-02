using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using System.Collections.Generic;

namespace BotConsensus.Dialogs
{
    [Serializable]
    public class RootDialog : IDialog<object>
    {
        public async Task StartAsync(IDialogContext context)
        {
            var message = context.MakeMessage();
            var attachment = WelcomeCard();
            message.Attachments.Add(attachment);
            await context.PostAsync(message);
            // Show the list of plan
            context.Wait(this.ShowOptions);
        }

        public virtual async Task ShowOptions(IDialogContext context, IAwaitable<IMessageActivity> activity)
        {
            var message = await activity;

            PromptDialog.Choice(
               context: context,
               resume: ChoiceReceivedAsync,
               options: (IEnumerable<AdvanceOptions>)Enum.GetValues(typeof(AdvanceOptions)),
               prompt: "Hi, Please Select Option",
               retry: "Selected Option not available . Please try again.",
               promptStyle: PromptStyle.Auto
               );
        }

        /// <summary>
        /// Design Title with Image and About US link
        /// </summary>
        /// <returns></returns>
        private static Attachment ThankYouCard()
        {
            var heroCard = new HeroCard
            {
                Title = "Thank you",
                Subtitle = "",
                Text = "Thank you for the donation",
                Images = new List<CardImage> { new CardImage(System.Web.HttpContext.Current.Server.MapPath(@"~\\Image\\Donation Image.png")) },
                //Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "About US", value: "https://www.oneadvanced.com/") }
            };

            return heroCard.ToAttachment();
        }

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
        public virtual async Task ChoiceReceivedAsync(IDialogContext context, IAwaitable<AdvanceOptions> activity)
        {
            AdvanceOptions response = await activity;
            if (response == AdvanceOptions.Donation)
                context.Call<object>(new DonationFirstDialog(response.ToString()), ChildDialogComplete);
            else
                context.Call<object>(new CourseFirstDialog(response.ToString()), ChildDialogComplete);

        }
        public virtual async Task ChildDialogComplete(IDialogContext context, IAwaitable<object> response)
        {
            var message = context.MakeMessage();
            var attachment = ThankYouCard();
            message.Attachments.Add(attachment);
            await context.PostAsync(message);
            //await context.PostAsync("Thanks !!!");
            context.EndConversation(EndOfConversationCodes.CompletedSuccessfully);
            //context.Done(this);
        }

        public enum AdvanceOptions
        {
            Donation,
            Courses,
        }
    }
}