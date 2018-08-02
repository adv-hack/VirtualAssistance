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
            var attachment = GetHeroCard();
            message.Attachments.Add(attachment);
            await context.PostAsync(message);

            // Show the list of plan
            context.Wait(this.MessageReceivedAsync);

            //context.Wait(MessageReceivedAsync);

            //return Task.CompletedTask;
        }

        private async Task MessageReceivedAsync(IDialogContext context, IAwaitable<object> result)
        {
            var activity = await result as Activity;

            PromptDialog.Choice(
               context: context,
               resume: ChoiceReceivedAsync,
               options: (IEnumerable<AdvanceOptions>)Enum.GetValues(typeof(AdvanceOptions)),
               prompt: "Hi. Please Select Options",
               retry: "Selected Option not avilabel . Please try again.",
               promptStyle: PromptStyle.Auto
               );


            // Calculate something for us to return
            int length = (activity.Text ?? string.Empty).Length;

            // Return our reply to the user
            await context.PostAsync($"You sent {activity.Text} which was {length} characters");

            context.Wait(MessageReceivedAsync);
        }

        /// <summary>
        /// Design Title with Image and About US link
        /// </summary>
        /// <returns></returns>
        private static Attachment GetHeroCard()
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
            context.Call<object>(new DonationFirstDialog(response.ToString()), ChildDialogComplete);

        }
        public virtual async Task ChildDialogComplete(IDialogContext context, IAwaitable<object> response)
        {
            await context.PostAsync("Thanks !!!");
            context.Done(this);
        }

        public enum AdvanceOptions
        {
            Donation,
            Courses,
        }
    }
}