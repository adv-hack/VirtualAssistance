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
        private static Attachment GetHeroCard()
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

        public virtual async Task ChoiceReceivedAsync(IDialogContext context, IAwaitable<AdvanceOptions> activity)
        {
            AdvanceOptions response = await activity;
            context.Call<object>(new DonationFirstDialog(response.ToString()), ChildDialogComplete);

        }
        public virtual async Task ChildDialogComplete(IDialogContext context, IAwaitable<object> response)
        {
            var message = context.MakeMessage();
            var attachment = GetHeroCard();
            message.Attachments.Add(attachment);
            await context.PostAsync(message);
            //await context.PostAsync("Thanks !!!");
            context.Done(this);
        }

        public enum AdvanceOptions
        {
            Donation,
            Courses,
        }
    }
}