using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using System.Collections.Generic;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using Newtonsoft.Json.Linq;

namespace MyFirstBot.Dialogs
{
    [Serializable]
    public class RootDialog : IDialog<object>
    {
        public async Task StartAsync(IDialogContext context)
        {
            //Show the title with background image and Details
            var message = context.MakeMessage();
            var attachment = GetHeroCard();
            message.Attachments.Add(attachment);
            await context.PostAsync(message);

            // Show the list of plan
            context.Wait(this.ShowOptions);
            //context.Wait(NewMessageReceivedAsync);

            //return Task.CompletedTask;
        }


        public virtual async Task ShowOptions(IDialogContext context, IAwaitable<IMessageActivity> activity)
        {
            var message = await activity;

            WebRequest request = WebRequest.Create("http://10.33.16.55/rest/finance/account?id=1");
            request.Method = "GET";

            request.UseDefaultCredentials = true;
            request.PreAuthenticate = true;
            // If required by the server, set the credentials.

            // Get the response.
            HttpWebResponse response2 = (HttpWebResponse)request.GetResponse();
            // Get the stream containing content returned by the server.
            Stream dataStream = response2.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Display the content.
            var serializer = new JavaScriptSerializer();
            var res = serializer.DeserializeObject(responseFromServer);
            var jVaue = JValue.Parse(responseFromServer);
            var obj = JObject.Parse(responseFromServer);

            PromptDialog.Choice(
                context: context,
                resume: ChoiceReceivedAsync,
                options: (IEnumerable<AdvanceOptions>)Enum.GetValues(typeof(AdvanceOptions)),
                prompt: "Hi. Please Select Options",
                retry: "Selected Option not avilabel . Please try again.",
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

        private Task NewMessageReceivedAsync(IDialogContext context, IAwaitable<object> result)
        {
            PromptDialog.Text(context, NameEntered, @"Hi! What's your name?");
            return Task.CompletedTask;
        }

        private async Task MessageReceivedAsync(IDialogContext context, IAwaitable<object> result)
        {
            var activity = await result as Activity;

            // calculate something for us to return
            int length = (activity.Text ?? string.Empty).Length;

            string activityText = activity.Text.ToLower();
            // return our reply to the user
            //await context.PostAsync($"You sent {activity.Text} which was {length} characters");
            if (activityText.Contains("morning"))
            {
                await context.PostAsync("Good Morning , Have a nice Day");
            }   //test      
            else if (activityText.Contains("night"))
            {
                await context.PostAsync("Good night and Sweetest Dreams");
            }
            else if (activityText.Contains("who are you"))
            {
                await context.PostAsync("I am a Bot created by Advanced");
            }
            else if (activityText.Contains("date"))
            {
                await context.PostAsync(DateTime.Now.ToString());
            }
            else
            {

                await context.PostAsync($"You sent {activity.Text} which was {length} characters");

            }

            context.Wait(MessageReceivedAsync);
        }

        private async Task NameEntered(IDialogContext context, IAwaitable<object> result)
        {
            await context.PostAsync($@"Hi {await result}!");

            context.Wait(MessageReceivedAsync);
        }
    }
}